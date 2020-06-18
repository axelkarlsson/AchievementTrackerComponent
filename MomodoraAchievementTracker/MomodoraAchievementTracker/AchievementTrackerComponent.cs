using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.Model;

namespace LiveSplit.UI.Components
{
    public class AchievementTrackerComponent : IComponent
    {
        public AchievementTrackerInternalComponent InternalComponent { get; set; }
        public List<SimpleLabel> AchievementLabelList { get; protected set; }
        public LiveSplitState state;

        public AchievementTrackerComponent(LiveSplitState state)
        {
            AchievementLabelList = new List<SimpleLabel>();
            InternalComponent = new AchievementTrackerInternalComponent("Test", "Double test");
            //Should be based on how many achievements are set to be tracked in the thing
            //2 labels each, 1 for achievement name, 1 for status 9 total for now
            this.state = state;
            for (int i = 0; i < 18; i++)
            {

                AchievementLabelList.Add(new SimpleLabel(i % 2 == 1 ? "Super test" : "Other thing"));
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
        }

        public string ComponentName => "Momodora Achievement Tracker";

        public float HorizontalWidth { get; set; }

        public float MinimumHeight => InternalComponent.MinimumHeight;

        public float VerticalHeight { get; set; }

        public float MinimumWidth => 200;

        public float PaddingTop => 1;

        public float PaddingBottom => 1;

        public float PaddingLeft => InternalComponent.PaddingLeft;

        public float PaddingRight => InternalComponent.PaddingRight;

        public IDictionary<string, Action> ContextMenuControls => null;

        public void Dispose()
        {
        }

        public void UpdateTrackers(double deaths, double roomsVisited, double commonEnemiesKilled, double difficulty, double bugsDelivered, double shroomDelivered, double greenLeaf, double maxHealth, double choir, double bugCount, double shroomFound)
        {
            //0 good, 1+ bad
            AchievementLabelList[0].Text = (deaths == 0) ? "Deathless" : "Not Deathless";
	        //0 good, 1+ bad
		    AchievementLabelList[2].Text = (commonEnemiesKilled == 0) ? "Pacifist" : "Murderer";
		    //454 Done
			//if (roomsVisited == 454) { vars.achievedDict[name] = true; }
            AchievementLabelList[4].Text = (roomsVisited == 454) ? "Explored" : String.Format("{0}/454", roomsVisited);
		    //1 done
			//if (current.ShroomDelivered == 1) { vars.achievedDict[name] = true; }
            AchievementLabelList[6].Text = (shroomDelivered == 1) ? "Delivered" : ((shroomFound == 1) ? "Not Delivered" : "Not Found");
			//if (bugsDelivered == 1) { vars.achievedDict[name] = true; }
            //1 done in BugsDelivered, BugCount is how many are collected
            AchievementLabelList[8].Text = (bugsDelivered == 1) ? "Delivered" : String.Format("{0}/20", bugCount);
		    //1 done
     		//if (choir == 1) { vars.achievedDict[name] = true; }
            AchievementLabelList[10].Text = (choir == 1) ? "Killed" : "Alive";
			//if (maxHealth == 18) { vars.achievedDict[name] = true; }
            //17 is done, tracks maxhealth and insane starts with 1 so max health is 18, -1 means 17 fragments
            AchievementLabelList[12].Text = String.Format("{0}/17", maxHealth - 1);
		    AchievementLabelList[14].Text = (difficulty == 4) ? "Insane" : "Not insane";
		    AchievementLabelList[16].Text = (greenLeaf == 1) ? "True End" : "Normal End";
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

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            if (invalidator != null)
            {
                invalidator.Invalidate(0, 0, width, height);
            }
        }
    }
}
