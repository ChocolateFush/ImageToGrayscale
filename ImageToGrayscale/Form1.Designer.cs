namespace ImageToGrayscale
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
            this.open_button = new System.Windows.Forms.Button();
            this.picture_box = new System.Windows.Forms.PictureBox();
            this.grayscale_button = new System.Windows.Forms.Button();
            this.g_blur_button = new System.Windows.Forms.Button();
            this.edge_detect = new System.Windows.Forms.Button();
            this.sensitivity = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivity)).BeginInit();
            this.SuspendLayout();
            // 
            // open_button
            // 
            this.open_button.Location = new System.Drawing.Point(13, 13);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(75, 23);
            this.open_button.TabIndex = 0;
            this.open_button.Text = "Open";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // picture_box
            // 
            this.picture_box.Location = new System.Drawing.Point(1, 86);
            this.picture_box.Name = "picture_box";
            this.picture_box.Size = new System.Drawing.Size(259, 175);
            this.picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture_box.TabIndex = 1;
            this.picture_box.TabStop = false;
            // 
            // grayscale_button
            // 
            this.grayscale_button.Location = new System.Drawing.Point(107, 12);
            this.grayscale_button.Name = "grayscale_button";
            this.grayscale_button.Size = new System.Drawing.Size(75, 23);
            this.grayscale_button.TabIndex = 2;
            this.grayscale_button.Text = "Grayscale";
            this.grayscale_button.UseVisualStyleBackColor = true;
            this.grayscale_button.Click += new System.EventHandler(this.grayscale_button_Click);
            // 
            // g_blur_button
            // 
            this.g_blur_button.Location = new System.Drawing.Point(205, 13);
            this.g_blur_button.Name = "g_blur_button";
            this.g_blur_button.Size = new System.Drawing.Size(75, 38);
            this.g_blur_button.TabIndex = 3;
            this.g_blur_button.Text = "Gaussian Blur";
            this.g_blur_button.UseVisualStyleBackColor = true;
            this.g_blur_button.Click += new System.EventHandler(this.g_blur_button_Click);
            // 
            // edge_detect
            // 
            this.edge_detect.Location = new System.Drawing.Point(314, 13);
            this.edge_detect.Name = "edge_detect";
            this.edge_detect.Size = new System.Drawing.Size(75, 23);
            this.edge_detect.TabIndex = 4;
            this.edge_detect.Text = "Edge Detect";
            this.edge_detect.UseVisualStyleBackColor = true;
            this.edge_detect.Click += new System.EventHandler(this.edge_detect_Click);
            // 
            // sensitivity
            // 
            this.sensitivity.Location = new System.Drawing.Point(314, 55);
            this.sensitivity.Name = "sensitivity";
            this.sensitivity.Size = new System.Drawing.Size(104, 45);
            this.sensitivity.TabIndex = 5;
            this.sensitivity.Value = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(445, 265);
            this.Controls.Add(this.sensitivity);
            this.Controls.Add(this.edge_detect);
            this.Controls.Add(this.g_blur_button);
            this.Controls.Add(this.grayscale_button);
            this.Controls.Add(this.picture_box);
            this.Controls.Add(this.open_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.PictureBox picture_box;
        private System.Windows.Forms.Button grayscale_button;
        private System.Windows.Forms.Button g_blur_button;
        private System.Windows.Forms.Button edge_detect;
        private System.Windows.Forms.TrackBar sensitivity;
    }
}

