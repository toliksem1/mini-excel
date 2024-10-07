using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp28
{
    public partial class Form1 : Form
    {

        public int x = 10;//розміри листа по замовчуванню
        public int y = 10;//по горизонталі і вертикалі відповідно

        public Form1()
        {
            InitializeComponent();
            initGrid(x, y);//ініціалізуємо сітку по значенням за замовчуванням
            this.FormClosing += MainForm_FormClosing;
        }
        public void initGrid(int c, int r)
        {//ініціалізація сітки
         //c - ширина, r - висота (в клітинках)
            x = c; y = r; //зберігаємо значення ширини та висоти в глобальні змінні
            dataGridView1.Columns.Clear();//очищуємо стовпці
            dataGridView1.Rows.Clear();//очищуємо рядки
            for (int i = 0; i < x; i++)//перебираємо від 0 до кількості стовпців -1 через змінну і
            {
                dataGridView1.Columns.Add(i.ToString(), i.ToString());//додаємо наступний стовпець
                                                                      //перший параметр назва стовпця
                                                                      //другий заголовок
            }

            for (int i = 0; i < y; i++)// перебираємо від 0 до кількості стовпців -1 через змінну і
            {
                dataGridView1.Rows.Add();//додаємо рядок
            }
            
        }

        public void saveGrid(string fn)
        { //функція збереження сітки з даними в файл
          //fn – ім’я файлу
          //в файлі розділювачом клітинок буде виступати "|", тобто такий рядок
          // клітинка 1       клітинка 2      клітинка 3
          //в файлі буде записано, як "клітинка 1|клітинка 2|клітинка 3"
            FileInfo f = new FileInfo(fn);//ініціалізуємо об’єкт файлу f

            StreamWriter w = new StreamWriter(f.Create());//створюємо поток для запису в файл w, якщо немає - файл створиться, якщо є – перезапишеться
            string l;//буде використовуватись для формування рядка з подальшим записом в файл
            for (int rc = 0; rc < dataGridView1.Rows.Count - 1; rc++)//перебираємо від 0 до кількості рядків -2 через rc
            {
                l = "";//очищуємо рядок
                for (int cc = 0; cc <= dataGridView1.Columns.Count - 1; cc++) //перебираємо від 0 до кількості стовпців -1 через сс
                {
                    l += dataGridView1.Rows[rc].Cells[cc].Value + "|";//додаємо до рядка значення клітинки і символ "|"
                }
                l.Substring(0, l.Length - 1);//підтираємо останній символ "|" - він лишній
                w.WriteLine(l);//пишемо рядок в файл
            }
            w.Close(); //закриваємо файл
        }
        public void openGrid(string fn)
        {//відкриваємо файл fn та відображаємо його вміст на сітці
            FileInfo f = new FileInfo(fn);//ініціалізуємо об’єкт файлу f
            StreamReader r = new StreamReader(f.OpenRead());//відкриваємо поток r для читання даних з файлу
            string l;//буде використовуватись для формування рядка з подальшим записом в файл
            dataGridView1.Rows.Clear();//очищуємо рядки
            dataGridView1.Columns.Clear();//очищуємо стовпці
            while (!r.EndOfStream)
            {//цикл працює доки ми не досягли кінця файлу
                l = r.ReadLine();//зчитуємо наступний рядок з файлу
                String[] cells = l.Split('|');//розділяємо підрядки відокремлені '|' в масив типу String
                if (dataGridView1.Columns.Count < cells.Length - 1)//якщо кількість стовпців сітки менша за кількість елементів
                                                                   //зчитаних із файлу, тоді в  нас порожня сітка, і ми, мусимо, додати потрібну кількість стовпців
                    for (int i = 0; i < cells.Length - 1; i++)//перебираємо від 0 до кількості елементів зчитаних з файлу
                        dataGridView1.Columns.Add(i.ToString(), i.ToString());//додаємо наступний стовпець
                dataGridView1.Rows.Add(cells);//додаємо зчитаний рядок до сітки
            }
        }

        public void gridFind(string txt, bool c)//пошук по клітинкам сітки
                                                //с - чутливість до реєстру
                                                //txt - текст для пошуку
        {
            string ct;//змінна в яку, для  зручності, буде копіюватися текст клітинки
                      //так як процедура всі знайдені клітинки (якщо є) відображає вибраними
                      //то потрібно зняти перед цим клітинку (клітинки) які вибрав користувач
            foreach (DataGridViewCell cl in dataGridView1.SelectedCells)
            { //якщо є вибрані клітинки на сітці
                cl.Selected = false;//помічаємо їх як не вибрані
            }
            for (int rc = 0; rc <= dataGridView1.Rows.Count - 1; rc++)//перебираємо від 0 до кількості рядків -1 через rc
                for (int cc = 0; cc <= dataGridView1.Columns.Count - 1; cc++)//перебираємо від 0 до кількості стовпців -1 через сс
                {
                    if (!c)//якщо пошук не чутливий до реєстру
                    {
                        ct = dataGridView1.Rows[rc].Cells[cc].Value + "";  //беремо значення з поточної клітинки
                        if (txt.ToUpper() == ct.ToUpper())//перевіряємо із шуканим значенням у верхньому реєстрі
                            dataGridView1.Rows[rc].Cells[cc].Selected = true;//якщо значення співпадають виділяємо клітинку
                    }
                    else//пошук чутливий до реєстру
                    {
                        if (txt == dataGridView1.Rows[rc].Cells[cc].Value + "")//порівнюємо значення
                            dataGridView1.Rows[rc].Cells[cc].Selected = true;//якщо значення співпадають виділяємо клітинку
                    }
                }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)//обробка елементу меню новий
        {
            Form2 f2 = new Form2(x, y, this);//створюємо форму, яка запитує кількість стовпців та рядків
                                             //x - кількість стовпців, y - кількість рядків, this - посилання на головну форму
            f2.ShowDialog();//показуємо вікно модально
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)//обробка елементу меню зберегти
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)//якщо користувач вибрав ім’я файлу
            {
                saveGrid(saveFileDialog1.FileName);//зберігаємо файл
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)//обробка елементу меню відкрити
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)//якщо користувач вибрав файл і натиснув ок
                openGrid(openFileDialog1.FileName);//відкриваємо файл
        }
        private void addColumnToolStripMenuItem_Click(object sender, EventArgs e)//обробка елементу додати стовпець
        {
            //створюємо новий стовпець текстового типу, одразу передаємо значення параметрів нового стовпця
            DataGridViewColumn col = new DataGridViewColumn(new DataGridViewTextBoxCell()) { Name = "col", HeaderText = "col" };
            //col.Name - назва стовпця
            //col.HeaderText - заголовок стовпця
            dataGridView1.Columns.Insert(dataGridView1.CurrentCell.ColumnIndex, col);//додаємо новий стовпець, перед активним
        }
        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)//елемент меню додати рядок
        {
            dataGridView1.Rows.Insert(dataGridView1.CurrentCell.RowIndex, new String[] { });//додаємо новий рядок перед активним
        }
        private void removeColumnToolStripMenuItem_Click(object sender, EventArgs e)//елемент меню видалити стовпець
        {
            dataGridView1.Columns.RemoveAt(dataGridView1.CurrentCell.ColumnIndex);//видаляє активний стовпець
        }
        private void removeRowToolStripMenuItem_Click(object sender, EventArgs e)//елемент меню видалити рядок
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);//видаляє активний рядок
        }
        private void boldToolStripMenuItem_Click(object sender, EventArgs e)//елемент меню жирний
        {
            try//пробуємо змінити жирність шрифту клітинки
            {
                if (dataGridView1.CurrentCell.Style.Font.Bold)//якщо клітинка вже жирна
                                                              //створюємо новий екземпляр шрифту на базі поточного але нежирний
                    dataGridView1.CurrentCell.Style.Font = new Font(dataGridView1.CurrentCell.Style.Font, dataGridView1.CurrentCell.Style.Font.Style & ~FontStyle.Bold);

                //якщо шрифт не жирний створюємо новий екземпляр шрифту + жирний
                else dataGridView1.CurrentCell.Style.Font = new Font(dataGridView1.CurrentCell.Style.Font, dataGridView1.CurrentCell.Style.Font.Style | FontStyle.Bold);
            }
            catch//якщо трапилася помилка, тобто у клітинці ще не створений об’єкт шрифт
            {
                //створюємо його на базі стандартного + жирний
                dataGridView1.CurrentCell.Style.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Bold);
            }
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)//елемент меню курсив
        {
            try//пробуємо змінити нахиленість шрифту клітинки
            {
                if (dataGridView1.CurrentCell.Style.Font.Italic)//якщо клітинка вже курсивна
                                                                //створюємо новий екземпляр шрифту на базі поточного але не курсивний
                    dataGridView1.CurrentCell.Style.Font = new Font(dataGridView1.CurrentCell.Style.Font, dataGridView1.CurrentCell.Style.Font.Style & ~FontStyle.Italic);
                //якщо шрифт не курсивний створюємо новий екземпляр шрифту + курсив
                else dataGridView1.CurrentCell.Style.Font = new Font(dataGridView1.CurrentCell.Style.Font, dataGridView1.CurrentCell.Style.Font.Style | FontStyle.Italic);
            }
            catch//якщо трапилася помилка, тобто у клітинці ще не створений об’єкт шрифт
            {
                //створюємо його на базі стандартного + курсив
                dataGridView1.CurrentCell.Style.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Italic);
            }
        }
        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)//елемент меню підкреслений
        {
            try//пробуємо змінити підкресленість шрифту клітинки
            {
                if (dataGridView1.CurrentCell.Style.Font.Italic)//якщо клітинка вже підкреслена
                                                                //створюємо новий екземпляр шрифту на базі поточного але не підкреслений
                    dataGridView1.CurrentCell.Style.Font = new Font(dataGridView1.CurrentCell.Style.Font, dataGridView1.CurrentCell.Style.Font.Style & ~FontStyle.Underline);
                //якщо шрифт не підкреслений створюємо новий екземпляр шрифту + підкреслений
                else dataGridView1.CurrentCell.Style.Font = new Font(dataGridView1.CurrentCell.Style.Font, dataGridView1.CurrentCell.Style.Font.Style | FontStyle.Underline);
            }
            catch//якщо трапилася помилка, тобто у клітинці ще не створений об’єкт шрифт
            {
                //створюємо його на базі стандартного + підкреслений
                dataGridView1.CurrentCell.Style.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Underline);
            }
        }
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)//елемент меню шрифт
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)//якщо у вікні був вибраний шрифт і натиснута ок
                dataGridView1.CurrentCell.Style.Font = fontDialog1.Font;//змінюємо шрифт клітинки на шрифт обраний у формі
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)//елемент меню знайти
        {
            Form3 f3 = new Form3(this);//створюємо форму пошуку, як аргумент передаємо посилання на головну форму
            f3.ShowDialog();//показуємо форму модально
        }
        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)//елемент меню замінити
        {
            Form4 f4 = new Form4(this, dataGridView1);//створюємо вікно пошуку та заміни
                                                      //передаємо аргументами посилання на головну форму, та посилання на сітку, яка відображає дані
            f4.ShowDialog();//показуємо вікно модально
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(this);
            f5.ShowDialog();
        }
        private bool UpdateInForm = true;
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (UpdateInForm)
            {
                // показати запрошення
                DialogResult result = MessageBox.Show("Зберегти зміни?", "Внимание", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        saveGrid(saveFileDialog1.FileName); // збереження
                    }
                    else
                    {
                        e.Cancel = true; 
                    }
                }
                else if (result == DialogResult.No)
                {
                    // Пользователь не хочет сохранять изменения, форма будет закрыта
                }
                else
                {
                    e.Cancel = true; // відмінна закрита форми
                }
            }
        }


    }

}
