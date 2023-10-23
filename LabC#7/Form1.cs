namespace LabC_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("В массиве R, содержащем 25 элементов, заменить значения отрицательных элементов квадратами значений, значения положительных увеличить на 7, а нулевые значения оставить без изменения. Вывести массив R");
        }
        int[] mas = new int[25];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 25; i++)
            {
                mas[i] = rand.Next(-100, 100);
                listBox1.Items.Add("Mas[" + i.ToString() + "] = " +
                    mas[i].ToString());
            }
        }
         
        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
                for(int i = 0; i < 25; i++)
            {
                if (mas[i] < 0)
                {
                    mas[i] = (int) Math.Pow(mas[i], 2);
                    listBox2.Items.Add("Mas[" + Convert.ToString(i) + "] = "
                        + mas[i].ToString());
                }
                else if (mas[i] > 0)
                {
                    mas[i] = mas[i] + 7;
                    listBox2.Items.Add("Mas[" + Convert.ToString(i) + "] = "
                        + mas[i].ToString());
                }
                else
                {
                    mas[i] = mas[i];
                    listBox2.Items.Add("Mas[" + Convert.ToString(i) + "] = "
                        + mas[i].ToString());
                }
            }
        }
    }
}