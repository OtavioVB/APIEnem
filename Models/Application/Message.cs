namespace APIEnem.Models.Application
{
    public class Message
    {
        public string LocationResultCode { get; set; }
        public string Definition { get; set; }
        public string Action { get; set; }

        public Message(string locationResultCode, string message, string action)
        {
            LocationResultCode = locationResultCode;
            Definition = message;
            Action = action;
        }
    }
}
