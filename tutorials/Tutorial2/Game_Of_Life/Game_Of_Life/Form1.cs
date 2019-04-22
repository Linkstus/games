using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Of_Life
{
    public partial class Window : Form
    {
        private Random random = new Random();
        private int[,] grid;
        private int size = 10;
        private int rows;
        private int columns;

        public Window()
        {
            InitializeComponent();
        }
/*
 

void draw() {
  background(0);

  int[][] next = new int[cols][rows];

  // Compute next based on grid
  for (int i = 0; i < cols; i++) {
    for (int j = 0; j < rows; j++) {
      int state = grid[i][j];
      // Count live neighbors!
      int sum = 0;
      int neighbors = countNeighbors(grid, i, j);

      if (state == 0 && neighbors == 3) {
        next[i][j] = 1;
      } else if (state == 1 && (neighbors < 2 || neighbors > 3)) {
        next[i][j] = 0;
      } else {
        next[i][j] = state;
      }

    }
  }

  grid = next;



}


int countNeighbors(int [][]grid, int x, int y) {
  int sum = 0;
  for (int i = -1; i < 2; i++) {
    for (int j = -1; j < 2; j++) {
      int col = (x + i + cols) % cols;
      int row = (y + j + rows) % rows;
      sum += grid[col][row];
    }
  }
  sum -= grid[x][y];
  return sum;
}*/
        private void Grid_Paint(object sender, PaintEventArgs e)
        {
            gridSetup();
            drawShapes(e);

            
        }

        private void gridSetup()
        {
            rows = Grid.Height / size;
            columns = Grid.Width / size;

            grid = new int[rows, columns];

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    grid[i, j] = random.Next(0, 2);
                }
            }
        }

        private void drawShapes(PaintEventArgs e)
        {

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    int x = i * size;
                    int y = j * size;

                    if(grid[i, j] == 1)
                    {
                        e.Graphics.DrawRectangle(new Pen(Color.FromName("Black")), new Rectangle(x, y, size - 1, size - 1));
                    }
                }
            }


        }
    }
}
