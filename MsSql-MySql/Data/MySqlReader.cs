using MsSql_MySql.ContextDb;
using MsSql_MySql.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsSql_MySql.Data
{
    public class MySqlReader
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private MainWindow _mainWindow;

        public MySqlReader(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
        }

        public async Task ReadComuni()
        {
            using (MySqlContext dbMy = new MySqlContext())
            {
                try
                {
                    List<gi_comuni_validita> listaComuniMy = await dbMy.gi_comuni_validita.ToListAsync();
                    _mainWindow.Dispatcher.Invoke(() => _mainWindow.MySqlList.ItemsSource = listaComuniMy);
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
