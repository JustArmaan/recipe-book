namespace Quiz2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecipeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllRecipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxRecipes = new System.Windows.Forms.ListBox();
            this.addRecipe = new System.Windows.Forms.Button();
            this.deleteRecipe = new System.Windows.Forms.Button();
            this.viewRecipe = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.updateRecipe = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.calender = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecipeToolStripMenuItem,
            this.filesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1491, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addRecipeToolStripMenuItem
            // 
            this.addRecipeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecipeToolStripMenuItem1,
            this.viewAllRecipesToolStripMenuItem,
            this.viewFavoritesToolStripMenuItem});
            this.addRecipeToolStripMenuItem.Name = "addRecipeToolStripMenuItem";
            this.addRecipeToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
            this.addRecipeToolStripMenuItem.Text = "Recipes";
            // 
            // addRecipeToolStripMenuItem1
            // 
            this.addRecipeToolStripMenuItem1.Name = "addRecipeToolStripMenuItem1";
            this.addRecipeToolStripMenuItem1.Size = new System.Drawing.Size(319, 44);
            this.addRecipeToolStripMenuItem1.Text = "Add Recipe";
            // 
            // viewAllRecipesToolStripMenuItem
            // 
            this.viewAllRecipesToolStripMenuItem.Name = "viewAllRecipesToolStripMenuItem";
            this.viewAllRecipesToolStripMenuItem.Size = new System.Drawing.Size(319, 44);
            this.viewAllRecipesToolStripMenuItem.Text = "View All Recipes";
            // 
            // viewFavoritesToolStripMenuItem
            // 
            this.viewFavoritesToolStripMenuItem.Name = "viewFavoritesToolStripMenuItem";
            this.viewFavoritesToolStripMenuItem.Size = new System.Drawing.Size(319, 44);
            this.viewFavoritesToolStripMenuItem.Text = "View Favorites";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(196, 36);
            this.filesToolStripMenuItem.Text = "Download Files";
            // 
            // listBoxRecipes
            // 
            this.listBoxRecipes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.listBoxRecipes.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listBoxRecipes.FormattingEnabled = true;
            this.listBoxRecipes.ItemHeight = 25;
            this.listBoxRecipes.Location = new System.Drawing.Point(52, 197);
            this.listBoxRecipes.Name = "listBoxRecipes";
            this.listBoxRecipes.Size = new System.Drawing.Size(219, 429);
            this.listBoxRecipes.TabIndex = 1;
            this.listBoxRecipes.SelectedIndexChanged += new System.EventHandler(this.listBoxRecipes_SelectedIndexChanged);
            // 
            // addRecipe
            // 
            this.addRecipe.BackColor = System.Drawing.Color.Maroon;
            this.addRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecipe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addRecipe.Location = new System.Drawing.Point(52, 670);
            this.addRecipe.Name = "addRecipe";
            this.addRecipe.Size = new System.Drawing.Size(167, 58);
            this.addRecipe.TabIndex = 3;
            this.addRecipe.Text = "Add Recipe";
            this.addRecipe.UseVisualStyleBackColor = false;
            this.addRecipe.Click += new System.EventHandler(this.addRecipe_Click);
            // 
            // deleteRecipe
            // 
            this.deleteRecipe.BackColor = System.Drawing.Color.Maroon;
            this.deleteRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRecipe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteRecipe.Location = new System.Drawing.Point(673, 670);
            this.deleteRecipe.Name = "deleteRecipe";
            this.deleteRecipe.Size = new System.Drawing.Size(203, 58);
            this.deleteRecipe.TabIndex = 4;
            this.deleteRecipe.Text = "Delete Recipe";
            this.deleteRecipe.UseVisualStyleBackColor = false;
            this.deleteRecipe.Click += new System.EventHandler(this.deleteRecipe_Click);
            // 
            // viewRecipe
            // 
            this.viewRecipe.BackColor = System.Drawing.Color.Maroon;
            this.viewRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRecipe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewRecipe.Location = new System.Drawing.Point(901, 670);
            this.viewRecipe.Name = "viewRecipe";
            this.viewRecipe.Size = new System.Drawing.Size(178, 58);
            this.viewRecipe.TabIndex = 5;
            this.viewRecipe.Text = "View Recipe";
            this.viewRecipe.UseVisualStyleBackColor = false;
            this.viewRecipe.Click += new System.EventHandler(this.viewRecipe_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 784);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1491, 42);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(237, 32);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // updateRecipe
            // 
            this.updateRecipe.BackColor = System.Drawing.Color.Maroon;
            this.updateRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRecipe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateRecipe.Location = new System.Drawing.Point(436, 670);
            this.updateRecipe.Name = "updateRecipe";
            this.updateRecipe.Size = new System.Drawing.Size(211, 58);
            this.updateRecipe.TabIndex = 8;
            this.updateRecipe.Text = "Update Recipe";
            this.updateRecipe.UseVisualStyleBackColor = false;
            this.updateRecipe.Click += new System.EventHandler(this.updateRecipe_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Created First",
            "Created Last",
            "Favourited"});
            this.comboBox1.Location = new System.Drawing.Point(52, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(47, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sort By";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(244, 670);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 58);
            this.button1.TabIndex = 11;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(326, 197);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1054, 438);
            this.flowLayoutPanel1.TabIndex = 12;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 259);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // calender
            // 
            this.calender.BackColor = System.Drawing.Color.Maroon;
            this.calender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calender.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calender.Location = new System.Drawing.Point(1105, 670);
            this.calender.Name = "calender";
            this.calender.Size = new System.Drawing.Size(167, 58);
            this.calender.TabIndex = 13;
            this.calender.Text = "Calender";
            this.calender.UseVisualStyleBackColor = false;
            this.calender.Click += new System.EventHandler(this.calender_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 826);
            this.Controls.Add(this.calender);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.updateRecipe);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.viewRecipe);
            this.Controls.Add(this.deleteRecipe);
            this.Controls.Add(this.addRecipe);
            this.Controls.Add(this.listBoxRecipes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecipeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewAllRecipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFavoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxRecipes;
        private System.Windows.Forms.Button addRecipe;
        private System.Windows.Forms.Button deleteRecipe;
        private System.Windows.Forms.Button viewRecipe;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button updateRecipe;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button calender;
    }
}

