namespace FoodShareAPI.Exceptions
{
    public class ApiErrorException : Exception
    {
        public int ErrorCode { get; set; }

        public ApiErrorException(int errorCode, string message)
            : base(message)
        {
            ErrorCode = errorCode;
        }

        public ApiErrorException(int errorCode, string message, Exception inner)
            : base(message, inner)
        {
            ErrorCode = errorCode;
        }
    }
}