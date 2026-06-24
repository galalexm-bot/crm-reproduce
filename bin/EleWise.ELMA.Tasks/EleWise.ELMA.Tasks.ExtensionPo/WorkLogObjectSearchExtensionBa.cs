using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.ExtensionPoints.WorkLog;
using NHibernate;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

public abstract class WorkLogObjectSearchExtensionBase : IWorkLogObjectSearchPermissionExtension, IWorkLogObjectSearchExtension
{
	private readonly List<string> properties = new List<string>();

	private List<Guid> objectTypeUids;

	public abstract Guid Uid { get; }

	public virtual Type BaseObjectType => null;

	public List<Guid> ObjectTypeUids
	{
		get
		{
			if (objectTypeUids == null)
			{
				if (BaseObjectType == null)
				{
					throw new Exception(SR.T("Не указан тип объекта, с которым работает точка расширения."));
				}
				if (!(MetadataLoader.LoadMetadata(BaseObjectType) is EntityMetadata entityMetadata))
				{
					throw new Exception(SR.T("Тип объекта, указанный в точке расширения, не является типом сущности."));
				}
				objectTypeUids = new List<Guid> { entityMetadata.Uid };
				objectTypeUids.AddRange(from m in MetadataLoader.GetChildClasses(entityMetadata)
					select m.Uid);
			}
			return objectTypeUids;
		}
	}

	public List<string> Properties => properties;

	public virtual bool GroupBySearch => true;

	protected WorkLogObjectSearchExtensionBase()
	{
		Init();
		AddProperty((IWorkLogItemSearchFilter m) => m.EntityType);
	}

	protected abstract void Init();

	public virtual void SetupFilter(IEntityFilter entityFilter, IWorkLogObjectSearchFilter filter)
	{
	}

	public virtual void SetupCriteria(ICriteria criteria, IWorkLogObjectSearchFilter filter)
	{
	}

	public virtual bool HasPermission(Guid typeUid)
	{
		return true;
	}

	protected void AddProperty<TFilter>(Expression<Func<TFilter, object>> propertyExpr)
	{
		if (propertyExpr == null)
		{
			throw new ArgumentNullException("propertyExpr");
		}
		string item = ((!(propertyExpr.Body is MemberExpression)) ? ((MemberExpression)((UnaryExpression)propertyExpr.Body).Operand).Member.Name : ((MemberExpression)propertyExpr.Body).Member.Name);
		Properties.Add(item);
	}

	protected void AddPropertyGlobal<TValue>(Expression<Func<IWorkLogObjectSearchFilter, TValue>> propertyExpr)
	{
		if (propertyExpr == null)
		{
			throw new ArgumentNullException("propertyExpr");
		}
		Properties.Add(((MemberExpression)propertyExpr.Body).Member.Name);
	}
}
