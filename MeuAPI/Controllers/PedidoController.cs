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
        public void MandarFormulario([FromBody] Pedido pedido)
        {
            if ((pedido.id) == 0)
            {
                throw new ArgumentException("Id");
            }
            if (string.IsNullOrWhiteSpace(pedido.descricao) == true)
            {
                throw new ArgumentException("Descricao");
            }
            if ((pedido.valorTotal) == 0)
            {
                throw new ArgumentException("Valor Total");
            }

            using (SqlConnection conn = new SqlConnection("Server=tcp:junkainapi.database.windows.net,1433;Database=MeuAPI;User ID=dunada;Password=Junkain21!;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                conn.Open();

                // Cria um comando para inserir um novo registro à tabela
                using (SqlCommand cmd = new SqlCommand("INSERT INTO tbPedidos (ID, DESCRICAO, VALORTOTAL) VALUES (@id, @descricao, @valortotal)", conn))
                {
                    // Esses valores poderiam vir de qualquer outro lugar, como uma TextBox...
                    cmd.Parameters.AddWithValue("@id", pedido.id);
                    cmd.Parameters.AddWithValue("@descricao", pedido.descricao);
                    cmd.Parameters.AddWithValue("@valortotal", pedido.valorTotal);
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





