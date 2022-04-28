using FranMotors.DB;
using FranMotors.Manager;
using FranMotors.Models;
using FranMotors.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FranMotors.Controllers
{
    public class MecanicoController : Controller
    {
        private FranMotorsContext context;
        private readonly IMecanicoRepository mecanicoRepository;
        private readonly IAccountViewBagManager accountViewBagManager;

        public MecanicoController(FranMotorsContext context, IMecanicoRepository mecanicoRepository, IAccountViewBagManager accountViewBagManager)
        {
            this.context = context;
            this.mecanicoRepository = mecanicoRepository;
            this.accountViewBagManager = accountViewBagManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            accountViewBagManager.ConfiguraViewBagForVirwAccount(ViewBag);
            return View();
        }
        public IActionResult ListMoto(int id)
        {
            var moto = mecanicoRepository.ListMotoForClient(id);
            accountViewBagManager.ConfiguraViewBagListMoto(ViewBag, id);
            accountViewBagManager.ConfiguraViewBagForVirwAccount(ViewBag);
            return View(moto);
        }
        [HttpGet]
        public IActionResult ListCliente()
        {
            accountViewBagManager.ConfiguraViewBagForVirwAccount(ViewBag);
            return View();

        }
        [HttpGet]
        public IActionResult AllClientes(string buscarClientes)
        {

            return View(mecanicoRepository.GetAllClientes(buscarClientes));
        }
        [HttpGet]
        public IActionResult EditCliente(int id)
        {
            accountViewBagManager.ConfiguraViewBagForVirwAccount(ViewBag);
            var clie = context.Clientes.Where(o => o.Id == id).FirstOrDefault();

            return View(clie);
        }
        [HttpGet]
        public IActionResult RegisterMoto(int id)
        {
            var clie = context.Clientes.FirstOrDefault(o => o.Id == id);
            accountViewBagManager.ConfiguraViewBagForVirwAccount(ViewBag);
            return View(clie);
        }
        [HttpGet]
        public IActionResult RegHistory(int id)
        {
            accountViewBagManager.ConfiguraViewBagForVirwAccount(ViewBag);
            var moto = context.Motocicletas.FirstOrDefault(o => o.Id == id);
            return View(moto);
        }
        [HttpGet]
        public IActionResult VerHistoria(int id, int idcliente)
        {
            var hist = mecanicoRepository.LisHistorialForMoto(id, idcliente);
            accountViewBagManager.ConfiguraViewBagForViewListHistory(ViewBag, idcliente);
            accountViewBagManager.ConfiguraViewBagForVirwAccount(ViewBag);
            return View(hist);
        }
        [HttpGet]
        public IActionResult EditMoto(int id)
        {
            var edmoto = context.Motocicletas.Where(o => o.Id == id).FirstOrDefault();
            accountViewBagManager.ConfiguraViewBagForVirwAccount(ViewBag);
            return View(edmoto);
        }
        [HttpPost]
        public IActionResult RegHistory(int id, Historial history, int idcliente)
        {

            mecanicoRepository.RegistrarHistoria(id,history, idcliente);
            return RedirectToAction("ListMoto", new { Id = idcliente});
        }
        [HttpPost]
        public IActionResult RegisterMoto(int id, Motocicleta moto)
        {
            mecanicoRepository.RegisterMoto(id, moto);

            return RedirectToAction("ListCliente");
        }
        [HttpPost]
        public IActionResult Register(Cliente cliente)
        {
            //if (ModelState.IsValid)
            //{
            //    account.Tipo = "Mecanico";
            //    account.Estado = true;
            //    context.Accounts.Add(account);
            //    context.SaveChanges();
            //    return RedirectToAction("Mecanico", new Account());
            //}
            accountViewBagManager.ConfiguraViewBagForVirwAccount(ViewBag);
            if (ModelState.IsValid && cliente != null)
            {
                mecanicoRepository.RegistrarCliente(cliente);
                return RedirectToAction("ListCliente");
            }

            return View();
        }
        [HttpPost]
        public IActionResult EditCliente(Cliente cliente)
        {
            var cli = context.Clientes.Find(cliente.Id);
            cli.Nombre = cliente.Nombre;
            cli.Apellido = cliente.Apellido;
            cli.Dni = cliente.Dni;
            cli.Correo = cliente.Correo;
            cli.Telefono = cliente.Telefono;
            context.SaveChanges();
            return RedirectToAction("ListCliente");
        }
        [HttpPost]
        public IActionResult EditMoto(Motocicleta moto, int idcliente)
        {
            mecanicoRepository.EditarMoto(moto, idcliente);

            return RedirectToAction("ListMoto", new { Id = idcliente });
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var cliente = context.Clientes.Find(id);
            context.Clientes.Remove(cliente);
            context.SaveChanges();

            return RedirectToAction("ListCliente");
        }       
    }
}
