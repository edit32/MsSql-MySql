﻿using MsSql_MySql.ContextDb;
using MsSql_MySql.Models;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsSql_MySql.Data
{
    public class MsSqlDataReader
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public async Task<List<gi_comuni_validita>> GetMsComuni()
        {
            List<gi_comuni_validita> listaC = new List<gi_comuni_validita>();

            using (MsSqlContext dbMs = new MsSqlContext())
            {
                try
                {
                    listaC = await dbMs.gi_comuni_validita.ToListAsync();                    
                }
                catch (Exception ex)
                {
                    log.Error(ex);                    
                }
            }
            return listaC;
        }

    }
}
