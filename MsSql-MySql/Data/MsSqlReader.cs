using MsSql_MySql.ContextDb;
using MsSql_MySql.Models;
using MsSql_MySql.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsSql_MySql.Data
{
    public class MsSqlReader
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private MainWindow _mainWindow;

        public MsSqlReader(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
        }

        public async Task ReadComuni()
        {
            using (MsSqlContext dbMs = new MsSqlContext())
            {
                try
                {
                    List<gi_comuni_validita> listaComuniMs = await dbMs.gi_comuni_validita.ToListAsync();                    
                    _mainWindow.Dispatcher.Invoke(() => _mainWindow.MsSqlList.ItemsSource = listaComuniMs);
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    _mainWindow.Dispatcher.Invoke(() => _mainWindow.txtMultiLine.Text = ex.Message);                    
                }
            }
        }
    }
}
