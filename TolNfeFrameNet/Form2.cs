using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Common;

namespace TolNfeFrameNet
{
    public partial class Form2 : Form
    {

        public static Form1 insere = new Form1();
        public static Form2 pesq = new Form2();
        public string[] SqlCampo1 = insere.insereCampo();
        public static DataTable dt = new DataTable();

        public Form2()
        {
            InitializeComponent();
        }

        public string pesquisa()
        {

            return Convert.ToString(pesq.tx_pesq.Text.Trim());
            

        }

        private DataTable selecionar(bool ativos)
        {
            var dt = new DataTable();
            string nomePesq = tx_pesq.Text.Trim();
            string tabela = Convert.ToString(pesq.mySqlDataTable1.TableName).Trim();

            try
            {
   
                if (nomePesq == null)
                {

                }
                else
                {

                    //Executa comando MySQL e insere em uma DataGridView
                    MySqlCommand cmd = Conectar.EXEC_QUERY("SELECT " + pesq.SqlCampo1[0].Trim() + ", " + pesq.SqlCampo1[1].Trim() + " FROM " + tabela + " WHERE " + pesq.SqlCampo1[1].Trim() + " LIKE '%" + nomePesq + "%' ORDER BY " + pesq.SqlCampo1[0].Trim() + " ASC");
                    Console.WriteLine(cmd);
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                        
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao procurar o cliente " + ex.Message);
            }

            return dt;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (pesq.tx_pesq.Text == string.Empty)
            {

                MessageBox.Show("Campo de pesquisa nao pode estar vazio", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                dt = selecionar(true);
                dataSelectView.DataSource = dt;
                gridPesquisar();
                 
            }


        }

        public void gridPesquisar()
        {

            dataSelectView.DefaultCellStyle.Font = new Font("Ariel", 9);
            dataSelectView.RowHeadersWidth = 25;

            dataSelectView.Columns["CLICOD"].HeaderText = "ID";
            dataSelectView.Columns["CLICOD"].Width = 30;
            dataSelectView.Columns["CLICOD"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataSelectView.Columns["CLICOD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataSelectView.Columns["CLICOD"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            dataSelectView.Columns["CLINOM"].HeaderText = "Descrição";
            dataSelectView.Columns["CLINOM"].Width = 140;
            dataSelectView.Columns["CLINOM"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataSelectView.Columns["CLINOM"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataSelectView.Columns["CLINOM"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);


        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (tx_pesq.Text == "Pesquisa")
            {
                tx_pesq.Text = "";

                tx_pesq.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            if (tx_pesq.Text == "")
            {
                tx_pesq.Text = "Pesquisa";

                tx_pesq.ForeColor = Color.Silver;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

    
        private void Form2_Load(object sender, EventArgs e)
        {

        }

       
    }
}
