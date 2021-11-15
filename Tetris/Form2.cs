using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form2 : Form
    {
         
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string infoString = "";
            infoString = "Для управление фигурами используйте стрелочку влево/вправо.\n";
            infoString += "Чтобы ускорить падение фигуры - нажмите 'Пробел'.\n";
            infoString += "Для поворота фигуры используйте 'A'.\n";
            MessageBox.Show(infoString, "Справка");
            
        }
        
         private void button1_Click(object sender, EventArgs e)
        {
            Application.Run(new Form1());
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
