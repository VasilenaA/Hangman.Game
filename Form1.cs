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
            Category animals = new Category("∆Ë‚ÓÚÌË");
            Category colors = new Category("÷‚ÂÚÓ‚Â");
            Category nature = new Category("œËÓ‰‡");

            Word cat = new Word(" Œ“ ¿", animals);
            Word dog = new Word(" ”◊≈", animals);
            Word dolpfin = new Word("ƒ≈À‘»Õ", animals);
            Word blue = new Word("—»Õ‹Œ", colors);
            Word purple = new Word("À»À¿¬Œ", colors);
            Word red = new Word("◊≈–¬≈ÕŒ", colors);
            Word forest = new Word("√Œ–¿", nature);
            Word sky = new Word("Õ≈¡≈", nature);

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