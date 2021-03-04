namespace Tic_Tac_Toe_With_AI
{
    partial class Form2
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
            this.P1 = new System.Windows.Forms.Label();
            this.P2 = new System.Windows.Forms.Label();
            this.T1 = new System.Windows.Forms.TextBox();
            this.T2 = new System.Windows.Forms.TextBox();
            this.StartB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // P1
            // 
            this.P1.AutoSize = true;
            this.P1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1.Location = new System.Drawing.Point(12, 19);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(173, 25);
            this.P1.TabIndex = 0;
            this.P1.Text = "Player 1 Name ";
            // 
            // P2
            // 
            this.P2.AutoSize = true;
            this.P2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2.Location = new System.Drawing.Point(12, 49);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(173, 25);
            this.P2.TabIndex = 1;
            this.P2.Text = "Player 2 Name ";
            // 
            // T1
            // 
            this.T1.Location = new System.Drawing.Point(191, 25);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(240, 20);
            this.T1.TabIndex = 2;
            // 
            // T2
            // 
            this.T2.Location = new System.Drawing.Point(189, 54);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(240, 20);
            this.T2.TabIndex = 3;
            this.T2.TextChanged += new System.EventHandler(this.T2_TextChanged);
            this.T2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p2);
            // 
            // StartB
            // 
            this.StartB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartB.Location = new System.Drawing.Point(354, 80);
            this.StartB.Name = "StartB";
            this.StartB.Size = new System.Drawing.Size(75, 23);
            this.StartB.TabIndex = 4;
            this.StartB.Text = "Start";
            this.StartB.UseVisualStyleBackColor = true;
            this.StartB.Click += new System.EventHandler(this.StartB_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 113);
            this.Controls.Add(this.StartB);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label P1;
        private System.Windows.Forms.Label P2;
        private System.Windows.Forms.TextBox T1;
        private System.Windows.Forms.TextBox T2;
        private System.Windows.Forms.Button StartB;
    }
}