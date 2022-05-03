using Interpreter.Core.Sorters;
using System;
using System.Windows.Forms;

namespace Interpreter
{
    public partial class MainForm : Form
    {
        private readonly IInterpreter _interpreter;
        private readonly ISorter _sorter;

        public MainForm()
        {
            InitializeComponent();

            _interpreter = new GoodleInterpreter(FromLanguageBox.Text, ToLanguageBox.Text);
            _sorter = new InsertionSorter();
        }

        private void OnTranslateButtonClicked(object sender, EventArgs e)
        {
            string inputWord = InputField.Text;

            TranslateData translateDate = _interpreter.Translate(inputWord);

            OutputWindow.Text += translateDate.TranslateWord + " ";
        }

        private void OnSortButtonClicked(object sender, EventArgs e)
        {
            string[] sortWords = OutputWindow.Text.Split(' ');

            _sorter.Sort(sortWords);

            OutputWindow.Clear();

            foreach (var sortedWord in sortWords)
                OutputWindow.Text += sortedWord + " ";
        }

        private void OnClearOutputWindowClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OutputWindow.Text))
                MessageBox.Show("Уже чисто как бы");
            else
               OutputWindow.Clear();
        }

        private void OnChangeLanguageButtonClicked(object sender, EventArgs e)
        {
            _interpreter.ChangeFromLanguage(FromLanguageBox.Text);
            _interpreter.ChangeToLanguage(ToLanguageBox.Text);

            MessageBox.Show("Новые языки установлены");
        }
    }
}
