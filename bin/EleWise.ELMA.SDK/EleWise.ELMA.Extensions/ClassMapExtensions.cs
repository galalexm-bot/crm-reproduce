using EleWise.ELMA.Runtime.Db;
using NHibernate.Mapping.ByCode;

namespace EleWise.ELMA.Extensions;

public static class ClassMapExtensions
{
	internal static ClassMapExtensions O9OtIDGxCuXABXBpUVFu;

	public static void SetGenerator(this IIdMapper mapping, string tableName, string idColumnName)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
			{
				IMapIdentityProvider currentThreadProvider = MapIdentityProvider.CurrentThreadProvider;
				if (currentThreadProvider == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 1;
					}
					break;
				}
				currentThreadProvider.SetGenerator(mapping, tableName, idColumnName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 1:
				return;
			}
		}
	}

	internal static bool ueutDiGxvS5nvNTd76db()
	{
		return O9OtIDGxCuXABXBpUVFu == null;
	}

	internal static ClassMapExtensions BrAvnfGx8h353E38tPen()
	{
		return O9OtIDGxCuXABXBpUVFu;
	}
}
