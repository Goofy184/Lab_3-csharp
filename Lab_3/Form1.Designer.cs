
namespace Lab_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CenterX = new System.Windows.Forms.TextBox();
            this.CenterY = new System.Windows.Forms.TextBox();
            this.PointX = new System.Windows.Forms.TextBox();
            this.PointY = new System.Windows.Forms.TextBox();
            this.Radius = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Центр кола";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Координати точки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Радіус кола";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Обчислити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CenterX
            // 
            this.CenterX.Location = new System.Drawing.Point(97, 25);
            this.CenterX.Name = "CenterX";
            this.CenterX.Size = new System.Drawing.Size(64, 20);
            this.CenterX.TabIndex = 7;
            // 
            // CenterY
            // 
            this.CenterY.Location = new System.Drawing.Point(97, 60);
            this.CenterY.Name = "CenterY";
            this.CenterY.Size = new System.Drawing.Size(64, 20);
            this.CenterY.TabIndex = 8;
            // 
            // PointX
            // 
            this.PointX.Location = new System.Drawing.Point(228, 25);
            this.PointX.Name = "PointX";
            this.PointX.Size = new System.Drawing.Size(64, 20);
            this.PointX.TabIndex = 9;
            // 
            // PointY
            // 
            this.PointY.Location = new System.Drawing.Point(228, 60);
            this.PointY.Name = "PointY";
            this.PointY.Size = new System.Drawing.Size(64, 20);
            this.PointY.TabIndex = 10;
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(8, 25);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(64, 20);
            this.Radius.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 236);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.PointY);
            this.Controls.Add(this.PointX);
            this.Controls.Add(this.CenterY);
            this.Controls.Add(this.CenterX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CenterX;
        private System.Windows.Forms.TextBox CenterY;
        private System.Windows.Forms.TextBox PointX;
        private System.Windows.Forms.TextBox PointY;
        private System.Windows.Forms.TextBox Radius;
    }
}

