using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Components;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

public abstract class WorkLogExtensionBase<TModel> : IWorkLogExtension where TModel : IEntity<long>
{
	public abstract Guid Uid { get; }

	public Guid BaseObjectUid => InterfaceActivator.UID<TModel>();

	public virtual List<Guid> ObjectUidList
	{
		get
		{
			List<Guid> list = new List<Guid>();
			list.Add(BaseObjectUid);
			ClassMetadata metadata = InterfaceActivator.LoadMetadata<TModel>() as ClassMetadata;
			list.AddRange(from m in MetadataLoader.GetChildClasses(metadata)
				select m.Uid);
			return list;
		}
	}

	public virtual List<Guid> DefaultObjectsUidsList => new List<Guid>();

	public IUser DefaultHarmonizator(IEntity entity)
	{
		IWorkLogDefaultHarmonizatorExtension workLogDefaultHarmonizatorExtension = ComponentManager.Current.GetExtensionPoints<IWorkLogDefaultHarmonizatorExtension>().FirstOrDefault();
		if (workLogDefaultHarmonizatorExtension != null)
		{
			IUser user = workLogDefaultHarmonizatorExtension.DefaultHarmonizator(entity);
			if (user != null)
			{
				return user;
			}
		}
		return GetDefaultHarmonizator(entity);
	}

	protected IUser DefaultHarmonizator()
	{
		return WorkLogExtensionHelper.DefaultHarmonizator();
	}

	protected virtual IUser GetDefaultHarmonizator(IEntity entity)
	{
		return null;
	}

	public virtual WorkTime? PlanWorkLog(IEntity entity)
	{
		return null;
	}
}
