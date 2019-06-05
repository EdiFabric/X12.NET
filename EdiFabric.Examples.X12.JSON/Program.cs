namespace EdiFabric.Examples.X12.JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Serialize to JSON
            SerializeToJson.Run();

            //  Deserialize from JSON
            DeserializeFromJson.Run();
        }
    }
}
