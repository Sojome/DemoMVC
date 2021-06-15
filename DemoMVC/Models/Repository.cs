using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class Repository
    {
        public Demo GetDemo()
        {
            return new Demo { Mensaje = "hola mundo", mensajeHtml = "<h1>hola mundo</h1>" };
        }
    }
}