namespace SistemaCadeteria;

public class Pedidos
{
    public int? NroPedido { get; set; }
    public string? observacion { get; set; }
    public Cliente? cliente { get; set; }
    public string? Estado { get; set; }
    public Pedidos(int nroPedido, string? observacion, Cliente? cliente, string? estado)
    {
        NroPedido = nroPedido;
        this.observacion = observacion;
        this.cliente = cliente;
        Estado = estado;
    }

    /* public string VerDireccionCliente(List<Cliente> clientes, string? nombreCliente) {

        string? direccion = "No se encontro la direccion";
        foreach (var cliente in clientes)
        {
            if (cliente.Nombre1 == nombreCliente)
            {
                direccion = cliente?.Direccion1;
            }
        }

        return direccion;
    }
     */
}