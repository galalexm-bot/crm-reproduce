using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers;

public class MetadataItemHeaderDtoManager : DTOManager, IMetadataItemHeaderDtoManager, IConfigurationService
{
	internal static MetadataItemHeaderDtoManager rjQv0yb5QW003QdeA4Ga;

	public MetadataItemHeaderManager MetadataItemHeaderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadataItemHeaderManager_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CMetadataItemHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<IDependenciesExtension> DependenciesExtensions { get; set; }

	public virtual IEnumerable<string> GetGlobalModuleNames(IEnumerable<EntityMetadata> mds)
	{
		List<string> list = new List<string>();
		using IEnumerator<EntityMetadata> enumerator = mds.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
			CS_0024_003C_003E8__locals0.md = enumerator.Current;
			if (CS_0024_003C_003E8__locals0.md.IsConfig())
			{
				IMetadataItemHeader metadataItemHeader = AbstractNHEntityManager<IMetadataItemHeader, long>.Instance.LoadOrNull(CS_0024_003C_003E8__locals0.md.Uid);
				if (metadataItemHeader == null || metadataItemHeader.Published == null || metadataItemHeader.Published.ScriptModule == null || metadataItemHeader.Published.ScriptModule.GlobalScriptModules == null)
				{
					continue;
				}
				foreach (AssemblyReference globalScriptModule in metadataItemHeader.Published.ScriptModule.GlobalScriptModules)
				{
					list.AddIfNotContains(globalScriptModule.Name);
				}
				continue;
			}
			foreach (EntityMetadata item in MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>().Where(delegate(EntityMetadata m)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return _003C_003Ec__DisplayClass8_0.klocTcCxDATUMAb3hIUS(_003C_003Ec__DisplayClass8_0.aKGxvsCxp0DVI9QetY7a(m), _003C_003Ec__DisplayClass8_0.i4sewZCxaCRvqZOWs5Dj(CS_0024_003C_003E8__locals0.md));
					case 1:
						if (m.Type != EntityMetadataType.InterfaceExtension)
						{
							return false;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}))
			{
				IMetadataItemHeader metadataItemHeader2 = AbstractNHEntityManager<IMetadataItemHeader, long>.Instance.LoadOrNull(item.Uid);
				if (metadataItemHeader2 == null || metadataItemHeader2.Published == null || metadataItemHeader2.Published.ScriptModule == null || metadataItemHeader2.Published.ScriptModule.GlobalScriptModules == null)
				{
					continue;
				}
				foreach (AssemblyReference globalScriptModule2 in metadataItemHeader2.Published.ScriptModule.GlobalScriptModules)
				{
					list.AddIfNotContains(globalScriptModule2.Name);
				}
			}
		}
		return list;
	}

	public virtual IDictionary<Guid, string> GetObjectsUidsFromDependencies(Guid uid)
	{
		_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
		CS_0024_003C_003E8__locals0.uid = uid;
		Dictionary<Guid, string> result = new Dictionary<Guid, string>();
		IEnumerable<IDependencyContainer> source = DependenciesExtensions.SelectMany((IDependenciesExtension point) => point.GetDependencyContainers(CS_0024_003C_003E8__locals0.uid));
		foreach (MetadataDependencyContainer item in source.OfType<MetadataDependencyContainer>())
		{
			GetObjectsUidsFromDependencies(item, result);
		}
		foreach (ScriptModuleDependencyContainer item2 in source.OfType<ScriptModuleDependencyContainer>())
		{
			GetObjectsUidsFromDependencies(item2, result);
		}
		return result;
	}

	private void GetObjectsUidsFromDependencies(MetadataDependencyContainer dependencies, IDictionary<Guid, string> result)
	{
		if (result == null)
		{
			result = result ?? new Dictionary<Guid, string>();
		}
		if (dependencies == null)
		{
			return;
		}
		GetObjectsUidsFromDependencies(dependencies.EntityDependencies, ref result);
		GetObjectsUidsFromDependencies(dependencies.DataClassDependencies, ref result);
		GetObjectsUidsFromDependencies(dependencies.FunctionDependencies, ref result);
		if (dependencies.FormDependencies == null)
		{
			return;
		}
		foreach (FormViewItemDependencyContainer formDependency in dependencies.FormDependencies)
		{
			GetObjectsUidsFromDependencies(formDependency.EntityDependencies, ref result);
			GetObjectsUidsFromDependencies(formDependency.DataClassDependencies, ref result);
			GetObjectsUidsFromDependencies(formDependency.ComponentDependencies, ref result);
		}
	}

	private void GetObjectsUidsFromDependencies(ScriptModuleDependencyContainer dependencies, IDictionary<Guid, string> result)
	{
		if (result == null)
		{
			result = result ?? new Dictionary<Guid, string>();
		}
		if (dependencies != null)
		{
			GetObjectsUidsFromDependencies(dependencies.EntityDependencies, ref result);
			GetObjectsUidsFromDependencies(dependencies.DataClassDependencies, ref result);
		}
	}

	private void GetObjectsUidsFromDependencies(List<EntityDependency> entityDependencies, ref IDictionary<Guid, string> result)
	{
		if (result == null)
		{
			result = result ?? new Dictionary<Guid, string>();
		}
		if (entityDependencies == null)
		{
			return;
		}
		_ = MetadataServiceContext.Service;
		foreach (EntityDependency entityDependency in entityDependencies)
		{
			if (entityDependency.Properties == null)
			{
				continue;
			}
			foreach (PropertySignature property in entityDependency.Properties)
			{
				IMetadataItemHeader metadataItemHeader;
				if (property?.Type != null && !result.ContainsKey(property.Type.SubTypeUid) && (metadataItemHeader = MetadataItemHeaderManager.LoadOrNull(property.Type.SubTypeUid)) != null)
				{
					result.Add(property.Type.SubTypeUid, metadataItemHeader.DisplayName);
				}
			}
		}
	}

	private void GetObjectsUidsFromDependencies(List<DataClassDependency> dataClassDependencies, ref IDictionary<Guid, string> result)
	{
		if (result == null)
		{
			result = result ?? new Dictionary<Guid, string>();
		}
		if (dataClassDependencies == null)
		{
			return;
		}
		DataClassMetadataItemHeaderManager instance = DataClassMetadataItemHeaderManager.Instance;
		foreach (DataClassDependency dataClassDependency in dataClassDependencies)
		{
			if (dataClassDependency.Properties == null)
			{
				continue;
			}
			foreach (PropertySignature property in dataClassDependency.Properties)
			{
				DataClassMetadataItemHeader dataClassMetadataItemHeader;
				if (property?.Type != null && !result.ContainsKey(property.Type.SubTypeUid) && (dataClassMetadataItemHeader = instance.LoadOrNull(property.Type.SubTypeUid)) != null)
				{
					result.Add(property.Type.SubTypeUid, dataClassMetadataItemHeader.DisplayName);
				}
			}
		}
	}

	private void GetObjectsUidsFromDependencies(List<ComponentDependency> componentDependencies, ref IDictionary<Guid, string> result)
	{
		if (result == null)
		{
			result = result ?? new Dictionary<Guid, string>();
		}
		if (componentDependencies == null)
		{
			return;
		}
		ComponentMetadataItemHeaderManager instance = ComponentMetadataItemHeaderManager.Instance;
		foreach (ComponentDependency componentDependency in componentDependencies)
		{
			if (componentDependency.Inputs == null)
			{
				continue;
			}
			foreach (InputComputedValue input in componentDependency.Inputs)
			{
				ComponentMetadataItemHeader componentMetadataItemHeader;
				if (input != null && !result.ContainsKey(input.SubTypeUid) && (componentMetadataItemHeader = instance.LoadOrNull(input.SubTypeUid)) != null)
				{
					result.Add(input.SubTypeUid, componentMetadataItemHeader.DisplayName);
				}
			}
		}
	}

	private void GetObjectsUidsFromDependencies(List<FunctionDependency> functionDependencies, ref IDictionary<Guid, string> result)
	{
		if (result == null)
		{
			result = result ?? new Dictionary<Guid, string>();
		}
		if (functionDependencies == null)
		{
			return;
		}
		FunctionMetadataItemHeaderManager instance = FunctionMetadataItemHeaderManager.Instance;
		foreach (FunctionDependency functionDependency in functionDependencies)
		{
			FunctionMetadataItemHeader functionMetadataItemHeader;
			if (functionDependency != null && (functionDependency.ParameterType?.SubTypeUid).HasValue && !result.ContainsKey(functionDependency.ParameterType.SubTypeUid) && (functionMetadataItemHeader = instance.LoadOrNull(functionDependency.ParameterType.SubTypeUid)) != null)
			{
				result.Add(functionDependency.ParameterType.SubTypeUid, functionMetadataItemHeader.DisplayName);
			}
			FunctionMetadataItemHeader functionMetadataItemHeader2;
			if (functionDependency != null && (functionDependency.ReturnType?.SubTypeUid).HasValue && !result.ContainsKey(functionDependency.ReturnType.SubTypeUid) && (functionMetadataItemHeader2 = instance.LoadOrNull(functionDependency.ReturnType.SubTypeUid)) != null)
			{
				result.Add(functionDependency.ReturnType.SubTypeUid, functionMetadataItemHeader2.DisplayName);
			}
		}
	}

	public MetadataItemHeaderDtoManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool i5lfE7b5C9op2pCcD9nE()
	{
		return rjQv0yb5QW003QdeA4Ga == null;
	}

	internal static MetadataItemHeaderDtoManager VgWgj2b5vr1PXLYZvpTe()
	{
		return rjQv0yb5QW003QdeA4Ga;
	}
}
