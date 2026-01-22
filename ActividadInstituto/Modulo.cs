namespace ActividadInstituto;

public class Modulo(string? id, string? nombre, int horas = 5)
{
    public string? Id { get; private set; } = id;
    public string? Nombre { get; private set; } = nombre;
    public int Horas { get; private set; } = horas;
    public Profesor? Profesor { get; private set; }

    /*public void AgregarProfesor(Profesor prof)
    {
        this.Profesor = prof;
    }*/
    
}