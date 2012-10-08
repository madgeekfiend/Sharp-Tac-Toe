using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_Tac_Toe
{
    /// <summary>
    /// 
    /// Keeps track of the game. A game consists of a grid and 2 players. For now the computer will be player 2 and player 1 will always have the
    /// first move.
    /// 
    /// </summary>
    class Game
    {
        private Grid grid = new Grid();
        private Player[] players = new Player[2];
        
        public Game()
        {
            // Always 1 grid initiliaze to start
            grid.reset();
        }

        public void PlaceMark(int spot, Grid.GRID_TYPE type)
        {
            try
            {
                grid.PlaceMark(spot, type);
            }
            catch (InvalidMoveException e)
            {
                throw e;
            }
        }

        public int ComputerPlays()
        {
            // The computer will be Y since the AI code is part of game that logic will go here
            // Just do a random number for now
            Random rand = new Random();
            int move = rand.Next(0, 8);
            while(!grid.canMove(move))
            {
                move = rand.Next(0,8);
            }

            return move;
        }

        public bool HasMoreMoves()
        {
            return !grid.isGridFull();
        }

        /// <summary>
        /// Determine if the player won.
        /// </summary>
        /// <param name="player">What player to check for a win</param>
        /// <returns>True if the player has won and false if he player hasn't won</returns>
        public bool hasWon(Grid.GRID_TYPE player)
        {
            // Let's see if someone has won only 8 win conditions
            // Horizontal
            if ( grid.GetInPosition(0) == (int)player && grid.GetInPosition(1) == (int)player && grid.GetInPosition(2) == (int)player)
                return true;
            if (grid.GetInPosition(3) == (int)player && grid.GetInPosition(4) == (int)player && grid.GetInPosition(5) == (int)player)
                return true;
            if (grid.GetInPosition(6) == (int)player && grid.GetInPosition(7) == (int)player && grid.GetInPosition(8) == (int)player)
                return true;
            // Vertical
            if (grid.GetInPosition(0) == (int)player && grid.GetInPosition(3) == (int)player && grid.GetInPosition(6) == (int)player)
                return true;
            if (grid.GetInPosition(1) == (int)player && grid.GetInPosition(4) == (int)player && grid.GetInPosition(7) == (int)player)
                return true;
            if (grid.GetInPosition(2) == (int)player && grid.GetInPosition(5) == (int)player && grid.GetInPosition(8) == (int)player)
                return true;
            // Diagnols
            if (grid.GetInPosition(0) == (int)player && grid.GetInPosition(4) == (int)player && grid.GetInPosition(8) == (int)player)
                return true;
            if (grid.GetInPosition(2) == (int)player && grid.GetInPosition(4) == (int)player && grid.GetInPosition(6) == (int)player)
                return true;

            return false;
        }
    }
}
