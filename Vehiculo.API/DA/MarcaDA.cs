using Abstracciones.Interfaces.DA;
using Abstracciones.Modelos;
using Dapper;
using Microsoft.Data.SqlClient;


namespace DA
{
    public class MarcaDA : IMarcaDA
    {
        private IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;

        public MarcaDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorio();
        }

        public async Task<IEnumerable<MarcaBase>> Obtener()
        {
            string query = @"ObtenerMarcas";
            var resultadoConsulta = await _sqlConnection.QueryAsync<MarcaBase>(query);
            return resultadoConsulta;
        }
    }
}
