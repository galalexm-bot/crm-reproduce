using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.ExtensionPoints;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Actions;

public class DbUpdateIsGroupColumnAction : DbAction
{
	private string tableName;

	private string isGroupColumnName;

	private string parentColumnName;

	private static DbUpdateIsGroupColumnAction AcXmpFWqKYro2WwH9OgF;

	public DbUpdateIsGroupColumnAction(ITransformationProvider transform, string tableName, string isGroupColumnName, string parentColumnName)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		LC5yU8WqkaimTLsPJva3();
		base._002Ector(transform);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				this.parentColumnName = parentColumnName;
				num = 2;
				continue;
			case 1:
				this.isGroupColumnName = isGroupColumnName;
				num = 3;
				continue;
			case 2:
				return;
			}
			this.tableName = tableName;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
			{
				num = 1;
			}
		}
	}

	public override void Execute()
	{
		//Discarded unreachable code: IL_0191, IL_01a0
		int num = 6;
		IUpdateIsGroupColumnExtension updateIsGroupColumnExtension = default(IUpdateIsGroupColumnExtension);
		IEnumerable<IUpdateIsGroupColumnExtension> extensionPoints = default(IEnumerable<IUpdateIsGroupColumnExtension>);
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		IRuntimeApplication service = default(IRuntimeApplication);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					updateIsGroupColumnExtension = extensionPoints.FirstOrDefault(_003C_003Ec__DisplayClass1_._003CExecute_003Eb__0);
					num = 11;
					break;
				case 6:
					service = Locator.GetService<IRuntimeApplication>();
					num2 = 5;
					continue;
				case 10:
					ivdcMYWqOdybBXt50N5i(updateIsGroupColumnExtension, tableName, isGroupColumnName, parentColumnName);
					num2 = 12;
					continue;
				default:
					_003C_003Ec__DisplayClass1_.provider = service.MainProvider;
					num2 = 8;
					continue;
				case 2:
					return;
				case 9:
					return;
				case 12:
					return;
				case 1:
					_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					if (updateIsGroupColumnExtension == null)
					{
						return;
					}
					num = 10;
					break;
				case 8:
					extensionPoints = ((ComponentManager)sB4FFKWqnvhAPrhjKerl()).GetExtensionPoints<IUpdateIsGroupColumnExtension>();
					num2 = 4;
					continue;
				case 3:
					if (service.MainProvider == null)
					{
						num2 = 2;
						continue;
					}
					goto case 1;
				case 5:
					if (service == null)
					{
						return;
					}
					num2 = 3;
					continue;
				case 4:
					if (extensionPoints == null)
					{
						AMcWSGWqeW900jDvB8vX(Logger.Log, SR.T((string)zKlLChWq23wY3hM4UIfV(0x53CACA3 ^ 0x53D5DD5), zKlLChWq23wY3hM4UIfV(0x2ACE37D ^ 0x2AD129D)));
						num = 9;
						break;
					}
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	internal static void LC5yU8WqkaimTLsPJva3()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool JwUhVUWqX1fh53RK4AtV()
	{
		return AcXmpFWqKYro2WwH9OgF == null;
	}

	internal static DbUpdateIsGroupColumnAction VTq8m0WqTmvQkeJC11Pr()
	{
		return AcXmpFWqKYro2WwH9OgF;
	}

	internal static object sB4FFKWqnvhAPrhjKerl()
	{
		return ComponentManager.Current;
	}

	internal static void ivdcMYWqOdybBXt50N5i(object P_0, object P_1, object P_2, object P_3)
	{
		((IUpdateIsGroupColumnExtension)P_0).Execute((string)P_1, (string)P_2, (string)P_3);
	}

	internal static object zKlLChWq23wY3hM4UIfV(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void AMcWSGWqeW900jDvB8vX(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}
}
