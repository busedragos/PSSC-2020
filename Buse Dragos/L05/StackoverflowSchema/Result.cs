using System;
using System.Collections.Generic;
using System.Text;

namespace StackoverflowSchema
{
    class Result
    {
        public interface ICreateQuest { }

        public class QuestAdd : ICreateQuest { }
        public class QuestNotAdd : ICreateQuest { }
    }
}
