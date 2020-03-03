using Lime.Protocol;
using StandardBlipSDKHelperLibrary.Models;

namespace StandardBlipSDKHelperLibrary.Interfaces
{
    public interface IListCreation
    {
        Document CreateListDocument(ListModel itemsList);
    }
}
