using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_lab.Models
{
    public class ModeloIntermedio
    {
        public Cliente modeloCliente { get; set; }
        public Telefono telefono1 { get; set;  }
        public Telefono telefono2 { get; set; }
        public Cuenta cuenta1 { get; set; }
        public Cuenta cuenta2 { get; set; }
        public Cuenta cuenta3 { get; set; }

        public List<Cliente> listaClientes = new List<Cliente>();
        public List<Telefono> listaTelefonos = new List<Telefono>();
        public List<Cuenta> listaCuentas = new List<Cuenta>(); 
    }
}
