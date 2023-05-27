
namespace Seken_top
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
            this.components = new System.ComponentModel.Container();
            this.Ball = new System.Windows.Forms.Button();
            this.Wall = new System.Windows.Forms.Panel();
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.DarkMagenta;
            this.Ball.FlatAppearance.BorderSize = 0;
            this.Ball.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ball.Location = new System.Drawing.Point(12, 92);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(35, 35);
            this.Ball.TabIndex = 0;
            this.Ball.UseVisualStyleBackColor = false;
            this.Ball.Click += new System.EventHandler(this.Tick_Tick);
            // 
            // Wall
            // 
            this.Wall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Wall.Location = new System.Drawing.Point(240, 150);
            this.Wall.Name = "Wall";
            this.Wall.Size = new System.Drawing.Size(10, 200);
            this.Wall.TabIndex = 1;
            // 
            // Tick
            // 
            this.Tick.Enabled = true;
            this.Tick.Interval = 1;
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.Wall);
            this.Controls.Add(this.Ball);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ball;
        private System.Windows.Forms.Panel Wall;
        private System.Windows.Forms.Timer Tick;
    }
}

