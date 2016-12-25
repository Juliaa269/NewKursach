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
            this.planner = new Planner();
            this.label8.Text = "" + Planner.intensivity;
        }

        // UI
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

        private Planner planner;

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
            planner.tick();
            legacy();
            displayCurrentTick();
            displayCPUQueue();
        }

        private void displayCPUQueue()
        {
            listBox1.Items.Clear();
            foreach (Process process in planner.cpuQueue())
            {
                listBox1.Items.Add(process.name);
            }

        }
      
        private void displayCurrentTick()
        {
            this.label6.Text = "" + planner.getCurrentTick();

        }

        private void legacy()
        {
            int numb = rnd.Next(100);

            listBox2.Items.Add(numb);
            listBox3.Items.Add(numb);
            listBox4.Items.Add(numb);

        }

        private void STARTBTN_Click(object sender, EventArgs e) // кнопка СТАРТ
        {
            this.timer1.Start();
            CLEARBTN.Enabled = false;
            STARTBTN.Enabled = false;
            STOPBTN.Enabled = true;
            EXITBTN.Enabled = false;
        }

        private void STOPBTN_Click(object sender, EventArgs e) // кнопка СТОП
        {
            this.timer1.Stop();
            CLEARBTN.Enabled = true;
            STARTBTN.Enabled = true;
            STOPBTN.Enabled = false;
            EXITBTN.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e) // заглавная форма
        {
            CLEARBTN.Enabled = false;
            STARTBTN.Enabled = true;
            STOPBTN.Enabled = false;
            EXITBTN.Enabled = true;
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

            planner.clear();
            displayCurrentTick();

            STARTBTN.Enabled = EXITBTN.Enabled = true;
            CLEARBTN.Enabled = STOPBTN.Enabled = false;

        }

        private void EXITBTN_Click(object sender, EventArgs e) // кнопка ВЫХОД
        {
            Application.Exit();
        }

        private void current_tick_Click(object sender, EventArgs e)
        {

        }

        private void InensivityBTN_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
