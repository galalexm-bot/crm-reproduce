using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.UI.DTO.Managers;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.Web.DTO.Managers;

public class ContentActionsDTOManager : DTOManager, IContentActionsDTOManager, IConfigurationService
{
	private readonly ContentActionRegistry contentActionRegistry;

	private readonly ControllerActionRegistry controllerActionRegistry;

	public ContentActionsDTOManager(ControllerActionRegistry controllerActionRegistry, ContentActionRegistry contentActionRegistry)
	{
		this.contentActionRegistry = contentActionRegistry;
		this.controllerActionRegistry = controllerActionRegistry;
	}

	public virtual IEnumerable<ContentActionDTO> ContentActions()
	{
		if (controllerActionRegistry == null)
		{
			return new ContentActionDTO[0];
		}
		return (from q in controllerActionRegistry.All().OfType<IContentAction>()
			select Convert(q, (q.Id == "EleWise.ELMA.Web.Components.FormActionProvider") ? "EleWise.ELMA.Web.Components.FormActionProvider" : "ActionsLinkTypeProvider")).ToArray();
	}

	public virtual ContentActionDTO GetContentAction(string typeProviderId, string id)
	{
		if (controllerActionRegistry == null || (typeProviderId != "ActionsLinkTypeProvider" && typeProviderId != "EleWise.ELMA.Web.Components.FormActionProvider"))
		{
			return null;
		}
		IContentAction contentAction = controllerActionRegistry.Get(id);
		if (contentAction == null && contentActionRegistry != null)
		{
			contentAction = contentActionRegistry.Get(typeProviderId, id);
		}
		return Convert(contentAction, typeProviderId);
	}

	private string ConvertImage(string image)
	{
		if (string.IsNullOrWhiteSpace(image))
		{
			return null;
		}
		image = image.Replace('\\', '/');
		if (!image.StartsWith("~") && !image.StartsWith("#"))
		{
			image = (image.StartsWith("/") ? "~" : "~/") + image;
		}
		return image;
	}

	private ContentActionDTO Convert(IContentAction action, string providerId)
	{
		if (action != null)
		{
			return new ContentActionDTO
			{
				TypeProviderId = providerId,
				Id = action.Id,
				Name = action.Name,
				Category = SR.T(action.Category),
				Image16 = ConvertImage(action.Image16),
				Image24 = ConvertImage(action.Image24),
				Image32 = ConvertImage(action.Image32),
				Order = action.Order,
				ActionType = SR.T(action.ActionType)
			};
		}
		return null;
	}
}
