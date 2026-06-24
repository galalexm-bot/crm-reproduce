using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Web.Service.v1;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[Component]
[Uid("{77CE4060-B7C4-4383-A7BD-80C868B793FE}")]
public class AssemblyLoadService : IAssemblyLoadService, IInternalAPIWebService
{
	public const string GuidS = "{77CE4060-B7C4-4383-A7BD-80C868B793FE}";

	public static Guid Guid = new Guid("{77CE4060-B7C4-4383-A7BD-80C868B793FE}");

	public ILogger Logger => EleWise.ELMA.Logging.Logger.Log;

	public AssemblyList LoadAssemblyList(bool loadFiles)
	{
		AssemblyList assemblyList = new AssemblyList();
		List<AssemblyLoadModel> list = new List<AssemblyLoadModel>();
		FileInfo[] files = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", "CompiledModel")).GetFiles("*.dll");
		foreach (FileInfo fileInfo in files)
		{
			AssemblyLoadModel assemblyLoadModel = new AssemblyLoadModel
			{
				AssemblyName = fileInfo.Name,
				Hash = fileInfo.GetHashCode().ToString(CultureInfo.InvariantCulture)
			};
			if (loadFiles)
			{
				assemblyLoadModel.AssemblyData = File.ReadAllBytes(fileInfo.FullName);
			}
			list.Add(assemblyLoadModel);
		}
		assemblyList.AssemblyLoadModels = list.ToArray();
		return assemblyList;
	}
}
