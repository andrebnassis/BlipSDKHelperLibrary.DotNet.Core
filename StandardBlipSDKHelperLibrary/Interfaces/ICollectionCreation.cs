using Lime.Protocol;
using StandardBlipSDKHelperLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardBlipSDKHelperLibrary.Interfaces
{
    public interface ICollectionCreation
    {
        DocumentCollection CreateCollectionOfDocuments(params Document[] content);

        DocumentCollection CreateCollectionOfDocuments(GroupDocumentsModel content);
    }
}
