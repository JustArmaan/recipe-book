using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Quiz2
{
    public partial class checkBoxFavorite : Form
    {
        ToolTip toolTip1 = new ToolTip();
        public checkBoxFavorite()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 255, 255);


        }
        private MySqlConnection createDbConnection()
        {
            string server = "localhost";
            string uid = "quiz2user";
            string password = "password";
            string database = "recipe_book";

            string connect = $"server={server};uid={uid};pwd={password};database={database}";
            return new MySqlConnection(connect);
        }


        private void viewAllRecipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        public bool IsFavorite
        {
            get { return checkcheckBoxFavoriteBox1.Checked; }
        }

        private void viewFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        public string RecipeName
        {
            get { return textBoxRecipeName.Text.Trim(); }
        }
        public string Description
        {
            get { return richTextBox1.Text.Trim(); }
        }
 
        private void textBoxRecipeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            buttonAddRecipe.Enabled = false;

            string recipeName = textBoxRecipeName.Text;
            string ingredients = richTextBox2.Text.Trim(); 
            string directions = richTextBox1.Text.Trim();  
            string description = richTextBox3.Text.Trim();
            bool isFavorite = checkcheckBoxFavoriteBox1.Checked;
            byte[] imageBytes = null;

            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }
            }
            else
            {
                imageBytes = null; 
            }


            if (string.IsNullOrEmpty(recipeName) || string.IsNullOrEmpty(ingredients) ||
                string.IsNullOrEmpty(directions))
            {
                MessageBox.Show("Please fill all the fields.");
                buttonAddRecipe.Enabled = true;
                return;
            }

            string query = "INSERT INTO Recipes (Name, Ingredients, Directions, Description, IsFavorite, RecipeImage) " +
                           "VALUES (@Name, @Ingredients, @Directions, @Description, @IsFavorite, @RecipeImage)";

            using (MySqlConnection mySqlConnection = createDbConnection())
            {
                try
                {
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                    mySqlCommand.Parameters.AddWithValue("@Name", recipeName);
                    mySqlCommand.Parameters.AddWithValue("@Ingredients", ingredients);
                    mySqlCommand.Parameters.AddWithValue("@Directions", directions);
                    mySqlCommand.Parameters.AddWithValue("@Description", description); 
                    mySqlCommand.Parameters.AddWithValue("@IsFavorite", isFavorite);
                    mySqlCommand.Parameters.AddWithValue("@RecipeImage", imageBytes);

                    int result = mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show(result > 0 ? "Recipe added successfully." : "Failed to add recipe.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    buttonAddRecipe.Enabled = true;
                }
            }
        }




        private void addRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png)|*.jpg; *.jpeg; *.gif; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void checkBoxFavorite_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button2, "Add a picture of your recipe");
    toolTip1.SetToolTip(buttonAddRecipe, "Click to add recipe");
    
    button2.DialogResult = DialogResult.None;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
