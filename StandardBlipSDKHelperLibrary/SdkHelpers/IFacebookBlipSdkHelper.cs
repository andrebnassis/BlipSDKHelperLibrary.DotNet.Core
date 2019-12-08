using System.Collections.Generic;
using System.Threading.Tasks;
using StandardBlipSDKHelperLibrary.Models;
using Lime.Messaging.Contents;
using Lime.Protocol;
//using RestSharp;
using StandardBlipSDKHelperLibrary.Interfaces;
using Take.Blip.Client;

namespace StandardBlipSDKHelperLibrary.SdkHelpers
{
    public interface IFacebookBlipSDKHelper :
    ICallButtonCreation,
    ICarouselCreation,
    ICollectionCreation,
    IImageCreation,
    IListCreation,
    IMenuCreation,
    IPlainTextCreation,
    IQuickreplyCreation,
    IReceiptCreation,
    IVideoCreation,
    IWebLinkCreation
    {
        //Task<IRestResponse> RegisterDomainToWhitelist(ISender sender, params string[] urls);
        //Task<IRestResponse> RegisterDomainToWhitelist(ISender sender, List<string> urls);
    }
}