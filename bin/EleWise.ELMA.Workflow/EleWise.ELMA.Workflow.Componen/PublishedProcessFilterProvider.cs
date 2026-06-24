using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component]
public class PublishedProcessFilterProvider : IEntityFilterProvider
{
	public const string UID_S = "F2F32E2E-7C52-4743-8F6B-F868043D5FC6";

	public static readonly Guid UID;

	private static PublishedProcessFilterProvider YXxCQ7O0xmsuJEkfIQu1;

	public virtual Guid ProviderUid => UID;

	public virtual void ApplyFilter(IEntityFilter filter, string data)
	{
		int num = 4;
		int num2 = num;
		IProcessHeaderFilter processHeaderFilter = default(IProcessHeaderFilter);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				if (processHeaderFilter == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
					{
						num2 = 0;
					}
					break;
				}
				processHeaderFilter.HasPublished = true;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				filter.Query = data;
				num2 = 2;
				break;
			case 4:
				processHeaderFilter = filter as IProcessHeaderFilter;
				num2 = 3;
				break;
			case 0:
				return;
			case 2:
				return;
			}
		}
	}

	public string GetFilterProviderData(Type entityType, PropertyMetadata propertyMetadata, ViewAttributes viewAttributes)
	{
		//Discarded unreachable code: IL_00ac, IL_00c6, IL_00d0, IL_00df
		int num = 9;
		int num2 = num;
		EntitySettings entitySettings = default(EntitySettings);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 8:
				if (propertyMetadata == null)
				{
					num2 = 4;
					continue;
				}
				if (!KxleKmO0Etnq9YS22dTs(propertyMetadata.SubTypeUid, InterfaceActivator.UID<IProcessHeader>(loadImplementation: false)))
				{
					num2 = 6;
					continue;
				}
				goto case 1;
			case 1:
				if (viewAttributes == null)
				{
					num2 = 3;
					continue;
				}
				goto case 5;
			case 7:
				return "";
			case 6:
				return null;
			case 4:
				return null;
			default:
				if (entitySettings != null)
				{
					return entitySettings.FilterQuery;
				}
				num2 = 7;
				continue;
			case 2:
			case 3:
				obj = A41xkvO04BcDag3fIHXb(propertyMetadata) as EntitySettings;
				break;
			case 9:
				if (!mLWoBcO0hbQW7XGSNXwN(entityType, null))
				{
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
					{
						num2 = 8;
					}
					continue;
				}
				goto case 4;
			case 5:
				if (jh7pM3O0wTakskAAYf5i(viewAttributes) == null)
				{
					num2 = 2;
					continue;
				}
				obj = jh7pM3O0wTakskAAYf5i(viewAttributes) as EntitySettings;
				break;
			}
			entitySettings = (EntitySettings)obj;
			num2 = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
			{
				num2 = 0;
			}
		}
	}

	public IEntityFilter GetFilter(Guid uid, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_004c, IL_0088, IL_0097, IL_00d7, IL_00e6, IL_012f, IL_0146, IL_0155
		switch (1)
		{
		case 1:
			try
			{
				IProcessHeaderFilter processHeaderFilter = filter as IProcessHeaderFilter;
				int num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
				{
					num = 0;
				}
				IEntityFilter result = default(IEntityFilter);
				while (true)
				{
					switch (num)
					{
					case 2:
						return result;
					case 4:
						return result;
					default:
						if (processHeaderFilter == null)
						{
							num = 3;
							continue;
						}
						break;
					case 1:
					case 3:
						result = (IEntityFilter)rNm2hJOyKinXhJbiyErn(wfZNtlO0zjtrlloqnT9N(typeof(IProcessHeaderFilter).TypeHandle));
						num = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
						{
							num = 4;
						}
						continue;
					case 5:
						break;
					}
					result = processHeaderFilter;
					num = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
					{
						num = 2;
					}
				}
			}
			catch
			{
				int num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			break;
		}
		return null;
	}

	public PublishedProcessFilterProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PublishedProcessFilterProvider()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				UID = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACCDD87 ^ 0x2ACD64FF));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				pwXI5COyOKkoQLlwRvpS();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool TvLI3VO0SiiJL5vQ0Uu2()
	{
		return YXxCQ7O0xmsuJEkfIQu1 == null;
	}

	internal static PublishedProcessFilterProvider Po5KTgO01AafDmMxAmx6()
	{
		return YXxCQ7O0xmsuJEkfIQu1;
	}

	internal static bool mLWoBcO0hbQW7XGSNXwN(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool KxleKmO0Etnq9YS22dTs(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object jh7pM3O0wTakskAAYf5i(object P_0)
	{
		return ((ViewAttributes)P_0).TypeSettings;
	}

	internal static object A41xkvO04BcDag3fIHXb(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static Type wfZNtlO0zjtrlloqnT9N(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object rNm2hJOyKinXhJbiyErn(Type P_0)
	{
		return InterfaceActivator.Create(P_0);
	}

	internal static void pwXI5COyOKkoQLlwRvpS()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
