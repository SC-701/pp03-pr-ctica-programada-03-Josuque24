using Abstracciones.Modelos;

namespace Abstracciones.Interfaces.Flujo
{
    public interface IModeloFlujo
    {
        Task<IEnumerable<ModeloBase>> Obtener(Guid Id);
    }
}
