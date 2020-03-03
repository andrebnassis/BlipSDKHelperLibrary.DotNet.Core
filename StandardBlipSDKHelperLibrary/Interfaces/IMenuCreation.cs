using Lime.Messaging.Contents;
using StandardBlipSDKHelperLibrary.Models;

namespace StandardBlipSDKHelperLibrary.Interfaces
{
    public interface IMenuCreation
    {
        Select CreateMenuDocument(MenuModel menuModel);
    }
}
