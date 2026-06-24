using System;
using System.Linq.Expressions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security;

public abstract class InstanceSettingsPermissionChildBase<ET, PET, PT> : InstanceSettingsPermissionBase<PET, PT>, IInstanceSettingsPermissionChild, IInstanceSettingsPermission where ET : class where PET : class where PT : class, IInstanceSettingsPermissionHolder
{
	private readonly string parentPropertyName;

	public override Type EntityType => InterfaceActivator.TypeOf<ET>();

	public virtual string ParentPropertyName => parentPropertyName;

	protected InstanceSettingsPermissionChildBase(Expression<Func<PT, PET>> targetExpression, Expression<Func<ET, PET>> parentExpression)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector(targetExpression);
		parentPropertyName = LinqUtils.NameOf(parentExpression);
	}

	public abstract Guid GetParentPermissionId(Guid childPermissionId);
}
