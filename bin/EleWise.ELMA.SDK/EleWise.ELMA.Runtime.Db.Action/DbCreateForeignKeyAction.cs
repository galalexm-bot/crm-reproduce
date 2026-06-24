using System.Linq;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Actions;

public class DbCreateForeignKeyAction : DbAction
{
	private ForeignKey foreignKey;

	private static DbCreateForeignKeyAction YW98VeWKpXYYaXZNNI0R;

	public ForeignKey ForeignKey => foreignKey;

	public DbCreateForeignKeyAction(ITransformationProvider transform, ForeignKey foreignKey)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		WKkvkDWKtSt6VaNmx40S();
		base._002Ector(transform);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.foreignKey = foreignKey;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void Execute()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				vFT35xWKAfmV8tnL9wdV(base.Transform, ForeignKey);
				num2 = 2;
				continue;
			case 2:
				return;
			case 4:
				base.Execute();
				num2 = 3;
				continue;
			case 5:
				WriteLogMessage();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				if (X6abiuWKwElBYmgvnWpa(base.LogMessage))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 5;
			}
			base.LogMessage = SR.T((string)BdOGdhWK4J6qXL0VxWVN(-281842504 ^ -281896618), GMFdbWWK6IVv8VvIGPfx(ForeignKey), AQ7y7VWKHmu3QIBQ4VSg(ForeignKey), (ForeignKey.Columns != null) ? string.Join((string)BdOGdhWK4J6qXL0VxWVN(0x103FE975 ^ 0x103FBB85), ForeignKey.Columns.Select((string c) => (string)_003C_003Ec.xfE0uDQw4DXdoVhSnnky(_003C_003Ec.URxg0SQwwQ6P65UsYwpw(-1979251663 ^ -1979246231), c, _003C_003Ec.URxg0SQwwQ6P65UsYwpw(-606654180 ^ -606655420)))) : "", ForeignKey.RefTableName, (ForeignKey.RefColumns != null) ? string.Join((string)BdOGdhWK4J6qXL0VxWVN(-629844702 ^ -629864494), ForeignKey.RefColumns.Select((string c) => (string)_003C_003Ec.xfE0uDQw4DXdoVhSnnky(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CB5B13), c, _003C_003Ec.URxg0SQwwQ6P65UsYwpw(-978351861 ^ -978348973)))) : "");
			num2 = 5;
		}
	}

	internal static void WKkvkDWKtSt6VaNmx40S()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Wlt7IUWKaHUnqw7hVPDB()
	{
		return YW98VeWKpXYYaXZNNI0R == null;
	}

	internal static DbCreateForeignKeyAction sYH5CeWKDw5oBUsZIaVQ()
	{
		return YW98VeWKpXYYaXZNNI0R;
	}

	internal static bool X6abiuWKwElBYmgvnWpa(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object BdOGdhWK4J6qXL0VxWVN(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object GMFdbWWK6IVv8VvIGPfx(object P_0)
	{
		return ((ForeignKey)P_0).Name;
	}

	internal static object AQ7y7VWKHmu3QIBQ4VSg(object P_0)
	{
		return ((ForeignKey)P_0).TableName;
	}

	internal static void vFT35xWKAfmV8tnL9wdV(object P_0, object P_1)
	{
		((ITransformationProvider)P_0).AddForeignKey((ForeignKey)P_1);
	}
}
