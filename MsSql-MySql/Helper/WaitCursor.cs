using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace MsSql_MySql.Helper
{
    public class WaitCursor : IDisposable
    {
        public WaitCursor(Window control, bool ignore = false)
        {
            if (ignore) return;
            Application.Current?.Dispatcher.Invoke(new Action(() => { Mouse.OverrideCursor = Cursors.Wait; }));
        }

        public void Dispose()
        {
            Application.Current?.Dispatcher.Invoke(new Action(() => { Mouse.OverrideCursor = null; }));
        }
    }
}
