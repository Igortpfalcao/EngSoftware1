
using blog;
using usuario;
using nota;
using System.Data.Common;

namespace sistemaBlog{

    public class SistemaBlog{
        private List<Blog> blogs = new List<Blog>();
        private List<Usuario> usuarios = new List<Usuario>();
    

    public void CriarBlog(String titulo, String emailDono) {

            try{
                Usuario dono = BuscarUsuarioPorEmail(emailDono);
                int blogId = 999;
                Blog novoBlog = new Blog(titulo, dono, DateTime.Now, blogId);
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

        public Blog BuscarBlogPorId(int Id){
            foreach (Blog blog in blogs){
                if(blog.Id == Id){
                    return blog;
                }
            }
            throw new InvalidOperationException("Blog não encontrado");
        }
        

        public void CriarNota(Usuario usuario, string titulo, string texto, int IdBlog){
            try{
            Blog blog = BuscarBlogPorId(IdBlog);
            if (usuario == blog.Dono){
                Nota nota = new Nota(titulo, texto, DateTime.Now, blog, usuario);
                blog.notas.Add(nota);
            }
            else{
                return;
            }
            }
            catch(InvalidOperationException e){
                Console.WriteLine("Erro: " + e.Message);
                
            }
        }
        public List<string> ObterTextosNotas(int idBlog){ 
            try{
                Blog blog = BuscarBlogPorId(idBlog);
                List<Nota> notas = blog.GetNotas();
                List<string> textos = new List<string>();

                foreach (Nota nota in notas){
                    textos.Add(nota.Texto);
                }
                return textos;   
            }
            catch(InvalidOperationException e){
                Console.WriteLine("Erro: " + e.Message);
                return new List<string>();
            }
        } 
    }
}

