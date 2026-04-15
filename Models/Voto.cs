// Define el espacio de nombres para los modelos
namespace VotacionesAPI.Models;

// Clase que representa un voto
public class Voto 
{
    // Identificador único del voto
    public int Id { get; set; }
    // Nombre del candidato votado
    public string Candidato { get; set; }
    // Cédula del votante
    public string Cedula { get; set; }
    // Fecha y hora en que se realizó el voto
    public DateTime Fecha { get; set; } = DateTime.Now;
}