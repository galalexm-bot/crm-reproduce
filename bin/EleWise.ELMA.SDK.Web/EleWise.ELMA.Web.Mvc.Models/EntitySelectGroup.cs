using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Web.Mvc.Models;

[DataContract]
public class EntitySelectGroup
{
	[IgnoreDataMember]
	private int? level;

	[DataMember]
	public string Header { get; set; }

	public string StyleHeader
	{
		get
		{
			if (Styles == null || string.IsNullOrEmpty(Styles.IconUrl))
			{
				return Header.HtmlEncode();
			}
			return string.Format("<span class=\"iconTypeText\">{0}{1}</span>", HtmlExtensions.Image(Styles.IconUrl, new
			{
				@class = "entityTypeIcon"
			}), Header.HtmlEncode());
		}
	}

	[DataMember]
	public bool ShowHeader { get; set; }

	[DataMember]
	public bool ShowOnTop { get; set; }

	[DataMember]
	public int Order { get; set; }

	[DataMember]
	public EntitySelectGroupStyles Styles { get; set; }

	[DataMember]
	public IEnumerable<IEntity> Entities { get; set; }

	[IgnoreDataMember]
	public int Level
	{
		get
		{
			if (level.HasValue)
			{
				return level.Value;
			}
			if (GetParent == null)
			{
				level = 0;
			}
			if (!level.HasValue)
			{
				EntitySelectGroup entitySelectGroup = GetParent();
				level = ((entitySelectGroup != null) ? (entitySelectGroup.Level + 1) : 0);
			}
			return level.Value;
		}
	}

	[IgnoreDataMember]
	public Func<EntitySelectGroup> GetParent { get; set; }

	[IgnoreDataMember]
	public string Id { get; set; }
}
