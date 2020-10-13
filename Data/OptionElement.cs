using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppSelectMultiple.Data
{
    public class OptionElement
    {
        public int Value { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public static List<OptionElement> GetElements()
        {
            List<OptionElement> optionElements = new List<OptionElement>();
            optionElements.Add(new OptionElement() { Value = 1, Name = "Madrid", Active = true });
            optionElements.Add(new OptionElement() { Value = 2, Name = "Paris", Active = true });
            optionElements.Add(new OptionElement() { Value = 3, Name = "Berlin", Active = true });
            optionElements.Add(new OptionElement() { Value = 4, Name = "London", Active = true });
            optionElements.Add(new OptionElement() { Value = 5, Name = "Rome", Active = true });

            return optionElements.OrderBy(x => x.Name).ToList();
        }
    }
}
