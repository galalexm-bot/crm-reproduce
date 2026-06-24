using System;
using System.Web.Mvc;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class PageProfileModel : EntityModel<IPageProfile>
{
	private IContentActionRegistry contentActionRegistry;

	private IContentActionRegistry ContentActionRegistry => contentActionRegistry ?? (contentActionRegistry = Locator.GetServiceNotNull<IContentActionRegistry>());

	[DisplayName("SR.M('Отображаемое имя')")]
	public string DisplayName { get; private set; }

	[DisplayName("SR.M('Наименование')")]
	public string Name { get; private set; }

	[DisplayName("SR.M('Дата создания')")]
	public DateTime CreationDate { get; private set; }

	[DisplayName("SR.M('Автор создания')")]
	public IUser CreationAuthor { get; private set; }

	[DisplayName("SR.M('Дата публикации')")]
	public DateTime? PublishedDate { get; private set; }

	[DisplayName("SR.M('Автор публикации')")]
	public IUser PublishedAuthor { get; private set; }

	public string IconUrl { get; private set; }

	public Func<HtmlHelper, string> Url { get; private set; }

	public PageProfileModel(IPageProfile pageProfile)
		: base(pageProfile)
	{
		Url = (HtmlHelper helper) => null;
		IFormMetadataItemHeader formMetadataItemHeader = AbstractNHEntityManager<IFormMetadataItemHeader, long>.Instance.LoadOrNull(pageProfile.Uid);
		if (formMetadataItemHeader != null)
		{
			DisplayName = formMetadataItemHeader.DisplayName;
			Name = formMetadataItemHeader.Name;
			CreationDate = formMetadataItemHeader.CreationDate;
			if (formMetadataItemHeader.CreationAuthorId.HasValue)
			{
				CreationAuthor = UserManager.Instance.Load(formMetadataItemHeader.CreationAuthorId.Value);
			}
			if (formMetadataItemHeader.Published != null)
			{
				PublishedDate = formMetadataItemHeader.Published.CreationDate;
				if (formMetadataItemHeader.Published.CreationAuthorId.HasValue)
				{
					PublishedAuthor = UserManager.Instance.Load(formMetadataItemHeader.Published.CreationAuthorId.Value);
				}
			}
			IContentAction contentItem2 = ContentActionRegistry.Get("ActionsLinkTypeProvider", ContentActionStatics.ConfigurationPageContentActionId(formMetadataItemHeader.Name, RuntimeVersion.Version1));
			if (contentItem2 != null)
			{
				Url = (HtmlHelper htmlHelper) => contentItem2.GetHref(((ControllerContext)htmlHelper.get_ViewContext()).get_RequestContext());
				IconUrl = contentItem2.GetImage(ObjectIconFormat.x32);
			}
			return;
		}
		ComponentMetadataItemHeader componentMetadataItemHeader = AbstractNHEntityManager<ComponentMetadataItemHeader, long>.Instance.LoadOrNull(pageProfile.Uid);
		if (componentMetadataItemHeader == null)
		{
			return;
		}
		DisplayName = componentMetadataItemHeader.DisplayName;
		Name = componentMetadataItemHeader.Name;
		CreationDate = componentMetadataItemHeader.CreationDate;
		if (componentMetadataItemHeader.CreationAuthorId.HasValue)
		{
			CreationAuthor = UserManager.Instance.Load(componentMetadataItemHeader.CreationAuthorId.Value);
		}
		if (componentMetadataItemHeader.Published != null)
		{
			PublishedDate = componentMetadataItemHeader.Published.CreationDate;
			if (componentMetadataItemHeader.Published.CreationAuthorId.HasValue)
			{
				PublishedAuthor = UserManager.Instance.Load(componentMetadataItemHeader.Published.CreationAuthorId.Value);
			}
		}
		IContentAction contentItem = ContentActionRegistry.Get("ActionsLinkTypeProvider", ContentActionStatics.ConfigurationPageContentActionId(componentMetadataItemHeader.Name, RuntimeVersion.Version2));
		if (contentItem != null)
		{
			Url = (HtmlHelper htmlHelper) => contentItem.GetHref(((ControllerContext)htmlHelper.get_ViewContext()).get_RequestContext());
			IconUrl = contentItem.GetImage(ObjectIconFormat.x32);
		}
	}
}
