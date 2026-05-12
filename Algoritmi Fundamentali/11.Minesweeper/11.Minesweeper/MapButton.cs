namespace _11.Minesweeper
{
    public class MapButton
    {
        public int Line { get; set; }
        public int Column { get; set; }
        public bool IsOpen { get; set; }
        public bool IsFlagged { get; set; }
        public int Value { get; set; }
        public Button Button { get; set; }

        public MapButton(int line, int column, Button button)
        {
            Line = line;
            Column = column;
            Button = button;
            IsOpen = false;
            IsFlagged = false;
            Value = 0;
            Button.MouseDown += Button_MouseClick;
        }

        public void Button_MouseClick(object? sender, MouseEventArgs e)
        {
            if (IsOpen) return;
            if (e.Button == MouseButtons.Right)
            {
                IsFlagged = !IsFlagged;
                Button.Text = IsFlagged ? "F" : "";
                Button.ForeColor = Color.Red;
                Form1.YouWonMessage();
                return;
            }
            if (IsFlagged) return;

            Open();
            if (Value == 0)
            {
                // Parcurgere in adancime, sus, stanga, jos, dreapta
                if (Line > 0) Form1.matrix[Line - 1, Column].Button_MouseClick(null, e);
                if (Column > 0) Form1.matrix[Line, Column - 1].Button_MouseClick(null, e);
                if (Line < Form1.n - 1) Form1.matrix[Line + 1, Column].Button_MouseClick(null, e);
                if (Column < Form1.m - 1) Form1.matrix[Line, Column + 1].Button_MouseClick(null, e);
            }
            Form1.YouWonMessage();
        }

        public void Open()
        {
            IsOpen = true;
            Button.BackColor = Color.White;
            Button.ForeColor = Value switch
            {
                1 => Color.Blue,
                2 => Color.Green,
                3 => Color.Red,
                4 => Color.DarkBlue,
                5 => Color.DarkRed,
                6 => Color.DarkCyan,
                8 => Color.Gray,
                7 or -1 or _ => Color.Black,
            };
            if (Value > 0)
                Button.Text = Value.ToString();
            if (Value == -1)
            {
                Form1.GameOver();
                Button.BackColor = Color.Red;
            }
        }
    }
}
