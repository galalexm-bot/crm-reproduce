using System;
using System.Linq;
using EleWise.ELMA.Events;
using Orchard.ContentManagement;
using Orchard.ContentManagement.FieldStorage;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Models;
using Orchard.Localization;
using Orchard.Security;
using Orchard.Settings;

namespace Orchard.Core.Settings.Tokens;

public class SettingsTokens : ITokenProvider, IEventHandler
{
	private readonly IOrchardServices _orchardServices;

	private readonly IContentDefinitionManager _contentDefinitionManager;

	private readonly IMembershipService _membershipService;

	public Localizer T { get; set; }

	public SettingsTokens(IOrchardServices orchardServices, IContentDefinitionManager contentDefinitionManager, IMembershipService membershipService)
	{
		_orchardServices = orchardServices;
		_contentDefinitionManager = contentDefinitionManager;
		_membershipService = membershipService;
	}

	public void Describe(dynamic context)
	{
		context.For("Site", T("Site Settings"), T("Tokens for Site Settings")).Token("SiteName", T("Site Name"), T("The name of the site."), "Text").Token("SuperUser", T("Super User"), T("The super user of the site."), "Text")
			.Token("Culture", T("Site Culture"), T("The current culture of the site."), "Text")
			.Token("BaseUrl", T("Base Url"), T("The base url the site."), "Text")
			.Token("TimeZone", T("Time Zone"), T("The current time zone of the site."), "Text");
		ContentTypeDefinition typeDefinition = _contentDefinitionManager.GetTypeDefinition("Site");
		if (typeDefinition == null || !typeDefinition.Parts.SelectMany((ContentTypePartDefinition x) => x.PartDefinition.Fields).Any())
		{
			return;
		}
		dynamic val = context.For("Site");
		foreach (ContentPartFieldDefinition item in typeDefinition.Parts.SelectMany((ContentTypePartDefinition x) => x.PartDefinition.Fields))
		{
			ContentPartFieldDefinition contentPartFieldDefinition = item;
			string name = contentPartFieldDefinition.Name;
			val.Token(name, T("{0}", contentPartFieldDefinition.Name), T("The setting named {0}.", item.DisplayName), contentPartFieldDefinition.Name);
		}
	}

	public void Evaluate(dynamic context)
	{
		dynamic val = context.For<ISite>("Site", (Func<ISite>)(() => _orchardServices.WorkContext.CurrentSite));
		val.Token("SiteName", (Func<ISite, object>)((ISite content) => content.SiteName)).Chain("SiteName", "Text", (Func<ISite, object>)((ISite content) => content.SiteName)).Token("SuperUser", (Func<ISite, object>)((ISite content) => content.SuperUser))
			.Chain("SuperUser", "User", (Func<ISite, object>)((ISite content) => _membershipService.GetUser(content.SuperUser)))
			.Token("Culture", (Func<ISite, object>)((ISite content) => content.SiteCulture))
			.Chain("Culture", "Text", (Func<ISite, object>)((ISite content) => content.SiteCulture))
			.Token("BaseUrl", (Func<ISite, object>)((ISite content) => content.BaseUrl))
			.Chain("BaseUrl", "Text", (Func<ISite, object>)((ISite content) => content.BaseUrl))
			.Token("TimeZone", (Func<ISite, object>)((ISite content) => content.SiteTimeZone))
			.Chain("TimeZone", "Text", (Func<ISite, object>)((ISite content) => content.SiteTimeZone));
		if (!((context.Target == "Site") ? true : false) || !((val.Data != null && val.Data.ContentItem != null) ? true : false))
		{
			return;
		}
		foreach (ContentPartFieldDefinition item in _contentDefinitionManager.GetTypeDefinition("Site").Parts.SelectMany((ContentTypePartDefinition x) => x.PartDefinition.Fields))
		{
			ContentPartFieldDefinition field = item;
			string name = item.Name;
			val.Token(name, (Func<IContent, object>)((IContent content) => LookupField(content, field.Name).Storage.Get<string>()));
			val.Chain(name, item.FieldDefinition.Name, (Func<IContent, object>)((IContent content) => LookupField(content, field.Name)));
		}
	}

	private static ContentField LookupField(IContent content, string fieldName)
	{
		return content.ContentItem.Parts.Where((ContentPart part) => part.PartDefinition.Name == "Site").SelectMany((ContentPart part) => part.Fields.Where((ContentField field) => field.Name == fieldName)).FirstOrDefault();
	}
}
