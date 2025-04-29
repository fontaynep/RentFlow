namespace RentFlow.Models
    {
    public class Property
        {
        public required int Id
            {
            get; set;
            }
        public required string Address
            {
            get; set;
            }
        public required string City
            {
            get; set;
            }
        public required string State
            {
            get; set;
            }
        public required string Zip
            {
            get; set;
            }
        public required decimal MonthlyRent
            {
            get; set;
            }
        public required string? Notes
            {
            get; set;
            }
        }
    }
