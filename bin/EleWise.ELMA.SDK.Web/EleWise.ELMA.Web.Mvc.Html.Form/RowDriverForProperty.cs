using System;
using System.Linq.Expressions;
using System.Reflection;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public sealed class RowDriverForProperty<TModel, TValue> : RowDriverForModel<TModel>
{
	public RowDriverForProperty(Expression<Func<TModel, TValue>> forProperty, Type realType = null)
		: base(GetPropertyName(forProperty), realType)
	{
	}

	public RowDriverForProperty(string propertyName, Type realType = null)
		: base(propertyName, realType)
	{
	}

	private static string GetPropertyName(Expression<Func<TModel, TValue>> value)
	{
		if (!(value.Body is MemberExpression memberExpression) || !(memberExpression.Member is PropertyInfo))
		{
			throw new ArgumentException(SR.T("Значение должно быть обращением к свойству"));
		}
		return memberExpression.Member.Name;
	}
}
