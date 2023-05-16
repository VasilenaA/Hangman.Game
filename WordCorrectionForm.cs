using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GameBesenica
{
    public partial class WordCorrectionForm : Form
    {
        public WordCorrectionForm()
        {
            InitializeComponent();
            // bind the Categories list to the Categories combo box
            categoryComboBox.DataSource = Form1.Categories;
            categoryComboBox.DisplayMember = "Name";

            // bind the words list to the words combo box
            wordComboBox.DataSource = Form1.words;
            wordComboBox.DisplayMember = "Name";
        }

        private void WordCorrectionForm_Load(object sender, EventArgs e)
        {
            wishWordButton.Hide();
            wishCategoryButton.Hide();
            wordComboBox.Hide();
            categoryComboBox.Hide();
            wordTextBox.Hide();
            categoryTextBox.Hide();
            addCategoryButton.Hide();
            addWordButton.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            deleteWordButton.Hide();
            deleteCategoryButton.Hide();

        }

        private void wishAddingButton_Click(object sender, EventArgs e)
        {
            wishWordButton.Show();
            wishCategoryButton.Show();
            wordComboBox.Hide();
            categoryComboBox.Hide();
            wordTextBox.Hide();
            categoryTextBox.Hide();
            addCategoryButton.Hide();
            addWordButton.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            deleteWordButton.Hide();
            deleteCategoryButton.Hide();
        }

        private void wishWordButton_Click(object sender, EventArgs e)
        {
            categoryComboBox.Show();
            label2.Show();
            wordTextBox.Show();
            label5.Show();
            addWordButton.Show();
            wordComboBox.Show();

            addCategoryButton.Hide();
            categoryTextBox.Hide();
            label3.Show();
            label4.Hide();
        }
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedItem is Category selectedCategory)
            {
                // update the words combo box to show only the words for the selected category
                wordComboBox.DataSource = null;
                wordComboBox.DataSource = selectedCategory.Words;
                wordComboBox.DisplayMember = "Name";
            }
            else
            {
                wordComboBox.DataSource = null;
            }
        }
        private void addWordButton_Click(object sender, EventArgs e)
        {
            Category selectedCategory = (Category)categoryComboBox.SelectedItem;
            string newWordName = wordTextBox.Text.ToUpper();
            if (Form1.words.Any(w => w.Name == newWordName))
            {
                MessageBox.Show("Думата съществува.Въведете нова");
            }
            else
            {
                Word newWord = new Word(newWordName, selectedCategory);
                Form1.words.Add(newWord);
                wordComboBox.Show();
                label3.Show();
            }

            wordComboBox.DataSource = null;
            wordComboBox.DataSource = selectedCategory.Words;
            wordComboBox.DisplayMember = "Name";
            wordTextBox.Text = "";
        }

        private void wishCategoryButton_Click(object sender, EventArgs e)
        {
            categoryComboBox.Show();
            label2.Show();
            categoryTextBox.Show();
            label4.Show();
            wordTextBox.Show();
            label5.Show();
            addCategoryButton.Show();

            addWordButton.Hide();
            wordComboBox.Hide();
            label3.Hide();
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            string categoryName = categoryTextBox.Text;
            string wordForCategory = wordTextBox.Text.ToUpper();
            if (Form1.Categories.Any(c => c.Name == categoryName))
            {
                MessageBox.Show("Категорията вече съществува.Добавете друга");
                categoryTextBox.Text = "";
                wordTextBox.Text = "";
            }
            else if (categoryName == "")
            {
                MessageBox.Show("Не може да добавите празна категория!");
            }
            else if (wordForCategory == "")
            {
                MessageBox.Show("Трябва да въведете дума за новата категория!");
            }
            else
            {
                Category newCategory = new Category(categoryName);
                Form1.Categories.Add(newCategory);
                Word newWord = new Word(wordForCategory, newCategory);
                Form1.words.Add(newWord);
                categoryComboBox.DataSource = null;
                categoryComboBox.DataSource = Form1.Categories;
                categoryComboBox.DisplayMember = "Name";
                wordComboBox.Show();
                categoryComboBox.SelectedItem = newCategory;
                wordComboBox.DataSource = newCategory.Words;
                wordComboBox.DisplayMember = "Name";

                MessageBox.Show($"The new category '{categoryName}' and its associated word '{wordForCategory}' have been added.");
                categoryTextBox.Text = "";
                wordTextBox.Text = "";
            }
        }

        private void wishDeletingButton_Click(object sender, EventArgs e)
        {
            deleteWordButton.Show();
            deleteCategoryButton.Show();

            wishWordButton.Hide();
            wishCategoryButton.Hide();
            wordComboBox.Show();
            categoryComboBox.Show();
            wordTextBox.Hide();
            categoryTextBox.Hide();
            addCategoryButton.Hide();
            addWordButton.Hide();
            label2.Show();
            label3.Show();
            label4.Hide();
            label5.Hide();
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            Category selectedCategory = (Category)categoryComboBox.SelectedItem;
            // remove the category and all its associated words from the lists
            Form1.Categories.Remove(selectedCategory);
            Form1.words.RemoveAll(w => w.Category == selectedCategory);

            // update the combo boxes
            categoryComboBox.DataSource = null;
            categoryComboBox.DataSource = Form1.Categories;
            categoryComboBox.DisplayMember = "Name";

            // clear the words combo box
            wordComboBox.DataSource = null;

            // show a message to inform the user
            MessageBox.Show($"The category '{selectedCategory.Name}' and all its associated words have been deleted.");
        }

        private void deleteWordButton_Click(object sender, EventArgs e)
        {
            // get the selected word
            if (wordComboBox.SelectedItem is Word selectedWord)
            {
                // remove the selected word from its category's word list
                selectedWord.Category.Words.Remove(selectedWord);

                // remove the selected word from the words list
                Form1.words.Remove(selectedWord);

                // update the words combo box to show only the remaining words for the selected category
                if (categoryComboBox.SelectedItem is Category selectedCategory)
                {
                    wordComboBox.DataSource = null;
                    wordComboBox.DataSource = selectedCategory.Words;
                    wordComboBox.DisplayMember = "Name";
                }
                else
                {
                    wordComboBox.DataSource = null;
                }
            }
        }
        private void къмИгратаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainGameForm mainGameForm = new MainGameForm();
            mainGameForm.Show();
            this.Hide();
        }

        private void изходОтИгратаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
