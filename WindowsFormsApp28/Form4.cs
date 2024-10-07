using System;
using System.Windows.Forms;

namespace WindowsFormsApp28
{
    public partial class Form4 : Form
    {
        public Form1 f1;//посилання на головну форму
        public DataGridView dg;//посилання на сітку з даними
        public int c = 0;//змінна для проміжного зберігання кількості стовпців
        public int r = 0;//змінна для проміжного зберігання кількості рядків

        public Form4(Form1 f, DataGridView d)//конструктор форми
        {
            InitializeComponent();
            f1 = f;//зберігаємо посилання на головну форму
            dg = d;//зберігаємо посилання на сітку з даними
        }

        private void button2_Click(object sender, EventArgs e)//кнопка відмінити
        {
            this.Close();//закриваємо форму
        }

        private void button1_Click(object sender, EventArgs e)//кнопка замінити все
        {
            f1.gridFind(textBox1.Text, checkBox1.Checked);//викликаємо процедуру пошуку із головної форми
                                                          //перший аргумент - шуканий текст, другий - чутливість до реєстру
                                                          //після виконання функції, всі клітинки в яких міститься шуканий фрагмент тексту,
                                                          //будуть виділеними
            int zmineno = 0;
            foreach (DataGridViewCell cl in dg.SelectedCells)
            {//перебираємо всі виділені клітинки
                cl.Value = textBox2.Text;//замінюємо значення кожної клітинки
                zmineno++;
            }
            MessageBox.Show($"Заміна завершена, замінено {zmineno} клітинок.", "Заміна завершена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();//закриваємо форму
        }

        private void button3_Click(object sender, EventArgs e)//кнопка замінити
        {
            f1.gridFind(textBox1.Text, checkBox1.Checked);//викликаємо процедуру пошуку із головної форми
                                                          //навіщо викликати - описано вище
            for (int i = dg.SelectedCells.Count - 1; i >= 0; i--)//перебираємо вибрані клітинки через змінну і
            {
                //показуємо повідомлення із запитом на заміну
                if (MessageBox.Show("Replace?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {//якщо користувач схвалив заміну
                    dg.SelectedCells[i].Value = textBox2.Text;//міняємо текст поточної клітинки
                }
            }
            this.Close();//закриваємо форму
        }

      
    }
}
