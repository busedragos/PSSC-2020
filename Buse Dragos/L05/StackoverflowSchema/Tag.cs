using System;
using System.Collections.Generic;
using System.Text;

namespace StackoverflowSchema
{
    class Tag
    {
        public string Tagg { get; }
        private Tag(string tag)
        {
            Tagg = tag;
        }
    }
}
