using MeuAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MeuAPI.Controllers
{

    public class PedidoController : ApiController
    {
        [HttpPost]
        public HttpRequestMessage MandarFormulario(Pedido pedido)
        {


            

            return null;
        }

        [HttpGet]
        public List<Pedido> ObterPedidos()
        {
            Pedido p;

            List<Pedido> pedidos = new List<Pedido>();

            p = new Pedido();

            p.Id = 1;
            p.Descricao = "Coxinha";
            p.ValorTotal = 3.15;
            pedidos.Add(p);

            p = new Pedido();

            p.Id = 2;
            p.Descricao = "Hamburgão";
            p.ValorTotal = 5.00;
            pedidos.Add(p);

            p = new Pedido();

            p.Id = 3;
            p.Descricao = "Esiha";
            p.ValorTotal = 4.00;
            pedidos.Add(p);

            return pedidos;

        }
    }
}





