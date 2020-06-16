using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.Model;

namespace LiveSplit.UI.Components
{
    class AchievementTrackerComponentFactory : IComponentFactory
    {
        public string ComponentName => "Momodora Achievement Tracker";

        public string Description => "Displays status of achievements for the current Momodora file";

        public ComponentCategory Category => ComponentCategory.Information;

        public string UpdateName => ComponentName;

        public string XMLURL => UpdateURL + "MomodoraAchievementTracker/MomodoraAchievementTracker/update.MomodoraAchievementTracker.xml";

        public string UpdateURL => "https://raw.githubusercontent.com/axelkarlsson/AchievementTrackerComponent/master/";

        public Version Version => Version.Parse("1.0.0");

        public IComponent Create(LiveSplitState state)
        {
            return new AchievementTrackerComponent(state);
        }
    }
}
