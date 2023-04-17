using GraphQL;
using GraphQL.NewtonsoftJson;
using GraphQL.Types;

namespace App
{
    public class HelloWorld
    {
        public HelloWorld() { }
        public async Task GetJson()
        {
            var schema = Schema.For(@"
              type Query {
                hello: String
              }
            ");

            var root = new { Hello = "Hello World!" };
            var json = await schema.ExecuteAsync(_ =>
            {
                _.Query = "{ hello }";
                _.Root = root;
            });

            Console.WriteLine(json);
        }
    }
}
