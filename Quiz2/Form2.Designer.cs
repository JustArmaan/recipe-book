namespace Quiz2
{
    partial class checkBoxFavorite
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
            this.enter = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecipeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllRecipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddRecipe = new System.Windows.Forms.Button();
            this.textBoxRecipeName = new System.Windows.Forms.TextBox();
            this.checkcheckBoxFavoriteBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.AutoSize = true;
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.ForeColor = System.Drawing.Color.Maroon;
            this.enter.Location = new System.Drawing.Point(54, 92);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(250, 31);
            this.enter.TabIndex = 0;
            this.enter.Text = "Enter Recipe Name";
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
            this.menuStrip1.Size = new System.Drawing.Size(896, 48);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // addRecipeToolStripMenuItem
            // 
            this.addRecipeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecipeToolStripMenuItem1,
            this.viewAllRecipesToolStripMenuItem,
            this.viewFavoritesToolStripMenuItem});
            this.addRecipeToolStripMenuItem.Name = "addRecipeToolStripMenuItem";
            this.addRecipeToolStripMenuItem.Size = new System.Drawing.Size(114, 40);
            this.addRecipeToolStripMenuItem.Text = "Recipes";
            this.addRecipeToolStripMenuItem.Click += new System.EventHandler(this.addRecipeToolStripMenuItem_Click);
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
            this.viewAllRecipesToolStripMenuItem.Click += new System.EventHandler(this.viewAllRecipesToolStripMenuItem_Click);
            // 
            // viewFavoritesToolStripMenuItem
            // 
            this.viewFavoritesToolStripMenuItem.Name = "viewFavoritesToolStripMenuItem";
            this.viewFavoritesToolStripMenuItem.Size = new System.Drawing.Size(319, 44);
            this.viewFavoritesToolStripMenuItem.Text = "View Favorites";
            this.viewFavoritesToolStripMenuItem.Click += new System.EventHandler(this.viewFavoritesToolStripMenuItem_Click);
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(81, 40);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // buttonAddRecipe
            // 
            this.buttonAddRecipe.BackColor = System.Drawing.Color.Maroon;
            this.buttonAddRecipe.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRecipe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddRecipe.Location = new System.Drawing.Point(59, 673);
            this.buttonAddRecipe.Name = "buttonAddRecipe";
            this.buttonAddRecipe.Size = new System.Drawing.Size(224, 60);
            this.buttonAddRecipe.TabIndex = 2;
            this.buttonAddRecipe.Text = "Add Recipe";
            this.buttonAddRecipe.UseVisualStyleBackColor = false;
            this.buttonAddRecipe.Click += new System.EventHandler(this.buttonAddRecipe_Click);
            // 
            // textBoxRecipeName
            // 
            this.textBoxRecipeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textBoxRecipeName.Location = new System.Drawing.Point(59, 130);
            this.textBoxRecipeName.Name = "textBoxRecipeName";
            this.textBoxRecipeName.Size = new System.Drawing.Size(224, 31);
            this.textBoxRecipeName.TabIndex = 3;
            this.textBoxRecipeName.Text = "Enter Name";
            this.textBoxRecipeName.TextChanged += new System.EventHandler(this.textBoxRecipeName_TextChanged);
            // 
            // checkcheckBoxFavoriteBox1
            // 
            this.checkcheckBoxFavoriteBox1.AutoSize = true;
            this.checkcheckBoxFavoriteBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.checkcheckBoxFavoriteBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkcheckBoxFavoriteBox1.Location = new System.Drawing.Point(59, 402);
            this.checkcheckBoxFavoriteBox1.Name = "checkcheckBoxFavoriteBox1";
            this.checkcheckBoxFavoriteBox1.Size = new System.Drawing.Size(252, 35);
            this.checkcheckBoxFavoriteBox1.TabIndex = 4;
            this.checkcheckBoxFavoriteBox1.Text = "Favourite Recipe";
            this.checkcheckBoxFavoriteBox1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(468, 673);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 60);
            this.button2.TabIndex = 6;
            this.button2.Text = "Upload Image";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(463, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recipe Image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.pictureBox1.Location = new System.Drawing.Point(468, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 278);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(54, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Directions";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.richTextBox1.Location = new System.Drawing.Point(59, 501);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(224, 140);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(54, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ingredients";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.richTextBox2.Location = new System.Drawing.Point(59, 219);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(224, 140);
            this.richTextBox2.TabIndex = 13;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.richTextBox3.Location = new System.Drawing.Point(468, 501);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(348, 140);
            this.richTextBox3.TabIndex = 15;
            this.richTextBox3.Text = "";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(463, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Description";
            // 
            // checkBoxFavorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 834);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkcheckBoxFavoriteBox1);
            this.Controls.Add(this.textBoxRecipeName);
            this.Controls.Add(this.buttonAddRecipe);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.enter);
            this.Name = "checkBoxFavorite";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.checkBoxFavorite_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecipeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewAllRecipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFavoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.Button buttonAddRecipe;
        private System.Windows.Forms.TextBox textBoxRecipeName;
        private System.Windows.Forms.CheckBox checkcheckBoxFavoriteBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label4;
    }
}