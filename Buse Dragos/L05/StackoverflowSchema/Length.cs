using System;
using System.Collections.Generic;
using System.Text;
using LanguageExt.Common;

namespace StackoverflowSchema
{
    class Length
    {
        public string Text { get; }
        public Length(string text)
        {
            Text = text;
        }
        public static Result<Length> Create(string text)
        {
            if (text.Length < 1000)
            {
                return new Length(text);
            }
            else
            {
                return new Result<Length>(new ArgumentException());
            }
        }
    }
}
