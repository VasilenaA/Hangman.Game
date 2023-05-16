namespace GameBesenica
{
    partial class WordCorrectionForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            wishAddingButton = new Button();
            wishDeletingButton = new Button();
            wishWordButton = new Button();
            wishCategoryButton = new Button();
            addWordButton = new Button();
            addCategoryButton = new Button();
            deleteWordButton = new Button();
            deleteCategoryButton = new Button();
            categoryComboBox = new ComboBox();
            wordComboBox = new ComboBox();
            categoryTextBox = new TextBox();
            wordTextBox = new TextBox();
            menuStrip1 = new MenuStrip();
            къмИгратаToolStripMenuItem = new ToolStripMenuItem();
            изходОтИгратаToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Eras Medium ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(173, 40);
            label1.Name = "label1";
            label1.Size = new Size(450, 39);
            label1.TabIndex = 0;
            label1.Text = "Какво желаете да направите?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(341, 148);
            label2.Name = "label2";
            label2.Size = new Size(127, 31);
            label2.TabIndex = 1;
            label2.Text = "Категории:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(368, 209);
            label3.Name = "label3";
            label3.Size = new Size(75, 31);
            label3.TabIndex = 2;
            label3.Text = "Думи:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(89, 294);
            label4.Name = "label4";
            label4.Size = new Size(230, 31);
            label4.TabIndex = 3;
            label4.Text = "Напишете категория";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(142, 332);
            label5.Name = "label5";
            label5.Size = new Size(177, 31);
            label5.TabIndex = 4;
            label5.Text = "Напишете дума";
            // 
            // wishAddingButton
            // 
            wishAddingButton.BackColor = Color.LightCyan;
            wishAddingButton.Font = new Font("Eras Medium ITC", 15F, FontStyle.Regular, GraphicsUnit.Point);
            wishAddingButton.ForeColor = Color.MidnightBlue;
            wishAddingButton.Location = new Point(31, 82);
            wishAddingButton.Name = "wishAddingButton";
            wishAddingButton.Size = new Size(267, 80);
            wishAddingButton.TabIndex = 5;
            wishAddingButton.Text = "Добавяне на думи или категории";
            wishAddingButton.UseVisualStyleBackColor = false;
            wishAddingButton.Click += wishAddingButton_Click;
            // 
            // wishDeletingButton
            // 
            wishDeletingButton.BackColor = Color.LightCyan;
            wishDeletingButton.Font = new Font("Eras Medium ITC", 15F, FontStyle.Regular, GraphicsUnit.Point);
            wishDeletingButton.Location = new Point(507, 82);
            wishDeletingButton.Name = "wishDeletingButton";
            wishDeletingButton.Size = new Size(261, 80);
            wishDeletingButton.TabIndex = 6;
            wishDeletingButton.Text = "Изтриване на думи или категории";
            wishDeletingButton.UseVisualStyleBackColor = false;
            wishDeletingButton.Click += wishDeletingButton_Click;
            // 
            // wishWordButton
            // 
            wishWordButton.BackColor = Color.LightCyan;
            wishWordButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            wishWordButton.Location = new Point(12, 182);
            wishWordButton.Name = "wishWordButton";
            wishWordButton.Size = new Size(132, 71);
            wishWordButton.TabIndex = 7;
            wishWordButton.Text = "Да добавя дума";
            wishWordButton.UseVisualStyleBackColor = false;
            wishWordButton.Click += wishWordButton_Click;
            // 
            // wishCategoryButton
            // 
            wishCategoryButton.BackColor = Color.LightCyan;
            wishCategoryButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            wishCategoryButton.Location = new Point(173, 179);
            wishCategoryButton.Name = "wishCategoryButton";
            wishCategoryButton.Size = new Size(132, 74);
            wishCategoryButton.TabIndex = 8;
            wishCategoryButton.Text = "Да добавя категория";
            wishCategoryButton.UseVisualStyleBackColor = false;
            wishCategoryButton.Click += wishCategoryButton_Click;
            // 
            // addWordButton
            // 
            addWordButton.BackColor = Color.LightCyan;
            addWordButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            addWordButton.Location = new Point(358, 381);
            addWordButton.Name = "addWordButton";
            addWordButton.Size = new Size(126, 62);
            addWordButton.TabIndex = 9;
            addWordButton.Text = "Добави думата";
            addWordButton.UseVisualStyleBackColor = false;
            addWordButton.Click += addWordButton_Click;
            // 
            // addCategoryButton
            // 
            addCategoryButton.BackColor = Color.LightCyan;
            addCategoryButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            addCategoryButton.Location = new Point(316, 397);
            addCategoryButton.Name = "addCategoryButton";
            addCategoryButton.Size = new Size(199, 62);
            addCategoryButton.TabIndex = 10;
            addCategoryButton.Text = "Добави категорията с думата към нея";
            addCategoryButton.UseVisualStyleBackColor = false;
            addCategoryButton.Click += addCategoryButton_Click;
            // 
            // deleteWordButton
            // 
            deleteWordButton.BackColor = Color.LightCyan;
            deleteWordButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            deleteWordButton.Location = new Point(556, 250);
            deleteWordButton.Name = "deleteWordButton";
            deleteWordButton.Size = new Size(126, 71);
            deleteWordButton.TabIndex = 11;
            deleteWordButton.Text = "Изтрий думата";
            deleteWordButton.UseVisualStyleBackColor = false;
            deleteWordButton.Click += deleteWordButton_Click;
            // 
            // deleteCategoryButton
            // 
            deleteCategoryButton.BackColor = Color.LightCyan;
            deleteCategoryButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            deleteCategoryButton.Location = new Point(556, 168);
            deleteCategoryButton.Name = "deleteCategoryButton";
            deleteCategoryButton.Size = new Size(126, 68);
            deleteCategoryButton.TabIndex = 12;
            deleteCategoryButton.Text = "Изтрий категорията";
            deleteCategoryButton.UseVisualStyleBackColor = false;
            deleteCategoryButton.Click += deleteCategoryButton_Click;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(341, 182);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(151, 28);
            categoryComboBox.TabIndex = 13;
            categoryComboBox.SelectedIndexChanged += categoryComboBox_SelectedIndexChanged;
            // 
            // wordComboBox
            // 
            wordComboBox.FormattingEnabled = true;
            wordComboBox.Location = new Point(341, 243);
            wordComboBox.Name = "wordComboBox";
            wordComboBox.Size = new Size(151, 28);
            wordComboBox.TabIndex = 14;
            // 
            // categoryTextBox
            // 
            categoryTextBox.Location = new Point(341, 294);
            categoryTextBox.Name = "categoryTextBox";
            categoryTextBox.Size = new Size(151, 27);
            categoryTextBox.TabIndex = 15;
            // 
            // wordTextBox
            // 
            wordTextBox.Location = new Point(341, 338);
            wordTextBox.Name = "wordTextBox";
            wordTextBox.Size = new Size(151, 27);
            wordTextBox.TabIndex = 16;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { къмИгратаToolStripMenuItem, изходОтИгратаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(785, 36);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // къмИгратаToolStripMenuItem
            // 
            къмИгратаToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            къмИгратаToolStripMenuItem.Name = "къмИгратаToolStripMenuItem";
            къмИгратаToolStripMenuItem.Size = new Size(129, 32);
            къмИгратаToolStripMenuItem.Text = "Към играта";
            къмИгратаToolStripMenuItem.Click += къмИгратаToolStripMenuItem_Click;
            // 
            // изходОтИгратаToolStripMenuItem
            // 
            изходОтИгратаToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            изходОтИгратаToolStripMenuItem.Name = "изходОтИгратаToolStripMenuItem";
            изходОтИгратаToolStripMenuItem.Padding = new Padding(50, 0, 5, 0);
            изходОтИгратаToolStripMenuItem.Size = new Size(217, 32);
            изходОтИгратаToolStripMenuItem.Text = "Изход от играта";
            изходОтИгратаToolStripMenuItem.Click += изходОтИгратаToolStripMenuItem_Click;
            // 
            // WordCorrectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(785, 471);
            Controls.Add(wordTextBox);
            Controls.Add(categoryTextBox);
            Controls.Add(wordComboBox);
            Controls.Add(categoryComboBox);
            Controls.Add(deleteCategoryButton);
            Controls.Add(deleteWordButton);
            Controls.Add(addCategoryButton);
            Controls.Add(addWordButton);
            Controls.Add(wishCategoryButton);
            Controls.Add(wishWordButton);
            Controls.Add(wishDeletingButton);
            Controls.Add(wishAddingButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            ForeColor = Color.Navy;
            MainMenuStrip = menuStrip1;
            Name = "WordCorrectionForm";
            Text = "WordCorrectionForm";
            Load += WordCorrectionForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button wishAddingButton;
        private Button wishDeletingButton;
        private Button wishWordButton;
        private Button wishCategoryButton;
        private Button addWordButton;
        private Button addCategoryButton;
        private Button deleteWordButton;
        private Button deleteCategoryButton;
        private ComboBox categoryComboBox;
        private ComboBox wordComboBox;
        private TextBox categoryTextBox;
        private TextBox wordTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem къмИгратаToolStripMenuItem;
        private ToolStripMenuItem изходОтИгратаToolStripMenuItem;
    }
}