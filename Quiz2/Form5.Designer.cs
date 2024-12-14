namespace Quiz2
{
    partial class Form5
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBoxMeal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddMeal = new System.Windows.Forms.Button();
            this.listBoxMeals = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.monthCalendar1.Location = new System.Drawing.Point(51, 52);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // textBoxMeal
            // 
            this.textBoxMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textBoxMeal.Location = new System.Drawing.Point(132, 435);
            this.textBoxMeal.Name = "textBoxMeal";
            this.textBoxMeal.Size = new System.Drawing.Size(293, 31);
            this.textBoxMeal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(45, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Meal";
            // 
            // buttonAddMeal
            // 
            this.buttonAddMeal.BackColor = System.Drawing.Color.Maroon;
            this.buttonAddMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMeal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddMeal.Location = new System.Drawing.Point(556, 417);
            this.buttonAddMeal.Name = "buttonAddMeal";
            this.buttonAddMeal.Size = new System.Drawing.Size(236, 49);
            this.buttonAddMeal.TabIndex = 3;
            this.buttonAddMeal.Text = "Add Meal";
            this.buttonAddMeal.UseVisualStyleBackColor = false;
            // 
            // listBoxMeals
            // 
            this.listBoxMeals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.listBoxMeals.FormattingEnabled = true;
            this.listBoxMeals.ItemHeight = 25;
            this.listBoxMeals.Location = new System.Drawing.Point(556, 90);
            this.listBoxMeals.Name = "listBoxMeals";
            this.listBoxMeals.Size = new System.Drawing.Size(236, 279);
            this.listBoxMeals.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(550, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Meals";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 639);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxMeals);
            this.Controls.Add(this.buttonAddMeal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMeal);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBoxMeal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddMeal;
        private System.Windows.Forms.ListBox listBoxMeals;
        private System.Windows.Forms.Label label2;
    }
}