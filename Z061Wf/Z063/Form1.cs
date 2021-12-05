using System;
using System.Text;
using System.Windows.Forms;

namespace Z063
{
    public partial class Form1 : Form
    {
        int n;
        int[,] arr;
        Random r = new Random();
        StringBuilder labelTwo = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }
        void Main()
        {
            if (Int32.TryParse(textBox2.Text, out n) && n>0)
            {
                labelTwo.Clear();
                arr = new int[n,n];
                for (int i = 0; i < n; i++)
                {
                    labelTwo.Append("\n");
                    for (int j = 0; j < n; j++)
                    {
                        arr[i, j] = r.Next(-10, 10);
                        labelTwo.Append($"{arr[i, j]}  ");
                    }
                }
                label2.Text = labelTwo.ToString();
            }
            else
            {
                MessageBox.Show("Размер матрицы должен определяться положительным целочисленным значением");
            }
                
        }
        void postMain()
        {
            labelTwo.Clear();
            for (int i = 0; i < n; i++)
            {
                labelTwo.Append("\n");
                if ((i+1) % 2 == 1)
                {
                    for (int j = 0; j < n; j++)
                    {
                        labelTwo.Append($"{arr[i, j]}  ");
                    }
                }
                else//if ((i + 1) % 2 == 0)
                {
                    for (int j = n-1; j >= 0; j--)
                    {
                        labelTwo.Append($"{arr[i, j]}  ");
                    }
                }
            }
            label2.Text = labelTwo.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            postMain();
        }
    }
}
