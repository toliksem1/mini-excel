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
    public partial class Form3 : Form
    {

        public Form1 f1;//посилання на головну форму

        public Form3(Form1 f)
        {
            InitializeComponent();
            f1 = f;//зберігаємо посилання на головну форму
        }

        private void button1_Click(object sender, EventArgs e)//кнопка знайти
        {
            f1.gridFind(textBox1.Text, checkBox1.Checked);//викликаємо процедуру пошуку головної форми
                                                          //перший аргумент - шуканий текст, другий - чутливість до реєстру
            this.Close();//закриваємо форму
        }

        private void button2_Click(object sender, EventArgs e)//кнопка відмінити
        {
            this.Close();//закриваємо форму
        }

        
    }
}
