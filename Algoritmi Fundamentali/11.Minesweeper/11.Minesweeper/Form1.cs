namespace _11.Minesweeper
{
    public partial class Form1 : Form
    {
        public static int n, m, size = 50, mines;
        public static MapButton[,] matrix;

        public Form1()
        {
            InitializeComponent();
            n = pictureBox1.Height / size;
            m = pictureBox1.Width / size;
            matrix = new MapButton[n, m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(size, size);
                    button.Location = new Point(j * size, i * size);
                    button.Font = new Font("Arial", size / 2, FontStyle.Bold);
                    button.BackColor = Color.LightGray;
                    button.Enabled = false;
                    pictureBox1.Controls.Add(button);
                    matrix[i, j] = new MapButton(i, j, button);
                }
        }

        public static void GameOver()
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j].Value == -1)
                    {
                        matrix[i, j].Button.BackColor = Color.White;
                        matrix[i, j].Button.Text = "X";
                    }

                    if (matrix[i, j].IsOpen) continue;
                    matrix[i, j].Button.Enabled = false;
                }
        }

        private static bool CheckIfYouWon()
        {
            int flagged = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j].IsFlagged)
                    {
                        flagged++;
                        if (matrix[i, j].Value != -1)
                            return false;
                    }
                }
            return flagged == mines;
        }

        public static void YouWonMessage()
        {
            if (CheckIfYouWon())
            {
                GameOver();
                MessageBox.Show("Ai Castigat!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Stergem continutul curent al butoanelor
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j].Value = 0;
                    matrix[i, j].IsOpen = false;
                    matrix[i, j].Button.Text = "";
                    matrix[i, j].Button.BackColor = Color.LightGray;
                }

            // Vrem sa generam minele
            mines = n * m / 10;
            for (int k = 0; k < mines; k++)
            {
                int i, j;
                do
                {
                    i = Random.Shared.Next(n);
                    j = Random.Shared.Next(m);
                } while (matrix[i, j].Value == -1);

                matrix[i, j].Value = -1;
            }

            // Generam numerele care dau indicii despre numarul de mine din jur
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j].Button.Enabled = true;
                    if (matrix[i, j].Value == -1)
                    {
                        matrix[i, j].Button.ForeColor = Color.Black;
                        continue;
                    }

                    int suma = 0;
                    for (int k = i - 1; k <= i + 1; k++)
                        for (int l = j - 1; l <= j + 1; l++)
                        {
                            if (k >= 0 && k < n && l >= 0 && l < m && matrix[k, l].Value == -1)
                            {
                                suma++;
                            }
                        }

                    matrix[i, j].Value = suma;
                }
        }
    }
}
