namespace APIEnem.Domain.Models.Exceptions
{
    public class ModelException : Exception
    {
        public string Message { get; set; }
        public string ErrorLocal { get; set; }
        public string Action { get; set; }

        public ModelException(string localCodeError,string errorMessage, string actionMessage)
        {
            Message = errorMessage;
            ErrorLocal = localCodeError;
            Action = actionMessage;
        }
    }
}
