using System;
using Console_Server.Support;
using GraphQL;
using GraphQL.Types;

namespace Console_Server
{
    public class Program
    {
        public static void Main()
        {
            var schema = Schema.For(@"
                    type Jedi{
                        name: String,
                        side: String
                    }

                    type Query{
                        hello: String,
                        jedis: [Jedi]
                    }", _ =>
            {
                _.Types.Include<Query>();
            });

            var root = new { Hello = "Hello World!" };

            var helloJson = schema.Execute(_ =>
            {
                _.Query = "{ hello }";
                _.Root = root;
            });

            Console.WriteLine(helloJson);
            Console.WriteLine();


            var jediJson = schema.Execute(_ => { _.Query = "{ jedis { name, side } }"; });
            Console.WriteLine(jediJson);
        }
    }
}
