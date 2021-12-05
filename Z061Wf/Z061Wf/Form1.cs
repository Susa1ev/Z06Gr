using System;
using System.Windows.Forms;

namespace Z061Wf
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int n;
        int[] arr;
        public Form1()
        {
            InitializeComponent();
        }
        void Main()
        {
            label2.Text = string.Empty;
            label3.Text = string.Empty;
            if (Int32.TryParse(textBox1.Text, out n) && n>0)
            {
                arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = rnd.Next(-10, 10);
                    label2.Text += arr[i] + " ";
                    if(arr[i]%2==1||arr[i]%2 == -1)
                    {
                        label3.Text += (i+1) + " ";
                    }
                }
            }
            else
            {
                MessageBox.Show("Размерность массива должна быть положительным целым числом");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }
    }
}
