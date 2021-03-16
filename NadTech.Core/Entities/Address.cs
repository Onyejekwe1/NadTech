namespace NadTech.Core.Entities
{
    public class Address : BaseEntity
    {
        public new int Id { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public int HouseNumber { get; set; }    
    }
}
