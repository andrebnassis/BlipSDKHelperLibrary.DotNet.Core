using Lime.Messaging.Contents;

namespace StandardBlipSDKHelperLibrary.Interfaces
{
    public interface IVideoCreation
    {
        MediaLink CreateVideoDocument(string urlVideo, string title = null, string subtitle = null);
    }
}
