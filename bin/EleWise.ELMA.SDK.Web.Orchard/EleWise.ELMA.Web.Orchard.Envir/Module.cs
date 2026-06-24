using EleWise.ELMA.Modules;
using Orchard.Environment.Extensions.Models;

namespace EleWise.ELMA.Web.Orchard.Enviroment;

public class Module : IWebModuleUnit
{
	private readonly FeatureDescriptor featureDescriptor;

	public string Uid => featureDescriptor.Id;

	public string Name => featureDescriptor.Name;

	public string DisplayName => featureDescriptor.Extension.DisplayName;

	public string Description => featureDescriptor.Description;

	public string WebSite => featureDescriptor.Extension.WebSite;

	public string Author => featureDescriptor.Extension.Author;

	public Module(FeatureDescriptor featureDescriptor)
	{
		this.featureDescriptor = featureDescriptor;
	}

	public Module(Feature feature)
	{
		featureDescriptor = feature.Descriptor;
	}
}
