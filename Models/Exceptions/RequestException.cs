namespace APIEnem.Models.Exceptions
{
    public class RequestException : Exception
    {
        public string Message { get; set; }
        public string ErrorLocal { get; set; }
        public string Action { get; set; }

        public RequestException(string localCodeError,string errorMessage, string actionMessage)
        {
            Message = errorMessage;
            ErrorLocal = localCodeError;
            Action = actionMessage;
        }
    }
}
