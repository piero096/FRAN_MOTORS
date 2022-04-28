using FranMotors.DB;
using FranMotors.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FranMotors.Repositories
{
    public interface IMecanicoRepository
    {
        void RegistrarCliente(Cliente cliente);
        List<Cliente> GetAllClientes(string buscarClientes);
        void RegisterMoto(int id, Motocicleta moto);
        void RegistrarHistoria(int id, Historial history, int idcliente);
        List<Historial> LisHistorialForMoto(int id, int idcliente);
        List<Motocicleta> ListMotoForClient(int id);
        void EditarMoto(Motocicleta moto, int idcliente);
        Account LoggedUser();
    }
    public class MecanicoRepository : IMecanicoRepository
    {
        private readonly FranMotorsContext context;
        private readonly IHttpContextAccessor _context;
        public MecanicoRepository(FranMotorsContext context, IHttpContextAccessor _context)
        {
            this.context = context;
            this._context = _context;
        }

        public List<Cliente> GetAllClientes(string buscarClientes)
        {
            var user = LoggedUser();

            if (!string.IsNullOrEmpty(buscarClientes))
            {
                return context.Clientes.Where(o => o.IdMecanico == user.Id && o.Nombre.Contains(buscarClientes) || o.Apellido.Contains(buscarClientes)).ToList();
            }
            return context.Clientes.Where(o => o.IdMecanico == user.Id).ToList();
        }

        public List<Motocicleta> ListMotoForClient(int id)
        {            
            return context.Motocicletas.Where(o => o.IdCliente == id).ToList();
        }

        public void RegisterMoto(int id, Motocicleta moto)
        {
            context.Motocicletas.Add(new Motocicleta
            {
                Placa = moto.Placa,
                Marca = moto.Marca,
                NumSerie = moto.NumSerie,
                Cilindrada = moto.Cilindrada,
                Año = moto.Año,
                IdCliente = id,
                EstadoMoto = moto.EstadoMoto
            });
            context.SaveChanges();
        }

        public void RegistrarCliente(Cliente cliente)
        {
            var user = LoggedUser();
            cliente.IdMecanico = user.Id;
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }
        public Account LoggedUser()
        {
            var claim = _context.HttpContext.User.Claims.First();
            string username = claim.Value;
            var user = context.Accounts.First(o => o.Username == username);


            return user;
        }

        public void RegistrarHistoria(int id, Historial history, int idcliente)
        {
            var fecha = DateTime.Now;

            context.Historials.Add(new Historial
            {
                Detalle = history.Detalle,
                Fecha = fecha,
                IdMoto = id
            });
            context.SaveChanges();
        }

        public List<Historial> LisHistorialForMoto(int id, int idcliente)
        {
            return context.Historials.Where(o => o.IdMoto == id).ToList();
        }

        public void EditarMoto(Motocicleta moto, int idcliente)
        {
            var editmoto = context.Motocicletas.Find(moto.Id);
            editmoto.EstadoMoto = moto.EstadoMoto;

            context.SaveChanges();
        }
    }
}
