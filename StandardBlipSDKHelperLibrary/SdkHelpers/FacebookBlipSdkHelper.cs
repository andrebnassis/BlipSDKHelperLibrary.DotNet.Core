using StandardBlipSDKHelperLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lime.Messaging.Contents;
using StandardBlipSDKHelperLibrary.Interfaces;
using Lime.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Take.Blip.Client;
using Lime.Protocol.Network;
using System.Threading;
using RestEase;

namespace StandardBlipSDKHelperLibrary.SdkHelpers
{
    public class FacebookBlipSDKHelper : IFacebookBlipSDKHelper
    {

        public FacebookBlipSDKHelper()
        {

        }

        public JsonDocument CreateCallButtonDocument(string title, string buttonText, string phoneNumber)
        {
            return BlipSDKHelperCore.MESSENGER_CreateCallButtonDocument(title, buttonText, phoneNumber);
        }

        public DocumentCollection CreateCarouselDocument(CarouselModel carouselModel)
        {
            return BlipSDKHelperCore.GENERIC_CreateCarouselDocument(carouselModel);
        }

        public DocumentCollection CreateCollectionOfDocuments(GroupDocumentsModel content)
        {
            return BlipSDKHelperCore.GENERIC_CreateCollectionOfDocuments(content);
        }

        public DocumentCollection CreateCollectionOfDocuments(params Document[] content)
        {
            return BlipSDKHelperCore.GENERIC_CreateCollectionOfDocuments(content);
        }

        public MediaLink CreateImageDocument(string urlImage, string previewUrlImage = null, string title = null, string subtitle = null)
        {
            return BlipSDKHelperCore.GENERIC_CreateImageDocument(urlImage, previewUrlImage, title, subtitle);
        }

        public Document CreateListDocument(ListModel itemsList)
        {
            return BlipSDKHelperCore.MESSENGER_CreateListDocument(itemsList);
        }

        public Select CreateMenuDocument(MenuModel menuModel)
        {
            return BlipSDKHelperCore.GENERIC_CreateMenuDocument(menuModel);
        }

        public Document CreateQuickReplyDocument(QuickReplyModel quickReplyModel)
        {
            return BlipSDKHelperCore.MESSENGER_CreateQuickReplyDocument(quickReplyModel);
        }

        public JsonDocument CreateReceiptDocument(ReceiptModel receipt)
        {
            return BlipSDKHelperCore.MESSENGER_CreateReceiptDocument(receipt);
        }

        public PlainText CreateTextDocument(string text)
        {
            return BlipSDKHelperCore.GENERIC_CreateTextDocument(text);
        }

        public MediaLink CreateVideoDocument(string urlVideo, string title = null, string subtitle = null)
        {
            return BlipSDKHelperCore.GENERIC_CreateVideoDocument(urlVideo, title, subtitle);
        }

        public WebLink CreateWebLinkDocument(string url, string previewUrl = null, string title = null, string subtitle = null)
        {
            return BlipSDKHelperCore.GENERIC_CreateWebLinkDocument(url, previewUrl, title, subtitle);
        }

        private async Task<string> GetPageAccessToken(ISender sender)
        {
            JToken JValuePageAccessToken = "";

            try
            {
                var commandResponse = await sender.ProcessCommandAsync(new Command() { Id = EnvelopeId.NewId(), Method = CommandMethod.Get, Uri = new LimeUri("/configuration/caller") }, CancellationToken.None);
                foreach (var item in (commandResponse.Resource as DocumentCollection).Items)
                {
                    JToken JValueKey = "";
                    var JObjectItem = JObject.FromObject(item);
                    var foundKey = JObjectItem.TryGetValue("name", out JValueKey);
                    if ((JValueKey as JValue).Value.ToString().Equals("PageAccessToken"))
                    {
                        var foundValue = JObjectItem.TryGetValue("value", out JValuePageAccessToken);
                        break;
                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception("Error trying to get PageAccessToken", e);
            }

            return (JValuePageAccessToken as JValue).Value.ToString();
        }

        public async Task<object> RegisterDomainToWhitelist(ISender sender, params string[] urls)
        {
            var pageAccessToken = await GetPageAccessToken(sender);

            if (pageAccessToken.Trim().IsNullOrEmpty())
            {
                throw (new Exception("Could not get PageAccessToken"));
            }

            try { 
            using (var client = RestClient.For<IFacebookGraphApi>("https://graph.facebook.com/"))
            {

                return await client.RegisterDomainToWhiteList(pageAccessToken, new DomainWhiteListModel { whitelisted_domains = urls.ToList()});
            }
            }
            catch(Exception e) 
            {
                throw;
            }

        }

        public async Task<object> RegisterDomainToWhitelist(ISender sender, List<string> urls)
        {
            var pageAccessToken = await GetPageAccessToken(sender);

            if (pageAccessToken.Trim().IsNullOrEmpty())
            {
                throw (new Exception("Could not get PageAccessToken"));
            }

            try
            {
                using (var client = RestClient.For<IFacebookGraphApi>("https://graph.facebook.com/"))
                {

                    return await client.RegisterDomainToWhiteList(pageAccessToken, new DomainWhiteListModel { whitelisted_domains = urls });
                }
            }
            catch (Exception e)
            {
                throw;
            }

        }
    }
}
