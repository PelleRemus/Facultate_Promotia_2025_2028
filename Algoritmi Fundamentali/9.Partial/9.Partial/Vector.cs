namespace _9.Partial
{
    public class Vector
    {
        public int[] array;
        public int min, max;
        public Vector(int[] array, int min, int max)
        {
            this.array = array;
            this.min = min;
            this.max = max;
        }

        public Vector PowerOfArray()
        {
            // Cream vectorul de frecventa pentru vectorul original
            int[] frecventa = new int[max - min + 1];

            for (int i = 0; i < array.Length; i++)
            {
                frecventa[array[i] - min]++;
            }

            // Counting sort: folosim un alt vector de frecventa pentru a sorta elementele
            // din vectorul initial de frecventa
            // 1. Gasim maximul din vectorul de frecventa
            int frecMax = 0;
            for (int i = 0; i < frecventa.Length; i++)
            {
                if (frecventa[i] > frecMax)
                {
                    frecMax = frecventa[i];
                }
            }

            // 2. Cream al doilea vector de frecventa
            int[] frecventa2 = new int[frecMax + 1];
            int count = 0;
            for (int i = 0; i < frecventa.Length; i++)
            {
                if (frecventa[i] != 0)
                {
                    frecventa2[frecventa[i]]++;
                    count++;
                }
            }

            // 3. Parcurgem frecventa2, si stim de cate ori apare fiecare numar (dupa indice)
            // Si putem adauga indicele respectiv de atatea ori in vectorul putere rezultat
            int[] putere = new int[count];
            int index = 0;
            for (int i = frecventa2.Length - 1; i > 0; i--)
            {
                while (frecventa2[i] > 0)
                {
                    putere[index] = i;
                    index++;
                    frecventa2[i]--;
                }
            }

            return new Vector(putere, 0, 0);
        }

        public override string ToString()
        {
            string s = String.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                s = $"{s}{array[i]} ";
            }
            return s;
        }
    }
}
