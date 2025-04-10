using System;

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using nota;
using usuario;



namespace comentario{
    public class Comentario{

        private string _texto;

        private DateTime _dataDeCriacao;

        private Nota _nota;

        private Usuario _autor;

        public Comentario(string Titulo, string Texto, DateTime DataDeCriacao, Nota Nota, Usuario Autor){

            _texto = Texto;

            _dataDeCriacao = DataDeCriacao;

            _nota = Nota;

            _autor = Autor;
        }

        public string Texto{
            get => _texto;

            set => _texto = Texto;
        }

        public DateTime DataDeCriacao{
            get => _dataDeCriacao;
        }

        public Nota Nota{
            get => _nota;
        }
        
        public string Autor{
            get => _autor.Nome;
        }
    }   
}