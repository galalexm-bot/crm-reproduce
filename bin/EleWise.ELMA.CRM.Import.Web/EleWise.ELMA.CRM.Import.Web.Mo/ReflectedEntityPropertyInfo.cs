using System;
using System.Reflection;

namespace EleWise.ELMA.CRM.Import.Web.Models;

public class ReflectedEntityPropertyInfo
{
	public PropertyInfo MasterProperty { get; set; }

	public string MasterPropertyDisplayName { get; set; }

	public PropertyInfo Property { get; set; }

	public string PropertyDisplayName { get; set; }

	public Guid PropertyUid { get; set; }
}
