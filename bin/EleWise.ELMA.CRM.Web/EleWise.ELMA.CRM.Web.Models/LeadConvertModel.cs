using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.CRM.Web.Models;

public class LeadConvertModel : EntityModel<ILead>
{
	public IEnumerable<ExtendedSelectListItem> ContractorTypes { get; private set; }

	public Guid ContractorUid { get; set; }

	public IContractorBaseModel Contractor { get; set; }

	public IEnumerable<ExtendedSelectListItem> ConvertTypes { get; private set; }

	public Guid ConvertUid { get; set; }

	public List<IContact> Contacts { get; set; }

	public SaleModel Sale { get; set; }

	public IRelationshipBaseModel Relationship { get; set; }

	public string Comment { get; set; }

	public bool? RuntimeVersion2 { get; set; }

	public LeadConvertModel()
	{
		ClassMetadata metadata = (ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<IContractor>());
		ClassMetadata metadata2 = (ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<IRelationship>());
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<ISale>());
		ContractorTypes = MetadataLoader.GetChildClasses(metadata).Select(delegate(ClassMetadata md)
		{
			ExtendedSelectListItem extendedSelectListItem2 = new ExtendedSelectListItem();
			((SelectListItem)extendedSelectListItem2).set_Text(md.DisplayName);
			((SelectListItem)extendedSelectListItem2).set_Value(md.Uid.ToString());
			((SelectListItem)extendedSelectListItem2).set_Selected(md.Uid == InterfaceActivator.UID<IContractorLegal>());
			return extendedSelectListItem2;
		});
		ConvertTypes = new ClassMetadata[1] { classMetadata }.Concat(MetadataLoader.GetChildClasses(metadata2)).Concat(new ClassMetadata[1]).Select(delegate(ClassMetadata md)
		{
			ExtendedSelectListItem extendedSelectListItem = new ExtendedSelectListItem();
			((SelectListItem)extendedSelectListItem).set_Text((md != null) ? md.DisplayName : SR.T("Не создавать"));
			string value;
			if (md == null)
			{
				Guid empty = Guid.Empty;
				value = empty.ToString();
			}
			else
			{
				value = md.Uid.ToString();
			}
			((SelectListItem)extendedSelectListItem).set_Value(value);
			((SelectListItem)extendedSelectListItem).set_Selected(md != null && md.Uid == InterfaceActivator.UID<ISale>());
			extendedSelectListItem.HtmlAttributes = new
			{
				onclick = "changeStep4(this)"
			};
			return extendedSelectListItem;
		});
	}
}
