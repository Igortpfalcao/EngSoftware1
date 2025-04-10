using System;

using System.Collections.Generic;
using nota;
using usuario;

namespace blog{
    public class Blog{
        private string _titulo;

        private Usuario _dono;

        private DateTime _dataDeCriacao;

        private List<Nota> notas = new List<Nota>();

        public Blog(string Titulo, Usuario Dono, DateTime DataDeCriacao){
            _titulo = Titulo;

            _dono = Dono;

            _dataDeCriacao = DataDeCriacao;
        }

        public string Titulo{
            get => _titulo;
            set => _titulo = value;
        }

        public Usuario Dono{
            get => _dono;
            set => _dono = value;
        }

        public DateTime DataDeCriacao{
            get => _dataDeCriacao;
        }
    }
}