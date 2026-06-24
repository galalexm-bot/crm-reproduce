using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Services;

[Service]
internal sealed class SearchMetadataService : ISearchMetadataServiceInternal, ISearchMetadataService
{
	private readonly ModuleMetadataItemHeaderManager moduleMetadataItemHeaderManager;

	private readonly ModuleMetadataItemManager moduleMetadataItemManager;

	private readonly IDataClassMetadataItemHeaderManager dataClassMetadataItemHeaderManager;

	private readonly IFunctionMetadataItemHeaderManager functionMetadataItemHeaderManager;

	private readonly IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager;

	private readonly IModuleMetadataLoader moduleMetadataLoader;

	private IEnumerable<DataClassMetadata> nonInternalDraftDataClasses;

	private static SearchMetadataService mg8t4UbvSG6WDyJheU2n;

	public SearchMetadataService(ModuleMetadataItemHeaderManager moduleMetadataItemHeaderManager, ModuleMetadataItemManager moduleMetadataItemManager, IDataClassMetadataItemHeaderManager dataClassMetadataItemHeaderManager, IFunctionMetadataItemHeaderManager functionMetadataItemHeaderManager, IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager, IModuleMetadataLoader moduleMetadataLoader)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		G4vVIQbvqBSU99i6udTR();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
		{
			num = 6;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				this.moduleMetadataLoader = moduleMetadataLoader;
				num = 5;
				break;
			default:
				this.moduleMetadataItemManager = moduleMetadataItemManager;
				num = 4;
				break;
			case 5:
				return;
			case 4:
				this.dataClassMetadataItemHeaderManager = dataClassMetadataItemHeaderManager;
				num = 3;
				break;
			case 3:
				this.functionMetadataItemHeaderManager = functionMetadataItemHeaderManager;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num = 0;
				}
				break;
			case 1:
				this.componentMetadataItemHeaderManager = componentMetadataItemHeaderManager;
				num = 2;
				break;
			case 6:
				this.moduleMetadataItemHeaderManager = moduleMetadataItemHeaderManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public IEnumerable<DataClassMetadata> GetPublishedDataClasses()
	{
		List<DataClassMetadata> list = (from a in dataClassMetadataItemHeaderManager.GetAllPublished()
			select a.Published into configurationDataClass
			select (DataClassMetadata)_003C_003Ec.A2qSPFCON0hTI70WJkDZ(configurationDataClass)).ToList();
		foreach (ModuleVersion allDefaultVersion in moduleMetadataLoader.GetAllDefaultVersions(Enumerable.Empty<Guid>()))
		{
			list.AddRange(allDefaultVersion.Metadata.DataClasses);
		}
		return list;
	}

	public IEnumerable<DataClassAssemblyInfo> GetPublishedDataClassAssemblies()
	{
		List<DataClassMetadataItem> list = (from a in dataClassMetadataItemHeaderManager.GetAllPublished()
			select a.Published).ToList();
		List<ModuleMetadataItem> list2 = (from a in moduleMetadataItemHeaderManager.GetAllPublished()
			select (ModuleMetadataItem)_003C_003Ec.elnmrmCO373LcKiG5fej(a)).ToList();
		List<DataClassAssemblyInfo> list3 = new List<DataClassAssemblyInfo>(list.Count + list2.Count);
		list3.AddRange(list.Select(delegate(DataClassMetadataItem dataClass)
		{
			DataClassAssemblyInfo dataClassAssemblyInfo2 = new DataClassAssemblyInfo();
			_003C_003Ec.eZStCNCOaXfjk4tnjCme(dataClassAssemblyInfo2, _003C_003Ec.fycnWqCOpF8XlDU4D812(dataClass));
			_003C_003Ec.AdSMQcCOt5xGKgEQMqj0(dataClassAssemblyInfo2, _003C_003Ec.Dc6J1SCODChmLXqhVch4(dataClass));
			_003C_003Ec.gYOL8ACO4HGrm9mpCrGT(dataClassAssemblyInfo2, _003C_003Ec.jidC5xCOwbr58peZV9yg(dataClass));
			return dataClassAssemblyInfo2;
		}));
		list3.AddRange(list2.Select(delegate(ModuleMetadataItem module)
		{
			DataClassAssemblyInfo dataClassAssemblyInfo = new DataClassAssemblyInfo();
			_003C_003Ec.eZStCNCOaXfjk4tnjCme(dataClassAssemblyInfo, module.AssemblyName);
			_003C_003Ec.AdSMQcCOt5xGKgEQMqj0(dataClassAssemblyInfo, _003C_003Ec.oGUv0rCO6DTjcI4apRVc(module));
			_003C_003Ec.gYOL8ACO4HGrm9mpCrGT(dataClassAssemblyInfo, _003C_003Ec.zJB2VsCOHJ0Rb5HSS2tj(module));
			return dataClassAssemblyInfo;
		}));
		return list3;
	}

	public IEnumerable<DataClassMetadata> GetDraftDataClasses()
	{
		List<DataClassMetadataItem> source = (from a in dataClassMetadataItemHeaderManager.GetAllDrafts()
			select (DataClassMetadataItem)_003C_003Ec.VKXxATCOA7JXVPu2QfjJ(a)).ToList();
		return Enumerable.Concat(second: moduleMetadataItemHeaderManager.GetAllPublished().SelectMany((ModuleMetadataItemHeader a) => ((ModuleInfoMetadata)a.Published.Metadata).DataClasses), first: source.Select((DataClassMetadataItem configurationDataClass) => (DataClassMetadata)configurationDataClass.Metadata));
	}

	public IEnumerable<DataClassMetadata> GetNonInternalDraftDataClasses()
	{
		if (nonInternalDraftDataClasses != null)
		{
			return nonInternalDraftDataClasses;
		}
		IEnumerable<DataClassMetadataItem> source = from a in dataClassMetadataItemHeaderManager.GetAllDrafts()
			select (DataClassMetadataItem)_003C_003Ec.VKXxATCOA7JXVPu2QfjJ(a);
		IEnumerable<DataClassMetadata> second = from a in moduleMetadataItemManager.GetLastPublished(ModuleMetadataItemHeaderManager.DesignerModules).SelectMany((ModuleMetadataItem a) => ((ModuleInfoMetadata)a.Metadata).DataClasses)
			where !_003C_003Ec.FEBpKJCO7HMj5fXYoQ8Q(a)
			select a;
		nonInternalDraftDataClasses = source.Select((DataClassMetadataItem configurationDataClass) => (DataClassMetadata)_003C_003Ec.A2qSPFCON0hTI70WJkDZ(configurationDataClass)).Concat(second);
		return nonInternalDraftDataClasses;
	}

	public IEnumerable<FunctionMetadata> GetPublishedFunctions()
	{
		List<FunctionMetadata> list = (from a in functionMetadataItemHeaderManager.GetAllPublished()
			select (FunctionMetadataItem)_003C_003Ec.WwDfaMCOxnwqNXTxluSw(a)).ToList().Select(delegate(FunctionMetadataItem configurationFunction)
		{
			FunctionMetadata obj = (FunctionMetadata)ClassSerializationHelper.CloneObjectByXml(_003C_003Ec.CfFr7YCO0ctEVv9uUypl(configurationFunction));
			_003C_003Ec.odmBM5COmbXt7HG60UkV(obj, configurationFunction.Header.Uid);
			return obj;
		}).ToList();
		foreach (ModuleMetadataItem item in (from a in moduleMetadataItemHeaderManager.GetAllPublished()
			select (ModuleMetadataItem)_003C_003Ec.elnmrmCO373LcKiG5fej(a)).ToList())
		{
			list.AddRange(((ModuleInfoMetadata)item.Metadata).Functions);
		}
		return list;
	}

	public IEnumerable<FunctionMetadata> GetDraftFunctions()
	{
		List<FunctionMetadata> list = (from a in functionMetadataItemHeaderManager.GetAllDrafts()
			select (FunctionMetadataItem)_003C_003Ec.maXl9oCOyyZHp79SkOHJ(a)).Select(delegate(FunctionMetadataItem configurationFunction)
		{
			FunctionMetadata obj = (FunctionMetadata)ClassSerializationHelper.CloneObjectByXml(_003C_003Ec.CfFr7YCO0ctEVv9uUypl(configurationFunction));
			_003C_003Ec.odmBM5COmbXt7HG60UkV(obj, _003C_003Ec.g2HwvXCOM9GMPPkayusC(configurationFunction.Header));
			return obj;
		}).ToList();
		foreach (ModuleMetadataItem item in (from a in moduleMetadataItemHeaderManager.GetAllPublished()
			select (ModuleMetadataItem)_003C_003Ec.elnmrmCO373LcKiG5fej(a)).ToList())
		{
			list.AddRange(((ModuleInfoMetadata)item.Metadata).Functions);
		}
		return list;
	}

	public IEnumerable<ComponentMetadata> GetPublishedComponents()
	{
		List<ComponentMetadata> list = (from a in componentMetadataItemHeaderManager.GetAllPublished()
			select (ComponentMetadataItem)_003C_003Ec.HcuMJWCOJaRlIl7AdQFI(a)).ToList().Select(delegate(ComponentMetadataItem configurationComponent)
		{
			ComponentMetadata obj = (ComponentMetadata)ClassSerializationHelper.CloneObjectByXml(_003C_003Ec.lmYmW5CO9DWkELBET7Xa(configurationComponent));
			_003C_003Ec.odmBM5COmbXt7HG60UkV(obj, _003C_003Ec.eUZFurCOlGQ2GmdQYQid(_003C_003Ec.NklCmBCOd9LN9ULsuE6k(configurationComponent)));
			return obj;
		}).ToList();
		foreach (ModuleMetadataItem item in (from a in moduleMetadataItemHeaderManager.GetAllPublished()
			select (ModuleMetadataItem)_003C_003Ec.elnmrmCO373LcKiG5fej(a)).ToList())
		{
			list.AddRange(((ModuleInfoMetadata)item.Metadata).Components);
		}
		return list;
	}

	public IEnumerable<ComponentMetadata> GetDraftComponents()
	{
		List<ComponentMetadata> list = (from a in componentMetadataItemHeaderManager.GetAllDrafts()
			select (ComponentMetadataItem)_003C_003Ec.JeAdL4COrVBBj2nSR0Gd(a)).ToList().Select(delegate(ComponentMetadataItem configurationComponent)
		{
			ComponentMetadata obj = (ComponentMetadata)ClassSerializationHelper.CloneObjectByXml(_003C_003Ec.lmYmW5CO9DWkELBET7Xa(configurationComponent));
			_003C_003Ec.odmBM5COmbXt7HG60UkV(obj, _003C_003Ec.eUZFurCOlGQ2GmdQYQid(_003C_003Ec.NklCmBCOd9LN9ULsuE6k(configurationComponent)));
			return obj;
		}).ToList();
		foreach (ModuleMetadataItem item in (from a in moduleMetadataItemHeaderManager.GetAllPublished()
			select (ModuleMetadataItem)_003C_003Ec.elnmrmCO373LcKiG5fej(a)).ToList())
		{
			list.AddRange(((ModuleInfoMetadata)item.Metadata).Components);
		}
		return list;
	}

	void ISearchMetadataServiceInternal.ClearCache()
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
				nonInternalDraftDataClasses = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void G4vVIQbvqBSU99i6udTR()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool WSQZg2bvidIAq3iRKSyV()
	{
		return mg8t4UbvSG6WDyJheU2n == null;
	}

	internal static SearchMetadataService zgQwLqbvRtx5Mw9FThX8()
	{
		return mg8t4UbvSG6WDyJheU2n;
	}
}
