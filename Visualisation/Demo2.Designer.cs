namespace Visualisation
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
            this.stateBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.yaePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yaePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(475, 32);
            this.btn_play.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(71, 37);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "Start";
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
            this.roomPictureBox.Image = global::Visualisation.Properties.Resources.RoomWithFood;
            this.roomPictureBox.Location = new System.Drawing.Point(0, 0);
            this.roomPictureBox.Name = "roomPictureBox";
            this.roomPictureBox.Size = new System.Drawing.Size(445, 443);
            this.roomPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roomPictureBox.TabIndex = 6;
            this.roomPictureBox.TabStop = false;
            this.roomPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.roomPictureBox_MouseClick);
            // 
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(475, 110);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(125, 27);
            this.stateBox.TabIndex = 7;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.stateLabel.Location = new System.Drawing.Point(475, 87);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(43, 20);
            this.stateLabel.TabIndex = 8;
            this.stateLabel.Text = "State";
            // 
            // yaePictureBox
            // 
            this.yaePictureBox.Image = global::Visualisation.Properties.Resources.Yae;
            this.yaePictureBox.Location = new System.Drawing.Point(325, 15);
            this.yaePictureBox.Name = "yaePictureBox";
            this.yaePictureBox.Size = new System.Drawing.Size(55, 64);
            this.yaePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yaePictureBox.TabIndex = 9;
            this.yaePictureBox.TabStop = false;
            // 
            // Demo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.yaePictureBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.roomPictureBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Demo2";
            this.Size = new System.Drawing.Size(610, 490);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yaePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.PictureBox roomPictureBox;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.PictureBox yaePictureBox;
    }
}
