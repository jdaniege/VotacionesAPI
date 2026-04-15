// Importa los espacios de nombres necesarios para el controlador
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VotacionesAPI.Data;
using VotacionesAPI.Models;

namespace VotacionesAPI.Controllers;

// Indica que esta clase es un controlador de API y define la ruta base
[ApiController]
[Route("api/[controller]")]
public class VotosController : ControllerBase
{
    // Contexto de base de datos para acceder a los votos
    private readonly AppDbContext _context;

    // Constructor que recibe el contexto de base de datos
    public VotosController(AppDbContext context)
    {
        _context = context;
    }

    // Método GET: obtiene la lista de votos
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        // Devuelve la lista de votos como respuesta
        return Ok(await _context.Votos.ToListAsync());
    }

    // Método POST: agrega un nuevo voto
    [HttpPost]
    public async Task<IActionResult> Post(Voto voto)
    {
        // Agrega el voto recibido al contexto
        _context.Votos.Add(voto);
        // Guarda los cambios en la base de datos
        await _context.SaveChangesAsync();
        // Devuelve el voto agregado como respuesta
        return Ok(voto);
    }
}