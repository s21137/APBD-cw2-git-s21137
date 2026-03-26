namespace cw2;

public class Camera : Equipment
{
    public int Megapixels { get; }
    public string Lens { get; }

    public Camera(string name, int megapixels, string lens) : base(name)
    {
        if (megapixels <= 0) throw new ArgumentOutOfRangeException(nameof(megapixels), "Megapiksele muszą być dodatnie  ");
        if (string.IsNullOrWhiteSpace(lens)) throw new ArgumentException("Typ obiektywu jest wymagany");
        
        Megapixels = megapixels;
        Lens = lens;
    }
}