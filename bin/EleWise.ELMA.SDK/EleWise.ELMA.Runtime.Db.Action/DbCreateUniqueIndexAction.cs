using System.Linq;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Actions;

public class DbCreateUniqueIndexAction : DbAction
{
	private Index index;

	internal static DbCreateUniqueIndexAction g0h92HWqukZ54eYkprGU;

	public Index Index => index;

	public DbCreateUniqueIndexAction(ITransformationProvider transform, Index index)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(transform);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
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
			this.index = index;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
			{
				num = 1;
			}
		}
	}

	public override void Execute()
	{
		//Discarded unreachable code: IL_00b3
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				base.Transform.AddUniqueIndex(Index);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 6;
				}
				continue;
			case 4:
				if (!HqyWcdWqSbx7R65IjT1g(base.LogMessage))
				{
					num2 = 2;
					continue;
				}
				break;
			case 6:
				return;
			default:
				WriteLogMessage();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				base.Execute();
				num2 = 4;
				continue;
			case 3:
				break;
			}
			base.LogMessage = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957795500), RbLWVDWqiLMyqtBIjUUo(Index), BAK5tUWqRGikHbHiXgKe(Index), string.Join((string)XAhDdJWqqp3TWUFlseu3(0x1FFEF86A ^ 0x1FFEAA9A), Index.Columns.Select((string c) => (string)_003C_003Ec.OptCX1Qw2UbiiD2GiCwN(_003C_003Ec.EAE2hSQwOO0SEDG71uCq(-576149596 ^ -576144644), c, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951511874)))));
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
			{
				num2 = 0;
			}
		}
	}

	internal static bool VvgRSFWqIHXw8cNhBvCh()
	{
		return g0h92HWqukZ54eYkprGU == null;
	}

	internal static DbCreateUniqueIndexAction vN3OsdWqVC6A29YbxVWQ()
	{
		return g0h92HWqukZ54eYkprGU;
	}

	internal static bool HqyWcdWqSbx7R65IjT1g(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object RbLWVDWqiLMyqtBIjUUo(object P_0)
	{
		return ((Index)P_0).Name;
	}

	internal static object BAK5tUWqRGikHbHiXgKe(object P_0)
	{
		return ((Index)P_0).TableName;
	}

	internal static object XAhDdJWqqp3TWUFlseu3(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
