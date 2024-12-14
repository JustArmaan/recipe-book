using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quiz2
{
    public partial class Form4 : Form
    {
        private string connectionString = "server=localhost;uid=quiz2user;pwd=password;database=recipe_book";
        private int recipeId;

        public Form4(int id)
        {
            InitializeComponent();
            recipeId = id;

            LoadRecipeDetails();
        }

        private void LoadRecipeDetails()
        {
            string query = "SELECT Name, Description, Ingredients, Directions FROM Recipes WHERE Id = @Id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", recipeId);

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        textBox1.Text = reader["Name"].ToString();
                        descriptions.Text = reader["Description"].ToString();
                        ingredients.Text = reader["Ingredients"].ToString();
                        directions.Text = reader["Directions"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading recipe: {ex.Message}");
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(ingredients.Text) || string.IsNullOrEmpty(directions.Text))
            {
                MessageBox.Show("Please fill out all required fields.");
                return;
            }

            string query = "UPDATE Recipes SET Name = @Name, Description = @Description, Ingredients = @Ingredients, Directions = @Directions WHERE Id = @Id";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", textBox1.Text);
                    command.Parameters.AddWithValue("@Description", descriptions.Text);
                    command.Parameters.AddWithValue("@Ingredients", ingredients.Text);
                    command.Parameters.AddWithValue("@Directions", directions.Text);
                    command.Parameters.AddWithValue("@Id", recipeId);
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0 ? "Recipe updated successfully!" : "No changes were made.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating recipe: {ex.Message}");
                }
            }
        


    }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void favourite_CheckedChanged(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }


        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif",
                Title = "Select a Recipe Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void update_Click_1(object sender, EventArgs e)
        {

        }
    }
}
