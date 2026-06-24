using System;
using System.Linq.Expressions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.ExportHelper;

public class ExportRuleBuilderSelectType<T> : ExportRuleBuilderBase<T>
{
	public ExportRuleBuilderSelectType(ExportRule exportRule, ExportRuleBuilder<T> exportRuleBuilder)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(exportRule, exportRuleBuilder);
	}

	public ExportRuleBuilderSelectAction<T> ForType<T1>()
	{
		rules.ObjectType = InterfaceActivator.TypeOf<T1>();
		return new ExportRuleBuilderSelectAction<T>(this);
	}

	public ExportRuleBuilderSelectAction<T> ForType(Type type)
	{
		rules.ObjectType = InterfaceActivator.TypeOf(type);
		return new ExportRuleBuilderSelectAction<T>(this);
	}

	public ExportRuleBuilderSelectAction<T> ForPropertyName(Type type, string propertyName)
	{
		rules.ParentType = InterfaceActivator.TypeOf(type);
		rules.PropertyName = propertyName;
		return new ExportRuleBuilderSelectAction<T>(this);
	}

	public ExportRuleBuilderSelectAction<T> ForPropertyName<T1>(string propertyName)
	{
		rules.ParentType = InterfaceActivator.TypeOf<T1>();
		rules.PropertyName = propertyName;
		return new ExportRuleBuilderSelectAction<T>(this);
	}

	public ExportRuleBuilderSelectAction<T> ForPropertyName<T1>(Expression<Func<T1, object>> f)
	{
		rules.ParentType = InterfaceActivator.TypeOf<T1>();
		rules.PropertyName = LinqUtils.NameOf(f);
		return new ExportRuleBuilderSelectAction<T>(this);
	}

	public ExportRuleBuilderSelectAction<T> ForPropertyName(string propertyName)
	{
		rules.ParentType = InterfaceActivator.TypeOf(typeof(T));
		rules.PropertyName = propertyName;
		return new ExportRuleBuilderSelectAction<T>(this);
	}

	public ExportRuleBuilderSelectAction<T> ForPropertyName(Expression<Func<T, object>> f)
	{
		rules.ParentType = InterfaceActivator.TypeOf<T>();
		rules.PropertyName = LinqUtils.NameOf(f);
		return new ExportRuleBuilderSelectAction<T>(this);
	}
}
