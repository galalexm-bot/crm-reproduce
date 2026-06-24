using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class LinkModel
{
	public ILinkTypeProvider LinkTypeProvider { get; set; }

	public IContentAction ContentAction { get; set; }

	public string ActionTypeProviderId { get; set; }

	public string ActionId { get; set; }

	public string Text { get; set; }

	public string TypeText { get; set; }

	public string Image { get; set; }

	public bool ReadOnly { get; set; }

	public static LinkModel Create(ContentActionRegistry contentActionRegistry, string actionProviderId, string actionId)
	{
		if (string.IsNullOrWhiteSpace(actionProviderId))
		{
			return new LinkModel();
		}
		ILinkTypeProvider linkTypeProvider = contentActionRegistry.GetLinkTypeProvider(actionProviderId);
		IContentAction contentAction = contentActionRegistry.Get(actionProviderId, actionId);
		if (contentAction == null)
		{
			return new LinkModel();
		}
		return new LinkModel
		{
			ActionTypeProviderId = actionProviderId,
			ActionId = actionId,
			Image = contentAction.GetImage(ObjectIconFormat.x16),
			Text = linkTypeProvider.GetActionName(contentAction),
			TypeText = linkTypeProvider.Name,
			ContentAction = contentAction,
			LinkTypeProvider = linkTypeProvider
		};
	}
}
