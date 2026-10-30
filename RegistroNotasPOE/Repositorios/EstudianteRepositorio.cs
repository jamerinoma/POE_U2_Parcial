using System.Configuration;
using Microsoft.Data.SqlClient;
using RepoDb;
using RegistroNotasPOE.Clases;

namespace RegistroNotasPOE.Repositorios;
public sealed class EstudianteRepositorio
{
    private readonly string _cadena = ConfigurationManager.ConnectionStrings["conexionBD"]?.ConnectionString
        ?? throw new InvalidOperationException("No se encontró conexionBD en App.config.");

    
    public List<Estudiante> Listar()
    {
        using var conexion = new SqlConnection(_cadena);
        return conexion.QueryAll<Estudiante>().OrderBy(x => x.Id).ToList();
    }

    public void Agregar(Estudiante estudiante)
    {
        using var conexion = new SqlConnection(_cadena);
        conexion.Insert<Estudiante>(estudiante);
    }

    public void Actualizar(Estudiante estudiante)
    {
        using var conexion = new SqlConnection(_cadena);
        int filas = conexion.Update<Estudiante>(estudiante);
        if (filas != 1) throw new InvalidOperationException("No se encontró el estudiante para actualizar.");
    }
}
