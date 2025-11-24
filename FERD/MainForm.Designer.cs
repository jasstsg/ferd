namespace FERD
{
    partial class MainForm
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
            button_create = new Button();
            button_setCharacterFolder = new Button();
            textBox_characterFolder = new TextBox();
            listBox_characters = new ListBox();
            button_openCharacter = new Button();
            button1 = new Button();
            button_OpenPromotionTree = new Button();
            SuspendLayout();
            // 
            // button_create
            // 
            button_create.Location = new Point(12, 78);
            button_create.Name = "button_create";
            button_create.Size = new Size(158, 23);
            button_create.TabIndex = 0;
            button_create.Text = "Create new character";
            button_create.UseVisualStyleBackColor = true;
            button_create.Click += button_create_Click;
            // 
            // button_setCharacterFolder
            // 
            button_setCharacterFolder.Location = new Point(12, 7);
            button_setCharacterFolder.Name = "button_setCharacterFolder";
            button_setCharacterFolder.Size = new Size(168, 23);
            button_setCharacterFolder.TabIndex = 1;
            button_setCharacterFolder.Text = "Set Character folder";
            button_setCharacterFolder.UseVisualStyleBackColor = true;
            button_setCharacterFolder.Click += button_setCharacterFolder_Click;
            // 
            // textBox_characterFolder
            // 
            textBox_characterFolder.Location = new Point(12, 36);
            textBox_characterFolder.Name = "textBox_characterFolder";
            textBox_characterFolder.Size = new Size(460, 23);
            textBox_characterFolder.TabIndex = 2;
            // 
            // listBox_characters
            // 
            listBox_characters.FormattingEnabled = true;
            listBox_characters.ItemHeight = 15;
            listBox_characters.Location = new Point(12, 136);
            listBox_characters.Name = "listBox_characters";
            listBox_characters.Size = new Size(321, 379);
            listBox_characters.TabIndex = 3;
            // 
            // button_openCharacter
            // 
            button_openCharacter.Location = new Point(12, 107);
            button_openCharacter.Name = "button_openCharacter";
            button_openCharacter.Size = new Size(158, 23);
            button_openCharacter.TabIndex = 4;
            button_openCharacter.Text = "Open Selected Character";
            button_openCharacter.UseVisualStyleBackColor = true;
            button_openCharacter.Click += button_openCharacter_Click;
            // 
            // button1
            // 
            button1.Location = new Point(176, 107);
            button1.Name = "button1";
            button1.Size = new Size(157, 23);
            button1.TabIndex = 5;
            button1.Text = "Delete Selected Character";
            button1.UseVisualStyleBackColor = true;
            // 
            // button_OpenPromotionTree
            // 
            button_OpenPromotionTree.Location = new Point(339, 136);
            button_OpenPromotionTree.Name = "button_OpenPromotionTree";
            button_OpenPromotionTree.Size = new Size(133, 36);
            button_OpenPromotionTree.TabIndex = 6;
            button_OpenPromotionTree.Text = "Open Promotion Tree";
            button_OpenPromotionTree.UseVisualStyleBackColor = true;
            button_OpenPromotionTree.Click += button_OpenPromotionTree_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(button_OpenPromotionTree);
            Controls.Add(button1);
            Controls.Add(button_openCharacter);
            Controls.Add(listBox_characters);
            Controls.Add(textBox_characterFolder);
            Controls.Add(button_setCharacterFolder);
            Controls.Add(button_create);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_create;
        private Button button_setCharacterFolder;
        private TextBox textBox_characterFolder;
        private ListBox listBox_characters;
        private Button button_openCharacter;
        private Button button1;
        private Button button_OpenPromotionTree;
    }
}