using System;
using System.Text;

namespace Entities
{
    public class MyString
    {
        StringBuilder value;
        public StringBuilder Value { get => value; set => this.value = value; }
        public MyString(string str = null)
        {
            value = new StringBuilder(str);
        }
        public MyString(StringBuilder str) : this(str.ToString()) { }
        public void Reverse()
        {
            for (int i = 0; i < Value.Length / 2; i++)
            {
                char temp = Value[i];
                Value[i] = Value[Value.Length - i - 1];
                Value[Value.Length - i - 1] = temp;
            }
        }
        public override string ToString()
        {
            return value.ToString();
        }
    }
}
