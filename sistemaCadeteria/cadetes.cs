using System.Data.Common;

namespace SistemaCadeteria;

public class Cadetes
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Direccion { get; set; }
    public string? Telefono { get; set; }
    public List<Pedidos>? listadoPedidos { get; set; }

    public Cadetes(int id, string? nombre, string? direccion, string? telefono, List<Pedidos>? listadoPedidos)
    {
        Id = id;
        Nombre = nombre;
        Direccion = direccion;
        Telefono = telefono;
        this.listadoPedidos = listadoPedidos;
    }
}