using MeuAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;

namespace MeuAPI.Controllers
{

    public class PedidoController : ApiController
    {
        [HttpPost]
        public void MandarFormulario([FromBody] string Descricao, [FromBody] double ValorTotal)
        {
           
            using (SqlConnection conn = new SqlConnection("Server=tcp:junkainapi.database.windows.net,1433;Database=MeuAPI;User ID=dunada;Password=Junkain21!;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                conn.Open();

                // Cria um comando para inserir um novo registro à tabela
                using (SqlCommand cmd = new SqlCommand("INSERT INTO tbPedidos (DESCRICAO, VALORTOTAL) VALUES ( @descricao, @valortotal)", conn))
                {
                    cmd.Parameters.AddWithValue("@descricao", Descricao);
                    cmd.Parameters.AddWithValue("@valortotal", ValorTotal);
                    cmd.ExecuteNonQuery();
                }
            }


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





