using System.Collections.Generic;

namespace GameBesenica
{
    public partial class Form1 : Form
    {

        public static List<Word> words = default!;
        public static List<Category> Categories = default!;
        public Form1()
        {
            InitializeComponent();
            // create some Categories
            Category animals = new Category("�������");
            Category colors = new Category("�������");
            Category nature = new Category("�������");

            Word cat = new Word("�����", animals);
            Word dog = new Word("����", animals);
            Word dolpfin = new Word("������", animals);
            Word blue = new Word("�����", colors);
            Word purple = new Word("������", colors);
            Word red = new Word("�������", colors);
            Word forest = new Word("����", nature);
            Word sky = new Word("����", nature);

            Categories = new List<Category> { animals, colors, nature };
            words = new List<Word> { cat, dog, dolpfin, blue, purple, red, forest, sky };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WordCorrectionForm wordCorrectForm = new WordCorrectionForm();
            wordCorrectForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainGameForm mainGameForm = new MainGameForm();
            mainGameForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}