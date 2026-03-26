namespace cw2;

public class LoanService
{
    private readonly List<Loan> _loans = new();
    
    private int GetLimit(User user) => user switch {
        Student => 2,
        Employee => 5,
        _ => throw new ArgumentException("Nieobsługiwany typ użytkownika!")
    };

    private decimal CalculatePenalty(Loan loan, DateTime returnDate) {
        if (returnDate <= loan.ExpectedReturnDate) return 0;
        return (returnDate - loan.ExpectedReturnDate).Days * 15.00m;
    }

    
    public void Rent(User user, Equipment item, int days)
    {
        if (!item.IsAvailable) throw new InvalidOperationException("Sprzęt zajęty");

        int activeCount = _loans.Count(l => l.Borrower.Id == user.Id && l.IsActive);
        if (activeCount >= GetLimit(user)) throw new InvalidOperationException("Limit przekroczony");

        var loan = new Loan(user, item, days);
        item.ChangeStatus(EquipmentStatus.Rented);
        _loans.Add(loan);
    }

    public void Return(Guid loanId, DateTime? simulatedDate = null)
    {
        var loan = _loans.FirstOrDefault(l => l.Id == loanId && l.IsActive);
        if (loan == null) throw new Exception("Nie znaleziono wypożyczenia");

        var date = simulatedDate ?? DateTime.Now;
        loan.Settle(date, CalculatePenalty(loan, date));
        loan.LoanedItem.ChangeStatus(EquipmentStatus.Available);
    }

    public List<Loan> GetAll() => _loans;
}