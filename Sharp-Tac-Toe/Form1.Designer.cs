﻿namespace Sharp_Tac_Toe
{
    partial class frmGameBoard
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
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Lucida Sans Unicode", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(12, 12);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(136, 120);
            this.btn0.TabIndex = 0;
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Lucida Sans Unicode", 72F, System.Drawing.FontStyle.Bold);
            this.btn1.Location = new System.Drawing.Point(165, 12);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(136, 120);
            this.btn1.TabIndex = 1;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Lucida Sans Unicode", 72F, System.Drawing.FontStyle.Bold);
            this.btn2.Location = new System.Drawing.Point(316, 12);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(136, 120);
            this.btn2.TabIndex = 2;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Lucida Sans Unicode", 72F, System.Drawing.FontStyle.Bold);
            this.btn3.Location = new System.Drawing.Point(12, 150);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(136, 120);
            this.btn3.TabIndex = 3;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Lucida Sans Unicode", 72F, System.Drawing.FontStyle.Bold);
            this.btn4.Location = new System.Drawing.Point(165, 150);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(136, 120);
            this.btn4.TabIndex = 4;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Lucida Sans Unicode", 72F, System.Drawing.FontStyle.Bold);
            this.btn5.Location = new System.Drawing.Point(316, 150);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(136, 120);
            this.btn5.TabIndex = 5;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Lucida Sans Unicode", 72F, System.Drawing.FontStyle.Bold);
            this.btn6.Location = new System.Drawing.Point(12, 287);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(136, 120);
            this.btn6.TabIndex = 6;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Lucida Sans Unicode", 72F, System.Drawing.FontStyle.Bold);
            this.btn7.Location = new System.Drawing.Point(165, 287);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(136, 120);
            this.btn7.TabIndex = 7;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Lucida Sans Unicode", 72F, System.Drawing.FontStyle.Bold);
            this.btn8.Location = new System.Drawing.Point(316, 287);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(136, 120);
            this.btn8.TabIndex = 8;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Button_Click);
            // 
            // frmGameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 428);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Name = "frmGameBoard";
            this.Text = "Sharp-Tac-Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
    }
}

