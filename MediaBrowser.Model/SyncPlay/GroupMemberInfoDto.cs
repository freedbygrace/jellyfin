using System;

namespace MediaBrowser.Model.SyncPlay
{
    /// <summary>
    /// Class GroupMemberInfoDto.
    /// Provides detailed information about a member in a SyncPlay group.
    /// </summary>
    public class GroupMemberInfoDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMemberInfoDto"/> class.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="userName">The username.</param>
        /// <param name="ping">The ping in milliseconds.</param>
        /// <param name="isBuffering">Whether the member is currently buffering.</param>
        /// <param name="isReady">Whether the member is ready for playback.</param>
        public GroupMemberInfoDto(Guid userId, string userName, long ping, bool isBuffering, bool isReady)
        {
            UserId = userId;
            UserName = userName;
            Ping = ping;
            IsBuffering = isBuffering;
            IsReady = isReady;
        }

        /// <summary>
        /// Gets the user identifier.
        /// </summary>
        /// <value>The user identifier.</value>
        public Guid UserId { get; }

        /// <summary>
        /// Gets the username.
        /// </summary>
        /// <value>The username.</value>
        public string UserName { get; }

        /// <summary>
        /// Gets the ping in milliseconds.
        /// </summary>
        /// <value>The ping.</value>
        public long Ping { get; }

        /// <summary>
        /// Gets a value indicating whether this member is currently buffering.
        /// </summary>
        /// <value><c>true</c> if member is buffering; <c>false</c> otherwise.</value>
        public bool IsBuffering { get; }

        /// <summary>
        /// Gets a value indicating whether this member is ready for playback.
        /// </summary>
        /// <value><c>true</c> if member is ready; <c>false</c> otherwise.</value>
        public bool IsReady { get; }
    }
}

