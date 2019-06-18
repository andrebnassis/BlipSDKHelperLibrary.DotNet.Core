using Lime.Messaging.Contents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardBlipSDKHelperLibrary.Interfaces
{
    public interface IVideoCreation
    {
        MediaLink CreateVideoDocument(string urlVideo, string title = null, string subtitle = null);
    }
}
