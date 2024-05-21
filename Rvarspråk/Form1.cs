using Microsoft.VisualBasic;
using System.Drawing.Text;
using System.Text.RegularExpressions;

namespace Rvarspråk
{
    
    public partial class Form1 : Form
    {
        //lägger till vokaler och konsonanter som string 
        private readonly string consonants = "bcdfghjklmnpqrstvwz";
        private readonly string vokaler = "aeiouåöäy";
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            //sätter i till 0 och gör så att i altid är mindre än texten i textbox1. lägger till 1++
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                //hittar sista bokstaven i textbox1
                char c = textBox1.Text.ToLower()[i];
                //om sista bokstaven är en konsonant sätter den konsonanten i textbox2
                if (consonants.Contains(c))
                {
                    textBox2.Text += c;
                }
                //om sista bokstaven är en konsonant sätter den vokal i textbox2 använder detta för att fixa X
                if (vokaler.Contains(c))
                {
                    textBox2.Text += c;
                }
                   // om sista bokstaven är X så skrivs det koksos i Textbox2
                if (c == 'x')
                {
                    textBox2.Text += "koksos";
                }
                //fixar konverteringen till rövarspråk
                else if (consonants.Contains(c))
                {
                    textBox2.Text += 'o';
                    textBox2.Text += c;
                }
                 
            }
        }
        
    }
}
