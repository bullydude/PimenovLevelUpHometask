namespace Hometask_8_DeliveryAddressBuilder
{
    internal class DeliveryAddress
    {
        public string Index { get; set; } 

        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string House { get; set; }

        public string ApartmentNumber { get; set; }

        public override string ToString() =>
            $"Индекс: {Index}, страна: {Country}, город: {City}, {Street}, номер дома: {House}, номер квартиры: {ApartmentNumber}";
    }
}
