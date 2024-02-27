using System.ComponentModel.DataAnnotations;
using System.Windows.Forms.Design;
using System.IO;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;

namespace Notes
{
    public partial class Form1 : Form
    {
        public string Dateipfadlogin = Path.Combine(@"..\data\login.csv");

        public Form1()
        {
            InitializeComponent();


        }

        string Email = string.Empty;
        string Passwort = string.Empty;
        private void button13_Click(object sender, EventArgs e)
        {
            PanelIT.Visible = true;
            panel4.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            PanelABU.Visible = true;
            panel6.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            PanelEG.Visible = true;
            panel3.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            PanelRechner.Visible = true;
            panel8.Visible = true;
        }



        private void button6_Click(object sender, EventArgs e)
        {
            PanelIT.Visible = false;
            panel4.Visible = false;
        }



        private void button9_Click(object sender, EventArgs e)
        {
            PanelABU.Visible = false;
            panel6.Visible = false;
        }



        private void button5_Click(object sender, EventArgs e)
        {
            PanelEG.Visible = false;
            panel3.Visible = false;
        }


        private void button12_Click(object sender, EventArgs e)
        {
            PanelRechner.Visible = false;
            panel8.Visible = false;
        }






        private void button7_Click_1(object sender, EventArgs e)
        {

            int counter = 4;
            string Note1 = IT01.Text;
            string Note2 = IT02.Text;
            string Note3 = IT03.Text;
            string Note4 = IT04.Text;

            double Note1double = Convert.ToDouble(Note1);
            double Note2double = Convert.ToDouble(Note2);
            double Note3double = Convert.ToDouble(Note3);
            double Note4double = Convert.ToDouble(Note4);



            if (Note1double <= 0 || Note1double > 6)
            {
                Note1double = 0;
                IT01.Text = "0";
                counter--;
            }
            if (Note2double <= 0 || Note2double > 6)
            {
                Note2double = 0;
                IT02.Text = "0";
                counter--;
            }
            if (Note3double <= 0 || Note3double > 6)
            {
                Note3double = 0;
                IT03.Text = "0";
                counter--;
            }
            if (Note4double <= 0 || Note4double > 6)
            {
                Note4double = 0;
                IT04.Text = "0";
                counter--;
            }


            double sum = Note1double + Note2double + Note3double + Note4double;
            double durchschnitt = sum / counter;


            string durchschnittstring = Convert.ToString(Math.Round(durchschnitt, 2));

            DurchschnittIT.Text = durchschnittstring;


        }

        private void button8_Click(object sender, EventArgs e)
        {

            int counter = 4;
            string Note1 = ABU01.Text;
            string Note2 = ABU02.Text;
            string Note3 = ABU03.Text;
            string Note4 = ABU04.Text;

            double Note1double = Convert.ToDouble(Note1);
            double Note2double = Convert.ToDouble(Note2);
            double Note3double = Convert.ToDouble(Note3);
            double Note4double = Convert.ToDouble(Note4);



            if (Note1double <= 0 || Note1double > 6)
            {
                Note1double = 0;
                ABU01.Text = "0";
                counter--;
            }
            if (Note2double <= 0 || Note2double > 6)
            {
                Note2double = 0;
                ABU02.Text = "0";
                counter--;
            }
            if (Note3double <= 0 || Note3double > 6)
            {
                Note3double = 0;
                ABU03.Text = "0";
                counter--;
            }
            if (Note4double <= 0 || Note4double > 6)
            {
                Note4double = 0;
                ABU04.Text = "0";
                counter--;
            }


            double sum = Note1double + Note2double + Note3double + Note4double;
            double durchschnitt = sum / counter;

            string durchschnittstring = Convert.ToString(Math.Round(durchschnitt, 2));


            DurchschnittABU.Text = durchschnittstring;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int counter = 4;
            string Note1 = EG01.Text;
            string Note2 = EG02.Text;
            string Note3 = EG03.Text;
            string Note4 = EG04.Text;

            double Note1double = Convert.ToDouble(Note1);
            double Note2double = Convert.ToDouble(Note2);
            double Note3double = Convert.ToDouble(Note3);
            double Note4double = Convert.ToDouble(Note4);



            if (Note1double <= 0 || Note1double > 6)
            {
                Note1double = 0;
                EG01.Text = "0";
                counter--;
            }
            if (Note2double <= 0 || Note2double > 6)
            {
                Note2double = 0;
                EG02.Text = "0";
                counter--;
            }
            if (Note3double <= 0 || Note3double > 6)
            {
                Note3double = 0;
                EG03.Text = "0";
                counter--;
            }
            if (Note4double <= 0 || Note4double > 6)
            {
                Note4double = 0;
                EG04.Text = "0";
                counter--;
            }


            double sum = Note1double + Note2double + Note3double + Note4double;
            double durchschnitt = sum / counter;

            string durchschnittstring = Convert.ToString(Math.Round(durchschnitt, 2));


            DurchschnittEG.Text = durchschnittstring;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string erreichtePunkte = textBox12.Text;
            string maxpunkte = textBox9.Text;

            double erreichtePunktedouble = Convert.ToDouble(erreichtePunkte);
            double maxpunktedouble = Convert.ToDouble(maxpunkte);

            if (erreichtePunktedouble < 0)
            {
                MessageBox.Show("Gebe eine gültige Zahl ein");
            }
            else if (erreichtePunktedouble > maxpunktedouble)
            {
                MessageBox.Show("Die erriechte Punktzahl kann nicht grösser als die maximale Punktzahl sein.");
            }
            else
            {
                double zwischenresultat1 = erreichtePunktedouble * 5;
                double zwischenresultat2 = zwischenresultat1 / maxpunktedouble;
                double Note = zwischenresultat2 + 1;

                string Notestring = Convert.ToString(Math.Round(Note, 2));

                label11.Text = Notestring;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> listelogins = new List<string>();
            string[] logins = File.ReadAllLines(Dateipfadlogin);

            string loginmail = textBox11.Text;
            string loginpasswort = textBox10.Text;
            string logintotal = loginmail + loginpasswort;
            bool logincheck = false;

            foreach (string login in logins)
            {



                if (logintotal == login && logintotal != string.Empty)
                {
                    string[] data = File.ReadAllLines($@"..\data\users\{logintotal}.csv");
                    logincheck = true;

                    IT01.Text = data[0];
                    IT02.Text = data[1];
                    IT03.Text = data[2];
                    IT04.Text = data[3];
                    DurchschnittIT.Text = data[4];
                    ABU01.Text = data[5];
                    ABU02.Text = data[6];
                    ABU03.Text = data[7];
                    ABU04.Text = data[8];
                    DurchschnittABU.Text = data[9];
                    EG01.Text = data[10];
                    EG02.Text = data[11];
                    EG03.Text = data[12];
                    EG04.Text = data[13];
                    DurchschnittEG.Text = data[14];



                }
            }



            if (logincheck == true)
            {
                Panelloginerfolgreich.Visible = true;
                PanelLogin.Visible = false;
            }

            else
            {
                textBox11.Text = string.Empty;
                textBox10.Text = string.Empty;
                Panelloginfehlgeschlagen.Visible = true;
                Panelloginerfolgreich.Visible = false;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Email = textBox18.Text;
            Passwort = textBox17.Text;
            if (Email != string.Empty && Passwort != string.Empty)
            {

                bool Digit = false;
                bool Upper = false;
                bool lower = false;
                bool Sonderzeichen = false;

                if (Passwort.Length >= 8)
                {
                    foreach (char i in Passwort)
                    {
                        if (char.IsDigit(i))
                        {
                            Digit = true;
                        }
                    }

                    if (Digit == true)
                    {
                        foreach (char i in Passwort)
                        {
                            if (char.IsUpper(i))
                            {
                                Upper = true;
                            }
                        }
                        if (Upper == true)
                        {
                            foreach (char i in Passwort)
                            {
                                if (char.IsLower(i))
                                {
                                    lower = true;
                                }
                            }
                            if (lower == true)
                            {
                                string Sonderzeichenstring = "!@#$%^&*()-_=+[]{}|;:'\",.<>/?";
                                foreach (char i in Passwort)
                                {
                                    if (Sonderzeichenstring.Contains(i))
                                    {
                                        Sonderzeichen = true;
                                    }
                                }
                            }
                        }
                    }

                    if (Digit == true && Upper == true && lower == true && Sonderzeichen == true && Email.Contains("@") && Email.Contains("."))
                    {
                        PanelAccounterstellt.Visible = true;
                        PanelSignUp.Visible = false;
                        textBox18.Text = string.Empty;
                        textBox17.Text = string.Empty;

                        File.AppendAllText(Dateipfadlogin, "\n" + Email + Passwort);

                        string userpath = Path.Combine(@$"..\data\users\{Email + Passwort}.csv");

                        string[] userdata =
                        {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"};
                        WriteToCsv(userpath, userdata);


                    }

                    else
                    {
                        textBox18.Text = string.Empty;
                        textBox17.Text = string.Empty;
                        Panelfehlgeschlagenpasswort.Visible = true;
                        PanelSignUp.Visible = false;
                    }
                }
                else
                {
                    textBox18.Text = string.Empty;
                    textBox17.Text = string.Empty;
                    Panelfehlgeschlagenpasswort.Visible = true;
                    PanelSignUp.Visible = false;
                }



            }
            else
            {
                textBox18.Text = string.Empty;
                textBox17.Text = string.Empty;
                Panelfehlgeschlagenpasswort.Visible = true;
                PanelSignUp.Visible = false;

            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string mail = textBox11.Text;
            string passwort = textBox10.Text;

            string userpath = Path.Combine(@$"..\data\users\{mail + passwort}.csv");

            string[] userdata =
            {
                IT01.Text,
                IT02.Text,
                IT03.Text,
                IT04.Text,
                DurchschnittIT.Text,
                ABU01.Text,
                ABU02.Text,
                ABU03.Text,
                ABU04.Text,
                DurchschnittABU.Text,
                EG01.Text,
                EG02.Text,
                EG03.Text,
                EG04.Text,
                DurchschnittEG.Text

            };



            WriteToCsv(userpath, userdata);




        }
        static void WriteToCsv(string userpath, string[] userdata)
        {
            if (!File.Exists(userpath))
            {

                using (StreamWriter createFile = File.CreateText(userpath))
                {

                    foreach (string note in userdata)
                    {
                        createFile.WriteLine(note);
                    }
                }
            }
            else

            {
                using (StreamWriter writer = new StreamWriter(userpath))
                {

                    foreach (string note in userdata)
                    {
                        writer.WriteLine(note);
                    }
                }
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            PanelLogin.Visible = false;
            PanelSignUp.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelAccounterstellt.Visible = false;
            PanelLogin.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Panelloginerfolgreich.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {

            PanelLogin.Visible = true;
            Panelloginfehlgeschlagen.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            PanelSignUp.Visible = true;
            Panelfehlgeschlagenpasswort.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox10.PasswordChar = '\0';
            }
            else
            {
                textBox10.PasswordChar = '•';
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked)
            {
                textBox17.PasswordChar = '\0';
            }
            else
            {
                textBox17.PasswordChar = '•';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {



        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}