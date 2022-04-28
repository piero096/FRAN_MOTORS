using FranMotors.DB;
using FranMotors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FranMotors.Repositories
{

    public interface IAdminRepository
    {
        void Registrar(Account account);
        void Edit(Account account, string estado);
        List<Account> GetAllMecanicos(string buscarmeca);
    }
    public class AdminRepository : IAdminRepository
    {
        private readonly FranMotorsContext context;
        public AdminRepository(FranMotorsContext context)
        {
            this.context = context;
        }
        public void Edit(Account account, string estado)
        {
            var accounts = context.Accounts.Find(account.Id);
            accounts.Nombre = account.Nombre;
            accounts.Apellidos = account.Apellidos;
            accounts.Dni = account.Dni;
            accounts.Correo = account.Correo;
            accounts.Telefono = account.Telefono;
            if (estado == "Activo")
            {
                accounts.Estado = true;
            }
            else
            {
                accounts.Estado = false;
            }

            context.SaveChanges();
        }

        public List<Account> GetAllMecanicos(string buscarmeca)
        {
            if (!string.IsNullOrEmpty(buscarmeca))
            {
                return context.Accounts.Where(o => o.Nombre.Contains(buscarmeca) || o.Apellidos.Contains(buscarmeca)).ToList();
            }
            return context.Accounts.ToList();
        }

        public void Registrar(Account account)
        {
            account.Tipo = "Mecanico";
            account.Estado = true;
            context.Accounts.Add(account);
            context.SaveChanges();
        }
    }
}
