using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Web.Mvc.Models;

[DataContract]
public class EntitySelectModel
{
	[IgnoreDataMember]
	private int? level;

	[DataMember]
	public IEntity Entity { get; set; }

	[DataMember]
	[DefaultValue(0)]
	public int Priority { get; set; }

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
				EntitySelectModel entitySelectModel = GetParent();
				level = ((entitySelectModel != null) ? (entitySelectModel.Level + 1) : 0);
			}
			return level.Value;
		}
	}

	[IgnoreDataMember]
	public Func<EntitySelectModel> GetParent { get; set; }
}
