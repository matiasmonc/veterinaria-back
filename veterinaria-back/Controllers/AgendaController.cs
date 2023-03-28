using Microsoft.AspNetCore.Mvc;

namespace veterinaria_back.Controllers
{
    [ApiController]
    [Route("api/agenda")]
    public class AgendaController : ControllerBase
    {
        [HttpPost]
        public ActionResult<respuestaAgenda> Agendar(InputAgenda datosAgenda)
        {
            respuestaAgenda respuesta = new respuestaAgenda();
            if(datosAgenda != null)
            {
                respuesta.codigo = 1;
                respuesta.respuesta = "Consulta agendada exitosamente";
            }

            return respuesta;
        }
    }

    public class respuestaAgenda
    {
        public int codigo { get; set; }
        public string respuesta { get; set; }
    }

    public class InputAgenda
    {
        public string fecha { get; set; }
        public string hora { get; set; }
        public string direccion { get; set; }
        public string atencion { get; set; }
    }
}
