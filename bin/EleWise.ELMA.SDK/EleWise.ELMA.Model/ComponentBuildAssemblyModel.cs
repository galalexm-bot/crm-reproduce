using System.Collections.Generic;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model;

public sealed class ComponentBuildAssemblyModel
{
	public ComponentMetadataItem Item { get; }

	public IEnumerable<byte[]> Assemblies { get; }

	public IEnumerable<byte[]> ClientAssemblies { get; }

	internal bool IsSystem { get; }

	public ComponentBuildAssemblyModel(ComponentMetadataItem item, IEnumerable<byte[]> assemblies, IEnumerable<byte[]> clientAssemblies)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(item, assemblies, clientAssemblies, isSystem: false);
	}

	internal ComponentBuildAssemblyModel(ComponentMetadataItem item, IEnumerable<byte[]> assemblies, IEnumerable<byte[]> clientAssemblies, bool isSystem)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Item = item;
		Assemblies = assemblies;
		ClientAssemblies = clientAssemblies;
		IsSystem = isSystem;
	}
}
