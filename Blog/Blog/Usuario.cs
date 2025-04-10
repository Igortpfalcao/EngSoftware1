using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using blog;
using nota;

namespace usuario{
    public class Usuario{

        private int _id;

        private string _nome;

        private string _email;

        private string _senha;

        private List<Blog> blogs = new List<Blog>();

        public Usuario(int Id, string Nome, string Email, string Senha){
            _id = Id;
            _nome = Nome;
            _email = Email;
            _senha = Senha;
        }
        
        public int Id{
            get => _id;
        }
        public string Nome{
            get => _nome;

            set => _nome = value;
        }

        public string Email{
            get => _email;

            set => _email = value;
        }

        public string Senha{
            get => _senha;

            set => _senha = value;
        }
    }

}