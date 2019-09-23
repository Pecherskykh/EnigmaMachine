namespace EnigmaMachine
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.symbol = new System.Windows.Forms.TextBox();
            this.encodedSymbol = new System.Windows.Forms.TextBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.resetSettings = new System.Windows.Forms.Button();
            this.steckerverbindungen = new System.Windows.Forms.TextBox();
            this.ringstellung = new System.Windows.Forms.TextBox();
            this.leftRotorComboBox = new System.Windows.Forms.ComboBox();
            this.middleRotorComboBox = new System.Windows.Forms.ComboBox();
            this.rightRotorComboBox = new System.Windows.Forms.ComboBox();
            this.reflectorComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.removeRotors = new System.Windows.Forms.Button();
            this.addRotor = new System.Windows.Forms.Button();
            this.listRotors = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.removeReflectors = new System.Windows.Forms.Button();
            this.addReflector = new System.Windows.Forms.Button();
            this.listReflectors = new System.Windows.Forms.ListBox();
            this.fourthRotorOn = new System.Windows.Forms.CheckBox();
            this.rotor4ComboBox = new System.Windows.Forms.ComboBox();
            this.encodeDecode = new System.Windows.Forms.Button();
            this.clearBottomMargins = new System.Windows.Forms.Button();
            this.clearTopMargins = new System.Windows.Forms.Button();
            this.leftRotor = new System.Windows.Forms.DomainUpDown();
            this.rotor4 = new System.Windows.Forms.DomainUpDown();
            this.middleRotor = new System.Windows.Forms.DomainUpDown();
            this.rightRotor = new System.Windows.Forms.DomainUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // symbol
            // 
            this.symbol.Location = new System.Drawing.Point(13, 94);
            this.symbol.Name = "symbol";
            this.symbol.Size = new System.Drawing.Size(555, 20);
            this.symbol.TabIndex = 3;
            // 
            // encodedSymbol
            // 
            this.encodedSymbol.Location = new System.Drawing.Point(13, 120);
            this.encodedSymbol.Name = "encodedSymbol";
            this.encodedSymbol.Size = new System.Drawing.Size(555, 20);
            this.encodedSymbol.TabIndex = 4;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(13, 40);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(183, 23);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "Налаштувати";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // resetSettings
            // 
            this.resetSettings.Enabled = false;
            this.resetSettings.Location = new System.Drawing.Point(202, 40);
            this.resetSettings.Name = "resetSettings";
            this.resetSettings.Size = new System.Drawing.Size(180, 23);
            this.resetSettings.TabIndex = 6;
            this.resetSettings.Text = "Скинути налаштування";
            this.resetSettings.UseVisualStyleBackColor = true;
            this.resetSettings.Click += new System.EventHandler(this.ResetSettings_Click);
            // 
            // steckerverbindungen
            // 
            this.steckerverbindungen.Location = new System.Drawing.Point(389, 10);
            this.steckerverbindungen.Name = "steckerverbindungen";
            this.steckerverbindungen.Size = new System.Drawing.Size(179, 20);
            this.steckerverbindungen.TabIndex = 4;
            this.steckerverbindungen.Text = "NE MT RL OY HV IU GK FW PZ XC";
            // 
            // ringstellung
            // 
            this.ringstellung.Location = new System.Drawing.Point(318, 10);
            this.ringstellung.Name = "ringstellung";
            this.ringstellung.Size = new System.Drawing.Size(65, 20);
            this.ringstellung.TabIndex = 5;
            this.ringstellung.Text = "9 16 12";
            // 
            // leftRotorComboBox
            // 
            this.leftRotorComboBox.FormattingEnabled = true;
            this.leftRotorComboBox.Items.AddRange(new object[] {
            "I",
            "II",
            "III"});
            this.leftRotorComboBox.Location = new System.Drawing.Point(134, 10);
            this.leftRotorComboBox.Name = "leftRotorComboBox";
            this.leftRotorComboBox.Size = new System.Drawing.Size(40, 21);
            this.leftRotorComboBox.TabIndex = 6;
            this.leftRotorComboBox.Text = "I";
            // 
            // middleRotorComboBox
            // 
            this.middleRotorComboBox.FormattingEnabled = true;
            this.middleRotorComboBox.Items.AddRange(new object[] {
            "I",
            "II",
            "III"});
            this.middleRotorComboBox.Location = new System.Drawing.Point(180, 10);
            this.middleRotorComboBox.Name = "middleRotorComboBox";
            this.middleRotorComboBox.Size = new System.Drawing.Size(40, 21);
            this.middleRotorComboBox.TabIndex = 7;
            this.middleRotorComboBox.Text = "III";
            // 
            // rightRotorComboBox
            // 
            this.rightRotorComboBox.FormattingEnabled = true;
            this.rightRotorComboBox.Items.AddRange(new object[] {
            "I",
            "II",
            "III"});
            this.rightRotorComboBox.Location = new System.Drawing.Point(226, 10);
            this.rightRotorComboBox.Name = "rightRotorComboBox";
            this.rightRotorComboBox.Size = new System.Drawing.Size(40, 21);
            this.rightRotorComboBox.TabIndex = 8;
            this.rightRotorComboBox.Text = "II";
            // 
            // reflectorComboBox
            // 
            this.reflectorComboBox.FormattingEnabled = true;
            this.reflectorComboBox.Items.AddRange(new object[] {
            "B"});
            this.reflectorComboBox.Location = new System.Drawing.Point(272, 10);
            this.reflectorComboBox.Name = "reflectorComboBox";
            this.reflectorComboBox.Size = new System.Drawing.Size(40, 21);
            this.reflectorComboBox.TabIndex = 9;
            this.reflectorComboBox.Text = "B";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(574, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 157);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.removeRotors);
            this.tabPage1.Controls.Add(this.addRotor);
            this.tabPage1.Controls.Add(this.listRotors);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(192, 131);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ротори";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // removeRotors
            // 
            this.removeRotors.Location = new System.Drawing.Point(125, 105);
            this.removeRotors.Name = "removeRotors";
            this.removeRotors.Size = new System.Drawing.Size(64, 23);
            this.removeRotors.TabIndex = 4;
            this.removeRotors.Text = "Видалити";
            this.removeRotors.UseVisualStyleBackColor = true;
            this.removeRotors.Click += new System.EventHandler(this.RemoveRotors_Click);
            // 
            // addRotor
            // 
            this.addRotor.Location = new System.Drawing.Point(3, 105);
            this.addRotor.Name = "addRotor";
            this.addRotor.Size = new System.Drawing.Size(94, 23);
            this.addRotor.TabIndex = 3;
            this.addRotor.Text = "Додати ротор";
            this.addRotor.UseVisualStyleBackColor = true;
            this.addRotor.Click += new System.EventHandler(this.AddRotor_Click);
            // 
            // listRotors
            // 
            this.listRotors.FormattingEnabled = true;
            this.listRotors.Items.AddRange(new object[] {
            "I",
            "II",
            "III"});
            this.listRotors.Location = new System.Drawing.Point(3, 6);
            this.listRotors.Name = "listRotors";
            this.listRotors.Size = new System.Drawing.Size(186, 95);
            this.listRotors.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.removeReflectors);
            this.tabPage2.Controls.Add(this.addReflector);
            this.tabPage2.Controls.Add(this.listReflectors);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(192, 131);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Рефлектори";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // removeReflectors
            // 
            this.removeReflectors.Location = new System.Drawing.Point(125, 105);
            this.removeReflectors.Name = "removeReflectors";
            this.removeReflectors.Size = new System.Drawing.Size(64, 23);
            this.removeReflectors.TabIndex = 5;
            this.removeReflectors.Text = "Видалити";
            this.removeReflectors.UseVisualStyleBackColor = true;
            this.removeReflectors.Click += new System.EventHandler(this.RemoveReflectors_Click);
            // 
            // addReflector
            // 
            this.addReflector.Location = new System.Drawing.Point(3, 105);
            this.addReflector.Name = "addReflector";
            this.addReflector.Size = new System.Drawing.Size(115, 23);
            this.addReflector.TabIndex = 3;
            this.addReflector.Text = "Додати рефлектор";
            this.addReflector.UseVisualStyleBackColor = true;
            this.addReflector.Click += new System.EventHandler(this.AddReflector_Click);
            // 
            // listReflectors
            // 
            this.listReflectors.FormattingEnabled = true;
            this.listReflectors.Items.AddRange(new object[] {
            "B"});
            this.listReflectors.Location = new System.Drawing.Point(3, 6);
            this.listReflectors.Name = "listReflectors";
            this.listReflectors.Size = new System.Drawing.Size(186, 95);
            this.listReflectors.TabIndex = 2;
            // 
            // fourthRotorOn
            // 
            this.fourthRotorOn.AutoSize = true;
            this.fourthRotorOn.Location = new System.Drawing.Point(12, 12);
            this.fourthRotorOn.Name = "fourthRotorOn";
            this.fourthRotorOn.Size = new System.Drawing.Size(70, 17);
            this.fourthRotorOn.TabIndex = 10;
            this.fourthRotorOn.Text = "4 ротори";
            this.fourthRotorOn.UseVisualStyleBackColor = true;
            this.fourthRotorOn.CheckedChanged += new System.EventHandler(this.FourthRotorOn_CheckedChanged);
            // 
            // rotor4ComboBox
            // 
            this.rotor4ComboBox.Enabled = false;
            this.rotor4ComboBox.FormattingEnabled = true;
            this.rotor4ComboBox.Items.AddRange(new object[] {
            "I",
            "II",
            "III"});
            this.rotor4ComboBox.Location = new System.Drawing.Point(88, 10);
            this.rotor4ComboBox.Name = "rotor4ComboBox";
            this.rotor4ComboBox.Size = new System.Drawing.Size(40, 21);
            this.rotor4ComboBox.TabIndex = 11;
            // 
            // encodeDecode
            // 
            this.encodeDecode.Enabled = false;
            this.encodeDecode.Location = new System.Drawing.Point(13, 146);
            this.encodeDecode.Name = "encodeDecode";
            this.encodeDecode.Size = new System.Drawing.Size(273, 23);
            this.encodeDecode.TabIndex = 13;
            this.encodeDecode.Text = "Кодувати/Декодувати";
            this.encodeDecode.UseVisualStyleBackColor = true;
            this.encodeDecode.Click += new System.EventHandler(this.EncodeDecode_Click);
            // 
            // clearBottomMargins
            // 
            this.clearBottomMargins.Location = new System.Drawing.Point(292, 146);
            this.clearBottomMargins.Name = "clearBottomMargins";
            this.clearBottomMargins.Size = new System.Drawing.Size(276, 23);
            this.clearBottomMargins.TabIndex = 14;
            this.clearBottomMargins.Text = "Очистити нижні поля";
            this.clearBottomMargins.UseVisualStyleBackColor = true;
            this.clearBottomMargins.Click += new System.EventHandler(this.ClearBottomMargins_Click);
            // 
            // clearTopMargins
            // 
            this.clearTopMargins.Location = new System.Drawing.Point(388, 40);
            this.clearTopMargins.Name = "clearTopMargins";
            this.clearTopMargins.Size = new System.Drawing.Size(180, 23);
            this.clearTopMargins.TabIndex = 15;
            this.clearTopMargins.Text = "Очистити верхні поля";
            this.clearTopMargins.UseVisualStyleBackColor = true;
            this.clearTopMargins.Click += new System.EventHandler(this.ClearTopMargins_Click);
            // 
            // leftRotor
            // 
            this.leftRotor.Items.Add("A");
            this.leftRotor.Items.Add("B");
            this.leftRotor.Items.Add("C");
            this.leftRotor.Items.Add("D");
            this.leftRotor.Items.Add("E");
            this.leftRotor.Items.Add("F");
            this.leftRotor.Items.Add("G");
            this.leftRotor.Items.Add("H");
            this.leftRotor.Items.Add("I");
            this.leftRotor.Items.Add("J");
            this.leftRotor.Items.Add("K");
            this.leftRotor.Items.Add("L");
            this.leftRotor.Items.Add("M");
            this.leftRotor.Items.Add("N");
            this.leftRotor.Items.Add("O");
            this.leftRotor.Items.Add("P");
            this.leftRotor.Items.Add("Q");
            this.leftRotor.Items.Add("R");
            this.leftRotor.Items.Add("S");
            this.leftRotor.Items.Add("T");
            this.leftRotor.Items.Add("U");
            this.leftRotor.Items.Add("V");
            this.leftRotor.Items.Add("W");
            this.leftRotor.Items.Add("X");
            this.leftRotor.Items.Add("Y");
            this.leftRotor.Items.Add("Z");
            this.leftRotor.Location = new System.Drawing.Point(185, 69);
            this.leftRotor.Name = "leftRotor";
            this.leftRotor.Size = new System.Drawing.Size(100, 20);
            this.leftRotor.TabIndex = 16;
            this.leftRotor.Text = "A";
            // 
            // rotor4
            // 
            this.rotor4.Enabled = false;
            this.rotor4.Items.Add("A");
            this.rotor4.Items.Add("B");
            this.rotor4.Items.Add("C");
            this.rotor4.Items.Add("D");
            this.rotor4.Items.Add("E");
            this.rotor4.Items.Add("F");
            this.rotor4.Items.Add("G");
            this.rotor4.Items.Add("H");
            this.rotor4.Items.Add("I");
            this.rotor4.Items.Add("J");
            this.rotor4.Items.Add("K");
            this.rotor4.Items.Add("L");
            this.rotor4.Items.Add("M");
            this.rotor4.Items.Add("N");
            this.rotor4.Items.Add("O");
            this.rotor4.Items.Add("P");
            this.rotor4.Items.Add("Q");
            this.rotor4.Items.Add("R");
            this.rotor4.Items.Add("S");
            this.rotor4.Items.Add("T");
            this.rotor4.Items.Add("U");
            this.rotor4.Items.Add("V");
            this.rotor4.Items.Add("W");
            this.rotor4.Items.Add("X");
            this.rotor4.Items.Add("Y");
            this.rotor4.Items.Add("Z");
            this.rotor4.Location = new System.Drawing.Point(79, 69);
            this.rotor4.Name = "rotor4";
            this.rotor4.Size = new System.Drawing.Size(100, 20);
            this.rotor4.TabIndex = 17;
            this.rotor4.Text = "A";
            // 
            // middleRotor
            // 
            this.middleRotor.Items.Add("A");
            this.middleRotor.Items.Add("B");
            this.middleRotor.Items.Add("C");
            this.middleRotor.Items.Add("D");
            this.middleRotor.Items.Add("E");
            this.middleRotor.Items.Add("F");
            this.middleRotor.Items.Add("G");
            this.middleRotor.Items.Add("H");
            this.middleRotor.Items.Add("I");
            this.middleRotor.Items.Add("J");
            this.middleRotor.Items.Add("K");
            this.middleRotor.Items.Add("L");
            this.middleRotor.Items.Add("M");
            this.middleRotor.Items.Add("N");
            this.middleRotor.Items.Add("O");
            this.middleRotor.Items.Add("P");
            this.middleRotor.Items.Add("Q");
            this.middleRotor.Items.Add("R");
            this.middleRotor.Items.Add("S");
            this.middleRotor.Items.Add("T");
            this.middleRotor.Items.Add("U");
            this.middleRotor.Items.Add("V");
            this.middleRotor.Items.Add("W");
            this.middleRotor.Items.Add("X");
            this.middleRotor.Items.Add("Y");
            this.middleRotor.Items.Add("Z");
            this.middleRotor.Location = new System.Drawing.Point(291, 69);
            this.middleRotor.Name = "middleRotor";
            this.middleRotor.Size = new System.Drawing.Size(100, 20);
            this.middleRotor.TabIndex = 18;
            this.middleRotor.Text = "A";
            // 
            // rightRotor
            // 
            this.rightRotor.Items.Add("A");
            this.rightRotor.Items.Add("B");
            this.rightRotor.Items.Add("C");
            this.rightRotor.Items.Add("D");
            this.rightRotor.Items.Add("E");
            this.rightRotor.Items.Add("F");
            this.rightRotor.Items.Add("G");
            this.rightRotor.Items.Add("H");
            this.rightRotor.Items.Add("I");
            this.rightRotor.Items.Add("J");
            this.rightRotor.Items.Add("K");
            this.rightRotor.Items.Add("L");
            this.rightRotor.Items.Add("M");
            this.rightRotor.Items.Add("N");
            this.rightRotor.Items.Add("O");
            this.rightRotor.Items.Add("P");
            this.rightRotor.Items.Add("Q");
            this.rightRotor.Items.Add("R");
            this.rightRotor.Items.Add("S");
            this.rightRotor.Items.Add("T");
            this.rightRotor.Items.Add("U");
            this.rightRotor.Items.Add("V");
            this.rightRotor.Items.Add("W");
            this.rightRotor.Items.Add("X");
            this.rightRotor.Items.Add("Y");
            this.rightRotor.Items.Add("Z");
            this.rightRotor.Location = new System.Drawing.Point(397, 69);
            this.rightRotor.Name = "rightRotor";
            this.rightRotor.Size = new System.Drawing.Size(100, 20);
            this.rightRotor.TabIndex = 19;
            this.rightRotor.Text = "A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 181);
            this.Controls.Add(this.rightRotor);
            this.Controls.Add(this.middleRotor);
            this.Controls.Add(this.rotor4);
            this.Controls.Add(this.leftRotor);
            this.Controls.Add(this.clearTopMargins);
            this.Controls.Add(this.clearBottomMargins);
            this.Controls.Add(this.encodeDecode);
            this.Controls.Add(this.rotor4ComboBox);
            this.Controls.Add(this.fourthRotorOn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.reflectorComboBox);
            this.Controls.Add(this.rightRotorComboBox);
            this.Controls.Add(this.resetSettings);
            this.Controls.Add(this.middleRotorComboBox);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.leftRotorComboBox);
            this.Controls.Add(this.ringstellung);
            this.Controls.Add(this.encodedSymbol);
            this.Controls.Add(this.steckerverbindungen);
            this.Controls.Add(this.symbol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(796, 220);
            this.MinimumSize = new System.Drawing.Size(796, 220);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enigma";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox symbol;
        private System.Windows.Forms.TextBox encodedSymbol;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button resetSettings;
        private System.Windows.Forms.TextBox ringstellung;
        private System.Windows.Forms.TextBox steckerverbindungen;
        private System.Windows.Forms.ComboBox reflectorComboBox;
        private System.Windows.Forms.ComboBox rightRotorComboBox;
        private System.Windows.Forms.ComboBox middleRotorComboBox;
        private System.Windows.Forms.ComboBox leftRotorComboBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button addRotor;
        private System.Windows.Forms.ListBox listRotors;
        private System.Windows.Forms.Button addReflector;
        private System.Windows.Forms.ListBox listReflectors;
        private System.Windows.Forms.CheckBox fourthRotorOn;
        private System.Windows.Forms.ComboBox rotor4ComboBox;
        private System.Windows.Forms.Button removeRotors;
        private System.Windows.Forms.Button removeReflectors;
        private System.Windows.Forms.Button encodeDecode;
        private System.Windows.Forms.Button clearBottomMargins;
        private System.Windows.Forms.Button clearTopMargins;
        private System.Windows.Forms.DomainUpDown leftRotor;
        private System.Windows.Forms.DomainUpDown rotor4;
        private System.Windows.Forms.DomainUpDown middleRotor;
        private System.Windows.Forms.DomainUpDown rightRotor;
    }
}