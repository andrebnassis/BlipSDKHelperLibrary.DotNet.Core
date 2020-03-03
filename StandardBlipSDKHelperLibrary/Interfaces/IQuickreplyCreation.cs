using StandardBlipSDKHelperLibrary.Models;
using Lime.Protocol;

namespace StandardBlipSDKHelperLibrary.Interfaces
{
    public interface IQuickreplyCreation
    {
        Document CreateQuickReplyDocument(QuickReplyModel quickReplyModel);
    }
}
