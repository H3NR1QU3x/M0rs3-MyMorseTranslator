using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M0rs3
{
    public partial class Form1 : Form
    {
        

        private Dictionary<char, string> _charToMorse = new Dictionary<char, string>()
        {
            {'A', ".-"},
            {'B', "-..."},
            {'C', "-.-."},
            {'D', "-.."},
            {'E', "."},
            {'F', "..-."},
            {'G', "--."},
            {'H', "...."},
            {'I', ".."},
            {'J', ".---"},
            {'K', "-.-"},
            {'L', ".-.."},
            {'M', "--"},
            {'N', "-."},
            {'O', "---"},
            {'P', ".--."},
            {'Q', "--.-"},
            {'R', ".-."},
            {'S', "..."},
            {'T', "-"},
            {'U', "..-"},
            {'V', "...-"},
            {'W', ".--"},
            {'X', "-..-"},
            {'Y', "-.--"},
            {'Z', "--.."},
            {'0', "-----"},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {'Ç', "-.-.."},
            {'.', ".-.-.-"},
            {',', "--..--"},
            {'?', "..--.."},
            {'´', "	.----."},
            {'!', "-.-.--"},
            {'/', "-..-."},
            {'(', "-.--."},
            {')', "-.--.-"},
            {'&', ".-..."},
            {':', "---..."},
            {';', "-.-.-."},
            {'=', "-...-"},
            {'+', ".-.-."},
            {'-', "-....-"},
            {'_', "..--.-"},
            {'"', ".-..-."},
            {'$', "	...-..-"},
            {'@', ".--.-."},
            {'¿', "..-.-"},
            {'¡', "--...-"},







        };

        private Dictionary<string, char> _morseToChar = new Dictionary<string, char>();

        public Form1()
        {
            InitializeComponent();
            foreach (var kvp in _charToMorse)
            {
                _morseToChar.Add(kvp.Value, kvp.Key);
            }


        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.ToUpper();
            string output = "";

            if (rbnTextToMorse.Checked == true)
            {
                // Texto para Morse
                foreach (char c in input)
                {
                    if (c == ' ')
                        output += "  ";
                    else
                        output += _charToMorse[c] + " ";
                }
            }
            else
            {
                // Morse para Texto
                string[] words = input.Split(new string[] { "  " }, StringSplitOptions.None);

                foreach (string word in words)
                {
                    string[] letters = word.Split(' ');
                    foreach (string letter in letters)
                    {
                        if (_morseToChar.ContainsKey(letter))
                        {
                            output += _morseToChar[letter];
                        }
                    }
                    output += " ";
                }
            }


            txtOutput.Text = output.TrimEnd();
        }

        private void rbnTextToMorse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnTextToMorse.Checked == true)
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
        }

        private void rbnMorseToText_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnMorseToText.Checked == true)
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if(txtOutput.Text == "")
            {
                MessageBox.Show("Para copiar o Output, é preciso haver Output." +
                    "\n\nPeço-te se não for muito maçante, escreve alguma coisa no Input.","Sem Output",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
              Clipboard.SetText(txtOutput.Text);
            }
            
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtInput.Text = Clipboard.GetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string message = "Se for sobre alguns caracteres que levam acentuação,alguns caracteres não estão disponiveis devido de não haver uma tradução certa para o caracter." +
                "\n\nSe não for sobre isso, sê livre de ir ao meu Website para relatar sobre algum problema.";
               string ws = Environment.NewLine + "\nhttps://h3nr1qu3x.github.io/website/contact.html";
            MessageBox.Show(message + ws,"Ajuda" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
