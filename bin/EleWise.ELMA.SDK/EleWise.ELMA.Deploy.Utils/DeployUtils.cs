using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Packaging.ElmaStoreManifest;

namespace EleWise.ELMA.Deploy.Utils;

public static class DeployUtils
{
	internal static IEnumerable<T> SafeSkip<T>(List<T> source, int offset, int count)
	{
		if (source == null)
		{
			return null;
		}
		int num = source.Count - offset;
		if (count > 0)
		{
			num = Math.Min(num, count);
		}
		if (num > 0)
		{
			T[] array = new T[num];
			source.CopyTo(offset, array, 0, num);
			return array;
		}
		return Enumerable.Empty<T>();
	}

	public static List<ElmaStoreComponentManifest> SortComponentsByDependencies(List<ElmaStoreComponentManifest> manifests)
	{
		return manifests.OrderByDependencies(delegate(ElmaStoreComponentManifest left, ElmaStoreComponentManifest right)
		{
			//Discarded unreachable code: IL_0059, IL_0068, IL_0079
			int num = 3;
			int num2 = num;
			_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 5:
					if (left == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
						{
							num2 = 0;
						}
						break;
					}
					obj = left.Dependencies;
					goto IL_00d2;
				default:
					obj = null;
					goto IL_00d2;
				case 3:
					_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
					num2 = 2;
					break;
				case 1:
					return left.Dependencies.Any(_003C_003Ec__DisplayClass1_._003CSortComponentsByDependencies_003Eb__1);
				case 4:
					return false;
				case 2:
					{
						_003C_003Ec__DisplayClass1_.right = right;
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num2 = 5;
						}
						break;
					}
					IL_00d2:
					if (obj == null)
					{
						num2 = 4;
						break;
					}
					goto case 1;
				}
			}
		}).ToList();
	}
}
