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
        private Random rnd = new Random();
        private List<int> listBox1queue = new List<int>(); // очередь ЦП
        private List<int> listBox2queue = new List<int>(); // очередь Видео Карты
        private List<int> listBox3queue = new List<int>(); // очередь Жесткого Диска
        private List<int> listBox4queue = new List<int>(); // очередь Звуковой Карты

        private List<int> groupBoxCPU = new List<int>(); // инфо о ЦП
        private List<int> groupBoxVC = new List<int>(); // инфо о Видео Карте
        private List<int> groupBoxHDD = new List<int>(); // инфо о Жестком Диске
        private List<int> groupBoxSC = new List<int>(); // инфо о Звуковой Карте
        private List<int> groupBoxST = new List<int>(); // Статистика
        private List<int> groupBoxMm = new List<int>(); // инфо о памяти

        private Label tickLabel;

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
            //processor.tick();
            legacy();
            displayCurrentTick();
        }

        private void displayCurrentTick() {
            this.label6.Text = "2";
        }

        private void legacy()
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

        private void button2_Click(object sender, EventArgs e) // кнопка СТАРТ
        {
            this.timer1.Start();
            CLEARBTN.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e) // кнопка СТОП
        {
            this.timer1.Stop();
            CLEARBTN.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e) // заглавная форма
        {
            CLEARBTN.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
        }

        private void onClearPressed(object sender, EventArgs e) // кнопка ОЧИСТИТЬ 
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
            CLEARBTN.Enabled = button3.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e) // кнопка ВЫХОД
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
