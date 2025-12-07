using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace windowsforme1
{
    public class MainForm : Form
    {
        Button Button = new Button();
        TextBox Boxname = new TextBox();
        TextBox BoxPasword = new TextBox();

        public MainForm()
        {
            this.Text = "Moja prva forma";
            this.Size = new System.Drawing.Size(640, 480);
            Button.Text = "Prijava";
            Button.Location = new System.Drawing.Point(100, 100);
            Boxname.Text = "Korisničko ime: Izbrisati ";
            Boxname.Location = new System.Drawing.Point(20, 20);
            Boxname.Width = 150;
            BoxPasword.Text = "Lozinka: Izbrisati ";
            BoxPasword.Location = new System.Drawing.Point(20, 60);
            BoxPasword.Width = 150;
            this.Controls.Add(Button);
            this.Controls.Add(Boxname);
            this.Controls.Add(BoxPasword);
            Button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            string korisnickoime = Boxname.Text;
            string lozinka = BoxPasword.Text;
            if (korisnickoime == "duje" && lozinka == "lucin")
            {
                MessageBox.Show("Ispravno");
            }
            else
            {
                MessageBox.Show(" Nije ispravno, pokušaj ponovno ):");
            }
        }
    }
}
