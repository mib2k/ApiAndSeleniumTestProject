using System.Collections.Generic;
using System.Threading;

namespace Framework
{
    public class Context
    {
        private static readonly ThreadLocal<Context> Instance;

        static Context()
        {
            Instance = new ThreadLocal<Context>(() => new Context());
        }

        private Context() { }

        public static Context Current => Instance.Value;

        public Dictionary<string, string> KeyValuePairs { get; set; } = new Dictionary<string, string>();
    }

}
