using System;
using System.ComponentModel;

namespace MediaBrowser.Model.SyncPlay;

/// <summary>
/// Class SyncPlayChatMessageUpdate.
/// </summary>
public class SyncPlayChatMessageUpdate : GroupUpdate<ChatMessageDto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SyncPlayChatMessageUpdate"/> class.
    /// </summary>
    /// <param name="groupId">The group identifier.</param>
    /// <param name="data">The chat message data.</param>
    public SyncPlayChatMessageUpdate(Guid groupId, ChatMessageDto data) : base(groupId, data)
    {
    }

    /// <inheritdoc />
    [DefaultValue(GroupUpdateType.ChatMessage)]
    public override GroupUpdateType Type => GroupUpdateType.ChatMessage;
}

