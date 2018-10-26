using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ancestor.Core
{
    /// <summary>
    /// Ancestor例外
    /// </summary>
    public class AncestorException : Exception
    {
        public AncestorExceptionReason Reason { get; private set; }
        public object Raised { get; private set; }
        public AncestorException(AncestorExceptionReason reason, string message, object raised, Exception innerException = null) : base(message, innerException)
        {
            Reason = reason;
            Raised = raised;
        }

        public AncestorException(AncestorExceptionReason reason, object raised = null, Exception innerException = null) : this(reason, GetReasonDescription(reason), raised, innerException)
        {

        }

        public AncestorException(string message, object raised = null, Exception innerException = null) : this(AncestorExceptionReason.Custom, message, raised, innerException)
        {

        }

        private static string GetReasonDescription(AncestorExceptionReason reason)
        {
            return null;
        }    
    }

    /// <summary>
    /// 例外理由
    /// </summary>
    public enum AncestorExceptionReason
    {
        None = 0,
        DbException = 1,


        Custom = 99,
    }

}
