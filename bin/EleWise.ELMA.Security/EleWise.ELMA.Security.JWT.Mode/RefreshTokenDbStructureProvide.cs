using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.JWT.Models;

[Component(Type = ComponentType.Server)]
internal class RefreshTokenDbStructureProvider : IEntityMappingProvider, IInitHandler
{
	private static RefreshTokenDbStructureProvider gFoMpGgdRKx9QKR8nBD;

	public IEnumerable<Type> GetMappingTypes()
	{
		return new Type[1] { typeof(RefreshTokenMap) };
	}

	public void Init()
	{
	}

	public void InitComplete()
	{
		CreateStructure();
	}

	private void CreateStructure()
	{
		//Discarded unreachable code: IL_0039, IL_0048
		int num = 2;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		Table table = default(Table);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			default:
				gVJwGEgrJv0Fr32l5qs(serviceNotNull, table);
				num2 = 3;
				continue;
			case 2:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				if (serviceNotNull.TableExists((string)OOBQNFg8NCnP9l7RlMo(0x40944BC4 ^ 0x4094A33C)))
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			case 4:
				break;
			case 3:
				return;
			}
			table = new Table
			{
				Name = (string)OOBQNFg8NCnP9l7RlMo(-1365352774 ^ -1365330366),
				Columns = new List<Column>
				{
					new Column((string)OOBQNFg8NCnP9l7RlMo(0xBBC1CCD ^ 0xBBC1353), DbType.Guid, ColumnProperty.PrimaryKey),
					new Column(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x67DFA65E ^ 0x67DFA544), DbType.Int64),
					new Column((string)OOBQNFg8NCnP9l7RlMo(-185816410 ^ -185842758), DbType.DateTime),
					new Column(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x38328F00 ^ 0x38326634), DbType.StringFixedLength, 250)
				}
			};
			num2 = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 != 0)
			{
				num2 = 0;
			}
		}
	}

	public RefreshTokenDbStructureProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oeoQwWg3rmiRJpXVpG7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object OOBQNFg8NCnP9l7RlMo(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void gVJwGEgrJv0Fr32l5qs(object P_0, object P_1)
	{
		((ITransformationProvider)P_0).AddTable((Table)P_1);
	}

	internal static bool pf8fwtgTH3R8mB1qvuA()
	{
		return gFoMpGgdRKx9QKR8nBD == null;
	}

	internal static RefreshTokenDbStructureProvider ChPh8sggyOWK1MHJExi()
	{
		return gFoMpGgdRKx9QKR8nBD;
	}

	internal static void oeoQwWg3rmiRJpXVpG7()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
