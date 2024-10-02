namespace JoseCerezo_Proyecto1.Models
{
    public class Carrera
    {
        public string IdCarrera { get; set; }

        public string Nombre { get; set; }

        public Coordinador Coordinador { get; set; }
    }
}
