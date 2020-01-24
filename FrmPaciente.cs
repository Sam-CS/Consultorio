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
    public partial class FrmPaciente : Form, IcadForm
    {
        Paciente objPaciente;
        Conexao con;
        public void bloquearCampos()
        {
            txtIdPaciente.ReadOnly = true;
            txtNomePaciente.ReadOnly = true;
            txtCpf.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            dtpNasc.Enabled = false;
        }

        public void desbloquearCampos()
        {
            txtIdPaciente.ReadOnly = false;
            txtNomePaciente.ReadOnly = false;
            txtCpf.ReadOnly = false;
            txtEndereco.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            dtpNasc.Enabled = true;
        }

        public void lerDados()
        {
            objPaciente = new Paciente();

            objPaciente.idPaciente = int.Parse(txtIdPaciente.Text.Trim());
            objPaciente.nomePaciente = txtNomePaciente.Text;
            objPaciente.cpf = txtCpf.Text;
            objPaciente.endereco = txtEndereco.Text;
            objPaciente.telefone = txtTelefone.Text;
            objPaciente.dtNasc = dtpNasc.Value;
            
        
        }

        public void limparCampos()
        {

            txtIdPaciente.Text = "";
            txtNomePaciente.Text = "";
            txtCpf.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            
        }

        public void atualizarGrid()
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

            dgvPaciente.DataSource = null;
            dgvPaciente.DataSource = listPaciente;
            
        }





        public FrmPaciente()
        {
            con = new Conexao();
            InitializeComponent();
        }

        private void btnNovoPaciente_Click(object sender, EventArgs e)
        {
            desbloquearCampos();
            limparCampos();
        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            atualizarGrid();
            bloquearCampos();
        }

        private void btnSalvarPaciente_Click(object sender, EventArgs e)
        {
            lerDados();
            String sql = "INSERT INTO tb_paciente VALUES (" + objPaciente.idPaciente + ", '" + objPaciente.nomePaciente + "', '" + objPaciente.cpf + "', '" + objPaciente.endereco + "', '" + objPaciente.telefone + "', '" + objPaciente.dtNasc + "')";

            if (con.executar(sql) == 1)
            {
                MessageBox.Show("Dados salvos com sucesso!");
            }
            else
            {
                MessageBox.Show("Dados não salvos com sucesso!");
            }
            bloquearCampos();
            atualizarGrid();
        }

        private void dgvPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPaciente.Text = dgvPaciente.CurrentRow.Cells[0].Value.ToString();
            txtNomePaciente.Text = dgvPaciente.CurrentRow.Cells[1].Value.ToString();
            txtCpf.Text = dgvPaciente.CurrentRow.Cells[2].Value.ToString();
            txtEndereco.Text = dgvPaciente.CurrentRow.Cells[3].Value.ToString();
            txtTelefone.Text = dgvPaciente.CurrentRow.Cells[4].Value.ToString();
            dtpNasc.Text = dgvPaciente.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
