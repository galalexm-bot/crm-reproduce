using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

public class TableSelect
{
	internal static TableSelect JMLvopOuhlFck6yUmWrj;

	public string TableName
	{
		[CompilerGenerated]
		get
		{
			return _003CTableName_003Ek__BackingField;
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
					_003CTableName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<string> Joins { get; set; }

	public List<string> Clauses { get; set; }

	public List<int> ChildJoins { get; set; }

	public string Property
	{
		[CompilerGenerated]
		get
		{
			return _003CProperty_003Ek__BackingField;
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
				case 1:
					_003CProperty_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public string GetSql(string selectValueAlias)
	{
		//Discarded unreachable code: IL_0039, IL_0048
		int num = 2;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
			case 5:
				return result;
			case 1:
				if (r0Pes6Ou4nmn0ja329Fs(selectValueAlias))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				result = (string)zARceJODv5w5cqXJrlqg(Fn1q3lOuz5rZAKgDJrmI(--727842433 ^ 0x2B601C87), new object[4]
				{
					serviceNotNull.Dialect.QuoteIfNeeded((string)Fn1q3lOuz5rZAKgDJrmI(0x56F860D7 ^ 0x56F8387D)),
					NZTimUODK2SCXPEys8B5(serviceNotNull.Dialect, TableName),
					string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65B7F624 ^ 0x65B69ECA), Joins),
					(TNOr0NODOtnTs1m3B4Hm(Clauses) > 0) ? bQ9qpwODZRIFtIUhoqUM(Fn1q3lOuz5rZAKgDJrmI(0x7381F16B ^ 0x738074B7), string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1647793954 ^ -1647760084), Clauses)) : ""
				});
				num2 = 3;
				continue;
			case 4:
				break;
			}
			result = (string)zARceJODv5w5cqXJrlqg(Fn1q3lOuz5rZAKgDJrmI(-1516552726 ^ -1516576862), new object[6]
			{
				NZTimUODK2SCXPEys8B5(YwYOIyODYmDLU30344Ob(serviceNotNull), Fn1q3lOuz5rZAKgDJrmI(0x1AF6F1F2 ^ 0x1AF6A958)),
				Property,
				selectValueAlias,
				NZTimUODK2SCXPEys8B5(YwYOIyODYmDLU30344Ob(serviceNotNull), TableName),
				string.Join((string)Fn1q3lOuz5rZAKgDJrmI(-1430645277 ^ -1430553331), Joins),
				(TNOr0NODOtnTs1m3B4Hm(Clauses) > 0) ? bQ9qpwODZRIFtIUhoqUM(Fn1q3lOuz5rZAKgDJrmI(0x1134D2C0 ^ 0x1135571C), string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x10054FD), Clauses)) : ""
			});
			num2 = 5;
		}
	}

	public TableSelect()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				ChildJoins = new List<int>();
				num = 3;
				break;
			default:
				Clauses = new List<string>();
				num = 2;
				break;
			case 1:
				Joins = new List<string>();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
				{
					num = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	internal static bool uUf1ieOuEl41TdVNPepM()
	{
		return JMLvopOuhlFck6yUmWrj == null;
	}

	internal static TableSelect Kp9dXlOuwSUXkfQownOZ()
	{
		return JMLvopOuhlFck6yUmWrj;
	}

	internal static bool r0Pes6Ou4nmn0ja329Fs(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object Fn1q3lOuz5rZAKgDJrmI(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object NZTimUODK2SCXPEys8B5(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static int TNOr0NODOtnTs1m3B4Hm(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static object bQ9qpwODZRIFtIUhoqUM(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object zARceJODv5w5cqXJrlqg(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object YwYOIyODYmDLU30344Ob(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}
}
