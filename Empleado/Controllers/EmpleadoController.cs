using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace EmpleadoController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private Models.EmpleadoContext db;
        public EmpleadoController(Models.EmpleadoContext context)
        {
            db = context;
        }
        [HttpGet(Name = "ObtenerEmpleado")]
        public ActionResult<IEnumerable<Models.Empleado>> EmpleadosResult()
        {
            return db.Empleado.ToList();
        }
        [HttpPost]
        public ActionResult PostEmpleado([FromBody] Models.Empleado empleado)
        {
            db.Empleado.Add(empleado);
            db.SaveChanges();
            return new CreatedAtRouteResult("ObtenerEmpleado",empleado);
        }
        [HttpPut("{id}")]
        public ActionResult PutEmpleado(int id, [FromBody] Models.Empleado empleado) {
            if (id != empleado.Id)
            {
                return BadRequest();
            }
            db.Entry(empleado).State = EntityState.Modified;
            db.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult<Models.Empleado> DeleteEmpleado(int id) 
        {
            var empleado = db.Empleado.FirstOrDefault(x => x.Id == id);
            if (empleado == null)
            {
                return NotFound();
            }
            db.Empleado.Remove(empleado);
            db.SaveChanges();
            return empleado;

        }
    }
}
