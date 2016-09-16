using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_lab.Models;

namespace Proyecto_lab.Controllers
{
    public class Lab_IngIController : Controller
    {
        BD_B02441Entities baseDatos = new BD_B02441Entities();
        // GET: Lab_IngI
        public ActionResult Index()
        {
            ModeloIntermedio modelo = new ModeloIntermedio();
            modelo.listaClientes = baseDatos.Cliente.ToList();
            modelo.listaTelefonos = baseDatos.Telefono.ToList();
            modelo.listaCuentas = baseDatos.Cuenta.ToList();       
            return View(modelo);
        }
        public ActionResult Create() {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ModeloIntermedio modelo)
        {
            if (ModelState.IsValid)
            {
                baseDatos.Cliente.Add(modelo.modeloCliente);
                baseDatos.SaveChanges();
                if (modelo.telefono1.numero != null)
                {
                    modelo.telefono1.cedula = modelo.modeloCliente.cedula;
                    baseDatos.Telefono.Add(modelo.telefono1);
                }
                if (modelo.telefono2.numero != null)
                {
                    modelo.telefono2.cedula = modelo.modeloCliente.cedula;
                    baseDatos.Telefono.Add(modelo.telefono2);
                }
                baseDatos.SaveChanges();

                if (modelo.cuenta1.numero != null)
                {
                    modelo.cuenta1.cedula = modelo.modeloCliente.cedula;
                    baseDatos.Cuenta.Add(modelo.cuenta1);
                }
                if (modelo.cuenta2.numero != null)
                {
                    modelo.cuenta2.cedula = modelo.modeloCliente.cedula;
                    baseDatos.Cuenta.Add(modelo.cuenta2);
                }
                if (modelo.cuenta3.numero != null)
                {
                    modelo.cuenta3.cedula = modelo.modeloCliente.cedula;
                    baseDatos.Cuenta.Add(modelo.cuenta3);
                }
                baseDatos.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Debe completar toda la información necesaria.");
                return View(modelo);
            }
        }

        public ActionResult Details()
        {
            return View();
        }

    }
}