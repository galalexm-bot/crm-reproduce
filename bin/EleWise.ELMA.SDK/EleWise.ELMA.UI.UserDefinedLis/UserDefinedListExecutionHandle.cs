using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.UserDefinedList;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Scripts.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.UserDefinedList;

[Component]
internal sealed class UserDefinedListExecutionHandler : IUserDefinedListExecutionHandler
{
	private readonly IComponentMetadataItemManager componentMetadataItemManager;

	private readonly IModuleReferenceManager moduleReferenceManager;

	private readonly IUserDefinedListService userDefinedListService;

	private readonly IModuleMetadataLoader moduleMetadataLoader;

	private readonly IModuleAssemblyLoader moduleAssemblyLoader;

	internal static UserDefinedListExecutionHandler y3VO5JU2cdW0UgAvGIK;

	public UserDefinedListExecutionHandler(IComponentMetadataItemManager componentMetadataItemManager, IModuleReferenceManager moduleReferenceManager, IUserDefinedListService userDefinedListService, IModuleMetadataLoader moduleMetadataLoader, IModuleAssemblyLoader moduleAssemblyLoader)
	{
		//Discarded unreachable code: IL_002a
		EsJL1sU11WWYAsm28jx();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				this.moduleReferenceManager = moduleReferenceManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num = 0;
				}
				break;
			case 4:
				this.moduleMetadataLoader = moduleMetadataLoader;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num = 2;
				}
				break;
			case 2:
				this.moduleAssemblyLoader = moduleAssemblyLoader;
				num = 3;
				break;
			case 1:
			{
				this.componentMetadataItemManager = componentMetadataItemManager;
				int num2 = 5;
				num = num2;
				break;
			}
			default:
				this.userDefinedListService = userDefinedListService;
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num = 3;
				}
				break;
			case 3:
				return;
			}
		}
	}

	public IEnumerable<object> ExecuteGetUserDefinedList(Guid modelSubTypeUid, Guid userDefinedListUid)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals0.modelSubTypeUid = modelSubTypeUid;
		CS_0024_003C_003E8__locals0.userDefinedListUid = userDefinedListUid;
		CS_0024_003C_003E8__locals0.moduleUid = moduleReferenceManager.LoadOrNull(CS_0024_003C_003E8__locals0.modelSubTypeUid)?.ModuleUid ?? Guid.Empty;
		ComponentMetadata componentMetadata;
		if (CS_0024_003C_003E8__locals0.moduleUid == Guid.Empty)
		{
			componentMetadata = (ComponentMetadata)componentMetadataItemManager.Load(CS_0024_003C_003E8__locals0.modelSubTypeUid).Metadata;
		}
		else
		{
			ItemRuntimeModel itemRuntimeModel = ContextVars.GetOrDefault<UIRuntimeModel>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F30BD4E)).RuntimeModules.FirstOrDefault((ItemRuntimeModel a) => _003C_003Ec__DisplayClass6_0.h829OOfU1fpSVJDCFBBo(a.HeaderUid, CS_0024_003C_003E8__locals0.moduleUid));
			if (itemRuntimeModel == null)
			{
				string message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F5A0AA), CS_0024_003C_003E8__locals0.moduleUid);
				Logger.Log.Error(message);
				throw new Exception(message);
			}
			ModuleVersion specificModuleVersion = moduleMetadataLoader.GetSpecificModuleVersion(CS_0024_003C_003E8__locals0.moduleUid, itemRuntimeModel.ItemUid);
			moduleAssemblyLoader.GetServerAssembly(CS_0024_003C_003E8__locals0.moduleUid, itemRuntimeModel.ItemUid);
			componentMetadata = specificModuleVersion.Metadata.Components.FirstOrDefault((ComponentMetadata a) => _003C_003Ec__DisplayClass6_0.h829OOfU1fpSVJDCFBBo(_003C_003Ec__DisplayClass6_0.gBk7FOfUNBnBAfOppAy8(a), CS_0024_003C_003E8__locals0.modelSubTypeUid));
		}
		if (componentMetadata == null)
		{
			string message2 = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921253049), typeof(ComponentMetadata).FullName);
			Logger.Log.Error(message2);
			throw new Exception(message2);
		}
		UserDefinedListInfo userDefinedListInfo = componentMetadata.UserDefinedListInfos.FirstOrDefault((UserDefinedListInfo pdw) => _003C_003Ec__DisplayClass6_0.h829OOfU1fpSVJDCFBBo(_003C_003Ec__DisplayClass6_0.uSJwMMfU3H5EpNcgGIUY(pdw), CS_0024_003C_003E8__locals0.userDefinedListUid));
		if (userDefinedListInfo == null)
		{
			string message3 = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629832050), CS_0024_003C_003E8__locals0.userDefinedListUid.ToString());
			Logger.Log.Error(message3);
			throw new Exception(message3);
		}
		return userDefinedListService.GetUserDefinedList(userDefinedListInfo);
	}

	internal static void EsJL1sU11WWYAsm28jx()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool ME2YrFUetlDRF5aEQAH()
	{
		return y3VO5JU2cdW0UgAvGIK == null;
	}

	internal static UserDefinedListExecutionHandler FjajI7UP7OQQvggCvqa()
	{
		return y3VO5JU2cdW0UgAvGIK;
	}
}
