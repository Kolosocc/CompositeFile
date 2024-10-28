using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeFile
{
    public class Section : IDocumentComponent
    {
        public string _title; 
        private List<IDocumentComponent> _components = new List<IDocumentComponent>();

        public Section(string title)
        {
            _title = title;
        }

        public void Add(IDocumentComponent component)
        {
            _components.Add(component);
            string componentType = component is Paragraph ? "Paragraph" : "Section";
            Console.WriteLine($"{componentType} добавлен в Section '{_title}'");
        }

        public void Remove(IDocumentComponent component)
        {
            if (_components.Remove(component))
            {
                string componentType = component is Paragraph ? "Paragraph" : "Section";
                Console.WriteLine($"{componentType} удален из Section '{_title}'");
            }
            else
            {
                Console.WriteLine("Указанный компонент не найден в Section.");
            }
        }

        public void Display(int depth = 0)
        {
            Console.WriteLine(new string('-', depth) + " Section: " + _title);
            foreach (var component in _components)
            {
                component.Display(depth + 2);
            }
        }
    }


}
