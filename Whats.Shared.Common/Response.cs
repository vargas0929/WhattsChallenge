namespace Whats.Shared.Common
{

    /// <summary>
    /// Generic response for request
    /// </summary>
    /// <typeparam name="T">Generic class</typeparam>
    public class Response<T>
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The Generic class.
        /// </value>
        public T Data { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is success.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is success; otherwise, <c>false</c>.
        /// </value>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message or detailed error.
        /// </value>
        public string Message { get; set; }
        /// <summary>
        /// Gets or sets the status code.
        /// </summary>
        /// <value>
        /// The http status code e.g. 200, 400, 404,500, etc.
        /// </value>
        public int StatusCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string StringCode { get; set; }
        /// <summary>
        /// Gets or sets the exception.
        /// </summary>
        /// <value>
        /// The exception if exists
        /// </value>

        public Exception Exception { get; set; }
        public int ErrorCode { get; set; }
        public Response()
        {
            IsSuccess = false;

        }
     
    }
}
