using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formel_Sammlung
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen stift = new Pen(Color.Black, 2); // erstellt einen Stift in der Farbe Schwarz
            Graphics leinwand = e.Graphics; // e.Graphics verwenden

            if (radioButtonWürfel.Checked)
            {
                leinwand.DrawLine(stift, 175, 175, 175, 75);
                leinwand.DrawLine(stift, 175, 175, 275, 175);
                leinwand.DrawLine(stift, 175, 75, 275, 75);
                leinwand.DrawLine(stift, 275, 75, 275, 175);
                leinwand.DrawLine(stift, 275, 175, 325, 125);
                leinwand.DrawLine(stift, 275, 75, 325, 25);
                leinwand.DrawLine(stift, 175, 75, 225, 25);
                leinwand.DrawLine(stift, 175, 175, 225, 125);
                leinwand.DrawLine(stift, 225, 125, 225, 25);
                leinwand.DrawLine(stift, 325, 125, 325, 25);
                leinwand.DrawLine(stift, 225, 125, 325, 125);
                leinwand.DrawLine(stift, 225, 25, 325, 25);
                Font font1 = new Font("Times New Roman", 16, FontStyle.Bold, GraphicsUnit.Pixel);
                Point point1 = new Point(200, 180);
                Point point2 = new Point(325, 60);
                leinwand.DrawString("Seite a", font1, Brushes.Black, point1);
                leinwand.DrawString("Seite a", font1, Brushes.Black, point2);
            }
            else if (radioButtonQuader.Checked)
            {
                leinwand.DrawLine(stift, 150, 200, 350, 200);
                leinwand.DrawLine(stift, 150, 200, 150, 100);
                leinwand.DrawLine(stift, 150, 100, 350, 100);
                leinwand.DrawLine(stift, 350, 100, 350, 200);
                leinwand.DrawLine(stift, 350, 200, 400, 150);
                leinwand.DrawLine(stift, 350, 100, 400, 50);
                leinwand.DrawLine(stift, 150, 200, 200, 150);
                leinwand.DrawLine(stift, 150, 100, 200, 50);
                leinwand.DrawLine(stift, 200, 50, 200, 150);
                leinwand.DrawLine(stift, 200, 50, 400, 50);
                leinwand.DrawLine(stift, 200, 150, 400, 150);
                leinwand.DrawLine(stift, 400, 50, 400, 150);
                Font font1 = new Font("Times New Roman", 16, FontStyle.Bold, GraphicsUnit.Pixel);
                Point point1 = new Point(230, 200);
                Point point2 = new Point(400, 90);
                Point point3 = new Point(375, 175);
                leinwand.DrawString("Seite a", font1, Brushes.Black, point1);
                leinwand.DrawString("Seite b", font1, Brushes.Black, point2);
                leinwand.DrawString("Seite c", font1, Brushes.Black, point3);
            }
        }

        private void radioButtonWürfel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonQuader_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonZylinder_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonKegel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonPrisma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonKugel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonZeichnen_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Invalidate(); // Paint-Event auslösen
        }

        private void buttonReset_Click_1(object sender, EventArgs e)
        {
            Graphics leinwand = pictureBox1.CreateGraphics();
            labelErgebnis.Text = ("");
            txtEingabe1.Text = ("");
            txtEingabe2.Text = ("");
            txtEingabe3.Text = ("");
            pictureBox1.Invalidate(); // Paint-Event auslösen
        }

        private void buttonBerechnen_Click_1(object sender, EventArgs e)
        {
            Double Volumen, Oberfläche;
            if (radioButtonWürfel.Checked && radioButtonVolumen.Checked)
            {
                Double a = Convert.ToDouble(txtEingabe1.Text);
                Volumen = Math.Pow(a, 3);
                labelErgebnis.Text = ("Das Volumen des Würfels beträgt: ") + Volumen + ("cm³");
            }
            else if (radioButtonWürfel.Checked && radioButtonOberfläche.Checked)
            {
                Double a = Convert.ToDouble(txtEingabe1.Text);
                Oberfläche = 6 * Math.Pow(a, 2);
                labelErgebnis.Text = ("Die Oberfläche des Würfels beträgt: ") + Oberfläche + ("cm²");
            }
            else if (radioButtonQuader.Checked && radioButtonVolumen.Checked)
            {
                Double a = Convert.ToDouble(txtEingabe1.Text);
                Double b = Convert.ToDouble(txtEingabe2.Text);
                Double c = Convert.ToDouble(txtEingabe3.Text);
                Volumen = a * b * c;
                labelErgebnis.Text = ("Das Volumen des Quaders beträgt: ") + Volumen + ("cm³");
            }
            else if (radioButtonQuader.Checked && radioButtonOberfläche.Checked)
            {
                Double a = Convert.ToDouble(txtEingabe1.Text);
                Double b = Convert.ToDouble(txtEingabe2.Text);
                Double c = Convert.ToDouble(txtEingabe3.Text);
                Oberfläche = 2 * a * b + 2 * b * c + 2 * a * c;
                labelErgebnis.Text = ("Die Oberfläche des Quaders beträgt: ") + Oberfläche + ("cm²");
            }
            else if (radioButtonZylinder.Checked && radioButtonVolumen.Checked)
            {
                Double r = Convert.ToDouble(txtEingabe1.Text);
                Double h = Convert.ToDouble(txtEingabe2.Text);
                Double VolumenRounded;
                Volumen = Math.PI * Math.Pow(r, 2) * h;
                VolumenRounded = Math.Round(Volumen, 3);
                labelErgebnis.Text = ("Das Volumen des Zylinders beträgt: ") + VolumenRounded + ("cm³");
            }
            else if (radioButtonZylinder.Checked && radioButtonOberfläche.Checked)
            {
                Double r = Convert.ToDouble(txtEingabe1.Text);
                Double h = Convert.ToDouble(txtEingabe2.Text);
                Double OberflächeRounded;
                Oberfläche = 2 * Math.PI * r + 2 * Math.PI * r * h;
                OberflächeRounded = Math.Round(Oberfläche, 3);
                labelErgebnis.Text = ("Die Oberfläche des Zylinders beträgt: ") + OberflächeRounded + ("cm²");
            }
            else if (radioButtonKegel.Checked && radioButtonVolumen.Checked)
            {
                Double r = Convert.ToDouble(txtEingabe2.Text);
                Double h = Convert.ToDouble(txtEingabe1.Text);
                Double VolumenRounded;
                Volumen = (1.0 / 3.0) * Math.PI * Math.Pow(r, 2) * h;
                VolumenRounded = Math.Round(Volumen, 3);
                labelErgebnis.Text = ("Das Volumen des Kegelss beträgt: ") + VolumenRounded + ("cm³");
            }
            else if (radioButtonKegel.Checked && radioButtonOberfläche.Checked)
            {
                Double s = Convert.ToDouble(txtEingabe1.Text);
                Double r = Convert.ToDouble(txtEingabe2.Text);
                Double h = Convert.ToDouble(txtEingabe3.Text);
                Double OberflächeRounded;
                Oberfläche = Math.PI * Math.Pow(r, 2) + Math.PI * r * s;
                OberflächeRounded = Math.Round(Oberfläche, 3);
                labelErgebnis.Text = ("Die Oberfläche des Kegelss beträgt: ") + OberflächeRounded + ("cm²");
            }
            else if (radioButtonPrisma.Checked && radioButtonVolumen.Checked)
            {
                Double G = Convert.ToDouble(txtEingabe1.Text);
                Double h = Convert.ToDouble(txtEingabe2.Text);
                Volumen = G * h;
                Double VolumenRounded = Math.Round(Volumen, 3);
                labelErgebnis.Text = ("Das Volumen des Prisma beträgt: ") + VolumenRounded + ("cm³");
            }
            else if (radioButtonPrisma.Checked && radioButtonOberfläche.Checked)
            {
                Double G = Convert.ToDouble(txtEingabe1.Text);
                Double M = Convert.ToDouble(txtEingabe2.Text);
                Oberfläche = 2 * G + M;
                Double OberflächeRounded = Math.Round(Oberfläche, 3);
                labelErgebnis.Text = ("Die Oberfläche des Prisma beträgt: ") + OberflächeRounded + ("cm²");
            }
            else if (radioButtonKugel.Checked && radioButtonVolumen.Checked)
            {
                Double r = Convert.ToDouble(txtEingabe1.Text);
                Volumen = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
                Double VolumenRounded = Math.Round(Volumen, 2);
                labelErgebnis.Text = ("Das Volumen der Kugel beträgt: ") + VolumenRounded + ("cm³");
            }
            else if (radioButtonKugel.Checked && radioButtonOberfläche.Checked)
            {
                Double r = Convert.ToDouble(txtEingabe1.Text);
                Oberfläche = 4 * Math.PI * Math.Pow(r, 2);
                Double OberflächeRounded = Math.Round(Oberfläche, 3);
                labelErgebnis.Text = ("Die Oberfläche der Kugel beträgt: ") + OberflächeRounded + ("cm²");
            }
            else
            {
                Console.WriteLine("Bitte geben sie die Gültigen Zahl ein und Wählen sie Einen Körper aus");
                labelErgebnis.Text = ("Bitte geben sie die Gültigen Zahl ein\n   und Wählen sie Einen Körper aus");
            }
        }

        private void buttonEingabeÄndern_Click(object sender, EventArgs e)
        {
            if (radioButtonWürfel.Checked)
            {
                labelWert1.Text = ("Wert A in cm");
                txtEingabe2.Visible = false;
                labelWert2.Visible = false;
                txtEingabe3.Visible = false;
                labelWert3.Visible = false;
            }
            else if (radioButtonQuader.Checked)
            {
                txtEingabe2.Visible = true;
                labelWert2.Visible = true;
                txtEingabe3.Visible = true;
                labelWert3.Visible = true;
                labelWert1.Text = ("Strecke |a| in cm");
                labelWert2.Text = ("Strecke |b| in cm");
                labelWert3.Text = ("Strecke |c| in cm");
            }
            else if (radioButtonZylinder.Checked)
            {
                txtEingabe2.Visible = true;
                labelWert2.Visible = true;
                txtEingabe3.Visible = false;
                labelWert3.Visible = false;
                labelWert1.Text = ("Radius |r| in cm");
                labelWert2.Text = ("Höhe |h| in cm");

            }
            else if (radioButtonKegel.Checked && radioButtonOberfläche.Checked)
            {
                txtEingabe2.Visible = true;
                labelWert2.Visible = true;
                txtEingabe3.Visible = true;
                labelWert3.Visible = true;
                labelWert1.Text = ("Strecke |s| in cm");
                labelWert2.Text = ("Radius |r| in cm");
                labelWert3.Text = ("Höhe |h| in cm");
            }
            else if (radioButtonKegel.Checked && radioButtonVolumen.Checked)
            {
                txtEingabe2.Visible = true;
                labelWert2.Visible = true;
                txtEingabe3.Visible = false;
                labelWert3.Visible = false;
                labelWert1.Text = ("Höhe |h| in cm");
                labelWert2.Text = ("Radius |r| in cm");
            }
            else if (radioButtonPrisma.Checked && radioButtonVolumen.Checked)
            {
                txtEingabe2.Visible = true;
                labelWert2.Visible = true;
                txtEingabe3.Visible = false;
                labelWert3.Visible = false;
                labelWert1.Text = ("Grundfläche |G| in cm²");
                labelWert2.Text = ("Höhe |h| in cm");
            }
            else if (radioButtonPrisma.Checked && radioButtonOberfläche.Checked)
            {
                txtEingabe2.Visible = true;
                labelWert2.Visible = true;
                txtEingabe3.Visible = false;
                labelWert3.Visible = false;
                labelWert1.Text = ("Grundfläche |G| in cm²");
                labelWert2.Text = ("Fläche |M| in cm²");
            }
            else
            {
                txtEingabe2.Visible = false;
                labelWert2.Visible = false;
                txtEingabe3.Visible = false;
                labelWert3.Visible = false;
                labelWert1.Text = ("Radius |r| in cm");
            }



            groupBoxEingabe.Update();
        }
    }
}