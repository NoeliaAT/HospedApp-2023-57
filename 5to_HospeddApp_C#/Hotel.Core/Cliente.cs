namespace HotelApp.Core;

public class Cliente{
    public ushort IdCliente;
    public string Nombre;
    public string Apellido;
    public string Email;
    public string Contraseña;
    public Cliente (ushort IdCliente, string Nombre, string Apellido, string Email, string Contraseña){
        this.IdCliente = IdCliente;
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.Email = Email;
        this.Contraseña = Contraseña;
    }
}