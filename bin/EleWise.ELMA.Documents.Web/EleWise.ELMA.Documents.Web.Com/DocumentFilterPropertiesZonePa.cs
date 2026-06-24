using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Web.Components.Filter;

[Component(Order = 20)]
public class DocumentFilterPropertiesZonePanel : BaseFilterPropertiesZone
{
	public static Guid UID = new Guid("{9FFAD0D6-842C-4741-9F1D-E658FF35C128}");

	private List<Guid> otherUid = new List<Guid>();

	private Guid dmsObjectUid = InterfaceActivator.UID<IDmsObject>();

	private Guid documentUid = InterfaceActivator.UID<IDocument>();

	public IEnumerable<IDocumentPropertyGuidExtension> GuidExtensionPoints { get; set; }

	public override Guid ZoneUid => UID;

	public override ZoneType ZoneType => ZoneType.Panel;

	public override bool ShowHeader => true;

	public override Guid? ParentZone => DocumentFilterPropertiesZoneTab.UID;

	public override string DisplayName => SR.T("Значения для поиска");

	public override MvcHtmlString AdditionalContent(HtmlHelper html, FilterModel model)
	{
		MvcHtmlString val = base.AdditionalContent(html, model);
		return MvcHtmlString.Create(string.Concat(PartialExtensions.Partial(html, "Filter/FilterPropertiesHiddenMainZone", (object)model), ((object)val).ToString()));
	}

	public override bool CheckType(FilterModel model)
	{
		if (model != null && model.Entity != null)
		{
			return model.Entity is IFilterDocumentFolder;
		}
		return false;
	}

	public override bool IsPropertyInZone(FilterModel model, FilterMetadataProperty property)
	{
		if (otherUid.Count < 1)
		{
			foreach (IDocumentPropertyGuidExtension item in GuidExtensionPoints.Where((IDocumentPropertyGuidExtension x) => x.CheckType(UID)))
			{
				otherUid.AddRange(item.GetGuidList());
			}
		}
		bool flag = otherUid.Contains(property.ClassUid);
		List<DocumentMetadata> source = MetadataServiceContext.Service.GetMetadataList().OfType<DocumentMetadata>().ToList();
		List<Guid> list = source.Select((DocumentMetadata m) => m.Uid).Union(source.Select((DocumentMetadata m) => m.ImplementationUid)).ToList();
		list.Add(dmsObjectUid);
		list.Add(documentUid);
		bool flag2 = list.Contains(property.ClassUid) && !DocumentsTypeSendedZonePanel.IsSendedProperty(property.PropertyName);
		if (!flag2)
		{
			if (!flag2)
			{
				return !flag;
			}
			return false;
		}
		return true;
	}
}
