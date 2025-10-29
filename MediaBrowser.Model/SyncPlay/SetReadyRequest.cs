#nullable disable

namespace MediaBrowser.Model.SyncPlay
{
    /// <summary>
    /// Class SetReadyRequest.
    /// Request to set the ready state for a user in a SyncPlay group.
    /// </summary>
    public class SetReadyRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetReadyRequest"/> class.
        /// </summary>
        public SetReadyRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetReadyRequest"/> class.
        /// </summary>
        /// <param name="isReady">Whether the user is ready.</param>
        public SetReadyRequest(bool isReady)
        {
            IsReady = isReady;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the user is ready.
        /// </summary>
        /// <value><c>true</c> if the user is ready; <c>false</c> otherwise.</value>
        public bool IsReady { get; set; }
    }
}

