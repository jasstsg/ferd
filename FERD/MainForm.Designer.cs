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
            button_deleteCharacter = new Button();
            button_OpenPromotionTree = new Button();
            button_generateCharacter = new Button();
            groupBox1 = new GroupBox();
            button_openSaveFolder = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button_create
            // 
            button_create.Location = new Point(314, 76);
            button_create.Name = "button_create";
            button_create.Size = new Size(158, 40);
            button_create.TabIndex = 0;
            button_create.Text = "Create new character";
            button_create.UseVisualStyleBackColor = true;
            button_create.Click += button_create_Click;
            // 
            // button_setCharacterFolder
            // 
            button_setCharacterFolder.Location = new Point(341, 21);
            button_setCharacterFolder.Name = "button_setCharacterFolder";
            button_setCharacterFolder.Size = new Size(55, 23);
            button_setCharacterFolder.TabIndex = 1;
            button_setCharacterFolder.Text = "Browse";
            button_setCharacterFolder.UseVisualStyleBackColor = true;
            button_setCharacterFolder.Click += button_setCharacterFolder_Click;
            // 
            // textBox_characterFolder
            // 
            textBox_characterFolder.Location = new Point(6, 22);
            textBox_characterFolder.Name = "textBox_characterFolder";
            textBox_characterFolder.Size = new Size(329, 23);
            textBox_characterFolder.TabIndex = 2;
            // 
            // listBox_characters
            // 
            listBox_characters.FormattingEnabled = true;
            listBox_characters.ItemHeight = 15;
            listBox_characters.Location = new Point(13, 76);
            listBox_characters.Name = "listBox_characters";
            listBox_characters.Size = new Size(295, 469);
            listBox_characters.TabIndex = 3;
            // 
            // button_openCharacter
            // 
            button_openCharacter.Location = new Point(314, 122);
            button_openCharacter.Name = "button_openCharacter";
            button_openCharacter.Size = new Size(158, 40);
            button_openCharacter.TabIndex = 4;
            button_openCharacter.Text = "Open Selected Character";
            button_openCharacter.UseVisualStyleBackColor = true;
            button_openCharacter.Click += button_openCharacter_Click;
            // 
            // button_deleteCharacter
            // 
            button_deleteCharacter.Location = new Point(314, 168);
            button_deleteCharacter.Name = "button_deleteCharacter";
            button_deleteCharacter.Size = new Size(158, 40);
            button_deleteCharacter.TabIndex = 5;
            button_deleteCharacter.Text = "Delete Selected Character";
            button_deleteCharacter.UseVisualStyleBackColor = true;
            button_deleteCharacter.Click += button_deleteCharacter_Click;
            // 
            // button_OpenPromotionTree
            // 
            button_OpenPromotionTree.Location = new Point(314, 352);
            button_OpenPromotionTree.Name = "button_OpenPromotionTree";
            button_OpenPromotionTree.Size = new Size(158, 40);
            button_OpenPromotionTree.TabIndex = 6;
            button_OpenPromotionTree.Text = "Open Promotion Tree";
            button_OpenPromotionTree.UseVisualStyleBackColor = true;
            button_OpenPromotionTree.Click += button_OpenPromotionTree_Click;
            // 
            // button_generateCharacter
            // 
            button_generateCharacter.Location = new Point(314, 260);
            button_generateCharacter.Name = "button_generateCharacter";
            button_generateCharacter.Size = new Size(158, 40);
            button_generateCharacter.TabIndex = 7;
            button_generateCharacter.Text = "Auto generate new character";
            button_generateCharacter.UseVisualStyleBackColor = true;
            button_generateCharacter.Click += button_generateCharacter_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_openSaveFolder);
            groupBox1.Controls.Add(textBox_characterFolder);
            groupBox1.Controls.Add(button_setCharacterFolder);
            groupBox1.Location = new Point(13, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(459, 53);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Character save folder";
            // 
            // button_openSaveFolder
            // 
            button_openSaveFolder.Location = new Point(398, 21);
            button_openSaveFolder.Name = "button_openSaveFolder";
            button_openSaveFolder.Size = new Size(55, 23);
            button_openSaveFolder.TabIndex = 3;
            button_openSaveFolder.Text = "Open";
            button_openSaveFolder.UseVisualStyleBackColor = true;
            button_openSaveFolder.Click += button_openSaveFolder_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(groupBox1);
            Controls.Add(button_generateCharacter);
            Controls.Add(button_OpenPromotionTree);
            Controls.Add(button_deleteCharacter);
            Controls.Add(button_openCharacter);
            Controls.Add(listBox_characters);
            Controls.Add(button_create);
            Name = "MainForm";
            Text = "Fire Emblem: Rolling Dice";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button_create;
        private Button button_setCharacterFolder;
        private TextBox textBox_characterFolder;
        private ListBox listBox_characters;
        private Button button_openCharacter;
        private Button button_deleteCharacter;
        private Button button_OpenPromotionTree;
        private Button button_generateCharacter;
        private GroupBox groupBox1;
        private Button button_openSaveFolder;
    }
}