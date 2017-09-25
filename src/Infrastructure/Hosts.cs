using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastHosts.Infrastructure
{
    sealed class Hosts
    {
        public static string Path { get; }

        static Hosts()
        {
            Path = System.IO.Path.Combine(Environment.SystemDirectory, "drivers", "etc", "hosts");
        }

        public IEnumerable<(int i, bool enabled, string line)> Read()
        {
            if (!File.Exists(Path)) throw new FileNotFoundException(Path);

            int lineCnt = 0;
            using (var reader = new StreamReader(Path))
            {
                while (reader.Peek() > 0)
                {
                    lineCnt++;
                    var line = reader.ReadLine();
                    yield return (i: lineCnt, enabled: true, line: line);
                }
            }
        }
    }
}
