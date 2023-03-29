﻿namespace Domain.Shared.Primitives.ValueObject.Base;

public abstract class ValueObject : IEquatable<ValueObject>
{
    public static bool operator ==(ValueObject left, ValueObject right)
    {
        if(left is null && right is null) return true;
        
        if(left is null || right is null) return false;

        return left.Equals(right);
    }
    public static bool operator !=(ValueObject left, ValueObject right) => !(left == right);
    public bool Equals(ValueObject? other) => !(other is null) && GetAtomicValues().SequenceEqual(other.GetAtomicValues()); 
    public override bool Equals(object? obj)
    {
        if(obj is null) return false;

        if(GetType() != obj.GetType()) return false;

        if(!(obj is ValueObject valueObject)) return false;

        return GetAtomicValues().SequenceEqual(valueObject.GetAtomicValues());
    }
    public override int GetHashCode()
    {
        HashCode hashCode = default;

        foreach(object obj in GetAtomicValues()) 
        {
            hashCode.Add(obj);
        }

        return hashCode.GetHashCode();
    }
    public abstract IEnumerable<object> GetAtomicValues();
}
