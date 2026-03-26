namespace cw2;

public abstract class Equipment
{
    public Guid Id { get; }
    public string Name { get; private set; }
    public EquipmentStatus Status { get; private set; }

    protected Equipment(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Nazwa nie może być pusta");
            
        Id = Guid.NewGuid();
        Name = name;
        Status = EquipmentStatus.Available;
    }

    public bool IsAvailable => Status == EquipmentStatus.Available;

    public void ChangeStatus(EquipmentStatus newStatus) => Status = newStatus;
}