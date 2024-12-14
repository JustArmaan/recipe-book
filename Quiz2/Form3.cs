using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Quiz2.Form1;
using WMPLib;

namespace Quiz2
{
    public partial class Form3 : Form
    {
        private string connectionString = "server=localhost;uid=quiz2user;pwd=password;database=recipe_book";
        private Recipe currentRecipe;
        private Timer countdownTImer;
        private int remainingTime;

        public Form3(Recipe recipe)
        {
            InitializeComponent();

            currentRecipe = recipe;

            LoadRecipeDetails();
            this.BackColor = Color.FromArgb(255, 255, 255);

            countdownTimer = new Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += timer1_Tick;
        }

        private void LoadRecipeDetails()
        {
            string query = "SELECT Name, Ingredients, Directions, Description, RecipeImage, CreatedAt FROM Recipes WHERE Id = @Id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", currentRecipe.Id);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    labelRecipeName.Text = reader.GetString(0);

                    string ingredients = reader.IsDBNull(1) ? "No ingredients available." : reader.GetString(1);
                    richTextBox1.Text = ingredients;

                    string directions = reader.IsDBNull(2) ? "No directions available." : reader.GetString(2);
                    PopulateDirections(directions);

                    textBox1.Text = reader.IsDBNull(3) ? "No description available." : reader.GetString(3);

                    if (!reader.IsDBNull(5))
                    {
                        DateTime createdAt = reader.GetDateTime(5);
                        labelCreatedAt.Text = createdAt.ToString("MMM, dd");
                    }
                    else
                    {
                        labelCreatedAt.Text = "Not available.";
                    }

                    if (!reader.IsDBNull(4))
                    {
                        byte[] imageBytes = (byte[])reader["RecipeImage"];
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                }
            }
        }
        private void PopulateDirections(string directions)
        {
            checkedListBoxDirections.Items.Clear(); 
            var directionsList = directions.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < directionsList.Length; i++)
            {
                checkedListBoxDirections.Items.Add($"{i + 1}. {directionsList[i]}", false);
            }
        }

        private string AddNumberingToDirections(string directions)
        {
            var directionsList = directions.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < directionsList.Length; i++)
            {
                directionsList[i] = $"{i + 1}. {directionsList[i]}";
            }
            return string.Join(Environment.NewLine, directionsList);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 60;
            trackBar1.Value = 30;

            countdownTimer.Stop();

            //progressBar1.Minimum = 0;
            //progressBar1.Maximum = 100;
            //progressBar1.Value = 0;

            //countdownTimer.Start();

            ////TreeNode vegetarianNode = treeView1.Nodes.Add("Vegetarian");
            ////vegetarianNode.Nodes.Add("Salads");
            ////vegetarianNode.Nodes.Add("Bread");

            ////treeView1.Nodes.Add("Dessert");
            ////treeView1.Nodes.Add("Vegan");

            ////TreeNode mealNode = treeView1.Nodes.Add("Meal");
            //mealNode.Nodes.Add("Breakfast");
            //mealNode.Nodes.Add("Lunch");
            //mealNode.Nodes.Add("Dinner");

            //countdownTimer.Start();

        }



        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (radioButton1.Checked)
        //    {
        //        MessageBox.Show("Difficulty set to Easy.");
        //        progressBar1.Value = Math.Min(25, progressBar1.Maximum);
        //    }
        //}

        //private void radioButton2_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (radioButton2.Checked)
        //    {
        //        MessageBox.Show("Difficulty set to Medium.");
        //        progressBar1.Value = Math.Min(50, progressBar1.Maximum);
        //    }
        //}

        //private void radioButton3_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (radioButton3.Checked)
        //    {
        //        MessageBox.Show("Difficulty set to Hard.");
        //        progressBar1.Value = Math.Min(75, progressBar1.Maximum);
        //    }
        //}

        //private void trackBar1_Scroll(object sender, EventArgs e)
        //{
        //    int cookingTime = trackBar1.Value;
        //    labelCookingTime.Text = $"Cooking Time: {cookingTime} minutes";

        //    if (cookingTime <= 25)
        //    {
        //        this.BackColor = Color.LightGreen;
        //    }
        //    else if (cookingTime <= 50)
        //    {
        //        this.BackColor = Color.Gold;
        //    }
        //    else
        //    {
        //        this.BackColor = Color.IndianRed;
        //    }
        //}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show("Category selected: " + e.Node.Text);
        }

        //private void progressBar1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show($"{progressBar1.Value}%");
        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void directions_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelRecipeName_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int cookingTime = trackBar1.Value;
            remaining.Text = $"Cooking Time: {cookingTime} minutes";

            if (cookingTime <= 25)
            {
                this.BackColor = Color.LightGreen;
            }
            else if (cookingTime <= 50)
            {
                this.BackColor = Color.Gold;
            }
            else
            {
                this.BackColor = Color.IndianRed;
            }
        }

    private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int minutes))
            {
                remainingTime = minutes * 60;
                countdownTimer.Start();
                UpdateRemainingTimeLabel();
            }
            else
            {
                MessageBox.Show("Please enter a valid number in minutes.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void remaining_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (remainingTime > 0)
            {
                remainingTime--;
                UpdateRemainingTimeLabel();

                if (remainingTime > 1200)
                {
                    this.BackColor = Color.LightGreen;
                }
                else if (remainingTime > 600) 
                {
                    this.BackColor = Color.Gold;
                }
                else
                {

                }
            }
            else
            {
                countdownTimer.Stop();
                MessageBox.Show("Time's up!", "Timer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PlaySound();
            }
        }
        private void UpdateRemainingTimeLabel()
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(remainingTime);
            remaining.Text = $"Time Remaining: {timeSpan.Minutes}m {timeSpan.Seconds}s";
        }
        private void PlaySound()
        {
            try
            {
                string soundFilePath = "C:\\Users\\Singh\\source\\repos\\Quiz2\\Quiz2\\alarm.mp3";
                if (File.Exists(soundFilePath))
                {
                    WindowsMediaPlayer player = new WindowsMediaPlayer();
                    player.URL = soundFilePath;
                    player.controls.play();
                }
                else
                {
                    MessageBox.Show("Sound file not found.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing sound: {ex.Message}", "Sound Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelCreatedAt_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBoxDirections_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = checkedListBoxDirections.SelectedIndex;

            if (selectedIndex >= 0)
            {
                bool isChecked = checkedListBoxDirections.GetItemChecked(selectedIndex);
                Font currentFont = checkedListBoxDirections.Font;

                checkedListBoxDirections.Font = new Font(currentFont.FontFamily, currentFont.Size,
                    isChecked ? FontStyle.Strikeout : FontStyle.Regular);
            }
        }





        //    private void countdownTimer_Tick_1(object sender, EventArgs e)
        //    {
        //        if (trackBar1.Value > 0)
        //        {
        //            trackBar1.Value -= 1; 
        //            labelCookingTime.Text = $"Time Remaining: {trackBar1.Value} seconds";

        //            if (trackBar1.Value > 40)
        //            {
        //                this.BackColor = Color.LightGreen;
        //            }
        //            else if (trackBar1.Value > 20)
        //            {
        //                this.BackColor = Color.Gold;
        //            }
        //            else
        //            {
        //                this.BackColor = Color.IndianRed;
        //            }
        //        }
        //        else
        //        {
        //            countdownTimer.Stop(); 
        //            MessageBox.Show("Time's up!");
        //        }
        //    }
    }

}
