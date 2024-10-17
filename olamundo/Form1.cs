using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olamundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            table.Columns.Add("Rua1",typeof(int));
            table.Columns.Add("Rua2", typeof(int));
            table.Columns.Add("Rua3", typeof(int));
            table.Columns.Add("Rua4", typeof(int));
            table.Columns.Add("Rua5", typeof(int));
            table.Columns.Add("Rua6", typeof(int));
            table.Columns.Add("Rua7", typeof(int));
            table.Columns.Add("Rua8", typeof(int));
            table.Columns.Add("Rua9", typeof(int));
            table.Columns.Add("Rua10", typeof(int));
            dataGridView1.DataSource = table;
            Random random = new Random();
            /*table.Rows.Add(random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15));
            table.Rows.Add(random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15));
            table.Rows.Add(random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15));
            table.Rows.Add(random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15));
            table.Rows.Add(random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15));
            table.Rows.Add(random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15));
            table.Rows.Add(random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15));
            table.Rows.Add(random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15));
            table.Rows.Add(random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15));
            table.Rows.Add(random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15), random.Next(1, 15));
           */
                        table.Rows.Add(random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3));
            table.Rows.Add(random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3));
            table.Rows.Add(random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3));
            table.Rows.Add(random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3));
            table.Rows.Add(random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3));
            table.Rows.Add(random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3));
            table.Rows.Add(random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3));
            table.Rows.Add(random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3));
            table.Rows.Add(random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3));
            table.Rows.Add(random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3), random.Next(1, 3));

            /*agora começa a saga da potencia 2, aqui é que a brincadeira fica mais bonita  */
            int valorquadrabig = 0;
            int acumulantemaiorbig = 0;
            int a1 = 0;
            int a2 = 0;
            int a3 = 0;
            int a4 = 0;
            int b1 = 0;
            int b2 = 0;
            int b3 = 0;
            int b4 = 0;
            int z1 = 0;
            int w1 = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    valorquadrabig += Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value) + Convert.ToInt32(dataGridView1.Rows[i].Cells[j + 1].Value) + Convert.ToInt32(dataGridView1.Rows[i].Cells[j + 1 + 1].Value) + Convert.ToInt32(dataGridView1.Rows[i].Cells[j + 1 + 1 + 1].Value);

                    valorquadrabig += Convert.ToInt32(dataGridView1.Rows[i + 1].Cells[j].Value) + Convert.ToInt32(dataGridView1.Rows[i + 1 ].Cells[j + 1].Value) + Convert.ToInt32(dataGridView1.Rows[i +1].Cells[j + 1 + 1].Value) + Convert.ToInt32(dataGridView1.Rows[i+1].Cells[j + 1 + 1 + 1].Value);
                   
                    valorquadrabig += Convert.ToInt32(dataGridView1.Rows[i + 1+1].Cells[j].Value) + Convert.ToInt32(dataGridView1.Rows[i + 1+1].Cells[j + 1+1].Value) + Convert.ToInt32(dataGridView1.Rows[i + 1+1].Cells[j + 1 + 1].Value) + Convert.ToInt32(dataGridView1.Rows[i + 1+1].Cells[j + 1 + 1 + 1].Value);
                  
                    valorquadrabig += Convert.ToInt32(dataGridView1.Rows[i + 1 + 1+1].Cells[j].Value) + Convert.ToInt32(dataGridView1.Rows[i + 1 + 1+1].Cells[j + 1 + 1].Value) + Convert.ToInt32(dataGridView1.Rows[i + 1 + 1+1].Cells[j + 1 + 1].Value) + Convert.ToInt32(dataGridView1.Rows[i + 1 + 1+1].Cells[j + 1 + 1 + 1].Value);

                    if (acumulantemaiorbig < valorquadrabig)
                    {
                        acumulantemaiorbig = valorquadrabig;
                        z1 = i;
                        w1 = j;
                        a1 = i + 1 + 1; 
                        b1 = j + 1;
                        a2 = i + 1;
                        b2 = j + 1 + 1;
                        a3 = i + 1 + 1;
                        b3 = j + 1 + 1 + 1;
                        a4 = i + 1 + 1 + 1;
                        b4 = j + 1 + 1 + 1 + 1;
                    }
                    valorquadrabig = 0;




                }


            }



            dataGridView1.Rows[z1].Cells[b1].Style.BackColor = Color.Red;
            dataGridView1.Rows[z1].Cells[b2].Style.BackColor = Color.Red;
            dataGridView1.Rows[z1].Cells[b3].Style.BackColor = Color.Red;
            dataGridView1.Rows[z1].Cells[b4].Style.BackColor = Color.Red;
            dataGridView1.Rows[a1].Cells[b1].Style.BackColor = Color.Red;
            dataGridView1.Rows[a1].Cells[b2].Style.BackColor = Color.Red;
            dataGridView1.Rows[a1].Cells[b3].Style.BackColor = Color.Red;
            dataGridView1.Rows[a1].Cells[b4].Style.BackColor = Color.Red;
            dataGridView1.Rows[a2].Cells[b1].Style.BackColor = Color.Red;
            dataGridView1.Rows[a2].Cells[b2].Style.BackColor = Color.Red;
            dataGridView1.Rows[a2].Cells[b3].Style.BackColor = Color.Red;
            dataGridView1.Rows[a2].Cells[b4].Style.BackColor = Color.Red;
            dataGridView1.Rows[a3].Cells[b1].Style.BackColor = Color.Red;
            dataGridView1.Rows[a3].Cells[b2].Style.BackColor = Color.Red;
            dataGridView1.Rows[a3].Cells[b3].Style.BackColor = Color.Red;
            dataGridView1.Rows[a3].Cells[b4].Style.BackColor = Color.Red;
            dataGridView1.Rows[a4].Cells[b1].Style.BackColor = Color.Red;
            dataGridView1.Rows[a4].Cells[b2].Style.BackColor = Color.Red;
            dataGridView1.Rows[a4].Cells[b3].Style.BackColor = Color.Red;
            dataGridView1.Rows[a4].Cells[b4].Style.BackColor = Color.Red;


            /* essa é a parte do veneno potencia 1*/
            int valorquadra = 0;
            int acumulantemaior = 0;
            int x1 = 0;
            int x2 = 0;
            int y1 = 0;
            int y2 = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {


                    valorquadra += Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value) + Convert.ToInt32(dataGridView1.Rows[i].Cells[j + 1].Value);
                    valorquadra += Convert.ToInt32(dataGridView1.Rows[i + 1].Cells[j].Value) + Convert.ToInt32(dataGridView1.Rows[i + 1].Cells[j + 1].Value);


                    if (dataGridView1.Rows[i].Cells[j].Style.BackColor == Color.Red ||
           dataGridView1.Rows[i].Cells[j + 1].Style.BackColor == Color.Red ||
           dataGridView1.Rows[i + 1].Cells[j].Style.BackColor == Color.Red ||
           dataGridView1.Rows[i + 1].Cells[j + 1].Style.BackColor == Color.Red)
                    {
                        valorquadra = acumulantemaior;
                    }
                    if (acumulantemaior < valorquadra)
                    {
                        acumulantemaior = valorquadra;
                        x1 = i; y1 = j; x2 = i + 1; y2 = j + 1;

                    }
                    valorquadra = 0;




                }


            }
            /*as cores amarelas ficavam aqui vas o vermelho se subreposia muito entao lhe atirei la embaixo*/


            /*termina aqui a potencia 1*/


            /*agora taqui o amarelo*/
            dataGridView1.Rows[x1].Cells[y1].Style.BackColor = Color.Yellow;
            dataGridView1.Rows[x2].Cells[y1].Style.BackColor = Color.Yellow;
            dataGridView1.Rows[x1].Cells[y2].Style.BackColor = Color.Yellow;
            dataGridView1.Rows[x2].Cells[y2].Style.BackColor = Color.Yellow;

            /*termina aqui a grande saga felismente teriminei*/


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
