using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EnigmaMachine
{
    public partial class Form1 : Form
    {
        Dictionary<string, Rotor> rotors = new Dictionary<string, Rotor>();
        Dictionary<string, string> reflectors = new Dictionary<string, string>();
        object[] settings;

        public Form1()
        {
            InitializeComponent();
            DefaultSettings();
            Settings();

            Enigma.ShowRotorsPosition += (a, b, c) =>
            {
                leftRotor.Text = a;
                middleRotor.Text = b;
                rightRotor.Text = c;
            };
        }

        private void DefaultSettings()
        {
            rotors.Add("I", new Rotor { Wiring = "EKMFLGDQVZNTOWYHXUSPAIBRCJ", Notch = 16 });
            rotors.Add("II", new Rotor { Wiring = "AJDKSIRUXBLHWTMCQGZNPYFVOE", Notch = 4 });
            rotors.Add("III", new Rotor { Wiring = "BDFHJLCPRTXVZNYEIWGAKMUSQO", Notch = 21, });
            reflectors.Add("B", "YRUHQSLDPXNGOKMIEBFZCWVJAT");
        }

        private string SteckerSettings()
        {
            string steckerSettings = steckerverbindungen.Text.Replace(" ", "").ToUpper();

            if (steckerSettings == "")
                return steckerSettings;

            if (!ValidationOfEnigma.BelongAlphabet(steckerSettings))
            {
                MessageBox.Show("Cbvdjks");
                return null;
            }

            if (steckerSettings.Length > 20)
            {
                MessageBox.Show("10");
                return null;
            }

            if (steckerSettings.Length % 2 != 0)
            {
                MessageBox.Show("Парне");
                return null;
            }

            if (ValidationOfEnigma.SymbolsRepeated(steckerSettings))
            {
                MessageBox.Show("Повторення");
                return null;
            }

            return steckerSettings;
        }

        private int[] RinngSettings()
        {
            int[] ringSettings;
            if (ringstellung.Text.Replace(" ", "") == "")
            {
                if (fourthRotorOn.Checked)
                {
                    ringstellung.Text = "1 1 1 1";
                    return new int[] { 1, 1, 1, 1 };
                }
                else
                {
                    ringstellung.Text = "1 1 1";
                    return new int[] { 1, 1, 1 };
                }
            }
            string errorMessage = "У вікні положення кілець, мають бути числа від 1 до 26 включно!";
            try
            {
                ringSettings = ringstellung.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
            }
            catch
            {
                MessageBox.Show(errorMessage);
                return null;
            }
            if (fourthRotorOn.Checked)
            {
                if (ringSettings.Length < 4)
                {
                    MessageBox.Show("Положення кілець встановлено не для всіх роторів!\r\nНа разі використовується чотири ротори");
                    return null;
                }
            }
            else
            {
                if (ringSettings.Length < 3)
                {
                    MessageBox.Show("Положення кілець встановлено не для всіх роторів!\r\nНа разі використовується три ротори");
                    return null;
                }
            }
            if (!ValidationOfEnigma.AllNumbersIntoInterval(ringSettings))
            {
                MessageBox.Show(errorMessage);
                return null;
            }
            return ringSettings;
        }

        private object[] EnigmaSettings()
        {
            object[] enigmaSettings = new object[3];
            string steckerSettings = SteckerSettings();
            if (steckerSettings != null)
                enigmaSettings[0] = steckerSettings;
            else return null;

            int[] ringSettings = RinngSettings();
            List<Rotor> selectedRotors;
            try
            { selectedRotors = SelectedRotors(); }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Виберіть ротори з випадаючих списків!");
                return null;
            }
            if (ringSettings != null && selectedRotors != null)
            {
                for (int i = 0; i < selectedRotors.Count; ++i)
                    selectedRotors[i].Ringstellung = ringSettings[selectedRotors.Count - (i + 1)] - 1;
                enigmaSettings[1] = selectedRotors;
            }
            else return null;
            string reflector;
            try { reflector = reflectors[reflectorComboBox.Text]; }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Виберіть рефлектор з випадаючого списку!");
                return null;
            }
            enigmaSettings[2] = reflector;
            return enigmaSettings;
        }
 
        private void Settings()
        {
            settings = EnigmaSettings();
            if (settings != null)
            {
                settingsButton.Enabled = false;
                resetSettings.Enabled = true;
                encodeDecode.Enabled = true;
            }
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings();
        }

        private void ResetSettings()
        {
            settings = null;
            resetSettings.Enabled = false;
            encodeDecode.Enabled = false;
            settingsButton.Enabled = true;
        }
        private void ResetSettings_Click(object sender, EventArgs e)
        {
            ResetSettings();
        }

        private void FourthRotorOn_CheckedChanged(object sender, EventArgs e)
        {
            ResetSettings();
            rotor4ComboBox.Enabled = !rotor4ComboBox.Enabled;
            rotor4.Enabled = !rotor4.Enabled;
        }

        private void AddRotor(string filename)
        {
            string[] file = File.ReadAllLines(filename);
            string errorMessage = "Файл пошкоджено!";
            if (file.Length < 3)
            {
                MessageBox.Show(errorMessage);
                return;
            }
            string wiring = file[1].Replace(" ", "").ToUpper();
            int[] notchs;
            if (wiring.Length == 26 && file[2].Replace(" ", "") != "")
            {
                if (!ValidationOfEnigma.BelongAlphabet(wiring))
                {
                    MessageBox.Show(errorMessage);
                    return;
                }
                if (ValidationOfEnigma.SymbolsRepeated(wiring))
                {
                    MessageBox.Show(errorMessage);
                    return;
                }
                try
                {
                    notchs = file[2].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
                }
                catch
                {
                    MessageBox.Show(errorMessage);
                    return;
                }
                if (!ValidationOfEnigma.AllNumbersIntoInterval(notchs))
                {
                    MessageBox.Show(errorMessage);
                    return;
                }

                try
                {
                    if (notchs.Length > 1)
                        rotors.Add(file[0], new Rotor() { Wiring = wiring, Notch = notchs[0] - 1, Notch2 = notchs[1] - 1 });
                    else
                        rotors.Add(file[0], new Rotor() { Wiring = wiring, Notch = notchs[0] - 1 });
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Ротор з таким ключем уже існує!");
                    return;
                }
                listRotors.Items.Add(file[0]);
                rightRotorComboBox.Items.Add(file[0]);
                middleRotorComboBox.Items.Add(file[0]);
                leftRotorComboBox.Items.Add(file[0]);
                rotor4ComboBox.Items.Add(file[0]);
            }
            else
                MessageBox.Show(errorMessage);
        }

        private List<Rotor> SelectedRotors()
        {
            List<Rotor> selectedRotors = new List<Rotor>();
            string errorMessage = "Вствновлені однакові ротори!";
            selectedRotors.Add(rotors[rightRotorComboBox.Text]);
            if (rightRotorComboBox.Text != middleRotorComboBox.Text)
                selectedRotors.Add(rotors[middleRotorComboBox.Text]);
            else
            {
                MessageBox.Show(errorMessage);
                return null;
            }
            if (leftRotorComboBox.Text != middleRotorComboBox.Text && leftRotorComboBox.Text != rightRotorComboBox.Text)
                selectedRotors.Add(rotors[leftRotorComboBox.Text]);
            else
            {
                MessageBox.Show(errorMessage);
                return null;
            }
            if (fourthRotorOn.Checked)
            {
                if (rotor4ComboBox.Text != leftRotorComboBox.Text && rotor4ComboBox.Text != middleRotorComboBox.Text && rotor4ComboBox.Text != rightRotorComboBox.Text)
                    selectedRotors.Add(rotors[rotor4ComboBox.Text]);
                else
                {
                    MessageBox.Show(errorMessage);
                    return null;
                }
            }
            return selectedRotors;
        }

        private void AddRotor_Click(object sender, EventArgs e)
        {
            string filename;
            OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Текстові файли(*.rot)|*.rot" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                AddRotor(filename);
            }
        }

        private void AddReflector(string filename)
        {
            string[] file = File.ReadAllLines(filename);
            string errorMessage = "Файл пошкоджено!";
            if (file.Length < 2)
            {
                MessageBox.Show(errorMessage);
                return;
            }
            string wiring = file[1].Replace(" ", "").ToUpper();
            if (wiring.Length != 26)
                return;
            if (!ValidationOfEnigma.BelongAlphabet(wiring))
            {
                MessageBox.Show(errorMessage);
                return;
            }
            if (ValidationOfEnigma.SymbolsRepeated(wiring))
            {
                MessageBox.Show(errorMessage);
                return;
            }
            reflectors.Add(file[0], wiring);
            listReflectors.Items.Add(file[0]);
            reflectorComboBox.Items.Add(file[0]);
        }

        private void AddReflector_Click(object sender, EventArgs e)
        {
            string filename;
            OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Текстові файли(*.ref)|*.ref" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                AddReflector(filename);
            }
        }

        private void RemoveRotors_Click(object sender, EventArgs e)
        {
            if (listRotors.Items.Count > 0)
            {
                string keyRotor;
                try { keyRotor = listRotors.SelectedItem.ToString(); }
                catch
                {
                    MessageBox.Show("Виберіть ротор який необхідно видалити!");
                    return;
                }
                ResetSettings();
                rotors.Remove(keyRotor);
                listRotors.Items.Remove(keyRotor);
                rightRotorComboBox.Items.Remove(keyRotor);
                middleRotorComboBox.Items.Remove(keyRotor);
                leftRotorComboBox.Items.Remove(keyRotor);
                rotor4ComboBox.Items.Remove(keyRotor);
            }
            else
                MessageBox.Show("У списку немає роторів!");
        }

        private void RemoveReflectors_Click(object sender, EventArgs e)
        {
            if (listReflectors.Items.Count > 0)
            {
                string keyReflector;
                try { keyReflector = listReflectors.SelectedItem.ToString(); }
                catch
                {
                    MessageBox.Show("Виберіть рефлектор який необхідно видалити!");
                    return;
                }
                ResetSettings();
                reflectors.Remove(keyReflector);
                listReflectors.Items.Remove(keyReflector);
                reflectorComboBox.Items.Remove(keyReflector);
            }
            else
                MessageBox.Show("У списку немає рефлекторів!");
        }

        private void EncodeDecode_Click(object sender, EventArgs e)
        {
            if (settings != null)
            {
                List<Rotor> selectedRotors = (List<Rotor>)settings[1];
                try
                {
                    selectedRotors[0].Position = Enigma.alphabet.IndexOf(rightRotor.Text.ToUpper()[0]);
                    selectedRotors[1].Position = Enigma.alphabet.IndexOf(middleRotor.Text.ToUpper()[0]);
                    selectedRotors[2].Position = Enigma.alphabet.IndexOf(leftRotor.Text.ToUpper()[0]);
                    if (selectedRotors.Count == 4)
                        selectedRotors[3].Position = Enigma.alphabet.IndexOf(rotor4.Text.ToUpper()[0]);
                }
                catch
                {
                    MessageBox.Show("Неправильне введення положення роторів!\r\nПоложення роторів вказуються латинськими літерами від A до Z включно");
                    return;
                }
                string inpuText = symbol.Text.ToUpper();
                if (ValidationOfEnigma.BelongAlphabet(inpuText.Replace(" ", "")))
                {
                    string cipherText = string.Empty;
                    foreach (char s in inpuText)
                    {
                        if (s != ' ')
                            cipherText += Enigma.Encrypt(s, (string)settings[0], selectedRotors, (string)settings[2]).ToString();
                        else
                            cipherText += " ";
                    }
                    encodedSymbol.Text = cipherText;
                }
                else
                    MessageBox.Show("Символи у вхідному тексті мають бути латинськими літерами!");
            }
        }

        private void ClearTopMargins_Click(object sender, EventArgs e)
        {
            rotor4ComboBox.Text = string.Empty;
            leftRotorComboBox.Text = string.Empty;
            middleRotorComboBox.Text = string.Empty;
            rightRotorComboBox.Text = string.Empty;
            reflectorComboBox.Text = string.Empty;
            ringstellung.Text = string.Empty;
            steckerverbindungen.Text = string.Empty;
        }

        private void ClearBottomMargins_Click(object sender, EventArgs e)
        {
            rotor4.Text = "A";
            leftRotor.Text = "A";
            middleRotor.Text = "A";
            rightRotor.Text = "A";
            symbol.Text = string.Empty;
            encodedSymbol.Text = string.Empty;
        }
    }
}