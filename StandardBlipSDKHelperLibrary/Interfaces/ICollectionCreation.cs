using Lime.Protocol;
using StandardBlipSDKHelperLibrary.Models;

namespace StandardBlipSDKHelperLibrary.Interfaces
{
    public interface ICollectionCreation
    {
        DocumentCollection CreateCollectionOfDocuments(params Document[] content);

        DocumentCollection CreateCollectionOfDocuments(GroupDocumentsModel content);
    }
}
