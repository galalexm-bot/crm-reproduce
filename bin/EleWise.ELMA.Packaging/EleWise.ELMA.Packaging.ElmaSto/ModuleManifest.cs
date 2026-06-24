using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Packaging.ElmaStoreManifest.Module;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

[Serializable]
[DataContract]
[XmlType(Namespace = "ModuleManifest")]
public sealed class ModuleManifest
{
	public List<DataClassManifest> DataClasses { get; set; }

	public List<FunctionManifest> Functions { get; set; }

	public List<ComponentUIManifest> Components { get; set; }

	public List<ModuleDependency> ModuleDependencies { get; set; }

	public ModuleManifest()
	{
		DataClasses = new List<DataClassManifest>();
		Functions = new List<FunctionManifest>();
		Components = new List<ComponentUIManifest>();
		ModuleDependencies = new List<ModuleDependency>();
	}

	public ICollection<string> CompatibleWith(ModuleManifest manifest, CompatibilityChecker checker)
	{
		if (manifest == null)
		{
			throw new ArgumentNullException("manifest");
		}
		if (checker == null)
		{
			throw new ArgumentNullException("checker");
		}
		return checker(this, manifest);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDataClasses()
	{
		return DataClasses.Count != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeFunctions()
	{
		return Functions.Count != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeComponents()
	{
		return Components.Count != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeModuleDependencies()
	{
		return ModuleDependencies.Count != 0;
	}
}
