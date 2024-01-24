using System.Windows.Forms.Design;

namespace Notes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        private void button13_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel4.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel6.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            panel8.Visible = true;
        }



        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel4.Visible = false;
        }



        private void button9_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel6.Visible = false;
        }



        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
        }


        private void button12_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel8.Visible = false;
        }






        private void button7_Click_1(object sender, EventArgs e)
        {

            int counter = 4;
            string Note1 = textBox1.Text;
            string Note2 = textBox5.Text;
            string Note3 = textBox4.Text;
            string Note4 = textBox3.Text;

            double Note1double = Convert.ToDouble(Note1);
            double Note2double = Convert.ToDouble(Note2);
            double Note3double = Convert.ToDouble(Note3);
            double Note4double = Convert.ToDouble(Note4);



            if (Note1double <= 0 || Note1double > 6)
            {
                Note1double = 0;
                textBox1.Text = "0";
                counter--;
            }
            if (Note2double <= 0 || Note2double > 6)
            {
                Note2double = 0;
                textBox5.Text = "0";
                counter--;
            }
            if (Note3double <= 0 || Note3double > 6)
            {
                Note3double = 0;
                textBox4.Text = "0";
                counter--;
            }
            if (Note4double <= 0 || Note4double > 6)
            {
                Note4double = 0;
                textBox3.Text = "0";
                counter--;
            }


            double sum = Note1double + Note2double + Note3double + Note4double;
            double durchschnitt = sum / counter;


            string durchschnittstring = Convert.ToString(Math.Round(durchschnitt, 2));

            label3.Text = durchschnittstring;


        }

        private void button8_Click(object sender, EventArgs e)
        {

            int counter = 4;
            string Note1 = textBox16.Text;
            string Note2 = textBox13.Text;
            string Note3 = textBox14.Text;
            string Note4 = textBox15.Text;

            double Note1double = Convert.ToDouble(Note1);
            double Note2double = Convert.ToDouble(Note2);
            double Note3double = Convert.ToDouble(Note3);
            double Note4double = Convert.ToDouble(Note4);



            if (Note1double <= 0 || Note1double > 6)
            {
                Note1double = 0;
                textBox16.Text = "0";
                counter--;
            }
            if (Note2double <= 0 || Note2double > 6)
            {
                Note2double = 0;
                textBox13.Text = "0";
                counter--;
            }
            if (Note3double <= 0 || Note3double > 6)
            {
                Note3double = 0;
                textBox14.Text = "0";
                counter--;
            }
            if (Note4double <= 0 || Note4double > 6)
            {
                Note4double = 0;
                textBox15.Text = "0";
                counter--;
            }


            double sum = Note1double + Note2double + Note3double + Note4double;
            double durchschnitt = sum / counter;

            string durchschnittstring = Convert.ToString(Math.Round(durchschnitt, 2));


            label7.Text = durchschnittstring;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int counter = 4;
            string Note1 = textBox8.Text;
            string Note2 = textBox2.Text;
            string Note3 = textBox6.Text;
            string Note4 = textBox7.Text;

            double Note1double = Convert.ToDouble(Note1);
            double Note2double = Convert.ToDouble(Note2);
            double Note3double = Convert.ToDouble(Note3);
            double Note4double = Convert.ToDouble(Note4);



            if (Note1double <= 0 || Note1double > 6)
            {
                Note1double = 0;
                textBox8.Text = "0";
                counter--;
            }
            if (Note2double <= 0 || Note2double > 6)
            {
                Note2double = 0;
                textBox2.Text = "0";
                counter--;
            }
            if (Note3double <= 0 || Note3double > 6)
            {
                Note3double = 0;
                textBox6.Text = "0";
                counter--;
            }
            if (Note4double <= 0 || Note4double > 6)
            {
                Note4double = 0;
                textBox7.Text = "0";
                counter--;
            }


            double sum = Note1double + Note2double + Note3double + Note4double;
            double durchschnitt = sum / counter;

            string durchschnittstring = Convert.ToString(Math.Round(durchschnitt, 2));


            label2.Text = durchschnittstring;
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


    }
}