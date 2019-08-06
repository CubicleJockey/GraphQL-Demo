﻿using System;
using GraphQL;
using GraphQL.Types;

namespace Console_Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var schema = Schema.For(@"
                    type Query{
                        hello: String
                    }");

            var root = new { Hello = "Hello World!" };

            var json = schema.Execute(_ =>
            {
                _.Query = "{ hello }";
                _.Root = root;
            });

            Console.WriteLine(json);
        }
    }
}
