using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Attributes.Models
{
    public class Default : Attribute
    {
        public string Text { get; private set; }
        public Default (string text)
        {
            Text = text;
        }
        public Default()
        {
            Text = "(not exist)";
        }
    }
}
