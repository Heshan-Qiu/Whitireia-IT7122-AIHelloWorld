using System;
using System.Windows.Forms;

namespace AIHelloWorldForms
{
    public partial class MainForm : Form
    {
        private LanguageDector dector;

        private LanguageTranslator translater;

        private string hello = "Hello world!";

        public MainForm()
        {
            InitializeComponent();

            CleanWords();

            dector = new LanguageDector();
            translater = new LanguageTranslator();
        }

        private async void btnSubmit_ClickAsync(object sender, EventArgs e)
        {
            CleanWords();

            if (string.IsNullOrWhiteSpace(tbxWords.Text))
            {
                MessageBox.Show("Please type your words.", "Words Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxWords.Focus();
            }
            else
            {
                DetectedLanguage language = await dector.DetectLanguage(tbxWords.Text);
                labelLanguage.Text = language.Name;

                string translatedName = await translater.GetTranslatedLanguageName(tbxWords.Text);
                labelHello.Text = await translater.Translate(translatedName, this.hello);
            }
        }

        private void CleanWords()
        {
            this.labelLanguage.Text = "";
            this.labelHello.Text = "";
        }
    }
}
