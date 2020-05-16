using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzleGame
{
    public partial class Form1 : Form
    {
        private Button[,] matrix = new Button[5, 5];
        private int blankX = 2;
        private int blankY = 2;
        private int buttonDimension = 90;
        public Form1()
        {
            InitializeComponent();
            initializeButtons();
        }

        public void initializeButtons()
        {         
            int number = 1;
            int j=0, i = 0;
            for (j=0; j<matrix.GetLength(0); j++)
            {
                for (i = 0; i < matrix.GetLength(1); i++)
                {
                    matrix[i, j] = new Button();
                    matrix[i, j].Text = number.ToString();
                    matrix[i, j].Location = new System.Drawing.Point(buttonDimension*i, buttonDimension*j);
                    matrix[i, j].Name = i.ToString() + j.ToString();
                    matrix[i, j].Size = new System.Drawing.Size(buttonDimension, buttonDimension);
                    matrix[i, j].Click += new System.EventHandler(this.buttonCiked);
                    this.Controls.Add(matrix[i,j]);
                    number++;
                }
            }
            this.ClientSize = new System.Drawing.Size(buttonDimension*i, buttonDimension*j);
            matrix[blankX, blankY].Text = "";
        }

        private void buttonCiked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int x = Convert.ToInt32(b.Name[0].ToString());
            int y = Convert.ToInt32(b.Name[1].ToString());
            int differenceX = Math.Abs(x - blankX);
            int differenceY = Math.Abs(y - blankY);
            int totalDifference = differenceX + differenceY;
            if (totalDifference == 1)
            {
                string tmp = matrix[x, y].Text;
                matrix[x, y].Text = matrix[blankX, blankY].Text;
                matrix[blankX, blankY].Text = tmp;
                blankX = x;
                blankY = y;
            }
        }
    }
}
