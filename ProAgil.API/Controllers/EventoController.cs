using Microsoft.AspNetCore.Mvc;
using ProAgil.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAgil.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        [HttpGet("/lista")]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return new Evento[]
            {
                new Evento()
                {
                    Id = 1,
                    Tema = "Angular ",
                    Local = "São Paulo",
                    QtdPessoas = 250,
                    Lote = "1� Lote",
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy")
                },

                new Evento()
                {
                    Id = 3,
                    Tema = ".NetCore",
                    Local = "Curitiba",
                    QtdPessoas = 250,
                    Lote = "1� Lote",
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy")
                }
            };
        }

        [HttpGet("/{id}")]
        public ActionResult<Evento> GetId(int Id)
        {
            return new Evento[]
          {
                new Evento()
                {
                    Id = 1,
                    Tema = "Angular ",
                    Local = "Curitiba",
                    QtdPessoas = 250,
                    Lote = "1� Lote",
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy")
                },

                new Evento()
                {
                    Id = 3,
                    Tema = ".NetCore",
                    Local = "Curitiba",
                    QtdPessoas = 250,
                    Lote = "1� Lote",
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy")
                }
          }.FirstOrDefault(x => x.Id == Id);
        }

    }
}