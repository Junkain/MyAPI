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

        [HttpGet]
        public List<Pedido> ObterPedidos()
        {
            Pedido p;

            List<Pedido> pedidos = new List<Pedido>();

            p = new Pedido();

            p.id = 1;
            p.descricao = "Coxinha";
            p.valorTotal = 3.15;
            pedidos.Add(p);

            p = new Pedido();

            p.id = 2;
            p.descricao = "Hamburgão";
            p.valorTotal = 5.00;
            pedidos.Add(p);

            p = new Pedido();

            p.id = 3;
            p.descricao = "Esiha";
            p.valorTotal = 4.00;
            pedidos.Add(p);

            return pedidos;

        }
    }
}





