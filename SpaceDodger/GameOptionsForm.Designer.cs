namespace SpaceDodger
{
    partial class GameOptionsForm
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
            this._lblDifficulty = new System.Windows.Forms.Label();
            this._lblTheme = new System.Windows.Forms.Label();
            this._btnOkay = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnHard = new System.Windows.Forms.RadioButton();
            this._btnMedium = new System.Windows.Forms.RadioButton();
            this._btnEasy = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._btnDark = new System.Windows.Forms.RadioButton();
            this._btnClassic = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblDifficulty
            // 
            this._lblDifficulty.AutoSize = true;
            this._lblDifficulty.Location = new System.Drawing.Point(9, 9);
            this._lblDifficulty.Name = "_lblDifficulty";
            this._lblDifficulty.Size = new System.Drawing.Size(47, 13);
            this._lblDifficulty.TabIndex = 0;
            this._lblDifficulty.Text = "Difficulty";
            // 
            // _lblTheme
            // 
            this._lblTheme.AutoSize = true;
            this._lblTheme.Location = new System.Drawing.Point(9, 112);
            this._lblTheme.Name = "_lblTheme";
            this._lblTheme.Size = new System.Drawing.Size(40, 13);
            this._lblTheme.TabIndex = 0;
            this._lblTheme.Text = "Theme";
            // 
            // _btnOkay
            // 
            this._btnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnOkay.Location = new System.Drawing.Point(12, 204);
            this._btnOkay.Name = "_btnOkay";
            this._btnOkay.Size = new System.Drawing.Size(75, 23);
            this._btnOkay.TabIndex = 2;
            this._btnOkay.Text = "OK";
            this._btnOkay.UseVisualStyleBackColor = true;
            this._btnOkay.Click += new System.EventHandler(this.OnOK);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.Location = new System.Drawing.Point(191, 204);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 2;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._btnHard);
            this.groupBox1.Controls.Add(this._btnMedium);
            this.groupBox1.Controls.Add(this._btnEasy);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 85);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a difficulty";
            // 
            // _btnHard
            // 
            this._btnHard.AutoSize = true;
            this._btnHard.Location = new System.Drawing.Point(204, 24);
            this._btnHard.Name = "_btnHard";
            this._btnHard.Size = new System.Drawing.Size(48, 17);
            this._btnHard.TabIndex = 2;
            this._btnHard.Text = "Hard";
            this._btnHard.UseVisualStyleBackColor = true;
            // 
            // _btnMedium
            // 
            this._btnMedium.AutoSize = true;
            this._btnMedium.Checked = true;
            this._btnMedium.Location = new System.Drawing.Point(78, 24);
            this._btnMedium.Name = "_btnMedium";
            this._btnMedium.Size = new System.Drawing.Size(105, 17);
            this._btnMedium.TabIndex = 1;
            this._btnMedium.TabStop = true;
            this._btnMedium.Text = "Medium (Defualt)";
            this._btnMedium.UseVisualStyleBackColor = true;
            // 
            // _btnEasy
            // 
            this._btnEasy.AutoSize = true;
            this._btnEasy.Location = new System.Drawing.Point(10, 24);
            this._btnEasy.Name = "_btnEasy";
            this._btnEasy.Size = new System.Drawing.Size(48, 17);
            this._btnEasy.TabIndex = 0;
            this._btnEasy.Text = "Easy";
            this._btnEasy.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._btnDark);
            this.groupBox2.Controls.Add(this._btnClassic);
            this.groupBox2.Location = new System.Drawing.Point(0, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 79);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a theme";
            // 
            // _btnDark
            // 
            this._btnDark.AutoSize = true;
            this._btnDark.Location = new System.Drawing.Point(135, 31);
            this._btnDark.Name = "_btnDark";
            this._btnDark.Size = new System.Drawing.Size(48, 17);
            this._btnDark.TabIndex = 1;
            this._btnDark.Text = "Dark";
            this._btnDark.UseVisualStyleBackColor = true;
            // 
            // _btnClassic
            // 
            this._btnClassic.AutoSize = true;
            this._btnClassic.Checked = true;
            this._btnClassic.Location = new System.Drawing.Point(10, 31);
            this._btnClassic.Name = "_btnClassic";
            this._btnClassic.Size = new System.Drawing.Size(101, 17);
            this._btnClassic.TabIndex = 0;
            this._btnClassic.TabStop = true;
            this._btnClassic.Text = "Classic (Default)";
            this._btnClassic.UseVisualStyleBackColor = true;
            // 
            // GameOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 240);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOkay);
            this.Controls.Add(this._lblTheme);
            this.Controls.Add(this._lblDifficulty);
            this.Name = "GameOptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblDifficulty;
        private System.Windows.Forms.Label _lblTheme;
        private System.Windows.Forms.Button _btnOkay;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton _btnHard;
        private System.Windows.Forms.RadioButton _btnMedium;
        private System.Windows.Forms.RadioButton _btnEasy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton _btnDark;
        private System.Windows.Forms.RadioButton _btnClassic;
    }
}