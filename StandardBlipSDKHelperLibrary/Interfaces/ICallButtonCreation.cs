using Lime.Protocol;

namespace StandardBlipSDKHelperLibrary.Interfaces
{
    public interface ICallButtonCreation
    {
        JsonDocument CreateCallButtonDocument(string title, string buttonText, string phoneNumber);
    }
}
