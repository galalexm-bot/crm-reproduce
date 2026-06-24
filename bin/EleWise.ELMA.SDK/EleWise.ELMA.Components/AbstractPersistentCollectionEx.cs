using System.Collections;
using EleWise.ELMA.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Collection;

namespace EleWise.ELMA.Components;

[Component]
internal class AbstractPersistentCollectionExtension : IOriginalCollectionExtension
{
	private static AbstractPersistentCollectionExtension G02UN2fGluJHyva6g2De;

	public bool Can(object obj)
	{
		return GetCollection(obj) != null;
	}

	public IEnumerable OriginalItems(object obj)
	{
		return GetCollection(obj);
	}

	private IEnumerable GetCollection(object obj)
	{
		//Discarded unreachable code: IL_0074, IL_00f2, IL_0101
		int num = 1;
		int num2 = num;
		IEnumerable enumerable = default(IEnumerable);
		IInheritedSet inheritedSet = default(IInheritedSet);
		AbstractPersistentCollection val = default(AbstractPersistentCollection);
		while (true)
		{
			switch (num2)
			{
			case 8:
				return enumerable;
			case 2:
				return null;
			case 10:
				inheritedSet = obj as IInheritedSet;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 3;
				}
				continue;
			case 9:
				if (enumerable != null)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 8;
					}
					continue;
				}
				goto case 2;
			case 3:
				if (inheritedSet != null)
				{
					num2 = 5;
					continue;
				}
				goto case 6;
			case 6:
			case 7:
				if (val == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 5:
			{
				object obj2 = PRIoRHfG5aVinBkGeIxG(inheritedSet);
				val = (AbstractPersistentCollection)((obj2 is AbstractPersistentCollection) ? obj2 : null);
				num2 = 7;
				continue;
			}
			default:
				if (val != null)
				{
					num2 = 6;
					continue;
				}
				goto case 10;
			case 1:
				val = (AbstractPersistentCollection)((obj is AbstractPersistentCollection) ? obj : null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				break;
			}
			enumerable = val.get_StoredSnapshot() as IEnumerable;
			num2 = 9;
		}
	}

	public AbstractPersistentCollectionExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		p8I7JZfGjNxxdJ5V4JbK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool OpKaFyfGrCbPnPpI5hCH()
	{
		return G02UN2fGluJHyva6g2De == null;
	}

	internal static AbstractPersistentCollectionExtension UQXH8tfGgq8A5Cm7WjPt()
	{
		return G02UN2fGluJHyva6g2De;
	}

	internal static object PRIoRHfG5aVinBkGeIxG(object P_0)
	{
		return ((IInheritedSet)P_0).GetSourceSet();
	}

	internal static void p8I7JZfGjNxxdJ5V4JbK()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
