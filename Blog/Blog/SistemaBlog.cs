
using blog;
using usuario;
using nota;

namespace sistemaBlog{

    public class SistemaBlog{
        private List<Blog> blogs = new List<Blog>();
        private List<Usuario> usuarios = new List<Usuario>();
    

   public void CriarBlog(String titulo, String emailDono) {

        try{
		    Usuario dono = BuscarUsuarioPorEmail(emailDono);
            Blog novoBlog = new Blog(titulo, dono, DateTime.Now);
		    blogs.Add(novoBlog);
        }
        catch(InvalidOperationException e){
            Console.WriteLine("Erro: " + e.Message);
            
        }
	}
	
	public Usuario BuscarUsuarioPorEmail(String email) {
		foreach (Usuario usuario in usuarios) {
			if(email == usuario.Email) 
				return usuario;
		}
		throw new InvalidOperationException("Usuário não encontrado.");
	}
    

    public void CriarNota(Blog blog, Usuario usuario, string titulo, string texto){
        if (usuario == blog.Dono){
            Nota nota = new Nota(titulo, texto, DateTime.Now, blog, usuario);
            blog.notas.Add(nota);
        }
        else{
            return;
        }
    }
}
}

