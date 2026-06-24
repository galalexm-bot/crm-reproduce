using System;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Common.Models.Filters;

public class FilterMetadataProperty
{
	private bool? visible;

	private PropertyViewSettings propertyViewSettings;

	[Obsolete("Используется для преобразования списка полей поиска из формата названий полей в формат Uid полей")]
	public string ClassFullName { get; set; }

	public Guid ClassUid { get; set; }

	public string ClassDisplayName { get; set; }

	public string PropertyName { get; set; }

	public string PropertyDisplayName { get; set; }

	public string PropertyPath { get; set; }

	public Guid PropertyUid { get; set; }

	[Obsolete("Использовать свойство Visible и метод SetVisible", true)]
	public PropertyViewSettings PropertyViewSettings
	{
		get
		{
			return propertyViewSettings;
		}
		set
		{
			propertyViewSettings = value;
			visible = null;
		}
	}

	public bool Visible
	{
		get
		{
			if (!visible.HasValue)
			{
				SetVisible(propertyViewSettings);
			}
			return visible.Value;
		}
		set
		{
			visible = value;
		}
	}

	public bool Hidden { get; set; }

	[Obsolete("Не используется", true)]
	public int Order { get; set; }

	public FilterMetadataProperty SetVisible(PropertyViewSettings propertyViewSettings)
	{
		visible = ((propertyViewSettings != null) ? (propertyViewSettings.GetForView(ViewType.Filter) ?? propertyViewSettings.GetForView(ViewType.Edit)) : null)?.Visible ?? true;
		return this;
	}
}
