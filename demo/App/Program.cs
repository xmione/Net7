using GraphQL;

namespace App
{
    public class Program
    {
        static void Main(string[] args)
        {
            var helloWorld = new HelloWorld();
            helloWorld.GetJson().Wait();

            var schemaFirstApproach = new SchemaFirstApproach();
            schemaFirstApproach.GetJson().Wait();

            var param = new Parameters();
            param.GetJson().Wait();

        }

    }
}