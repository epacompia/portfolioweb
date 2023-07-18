using Portfolio.Models;

namespace Portfolio.Servicios
{



    //definiendo una interfaz
    public interface IRepositorioProyectos
    {
        List<Proyecto> obtenerProyectos();
    }





    public class RepositorioProyectos:IRepositorioProyectos
    {

        
        public List<Proyecto> obtenerProyectos()
        {
            return new List<Proyecto>() {

                new Proyecto
            {
                Titulo= "Libro de Reclamaciones virtual",
                Descripcion="Proyecto implementado en la DIRCOCOR en lenguaje",
                Link= "https://librodereclamaciones.dircocor.com/",
                ImagenURL="/imagenes/libroreclamaciones.jpg"

            },
            new Proyecto
            {
                Titulo= "Sistema de inventarios DIRCOCOR",
                Descripcion="Proyecto implementado en la DIRCOCOR en lenguaje JAVA WEB",
                Link= "https://librodereclamaciones.dircocor.com/",
                ImagenURL="/imagenes/inventarios.jpg"

            },

            new Proyecto
            {
                Titulo= "Portafolio personal de presentación",
                Descripcion="Proyecto donde demuestro mis skills",
                Link= "https://librodereclamaciones.dircocor.com/",
                ImagenURL="/imagenes/personal.jpg"

            },

            };
        }



    }
}
