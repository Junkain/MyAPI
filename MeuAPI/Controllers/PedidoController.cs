using MeuAPI.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Http;
using System.Web.Http;

namespace MeuAPI.Controllers
{

    public class PedidoController : ApiController
    {
        [HttpPost]
        public HttpRequestMessage MandarFormulario(Pedido pedido)
        {
            using (SqlConnection conn = new SqlConnection("Server=tcp:junkainapi.database.windows.net,1433;Database=MeuAPI;User ID=dunada;Password=Junkain21!;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                conn.Open();
                
                using (SqlCommand cmd = new SqlCommand("INSERT INTO tbPedidos (DESCRICAO, VALORTOTAL) VALUES (@descricao, @valortotal)", conn))
                {
                    cmd.Parameters.AddWithValue("@descricao", pedido.Descricao);
                    cmd.Parameters.AddWithValue("@valortotal", pedido.ValorTotal);

                    cmd.ExecuteNonQuery();
                }
            }

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





