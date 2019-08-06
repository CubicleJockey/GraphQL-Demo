using System.Collections;
using System.Collections.Generic;
using GraphQL;

namespace Console_Server.Support
{
    public class Query
    {
        [GraphQLMetadata("jedis")]
        public IEnumerable<Jedi> GetJedis() => StarWarsDatabase.GetJedis;

        [GraphQLMetadata("hello")]
        public string GetHello() => "Hello Query Class";
    }
}
