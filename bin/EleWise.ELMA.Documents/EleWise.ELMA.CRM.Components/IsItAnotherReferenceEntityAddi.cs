using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.CRM.Components;

[Component(Order = 15000)]
public class IsItAnotherReferenceEntityAdditionalCheck : IDocumentsAdditionalChecks
{
	public bool IsItNecessaryType(IEntity ent)
	{
		IEntity entity = ent;
		IEntity parentOrThis = GetParentOrThis(entity);
		while (parentOrThis != entity && parentOrThis != null)
		{
			entity = parentOrThis;
			parentOrThis = GetParentOrThis(entity);
		}
		return parentOrThis != null;
	}

	public object GetFromEntity(IEntity ent)
	{
		IEntity entity = ent;
		IEntity parentOrThis = GetParentOrThis(entity);
		while (parentOrThis != entity && parentOrThis != null)
		{
			entity = parentOrThis;
			parentOrThis = GetParentOrThis(entity);
		}
		return parentOrThis?.CastAsRealType();
	}

	private IEntity GetParentOrThis(IEntity ent)
	{
		PropertyInfo reflectionProperty = ent.GetType().GetReflectionProperty("Parent");
		if (reflectionProperty != null)
		{
			object obj = reflectionProperty.GetValue(ent, null).CastAsRealType();
			if (obj != null)
			{
				return (IEntity)obj.CastAsRealType();
			}
			return null;
		}
		return ent.CastAsRealType();
	}
}
