using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewKursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        List<int> listBox1queue = new List<int>(); // очередь ЦП
        List<int> listBox2queue = new List<int>(); // очередь Видео Карты
        List<int> listBox3queue = new List<int>(); // очередь Жесткого Диска
        List<int> listBox4queue = new List<int>(); // очередь Звуковой Карты
        
        List<int> groupBoxCPU = new List<int>(); // инфо о ЦП
        List<int> groupBoxVC = new List<int>(); // инфо о Видео Карте
        List<int> groupBoxHDD = new List<int>(); // инфо о Жестком Диске
        List<int> groupBoxSC = new List<int>(); // инфо о Звуковой Карте
        List<int> groupBoxST = new List<int>(); // Статистика
        List<int> groupBoxMm = new List<int>(); // инфо о памяти

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e) // таймер------ изменить
        {
            int numb = rnd.Next(100);
            listBox1queue.Add(numb);
            listBox1.Items.Add(numb);
            listBox2queue.Add(numb);
            listBox2.Items.Add(numb);
            listBox3queue.Add(numb);
            listBox3.Items.Add(numb);
            listBox4queue.Add(numb);
            listBox4.Items.Add(numb);
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // кнопка СТАРТ
        {
            this.timer1.Start();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e) // кнопка СТОП
        {
            this.timer1.Stop();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e) // заглавная форма
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e) // кнопка ОЧИСТИТЬ 
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();

            listBox1queue.Clear();
            listBox2queue.Clear();
            listBox3queue.Clear();
            listBox4queue.Clear();

            groupBoxCPU.Clear();
            groupBoxVC.Clear();
            groupBoxHDD.Clear();
            groupBoxSC.Clear();
            groupBoxST.Clear();
            groupBoxMm.Clear();

            button2.Enabled = button4.Enabled = true;
            button1.Enabled = button3.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e) // кнопка ВЫХОД
        {
            Application.Exit();
        }
    }
}
