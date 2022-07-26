namespace APIEnem.Models.Application
{
    public class Message
    {
        public string LocationResultCode { get; set; }
        public string Definition { get; set; }
        public string Action { get; set; }

        public Message(string LocationResultCode, string Message, string Action)
        {
            this.LocationResultCode = LocationResultCode;
            this.Definition = Message;
            this.Action = Action;
        }
    }
}
