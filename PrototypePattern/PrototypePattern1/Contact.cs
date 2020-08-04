using System;

namespace PrototypePattern1
{
    [Serializable]
    public class Contact
    {
        public string Name { get; set; }
        public Address WorkAddress { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, WorkAddress: {WorkAddress}";
        }
    }
    
    [Serializable]
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public int Suite { get; set; }

        public override string ToString()
        {
            return $"Street: {Street}, City: {City}, Suite: {Suite}";
        }
    }
}
