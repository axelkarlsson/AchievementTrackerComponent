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
        public AchievementTrackerComponentFactory()
        {
        }

        public string ComponentName => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public ComponentCategory Category => throw new NotImplementedException();

        public string UpdateName => throw new NotImplementedException();

        public string XMLURL => throw new NotImplementedException();

        public string UpdateURL => throw new NotImplementedException();

        public Version Version => throw new NotImplementedException();

        public IComponent Create(LiveSplitState state)
        {
            throw new NotImplementedException();
        }
    }
}
