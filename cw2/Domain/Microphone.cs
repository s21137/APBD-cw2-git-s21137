namespace cw2;

public class Microphone : Equipment
{
   
    public bool IsWireless { get; private set; }
    public int MinFrequency { get; private set; }
    public int MaxFrequency { get; private set; }

    
    
    
    public Microphone(string name, bool isWireless, int minFreq, int maxFreq) 
        : base(name)
    {
        if (minFreq <= 0 || maxFreq <= 0)
            throw new ArgumentOutOfRangeException("Częstotliwość musi być większa od 0");

        
        if (minFreq >= maxFreq)
            throw new ArgumentException("Minimalna częstotliwość musi być nizsza niż maksymalna");

        
        IsWireless = isWireless;
        MinFrequency = minFreq;
        MaxFrequency = maxFreq;
        
        
    }

    
    public string GetFrequencyRange() => $"{MinFrequency}Hz - {MaxFrequency}Hz";
    
}