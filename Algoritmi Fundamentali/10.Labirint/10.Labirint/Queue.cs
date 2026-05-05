namespace _10.Labirint
{
    public class Queue
    {
        public MapTile[] v;
        public int length;

        // Coada are proprietatile ca se adauga la final si se stearga de la inceput
        public Queue()
        {
            length = 0;
            v = [];
        }

        public void Add(MapTile tile)
        {
            length++;
            MapTile[] newV = new MapTile[length];
            for (int i = 0; i < length - 1; i++)
            {
                newV[i] = v[i];
            }
            newV[length - 1] = tile;
            v = newV;
        }

        public MapTile Remove()
        {
            length--;
            MapTile[] newV = new MapTile[length];
            for (int i = 0; i < length; i++)
            {
                newV[i] = v[i + 1];
            }
            MapTile toReturn = v[0];
            v = newV;
            return toReturn;
        }
    }
}
