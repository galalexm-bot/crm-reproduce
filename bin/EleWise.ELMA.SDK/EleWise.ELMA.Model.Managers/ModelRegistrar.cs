using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Properties;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Managers;

[Component(Type = ComponentType.Server)]
internal class ModelRegistrar : INHManagerRegistrar, IMetadataRuntimeService, IMetadataService
{
	private ModelRegistrarImpl impl;

	internal static ModelRegistrar LswlGQhCZLjLEVRQD8Vy;

	private ModelRegistrarImpl Impl
	{
		get
		{
			int num = 2;
			int num2 = num;
			ModelRegistrarImpl modelRegistrarImpl = default(ModelRegistrarImpl);
			ModelRegistrarImpl modelRegistrarImpl2;
			while (true)
			{
				switch (num2)
				{
				case 1:
					modelRegistrarImpl = (impl = (ModelRegistrarImpl)FciXhuhCiPfUUrLlDRVh((ILicensedModuleAssembly)bhwry9hCSZA5ILlMC5OR(ComponentManager.Current.ModuleManager, RuEmnGhCVkC02qRRmA3I())));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					modelRegistrarImpl2 = impl;
					if (modelRegistrarImpl2 != null)
					{
						break;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					modelRegistrarImpl2 = modelRegistrarImpl;
					break;
				}
				break;
			}
			return modelRegistrarImpl2;
		}
	}

	public bool ConfigurationScriptsRecompileRequired => RxqhcVhCXrijiVE396HE(Impl);

	public string ConfigurationScriptsErrors => Impl.ConfigurationScriptsErrors;

	public void Register(NHManagerRegisterParams parameters)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				Impl.Register(this, parameters);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public IMetadata GetParentMetadata(Guid metadataUid)
	{
		return (IMetadata)JIq9eahCRCmUdX3Rjp10(Impl, metadataUid);
	}

	public Type GetTypeByUid(Guid uid, bool loadImplementation = true)
	{
		return Impl.GetTypeByUid(uid, loadImplementation);
	}

	public Type GetTypeByUidOrNull(Guid uid, bool loadImplementation = true)
	{
		return Impl.GetTypeByUidOrNull(uid, loadImplementation);
	}

	public IMetadata GetMetadata(Guid uid, bool loadImplementation = true)
	{
		return Impl.GetMetadata(uid, loadImplementation);
	}

	public void RegisterType(Type type)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				RegisterType(type, asEntity: true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void RegisterType(Type type, bool asEntity)
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
				RegisterTypes(new Type[1] { type }, asEntity, delegate(Type t, Exception ex)
				{
					throw ex;
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void RegisterTypes(IEnumerable<Type> types, Action<Type, Exception> registrationException)
	{
		RegisterTypes(types, asEntity: true, registrationException);
	}

	public void RegisterTypes(IEnumerable<Type> types, bool asEntity, Action<Type, Exception> registrationException = null)
	{
		Impl.RegisterTypes(types, null, registrationException, asEntity);
	}

	public void RegisterTypes(IEnumerable<Type> types, IDictionary<Type, string> entityNames, Action<Type, Exception> registrationException = null)
	{
		Impl.RegisterTypes(types, entityNames, registrationException, asEntity: true);
	}

	internal void LoadAndRegister(MetadataAssemblyPublishResult result, IEnumerable<IRootMetadata> deltaMetadataList)
	{
		Impl.LoadAndRegister(result, deltaMetadataList);
	}

	public IEnumerable<IMetadata> GetMetadataList()
	{
		return Impl.GetMetadataList();
	}

	public IEnumerable<AssemblyModelsMetadata> GetAssemblyModelsMetadataList()
	{
		return Impl.GetAssemblyModelsMetadataList();
	}

	public IEnumerable<AssemblyModelsMetadata> GetPreviousAssemblyModelsMetadataList()
	{
		return Impl.GetPreviousAssemblyModelsMetadataList();
	}

	public IEnumerable<ITypeDescriptor> GetTypeDescriptors()
	{
		return Impl.GetTypeDescriptors();
	}

	public ITypeDescriptor GetTypeDescriptor(Guid typeUid, Guid subTypeUid)
	{
		return (ITypeDescriptor)abtrTqhCqYu1GqWQNFv2(Impl, typeUid, subTypeUid);
	}

	public ITypeDescriptor GetTypeDescriptor(Type runtimeType)
	{
		return Impl.GetTypeDescriptor(runtimeType);
	}

	public IEnumerable<ITypeDescriptor> GetIdTypeDescriptors()
	{
		return Impl.GetIdTypeDescriptors();
	}

	public ITypeDescriptor GetIdTypeDescriptor(Guid typeUid)
	{
		return (ITypeDescriptor)a5kNqIhCKuFmMcgCjf5c(Impl, typeUid);
	}

	public void OnSoftPublished(ICollection<IRootMetadata> metadatas)
	{
		Impl.OnSoftPublished(metadatas);
	}

	public bool IsSystem(Guid typeUid)
	{
		return oDR2q4hCTNFgkghdUDxw(Impl, typeUid);
	}

	public bool IsConfig(Guid typeUid)
	{
		return SZMCjchCkQqSEfaYwOR7(Impl, typeUid);
	}

	public ModelRegistrar()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid RuEmnGhCVkC02qRRmA3I()
	{
		return __AssemblyInfo.UID;
	}

	internal static object bhwry9hCSZA5ILlMC5OR(object P_0, Guid uid)
	{
		return ((IModuleManager)P_0).FindUnitByUid(uid);
	}

	internal static object FciXhuhCiPfUUrLlDRVh(object P_0)
	{
		return ((ILicensedModuleAssembly)P_0).LicenseUnit;
	}

	internal static bool tF9RnqhCuEdCv1aJ7Ev6()
	{
		return LswlGQhCZLjLEVRQD8Vy == null;
	}

	internal static ModelRegistrar QjWhUVhCI8N0OcJHIFde()
	{
		return LswlGQhCZLjLEVRQD8Vy;
	}

	internal static object JIq9eahCRCmUdX3Rjp10(object P_0, Guid metadataUid)
	{
		return ((ModelRegistrarImpl)P_0).GetParentMetadata(metadataUid);
	}

	internal static object abtrTqhCqYu1GqWQNFv2(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((ModelRegistrarImpl)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static object a5kNqIhCKuFmMcgCjf5c(object P_0, Guid typeUid)
	{
		return ((ModelRegistrarImpl)P_0).GetIdTypeDescriptor(typeUid);
	}

	internal static bool RxqhcVhCXrijiVE396HE(object P_0)
	{
		return ((ModelRegistrarImpl)P_0).ConfigurationScriptsRecompileRequired;
	}

	internal static bool oDR2q4hCTNFgkghdUDxw(object P_0, Guid typeUid)
	{
		return ((ModelRegistrarImpl)P_0).IsSystem(typeUid);
	}

	internal static bool SZMCjchCkQqSEfaYwOR7(object P_0, Guid typeUid)
	{
		return ((ModelRegistrarImpl)P_0).IsConfig(typeUid);
	}
}
