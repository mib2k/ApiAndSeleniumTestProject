using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace TestContext
{
    public class Context
    {
        private static ThreadLocal<Context> _Instance;

        static Context()
        {
            _Instance = new ThreadLocal<Context>(() => { return new Context(); });
        }
        private Context() { }

        public static Context Current
        {
            get { return _Instance.Value; }
        }

        public Dictionary<string, string> KeyValuePairs { get; set; } = new Dictionary<string, string>();
    }

}
