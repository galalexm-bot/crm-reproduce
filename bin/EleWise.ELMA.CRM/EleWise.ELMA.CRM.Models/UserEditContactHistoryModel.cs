using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Models;

public class UserEditContactHistoryModel : HistoryBaseModel, IEditedHistoryModel<IContact>, IHistoryBaseModel, IContactHistoryBaseModel
{
	private Lazy<List<Guid>> baseProperties;

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public IContact OldEntity { get; set; }

	public IContact NewEntity { get; set; }

	public List<Guid> BaseProperties
	{
		get
		{
			if (baseProperties == null)
			{
				baseProperties = new Lazy<List<Guid>>(() => (from p in ((ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<IContact>())).Properties
					where !p.ViewSettings.GetForView(ViewType.Edit).Visible
					select p.Uid).ToList());
			}
			return baseProperties.Value;
		}
	}

	public UserEditContactHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
