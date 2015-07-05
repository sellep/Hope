using System;
using Hope.Common.Extensions;

namespace Hope.Common.Service
{

    public class ServiceException : Exception
    {

        #region fields

        private ErrorCode _ErrorCode;

        #endregion

        #region constructors

        public ServiceException(ErrorCode errorCode, string message) : base (message)
        {
            _ErrorCode = errorCode;
        }

        public ServiceException(ErrorCode errorCode, string message, Exception innerException) : base (message, innerException)
        {
            _ErrorCode = errorCode;
        }

        #endregion

        #region properties

        public ErrorCode ErrorCode
        {
            get { return _ErrorCode; }
        }

        #endregion

        #region methods

        public override string ToString()
        {
            return ErrorCode.ToString().Con(": ", base.ToString());
        }

        #endregion
    }
}
