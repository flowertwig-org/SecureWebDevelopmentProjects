using EPiServer.Core;

namespace A7_MissingFunctionLevelAccessControl.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
