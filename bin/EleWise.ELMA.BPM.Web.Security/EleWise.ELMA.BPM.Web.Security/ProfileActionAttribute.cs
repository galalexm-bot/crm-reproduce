using System;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class ProfileActionAttribute : Attribute
{
	public string Name { get; set; }

	public string Image { get; set; }

	public int Order { get; set; }

	public string UserIdParameterName { get; set; }

	public string QueryParameters { get; set; }
}
