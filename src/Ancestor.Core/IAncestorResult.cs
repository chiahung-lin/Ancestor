using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ancestor
{
    /// <summary>
    /// Ancestor執行結果介面
    /// </summary>
    public interface IAncestorResult
    {
        /// <summary>
        /// 執行是否成功
        /// </summary>
        bool Success { get; }
        Exception Exception { get; }
    }
}
