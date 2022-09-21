namespace DesafioPOO.Models
{
  public abstract class Smartphone
  {
    public string Numero { get; set; }
    private string Modelo { get; set; }
    private string IMEI { get; set; }
    private int Memoria { get; set; }
    public Smartphone(string numero)
    {
      Numero = numero;
      // TODO: Passar os parâmetros do construtor para as propriedades
    }

    public Smartphone() {}

    public void Ligar()
    {
      Console.WriteLine("Ligando...");
    }

    public void ReceberLigacao()
    {
      Console.WriteLine("Recebendo ligação...");
    }

    public abstract void InstalarAplicativo(string nomeApp);
  }
}