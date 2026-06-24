using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Components;

[Component(Type = ComponentType.Server)]
internal class AuthTokenDbStructureProvider : IEntityMappingProvider, IInitHandler
{
	private static AuthTokenDbStructureProvider LE1sXL9r98PW9tpHJ3X;

	public IEnumerable<Type> GetMappingTypes()
	{
		return new Type[1] { typeof(AuthTokenMap) };
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
		int num = 3;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		Table table = default(Table);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			default:
				nXD0lE9SK9R4qu8NW8D(serviceNotNull, table);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				table = new Table
				{
					Name = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2CFDCC80 ^ 0x2CFDB7BA),
					Columns = new List<Column>
					{
						new Column((string)ISA2aR9bOBaeKS2JLdr(0xA5DAE86 ^ 0xA5DA118), DbType.Guid, ColumnProperty.PrimaryKey),
						new Column((string)ISA2aR9bOBaeKS2JLdr(-225736894 ^ -225737640), DbType.Int64),
						new Column((string)ISA2aR9bOBaeKS2JLdr(-1642017152 ^ -1642059876), DbType.DateTime)
					}
				};
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (serviceNotNull.TableExists((string)ISA2aR9bOBaeKS2JLdr(0x738E3073 ^ 0x738E4B49)))
				{
					return;
				}
				num2 = 4;
				break;
			case 3:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 2;
				break;
			}
		}
	}

	public AuthTokenDbStructureProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object ISA2aR9bOBaeKS2JLdr(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void nXD0lE9SK9R4qu8NW8D(object P_0, object P_1)
	{
		((ITransformationProvider)P_0).AddTable((Table)P_1);
	}

	internal static bool rgHim1938hP3KuLwAAv()
	{
		return LE1sXL9r98PW9tpHJ3X == null;
	}

	internal static AuthTokenDbStructureProvider CjUbaR9yodCQBuD34v0()
	{
		return LE1sXL9r98PW9tpHJ3X;
	}
}
