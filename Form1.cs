namespace Formel_Sammlung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ÷ffnet Form3
            Form2 form2 = new Form2();
            form2.Show();

            // schlieﬂt die Aktuelle Seite
            this.Hide();
        }
    }
}
