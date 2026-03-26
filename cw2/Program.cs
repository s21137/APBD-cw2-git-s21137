using cw2;

class Program
{
    static void Main(string[] args)
    {
        
        var loanService = new LoanService();
        var laptop = new Laptop("Dell 123", "i7-12700H", 32);
        var mic = new Microphone("Shure 1221", false, 500, 20000);
        var camera = new Camera("Sony ABC", 33, "FE 2470");
        var secondaryLaptop = new Laptop("MacBook Air", "M2", 8);
        
        var student = new Student("Jan", "Kowal", "S12345");
        var employee = new Employee("dr Anna", "Nowak", "Katedra Nowe  media");
        
        
        
        
        
    }
}