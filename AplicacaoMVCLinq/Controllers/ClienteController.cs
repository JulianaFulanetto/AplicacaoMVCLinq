using AplicacaoMVCLinq.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoMVCLinq.Controllers

{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetClientes()
        {
            Cliente c1 = new Cliente(1, "Alice", "alice@example.com", "1234-5678", new DateOnly(2000, 6, 1));
            Cliente c2 = new Cliente(2, "Juliana", "juju@example.com", "1234-5678", new DateOnly(2008, 1, 15));
            Cliente c3 = new Cliente(3, "Kaléu", "kaleu@example.com", "1234-5678", new DateOnly(2006, 1, 5));
            Cliente c4 = new Cliente(4, "Lorena", "lorena@example.com", "1234-5678", new DateOnly(2008, 2, 12));
            Cliente c5 = new Cliente(5, "Maysa", "maysa@example.com", "1234-5678", new DateOnly(2008, 6, 7));

            List<Cliente> listaCliente = new List<Cliente>();
            //Adicionando os obj alunos na lista alunos 
            listaCliente.Add(c1);
            listaCliente.Add(c2);
            listaCliente.Add(c3);
            listaCliente.Add(c4);
            listaCliente.Add(c5);

            return View(listaCliente);
        }
    }
}
