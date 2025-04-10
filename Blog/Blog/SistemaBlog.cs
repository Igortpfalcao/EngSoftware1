
using blog;
using usuario;

namespace sistemaBlog{

    public class SistemaBlog{
        private List<Blog> blogs = new List<Blog>();
        private List <Usuario> usuarios = new List<Usuario>();
    

   public void criarBlog(String titulo, String emailDono) {

        try{
		    Usuario dono = buscarUsuarioPorEmail(emailDono);
            Blog novoBlog = new Blog(titulo, dono, DateTime.Now);
		    blogs.Add(novoBlog);
        }
        catch(InvalidOperationException e){
            Console.WriteLine("Erro: " + e.Message);
            
        }
	}
	
	public Usuario buscarUsuarioPorEmail(String email) {
		foreach (Usuario usuario in usuarios) {
			if(email == usuario.Email) 
				return usuario;
		}
		throw new InvalidOperationException("Usuário não encontrado.");
	}
    }
}
