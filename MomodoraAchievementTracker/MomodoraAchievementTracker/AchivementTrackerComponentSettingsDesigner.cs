using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveSplit.UI.Components
{
    partial class AchievementTrackerComponentSettings : UserControl
    {
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox overrideLabelCheckbox;
        private CheckBox overrideValueCheckbox;
        private CheckBox achievementColorCheckbox;
        private GroupBox labelColorGroup;
        private GroupBox valueColorGroup;
        private GroupBox achievementColorGroup;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label7;
        private Button labelOutlineBtn;
        private Label label8;
        private Button labelTextBtn;
        private Label label9;
        private Button labelShadowsBtn;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label4;
        private Button valuesOutlinesBtn;
        private Label label6;
        private Button valuesTextBtn;
        private Label label5;
        private Button valuesShadowBtn;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckBox colorLabelsCheckbox;
        private CheckBox colorValuesCheckbox;
        private Button progressColorBtn;
        private Button failedColorBtn;
        private Button completedColorBtn;
        private Label label1;
        private Label label2;
        private Label label3;


        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.overrideLabelCheckbox = new System.Windows.Forms.CheckBox();
            this.overrideValueCheckbox = new System.Windows.Forms.CheckBox();
            this.achievementColorCheckbox = new System.Windows.Forms.CheckBox();
            this.labelColorGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.labelOutlineBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTextBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.labelShadowsBtn = new System.Windows.Forms.Button();
            this.valueColorGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.valuesOutlinesBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.valuesTextBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.valuesShadowBtn = new System.Windows.Forms.Button();
            this.achievementColorGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.colorLabelsCheckbox = new System.Windows.Forms.CheckBox();
            this.colorValuesCheckbox = new System.Windows.Forms.CheckBox();
            this.progressColorBtn = new System.Windows.Forms.Button();
            this.failedColorBtn = new System.Windows.Forms.Button();
            this.completedColorBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.labelColorGroup.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.valueColorGroup.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.achievementColorGroup.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.overrideLabelCheckbox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.overrideValueCheckbox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.achievementColorCheckbox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelColorGroup, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.valueColorGroup, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.achievementColorGroup, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(446, 371);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // overrideLabelCheckbox
            // 
            this.overrideLabelCheckbox.AutoSize = true;
            this.overrideLabelCheckbox.Location = new System.Drawing.Point(3, 3);
            this.overrideLabelCheckbox.Name = "overrideLabelCheckbox";
            this.overrideLabelCheckbox.Size = new System.Drawing.Size(142, 17);
            this.overrideLabelCheckbox.TabIndex = 0;
            this.overrideLabelCheckbox.Text = "Override Layout Settings";
            this.overrideLabelCheckbox.UseVisualStyleBackColor = true;
            this.overrideLabelCheckbox.CheckedChanged += new System.EventHandler(this.overrideLabelCheckbox_CheckedChanged);
            // 
            // overrideValueCheckbox
            // 
            this.overrideValueCheckbox.AutoSize = true;
            this.overrideValueCheckbox.Location = new System.Drawing.Point(3, 114);
            this.overrideValueCheckbox.Name = "overrideValueCheckbox";
            this.overrideValueCheckbox.Size = new System.Drawing.Size(142, 17);
            this.overrideValueCheckbox.TabIndex = 1;
            this.overrideValueCheckbox.Text = "Override Layout Settings";
            this.overrideValueCheckbox.UseVisualStyleBackColor = true;
            this.overrideValueCheckbox.CheckedChanged += new System.EventHandler(this.overrideValueCheckbox_CheckedChanged);
            // 
            // achievementColorCheckbox
            // 
            this.achievementColorCheckbox.AutoSize = true;
            this.achievementColorCheckbox.Location = new System.Drawing.Point(3, 225);
            this.achievementColorCheckbox.Name = "achievementColorCheckbox";
            this.achievementColorCheckbox.Size = new System.Drawing.Size(175, 17);
            this.achievementColorCheckbox.TabIndex = 2;
            this.achievementColorCheckbox.Text = "Use Achievement Status Colors";
            this.achievementColorCheckbox.UseVisualStyleBackColor = true;
            this.achievementColorCheckbox.CheckedChanged += new System.EventHandler(this.achievementColorCheckbox_CheckedChanged);
            // 
            // labelColorGroup
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.labelColorGroup, 2);
            this.labelColorGroup.Controls.Add(this.tableLayoutPanel4);
            this.labelColorGroup.Location = new System.Drawing.Point(3, 28);
            this.labelColorGroup.Name = "labelColorGroup";
            this.labelColorGroup.Size = new System.Drawing.Size(440, 80);
            this.labelColorGroup.TabIndex = 3;
            this.labelColorGroup.TabStop = false;
            this.labelColorGroup.Text = "Label Colors";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelOutlineBtn, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelTextBtn, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelShadowsBtn, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(428, 58);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Outline";
            // 
            // labelOutlineBtn
            // 
            this.labelOutlineBtn.Location = new System.Drawing.Point(188, 3);
            this.labelOutlineBtn.Name = "labelOutlineBtn";
            this.labelOutlineBtn.Size = new System.Drawing.Size(23, 23);
            this.labelOutlineBtn.TabIndex = 2;
            this.labelOutlineBtn.UseVisualStyleBackColor = true;
            this.labelOutlineBtn.Click += new System.EventHandler(this.labelOutlineBtn_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Text";
            // 
            // labelTextBtn
            // 
            this.labelTextBtn.Location = new System.Drawing.Point(402, 3);
            this.labelTextBtn.Name = "labelTextBtn";
            this.labelTextBtn.Size = new System.Drawing.Size(23, 23);
            this.labelTextBtn.TabIndex = 3;
            this.labelTextBtn.UseVisualStyleBackColor = true;
            this.labelTextBtn.Click += new System.EventHandler(this.labelTextBtn_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Shadows";
            // 
            // labelShadowsBtn
            // 
            this.labelShadowsBtn.Location = new System.Drawing.Point(188, 32);
            this.labelShadowsBtn.Name = "labelShadowsBtn";
            this.labelShadowsBtn.Size = new System.Drawing.Size(23, 23);
            this.labelShadowsBtn.TabIndex = 4;
            this.labelShadowsBtn.UseVisualStyleBackColor = true;
            this.labelShadowsBtn.Click += new System.EventHandler(this.labelShadowsBtn_Click);
            // 
            // valueColorGroup
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.valueColorGroup, 2);
            this.valueColorGroup.Controls.Add(this.tableLayoutPanel3);
            this.valueColorGroup.Location = new System.Drawing.Point(3, 139);
            this.valueColorGroup.Name = "valueColorGroup";
            this.valueColorGroup.Size = new System.Drawing.Size(440, 77);
            this.valueColorGroup.TabIndex = 4;
            this.valueColorGroup.TabStop = false;
            this.valueColorGroup.Text = "Value Colors";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.valuesOutlinesBtn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.valuesTextBtn, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.valuesShadowBtn, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(428, 58);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Outlines";
            // 
            // valuesOutlinesBtn
            // 
            this.valuesOutlinesBtn.Location = new System.Drawing.Point(188, 3);
            this.valuesOutlinesBtn.Name = "valuesOutlinesBtn";
            this.valuesOutlinesBtn.Size = new System.Drawing.Size(23, 23);
            this.valuesOutlinesBtn.TabIndex = 2;
            this.valuesOutlinesBtn.UseVisualStyleBackColor = true;
            this.valuesOutlinesBtn.Click += new System.EventHandler(this.valuesOutlinesBtn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Text";
            // 
            // valuesTextBtn
            // 
            this.valuesTextBtn.Location = new System.Drawing.Point(402, 3);
            this.valuesTextBtn.Name = "valuesTextBtn";
            this.valuesTextBtn.Size = new System.Drawing.Size(23, 23);
            this.valuesTextBtn.TabIndex = 3;
            this.valuesTextBtn.UseVisualStyleBackColor = true;
            this.valuesTextBtn.Click += new System.EventHandler(this.valuesTextBtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Shadows";
            // 
            // valuesShadowBtn
            // 
            this.valuesShadowBtn.Location = new System.Drawing.Point(188, 32);
            this.valuesShadowBtn.Name = "valuesShadowBtn";
            this.valuesShadowBtn.Size = new System.Drawing.Size(23, 23);
            this.valuesShadowBtn.TabIndex = 4;
            this.valuesShadowBtn.UseVisualStyleBackColor = true;
            this.valuesShadowBtn.Click += new System.EventHandler(this.valuesShadowBtn_Click);
            // 
            // achievementColorGroup
            // 
            this.achievementColorGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.achievementColorGroup.Controls.Add(this.tableLayoutPanel2);
            this.achievementColorGroup.Location = new System.Drawing.Point(3, 250);
            this.achievementColorGroup.Name = "achievementColorGroup";
            this.achievementColorGroup.Size = new System.Drawing.Size(440, 115);
            this.achievementColorGroup.TabIndex = 5;
            this.achievementColorGroup.TabStop = false;
            this.achievementColorGroup.Text = "Achievement Status Colors";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Controls.Add(this.colorLabelsCheckbox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.colorValuesCheckbox, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.progressColorBtn, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.failedColorBtn, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.completedColorBtn, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(428, 87);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // colorLabelsCheckbox
            // 
            this.colorLabelsCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.colorLabelsCheckbox.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.colorLabelsCheckbox, 2);
            this.colorLabelsCheckbox.Location = new System.Drawing.Point(3, 6);
            this.colorLabelsCheckbox.Name = "colorLabelsCheckbox";
            this.colorLabelsCheckbox.Size = new System.Drawing.Size(208, 17);
            this.colorLabelsCheckbox.TabIndex = 0;
            this.colorLabelsCheckbox.Text = "Color Labels";
            this.colorLabelsCheckbox.UseVisualStyleBackColor = true;
            this.colorLabelsCheckbox.CheckedChanged += new System.EventHandler(this.colorLabelsCheckbox_CheckedChanged);
            // 
            // colorValuesCheckbox
            // 
            this.colorValuesCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.colorValuesCheckbox.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.colorValuesCheckbox, 2);
            this.colorValuesCheckbox.Location = new System.Drawing.Point(217, 6);
            this.colorValuesCheckbox.Name = "colorValuesCheckbox";
            this.colorValuesCheckbox.Size = new System.Drawing.Size(208, 17);
            this.colorValuesCheckbox.TabIndex = 1;
            this.colorValuesCheckbox.Text = "Color Values";
            this.colorValuesCheckbox.UseVisualStyleBackColor = true;
            this.colorValuesCheckbox.CheckedChanged += new System.EventHandler(this.colorValuesCheckbox_CheckedChanged);
            // 
            // progressColorBtn
            // 
            this.progressColorBtn.Location = new System.Drawing.Point(188, 32);
            this.progressColorBtn.Name = "progressColorBtn";
            this.progressColorBtn.Size = new System.Drawing.Size(23, 23);
            this.progressColorBtn.TabIndex = 2;
            this.progressColorBtn.UseVisualStyleBackColor = true;
            this.progressColorBtn.Click += new System.EventHandler(this.progressColorBtn_Click);
            // 
            // failedColorBtn
            // 
            this.failedColorBtn.Location = new System.Drawing.Point(402, 32);
            this.failedColorBtn.Name = "failedColorBtn";
            this.failedColorBtn.Size = new System.Drawing.Size(23, 23);
            this.failedColorBtn.TabIndex = 3;
            this.failedColorBtn.UseVisualStyleBackColor = true;
            this.failedColorBtn.Click += new System.EventHandler(this.failedColorBtn_Click);
            // 
            // completedColorBtn
            // 
            this.completedColorBtn.Location = new System.Drawing.Point(188, 61);
            this.completedColorBtn.Name = "completedColorBtn";
            this.completedColorBtn.Size = new System.Drawing.Size(23, 23);
            this.completedColorBtn.TabIndex = 4;
            this.completedColorBtn.UseVisualStyleBackColor = true;
            this.completedColorBtn.Click += new System.EventHandler(this.completedColorBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "In Progress Color";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Completed Color";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Failed Color";
            // 
            // AchievementTrackerComponentSettings
            // 
            this.Controls.Add(this.groupBox1);
            this.Name = "AchievementTrackerComponentSettings";
            this.Size = new System.Drawing.Size(459, 427);
            this.Load += new System.EventHandler(this.AchievementTrackerComponentSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.labelColorGroup.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.valueColorGroup.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.achievementColorGroup.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
