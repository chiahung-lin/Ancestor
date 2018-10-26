using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Ancestor
{
    /// <summary>
    /// 存取介面
    /// </summary>
    public interface IDataAccessObject : IDisposable
    {
        /// <summary>
        /// 啟動Transaction
        /// </summary>        
        IDbTransaction BeginTransaction();
    }
}
