namespace _2.Poker
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;

        public Form1()
        {
            InitializeComponent();
            Instance = this;
            pictureBox1.BackgroundImage = Image.FromFile("../../../Images/BackCard.png");
            Engine.Initiaize();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;

            await Engine.DealAllCards();

            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Selectam cartile pentru Player1
            int index = 0;
            Card[] cards = new Card[]
            {
                Engine.cards[Engine.cardsOrder[index]],
                Engine.cards[Engine.cardsOrder[index + 1]],
                Engine.cards[Engine.cardsOrder[index + 2]],
                Engine.cards[Engine.cardsOrder[index + 3]],
                Engine.cards[Engine.cardsOrder[index + 4]],
            };

            // Calculam scorul pentru Player1
            int player1Score = HighCard(cards);

            // Selectam cartile pentru Player2
            index = 5;
            cards[0] = Engine.cards[Engine.cardsOrder[index]];
            cards[1] = Engine.cards[Engine.cardsOrder[index + 1]];
            cards[2] = Engine.cards[Engine.cardsOrder[index + 2]];
            cards[3] = Engine.cards[Engine.cardsOrder[index + 3]];
            cards[4] = Engine.cards[Engine.cardsOrder[index + 4]];

            // Calculam scorul pentru Player2
            int player2Score = HighCard(cards);

            // Verificam cine a castigat
            if (player1Score > player2Score)
                MessageBox.Show($"Player1: {player1Score}{Environment.NewLine}" +
                    $"Player2: {player2Score}", "Player1 has Won!");
            else
                MessageBox.Show($"Player1: {player1Score}{Environment.NewLine}" +
                    $"Player2: {player2Score}", "Player2 has Won!");
        }

        int HighCard(Card[] cards)
        {
            return -1;
        }

        public PictureBox CreatePictureBoxForNewCard()
        {
            PictureBox card = new PictureBox();
            card.Parent = this;
            card.BackgroundImage = pictureBox1.BackgroundImage;
            card.Location = pictureBox1.Location;
            card.Size = pictureBox1.Size;
            card.BackgroundImageLayout = pictureBox1.BackgroundImageLayout;

            card.BringToFront();
            return card;
        }
    }
}
