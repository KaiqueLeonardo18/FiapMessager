﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Pedido
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataCriacao { get; set; }

        public Pedido(int id, Usuario usuario)
        {
            Id = id;
            Usuario = usuario;
        }

        public override string ToString()
        => $"Pedido Id: {Id}, Usuario: {Usuario.Nome}, Data de criacao: {DataCriacao:dd/MM/yyyy}";
    }
}
