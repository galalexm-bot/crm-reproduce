using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.UIBuilder.Web.Service;

[Component]
[Uid("{567071D9-5E65-41E0-BB5D-13F3D69953A8}")]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
internal sealed class OmniSharpService : IOmniSharpService, IInternalAPIWebService
{
	private const string GuidS = "{567071D9-5E65-41E0-BB5D-13F3D69953A8}";

	private static EleWise.ELMA.Services.IOmniSharpService Service => Locator.GetServiceNotNull<EleWise.ELMA.Services.IOmniSharpService>();

	public void Start(bool needRestart)
	{
		Service.Start(needRestart);
	}

	public Task<string> GetResult(OmniSharpRequest request)
	{
		return Service.GetResult(request);
	}

	public void AddReferences(AddReferencesRequest request)
	{
		Service.AddReferences(request);
	}

	public void RemoveReferences(RemoveReferencesRequest request)
	{
		Service.RemoveReferences(request);
	}
}
