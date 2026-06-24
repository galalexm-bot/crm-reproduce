using System;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Rebranding;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.Web.API;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[Component]
[Uid("{CE041FC4-74FE-4503-B8BA-F963DB2FFC5D}")]
public class BrandPackageService : IBrandPackageService, IInternalAPIWebService
{
	public const string GuidS = "{CE041FC4-74FE-4503-B8BA-F963DB2FFC5D}";

	public static Guid Guid = new Guid("{CE041FC4-74FE-4503-B8BA-F963DB2FFC5D}");

	public Stream Get()
	{
		return BrandResourceManager.GetBrandPackage();
	}
}
