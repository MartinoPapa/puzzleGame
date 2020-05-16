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
        private Button[,] matrix = new Button[4, 4]; //must be square

        private int blankX;
        private int blankY;
        private int buttonDimension = 80;
        public Form1()
        {
            InitializeComponent();        
            initializeButtons();
        }

        public void initializeButtons()
        {         
            int index = 0;
            int j=0, i = 0;
            var elementList = insertElements().ToList();
            elementList.Add("");
            for (j=0; j<matrix.GetLength(1); j++)
            {
                for (i = 0; i < matrix.GetLength(0); i++)
                {
                    matrix[i, j] = new Button();
                    matrix[i, j].Text = elementList[index];
                    matrix[i, j].Location = new System.Drawing.Point(buttonDimension*i, buttonDimension*j);
                    matrix[i, j].Name = i.ToString() + j.ToString();
                    matrix[i, j].Size = new System.Drawing.Size(buttonDimension, buttonDimension);
                    matrix[i, j].Click += new System.EventHandler(this.buttonCiked);
                    matrix[i, j].Font = new Font(Font.FontFamily, 15);
                    this.Controls.Add(matrix[i,j]);
                    index++;
                }
            }
            this.ClientSize = new System.Drawing.Size(buttonDimension*i, buttonDimension*j);
            blankX = j-1;
            blankY = i-1;
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
            if (chekForWin())
            {
                MessageBox.Show("press ok to restart", "YOU WON!");
                this.Dispose();
                Application.Restart();
            }
                
                
        }

        private IEnumerable<string> insertElements()
        {
            var r = new Random();
            var elementList = new List<string>();
            for (int i = 1; i <= matrix.Length-1; i++)
            {
                elementList.Add(i.ToString());
            }
            return elementList.OrderBy(x => r.Next());
        }

        private bool chekForWin()
        {
            int count = 1;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if(matrix[i, j].Text != "")
                    {
                        if(Convert.ToInt32(matrix[i, j].Text) != count) return false;
                    }
                    count++;
                }
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
