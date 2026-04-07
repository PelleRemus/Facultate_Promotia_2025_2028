namespace AutomateFredkin
{
    public partial class Form1 : Form
    {
        int n = 25, length, nrColors = 1;
        int[,] matrix;

        Bitmap bitmap; // Bitmap este o imagine pe care o putem modifica folosind un graphics
        Graphics graphics; // Graphics are o multime de metode pentru "desenare" pe un obiect

        public Form1()
        {
            InitializeComponent();
            matrix = new int[n, n];
            length = pictureBox1.Width / n;

            // Cream starea initiala a matricei
            matrix[n / 2, n / 2] = 1;

            AfisareMatrice();
        }

        // Urmatorul pas
        private void button1_Click(object sender, EventArgs e)
        {
            int[,] newMatrix = new int[n, n]; // Cream o matrice noua pentru a stoca rezultatul pasului curent
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (i > 0)
                        newMatrix[i, j] += matrix[i - 1, j]; // Adaugam valoarea de deasupra
                    if (i < n - 1)
                        newMatrix[i, j] += matrix[i + 1, j]; // Adaugam valoarea de dedesubt
                    if (j > 0)
                        newMatrix[i, j] += matrix[i, j - 1]; // Adaugam valoarea din stanga
                    if (j < n - 1)
                        newMatrix[i, j] += matrix[i, j + 1]; // Adaugam valoarea din dreapta

                    //if (count != 0)
                    //    matrix[i, j] = matrix[i, j] / count;

                    //if (count != 0)
                    //    matrix[i, j] = matrix[i, j] % count;

                    newMatrix[i, j] = newMatrix[i, j] % (nrColors + 1);
                }
            matrix = newMatrix;
            AfisareMatrice();
        }

        void AfisareMatrice()
        {
            // De fiecare data cand trecem la pasul urmator, vrem sa generam o imagine noua
            // de dimensiunea picturebox-ului, pentru ca acesta o va afisa
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap); // Spunem ca graphics va face modificari in acest bitmap

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        // Daca elementul nu e 0, il afisam ca un patratel
                        graphics.FillRectangle(Brushes.Red, j * length, i * length, length, length);
                    }
                }

            // Afisam imaginea nou creata in picturebox
            pictureBox1.Image = bitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
