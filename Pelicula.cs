public class pelicula{
  string clasificacion="",nombre="";
  int Naudiencia;
  public string getnombre(){
    return this.nombre;
  }
  public void setnombre(string nombre){
    this.nombre=nombre;
  }
  public string getclasificacion(){
    return this.clasificacion;
  }
  public void setclasificacion(string clasificacion){
    this.clasificacion=clasificacion;
  }
  public int getNaudiencia(){
    return this.Naudiencia;
  }
  public void setNaudiencia(int Naudiencia){
    this.Naudiencia=Naudiencia;
  }
  public void tostring(){

    Console.WriteLine("La pelicula "+this.nombre+" de clasificacion "+this.clasificacion+" tiene "+this.Naudiencia+" asistentes");
  }
}
