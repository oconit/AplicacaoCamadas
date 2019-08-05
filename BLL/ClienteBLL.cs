using System;
using System.Data;
using DAL;
using CUL;


namespace BLL
{
    public class ClienteBLL
    {
        public DataTable getClientesPorID(Cliente _cliente)
        {
            ClienteDAL _clienteDAL = new ClienteDAL();
            if (ValidarID(_cliente.ID))
            {
                return _clienteDAL.getClientesSelecionados().Tables[0];
            }
            return null;

        }

        private bool ValidarID(int clienteID)
        {
            if (clienteID > 5)
            {
                throw new ApplicationException("O código do cliente deve ser menor que 5");
            }
            return true;
        }
    }
}
