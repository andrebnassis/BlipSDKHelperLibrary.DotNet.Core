using Lime.Messaging.Contents;

namespace StandardBlipSDKHelperLibrary.Interfaces
{
    public interface IImageCreation
    {
        MediaLink CreateImageDocument(string urlImage, string previewUrlImage = null, string title = null, string subtitle = null);
    }
}
