﻿using EFcore.ValueObjects;
using System;
using System.Collections.Generic;

namespace EFcore.Domain
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime IniciadoEm { get; set; }
        public DateTime FinalizadoEm { get; set; }
        public TipoFrete TipoFrete { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public string Obersavacao { get; set; }
        public ICollection<PedidoItem> Itens { get; set; }
    }
}
