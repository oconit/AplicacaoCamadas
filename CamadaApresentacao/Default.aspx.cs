using System;
using System.Web.UI;
using BLL;
using CUL;

namespace CamadaApresentacao
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClienteBLL _clienteBLL = new ClienteBLL();
            Cliente _cliente = new Cliente();
            _cliente.ID = 5;
            try
            {
                gdvClientes.DataSource = _clienteBLL.getClientesPorID(_cliente);
                gdvClientes.DataBind();
            }
            catch (ApplicationException applicationException)
            {
                lblErro.Text = applicationException.Message;
            }
        }
    }
}