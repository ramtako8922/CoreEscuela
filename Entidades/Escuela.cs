namespace CoreEscuela.Entidades
{
   public class Escuela
   {
        private string v1;
        private int v2;
        private object primaria;

        public string id { get;  private set; }
    public int añoFundacion { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }

    public string Pais { get; set; }
     public string Ciudad { get; set; }

    public TiposEscuela TipoEscuela { get; set; }
    public List<Curso> cursos { get; set; }

    public Jornada jornadas { get; set; }

    public Escuela(){

    }
    public Escuela( int año,string nombre, string direccion){
        id=Guid.NewGuid().ToString(); 
        this.añoFundacion=año;
        this.Nombre=nombre;
        this.Direccion=direccion;
    }

    public Escuela( int año,string nombre, string direccion, TiposEscuela tipo, string pais="", string ciudad="" ){
        id=Guid.NewGuid().ToString(); 
        this.añoFundacion=año;
        this.Nombre=nombre;
        this.Direccion=direccion;
        this.Pais=pais;
        this.Ciudad=ciudad;
        this.TipoEscuela=tipo;
    }

        public Escuela(string v1, int v2, object primaria, string ciudad, string pais)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.primaria = primaria;
            Ciudad = ciudad;
            Pais = pais;
        }

        public override string ToString(){

        return $"Nombre{Nombre}\nAño de fundación:{añoFundacion}\n Dirección: {Direccion}\nTipo de Escuela: {TipoEscuela}\nPais: \"{Pais}\"{System.Environment.NewLine} Ciudad: {Ciudad}";

    }
   } 
}