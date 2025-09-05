namespace SistemaCadeteria;

public class Cadeteria
{
    public Cadeteria(string? nombre, string? direccion, string? telefono, List<Cadetes>? listadoCadetes)
    {
        Nombre = nombre;
        Direccion = direccion;
        Telefono = telefono;
        ListadoCadetes = listadoCadetes;
    }

    public string? Nombre { get; set; }
    public string? Direccion { get; set; }
    public string? Telefono { get; set; }
    public List<Cadetes>? ListadoCadetes { get; set; }

    public List<Pedidos>

}