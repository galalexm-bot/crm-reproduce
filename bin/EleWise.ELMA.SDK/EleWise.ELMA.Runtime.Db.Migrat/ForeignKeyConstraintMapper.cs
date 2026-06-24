using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Migrator.Providers;

public class ForeignKeyConstraintMapper
{
	private static ForeignKeyConstraintMapper GhXM50WOCFOqY0wxcCwC;

	public string SqlForConstraint(ForeignKeyConstraint constraint)
	{
		//Discarded unreachable code: IL_0061, IL_0070
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				switch (constraint)
				{
				case ForeignKeyConstraint.Cascade:
					goto IL_007b;
				case ForeignKeyConstraint.Restrict:
					return (string)kQlkWeWOZEdt02D5e9R3(-195614443 ^ -195743771);
				case ForeignKeyConstraint.SetDefault:
					return (string)kQlkWeWOZEdt02D5e9R3(-1921202237 ^ -1921072953);
				case ForeignKeyConstraint.SetNull:
					return (string)kQlkWeWOZEdt02D5e9R3(-1858887263 ^ -1859017025);
				case ForeignKeyConstraint.NoAction:
					goto end_IL_0012;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				goto IL_007b;
				IL_007b:
				return (string)kQlkWeWOZEdt02D5e9R3(-978351861 ^ -978481195);
				end_IL_0012:
				break;
			}
			break;
		}
		return (string)kQlkWeWOZEdt02D5e9R3(-1088304168 ^ -1088172822);
	}

	public ForeignKeyConstraintMapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object kQlkWeWOZEdt02D5e9R3(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool iyNjjZWOvJLLIpQHYLcv()
	{
		return GhXM50WOCFOqY0wxcCwC == null;
	}

	internal static ForeignKeyConstraintMapper OTh08xWO8ogXKyyePM34()
	{
		return GhXM50WOCFOqY0wxcCwC;
	}
}
