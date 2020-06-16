using System;
using System.Collections.Generic;
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

        public AchievementTrackerComponent(LiveSplitState state)
        {
            AchievementLabelList = new List<SimpleLabel>();
            InternalComponent = new AchievementTrackerInternalComponent("Test", "Double test");

            //Should be based on how many achievements are set to be tracked in the 
            for (int i = 0; i < 9; i++)
            {
                AchievementLabelList.Add(new SimpleLabel());
            }
        }

        public string ComponentName => "Momodora Achievement Tracker";

        public float HorizontalWidth => InternalComponent.HorizontalWidth;

        public float MinimumHeight => InternalComponent.MinimumHeight;

        public float VerticalHeight => 10;

        public float MinimumWidth => InternalComponent.MinimumWidth;

        public float PaddingTop => 1;

        public float PaddingBottom => 1;

        public float PaddingLeft => InternalComponent.PaddingLeft;

        public float PaddingRight => InternalComponent.PaddingRight;

        public IDictionary<string, Action> ContextMenuControls => null;

        public void Dispose()
        {
        }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
            InternalComponent.DrawVertical(g, state, height, clipRegion);
        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
            InternalComponent.DrawVertical(g, state, width, clipRegion);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            return null;
        }

        public Control GetSettingsControl(LayoutMode mode)
        {
            return null;
        }

        public void SetSettings(XmlNode settings)
        {

        }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            InternalComponent.InformationName = "Test1";
            InternalComponent.InformationValue = "Test2";
            InternalComponent.LongestString = "Test1".Length > "Test2".Length
                ? "Test1"
                : "Test2";

            InternalComponent.Update(invalidator, state, width, height, mode);
        }
    }
}
