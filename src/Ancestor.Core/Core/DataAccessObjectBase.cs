using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Ancestor
{
    public abstract class DataAccessObjectBase : IDataAccessObject
    {        
        public IDbConnection Connection { get; }
        public DataAccessObjectBase(IDbConnection connection)
        {
            Connection = connection;
        }

        public IDbTransaction BeginTransaction()
        {
            return Connection.BeginTransaction();
        }



        public void Dispose()
        {
            if (Connection.State == ConnectionState.Open)
                Connection.Close();
        }
    }
}
