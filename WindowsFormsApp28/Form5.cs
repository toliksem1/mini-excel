using System;
using System.Windows.Forms;

namespace WindowsFormsApp28
{
    public partial class Form5 : Form   
    {
        public Form1 f1;
        public Form5(Form1 f)
        {
            InitializeComponent();
            f1 = f;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Автор: Сємочко Анатолій Миколайович");
            listBox1.Items.Add("Групи: П21-1Д");
            listBox1.Items.Add("Навчається у Новокаховському приладобудівному фаховому коледжі.");
            listBox1.Items.Add("Дата народження 17.12.2005.");
        }

    }
}
