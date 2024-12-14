namespace Quiz2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel scrollablePanel;
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelRecipeName = new System.Windows.Forms.Label();
            this.labelCookingTime = new System.Windows.Forms.Label();
            this.ingredients = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelCreatedAt = new System.Windows.Forms.Label();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.directions = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.remaining = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.checkedListBoxDirections = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(812, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelRecipeName
            // 
            this.labelRecipeName.AutoSize = true;
            this.labelRecipeName.BackColor = System.Drawing.Color.Transparent;
            this.labelRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecipeName.Location = new System.Drawing.Point(7, 317);
            this.labelRecipeName.Name = "labelRecipeName";
            this.labelRecipeName.Size = new System.Drawing.Size(173, 63);
            this.labelRecipeName.TabIndex = 9;
            this.labelRecipeName.Text = "label4";
            this.labelRecipeName.Click += new System.EventHandler(this.labelRecipeName_Click);
            // 
            // labelCookingTime
            // 
            this.labelCookingTime.AutoSize = true;
            this.labelCookingTime.Location = new System.Drawing.Point(566, 550);
            this.labelCookingTime.Name = "labelCookingTime";
            this.labelCookingTime.Size = new System.Drawing.Size(0, 25);
            this.labelCookingTime.TabIndex = 10;
            this.labelCookingTime.Click += new System.EventHandler(this.label4_Click);
            // 
            // ingredients
            // 
            this.ingredients.AutoSize = true;
            this.ingredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredients.ForeColor = System.Drawing.Color.Maroon;
            this.ingredients.Location = new System.Drawing.Point(12, 469);
            this.ingredients.Name = "ingredients";
            this.ingredients.Size = new System.Drawing.Size(149, 31);
            this.ingredients.TabIndex = 11;
            this.ingredients.Text = "Ingredients";
            this.ingredients.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textBox1.Location = new System.Drawing.Point(571, 380);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 31);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelCreatedAt
            // 
            this.labelCreatedAt.AutoSize = true;
            this.labelCreatedAt.BackColor = System.Drawing.Color.Transparent;
            this.labelCreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatedAt.Location = new System.Drawing.Point(12, 398);
            this.labelCreatedAt.Name = "labelCreatedAt";
            this.labelCreatedAt.Size = new System.Drawing.Size(194, 31);
            this.labelCreatedAt.TabIndex = 13;
            this.labelCreatedAt.Text = "labelCreatedAt";
            this.labelCreatedAt.Click += new System.EventHandler(this.labelCreatedAt_Click);
            // 
            // directions
            // 
            this.directions.AutoSize = true;
            this.directions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directions.ForeColor = System.Drawing.Color.Maroon;
            this.directions.Location = new System.Drawing.Point(12, 699);
            this.directions.Name = "directions";
            this.directions.Size = new System.Drawing.Size(136, 31);
            this.directions.TabIndex = 14;
            this.directions.Text = "Directions";
            this.directions.Click += new System.EventHandler(this.directions_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.richTextBox1.Location = new System.Drawing.Point(18, 513);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(384, 138);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 958);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 31);
            this.textBox2.TabIndex = 17;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 924);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Minutes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 942);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 47);
            this.button1.TabIndex = 19;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // remaining
            // 
            this.remaining.AutoSize = true;
            this.remaining.Location = new System.Drawing.Point(13, 1016);
            this.remaining.Name = "remaining";
            this.remaining.Size = new System.Drawing.Size(70, 25);
            this.remaining.TabIndex = 20;
            this.remaining.Text = "label2";
            this.remaining.Click += new System.EventHandler(this.remaining_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(18, 1049);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(801, 90);
            this.trackBar1.TabIndex = 21;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // checkedListBoxDirections
            // 
            this.checkedListBoxDirections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.checkedListBoxDirections.FormattingEnabled = true;
            this.checkedListBoxDirections.Location = new System.Drawing.Point(18, 751);
            this.checkedListBoxDirections.Name = "checkedListBoxDirections";
            this.checkedListBoxDirections.Size = new System.Drawing.Size(384, 144);
            this.checkedListBoxDirections.TabIndex = 22;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 1342);
            this.Controls.Add(this.checkedListBoxDirections);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.remaining);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.directions);
            this.Controls.Add(this.labelCreatedAt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ingredients);
            this.Controls.Add(this.labelCookingTime);
            this.Controls.Add(this.labelRecipeName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRecipeName;
        private System.Windows.Forms.Label labelCookingTime;
        private System.Windows.Forms.Label ingredients;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelCreatedAt;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Label directions;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label remaining;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckedListBox checkedListBoxDirections;
    }
}