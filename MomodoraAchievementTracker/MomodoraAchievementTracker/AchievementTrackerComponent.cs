using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.ComponentUtil;
using LiveSplit.Model;


namespace LiveSplit.UI.Components
{
    public class AchievementTrackerComponent : IComponent
    {
        public List<SimpleLabel> AchievementLabelList { get; protected set; }
        public LiveSplitState state;
        private Process gameProc = null;
        private double activeSlot = 10;
        private HashSet<String> completedAchievements;

        DeepPointer deathsPointer;
        DeepPointer roomsVisitedPointer;
        DeepPointer commonEnemiesKilledPointer;
        DeepPointer diccifultyPointer;
        DeepPointer bugsDeliveredPointer;
        DeepPointer shroomDeliveredPointer;
        DeepPointer greenLeafPointer;
        DeepPointer maxHealthPointer;
        DeepPointer choirPointer;
        DeepPointer bugCountPointer;
        DeepPointer saveSlotPointer;
        DeepPointer shroomFoundPointer;


        public AchievementTrackerComponent(LiveSplitState state)
        {
            AchievementLabelList = new List<SimpleLabel>();
            state.OnStart += onStart;
            state.OnReset += onReset;
            this.state = state;
            for (int i = 0; i < 18; i++)
            {
                AchievementLabelList.Add(new SimpleLabel(i % 2 == 1 ? "Achievement" : "Value"));
            }
            AchievementLabelList[1].Text = "Deathless";
            AchievementLabelList[3].Text = "Pacifist";
            AchievementLabelList[5].Text = "Explorer";
            AchievementLabelList[7].Text = "Shroom";
            AchievementLabelList[9].Text = "Bugs Delivered";
            AchievementLabelList[11].Text = "Choir";
            AchievementLabelList[13].Text = "Vitality Fragments";
            AchievementLabelList[15].Text = "Insane Difficulty";
            AchievementLabelList[17].Text = "True End";

            completedAchievements = new HashSet<string>();

            deathsPointer = new DeepPointer(0x02304CE8, new int[] { 0x4, 0x540 });
            roomsVisitedPointer = new DeepPointer(0x02304CE8, new int[] { 0x4, 0x870 });
            commonEnemiesKilledPointer = new DeepPointer(0x02304CE8, new int[] { 0x4, 0x60, 0x4, 0x4, 0x490 });
            diccifultyPointer = new DeepPointer(0x0230C440, new int[] { 0x0, 0x4, 0x60, 0x4, 0x4, 0x630 });
            bugsDeliveredPointer = new DeepPointer(0x230C440, new int[] { 0x0, 0x4, 0x60, 0x4, 0x4, 0x7C0 });
            shroomDeliveredPointer = new DeepPointer(0x02304CE8, new int[] { 0x4, 0x60, 0x4, 0x4, 0x500 });
            greenLeafPointer = new DeepPointer(0x230C440, new int[] { 0x0, 0x4, 0x60, 0x4, 0x4, 0x600 });
            maxHealthPointer = new DeepPointer(0x02304CE8, new int[] { 0x4, 0xA0 });
            choirPointer = new DeepPointer(0x230C440, new int[] { 0x0, 0x4, 0x60, 0x4, 0x4, 0x6A0 });
            bugCountPointer = new DeepPointer(0x230C440, new int[] { 0x0, 0x4, 0x60, 0x4, 0x4, 0x3C0 });
            saveSlotPointer = new DeepPointer(0x230C440, new int[] { 0x0, 0x4, 0x60, 0x4, 0x4, 0xFA0 });
            shroomFoundPointer = new DeepPointer(0x230C440, new int[] { 0x0, 0x4, 0x60, 0x4, 0x4, 0x480 });
        }


        private void onStart(object sender, EventArgs e)
        {
            if (VerifyProcessRunning())
            {
                activeSlot = saveSlotPointer.Deref<double>(gameProc);
            }
            completedAchievements.Clear();

            //Lock to slot, reset completed achievements
        }

        private void onReset(object sender, TimerPhase value)
        {
            activeSlot = 10;
        }


        public string ComponentName => "Momodora Achievement Tracker";

        public float HorizontalWidth { get; set; }

        public float MinimumHeight => 10;

        public float VerticalHeight { get; set; }

        public float MinimumWidth => 200;

        public float PaddingTop => 1;

        public float PaddingBottom => 1;

        public float PaddingLeft => 1;

        public float PaddingRight => 1;

        public IDictionary<string, Action> ContextMenuControls => null;

        public void Dispose()
        {
        }

        public void UpdateTrackers()
        {
            if (VerifyProcessRunning() && (activeSlot == 10 || activeSlot == saveSlotPointer.Deref<double>(gameProc)))
            {
                //0 good, 1+ bad
                AchievementLabelList[0].Text = (deathsPointer.Deref<double>(gameProc) == 0) ? "Deathless" : "Not Deathless";

                //0 good, 1+ bad
                AchievementLabelList[2].Text = (commonEnemiesKilledPointer.Deref<double>(gameProc) == 0) ? "Pacifist" : "Murderer";

                if (completedAchievements.Contains(AchievementLabelList[3].Text))
                {
                    double roomsVisited = roomsVisitedPointer.Deref<double>(gameProc);
                    //454 Done
                    if (roomsVisited == 454)
                    {
                        completedAchievements.Add(AchievementLabelList[3].Text);
                    }
                    AchievementLabelList[4].Text = (roomsVisited == 454) ? "Explored" : String.Format("{0}/454", roomsVisited);
                }

                //1 done
                if (completedAchievements.Contains(AchievementLabelList[7].Text))
                {

                    double shroomDelivered = shroomDeliveredPointer.Deref<double>(gameProc);
                    if (shroomDelivered == 1)
                    {
                        completedAchievements.Add(AchievementLabelList[7].Text);
                    }

                    AchievementLabelList[6].Text = (shroomDelivered == 1) ? "Delivered" : ((shroomFoundPointer.Deref<double>(gameProc) == 1) ? "Not Delivered" : "Not Found");
                }


                if (completedAchievements.Contains(AchievementLabelList[9].Text))
                {
                    //1 done in BugsDelivered, BugCount is how many are collected
                    double bugsDelivered = bugsDeliveredPointer.Deref<double>(gameProc);
                    if (bugsDelivered == 1)
                    {
                        completedAchievements.Add(AchievementLabelList[9].Text);
                    }
                    AchievementLabelList[8].Text = (bugsDelivered == 1) ? "Delivered" : String.Format("{0}/20", bugCountPointer.Deref<double>(gameProc));
                }

                if (completedAchievements.Contains(AchievementLabelList[11].Text))
                {
                    //1 done
                    double choir = choirPointer.Deref<double>(gameProc);
                    if (choir == 1)
                    {
                        completedAchievements.Add(AchievementLabelList[11].Text);
                    }
                    AchievementLabelList[10].Text = (choir == 1) ? "Killed" : "Alive";
                }

                if (completedAchievements.Contains(AchievementLabelList[9].Text))
                {
                    //17 is done, tracks maxhealth and insane starts with 1 so max health is 18, -1 means 17 fragments
                    double maxHealth = maxHealthPointer.Deref<double>(gameProc);
                    if (maxHealth == 18)
                    {
                        completedAchievements.Add(AchievementLabelList[13].Text);

                    }
                    AchievementLabelList[12].Text = String.Format("{0}/17", maxHealth - 1);
                }

                AchievementLabelList[14].Text = (diccifultyPointer.Deref<double>(gameProc) == 4) ? "Insane" : "Not insane";

                AchievementLabelList[16].Text = (greenLeafPointer.Deref<double>(gameProc) == 1) ? "True End" : "Normal End";
            }
        }


        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
            throw new NotImplementedException();
        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {

            var textHeight = 0.7f * Math.Max(g.MeasureString("A", AchievementLabelList[1].Font).Height, g.MeasureString("A", AchievementLabelList[0].Font).Height);
            VerticalHeight = (textHeight * 9) * 0.9f;
            for (int i = 0; i < 18; i += 2)
            {
                AchievementLabelList[i].ShadowColor = state.LayoutSettings.ShadowsColor;
                AchievementLabelList[i].OutlineColor = state.LayoutSettings.TextOutlineColor;
                AchievementLabelList[i].ForeColor = state.LayoutSettings.TextColor;
                AchievementLabelList[i + 1].ShadowColor = state.LayoutSettings.ShadowsColor;
                AchievementLabelList[i + 1].OutlineColor = state.LayoutSettings.TextOutlineColor;
                AchievementLabelList[i + 1].ForeColor = state.LayoutSettings.TextColor;

                AchievementLabelList[i + 1].SetActualWidth(g);
                AchievementLabelList[i].SetActualWidth(g);

                AchievementLabelList[i].Width = width;
                AchievementLabelList[i].Height = VerticalHeight;
                //AchievementLabelWidth needs to be scaled or another width that is not the layout width needs to be used as base
                AchievementLabelList[i].X = 0;
                AchievementLabelList[i].Y = i*textHeight*0.42f - (3.5f * textHeight);
 
                AchievementLabelList[i + 1].Width = AchievementLabelList[i + 1].ActualWidth;
                AchievementLabelList[i + 1].Height = VerticalHeight;
                AchievementLabelList[i + 1].Y = i*textHeight * 0.42f - (3.5f * textHeight);
                AchievementLabelList[i + 1].X = 0;

                PrepareDraw(state, LayoutMode.Vertical, i);

                AchievementLabelList[i].Draw(g);
                AchievementLabelList[i + 1].Draw(g);
            }
          
        }

        public void PrepareDraw(LiveSplitState state, LayoutMode mode, int i) {
            AchievementLabelList[i + 1].Font = state.LayoutSettings.TextFont;
            AchievementLabelList[i].Font = state.LayoutSettings.TextFont;
            if (mode == LayoutMode.Vertical)
            {
                AchievementLabelList[i].VerticalAlignment = StringAlignment.Center;
                AchievementLabelList[i].HorizontalAlignment = StringAlignment.Far;
                AchievementLabelList[i + 1].VerticalAlignment = StringAlignment.Center;
            }
            else
            {
                AchievementLabelList[i].VerticalAlignment = StringAlignment.Near;
                AchievementLabelList[i + 1].VerticalAlignment = StringAlignment.Far;
            }
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            return parent;
        }

        public Control GetSettingsControl(LayoutMode mode)
        {
            return new Control();
        }

        public void SetSettings(XmlNode settings)
        {

        }

 

        private bool VerifyProcessRunning()
        {
            if(gameProc != null && !gameProc.HasExited)
            {
                return true;
            }
            Process[] game = Process.GetProcessesByName("MomodoraRUtM");
            if (game.Length > 0)
            {
                gameProc = game[0];
                return true;
            }
            return false;
        }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            UpdateTrackers();

            if (invalidator != null)
            {
                invalidator.Invalidate(0, 0, width, height);
            }
        }
    }
}
