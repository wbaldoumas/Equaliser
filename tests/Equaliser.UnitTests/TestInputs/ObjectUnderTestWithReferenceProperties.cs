using System;
using Equaliser.Attributes;

namespace Equaliser.UnitTests.TestInputs;

public class ObjectUnderTestWithReferenceProperties : IEquatable<ObjectUnderTestWithReferenceProperties>
{
    public int Property1 { get; set; }
    public string Property2 { get; set; }
    [CompareByReference]
    public ChildObject Property3 { get; set; }
    
    public bool Equals(ObjectUnderTestWithReferenceProperties other)
    {
        return Property1.Equals(other.Property1)
               && Property2.Equals(other.Property2)
               && ReferenceEquals(Property3, other.Property3);
    }
}