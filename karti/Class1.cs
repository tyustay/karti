using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LinqFaroShuffle;

namespace karti

{
    public static class Extensions
    {
        public static IEnumerable<T> LogQuery<T>
        (this IEnumerable<T> sequence, string tag)
        {
            // File.AppendText creates a new file if the file doesn't exist.
            using (var writer = File.AppendText("debug.log"))
            {
                writer.WriteLine($"Executing Query {tag}");
            }
            return sequence;
        }
    }
}
