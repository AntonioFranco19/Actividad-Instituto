namespace ActividadInstituto;

public class Alumno
{
    public string? Nif { get; private set; }
    public string? Nombre { get; private set; }
    public string? Telefono { get; private set; }
    public string? Direccion { get; private set; }
    public string? Email { get; private set; }
    public CicloFormativo CicloMatriculado { get; private set; }

    public Alumno(string? nif, string? nombre, string? telefono, string? direccion, string? email, CicloFormativo ciclo)
    {
        Nif = nif;
        Nombre = nombre;
        Telefono = telefono;
        Direccion = direccion;
        Email = email;
        CicloMatriculado = ciclo;
    }

    public override string ToString()
    {
        return $" Nombre: {this.Nombre} NIF: {Nif}, Telefono {Telefono}, Dirección: {Direccion}, Email: {Email}, Ciclo Matriculado: {CicloMatriculado.Nombre}.";
    }
}