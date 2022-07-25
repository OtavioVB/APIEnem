namespace APIEnem.Models.Exceptions
{
    public class RequestException : Exception
    {
        public string Message { get; set; }

        public RequestException(string error_message)
        {
            this.Message = error_message;
        }
    }
}
