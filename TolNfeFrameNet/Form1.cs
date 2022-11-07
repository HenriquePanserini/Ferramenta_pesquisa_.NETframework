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
    public partial class Form1 : Form
    {

        public static Form2 pesq = new Form2();
        public static MySqlScript script = new MySqlScript();
        public static string pesquisa = pesq.pesquisa();
        
        public Form1()
        {
            InitializeComponent();
        }


        public string[] insereCampo()
        {

                string[] SQlcampos = new string[6];
                SQlcampos[0] = "CLICOD";
                SQlcampos[1] = "CLINOM";
                SQlcampos[2] = "";
                SQlcampos[3] = "";
                SQlcampos[4] = "";
                SQlcampos[5] = "";

                return SQlcampos;
            
        }
        private void button3_Click(object sender, EventArgs e)
        {


            var form2 = new Form2();
            form2.Show();
            

        }
    }
}
