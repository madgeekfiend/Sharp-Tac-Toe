using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharp_Tac_Toe
{
    public partial class frmGameBoard : Form
    {
        // The one and only game maybe make it a Singelton? nah would probably be better not too
        private Game game = new Game();

        public frmGameBoard()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g;

            // Draw the grid
            g = e.Graphics;
            Pen linePen = new Pen(Color.Black);
            linePen.Width = 5;

            // Start drawing the line these are the vertical lines
            g.DrawLine(linePen, new Point(155, 13), new Point(155, 406));
            g.DrawLine(linePen, new Point(308, 13), new Point(308, 406));

            // Draw the horizontal lines
            g.DrawLine(linePen, new Point(13, 140), new Point(450, 140));
            g.DrawLine(linePen, new Point(13, 278), new Point(450, 278));
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int proposedMove = -1;
            btn.Enabled = false;
            try
            {
                switch (btn.Name)
                {
                    case "btn0":
                        proposedMove = 0;         
                        break;
                    case "btn1":
                        proposedMove = 1;
                        break;
                    case "btn2":
                        proposedMove = 2;
                        break;
                    case "btn3":
                        proposedMove = 3;
                        break;
                    case "btn4":
                        proposedMove = 4;
                        break;
                    case "btn5":
                        proposedMove = 5;
                        break;
                    case "btn6":
                        proposedMove = 6;
                        break;
                    case "btn7":
                        proposedMove = 7;
                        break;
                    case "btn8":
                        proposedMove = 8;
                        break;
                    default:
                        return;
                }
                game.PlaceMark(proposedMove, Grid.GRID_TYPE.X);
                btn.Text = "X";
                // Determine if the player has won
                if (game.hasWon(Grid.GRID_TYPE.X))
                {
                    MessageBox.Show("Congratulations! Player 1 has won the game!!!");
                    return;
                }

                // Let's see if we can continue
                if (!game.HasMoreMoves())
                {
                    MessageBox.Show("The Game is a tie. No more moves. Would you like to play again?");
                    return;
                }
                else
                {
                    // Computers turn
                    int computersmove = game.ComputerPlays();
                    game.PlaceMark(computersmove, Grid.GRID_TYPE.Y);
                    switch (computersmove)
                    {
                        case 0:
                            btn0.Text = "O";
                            btn0.Enabled = false;
                            break;
                        case 1:
                            btn1.Text = "O";
                            btn1.Enabled = false;
                            break;
                        case 2:
                            btn2.Text = "O";
                            btn2.Enabled = false;
                            break;
                        case 3:
                            btn3.Text = "O";
                            btn3.Enabled = false;
                            break;
                        case 4:
                            btn4.Text = "O";
                            btn4.Enabled = false;
                            break;
                        case 5:
                            btn5.Text = "O";
                            btn5.Enabled = false;
                            break;
                        case 6:
                            btn6.Text = "O";
                            btn6.Enabled = false;
                            break;
                        case 7:
                            btn7.Text = "O";
                            btn7.Enabled = false;
                            break;
                        case 8:
                            btn8.Text = "O";
                            btn8.Enabled = false;
                            break;
                        default:
                            break; // Should hopefully never get here ever
                    }

                    // See if the computer has won
                    if (game.hasWon(Grid.GRID_TYPE.Y))
                        MessageBox.Show("ARGH! The computer has won! SKYNET has grown more powerful!");
                }

                // Let's see if we can continue
                if ( !game.HasMoreMoves() )
                    MessageBox.Show("The Game is a tie. No more moves. Would you like to play again?");

                // Disable the button no more click events
                btn.Enabled = false;
            }
            catch (InvalidMoveException ex)
            {
                MessageBox.Show("That is an invalid move. Please try another move.");
            }
        }


    }
}
