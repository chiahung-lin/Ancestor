using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ancestor
{
    /// <summary>
    /// 傳統資料存取物件介面
    /// </summary>
    public interface ILegacyDataAccessObject : IDataAccessObject
    {
        /// <summary>
        /// 透過SQL語句查詢
        /// </summary>
        /// <param name="sqlString">SQL語句</param>
        /// <param name="paramsObject">參數物件</param>
        /// <returns><see cref="IAncestorResult"/></returns>
        IAncestorResult Query(string sqlString, object paramsObject);
        /// <summary>
        /// 透過SQL語句執行
        /// </summary>
        /// <param name="sqlString">SQL語句</param>
        /// <param name="paramsObject">參數物件</param>
        /// <returns><see cref="IAncestorResult"/></returns>
        IAncestorResult Execute(string sqlString, object paramsObject);
    }
}
