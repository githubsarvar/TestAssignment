namespace TestAssignment.Infrastructure;


public abstract class EntityBase : IEquatable<EntityBase>
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; set; }


    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is EntityBase other))
        {
            return false;
        }

        return Equals(other);
    }

    public bool Equals(EntityBase other) => (other == null) ? false : (Id == other.Id);
    public static bool operator ==(EntityBase first, EntityBase secound) => first is not null && secound is not null && first.Equals(secound);
    public static bool operator !=(EntityBase first, EntityBase secound) => !(first == secound);
    public override int GetHashCode() => Id.GetHashCode();
}
