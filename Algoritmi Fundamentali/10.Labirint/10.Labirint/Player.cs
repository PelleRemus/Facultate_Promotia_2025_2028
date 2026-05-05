namespace _10.Labirint
{
    public static class Player
    {
        // Pozitia curenta a jucatorului si pozitia destinatiei
        public static Point position, destinationPosition;
        public static Image image = Image.FromFile("../../../Resources/player.png");
        public static Form1 form;
        public static PictureBox destination; // Picturebox-ul care reprezinta destinatia jucatorului
        // Calea reprezentata prin mai multe puncte, pe care trebuie sa o faca jucatorul pentru a ajunge la destinatie
        public static List<Point> path;

        public static void Init(Form1 f)
        {
            form = f;
            path = new List<Point>();
            // Apelam metoda pentru a adauga imaginea pe pozitia curenta a jucatorului (pozitia 0, 0)
            ChangePosition(position);
        }

        public static void ChangePosition(Point newPosition)
        {
            // Intai, stergem imaginea de pe pozitia curenta
            form.display[position.Y, position.X].pictureBox.Image = null;
            // Apoi o adaugam pe noua pozitie
            form.display[newPosition.Y, newPosition.X].pictureBox.Image = image;
            position = newPosition;
        }
        public static void ChangeDestination(MapTile newDestination)
        {
            // Intai stergem culoarea aurie de fundal a destinatiei curente
            if (destination != null)
                destination.BackColor = Color.ForestGreen;

            // Si apoi o adaugam la destinatia noua
            newDestination.pictureBox.BackColor = Color.Gold;
            destinationPosition = new Point(newDestination.column, newDestination.line);
            destination = newDestination.pictureBox;

            // Reinitializam matricea pentru a incepe din nou de la 0
            // ca apoi sa putem apela din nou algoritmul lui Lee si acesta sa functioneze
            form.InitializeMatrixWithWalls();
            FindPathLee();
        }

        public static void GoToDestination()
        {
            // Daca nu avem niciun punct la care trebuie sa mergem, inseamna ca am ajuns la destinatie
            if (path.Count == 0)
                return;
            // luam urmatorul punct din lista, il stergem din lista, si schimbam pozitia jucatorului la acel punct
            Point nextPosition = path[0];
            path.RemoveAt(0);
            ChangePosition(nextPosition);
        }

        public static void FindPathLee()
        {

        }
    }
}
