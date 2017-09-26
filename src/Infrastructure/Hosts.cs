using FastHosts.Infrastructure.Ext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastHosts.Infrastructure
{
    sealed class Host
    {
        public int I { get; }
        public string Value { get; }
        public bool IsEnabled => Value.StartsWith("#", StringComparison.OrdinalIgnoreCase);
        public bool IsIp => Value.CountChar('.') >= 3;

        public Host(int i, string value)
        {
            I = i;
            Value = value;
        }
    }

    sealed class Hosts
    {
        public static string Path { get; }

        static Hosts()
        {
            Path = System.IO.Path.Combine(Environment.SystemDirectory, "drivers", "etc", "hosts");
        }

        public IEnumerable<Host> Read()
        {
            if (!File.Exists(Path)) throw new FileNotFoundException(Path);

            int cnt = 0;
            using (var reader = new StreamReader(Path))
            {
                while (reader.Peek() > 0)
                {
                    cnt++;
                    var line = reader.ReadLine();
                    yield return new Host(cnt, line);
                }
            }
        }
    }
}
