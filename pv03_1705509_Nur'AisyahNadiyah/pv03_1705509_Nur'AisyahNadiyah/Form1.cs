using pv03_1705509_Nur_AisyahNadiyah.Model;
using pv03_1705509_Nur_AisyahNadiyah.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pv03_1705509_Nur_AisyahNadiyah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TodoRepository todo = new TodoRepository();

            tbNim.Enabled = false;

            string nim = tbNim.Text;

            btnAdd.Enabled = true;
            SubmitNim.Enabled = false;

            dataGridView1.DataSource = todo.getByNim(nim);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Todo temp = new Todo();

            temp.NimMhs = tbNim.Text;
            temp.Nama = tbNama.Text;
            temp.Kategori = tbKategori.Text;

            TodoRepository todo = new TodoRepository();

            todo.addTodo(temp);

            string nim = tbNim.Text;

            dataGridView1.DataSource = todo.getByNim(nim);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Todo temp = new Todo();

            temp.Id = Convert.ToInt16(txtIdDelete.Text);

            TodoRepository todo = new TodoRepository();

            todo.deleteTodo(temp);

            string nim = tbNim.Text;

            dataGridView1.DataSource = todo.getByNim(nim);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Todo temp = new Todo();

            temp.Id = Convert.ToInt16(txtIdUpdate.Text);
            temp.NimMhs = tbNim.Text;
            temp.Nama = txtNamaUpdate.Text;
            temp.Kategori = txtKategoriUpdate.Text;

            TodoRepository todo = new TodoRepository();

            todo.updateTodo(temp);

            string nim = tbNim.Text;

            dataGridView1.DataSource = todo.getByNim(nim);
        }
    }
}
