using Primitives.IO;
using StackoverflowSchema;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;



namespace StackoverflowCore
{
    public class Core
    {
        public static Port<ICreateQuest> CreateQuest(string titlu, string intrebare, string tag) => NewPort<CMD, ICreateQuest>(new CMD(titlu, intrebare, tag));
    }
}
