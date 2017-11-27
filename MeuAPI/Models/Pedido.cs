using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MeuAPI.Models
{
    public class Pedido 
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double ValorTotal { get; set; }

    }
}