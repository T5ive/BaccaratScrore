using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace BaccaratScrore
{
    internal sealed class Variable
    {
        public static int _time=1;
        [DebuggerNonUserCode]
        internal static ScreenCatcher Catcher()
        {
            return _screenCatcher;
        }

        [DebuggerNonUserCode]
        [MethodImpl(MethodImplOptions.Synchronized)]
        internal static void ScreenCatcher(ScreenCatcher screenCatcher)
        {
            _screenCatcher = screenCatcher;
        }

        private static ScreenCatcher _screenCatcher;
    }
}