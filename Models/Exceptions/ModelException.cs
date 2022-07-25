namespace APIEnem.Models.Exceptions
{
    public class ModelException : Exception
    {
        public string Message { get; set; }
        public string ErrorLocal { get; set; }
        public string Action { get; set; }

        public ModelException(string local_code_error,string error_message, string action_message)
        {
            this.Message = error_message;
            this.ErrorLocal = local_code_error;
            this.Action = action_message;
        }
    }
}
