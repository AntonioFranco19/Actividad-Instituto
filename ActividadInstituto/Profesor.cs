namespace ActividadInstituto;

public class Profesor(string nif, string nombre, string telefono, string direccion, string email)
{
    public string Nif { get; } = nif;
    public string Nombre { get; } = nombre;

    public string Telefono { get; } = telefono;

    public string Direccion { get; } = direccion;
    public string Email { get; } = email;
}