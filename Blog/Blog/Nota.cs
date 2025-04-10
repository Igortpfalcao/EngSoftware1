using System;

using System.Collections.Generic;
using blog;
using usuario;

namespace nota{
     public class Nota{
        
        private string _titulo;

        private string _texto;

        private DateTime _dataDeCriacao;

        private Blog _blog;

        private Usuario _dono;

        public Nota(string Titulo, string Texto, DateTime DataDeCriacao, Blog Blog, Usuario Dono){
            _titulo = Titulo;

            _texto = Texto;

            _dataDeCriacao = DataDeCriacao;

            _blog = Blog;

            _dono = Dono;
        }

        public string Titulo{
            get => _titulo;

            set => _titulo = value;
        }

        public string Texto{
            get => _texto;

            set => _texto = Texto;
        }

        public DateTime DataDeCriacao{
            get => _dataDeCriacao;
        }

        public Blog Blog{
            get => _blog;
        }
        
        public string Dono{
            get => _dono.Nome;
        }
    }   
}