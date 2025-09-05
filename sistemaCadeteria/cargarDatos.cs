namespace SistemaCadeteria;

public class cargarDatos
{
    public List<Cadeteria> cargarCadeteria(string? nombreArchivo)
    {
        List<Cadeteria> cadeterias = new List<Cadeteria>();
        if (!File.Exists(nombreArchivo))
        {
            return cadeterias;
        }

        string[] lineas = File.ReadAllLines(nombreArchivo);
        lineas = lineas.Skip(1).ToArray();
        int cantidadFilas = lineas.Length;

        for (int i = 0; i < cantidadFilas; i++)
        {
            var campos = lineas[i].Split(',');
            string nombre = campos[1];
            string direccion = campos[2];
            string telefono = campos[3];

            Cadeteria cadeteria = new Cadeteria(nombre, direccion, telefono, null);

            cadeterias.Add(cadeteria);
        }


        return cadeterias;
    }

    
    public List<Cadetes> cargarCadetes(string? nombreArchivo)
    {
        List<Cadetes> listaCadetes = new List<Cadetes>();
        if (!File.Exists(nombreArchivo))
        {
            return listaCadetes;
        }

        string[] lineas = File.ReadAllLines(nombreArchivo);
        lineas = lineas.Skip(1).ToArray();
        int cantidadFilas = lineas.Length;

        for (int i = 0; i < cantidadFilas; i++)
        {
            var campos = lineas[i].Split(',');
            string nombre = campos[2];
            string direccion = campos[3];
            string telefono = campos[4];

            Cadetes cadete = new Cadetes(i+1,nombre, direccion, telefono, null);
            
            listaCadetes.Add(cadete);
        }
        

        return listaCadetes;
    }
        
    }