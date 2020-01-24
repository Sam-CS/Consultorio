using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Consultorio
{
    public partial class CadDentista : Form, IcadForm
    {
        
        Dentista objDentista;
        Conexao con;



        public void bloquearBotoes()
        {
            btnPesquisar.Enabled = false;
            btnExcluir.Enabled = false;
            
        }
        public void desbloquearBotoes()
        {
            btnPesquisar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        public void desbloquearCampos()
        {
            txtIdDentista.ReadOnly = false;
            txtNomeDentista.ReadOnly = false;
            txtCro.ReadOnly = false;
        }

        public void bloquearCampos()
        {
            txtIdDentista.ReadOnly = true;
            txtNomeDentista.ReadOnly = true;
            txtCro.ReadOnly = true;
        }
        public void lerDados()
        {
            objDentista = new Dentista();

            objDentista.idDentista = int.Parse(txtIdDentista.Text.Trim());
            objDentista.NomeDentista = txtNomeDentista.Text;
            objDentista.Cro = txtCro.Text;

            objDentista.Instagram = cbInstagram.Checked ? 1 : 0;
            objDentista.Twitter = cbTwitter.Checked ? 1 : 0;
            objDentista.Facebook = cbFacebook.Checked ? 1 : 0;
            objDentista.Linkedin = cbLinkedin.Checked ? 1 : 0;

            if (rbFeminino.Checked)
            {
                objDentista.Sexo = "F";
            }
            else
            {
                objDentista.Sexo = "M";   
            }

        }

        public void limparCampos()
        {
            txtIdDentista.Text = "";
            txtNomeDentista.Text = "";
            txtCro.Text = "";
        }



        public void atualizarGrid()
        {
            List<Dentista> listDentista = new List<Dentista>();
            con.conectar();
            SqlDataReader reader;
            reader = con.exeConsulta("select * from tb_dentista");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Dentista dentista = new Dentista();
                    dentista.idDentista = reader.GetInt32(0);
                    dentista.NomeDentista = reader.GetString(1);
                    dentista.Cro = reader.GetString(2);
                    dentista.Sexo = reader.GetValue(3) == null ? "": reader.GetValue(3).ToString();
                    dentista.Instagram = reader.GetValue(4).ToString() == "True" ? 1 : 0;
                    dentista.Facebook = reader.GetValue(5).ToString() == "True" ? 1 : 0;
                    dentista.Twitter = reader.GetValue(6).ToString() == "True" ? 1 : 0;
                    dentista.Linkedin = reader.GetValue(7).ToString() == "True" ? 1 : 0;

                    listDentista.Add(dentista);
                   
                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("Não retornou dados");
            }
            dgvDados.DataSource = null;
            dgvDados.DataSource = listDentista;

        }




        public CadDentista()
        {
            InitializeComponent();
            con = new Conexao();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            desbloquearCampos();
            limparCampos();
            bloquearBotoes();

        }

        private void CadDentista_Load(object sender, EventArgs e)
        {
            atualizarGrid();
            bloquearCampos();

        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdDentista.Text = dgvDados.CurrentRow.Cells[0].Value.ToString();
            txtNomeDentista.Text = dgvDados.CurrentRow.Cells[1].Value.ToString();
            txtCro.Text = dgvDados.CurrentRow.Cells[2].Value.ToString();

            rbFeminino.Checked = dgvDados.CurrentRow.Cells[3].Value.Equals("F") ? true : false;
            rbMasculino.Checked = dgvDados.CurrentRow.Cells[3].Value.Equals("M") ? true : false;
            cbInstagram.Checked = dgvDados.CurrentRow.Cells[4].Value.Equals(1) ? true : false;
            cbFacebook.Checked = dgvDados.CurrentRow.Cells[5].Value.Equals(1) ? true : false;
            cbTwitter.Checked = dgvDados.CurrentRow.Cells[6].Value.Equals(1) ? true : false;
            cbLinkedin.Checked = dgvDados.CurrentRow.Cells[7].Value.Equals(1) ? true : false;


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lerDados();
            String sql = "INSERT INTO tb_dentista VALUES (" + objDentista.idDentista+", '" +objDentista.NomeDentista+ "', '" +objDentista.Cro+"', '"+objDentista.Sexo+"', '"+objDentista.Instagram+"', '"+objDentista.Facebook+"', '"+objDentista.Twitter+"','"+objDentista.Linkedin+"')";

            if (con.executar(sql) == 1)
            {
                MessageBox.Show("Dados salvos com sucesso!");
            }
            else
            {
                MessageBox.Show("Dados não foram salvos!");
            }
            desbloquearBotoes();
            bloquearCampos();
            atualizarGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desbloquearBotoes();
            bloquearCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            con.conectar();

            DialogResult op = MessageBox.Show("Você realmente deseja excluir os dados?", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (op == DialogResult.OK)
            {
                Dentista dentista = new Dentista();
                dentista.idDentista = int.Parse(txtIdDentista.Text.ToString());
                String sql = "DELETE FROM tb_dentista WHERE id_dentista = " + dentista.idDentista;
                if (con.executar(sql) == 1)
                {
                    MessageBox.Show("Dados excluidos!");
                }
                else
                {
                    MessageBox.Show("Falha");
                }
                atualizarGrid();

           }


            
            
               
            
           
           
           

        }
    }
}

