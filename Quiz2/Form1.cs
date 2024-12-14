    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using MySql.Data.MySqlClient;

    namespace Quiz2
    {
        public partial class Form1 : Form
        {
            private List<Recipe> recipes = new List<Recipe>();

            public Form1()
            {
            InitializeComponent();
            LoadRecipesFromDatabase();
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.WrapContents = true;
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

            public class Recipe
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Description { get; set; }
                public bool IsFavorite { get; set; }

                public Recipe(int id, string name, string description, bool isFavorite)
                {
                    Id = id;
                    Name = name;
                    Description = description;
                    IsFavorite = isFavorite;
                }

                public override string ToString()
                {
                    return IsFavorite ? $"{Name} (Favorite)" : Name;
                }
            }

        private void LoadRecipesFromDatabase()
        {
            string sortOrder = comboBox1.SelectedItem?.ToString() ?? "Created First";
            string orderByClause = "ORDER BY CreatedAt ASC";

            if (sortOrder == "Created Last")
            {
                orderByClause = "ORDER BY CreatedAt DESC";
            }
            else if (sortOrder == "Favourited")
            {
                orderByClause = "ORDER BY IsFavorite DESC, CreatedAt DESC";
            }

            string query = $"SELECT Id, Name, Description, IsFavorite FROM Recipes {orderByClause}";

            try
            {
                using (MySqlConnection connection = createDbConnection())
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    recipes.Clear();
                    listBoxRecipes.Items.Clear();
                    flowLayoutPanel1.Controls.Clear();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32("Id");
                        string name = reader.GetString("Name");
                        string description = reader.GetString("Description");
                        bool isFavorite = reader.GetBoolean("IsFavorite");

                        Recipe recipe = new Recipe(id, name, description, isFavorite);
                        recipes.Add(recipe);

                        listBoxRecipes.Items.Add(recipe);

                        Panel recipePanel = new Panel
                        {
                            Width = 150,
                            Height = 200,
                            BorderStyle = BorderStyle.FixedSingle,
                            Margin = new Padding(10)
                        };

                        PictureBox recipeImage = new PictureBox
                        {
                            Width = 140,
                            Height = 140,
                            Image = LoadRecipeImage(id),
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Dock = DockStyle.Top
                        };

                        // Attach the Click event handler to the picture box
                        recipeImage.Click += (sender, e) => OnRecipeImageClick(recipe);

                        Label recipeLabel = new Label
                        {
                            Text = recipe.Name,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.Bottom,
                            Font = new Font("Arial", 10, FontStyle.Bold),
                            AutoSize = false,
                            Height = 40
                        };

                        recipePanel.Controls.Add(recipeImage);
                        recipePanel.Controls.Add(recipeLabel);
                        flowLayoutPanel1.Controls.Add(recipePanel);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading recipes: {ex.Message}");
            }
        }
        private void OnRecipeImageClick(Recipe recipe)
        {
            var viewRecipeForm = new Form3(recipe);
            viewRecipeForm.ShowDialog();
        }



        private Image LoadRecipeImage(int id)
        {
            try
            {
                // SQL query to get the image BLOB data
                string query = "SELECT RecipeImage FROM Recipes WHERE Id = @Id";

                using (MySqlConnection connection = createDbConnection())
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();

                    // Execute the command and read the BLOB data
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Check if the image exists in the database
                        if (!reader.IsDBNull(reader.GetOrdinal("RecipeImage")))
                        {
                            byte[] imageData = reader["RecipeImage"] as byte[];
                            if (imageData != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    // Convert byte[] to an Image and return
                                    return Image.FromStream(ms);
                                }
                            }
                        }
                    }
                }

                // Return a default image if not found
                return Image.FromFile("C:\\Users\\Singh\\source\\repos\\Quiz2\\Quiz2\\Onboard2.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image for recipe {id}: {ex.Message}");

                // Return a default image in case of error
                return Image.FromFile("C:\\Users\\Singh\\source\\repos\\Quiz2\\Quiz2\\Onboard2.jpg");
            }
        }


        private void AddRecipeToDatabase(string name, string description, bool isFavorite)
            {
                string query = "INSERT INTO Recipes (Name, Description, IsFavorite) VALUES (@Name, @Description, @IsFavorite)";
                using (MySqlConnection connection = createDbConnection())
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@IsFavorite", isFavorite);
                    command.ExecuteNonQuery();
                }
            }

            private void DeleteRecipeFromDatabase(int id)
            {
                string query = "DELETE FROM Recipes WHERE Id = @Id";
                using (MySqlConnection connection = createDbConnection())
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }

        private void addRecipe_Click(object sender, EventArgs e)
        {
            var addRecipeForm = new checkBoxFavorite();
            if (addRecipeForm.ShowDialog() == DialogResult.OK)
            {
                string recipeName = addRecipeForm.RecipeName;
                string recipeDescription = addRecipeForm.Description;
                bool isFavorite = addRecipeForm.IsFavorite;

                LoadRecipesFromDatabase();
                MessageBox.Show($"{recipeName} has been added.");
            }
        }


        private void viewRecipe_Click(object sender, EventArgs e)
            {
                if (listBoxRecipes.SelectedIndex != -1)
                {
                    Recipe selectedRecipe = (Recipe)listBoxRecipes.SelectedItem;
                    var viewRecipeForm = new Form3(selectedRecipe);
                    viewRecipeForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a recipe to view");
                }
            }

            private void deleteRecipe_Click(object sender, EventArgs e)
            {
                if (listBoxRecipes.SelectedIndex != -1)
                {
                    Recipe selectedRecipe = (Recipe)listBoxRecipes.SelectedItem;
                    DeleteRecipeFromDatabase(selectedRecipe.Id);
                    LoadRecipesFromDatabase();
                    MessageBox.Show($"{selectedRecipe.Name} has been deleted.");
                }
                else
                {
                    MessageBox.Show("Please select a recipe to delete");
                }
            }

            private void listView1_SelectedIndexChanged(object sender, EventArgs e)
            {
            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {
            }

            private void updateRecipe_Click(object sender, EventArgs e)
            {
                if (listBoxRecipes.SelectedIndex != -1)
                {
                    Recipe selectedRecipe = (Recipe)listBoxRecipes.SelectedItem;
                    var updateRecipeForm = new Form4(selectedRecipe.Id);
                    updateRecipeForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a recipe to edit");
                }
            }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                LoadRecipesFromDatabase();

            }

            private void button1_Click(object sender, EventArgs e)
            {
                string filePath = @"C:\Users\singh\Downloads\recipes.csv";

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    using (MySqlConnection connection = createDbConnection())
                    {
                        connection.Open();

                        string query = "SELECT Name, Description, IsFavorite FROM Recipes";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            writer.WriteLine("Name,Description,IsFavorite");

                            while (reader.Read())
                            {
                                string name = reader["Name"].ToString();
                                string description = reader["Description"].ToString();
                                string isFavorite = reader.GetBoolean("IsFavorite") ? "Yes" : "No";

                                name = name.Replace(",", "\\,");
                                description = description.Replace(",", "\\,");

                                writer.WriteLine($"{name},{description},{isFavorite}");
                            }
                        }
                    }
                    MessageBox.Show($"Recipes exported successfully to: {filePath}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while exporting recipes: {ex.Message}");
                }
            }

            private void listBoxRecipes_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox1_Click_1(object sender, EventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calender_Click(object sender, EventArgs e)
        {
            var calender = new Form5();
            calender.ShowDialog();
        }   
    }

    }

