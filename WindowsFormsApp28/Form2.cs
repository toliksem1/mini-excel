using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp28
{
    public partial class Form2 : Form
    {

        public Form1 f1;//посилання на головну форму

        public Form2(int c, int r, Form1 f)//конструктор форми
                                           //с - кількість стовпців, r - кількість рядків, f - посилання на головну форму
        {
            InitializeComponent();
            textBox1.Text = c.ToString();//записуємо в поле значення стовпців по замовчуванню
            textBox2.Text = r.ToString();//записуємо в поле значення рядків по замовчуванню
            f1 = f;// зберігає посилання на головну форму
        }

        private void button2_Click(object sender, EventArgs e)//кнопка відмінити
        {
            this.Close();//закриваємо форму
        }

        private void button1_Click(object sender, EventArgs e)//кнопка створити
        {
            f1.x = Int32.Parse(textBox1.Text);//передаємо в головну форму нову кількість стовпців
            f1.y = Int32.Parse(textBox2.Text);//передаємо в головну форму нову кількість рядків
            f1.initGrid(f1.x, f1.y);//викликаємо ініціалізацію сітки головної форми із новими параметрами
            this.Close();//закриваємо форму
        }

    }
}
