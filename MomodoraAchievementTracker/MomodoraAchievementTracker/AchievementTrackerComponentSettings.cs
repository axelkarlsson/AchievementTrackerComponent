using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveSplit.UI.Components
{
    class AchievementTrackerComponentSettings : UserControl
    {
        public Color inProgressColor { get; set; }
        public Color failedColor { get; set; }
        public Color completedColor { get; set; }
        private ColorDialog inProgressDialog;
        private ColorDialog failedDialog;
        private ColorDialog completedDialog;
        private GroupBox groupBox1;
        private Label failedLabel;
        private Button failedButton;
        private Label inProgressLabel;
        private Button inProgressBtn;
        private Label completedLabel;
        private Button completeColorBtn;
        
     
        public AchievementTrackerComponentSettings()
        {
            InitializeComponent();
            inProgressDialog = new ColorDialog();
            inProgressDialog.Color = inProgressColor;
            failedDialog = new ColorDialog();
            failedDialog.Color = failedColor;
            completedDialog = new ColorDialog();
            inProgressDialog.Color = inProgressColor;
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.completeColorBtn = new System.Windows.Forms.Button();
            this.completedLabel = new System.Windows.Forms.Label();
            this.inProgressLabel = new System.Windows.Forms.Label();
            this.inProgressBtn = new System.Windows.Forms.Button();
            this.failedLabel = new System.Windows.Forms.Label();
            this.failedButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.failedLabel);
            this.groupBox1.Controls.Add(this.failedButton);
            this.groupBox1.Controls.Add(this.inProgressLabel);
            this.groupBox1.Controls.Add(this.inProgressBtn);
            this.groupBox1.Controls.Add(this.completedLabel);
            this.groupBox1.Controls.Add(this.completeColorBtn);
            this.groupBox1.Location = new System.Drawing.Point(19, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // completeColorBtn
            // 
            this.completeColorBtn.Location = new System.Drawing.Point(150, 21);
            this.completeColorBtn.Name = "completeColorBtn";
            this.completeColorBtn.Size = new System.Drawing.Size(20, 20);
            this.completeColorBtn.TabIndex = 0;
            this.completeColorBtn.UseVisualStyleBackColor = true;
            // 
            // completedLabel
            // 
            this.completedLabel.AutoSize = true;
            this.completedLabel.Location = new System.Drawing.Point(6, 25);
            this.completedLabel.Name = "completedLabel";
            this.completedLabel.Size = new System.Drawing.Size(84, 13);
            this.completedLabel.TabIndex = 1;
            this.completedLabel.Text = "Completed Color";
            // 
            // inProgressLabel
            // 
            this.inProgressLabel.AutoSize = true;
            this.inProgressLabel.Location = new System.Drawing.Point(6, 50);
            this.inProgressLabel.Name = "inProgressLabel";
            this.inProgressLabel.Size = new System.Drawing.Size(87, 13);
            this.inProgressLabel.TabIndex = 3;
            this.inProgressLabel.Text = "In Progress Color";
            // 
            // inProgressBtn
            // 
            this.inProgressBtn.Location = new System.Drawing.Point(150, 46);
            this.inProgressBtn.Name = "inProgressBtn";
            this.inProgressBtn.Size = new System.Drawing.Size(20, 20);
            this.inProgressBtn.TabIndex = 2;
            this.inProgressBtn.UseVisualStyleBackColor = true;
            // 
            // failedLabel
            // 
            this.failedLabel.AutoSize = true;
            this.failedLabel.Location = new System.Drawing.Point(6, 75);
            this.failedLabel.Name = "failedLabel";
            this.failedLabel.Size = new System.Drawing.Size(62, 13);
            this.failedLabel.TabIndex = 5;
            this.failedLabel.Text = "Failed Color";
            // 
            // failedButton
            // 
            this.failedButton.Location = new System.Drawing.Point(150, 71);
            this.failedButton.Name = "failedButton";
            this.failedButton.Size = new System.Drawing.Size(20, 20);
            this.failedButton.TabIndex = 4;
            this.failedButton.UseVisualStyleBackColor = true;
            // 
            // AchievementTrackerComponentSettings
            // 
            this.Controls.Add(this.groupBox1);
            this.Name = "AchievementTrackerComponentSettings";
            this.Size = new System.Drawing.Size(342, 141);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

    }
}
