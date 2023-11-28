using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIPBOARD_CLASS
{
    public class CLIPBOARDRB
    {
        public class ClipboardRB<T>
        {
            private Stack<object> ms;

            public ClipboardRB()
            {
                ms = new Stack<object>();
            }
            public void Add(string input, string selected)
            {
                if (selected == "")
                {
                    ms.Push(input);
                }
                else
                {
                    ms.Push(selected);
                }
            }
            public string Paste(string result)
            {
                while (ms.Count != 0)
                {
                    string str = ms.Pop().ToString();
                    result += str;
                }
                return result;
            }
            public bool ClearStack()
            {
                ms.Clear();
                return true;
            }
            public string ClearInput(string input)
            {
                input = string.Empty;
                return input;
            }
        }
    }
}
