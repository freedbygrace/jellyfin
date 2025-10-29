#nullable disable

namespace MediaBrowser.Model.SyncPlay
{
    /// <summary>
    /// Class SendChatMessageRequest.
    /// </summary>
    public class SendChatMessageRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendChatMessageRequest"/> class.
        /// </summary>
        public SendChatMessageRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendChatMessageRequest"/> class.
        /// </summary>
        /// <param name="message">The message content.</param>
        public SendChatMessageRequest(string message)
        {
            Message = message;
        }

        /// <summary>
        /// Gets or sets the message content.
        /// </summary>
        /// <value>The message content.</value>
        public string Message { get; set; }
    }
}

