using System.Collections.Generic;

namespace PROG_KURS
{
    public class Element
    {
        public List<string> Field = new List<string>();
        public string Name;
        public string Tag;

        private int MaxChar;

        public Element(string Name)
        {
            this.Name = Name;
            MaxChar = Name.Length;
        }

        public int Max()
        {
            Showing();
            return MaxChar;
        }

        private void Showing()
        {
            foreach (var field in Field)            
                if (field.Length > MaxChar)
                    MaxChar = field.Length;            
        }
    }
}
