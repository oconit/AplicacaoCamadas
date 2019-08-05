using System.Data;

namespace DAL
{
    public class ClienteDAL
    {
        public DataSet getClientesSelecionados()
        {
            string sqlCommand = "select * from Clientes where id < 5";
            DataSet dataSet = SqlHelper.ExecuteDataset(SqlHelper.CONN_STRING, CommandType.Text, sqlCommand);
            return dataSet;
        }
    }
}
