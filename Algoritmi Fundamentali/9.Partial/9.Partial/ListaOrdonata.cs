namespace _9.Partial
{
    public class ListaOrdonata
    {
        public int[] array;
        public int n;

        // Pentru a simula o lista ordonata, incepem cu un vector gol
        public ListaOrdonata()
        {
            n = 0;
            array = new int[n];
        }

        // Pentru a fi ordonata, functia de adaugare trebuie sa adauge direct
        // la pozitia potrivita in vector pentru ca acesta sa ramana ordonat
        public void AdaugareOrdonata(int value)
        {
            int newN = n + 1;
            int[] newArray = new int[newN]; // noul vector are dimensiunea n, care tocmai a crscut

            // Gasim pozitia pe care are trebui sa fie adaugat noul value, pentru a pastra ordinea
            int index = 0; // indexul pentru noul value
            while (index < n && array[index] < value)
            {
                index++;
            }

            // Copiem toate valorile pana la index in vectorul nou
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            // Punem noul value pe pozitia index
            newArray[index] = value;

            // Copiem restul valorilor cu pozitii cu 1 mai la dreapta
            for (int i = index + 1; i < newN; i++)
            {
                newArray[i] = array[i - 1];
            }

            array = newArray;
            n = newN;
        }
    }
}
