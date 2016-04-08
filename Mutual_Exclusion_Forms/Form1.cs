using System;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mutual_Exclusion_Forms
{
    public partial class Form1 : Form
    {
        private string result_1, result_2;
        public Form1()
        {
            InitializeComponent();
            result_1 = " ";
            result_2 = " ";
        }
        private void start_Click(object sender, EventArgs e)
        {
            Mutual_Exclusion();
        }
        private void Mutual_Exclusion ()
        {
            if (character.Text.Length > 1)
            {
                MessageBox.Show("Введите только один символ!");
                return;
            }
            if (int.Parse(sign.Text) < 1 || int.Parse(sign.Text) > 3)
            {
                MessageBox.Show("Введите число от 1 до 3!");
                return;
            }
            switch (algorithm.SelectedIndex)
            {
                case 0:
                    Task.Factory.StartNew(() => { StrictAlternation(character.Text, int.Parse(sign.Text)); });
                    Task.WaitAll();
                    break;
                case 1:
                    Task.Factory.StartNew(() => { Petersons_Algorithm(character.Text, int.Parse(sign.Text)); });
                    Task.WaitAll();
                    break;
            }
        }
        #region Actions
        private string GetASCII(string str)
        {
            byte[] ascii = Encoding.ASCII.GetBytes(str);
            return ascii[0].ToString();
        }
        private string Signals(int count)
        {
            int i = 0;
            while (i < count)
            {
                Console.Beep();
                i++;
            }
            return count.ToString();
        }
        #endregion
        #region Strict_Alternation
        private void StrictAlternation(string str, int count)
        {
            int turn = 0;
            while (true)
            {
                while (turn == 0)
                {
                    result.Text = result_1;
                    Task_1(str);
                    turn = 1;
                    while (turn == 1)
                    {
                        result.Text = result_2;
                        Task_2(count);
                        turn = 0;
                    }
                }
            }
        }
        private void Task_1(string str)
        {
            proc1.BackColor = Color.Red;
            result_1 = GetASCII(str);
            Thread.Sleep(800);
            proc1.BackColor = Color.Green;
        }
        private void Task_2(int count)
        {
            proc2.BackColor = Color.Red;
            result_2 = Signals(count);
            Thread.Sleep(800);
            proc2.BackColor = Color.Green;
        }
        #endregion
        #region Petersons_Algorithm
        private bool[] processes = new bool[2]; // флаги двух процессов
        private int turn; // переменные, позволяющие избежать одновременного входа двух функций в критическую область
        private void EnterRegion(int thread)
        {
            int other = 1 - thread;
            processes[thread] = true;
            turn = thread;
            //while (turn == thread && processes[thread] == true);
        }
        private void LeaveRegion(int thread)
        {
            processes[thread] = false;
        }
        private void Petersons_Algorithm(string str, int count)
        {
            while (true)
            {
                result.Text = result_1;
                Task_P1(str);
                result.Text = result_2;
                Task_P2(count);
            }
        }
        private void Task_P1(string str)
        {
                EnterRegion(0);
                proc1.BackColor = Color.Red;
                result_1 = GetASCII(str);
                Thread.Sleep(800);
                proc1.BackColor = Color.Green;
                LeaveRegion(0);
        }
        private void Task_P2(int count)
        {
                EnterRegion(1);
                proc2.BackColor = Color.Red;
                result_2 = Signals(count);
                Thread.Sleep(500);
                proc2.BackColor = Color.Green;
                LeaveRegion(1);
        }
        #endregion
    }
}
