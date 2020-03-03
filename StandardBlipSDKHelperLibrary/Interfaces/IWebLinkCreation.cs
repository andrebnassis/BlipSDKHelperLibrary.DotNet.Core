using Lime.Messaging.Contents;

namespace StandardBlipSDKHelperLibrary.Interfaces
{
    public interface IWebLinkCreation
    {
        WebLink CreateWebLinkDocument(string url, string previewUrl = null, string title = null, string subtitle = null);
    }
}
