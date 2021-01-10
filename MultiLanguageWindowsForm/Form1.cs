using System.Windows.Forms;
using MultiLanguageWindowsForm.Language;

namespace MultiLanguageWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void FieldLanguage(string language)
        {
            var cl = new ChoseLanguage();
            cl.Language(language);

            labelName.Text = cl.Lang.Name;
            labelCountry.Text = cl.Lang.Coutry;
        }

        private void buttonLanguage_Click(object sender, System.EventArgs e)
        {
            if (comboBoxLanguage.Text!="")
            {
                
            var language = comboBoxLanguage.Text;
            FieldLanguage(language);
            }
            else
            {
                MessageBox.Show("Please Select Language & Try Again","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
