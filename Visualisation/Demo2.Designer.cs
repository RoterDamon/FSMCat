﻿namespace Visualisation
{
    partial class Demo2
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

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_play = new System.Windows.Forms.Button();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.roomPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(481, 32);
            this.btn_play.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(35, 37);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = ">";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.PlayButton);
            // 
            // pb_image
            // 
            this.pb_image.Image = global::Visualisation.Properties.Resources.Cat;
            this.pb_image.Location = new System.Drawing.Point(175, 306);
            this.pb_image.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(45, 44);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_image.TabIndex = 5;
            this.pb_image.TabStop = false;
            // 
            // roomPictureBox
            // 
            this.roomPictureBox.Image = global::Visualisation.Properties.Resources.RoomWithEat;
            this.roomPictureBox.Location = new System.Drawing.Point(0, 0);
            this.roomPictureBox.Name = "roomPictureBox";
            this.roomPictureBox.Size = new System.Drawing.Size(445, 443);
            this.roomPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roomPictureBox.TabIndex = 6;
            this.roomPictureBox.TabStop = false;
            this.roomPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.roomPictureBox_MouseClick);
            // 
            // Demo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.roomPictureBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Demo2";
            this.Size = new System.Drawing.Size(538, 492);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.PictureBox roomPictureBox;
    }
}
