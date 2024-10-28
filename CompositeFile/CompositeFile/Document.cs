using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeFile
{
    public class Document : IDocumentComponent
    {
        private string _title;
        private List<IDocumentComponent> _sections = new List<IDocumentComponent>();

        public Document(string title)
        {
            _title = title;
        }

        public void Add(IDocumentComponent component)
        {
            _sections.Add(component);
        }

        public void Remove(IDocumentComponent component)
        {
            _sections.Remove(component);
        }

        public void Display(int depth = 0)
        {
            Console.WriteLine(new string('-', depth) + " Document: " + _title);
            foreach (var section in _sections)
            {
                section.Display(depth + 2);
            }
        }
    }

}
