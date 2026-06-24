using System;

namespace EleWise.ELMA.Web.Mvc.Portlets;

public class PersonalizationAttribute : Attribute
{
	private PersonalizationScope scope;

	public PersonalizationScope Scope => scope;

	public PersonalizationAttribute(PersonalizationScope scope)
	{
		this.scope = scope;
	}
}
