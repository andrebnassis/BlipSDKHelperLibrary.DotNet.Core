using System;
using System.Threading;
using System.Threading.Tasks;
using Lime.Protocol;
using System.Diagnostics;
using Take.Blip.Client;
using StandardBlipSDKHelperLibrary.SdkHelpers;
using StandardBlipSDKHelperLibrary.Models;
using Lime.Messaging.Contents;

namespace TestLib
{
    /// <summary>
    /// Defines a class for handling messages. 
    /// This type must be registered in the application.json file in the 'messageReceivers' section.
    /// </summary>
    public class PlainTextMessageReceiver : IMessageReceiver
    {
        private readonly ISender _sender;
        private readonly Settings _settings;
        private readonly BlipChatBlipSDKHelper _blipchatDocumentService;
        private readonly FacebookBlipSDKHelper _facebookDocumentService;
        public PlainTextMessageReceiver(ISender sender, Settings settings)
        {
            _sender = sender;
            _settings = settings;
            _blipchatDocumentService = new BlipChatBlipSDKHelper();
            _facebookDocumentService = new FacebookBlipSDKHelper();
        }

    public async Task ReceiveAsync(Message message, CancellationToken cancellationToken)
        {
            #region BLIPCHAT
            ////BLIPCHAT
            //var document = _blipchatDocumentService.CreateTextDocument("Sending a simple text");

            ////BLIPCHAT
            //var document = _blipchatDocumentService.CreateImageDocument("https://dl.dropboxusercontent.com/s/99sw7vu788suww1/imagineFloor.jpg", "https://dl.dropboxusercontent.com/s/0u34yn7pj29ak1v/imagineFloorPreview.jpg", "OptionalTitle", "OptionalSubtitle");

            ////BLIPCHAT
            //var document = _blipchatDocumentService.CreateWebLinkDocument("https://dl.dropboxusercontent.com/s/99sw7vu788suww1/imagineFloor.jpg", "https://dl.dropboxusercontent.com/s/0u34yn7pj29ak1v/imagineFloorPreview.jpg", "OptionalTitle", "OptionalSubtitle");

            ////BLIPCHAT
            //var menu = new MenuModel("Choose an option:");
            //menu.AddTextButton("Button2", "Value2", 2);
            //menu.AddTextButton("Button1", "Value1", 1);
            //menu.AddTextButton("Button0", "Value0");
            //var document = _blipchatDocumentService.CreateMenuDocument(menu);

            ////BLIPCHAT
            //var quickreply = new QuickReplyModel("Choose an option:");
            ////quickreply.AddLocationButton(10);
            //quickreply.AddTextButton("Button1", "Value1", "https://www.iconexperience.com/_img/v_collection_png/256x256/shadow/bullet_ball_red.png", 1);
            //quickreply.AddTextButton("😀 Button2", "Value2", null, 2);
            //quickreply.AddTextButton("Button0", "Value0");
            //quickreply.AddTextButton("Button3", "Value3", null, 3);
            //quickreply.AddTextButton("Button4", "Value4", null, 4);
            //quickreply.AddTextButton("Button5", "Value5", null, 5);
            //quickreply.AddTextButton("Button6", "Value6", null, 6);
            //quickreply.AddTextButton("Button7", "Value7", null, 7);
            //quickreply.AddTextButton("Button8", "Value8", null, 8);
            //quickreply.AddTextButton("Button9", "Value9", null, 9);
            //var document = _blipchatDocumentService.CreateQuickReplyDocument(quickreply);

            ////BLIPCHAT
            //var document0 = _blipchatDocumentService.CreateTextDocument("Sending a simple text");
            //var document1 = _blipchatDocumentService.CreateImageDocument("https://dl.dropboxusercontent.com/s/99sw7vu788suww1/imagineFloor.jpg", "https://dl.dropboxusercontent.com/s/0u34yn7pj29ak1v/imagineFloorPreview.jpg", "OptionalTitle", "OptionalSubtitle");

            //var document = _blipchatDocumentService.CreateCollectionOfDocuments(document1, document0);

            //////OR if you want to order the values explicity.
            ////BLIPCHAT
            //var document0 = _blipchatDocumentService.CreateTextDocument("Sending a simple text");
            //var document1 = _blipchatDocumentService.CreateImageDocument("https://dl.dropboxusercontent.com/s/99sw7vu788suww1/imagineFloor.jpg", "https://dl.dropboxusercontent.com/s/0u34yn7pj29ak1v/imagineFloorPreview.jpg", "OptionalTitle", "OptionalSubtitle");
            //var collection = new GroupDocumentsModel();
            //collection.Add(document0, 2);
            //collection.Add(document1);
            //var document = _blipchatDocumentService.CreateCollectionOfDocuments(collection);

            ////BLIPCHAT
            //var carousel = new CarouselModel();
            //carousel.AddCard("Title, Subtitle, Image and Buttons", "Image goes up above, Title goes above, Subtitle goes here and button goes below.", "http://www.w3schools.com/css/img_fjords.jpg");
            //carousel.GetCard(0).AddLinkButton("Button1: Link", "http://www.w3schools.com/css/img_fjords.jpg", 1);
            //carousel.GetCard(0).AddTextButton("Button0: Text", "Value0");

            //carousel.AddCard("Title, Subtitle and Button", "Title goes above, Subtitle goes here and button goes below.", null);
            //carousel.GetCard(1).AddTextButton("Button0: Text", "Value0");
            //carousel.AddCard("Title, Subtitle and Image", "Image goes up above, Title goes above and Subtitle goes here.", "http://www.w3schools.com/css/img_fjords.jpg");
            //carousel.AddCard("Title, Image and Button: Image goes up above, Title goes here and button below", null, "http://www.w3schools.com/css/img_fjords.jpg");
            //carousel.GetCard(3).AddLinkButton("Button0: Link", "http://www.w3schools.com/css/img_fjords.jpg");

            //carousel.AddCard("Title and Image: Image goes up above, Title goes here", null, "http://www.w3schools.com/css/img_fjords.jpg");
            //carousel.AddCard("Title and Subtitle", "Title goes above, Subtitle goes here", null, 10);
            //carousel.AddCard("Title and Button: Title goes here, button goes below", null);
            //carousel.GetCard(6).AddLinkButton("Button0: Link", "http://www.facebook.com");

            //var document = _blipchatDocumentService.CreateCarouselDocument(carousel);
            #endregion BLIPCHAT



            ////FACEBOOK
            //var document = _facebookDocumentService.CreateTextDocument("Sending a simple text");

            ////FACEBOOK
            //var document = _facebookDocumentService.CreateImageDocument("https://dl.dropboxusercontent.com/s/99sw7vu788suww1/imagineFloor.jpg", "https://dl.dropboxusercontent.com/s/0u34yn7pj29ak1v/imagineFloorPreview.jpg", "OptionalTitle", "OptionalSubtitle");

            ////FACEBOOK
            //var document = _facebookDocumentService.CreateVideoDocument("https://dl.dropboxusercontent.com/s/jxy3sspxbl6ilan/John%20Lennon%20-%20Imagine.mp4", "OptionalTitle", "OptionalSubtitle");

            ////FACEBOOK
            //var document = _facebookDocumentService.CreateWebLinkDocument("https://dl.dropboxusercontent.com/s/99sw7vu788suww1/imagineFloor.jpg", "https://dl.dropboxusercontent.com/s/0u34yn7pj29ak1v/imagineFloorPreview.jpg", "OptionalTitle", "OptionalSubtitle");

            ////FACEBOOK
            //var menu = new MenuModel("Choose an option:");
            //menu.AddTextButton("Button2", "Value2", 2);
            //menu.AddTextButton("Button1", "Value1", 1);
            //menu.AddTextButton("Button0", "Value0");
            //var document = _facebookDocumentService.CreateMenuDocument(menu);

            ////FACEBOOK
            //var quickreply = new QuickReplyModel("Choose an option:");
            //quickreply.AddLocationButton(10);
            //quickreply.AddTextButton("Button1", "Value1", "https://www.iconexperience.com/_img/v_collection_png/256x256/shadow/bullet_ball_red.png", 1);
            //quickreply.AddTextButton("😀 Button2", "Value2", null, 2);
            //quickreply.AddTextButton("Button0", "Value0");
            //quickreply.AddTextButton("Button3", "Value3", null, 3);
            //quickreply.AddTextButton("Button4", "Value4", null, 4);
            //quickreply.AddTextButton("Button5", "Value5", null, 5);
            //quickreply.AddTextButton("Button6", "Value6", null, 6);
            //quickreply.AddTextButton("Button7", "Value7", null, 7);
            //quickreply.AddTextButton("Button8", "Value8", null, 8);
            //quickreply.AddTextButton("Button9", "Value9", null, 9);
            //var document = _facebookDocumentService.CreateQuickReplyDocument(quickreply);

            ////FACEBOOK
            //var document0 = _facebookDocumentService.CreateTextDocument("Sending a simple text");
            //var document1 = _facebookDocumentService.CreateImageDocument("https://dl.dropboxusercontent.com/s/99sw7vu788suww1/imagineFloor.jpg", "https://dl.dropboxusercontent.com/s/0u34yn7pj29ak1v/imagineFloorPreview.jpg", "OptionalTitle", "OptionalSubtitle");
            //var document2 = _facebookDocumentService.CreateVideoDocument("https://dl.dropboxusercontent.com/s/jxy3sspxbl6ilan/John%20Lennon%20-%20Imagine.mp4", "OptionalTitle", "OptionalSubtitle");

            //var document = _facebookDocumentService.CreateCollectionOfDocuments(document1, document2, document0);

            //////OR if you want to order the values explicity.
            ////FACEBOOK
            //var document0 = _facebookDocumentService.CreateTextDocument("Sending a simple text");
            //var document1 = _facebookDocumentService.CreateImageDocument("https://dl.dropboxusercontent.com/s/99sw7vu788suww1/imagineFloor.jpg", "https://dl.dropboxusercontent.com/s/0u34yn7pj29ak1v/imagineFloorPreview.jpg", "OptionalTitle", "OptionalSubtitle");
            //var document2 = _facebookDocumentService.CreateVideoDocument("https://dl.dropboxusercontent.com/s/jxy3sspxbl6ilan/John%20Lennon%20-%20Imagine.mp4", "OptionalTitle", "OptionalSubtitle");
            //var collection = new GroupDocumentsModel();
            //collection.Add(document0, 2);
            //collection.Add(document1);
            //collection.Add(document2, 1);
            //var document = _facebookDocumentService.CreateCollectionOfDocuments(collection);



            //var carousel = new CarouselModel();
            //carousel.AddCard("Title, Subtitle, Image and Buttons", "Image goes up above, Title goes above, Subtitle goes here and button goes below.", "http://www.w3schools.com/css/img_fjords.jpg");
            //carousel.GetCard(0).AddLinkButton("Button1: Link", "http://www.w3schools.com/css/img_fjords.jpg", 1);
            //carousel.GetCard(0).AddTextButton("Button0: Text", "Value0");

            //carousel.AddCard("Title, Subtitle and Button", "Title goes above, Subtitle goes here and button goes below.", null);
            //carousel.GetCard(1).AddTextButton("Button0: Text", "Value0");
            //carousel.AddCard("Title, Subtitle and Image", "Image goes up above, Title goes above and Subtitle goes here.", "http://www.w3schools.com/css/img_fjords.jpg");
            //carousel.AddCard("Title, Image and Button: Image goes up above, Title goes here and button below", null, "http://www.w3schools.com/css/img_fjords.jpg");
            //carousel.GetCard(3).AddLinkButton("Button0: Link", "http://www.w3schools.com/css/img_fjords.jpg");

            //carousel.AddCard("Title and Image: Image goes up above, Title goes here", null, "http://www.w3schools.com/css/img_fjords.jpg");
            //carousel.AddCard("Title and Subtitle", "Title goes above, Subtitle goes here", null, 10);
            //carousel.AddCard("Title and Button: Title goes here, button goes below", null);
            //carousel.GetCard(6).AddLinkButton("Button0: Link", "http://www.facebook.com");

            ////FACEBOOK
            //var document = _facebookDocumentService.CreateCarouselDocument(carousel);


            var list = new ListModel();
            list.HighlightFirstItem();
            list.AddBottomTextButton("BottomButton Text", "BottomButtonValue");
            list.AddItem("Title1", "Subtitle1", "https://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg", 1);
            list.AddItem("Title3", "Subtitle3", null, 3);
            list.AddItem("Title0", "Subtitle0", "https://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            list.GetItem(2).AddTextButton("ButtonText0", "ButtonValue0");
            list.AddItem("Title2", "Subtitle2", "", 2);
            list.GetItem(3).AddTextButton("ButtonText2", "ButtonValue2");
            //list.GetItem(3).AddWebUrl("https://www.youtube.com/");

            //IMPORTANT(only for List Creation case): 
            //If it is first time that you are using GetItem.AddWebUrl method, dont forget to call RegisterDomainToWhitelist function, passing the Urls as parameters.

            //FACEBOOK
            var document = _facebookDocumentService.CreateListDocument(list);



            //Trace.TraceInformation($"From: {message.From} \tContent: {message.Content}");
            await _sender.SendMessageAsync(document, message.From, cancellationToken);
        }
    }
}
