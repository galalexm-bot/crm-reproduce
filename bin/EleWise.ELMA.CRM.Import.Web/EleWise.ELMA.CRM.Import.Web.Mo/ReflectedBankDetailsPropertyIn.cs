using System;
using System.Reflection;

namespace EleWise.ELMA.CRM.Import.Web.Models;

public class ReflectedBankDetailsPropertyInfo : ReflectedEntityPropertyInfo
{
	public PropertyInfo BDMasterProperty { get; set; }

	public string BDPropertyDisplayName { get; set; }

	public Guid BDPropertyUid { get; set; }

	public ReflectedBankDetailsPropertyInfo(PropertyInfo masterProp, string masterPropertyDisplayName, PropertyInfo property, string propertyDisplayName, Guid propertyUid)
	{
		base.MasterProperty = masterProp;
		base.MasterPropertyDisplayName = masterPropertyDisplayName;
		base.Property = property;
		base.PropertyDisplayName = propertyDisplayName;
		base.PropertyUid = propertyUid;
	}
}
