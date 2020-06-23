using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveSplit.UI.Components
{
    partial class AchievementTrackerComponentSettings : UserControl
    {
        public Color inProgressColor { get; set; }
        public Color failedColor { get; set; }
        public Color completedColor { get; set; }
        private ColorDialog inProgressColorPicker;
        private ColorDialog failedColorPicker;
        private ColorDialog completedColorPicker;


        public AchievementTrackerComponentSettings()
        {
            InitializeComponent();

            inProgressColorPicker = new ColorDialog();
            failedColorPicker = new ColorDialog();
            completedColorPicker = new ColorDialog();
        }


        #region Label Color
        private void overrideLabelCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelOutlineBtn_Click(object sender, EventArgs e)
        {

        }

        private void labelTextBtn_Click(object sender, EventArgs e)
        {

        }

        private void labelShadowsBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Values Color
        private void overrideValueCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void valuesOutlinesBtn_Click(object sender, EventArgs e)
        {

        }

        private void valuesTextBtn_Click(object sender, EventArgs e)
        {

        }

        private void valuesShadowBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Achievement Colors
        private void achievementColorCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void colorLabelsCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void colorValuesCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void progressColorBtn_Click(object sender, EventArgs e)
        {
            if (inProgressColorPicker.ShowDialog() == DialogResult.OK)
            {
                progressColorBtn.BackColor = inProgressColorPicker.Color;
                inProgressColor = inProgressColorPicker.Color;
            }
        }

        private void failedColorBtn_Click(object sender, EventArgs e)
        {
            if (failedColorPicker.ShowDialog() == DialogResult.OK)
            {
                failedColorBtn.BackColor = failedColorPicker.Color;
                failedColor = failedColorPicker.Color;
            }
        }

        private void completedColorBtn_Click(object sender, EventArgs e)
        {
            if (completedColorPicker.ShowDialog() == DialogResult.OK)
            {
                completedColorBtn.BackColor = completedColorPicker.Color;
                completedColor = completedColorPicker.Color;
            }
        }
        #endregion
    }
}
