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

        public List<SimpleLabel> AchievementLabelList { get; protected set; }

        public AchievementTrackerComponent(LiveSplitState state)
        {
            AchievementLabelList = new List<SimpleLabel>();

            //Should be based on how many achievements are set to be tracked in the 
            for(int i = 0; i<9; i++)
            {
                AchievementLabelList.Add(new SimpleLabel());
            }
        }

        public string ComponentName => "Momodora Achievement Tracker";

        public float HorizontalWidth => 30;

        public float MinimumHeight => 10;

        public float VerticalHeight => 30;

        public float MinimumWidth => 10;

        public float PaddingTop => 5f;

        public float PaddingBottom => 5f;

        public float PaddingLeft => 5f;

        public float PaddingRight => 5f;

        public IDictionary<string, Action> ContextMenuControls => null;

        public void Dispose()
        {
                GC.SuppressFinalize(this);
        }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
     
        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
            
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
            
        }
    }
}
