using Lime.Messaging.Contents;
using StandardBlipSDKHelperLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardBlipSDKHelperLibrary.Interfaces
{
    public interface IMenuCreation
    {
        Select CreateMenuDocument(MenuModel menuModel);
    }
}
