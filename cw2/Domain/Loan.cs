namespace cw2;

public class Loan
{
    public Guid Id { get; }
    public User Borrower { get; }
    public Equipment LoanedItem { get; }
    public DateTime StartDate { get; }
    public DateTime ExpectedReturnDate { get; }
    public DateTime? ActualReturnDate { get; private set; }
    public decimal Penalty { get; private set; }

    public Loan(User borrower, Equipment item, int durationDays)
    {
        if (borrower == null) throw new ArgumentNullException(nameof(borrower));
        if (item == null) throw new ArgumentNullException(nameof(item));
        if (durationDays <= 0) throw new ArgumentException("Okres  wypożyczenia musi być dodatni");

        Id = Guid.NewGuid();
        Borrower = borrower;
        LoanedItem = item;
        StartDate = DateTime.Now;
        ExpectedReturnDate = StartDate.AddDays(durationDays);
        Penalty = 0;
    }

    public bool IsActive => ActualReturnDate == null;

    public void Settle(DateTime returnDate, decimal calculatedPenalty)
    {
        if (returnDate < StartDate) 
            throw new ArgumentException("Data zwrotu nioe może być wcześniejsza niz data wypozyczenia");
            
        ActualReturnDate = returnDate;
        Penalty = calculatedPenalty;
    }
}