namespace Quiz2
{
    partial class LoginRegister
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
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button2;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to RecipeBook\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(270, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login to begin";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            button1.FlatAppearance.BorderSize = 5;
            button1.ForeColor = System.Drawing.Color.Black;
            button1.Location = new System.Drawing.Point(506, 348);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(191, 59);
            button1.TabIndex = 9;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            button2.FlatAppearance.BorderSize = 5;
            button2.ForeColor = System.Drawing.Color.Black;
            button2.Location = new System.Drawing.Point(89, 348);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(191, 59);
            button2.TabIndex = 10;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(button2);
            this.Controls.Add(button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginRegister";
            this.Text = "LoginRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}