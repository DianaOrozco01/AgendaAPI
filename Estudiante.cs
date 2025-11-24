namespace AgendaAPI.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Carrera { get; set; }
        public string Universidad { get; set; }
        public DateTime FechaCreado { get; set; } = DateTime.Now;
    }
}