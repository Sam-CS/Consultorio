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
    public partial class FrmConsulta : Form, IcadForm
    {
        Consulta objConsulta;
        Conexao con;

        public void bloquearCampos()
        {
            txtIdConsulta.ReadOnly = true;
            txtMotivo.ReadOnly = true;
            dtpConsulta.Enabled = false;
            txtDiagnostico.ReadOnly = true;
            txtReceita.ReadOnly = true;
            dtpRetorno.Enabled = false;
            txtMotivoRetorno.ReadOnly = true;
        }

        public void desbloquearCampos()
        {
            txtIdConsulta.ReadOnly = false;
            txtMotivo.ReadOnly = false;
            dtpConsulta.Enabled = true;
            txtDiagnostico.ReadOnly = false;
            txtReceita.ReadOnly = false;
            dtpRetorno.Enabled = true;
            txtMotivoRetorno.ReadOnly = false;
        }

        public void lerDados()
        {
            objConsulta = new Consulta();
            objConsulta.idConsulta = int.Parse(txtIdConsulta.Text.Trim());
            objConsulta.motivo = txtMotivo.Text;
            objConsulta.dtConsulta = dtpConsulta.Value;
            objConsulta.diagnostico = txtDiagnostico.Text;
            objConsulta.receita = txtReceita.Text;
            objConsulta.dtRetorno = dtpRetorno.Value;
            objConsulta.motivoRetorno = txtMotivoRetorno.Text;
            objConsulta.idPaciente = int.Parse(cbPaciente.SelectedValue.ToString());
            objConsulta.idDentista = int.Parse(cbDentista.SelectedValue.ToString());
        }

        public void popularComboDentista()
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
                    dentista.Sexo = reader.GetValue(3) == null ? "" : reader.GetValue(3).ToString();
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

            cbDentista.DataSource = null;
            cbDentista.DataSource = listDentista;
            cbDentista.ValueMember = "idDentista";
            cbDentista.DisplayMember = "nomeDentista";

        }

        

       public void limparCampos()

        {
            txtIdConsulta.Text = "";
            txtMotivo.Text = "";
            dtpConsulta.Text = "";
            txtDiagnostico.Text = "";
            txtReceita.Text = "";
            dtpRetorno.Text = "";
            txtMotivoRetorno.Text = "";
            cbDentista.Text = "";
            cbPaciente.Text = "";

        }

        public void popularComboPaciente()
        {
            List<Paciente> listPaciente = new List<Paciente>();
            con.conectar();
            SqlDataReader reader;
            reader = con.exeConsulta("SELECT * FROM tb_paciente");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Paciente paciente = new Paciente();

                    paciente.idPaciente = reader.GetInt32(0);
                    paciente.nomePaciente = reader.GetString(1);
                    paciente.cpf = reader.GetString(2);
                    paciente.endereco = reader.GetString(3);
                    paciente.telefone = reader.GetString(4);
                    paciente.dtNasc = reader.GetDateTime(5);

                    listPaciente.Add(paciente);

                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("Não retornou dados!");
            }

            cbPaciente.DataSource = null;
            cbPaciente.DataSource = listPaciente;
            cbPaciente.DisplayMember = "nomePaciente";
            cbPaciente.ValueMember = "idPaciente";
        }

         public void atualizarGrid()
        {
            List<Consulta> listConsulta = new List<Consulta>();
            con.conectar();
            SqlDataReader reader;
            reader = con.exeConsulta("SELECT * FROM tb_consulta");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Consulta consulta = new Consulta();
                    consulta.idConsulta = reader.GetInt32(0);
                    consulta.motivo = reader.GetString(1);
                    consulta.dtConsulta = reader.GetDateTime(2);
                    consulta.diagnostico = reader.GetString(3);
                    consulta.receita = reader.GetString(4);
                    consulta.dtRetorno = reader.GetDateTime(5);
                    consulta.motivoRetorno = reader.GetString(6);
                    consulta.idPaciente = reader.GetInt32(7);
                    consulta.idDentista = reader.GetInt32(8);

                    listConsulta.Add(consulta);


                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("Não retornou dados!");
            }
            dgvConsulta.DataSource = null;
            dgvConsulta.DataSource = listConsulta;
        }




        





        public FrmConsulta()
        {
            con = new Conexao();
            InitializeComponent();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            bloquearCampos();
            popularComboDentista();
            popularComboPaciente();
            atualizarGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            desbloquearCampos();
            limparCampos();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lerDados();
            String sql = "INSERT INTO tb_consulta VALUES (" + objConsulta.idConsulta + ", '" + objConsulta.motivo + "', '" + objConsulta.dtConsulta + "','" + objConsulta.diagnostico + "', '" + objConsulta.receita + "', '" + objConsulta.dtRetorno + "', '" + objConsulta.motivoRetorno + "', '" + objConsulta.idPaciente + "', '" + objConsulta.idDentista + "')";
            if (con.executar(sql) == 1)
            {
                MessageBox.Show("Dados salvos com sucesso !");
            }
            else
            {
                MessageBox.Show("Dados não foram salvos !");
            }
            bloquearCampos();
            atualizarGrid();

        }

        private void dgvConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdConsulta.Text = dgvConsulta.CurrentRow.Cells[0].Value.ToString();
            txtMotivo.Text = dgvConsulta.CurrentRow.Cells[1].Value.ToString();
            dtpConsulta.Text = dgvConsulta.CurrentRow.Cells[2].Value.ToString();
            txtDiagnostico.Text = dgvConsulta.CurrentRow.Cells[3].Value.ToString();
            txtReceita.Text = dgvConsulta.CurrentRow.Cells[4].Value.ToString();
            dtpRetorno.Text = dgvConsulta.CurrentRow.Cells[5].Value.ToString();
            txtMotivoRetorno.Text = dgvConsulta.CurrentRow.Cells[6].Value.ToString();
            cbPaciente.Text = dgvConsulta.CurrentRow.Cells[7].Value.ToString();
            cbDentista.Text = dgvConsulta.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
