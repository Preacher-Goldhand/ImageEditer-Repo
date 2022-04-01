
namespace ImageEditer
{
    partial class MainForm
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
            this.Panel = new System.Windows.Forms.Panel();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.WindowPictureBox = new System.Windows.Forms.PictureBox();
            this.NormalButton = new System.Windows.Forms.Button();
            this.CenterButton = new System.Windows.Forms.Button();
            this.AutoSizeButton = new System.Windows.Forms.Button();
            this.StretchButton = new System.Windows.Forms.Button();
            this.ZoomButton = new System.Windows.Forms.Button();
            this.ImgSizeTextBox = new System.Windows.Forms.TextBox();
            this.ImgSizeLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SetButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.RotateButton = new System.Windows.Forms.Button();
            this.Filter1Button = new System.Windows.Forms.Button();
            this.Filter2Button = new System.Windows.Forms.Button();
            this.Filter3Button = new System.Windows.Forms.Button();
            this.Filter4Button = new System.Windows.Forms.Button();
            this.Filter5Button = new System.Windows.Forms.Button();
            this.HUETrackBar = new System.Windows.Forms.TrackBar();
            this.HUELabel = new System.Windows.Forms.Label();
            this.ContrastLabel = new System.Windows.Forms.Label();
            this.ContrastTrackBar = new System.Windows.Forms.TrackBar();
            this.BrightnessLabel = new System.Windows.Forms.Label();
            this.BrightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HUETrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.LightSlateGray;
            this.Panel.Controls.Add(this.MainPictureBox);
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(799, 453);
            this.Panel.TabIndex = 0;
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.BackColor = System.Drawing.Color.DimGray;
            this.MainPictureBox.Location = new System.Drawing.Point(12, 12);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(774, 427);
            this.MainPictureBox.TabIndex = 0;
            this.MainPictureBox.TabStop = false;
            this.MainPictureBox.Click += new System.EventHandler(this.MainPictureBox_Click);
            this.MainPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPictureBox_Paint);
            this.MainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseDown);
            this.MainPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseMove);
            this.MainPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseUp);
            // 
            // WindowPictureBox
            // 
            this.WindowPictureBox.Location = new System.Drawing.Point(814, 12);
            this.WindowPictureBox.Name = "WindowPictureBox";
            this.WindowPictureBox.Size = new System.Drawing.Size(214, 144);
            this.WindowPictureBox.TabIndex = 1;
            this.WindowPictureBox.TabStop = false;
            // 
            // NormalButton
            // 
            this.NormalButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.NormalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NormalButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NormalButton.Location = new System.Drawing.Point(833, 192);
            this.NormalButton.Name = "NormalButton";
            this.NormalButton.Size = new System.Drawing.Size(160, 31);
            this.NormalButton.TabIndex = 2;
            this.NormalButton.Text = "Normal";
            this.NormalButton.UseVisualStyleBackColor = false;
            this.NormalButton.Click += new System.EventHandler(this.NormalButton_Click);
            // 
            // CenterButton
            // 
            this.CenterButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.CenterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CenterButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CenterButton.Location = new System.Drawing.Point(833, 358);
            this.CenterButton.Name = "CenterButton";
            this.CenterButton.Size = new System.Drawing.Size(160, 31);
            this.CenterButton.TabIndex = 3;
            this.CenterButton.Text = "Center";
            this.CenterButton.UseVisualStyleBackColor = false;
            this.CenterButton.Click += new System.EventHandler(this.CenterButton_Click);
            // 
            // AutoSizeButton
            // 
            this.AutoSizeButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.AutoSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoSizeButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AutoSizeButton.Location = new System.Drawing.Point(833, 307);
            this.AutoSizeButton.Name = "AutoSizeButton";
            this.AutoSizeButton.Size = new System.Drawing.Size(160, 31);
            this.AutoSizeButton.TabIndex = 4;
            this.AutoSizeButton.Text = "Autosize";
            this.AutoSizeButton.UseVisualStyleBackColor = false;
            this.AutoSizeButton.Click += new System.EventHandler(this.AutoSizeButton_Click);
            // 
            // StretchButton
            // 
            this.StretchButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.StretchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StretchButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StretchButton.Location = new System.Drawing.Point(833, 248);
            this.StretchButton.Name = "StretchButton";
            this.StretchButton.Size = new System.Drawing.Size(160, 31);
            this.StretchButton.TabIndex = 5;
            this.StretchButton.Text = "Stretch";
            this.StretchButton.UseVisualStyleBackColor = false;
            this.StretchButton.Click += new System.EventHandler(this.StretchButton_Click);
            // 
            // ZoomButton
            // 
            this.ZoomButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.ZoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZoomButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZoomButton.Location = new System.Drawing.Point(833, 408);
            this.ZoomButton.Name = "ZoomButton";
            this.ZoomButton.Size = new System.Drawing.Size(160, 31);
            this.ZoomButton.TabIndex = 6;
            this.ZoomButton.Text = "Zoom";
            this.ZoomButton.UseVisualStyleBackColor = false;
            this.ZoomButton.Click += new System.EventHandler(this.ZoomButton_Click);
            // 
            // ImgSizeTextBox
            // 
            this.ImgSizeTextBox.Location = new System.Drawing.Point(12, 496);
            this.ImgSizeTextBox.Name = "ImgSizeTextBox";
            this.ImgSizeTextBox.Size = new System.Drawing.Size(383, 20);
            this.ImgSizeTextBox.TabIndex = 7;
            // 
            // ImgSizeLabel
            // 
            this.ImgSizeLabel.AutoSize = true;
            this.ImgSizeLabel.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImgSizeLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ImgSizeLabel.Location = new System.Drawing.Point(29, 471);
            this.ImgSizeLabel.Name = "ImgSizeLabel";
            this.ImgSizeLabel.Size = new System.Drawing.Size(64, 13);
            this.ImgSizeLabel.TabIndex = 8;
            this.ImgSizeLabel.Text = "Image Size";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeightLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.HeightLabel.Location = new System.Drawing.Point(153, 535);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(44, 13);
            this.HeightLabel.TabIndex = 9;
            this.HeightLabel.Text = "Height";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WidthLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.WidthLabel.Location = new System.Drawing.Point(29, 535);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(41, 13);
            this.WidthLabel.TabIndex = 10;
            this.WidthLabel.Text = "Width";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(12, 565);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 11;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(133, 565);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.HeightTextBox.TabIndex = 12;
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectButton.Location = new System.Drawing.Point(418, 488);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(160, 31);
            this.SelectButton.TabIndex = 13;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveButton.Location = new System.Drawing.Point(639, 488);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(160, 31);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SetButton
            // 
            this.SetButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.SetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SetButton.Location = new System.Drawing.Point(12, 627);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(88, 31);
            this.SetButton.TabIndex = 22;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = false;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResetButton.Location = new System.Drawing.Point(133, 627);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(88, 31);
            this.ResetButton.TabIndex = 23;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // RotateButton
            // 
            this.RotateButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.RotateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RotateButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RotateButton.Location = new System.Drawing.Point(266, 627);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(88, 31);
            this.RotateButton.TabIndex = 24;
            this.RotateButton.Text = "Rotate";
            this.RotateButton.UseVisualStyleBackColor = false;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // Filter1Button
            // 
            this.Filter1Button.BackColor = System.Drawing.Color.LightSlateGray;
            this.Filter1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filter1Button.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Filter1Button.Location = new System.Drawing.Point(550, 627);
            this.Filter1Button.Name = "Filter1Button";
            this.Filter1Button.Size = new System.Drawing.Size(88, 31);
            this.Filter1Button.TabIndex = 25;
            this.Filter1Button.Text = "Filter 1";
            this.Filter1Button.UseVisualStyleBackColor = false;
            this.Filter1Button.Click += new System.EventHandler(this.Filter1Button_Click);
            // 
            // Filter2Button
            // 
            this.Filter2Button.BackColor = System.Drawing.Color.LightSlateGray;
            this.Filter2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filter2Button.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Filter2Button.Location = new System.Drawing.Point(644, 627);
            this.Filter2Button.Name = "Filter2Button";
            this.Filter2Button.Size = new System.Drawing.Size(88, 31);
            this.Filter2Button.TabIndex = 26;
            this.Filter2Button.Text = "Filter 2 ";
            this.Filter2Button.UseVisualStyleBackColor = false;
            this.Filter2Button.Click += new System.EventHandler(this.Filter2Button_Click);
            // 
            // Filter3Button
            // 
            this.Filter3Button.BackColor = System.Drawing.Color.LightSlateGray;
            this.Filter3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filter3Button.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Filter3Button.Location = new System.Drawing.Point(738, 627);
            this.Filter3Button.Name = "Filter3Button";
            this.Filter3Button.Size = new System.Drawing.Size(88, 31);
            this.Filter3Button.TabIndex = 27;
            this.Filter3Button.Text = "Filter 3 ";
            this.Filter3Button.UseVisualStyleBackColor = false;
            this.Filter3Button.Click += new System.EventHandler(this.Filter3Button_Click);
            // 
            // Filter4Button
            // 
            this.Filter4Button.BackColor = System.Drawing.Color.LightSlateGray;
            this.Filter4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filter4Button.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Filter4Button.Location = new System.Drawing.Point(832, 627);
            this.Filter4Button.Name = "Filter4Button";
            this.Filter4Button.Size = new System.Drawing.Size(88, 31);
            this.Filter4Button.TabIndex = 28;
            this.Filter4Button.Text = "Filter 4 Button";
            this.Filter4Button.UseVisualStyleBackColor = false;
            this.Filter4Button.Click += new System.EventHandler(this.Filter4Button_Click);
            // 
            // Filter5Button
            // 
            this.Filter5Button.BackColor = System.Drawing.Color.LightSlateGray;
            this.Filter5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filter5Button.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Filter5Button.Location = new System.Drawing.Point(926, 627);
            this.Filter5Button.Name = "Filter5Button";
            this.Filter5Button.Size = new System.Drawing.Size(88, 31);
            this.Filter5Button.TabIndex = 29;
            this.Filter5Button.Text = "Filter 5 ";
            this.Filter5Button.UseVisualStyleBackColor = false;
            this.Filter5Button.Click += new System.EventHandler(this.Filter5Button_Click);
            // 
            // HUETrackBar
            // 
            this.HUETrackBar.Location = new System.Drawing.Point(398, 565);
            this.HUETrackBar.Name = "HUETrackBar";
            this.HUETrackBar.Size = new System.Drawing.Size(135, 45);
            this.HUETrackBar.TabIndex = 30;
            this.HUETrackBar.ValueChanged += new System.EventHandler(this.HUETrackBar_ValueChanged);
            // 
            // HUELabel
            // 
            this.HUELabel.AutoSize = true;
            this.HUELabel.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HUELabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.HUELabel.Location = new System.Drawing.Point(362, 572);
            this.HUELabel.Name = "HUELabel";
            this.HUELabel.Size = new System.Drawing.Size(30, 13);
            this.HUELabel.TabIndex = 31;
            this.HUELabel.Text = "HUE";
            // 
            // ContrastLabel
            // 
            this.ContrastLabel.AutoSize = true;
            this.ContrastLabel.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ContrastLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ContrastLabel.Location = new System.Drawing.Point(569, 572);
            this.ContrastLabel.Name = "ContrastLabel";
            this.ContrastLabel.Size = new System.Drawing.Size(54, 13);
            this.ContrastLabel.TabIndex = 32;
            this.ContrastLabel.Text = "Contrast";
            // 
            // ContrastTrackBar
            // 
            this.ContrastTrackBar.Location = new System.Drawing.Point(629, 565);
            this.ContrastTrackBar.Name = "ContrastTrackBar";
            this.ContrastTrackBar.Size = new System.Drawing.Size(135, 45);
            this.ContrastTrackBar.TabIndex = 33;
            this.ContrastTrackBar.Scroll += new System.EventHandler(this.ContrastTrackBar_Scroll);
            this.ContrastTrackBar.ValueChanged += new System.EventHandler(this.ContrastTrackBar_ValueChanged);
            // 
            // BrightnessLabel
            // 
            this.BrightnessLabel.AutoSize = true;
            this.BrightnessLabel.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BrightnessLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BrightnessLabel.Location = new System.Drawing.Point(811, 572);
            this.BrightnessLabel.Name = "BrightnessLabel";
            this.BrightnessLabel.Size = new System.Drawing.Size(65, 13);
            this.BrightnessLabel.TabIndex = 34;
            this.BrightnessLabel.Text = "Brightness";
            // 
            // BrightnessTrackBar
            // 
            this.BrightnessTrackBar.Location = new System.Drawing.Point(882, 565);
            this.BrightnessTrackBar.Name = "BrightnessTrackBar";
            this.BrightnessTrackBar.Size = new System.Drawing.Size(135, 45);
            this.BrightnessTrackBar.TabIndex = 35;
            this.BrightnessTrackBar.ValueChanged += new System.EventHandler(this.BrightnessTrackBar_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1040, 670);
            this.Controls.Add(this.BrightnessTrackBar);
            this.Controls.Add(this.BrightnessLabel);
            this.Controls.Add(this.ContrastTrackBar);
            this.Controls.Add(this.ContrastLabel);
            this.Controls.Add(this.HUELabel);
            this.Controls.Add(this.HUETrackBar);
            this.Controls.Add(this.Filter5Button);
            this.Controls.Add(this.Filter4Button);
            this.Controls.Add(this.Filter3Button);
            this.Controls.Add(this.Filter2Button);
            this.Controls.Add(this.Filter1Button);
            this.Controls.Add(this.RotateButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.ImgSizeLabel);
            this.Controls.Add(this.ImgSizeTextBox);
            this.Controls.Add(this.ZoomButton);
            this.Controls.Add(this.StretchButton);
            this.Controls.Add(this.AutoSizeButton);
            this.Controls.Add(this.CenterButton);
            this.Controls.Add(this.NormalButton);
            this.Controls.Add(this.WindowPictureBox);
            this.Controls.Add(this.Panel);
            this.Name = "MainForm";
            this.Text = "ImageEditer";
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HUETrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.PictureBox WindowPictureBox;
        private System.Windows.Forms.Button NormalButton;
        private System.Windows.Forms.Button CenterButton;
        private System.Windows.Forms.Button AutoSizeButton;
        private System.Windows.Forms.Button StretchButton;
        private System.Windows.Forms.Button ZoomButton;
        private System.Windows.Forms.TextBox ImgSizeTextBox;
        private System.Windows.Forms.Label ImgSizeLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button RotateButton;
        private System.Windows.Forms.Button Filter1Button;
        private System.Windows.Forms.Button Filter2Button;
        private System.Windows.Forms.Button Filter3Button;
        private System.Windows.Forms.Button Filter4Button;
        private System.Windows.Forms.Button Filter5Button;
        private System.Windows.Forms.TrackBar HUETrackBar;
        private System.Windows.Forms.Label HUELabel;
        private System.Windows.Forms.Label ContrastLabel;
        private System.Windows.Forms.TrackBar ContrastTrackBar;
        private System.Windows.Forms.Label BrightnessLabel;
        private System.Windows.Forms.TrackBar BrightnessTrackBar;
    }
}

