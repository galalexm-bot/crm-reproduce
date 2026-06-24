using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities.EntityReferences;

namespace EleWise.ELMA.Documents.Web.Models;

public class ReferenceOnEntityTypeInfo
{
	private Lazy<List<ILifeCycleStatus>> _statuses;

	public ReferenceOnEntityType EntityType { get; set; }

	public string Prefix { get; set; }

	public long Index { get; set; }

	public string OnChange { get; set; }

	public List<ILifeCycleStatus> Statuses
	{
		get
		{
			if (EntityType == null)
			{
				return new List<ILifeCycleStatus>();
			}
			if (_statuses == null)
			{
				_statuses = new Lazy<List<ILifeCycleStatus>>(() => GetStatuses());
			}
			return _statuses.Value;
		}
	}

	private List<ILifeCycleStatus> GetStatuses()
	{
		ILifeCycle lifeCycle = LifeCycleManager.Instance.LoadOrNull(EntityType.TypeUid);
		if (lifeCycle == null)
		{
			return new List<ILifeCycleStatus>();
		}
		return ((IEnumerable<ILifeCycleStatus>)lifeCycle.Statuses).ToList();
	}
}
