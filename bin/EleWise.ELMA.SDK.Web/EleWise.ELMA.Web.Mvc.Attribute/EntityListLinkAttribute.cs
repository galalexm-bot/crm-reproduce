using System;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Web.Mvc.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class EntityListLinkAttribute : Attribute
{
	public Type EntityType { get; set; }

	public EntityListLinkAttribute(Type entityType)
	{
		EntityType = InterfaceActivator.TypeOf(entityType);
	}
}
