using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padroes.Patterns.Behavioral.Memento
{
    public partial class Memento : Form
    {
        private MementoAdapter _mementoAdapter = new MementoAdapter();
        private Cliente _cliente;

        public Memento()
        {
            InitializeComponent();
            _cliente = _mementoAdapter.Inicializar();
        }

        private void Memento_Load(object sender, EventArgs e)
        {

        }

        private void Proximo()
        {
            try
            {
                _cliente = _mementoAdapter.Proximo();
            }
            catch (SystemException e)
            {
                MessageBox.Show(e.Message);
                return;
            }

            AtualizarCampos();
        }

        private void Anterior()
        {
            try
            {
                _cliente = _mementoAdapter.Anterior();
            }
            catch (SystemException e)
            {
                MessageBox.Show(e.Message);
                return;
            }

            AtualizarCampos();
        }

        private void AtualizarCampos()
        {
            txtId.Text = _cliente.Id.ToString();
            txtNome.Text = _cliente.Nome;
            txtTelefone.Text = _cliente.Telefone;
        }

        private void Salvar()
        {
            _cliente = _mementoAdapter.Salvar();
            _cliente.Id = int.Parse(txtId.Text);
            _cliente.Nome = txtNome.Text;
            _cliente.Telefone = txtTelefone.Text;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Anterior();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Proximo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarCampos();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
