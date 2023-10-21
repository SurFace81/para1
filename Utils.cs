using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace para1
{
    internal class Utils
    {
        public string getField(string line, int pos)
        {
            string field = "";

            int i = 0, cur_pos = 0;
            char[] chars = line.ToCharArray();
            while (i < chars.Length)
            {
                if (chars[i] == '\t')
                {
                    if (cur_pos == pos)
                        return field;
                    cur_pos += 1;
                    field = "";
                }
                else
                {
                    field += chars[i];
                }
                i += 1;
            }

            return field;
        }

        public bool isDigit(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if ('0' > chars[i] || '9' < chars[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
