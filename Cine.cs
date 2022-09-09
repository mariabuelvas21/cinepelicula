public class cine{
    public static void Main(string[] args){
       
        pelicula vertigo=new pelicula();
        pelicula annabelle=new pelicula();
        pelicula american_pie=new pelicula();
       
        vertigo.setnombre("Vertigo");
        vertigo.setNaudiencia(218);
        vertigo.setclasificacion("Suspenso");
        vertigo.tostring();

        annabelle.setnombre("Annabelle");
        annabelle.setNaudiencia(313);
        annabelle.setclasificacion("Terror");
        annabelle.tostring();

        american_pie.setnombre("American Pie");
        american_pie.setNaudiencia(386);
        american_pie.setclasificacion("Risa");
        american_pie.tostring();

        Console.WriteLine("¿Cual de estas 3 es tu pelicula favorita?");
          int respuesta=Convert.ToInt32(Console.ReadLine());

        switch (respuesta){
           case 1:
            Console.WriteLine("Su pelicula favirita es Vertigo");
            break;
           case 2:
            Console.WriteLine("Su pelicula favirita es Annabelle");
            break;
           case 3:
            Console.WriteLine("Su pelicula favirita es American Pie");
            break;
        
         default: 
             Console.WriteLine("ERROR");
             break;

        }
    }
}