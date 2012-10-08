using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_Tac_Toe
{
    class Grid
    {
        public enum GRID_TYPE
        {
            EMPTY = 0,
            X = 1,
            Y = 2
        }
        // The grid is going to be 3x3 but make it a flat array of 9
        private int[] grid = new int[9];

        public Grid()
        {
            reset();
        }

        /// <summary>
        /// Reset the grid to all 0 values. A 1 = X and 2 = 0
        /// </summary>
        public void reset()
        {
            for (int x = 0; x < grid.Length; x++)
                grid[x] = (int)GRID_TYPE.EMPTY;
        }

        public void PlaceMark(int spot, GRID_TYPE type)
        {
            grid[spot] = (int)type;
        }

        public bool canMove(int spot)
        {
            return grid[spot] == 0;
        }

        public int GetInPosition(int pos)
        {
            return grid[pos];
        }

        public bool isGridFull()
        {
            foreach (int x in grid)
            {
                if (0 == x)
                    return false;
            }

            return true;
        }
    }
}
