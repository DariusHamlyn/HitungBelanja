﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace HitungBelanja
{
    public partial class FrmTambahBarang : Form
    {
        string sqlString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = SimpleECommerce; Integrated Security = True;";

        public FrmTambahBarang()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (this.txtKodeBarang.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, kode barang tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtKodeBarang.Focus();
            }
            else if (this.txtNamaBarang.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, nama barang tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNamaBarang.Focus();
            }
            else if (this.txtJumlahBarang.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, jumlah tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtJumlahBarang.Focus();
            }
            else if (this.txtHargaBarang.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, harga tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtHargaBarang.Focus();
            }
            else
            {
                try
                {
                    using (var dao = new BarangDAO(sqlString))
                    {
                        dao.AddBarang(new Barang
                        {
                            Kode = this.txtKodeBarang.Text.Trim(),
                            Nama = this.txtNamaBarang.Text.Trim(),
                            Jumlah = int.Parse(txtJumlahBarang.Text.Trim()),
                            Harga = Convert.ToDecimal(txtHargaBarang.Text.Trim())
                        }); 
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}