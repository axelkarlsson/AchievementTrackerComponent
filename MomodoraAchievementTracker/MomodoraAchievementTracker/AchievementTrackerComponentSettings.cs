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
        public bool useAchievementColor { get; set; }
        public bool doColorValues { get; set; }
        public bool doColorLabels { get; set; }
        public Color inProgressColor { get; set; }
        public Color failedColor { get; set; }
        public Color completedColor { get; set; }

        public bool valueColorOverride { get; set; }
        public Color valueOutlineColor { get; set; }
        public Color valueShadowColor { get; set; }
        public Color valueTextColor { get; set; }

        public bool labelColorOverride { get; set; }
        public Color labelOutlineColor { get; set; }
        public Color labelShadowColor { get; set; }
        public Color labelTextColor { get; set; }

        

        private ColorDialog colorPicker;


        public AchievementTrackerComponentSettings()
        {
            InitializeComponent();

            colorPicker = new ColorDialog();
            useAchievementColor = false;
            doColorValues = false;
            doColorLabels = false;
            valueColorOverride = false;
            labelColorOverride = false;
            inProgressColor = Color.FromArgb(255, 155, 55);
            completedColor = Color.FromArgb(10, 255, 10);
            failedColor = Color.FromArgb(255, 10, 10);

            labelOutlineBtn.DataBindings.Add("BackColor", this, "labelOutlineColor", false, DataSourceUpdateMode.OnPropertyChanged);
            labelShadowsBtn.DataBindings.Add("BackColor", this, "labelShadowColor", false, DataSourceUpdateMode.OnPropertyChanged);
            labelTextBtn.DataBindings.Add("BackColor", this, "labelTextColor", false, DataSourceUpdateMode.OnPropertyChanged);
            overrideLabelCheckbox.DataBindings.Add("Checked", this, "labelColorOverride", false, DataSourceUpdateMode.OnPropertyChanged);

            valuesOutlinesBtn.DataBindings.Add("BackColor", this, "valueOutlineColor", false, DataSourceUpdateMode.OnPropertyChanged);
            valuesShadowBtn.DataBindings.Add("BackColor", this, "valueShadowColor", false, DataSourceUpdateMode.OnPropertyChanged);
            valuesTextBtn.DataBindings.Add("BackColor", this, "valueTextColor", false, DataSourceUpdateMode.OnPropertyChanged);
            overrideValueCheckbox.DataBindings.Add("Checked", this, "valueColorOverride", false, DataSourceUpdateMode.OnPropertyChanged);

            progressColorBtn.DataBindings.Add("BackColor", this, "inProgressColor", false, DataSourceUpdateMode.OnPropertyChanged);
            failedColorBtn.DataBindings.Add("BackColor", this, "failedColor",false, DataSourceUpdateMode.OnPropertyChanged);
            completedColorBtn.DataBindings.Add("BackColor", this, "completedColor",false, DataSourceUpdateMode.OnPropertyChanged);
            achievementColorCheckbox.DataBindings.Add("Checked", this, "useAchievementColor", false, DataSourceUpdateMode.OnPropertyChanged);
            colorLabelsCheckbox.DataBindings.Add("Checked", this, "doColorLabels", false, DataSourceUpdateMode.OnPropertyChanged);
            colorValuesCheckbox.DataBindings.Add("Checked", this, "doColorValues", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void AchievementTrackerComponentSettings_Load(object sender, EventArgs e)
        {
            overrideLabelCheckbox_CheckedChanged(null, null);
            overrideValueCheckbox_CheckedChanged(null, null);
            colorLabelsCheckbox_CheckedChanged(null, null);
            colorValuesCheckbox_CheckedChanged(null, null);
            achievementColorCheckbox_CheckedChanged(null, null);
        }

        #region Label Color
        private void overrideLabelCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            label7.Enabled = label8.Enabled = label9.Enabled = labelOutlineBtn.Enabled = labelShadowsBtn.Enabled = labelTextBtn.Enabled = overrideLabelCheckbox.Checked;
        }

        private void labelOutlineBtn_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                labelOutlineColor = colorPicker.Color;
            }
        }

        private void labelTextBtn_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                labelTextColor = colorPicker.Color;
            }
        }

        private void labelShadowsBtn_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                labelShadowColor = colorPicker.Color;
            }
        }
        #endregion

        #region Values Color
        private void overrideValueCheckbox_CheckedChanged(object sender, EventArgs e)
        {
             label4.Enabled = label5.Enabled = label6.Enabled = valuesOutlinesBtn.Enabled = valuesShadowBtn.Enabled = valuesTextBtn.Enabled = overrideValueCheckbox.Checked;
        }

        private void valuesOutlinesBtn_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                valueOutlineColor = colorPicker.Color;
            }
        }

        private void valuesTextBtn_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                valueTextColor = colorPicker.Color;
            }
        }

        private void valuesShadowBtn_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                valueShadowColor = colorPicker.Color;
            }
        }
        #endregion

        #region Achievement Colors
        private void achievementColorCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            colorValuesCheckbox.Checked = false;
            colorLabelsCheckbox.Checked = false;
            colorValuesCheckbox.Enabled = colorLabelsCheckbox.Enabled = label1.Enabled = label2.Enabled = label3.Enabled = progressColorBtn.Enabled = failedColorBtn.Enabled = completedColorBtn.Enabled = achievementColorCheckbox.Checked;
            
        }

        private void colorLabelsCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void colorValuesCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void progressColorBtn_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                inProgressColor = colorPicker.Color;
            }
        }

        private void failedColorBtn_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                failedColor = colorPicker.Color;
            }
        }

        private void completedColorBtn_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                completedColor = colorPicker.Color;
            }
        }
        #endregion
    }
}
