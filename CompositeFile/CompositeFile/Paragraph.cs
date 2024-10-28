using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeFile
{
    public class Paragraph : IDocumentComponent
    {
        private string _text;

        public Paragraph(string text)
        {
            _text = text;
        }

        public void Add(IDocumentComponent component)
        {
            return;  
        }

        public void Remove(IDocumentComponent component)
        {
            return;
        }

        public void Display(int depth = 0)
        {
            Console.WriteLine(new string('-', depth) + " " + _text);
        }
    }

}
