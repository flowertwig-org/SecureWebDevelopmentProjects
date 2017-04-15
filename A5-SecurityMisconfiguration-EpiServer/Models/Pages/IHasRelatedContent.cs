using EPiServer.Core;

namespace A5_SecurityMisconfiguration_EpiServer.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
