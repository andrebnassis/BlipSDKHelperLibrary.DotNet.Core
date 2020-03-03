using StandardBlipSDKHelperLibrary.Models;
using Lime.Protocol;

namespace StandardBlipSDKHelperLibrary.Interfaces
{
    public interface IReceiptCreation
    {
        JsonDocument CreateReceiptDocument(ReceiptModel receipt);
    }
}
