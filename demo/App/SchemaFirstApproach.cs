using GraphQL;
using GraphQL.NewtonsoftJson;
using GraphQL.Types;

namespace App
{
    public class SchemaFirstApproach
    {
        public class Droid
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        public class Query
        {
            [GraphQLMetadata("droid")]
            public Droid GetDroid()
            {
                return new Droid { Id = "123", Name = "R2-D2" };
            }
        }

        public SchemaFirstApproach() { }
        public async Task GetJson()
        {
            var schema = Schema.For(@"
              type Droid {
                id: ID
                name: String
              }

              type Query {
                droid: Droid
              }
            ", _ => {
                _.Types.Include<Query>();
            });

            var json = await schema.ExecuteAsync(_ =>
            {
                _.Query = "{ droid { id name } }";
            });

            Console.WriteLine(json);
        }
    }
}
