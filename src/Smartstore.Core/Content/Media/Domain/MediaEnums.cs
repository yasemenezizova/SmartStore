namespace Smartstore.Core.Content.Media
{
    public enum MediaTrackOperation
    {
        Track,
        Untrack
    }

    /// <summary>
    /// Represents a picture item type.
    /// </summary>
    public enum FallbackPictureType
    {
        NoFallback = 0,

        /// <summary>
        /// Entities (products, categories, manufacturers).
        /// </summary>
        Entity = 1,
    }

    public enum ThumbnailScaleMode
    {
        Auto,
        UseWidth,
        UseHeight
    }
}
