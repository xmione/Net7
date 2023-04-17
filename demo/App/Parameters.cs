using GraphQL;
using GraphQL.NewtonsoftJson;
using GraphQL.Types;

namespace App
{
    public class Parameters
    {

        public class Droid
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        public class Query
        {
            private List<Droid> _droids = new List<Droid>
            {
                new Droid { Id = "123", Name = "R2-D2" }
            };

            [GraphQLMetadata("droid")]
            public Droid GetDroid(string id)
            {
                return _droids.FirstOrDefault(x => x.Id == id);
            }
        }

        public Parameters() { }
        public async Task GetJson()
        {

            var schema = Schema.For(@"
              type Droid {
                id: ID
                name: String
              }

              type Query {
                droid(id: ID): Droid
              }
            ", _ => {
                _.Types.Include<Query>();
            });

            var json = await schema.ExecuteAsync(_ =>
            {
                _.Query = $"{{ droid(id: \"123\") {{ id name }} }}";
            });

            Console.WriteLine(json);
        }
    }
}
