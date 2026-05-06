using Directorio.Data;
using Microsoft.EntityFrameworkCore;

namespace practica1.Components.Data
{
    public class DirectorioDBContext(DbContextOptions<DirectorioDBContext>options): DbContext(options){
        public DbSet<Persona>Personas { get; set; }
    }
}