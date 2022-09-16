namespace Hometask_8_DeliveryAddressBuilder
{
    internal class DeliveryAddressBuilder : DeliveryAddressBuilderBase
    {
        public DeliveryAddressBuilder()
        {
            _deliveryAddress = new DeliveryAddress();
        }
        public override void BuildIndex()
        {
            var index = DataCheck.CheckInt("индекс");
            _deliveryAddress.Index = index;
        }
        public override void BuildCountry()
        {
            var country = DataCheck.Check("страну");
            _deliveryAddress.Country = country;
        }
        public override void BuildCity()
        {
            var city = DataCheck.Check("город");
            _deliveryAddress.City = city;
        }
        public override void BuildStreet()
        {
            var street = DataCheck.Check("улицу");
            _deliveryAddress.Street = street;
        }
        public override void BuildHouse()
        {
            var house = DataCheck.CheckInt("номер дома");
            _deliveryAddress.House = house;
        }
        public override void BuildApartmentNumber()
        {
            var apartmentNumber = DataCheck.CheckInt("номер квартиры");

            _deliveryAddress.ApartmentNumber = apartmentNumber;
        }
    }
}
