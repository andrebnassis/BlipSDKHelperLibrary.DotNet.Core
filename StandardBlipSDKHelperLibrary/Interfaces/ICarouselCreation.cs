using Lime.Protocol;
using StandardBlipSDKHelperLibrary.Models;

namespace StandardBlipSDKHelperLibrary.Interfaces
{
    public interface ICarouselCreation
    {
        DocumentCollection CreateCarouselDocument(CarouselModel carouselModel);
    }
}
