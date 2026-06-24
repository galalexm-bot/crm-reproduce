using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.Documents.Web.Components.Filter;

[Component(Order = 110)]
public class DocumentsTypeSendedZonePanel : BaseFilterPropertiesZone
{
	public static Guid UID = new Guid("{F71C34F8-632B-4F59-B1FD-E8298E2A4775}");

	public override Guid ZoneUid => UID;

	public override ZoneType ZoneType => ZoneType.StaticPanel;

	public override string DisplayName => SR.T("Отправления");

	public override Guid? ParentZone => DocumentFilterPropertiesZoneTab.UID;

	public override bool CheckType(FilterModel model)
	{
		if (model != null && model.Entity != null)
		{
			return model.Entity is IFilterDocumentFolder;
		}
		return false;
	}

	public static bool IsSendedProperty(string name)
	{
		if (!(name == LinqUtils.NameOf((Expression<Func<ISendableDocument, object>>)((ISendableDocument d) => d.SendDate))) && !(name == LinqUtils.NameOf((Expression<Func<ISendableDocument, object>>)((ISendableDocument d) => d.SendDocumentType))) && !(name == LinqUtils.NameOf((Expression<Func<ISendableDocument, object>>)((ISendableDocument d) => d.SendNumber))) && !(name == LinqUtils.NameOf((Expression<Func<ISendableDocument, object>>)((ISendableDocument d) => d.SendStatus))))
		{
			return name == LinqUtils.NameOf((Expression<Func<ISendableDocument, object>>)((ISendableDocument d) => d.SendUser));
		}
		return true;
	}

	public override MvcHtmlString AdditionalContent(HtmlHelper html, FilterModel model)
	{
		return MvcHtmlString.Empty;
	}

	public override bool IsPropertyInZone(FilterModel model, FilterMetadataProperty property)
	{
		return false;
	}
}
