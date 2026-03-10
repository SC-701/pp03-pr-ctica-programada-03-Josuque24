using Abstracciones.Interfaces.DA;
using Abstracciones.Modelos;
using Dapper;
using Microsoft.Data.SqlClient;

namespace DA
{
    public class ModeloDA : IModeloDA
    {
        private IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;

        public ModeloDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorio();
        }       
        public async Task<IEnumerable<ModeloBase>> Obtener(Guid Id)
        {
            string query = @"ObtenerModelo";
            var resultadoConsulta = await _sqlConnection.QueryAsync<ModeloBase>(query,
                new { Id = Id });
            return resultadoConsulta;
        }
    }
}
