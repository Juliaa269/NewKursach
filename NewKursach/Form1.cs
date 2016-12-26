﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// TODO Вывести статистику выполнения процессов
// TODO Вывести текущий исполняемый процесс
namespace NewKursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.planner = new Planner();
            this.label8.Text = "" + Planner.intensivity; // задаем интенсивность
            //this.listBox1.Text = planner.statistic;
        }

        // UI
        private Random rnd = new Random();

        private List<int> groupBoxCPU = new List<int>(); // инфо о ЦП
        private List<int> groupBoxVC = new List<int>(); // инфо о Видео Карте
        private List<int> groupBoxHDD = new List<int>(); // инфо о Жестком Диске
        private List<int> groupBoxSC = new List<int>(); // инфо о Звуковой Карте
        private List<int> groupBoxST = new List<int>(); // Статистика
        private List<int> groupBoxMm = new List<int>(); // инфо о памяти

        private Planner planner;

        private void timer1_Tick(object sender, EventArgs e) // таймер------ изменить
        {
            planner.tick();
            legacy();
            displayCurrentTick();
            displayCPUQueue();
            displayCurrentCPU();
            displayStatistic();
        }

        private void displayCPUQueue() //отображает очередь к ЦП
        {
            cpuQueueListBox.Items.Clear();
            foreach (Process process in planner.cpuQueue())
            {
                cpuQueueListBox.Items.Add(process.name + " Burst Time:" + process.burstTime);
            }
        }
        private void displayStatistic() // отображает статистику
        {
            listBox5.Items.Clear();
            foreach (Process process in planner.staticusss())
            {
                listBox5.Items.Add(process.name + " Burst Time:" + process.burstTime + "[" + process.resource + "]");
            }
        }

        private void displayCurrentCPU() // отображает текущий ЦП
        {
            listBox1.Items.Clear();
            if (planner.current_CPU() != null)
            {
                listBox1.Items.Add(planner.current_CPU().name + " Burst Time:" + planner.current_CPU().burstTime);
            }
        }

        private void displayCurrentTick() // отображает текущий тик
        {
            this.label6.Text = "" + planner.getCurrentTick();

        }

        private void legacy()
        {
            videoCardQueueListBox.Items.Clear();
            foreach (Process process in planner.videoCardWaitingQueue()) {
                videoCardQueueListBox.Items.Add(process.name);
            }
            hardDriveDiskQueueListBox.Items.Clear();
            foreach (Process process in planner.hddWaitingQueue())
            {
                hardDriveDiskQueueListBox.Items.Add(process.name);
            }
            soundCardListBox.Items.Clear();
            foreach (Process process in planner.soundCardWaitingQueue())
            {
                soundCardListBox.Items.Add(process.name);
            }
            currentVideoCardProcess.Items.Clear();
            Process videoProcess = planner.currentVideoCardProcess();
            if (videoProcess != null) {
                currentVideoCardProcess.Items.Add(videoProcess.name + "");
            }

            currentSoundCardProcess.Items.Clear();
            Process soudProcess = planner.currentSoundCardProcess();
            if (soudProcess != null)
            {
                currentSoundCardProcess.Items.Add(soudProcess.name + "");
            }

            currentHddProcess.Items.Clear();
            Process hddProcess = planner.currentHddProcess();
            if (hddProcess != null)
            {
                currentHddProcess.Items.Add(hddProcess.name + "");
            }
       
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
            cpuQueueListBox.Items.Clear();
            videoCardQueueListBox.Items.Clear();
            hardDriveDiskQueueListBox.Items.Clear();
            soundCardListBox.Items.Clear();

            listBox1.Items.Clear();
            currentVideoCardProcess.Items.Clear();
            currentHddProcess.Items.Clear();
            currentSoundCardProcess.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();

            planner.clear();
            displayCurrentTick();

            STARTBTN.Enabled = EXITBTN.Enabled = true;
            CLEARBTN.Enabled = STOPBTN.Enabled = false;
        }

        private void EXITBTN_Click(object sender, EventArgs e) // кнопка ВЫХОД
        {
            Application.Exit();
        }
    }
}
