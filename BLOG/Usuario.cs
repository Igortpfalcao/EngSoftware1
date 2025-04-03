using System;
using System.Collections.Generic;



public class Usuario{

    private string _nome;

    private string _email;

    private string _senha;

    private List<Blog> blogs = new List<Blog>();

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