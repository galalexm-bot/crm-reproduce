using System;
using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Web.Models;

public class LifeCycleStatusInfo : EntityModel<ILifeCycleStatus>
{
	public string Prefix { get; set; }

	public long Index { get; set; }

	public string OnChange { get; set; }

	public List<Guid> DocumentTypesFilter { get; set; }

	public Guid TypeUid
	{
		get
		{
			if (base.Entity == null)
			{
				return Guid.Empty;
			}
			if (typeUid == null)
			{
				typeUid = new Lazy<Guid>(() => MetadataLoader.LoadMetadata(base.Entity.GetType()).Uid);
			}
			return typeUid.Value;
		}
	}

	private Lazy<Guid> typeUid { get; set; }

	public LifeCycleStatusInfo()
	{
		DocumentTypesFilter = new List<Guid>();
	}
}
