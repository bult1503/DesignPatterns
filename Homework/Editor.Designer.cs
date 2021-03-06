﻿namespace Homework {
    partial class Editor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.screenBox = new System.Windows.Forms.PictureBox();
            this.shapePicker = new System.Windows.Forms.ListBox();
            this.actionPicker = new System.Windows.Forms.ListBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.screenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // screenBox
            // 
            this.screenBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screenBox.Location = new System.Drawing.Point(12, 82);
            this.screenBox.Name = "screenBox";
            this.screenBox.Size = new System.Drawing.Size(1256, 626);
            this.screenBox.TabIndex = 0;
            this.screenBox.TabStop = false;
            this.screenBox.Paint += new System.Windows.Forms.PaintEventHandler(this.screenBox_Paint);
            this.screenBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.screenBox_MouseClick);
            this.screenBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenBox_MouseDown);
            this.screenBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenBox_MouseMove);
            this.screenBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScreenBox_MouseUp);
            // 
            // shapePicker
            // 
            this.shapePicker.FormattingEnabled = true;
            this.shapePicker.ItemHeight = 16;
            this.shapePicker.Items.AddRange(new object[] {
            "Rectangle",
            "Ellipse"});
            this.shapePicker.Location = new System.Drawing.Point(12, 12);
            this.shapePicker.Name = "shapePicker";
            this.shapePicker.Size = new System.Drawing.Size(136, 68);
            this.shapePicker.TabIndex = 3;
            // 
            // actionPicker
            // 
            this.actionPicker.FormattingEnabled = true;
            this.actionPicker.ItemHeight = 16;
            this.actionPicker.Items.AddRange(new object[] {
            "Draw",
            "Move",
            "Select"});
            this.actionPicker.Location = new System.Drawing.Point(163, 12);
            this.actionPicker.Name = "actionPicker";
            this.actionPicker.Size = new System.Drawing.Size(136, 68);
            this.actionPicker.TabIndex = 4;
            this.actionPicker.SelectedIndexChanged += new System.EventHandler(this.actionPicker_SelectedIndexChanged);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(305, 22);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(57, 17);
            this.heightLabel.TabIndex = 5;
            this.heightLabel.Text = "Height: ";
            // 
            // heightUpDown
            // 
            this.heightUpDown.Location = new System.Drawing.Point(358, 20);
            this.heightUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.heightUpDown.Name = "heightUpDown";
            this.heightUpDown.Size = new System.Drawing.Size(120, 22);
            this.heightUpDown.TabIndex = 6;
            this.heightUpDown.ValueChanged += new System.EventHandler(this.heightUpDown_ValueChanged);
            // 
            // widthUpDown
            // 
            this.widthUpDown.Location = new System.Drawing.Point(358, 53);
            this.widthUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.widthUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.widthUpDown.Name = "widthUpDown";
            this.widthUpDown.Size = new System.Drawing.Size(120, 22);
            this.widthUpDown.TabIndex = 8;
            this.widthUpDown.ValueChanged += new System.EventHandler(this.widthUpDown_ValueChanged);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(305, 55);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(48, 17);
            this.widthLabel.TabIndex = 7;
            this.widthLabel.Text = "Width:";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.widthUpDown);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightUpDown);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.actionPicker);
            this.Controls.Add(this.shapePicker);
            this.Controls.Add(this.screenBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphic Editor";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Editor_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.screenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox screenBox;
        private System.Windows.Forms.ListBox shapePicker;
        private System.Windows.Forms.ListBox actionPicker;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.NumericUpDown heightUpDown;
        private System.Windows.Forms.NumericUpDown widthUpDown;
        private System.Windows.Forms.Label widthLabel;
    }
}

