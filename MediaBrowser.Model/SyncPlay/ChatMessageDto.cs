#nullable disable

using System;

namespace MediaBrowser.Model.SyncPlay
{
    /// <summary>
    /// Class ChatMessageDto.
    /// </summary>
    public class ChatMessageDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageDto"/> class.
        /// </summary>
        /// <param name="messageId">The message identifier.</param>
        /// <param name="groupId">The group identifier.</param>
        /// <param name="userId">The user identifier.</param>
        /// <param name="userName">The user name.</param>
        /// <param name="message">The message content.</param>
        /// <param name="timestamp">The timestamp.</param>
        /// <param name="isSystemMessage">Whether this is a system message.</param>
        public ChatMessageDto(Guid messageId, Guid groupId, Guid userId, string userName, string message, DateTime timestamp, bool isSystemMessage)
        {
            MessageId = messageId;
            GroupId = groupId;
            UserId = userId;
            UserName = userName;
            Message = message;
            Timestamp = timestamp;
            IsSystemMessage = isSystemMessage;
        }

        /// <summary>
        /// Gets the message identifier.
        /// </summary>
        /// <value>The message identifier.</value>
        public Guid MessageId { get; }

        /// <summary>
        /// Gets the group identifier.
        /// </summary>
        /// <value>The group identifier.</value>
        public Guid GroupId { get; }

        /// <summary>
        /// Gets the user identifier.
        /// </summary>
        /// <value>The user identifier.</value>
        public Guid UserId { get; }

        /// <summary>
        /// Gets the user name.
        /// </summary>
        /// <value>The user name.</value>
        public string UserName { get; }

        /// <summary>
        /// Gets the message content.
        /// </summary>
        /// <value>The message content.</value>
        public string Message { get; }

        /// <summary>
        /// Gets the timestamp.
        /// </summary>
        /// <value>The timestamp.</value>
        public DateTime Timestamp { get; }

        /// <summary>
        /// Gets a value indicating whether this is a system message.
        /// </summary>
        /// <value>Whether this is a system message.</value>
        public bool IsSystemMessage { get; }
    }
}

