using System;

namespace EleWise.ELMA.Web.Mvc.Attributes;

[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
public class AsyncViewItemActionAttribute : Attribute
{
	public string ParametrName { get; set; }
}
