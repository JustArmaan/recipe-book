using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Quiz2
{
    public partial class Form5 : Form
    {
        private string connectionString = "server=localhost;uid=quiz2user;pwd=password;database=recipe_book";

        public Form5()
        {
            InitializeComponent();
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            buttonAddMeal.Click += buttonAddMeal_Click;
            LoadMealsForDate(DateTime.Today);

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart; 
            LoadMealsForDate(selectedDate); 
        }
        private void LoadMealsForDate(DateTime date)
        {
            listBoxMeals.Items.Clear(); 
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT meal_description FROM Meals WHERE meal_date = @meal_date";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@meal_date", date);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listBoxMeals.Items.Add(reader["meal_description"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading meals: " + ex.Message);
            }

            if (listBoxMeals.Items.Count == 0)
            {
                listBoxMeals.Items.Add("No meals planned for this date.");
            }
        }
        private void buttonAddMeal_Click(object sender, EventArgs e)
        {
            string mealDescription = textBoxMeal.Text.Trim();
            DateTime selectedDate = monthCalendar1.SelectionStart;

            if (string.IsNullOrEmpty(mealDescription))
            {
                MessageBox.Show("Please enter a meal description.");
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Meals (meal_date, meal_description) VALUES (@meal_date, @meal_description)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@meal_date", selectedDate);
                        command.Parameters.AddWithValue("@meal_description", mealDescription);
                        command.ExecuteNonQuery();
                    }
                }

                LoadMealsForDate(selectedDate);

                textBoxMeal.Clear();

                MessageBox.Show("Meal added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding meal: " + ex.Message);
            }
        }
    }
}

