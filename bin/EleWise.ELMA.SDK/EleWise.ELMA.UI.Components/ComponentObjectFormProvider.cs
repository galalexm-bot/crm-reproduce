using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Components;

[Component]
internal sealed class ComponentObjectFormProvider : IObjectFormProvider
{
	private readonly IComponentMetadataItemManager componentMetadataItemManager;

	internal static ComponentObjectFormProvider rSkOGnBZlhh2sOSGmJkN;

	public ComponentObjectFormProvider(IComponentMetadataItemManager componentMetadataItemManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		RMPyprBZ5XGV6KhaWIrh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.componentMetadataItemManager = componentMetadataItemManager;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
			{
				num = 1;
			}
		}
	}

	public bool Check(Guid typeUid, Guid subTypeUid)
	{
		//Discarded unreachable code: IL_005b, IL_006a
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!BKlKr8BZjv2INQ3MKsaO(typeUid, ComponentMetadata.TypeUid))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 2:
				return BKlKr8BZjv2INQ3MKsaO(typeUid, PortletComponentMetadata.TypeUid);
			default:
				return true;
			case 1:
				if (BKlKr8BZjv2INQ3MKsaO(typeUid, PageComponentMetadata.TypeUid))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public (object, ClassMetadata) GetObjectInfo(Guid typeUid, Guid subTypeUid, string model)
	{
		ComponentMetadataItem componentMetadataItem = componentMetadataItemManager.Load(subTypeUid);
		ComponentMetadata componentMetadata = (ComponentMetadata)componentMetadataItem.Metadata;
		Assembly assembly = ComponentManager.FindLoadedAssembly(ScriptExecutionHandlerHelper.CreateFullAssemblyName(componentMetadataItem.AssemblyName, componentMetadataItem.AssemblyVersion, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633531469), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1765855796)), isFullName: true);
		if (assembly == null)
		{
			assembly = ComponentManager.LoadAssembly(componentMetadataItem.ScriptModule.AssemblyRaw, componentMetadataItem.ScriptModule.DebugRaw);
		}
		string name = componentMetadata.FullTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459575553) + componentMetadata.Content.Context.Name;
		Type type = assembly.GetType(name);
		return ((model != string.Empty) ? new EntityJsonSerializer().Deserialize(model, type, loadEntityIfExists: false) : Activator.CreateInstance(type), componentMetadata.Content.Context);
	}

	public FormViewItem GetFormByType(object obj, ViewType viewType)
	{
		throw new NotImplementedException((string)C2hmgNBZYjDBLcS7jyJB(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998471946)));
	}

	public FormViewItem GetFormByUid(object obj, Guid formUid)
	{
		return (FormViewItem)OTZ4AOBZsQfHBtHv6Rq0(cRRlmEBZU5kBRHtiennA((ComponentMetadata)DlhyhxBZLoQeZuUiXGUp(componentMetadataItemManager.Load(formUid))));
	}

	public void InitObject(object obj, ViewType viewType, IDictionary<string, object> arguments)
	{
	}

	internal static void RMPyprBZ5XGV6KhaWIrh()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool QBaNLyBZrRrVSr29SH8f()
	{
		return rSkOGnBZlhh2sOSGmJkN == null;
	}

	internal static ComponentObjectFormProvider CoptviBZgXORFplPWNLX()
	{
		return rSkOGnBZlhh2sOSGmJkN;
	}

	internal static bool BKlKr8BZjv2INQ3MKsaO(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object C2hmgNBZYjDBLcS7jyJB(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object DlhyhxBZLoQeZuUiXGUp(object P_0)
	{
		return ((ComponentMetadataItem)P_0).Metadata;
	}

	internal static object cRRlmEBZU5kBRHtiennA(object P_0)
	{
		return ((ComponentMetadata)P_0).Content;
	}

	internal static object OTZ4AOBZsQfHBtHv6Rq0(object P_0)
	{
		return ((ComponentContentMetadata)P_0).View;
	}
}
