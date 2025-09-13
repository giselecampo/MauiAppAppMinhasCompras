﻿using Microsoft.UI.Composition.Interactions;
using SQLite;

namespace MauiAppAppMinhasCompras.Models
{
    public class Produto
    {
        string _descricao;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao {
            get => _descricao;
            set 
            {
                if(value == null) 
                {
                    throw new Exception("Descrição é obrigatória");
                }
                _descricao = value;
            }
        }
        public double Quantidade { get; set; }
        public double Preco {  get; set; }
        public double Total { get => Quantidade * Preco; }



    }
}
