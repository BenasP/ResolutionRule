using System;
using System.Windows.Forms;

namespace ResolutionRule
{
    public partial class ResolutionRuleForm : Form
    {
        public ResolutionRuleForm()
        {
            InitializeComponent();
        }

        private void ResolutionRuleForm_Load(object sender, EventArgs e)
        {
            ValidateGenerateButton();
        }

        private void ValidateGenerateButton()
        {
            GenerateButton.Enabled = SourceFileTextBox.Text.IsNullOrEmpty() && ResultFileTextBox.Text.IsNullOrEmpty();
        }
    }
}
