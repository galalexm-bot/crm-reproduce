using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Helpers;

public class RestrictionBuilderSelectCollectionAction<T, T1> : RestrictionBuilderSelectAction<T> where T1 : class
{
	public RestrictionBuilderSelectCollectionAction(RestrictionBuilderSelectType<T> baseRestrictionBuilder)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(baseRestrictionBuilder);
	}

	public void UpdateMode(Func<T1, T1, bool> comparer = null)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.comparer = comparer;
		if (CS_0024_003C_003E8__locals0.comparer == null)
		{
			return;
		}
		restriction.CompareFunction = delegate(object x, object y)
		{
			//Discarded unreachable code: IL_00c5, IL_00d4
			int num = 5;
			int num2 = num;
			T1 val2 = default(T1);
			T1 val = default(T1);
			while (true)
			{
				switch (num2)
				{
				case 4:
					val2 = y as T1;
					num2 = 3;
					break;
				case 5:
					val = x as T1;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					if (val == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				case 2:
					return CS_0024_003C_003E8__locals0.comparer(val, val2);
				default:
					return false;
				case 1:
					if (val2 != null)
					{
						num2 = 2;
						break;
					}
					goto default;
				}
			}
		};
	}

	public void UpdateMode(CollectionUpdateMode mode, Func<T1, T1, bool> comparer = null)
	{
		restriction.CollectionUpdateMode = mode;
		UpdateMode(comparer);
	}
}
