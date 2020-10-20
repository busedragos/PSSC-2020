using System;
using System.ComponentModel.DataAnnotations;

namespace StackoverflowSchema
{
    public class CMD
    {
        public CMD(string titlu, string intrebare, string tag)
        {
            Titlu = titlu;
            Intrebare = intrebare;
            Tag = tag;
        }
        [Required]
        public string Titlu { get; }
        [Required]
        public string Intrebare { get; }
        [Required]
        public string Tag
        {
            get;
        }
    }
}
