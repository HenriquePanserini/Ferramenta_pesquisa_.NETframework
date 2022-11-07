
namespace TolNfeFrameNet
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tx_pesq = new System.Windows.Forms.TextBox();
            this.dataSelectView = new System.Windows.Forms.DataGridView();
            this.mySqlDataTable1 = new Devart.Data.MySql.MySqlDataTable();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSelectView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlDataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tx_pesq);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 52);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::TolNfeFrameNet.Properties.Resources.Consulta1;
            this.pictureBox1.Location = new System.Drawing.Point(316, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tx_pesq
            // 
            this.tx_pesq.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.tx_pesq.Location = new System.Drawing.Point(11, 15);
            this.tx_pesq.Name = "tx_pesq";
            this.tx_pesq.Size = new System.Drawing.Size(303, 20);
            this.tx_pesq.TabIndex = 1;
            this.tx_pesq.Text = "Pesquisa";
            this.tx_pesq.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tx_pesq.Enter += new System.EventHandler(this.textBox1_Enter);
            this.tx_pesq.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // dataSelectView
            // 
            this.dataSelectView.AllowUserToAddRows = false;
            this.dataSelectView.AllowUserToDeleteRows = false;
            this.dataSelectView.AllowUserToResizeColumns = false;
            this.dataSelectView.AllowUserToResizeRows = false;
            this.dataSelectView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSelectView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSelectView.BackgroundColor = System.Drawing.Color.White;
            this.dataSelectView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSelectView.GridColor = System.Drawing.Color.White;
            this.dataSelectView.Location = new System.Drawing.Point(11, 68);
            this.dataSelectView.MultiSelect = false;
            this.dataSelectView.Name = "dataSelectView";
            this.dataSelectView.ReadOnly = true;
            this.dataSelectView.RowHeadersVisible = false;
            this.dataSelectView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataSelectView.ShowEditingIcon = false;
            this.dataSelectView.Size = new System.Drawing.Size(776, 381);
            this.dataSelectView.TabIndex = 0;
            // 
            // mySqlDataTable1
            // 
            this.mySqlDataTable1.Name = "mySqlDataTable1";
            this.mySqlDataTable1.TableName = "tslc001";
            this.mySqlDataTable1.Owner = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataSelectView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSelectView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlDataTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tx_pesq;
        private System.Windows.Forms.DataGridView dataSelectView;
        private Devart.Data.MySql.MySqlDataTable mySqlDataTable1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}