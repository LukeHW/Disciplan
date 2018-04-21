namespace Disciplan
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxPages = new System.Windows.Forms.TabControl();
            this.uxWelcomePage = new System.Windows.Forms.TabPage();
            this.uxStartButton = new System.Windows.Forms.Button();
            this.uxWelcomeLabel = new System.Windows.Forms.Label();
            this.uxSecond = new System.Windows.Forms.TabPage();
            this.uxName = new System.Windows.Forms.TextBox();
            this.uxSecondLabel = new System.Windows.Forms.Label();
            this.uxPlanPage = new System.Windows.Forms.TabPage();
            this.uxIntro = new System.Windows.Forms.Label();
            this.uxPages.SuspendLayout();
            this.uxWelcomePage.SuspendLayout();
            this.uxSecond.SuspendLayout();
            this.uxPlanPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxPages
            // 
            this.uxPages.Controls.Add(this.uxWelcomePage);
            this.uxPages.Controls.Add(this.uxSecond);
            this.uxPages.Controls.Add(this.uxPlanPage);
            this.uxPages.Location = new System.Drawing.Point(1, 1);
            this.uxPages.Name = "uxPages";
            this.uxPages.SelectedIndex = 0;
            this.uxPages.Size = new System.Drawing.Size(985, 562);
            this.uxPages.TabIndex = 2;
            // 
            // uxWelcomePage
            // 
            this.uxWelcomePage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.uxWelcomePage.Controls.Add(this.uxStartButton);
            this.uxWelcomePage.Controls.Add(this.uxWelcomeLabel);
            this.uxWelcomePage.Location = new System.Drawing.Point(4, 22);
            this.uxWelcomePage.Name = "uxWelcomePage";
            this.uxWelcomePage.Padding = new System.Windows.Forms.Padding(3);
            this.uxWelcomePage.Size = new System.Drawing.Size(977, 536);
            this.uxWelcomePage.TabIndex = 0;
            this.uxWelcomePage.Text = "Welcome";
            // 
            // uxStartButton
            // 
            this.uxStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartButton.Location = new System.Drawing.Point(412, 295);
            this.uxStartButton.Name = "uxStartButton";
            this.uxStartButton.Size = new System.Drawing.Size(136, 45);
            this.uxStartButton.TabIndex = 3;
            this.uxStartButton.Text = "Begin!";
            this.uxStartButton.UseVisualStyleBackColor = true;
            this.uxStartButton.Click += new System.EventHandler(this.uxStartButton_Click);
            // 
            // uxWelcomeLabel
            // 
            this.uxWelcomeLabel.AutoSize = true;
            this.uxWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWelcomeLabel.Location = new System.Drawing.Point(246, 196);
            this.uxWelcomeLabel.Name = "uxWelcomeLabel";
            this.uxWelcomeLabel.Size = new System.Drawing.Size(484, 55);
            this.uxWelcomeLabel.TabIndex = 2;
            this.uxWelcomeLabel.Text = "Welcome to Disciplan";
            // 
            // uxSecond
            // 
            this.uxSecond.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.uxSecond.Controls.Add(this.uxName);
            this.uxSecond.Controls.Add(this.uxSecondLabel);
            this.uxSecond.Location = new System.Drawing.Point(4, 22);
            this.uxSecond.Name = "uxSecond";
            this.uxSecond.Padding = new System.Windows.Forms.Padding(3);
            this.uxSecond.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uxSecond.Size = new System.Drawing.Size(977, 536);
            this.uxSecond.TabIndex = 1;
            this.uxSecond.Text = "Second";
            this.uxSecond.UseWaitCursor = true;
            // 
            // uxName
            // 
            this.uxName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.uxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxName.Location = new System.Drawing.Point(254, 274);
            this.uxName.Multiline = true;
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(484, 45);
            this.uxName.TabIndex = 3;
            this.uxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxName.UseWaitCursor = true;
            this.uxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uxName_KeyDown);
            // 
            // uxSecondLabel
            // 
            this.uxSecondLabel.AutoSize = true;
            this.uxSecondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSecondLabel.Location = new System.Drawing.Point(247, 202);
            this.uxSecondLabel.Name = "uxSecondLabel";
            this.uxSecondLabel.Size = new System.Drawing.Size(491, 37);
            this.uxSecondLabel.TabIndex = 2;
            this.uxSecondLabel.Text = "What would you like to be called?";
            this.uxSecondLabel.UseWaitCursor = true;
            // 
            // uxPlanPage
            // 
            this.uxPlanPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.uxPlanPage.Controls.Add(this.uxIntro);
            this.uxPlanPage.Location = new System.Drawing.Point(4, 22);
            this.uxPlanPage.Name = "uxPlanPage";
            this.uxPlanPage.Padding = new System.Windows.Forms.Padding(3);
            this.uxPlanPage.Size = new System.Drawing.Size(977, 536);
            this.uxPlanPage.TabIndex = 2;
            this.uxPlanPage.Text = "Plan";
            // 
            // uxIntro
            // 
            this.uxIntro.AutoSize = true;
            this.uxIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxIntro.Location = new System.Drawing.Point(113, 192);
            this.uxIntro.Name = "uxIntro";
            this.uxIntro.Size = new System.Drawing.Size(0, 37);
            this.uxIntro.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.uxPages);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.uxPages.ResumeLayout(false);
            this.uxWelcomePage.ResumeLayout(false);
            this.uxWelcomePage.PerformLayout();
            this.uxSecond.ResumeLayout(false);
            this.uxSecond.PerformLayout();
            this.uxPlanPage.ResumeLayout(false);
            this.uxPlanPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl uxPages;
        private System.Windows.Forms.TabPage uxWelcomePage;
        private System.Windows.Forms.TabPage uxSecond;
        private System.Windows.Forms.Label uxSecondLabel;
        private System.Windows.Forms.Button uxStartButton;
        private System.Windows.Forms.Label uxWelcomeLabel;
        private System.Windows.Forms.TextBox uxName;
        private System.Windows.Forms.TabPage uxPlanPage;
        private System.Windows.Forms.Label uxIntro;
    }
}

