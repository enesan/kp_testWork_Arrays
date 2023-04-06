namespace Kontrosha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Sozdat_knopka_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int[] dim1arr = new int[rand.Next(1, 8)];
            int[,] dim2arr = new int[rand.Next(1, 8), rand.Next(1, 8)];
            int[][] stuparr = new int[rand.Next(1, 8)][];

            for (int i = 0; i < dim1arr.Length; i++)
            {
                dim1arr[i] = rand.Next(0, 21);
            }
            for(int i = 0; i < dim2arr.GetLength(0); i++)
                for(int j = 0; j < dim2arr.GetLength(1); j++)
                {
                    dim2arr[i, j] = rand.Next(0, 21);
                }            
            for (int i = 0; i < stuparr.GetLength(0); i++) stuparr[i] = new int[rand.Next(1, 8)];
            for (int i = 0; i < stuparr.GetLength(0); i++)
                for(int j = 0; j < stuparr[i].Length; j++)
                {
                    stuparr[i][j] = rand.Next(0, 21);
                }
            for(int j = 0; j < dim1arr.Length; j++)
                for (int i = 0; i < dim1arr.Length - 1; i++)
                {
                    if (dim1arr[i] > dim1arr[i + 1])
                    {
                        var temp = dim1arr[i];
                        dim1arr[i] = dim1arr[i + 1];
                        dim1arr[i + 1] = temp;
                    }
                }
            foreach (int i in dim1arr)
            {
                dim1MassivLabel.Text += $" {i}";
            }

            for (int i = 0; i < dim2arr.GetLength(0); i++)
            {
                int[] temp = new int[dim2arr.GetLength(1)];
                for (int j = 0; j < dim2arr.GetLength(1); j++)
                {
                    temp[j] = dim2arr[i, j];
                }                
                for(int k = 0; k < temp.Length; k++)
                    for (int l = 0;  l < temp.Length - 1; l++)
                    {
                        if (temp[l] > temp[l + 1])
                        {
                            var prokh = temp[l];
                            temp[l] = temp[l + 1];
                            temp[l + 1] = prokh;
                        }
                    }
                foreach (int j in temp)
                {
                    dim2MassivLabel.Text += $" {j}";
                }
                dim2MassivLabel.Text += "\n";
            }
            for(int i =0; i < stuparr.GetLength(0); i++)
            {
                for(int j = 0; j < stuparr[i].Length; j++)
                    for (int k = 0; k < stuparr[i].Length - 1; k++)
                    {
                        if (stuparr[i][k] > stuparr[i][k + 1])
                        {
                            var prokh = stuparr[i][k];
                            stuparr[i][k] = stuparr[i][k + 1];
                            stuparr[i][k + 1] = prokh;
                        }
                    }
            }
            
            
            for (int i = 0; i < stuparr.GetLength(0); i++)
            {
                foreach (int j in stuparr[i])
                {
                    stupMassivLabel.Text += $" {j}";
                }
                stupMassivLabel.Text += "\n";
            }
        }
    }
}