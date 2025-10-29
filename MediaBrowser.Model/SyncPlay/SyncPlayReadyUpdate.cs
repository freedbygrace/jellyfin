using System;
using System.ComponentModel;

namespace MediaBrowser.Model.SyncPlay
{
    /// <summary>
    /// Class SyncPlayReadyUpdate.
    /// Notifies group members when a user's ready state changes.
    /// </summary>
    public class SyncPlayReadyUpdate : GroupUpdate<ReadyUpdateDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncPlayReadyUpdate"/> class.
        /// </summary>
        /// <param name="groupId">The group identifier.</param>
        /// <param name="data">The ready update data.</param>
        public SyncPlayReadyUpdate(Guid groupId, ReadyUpdateDto data)
            : base(groupId, data)
        {
        }

        /// <inheritdoc />
        [DefaultValue(GroupUpdateType.UserReady)]
        public override GroupUpdateType Type => GroupUpdateType.UserReady;
    }

    /// <summary>
    /// Class ReadyUpdateDto.
    /// Contains information about a user's ready state change.
    /// </summary>
    public class ReadyUpdateDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadyUpdateDto"/> class.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="userName">The username.</param>
        /// <param name="isReady">Whether the user is ready.</param>
        /// <param name="allReady">Whether all users in the group are ready.</param>
        public ReadyUpdateDto(Guid userId, string userName, bool isReady, bool allReady)
        {
            UserId = userId;
            UserName = userName;
            IsReady = isReady;
            AllReady = allReady;
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
        /// Gets a value indicating whether the user is ready.
        /// </summary>
        /// <value><c>true</c> if the user is ready; <c>false</c> otherwise.</value>
        public bool IsReady { get; }

        /// <summary>
        /// Gets a value indicating whether all users in the group are ready.
        /// </summary>
        /// <value><c>true</c> if all users are ready; <c>false</c> otherwise.</value>
        public bool AllReady { get; }
    }
}

