using Microsoft.AspNetCore.Mvc;
using Abstracciones.Modelos;    

namespace Abstracciones.Interfaces.API
{
    public interface IMarcaController
    {
        Task<IActionResult> Obtener();
    }
}
