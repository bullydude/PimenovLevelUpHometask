namespace Hometask_8_DeliveryAddressBuilder
{
    class Director
    {
        public void Construct(DeliveryAddressBuilderBase builder)
        {
            builder.BuildIndex();
            builder.BuildCountry();
            builder.BuildCity();
            builder.BuildStreet();
            builder.BuildHouse();
            builder.BuildApartmentNumber();
        }
        public static void Main()
        {
            Director director = new Director();
            DeliveryAddressBuilderBase address = new DeliveryAddressBuilder();
            director.Construct(address);
            Console.WriteLine(address.GetAddress());
            Console.Read();
        }
    }
}