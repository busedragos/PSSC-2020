using LanguageExt.Common;
using Nest;
using Primitives.IO;
using StackoverflowSchema;
using System;
using System.Threading.Tasks;


namespace StackoverflowAdapter
{
    public class Adapter: Adapter<CMD, Result>
    {
        public override Task PostConditions(CMD cmd, Result result, object state)
        {
            throw new NotImplementedException();
        }
        public override async Task<Result>Work(CMD cmd, object state)
        {
            throw new NotFiniteNumberException();
        }
    }
}
