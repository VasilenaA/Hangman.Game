using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace GameBesenica
{
    public partial class MainGameForm : Form
    {

        private int guessesRemaining = 7;
        private int score = 0;
        string wordToFind = "";
        int wordLength;
        public MainGameForm()
        {
            InitializeComponent();
            categoriesComboBox.DataSource = Form1.Categories;
            categoriesComboBox.DisplayMember = "Name";
            disableAllButtons();

            buttonA.Click += new EventHandler(Button_Click);
            buttonB.Click += new EventHandler(Button_Click);
            buttonV.Click += new EventHandler(Button_Click);
            buttonG.Click += new EventHandler(Button_Click);
            buttonD.Click += new EventHandler(Button_Click);
            buttonE.Click += new EventHandler(Button_Click);
            buttonJ.Click += new EventHandler(Button_Click);
            buttonZ.Click += new EventHandler(Button_Click);
            buttonI.Click += new EventHandler(Button_Click);
            buttonY.Click += new EventHandler(Button_Click);
            buttonK.Click += new EventHandler(Button_Click);
            buttonL.Click += new EventHandler(Button_Click);
            buttonM.Click += new EventHandler(Button_Click);
            buttonN.Click += new EventHandler(Button_Click);
            buttonO.Click += new EventHandler(Button_Click);
            buttonP.Click += new EventHandler(Button_Click);
            buttonR.Click += new EventHandler(Button_Click);
            buttonS.Click += new EventHandler(Button_Click);
            buttonT.Click += new EventHandler(Button_Click);
            buttonU.Click += new EventHandler(Button_Click);
            buttonF.Click += new EventHandler(Button_Click);
            buttonH.Click += new EventHandler(Button_Click);
            buttonCC.Click += new EventHandler(Button_Click);
            buttonCH.Click += new EventHandler(Button_Click);
            buttonSH.Click += new EventHandler(Button_Click);
            buttonSHT.Click += new EventHandler(Button_Click);
            buttonRG.Click += new EventHandler(Button_Click);
            buttonRM.Click += new EventHandler(Button_Click);
            buttonYU.Click += new EventHandler(Button_Click);
            buttonQ.Click += new EventHandler(Button_Click);


        }
        private void MainGameForm_Load(object sender, EventArgs e)
        {

        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            enableAllButtonLetters();
            Category selectedCategory = (Category)categoriesComboBox.SelectedItem;
            List<string> newList = new List<string>();
            Form1.words.ForEach(word =>
            {
                if (word.Category.Name == selectedCategory.Name)
                {
                    newList.Add(word.Name);
                }
            });
            Random random = new Random();
            int wordIndex = random.Next(0, newList.Count);
            wordToFind = newList.ElementAt(wordIndex);
            wordLength = wordToFind.Length;
            labelGuessingWord.Text = new string('-', wordLength);
        }
        private void enableAllButtonLetters()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is System.Windows.Forms.Button button)
                {
                    button.Enabled = true;
                    button.BackColor = Color.White;
                }
            }
        }
        private void disableAllButtons()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is System.Windows.Forms.Button button)
                {
                    button.Enabled = false;
                    button.BackColor = Color.White;
                }
            }
        }
        public void ShowLetter(char letter)
        {
            char[] labelText = labelGuessingWord.Text.ToCharArray();
            for (int i = 0; i < wordLength; i++)
            {
                if (wordToFind[i] == letter)
                {
                    labelText[i] = letter;
                }
            }
            labelGuessingWord.Text = string.Join("", labelText);
            if (!labelGuessingWord.Text.Contains("-"))
            {
                MessageBox.Show("Поздравления, Вие познахте думата!");
                score++;
                labelScore.Text = score.ToString();
                disableAllButtons();
                guessesRemaining = 7;
                label2.Text = guessesRemaining.ToString();
                labelGuessingWord.ForeColor = Color.Green;
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            char letter = button.Text[0];
            if (wordToFind.Contains(letter))
            {
                ShowLetter(letter);
                button.BackColor = Color.Green;
            }
            else
            {
                guessesRemaining--;
                label2.Text = guessesRemaining.ToString();
                button.BackColor = Color.Red;
                switch (guessesRemaining)
                {
                    case 6:
                        pictureBox1.Image = Properties.Resources._01;
                        break;
                    case 5:
                        pictureBox1.Image = Properties.Resources._02;
                        break;
                    case 4:
                        pictureBox1.Image = Properties.Resources._03;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources._04;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources._05;
                        break;
                    case 1:
                        pictureBox1.Image = Properties.Resources._06;
                        break;
                    case 0:
                        pictureBox1.Image = Properties.Resources._07;
                        break;
                }             
                if (guessesRemaining == 0)
                {
                    MessageBox.Show("Вие загубихте. Трябва да започнете нова игра!");
                    score = 0;
                    labelScore.Text = score.ToString();
                    guessesRemaining = 7;
                    foreach (Control control in panel1.Controls)
                    {
                        if (control is System.Windows.Forms.Button)
                        {
                            control.Enabled = false;
                        }
                    }
                    labelGuessingWord.Text = wordToFind;
                    labelGuessingWord.ForeColor = Color.Red;
                }
            }
            button.Enabled = false;
        }
        private void редактирайДумиИКатегорииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WordCorrectionForm wordCorrectForm = new WordCorrectionForm();
            wordCorrectForm.Show();
            this.Hide();
        }

        private void изходОтИгратаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



    }
}
