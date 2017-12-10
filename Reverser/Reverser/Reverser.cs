using System;
using System.Text;

namespace Reverser
{
    public class Reverser
    {
        public string Reverse(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }

            var lines = value.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            var result = new StringBuilder();
            for (var i = lines.Length - 1; i > 0; i--)
            {
                result.Append($"{lines[i]}\r\n");
            }

            result.Append(lines[0]);
            return result.ToString();
        }
    }
}
