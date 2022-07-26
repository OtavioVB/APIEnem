namespace APIEnem.Models.Exceptions
{
    public class RequestException : Exception
    {
        public string Message { get; set; }
        public string ErrorLocal { get; set; }
        public string Action { get; set; }

        public RequestException(string local_code_error, string error_message, string action_message)
        {
            this.Message = error_message;
            this.ErrorLocal = local_code_error;
            this.Action = action_message;
        }
    }
}
