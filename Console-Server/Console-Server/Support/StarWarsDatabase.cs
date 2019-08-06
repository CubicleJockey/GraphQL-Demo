using System.Collections;
using System.Collections.Generic;

namespace Console_Server.Support
{
    public static class StarWarsDatabase
    {
        public static IEnumerable<Jedi> GetJedis => new[]
        {
            new Jedi {Name ="Luke", Side = "Light"},
            new Jedi {Name ="Yoda", Side = "Light"},
            new Jedi {Name ="Darth Vader", Side = "Dark"}
        };
    }
}
