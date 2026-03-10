using Abstracciones.Interfaces.DA;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Interfaces.Reglas;
using Abstracciones.Modelos;

namespace Flujo
{
    public class ModeloFlujo : IModeloFlujo
    {
        private readonly IModeloDA _modeloDA;

        public ModeloFlujo(IModeloDA modeloDA)
        {
            _modeloDA = modeloDA;
        }

        public async Task<IEnumerable<ModeloBase>> Obtener(Guid Id)
        {
            var vehiculo = await _modeloDA.Obtener(Id);            
            return vehiculo;
        }
    }
}
