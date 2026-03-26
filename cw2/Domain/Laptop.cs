namespace cw2;

public class Laptop : Equipment
{
    public string Cpu { get; private set; }
    public int RamSizeGb { get; private set; }

    public Laptop(string name, string cpu, int ramSizeGb) : base(name)
    {
        if (ramSizeGb <= 0) throw new ArgumentOutOfRangeException(nameof(ramSizeGb), "RAM musi być dodatni");
        if (string.IsNullOrWhiteSpace(cpu)) throw new ArgumentException("Procesor jest wymagany");
        Cpu = cpu;
        RamSizeGb = ramSizeGb;
    }
    
    
}
