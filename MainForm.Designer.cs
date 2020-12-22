namespace SPZLab8Var1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.changeDesktopColorButton = new System.Windows.Forms.Button();
            this.newDesktopBackgroundColorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.originalDesktopBackgroundColorTextBox = new System.Windows.Forms.TextBox();
            this.restoreOriginalColorCheckBox = new System.Windows.Forms.CheckBox();
            this.restoreOriginalDesktopBackgroundColorButton = new System.Windows.Forms.Button();
            this.newColorPictureBox = new System.Windows.Forms.PictureBox();
            this.originalColorPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.newColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalColorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // changeDesktopColorButton
            // 
            this.changeDesktopColorButton.Location = new System.Drawing.Point(12, 12);
            this.changeDesktopColorButton.Name = "changeDesktopColorButton";
            this.changeDesktopColorButton.Size = new System.Drawing.Size(219, 23);
            this.changeDesktopColorButton.TabIndex = 0;
            this.changeDesktopColorButton.Text = "Поменять цвет рабочего стола";
            this.changeDesktopColorButton.UseVisualStyleBackColor = true;
            this.changeDesktopColorButton.Click += new System.EventHandler(this.changeDesktopColorButton_Click);
            // 
            // newDesktopBackgroundColorTextBox
            // 
            this.newDesktopBackgroundColorTextBox.Location = new System.Drawing.Point(237, 12);
            this.newDesktopBackgroundColorTextBox.Name = "newDesktopBackgroundColorTextBox";
            this.newDesktopBackgroundColorTextBox.Size = new System.Drawing.Size(100, 23);
            this.newDesktopBackgroundColorTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Оригинальный цвет рабочего стола";
            // 
            // originalDesktopBackgroundColorTextBox
            // 
            this.originalDesktopBackgroundColorTextBox.Enabled = false;
            this.originalDesktopBackgroundColorTextBox.Location = new System.Drawing.Point(237, 41);
            this.originalDesktopBackgroundColorTextBox.Name = "originalDesktopBackgroundColorTextBox";
            this.originalDesktopBackgroundColorTextBox.Size = new System.Drawing.Size(100, 23);
            this.originalDesktopBackgroundColorTextBox.TabIndex = 3;
            // 
            // restoreOriginalColorCheckBox
            // 
            this.restoreOriginalColorCheckBox.AutoSize = true;
            this.restoreOriginalColorCheckBox.Location = new System.Drawing.Point(237, 70);
            this.restoreOriginalColorCheckBox.Name = "restoreOriginalColorCheckBox";
            this.restoreOriginalColorCheckBox.Size = new System.Drawing.Size(386, 19);
            this.restoreOriginalColorCheckBox.TabIndex = 4;
            this.restoreOriginalColorCheckBox.Text = "Восстановить оригинальный цвет рабочего стола после выхода?";
            this.restoreOriginalColorCheckBox.UseVisualStyleBackColor = true;
            // 
            // restoreOriginalDesktopBackgroundColorButton
            // 
            this.restoreOriginalDesktopBackgroundColorButton.Location = new System.Drawing.Point(12, 70);
            this.restoreOriginalDesktopBackgroundColorButton.Name = "restoreOriginalDesktopBackgroundColorButton";
            this.restoreOriginalDesktopBackgroundColorButton.Size = new System.Drawing.Size(219, 43);
            this.restoreOriginalDesktopBackgroundColorButton.TabIndex = 5;
            this.restoreOriginalDesktopBackgroundColorButton.Text = "Восстановить оригинальный цвет рабочего стола";
            this.restoreOriginalDesktopBackgroundColorButton.UseVisualStyleBackColor = true;
            this.restoreOriginalDesktopBackgroundColorButton.Click += new System.EventHandler(this.restoreOriginalDesktopBackgroundColorButton_Click);
            // 
            // newColorPictureBox
            // 
            this.newColorPictureBox.Location = new System.Drawing.Point(343, 12);
            this.newColorPictureBox.Name = "newColorPictureBox";
            this.newColorPictureBox.Size = new System.Drawing.Size(22, 23);
            this.newColorPictureBox.TabIndex = 6;
            this.newColorPictureBox.TabStop = false;
            // 
            // originalColorPictureBox
            // 
            this.originalColorPictureBox.Location = new System.Drawing.Point(343, 41);
            this.originalColorPictureBox.Name = "originalColorPictureBox";
            this.originalColorPictureBox.Size = new System.Drawing.Size(22, 23);
            this.originalColorPictureBox.TabIndex = 7;
            this.originalColorPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 122);
            this.Controls.Add(this.originalColorPictureBox);
            this.Controls.Add(this.newColorPictureBox);
            this.Controls.Add(this.restoreOriginalDesktopBackgroundColorButton);
            this.Controls.Add(this.restoreOriginalColorCheckBox);
            this.Controls.Add(this.originalDesktopBackgroundColorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newDesktopBackgroundColorTextBox);
            this.Controls.Add(this.changeDesktopColorButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.newColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalColorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeDesktopColorButton;
        private System.Windows.Forms.TextBox newDesktopBackgroundColorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox originalDesktopBackgroundColorTextBox;
        private System.Windows.Forms.CheckBox restoreOriginalColorCheckBox;
        private System.Windows.Forms.Button restoreOriginalDesktopBackgroundColorButton;
        private System.Windows.Forms.PictureBox newColorPictureBox;
        private System.Windows.Forms.PictureBox originalColorPictureBox;
    }
}

