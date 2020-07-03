﻿using System;
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
        private AchievementTrackerComponentSettings settingsControl;

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
            AchievementLabelList[9].Text = "Bug Collector";
            AchievementLabelList[11].Text = "Choir";
            AchievementLabelList[13].Text = "Vitality Fragments";
            AchievementLabelList[15].Text = "Difficulty";
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

            settingsControl = new AchievementTrackerComponentSettings();
        }


        private void onStart(object sender, EventArgs e)
        {
            if (VerifyProcessRunning())
            {
                activeSlot = saveSlotPointer.Deref<double>(gameProc);
            }
            completedAchievements.Clear();
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

   
        //Read values regarding achievements from memory and update the display
        public void UpdateTrackers()
        {
            //Add a check for in game
            if (VerifyProcessRunning() && (activeSlot == 10 || activeSlot == saveSlotPointer.Deref<double>(gameProc))) // && levelId thingy need to get pointer and compare to main menu
            {
                //0 good, 1+ bad
                if(deathsPointer.Deref<double>(gameProc) == 0)
                {
                    AchievementLabelList[0].Text = "Deathless";
                    SetTextColor(0, settingsControl.completedColor);
                }
                else
                {
                    AchievementLabelList[0].Text = "Not Deathless";
                    SetTextColor(0, settingsControl.failedColor);
                    //AchievementLabelList[0].ForeColor = <SETTING_FAILED_COLOUR>
                }

                //0 good, 1+ bad
                if (commonEnemiesKilledPointer.Deref<double>(gameProc) == 0)
                {
                    AchievementLabelList[2].Text = "Pacifist";
                    SetTextColor(2, settingsControl.completedColor);
                }
                else
                {
                    AchievementLabelList[2].Text = "Murderer";
                    SetTextColor(2, settingsControl.failedColor);
                }

                if (!completedAchievements.Contains(AchievementLabelList[5].Text))
                {
                    double roomsVisited = roomsVisitedPointer.Deref<double>(gameProc);
                    //454 Done
                    AchievementLabelList[4].Text = (roomsVisited == 454) ? "Explored" : String.Format("{0}/454", roomsVisited);
                    if (roomsVisited == 454)
                    {
                        completedAchievements.Add(AchievementLabelList[5].Text);
                        AchievementLabelList[4].Text = "Explored";
                        SetTextColor(4, settingsControl.completedColor);
                    }
                    else
                    {
                        AchievementLabelList[4].Text = String.Format("{0}/454", roomsVisited);
                        SetTextColor(4, settingsControl.inProgressColor);
                    }
                }

                //1 done
                if (!completedAchievements.Contains(AchievementLabelList[7].Text))
                {

                    double shroomDelivered = shroomDeliveredPointer.Deref<double>(gameProc);
                    if (shroomDelivered == 1)
                    {
                        completedAchievements.Add(AchievementLabelList[7].Text);
                        AchievementLabelList[6].Text = "Delivered";
                        SetTextColor(6, settingsControl.completedColor);
                    }
                    else
                    {
                        AchievementLabelList[6].Text = (shroomFoundPointer.Deref<double>(gameProc) == 1) ? "Not Delivered" : "Not Found";
                        SetTextColor(6, settingsControl.inProgressColor);
                    }
                }


                if (!completedAchievements.Contains(AchievementLabelList[9].Text))
                {
                    //1 done in BugsDelivered, BugCount is how many are collected
                    double bugsDelivered = bugsDeliveredPointer.Deref<double>(gameProc);
                    if (bugsDelivered == 1)
                    {
                        completedAchievements.Add(AchievementLabelList[9].Text);
                        AchievementLabelList[8].Text = "Delivered";
                        SetTextColor(8, settingsControl.completedColor);
                    }
                    else
                    {
                        AchievementLabelList[8].Text = String.Format("{0}/20", bugCountPointer.Deref<double>(gameProc));
                        SetTextColor(8, settingsControl.inProgressColor);
                    }
                }

                if (!completedAchievements.Contains(AchievementLabelList[11].Text))
                {
                    //1 done
                    double choir = choirPointer.Deref<double>(gameProc);
                    if (choir == 1)
                    {
                        completedAchievements.Add(AchievementLabelList[11].Text);
                        AchievementLabelList[10].Text = "Killed";
                        SetTextColor(10, settingsControl.completedColor);
                    }
                    else
                    {
                        AchievementLabelList[10].Text = "Alive";
                        SetTextColor(10, settingsControl.inProgressColor);
                    }
                }

                if (!completedAchievements.Contains(AchievementLabelList[13].Text))
                {
                    //17 is done, tracks maxhealth and insane starts with 1 so max health is 18, -1 means 17 fragments
                    double maxHealth = maxHealthPointer.Deref<double>(gameProc);
                    if (maxHealth == 18)
                    {
                        completedAchievements.Add(AchievementLabelList[13].Text);
                        SetTextColor(12, settingsControl.completedColor);
                    }
                    else
                    {
                        SetTextColor(12, settingsControl.inProgressColor);
                    }
                    AchievementLabelList[12].Text = String.Format("{0}/17", maxHealth - 1);
                }

                if(diccifultyPointer.Deref<double>(gameProc) == 4)
                {
                    AchievementLabelList[14].Text = "Insane";
                    SetTextColor(14, settingsControl.completedColor);
                }
                else
                {
                    AchievementLabelList[14].Text = "Not insane";
                    SetTextColor(14, settingsControl.failedColor);
                }

                if (greenLeafPointer.Deref<double>(gameProc) == 1)
                {
                    AchievementLabelList[16].Text = "True End";
                    SetTextColor(16, settingsControl.completedColor);
                }
                else
                {
                    AchievementLabelList[16].Text = "Normal End";
                    SetTextColor(16, settingsControl.inProgressColor);
                }
            }
        }


        private void SetTextColor(int index, Color achievementColor)
        {
            AchievementLabelList[index].ForeColor = settingsControl.doColorValues ? achievementColor : (settingsControl.valueColorOverride ? settingsControl.valueTextColor : state.LayoutSettings.TextColor);
            AchievementLabelList[index + 1].ForeColor = settingsControl.doColorLabels ? achievementColor : (settingsControl.labelColorOverride ? settingsControl.labelTextColor : state.LayoutSettings.TextColor);
        }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
            throw new NotImplementedException();
        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {

            var textHeight = g.MeasureString("A", state.LayoutSettings.TextFont).Height;
            VerticalHeight = textHeight * 9;

            //i are for values, i+1 are the labels
            for (int i = 0; i < 18; i += 2)
            {
                //Text Color should be moved to somewhere where I can check achievement progress as well
                AchievementLabelList[i].ShadowColor = settingsControl.valueColorOverride ? settingsControl.valueShadowColor : state.LayoutSettings.ShadowsColor;
                AchievementLabelList[i].OutlineColor = settingsControl.valueColorOverride ? settingsControl.valueOutlineColor : state.LayoutSettings.TextOutlineColor;
                AchievementLabelList[i + 1].ShadowColor = settingsControl.labelColorOverride ? settingsControl.labelShadowColor : state.LayoutSettings.ShadowsColor;
                AchievementLabelList[i + 1].OutlineColor = settingsControl.labelColorOverride ? settingsControl.labelOutlineColor : state.LayoutSettings.TextOutlineColor;

                AchievementLabelList[i + 1].SetActualWidth(g);
                AchievementLabelList[i].SetActualWidth(g);

                AchievementLabelList[i].Width = AchievementLabelList[i].ActualWidth;
                AchievementLabelList[i].Height = VerticalHeight;
                AchievementLabelList[i].X = width - AchievementLabelList[i].ActualWidth;
                AchievementLabelList[i].Y = i*textHeight*0.42f - (3.5f * textHeight);

                //Changing to width here seemed to solve the issue of some text not fully displaying
                AchievementLabelList[i + 1].Width = width; //AchievementLabelList[i + 1].ActualWidth;
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
            return settingsControl;
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
