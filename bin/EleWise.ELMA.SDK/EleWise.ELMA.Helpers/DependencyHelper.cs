using System.Collections.Generic;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Signatures;

namespace EleWise.ELMA.Helpers;

public static class DependencyHelper
{
	public static IEnumerable<T> CombineDependencies<T>(IEnumerable<T> dependencies) where T : Dependency
	{
		List<T> list = new List<T>();
		using IEnumerator<T> enumerator = dependencies.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass0_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0<T>();
			CS_0024_003C_003E8__locals0.dependency = enumerator.Current;
			T val = list.Find((T a) => a.HeaderUid == CS_0024_003C_003E8__locals0.dependency.HeaderUid);
			if (val == null)
			{
				list.Add(CS_0024_003C_003E8__locals0.dependency);
				continue;
			}
			if (string.IsNullOrWhiteSpace(val.Name) && !string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals0.dependency.Name))
			{
				val.Name = CS_0024_003C_003E8__locals0.dependency.Name;
			}
			if (string.IsNullOrWhiteSpace(val.DisplayName) && !string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals0.dependency.DisplayName))
			{
				val.DisplayName = CS_0024_003C_003E8__locals0.dependency.DisplayName;
			}
		}
		return list;
	}

	public static IEnumerable<T> CombineClassDependencies<T>(IEnumerable<T> dependencies) where T : ClassDependency
	{
		List<T> list = new List<T>();
		using IEnumerator<T> enumerator = dependencies.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass1_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0<T>();
			CS_0024_003C_003E8__locals0.dependency = enumerator.Current;
			T val = list.Find((T a) => a.HeaderUid == CS_0024_003C_003E8__locals0.dependency.HeaderUid);
			if (val == null)
			{
				list.Add(CS_0024_003C_003E8__locals0.dependency);
				continue;
			}
			if (string.IsNullOrWhiteSpace(val.Name) && !string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals0.dependency.Name))
			{
				val.Name = CS_0024_003C_003E8__locals0.dependency.Name;
			}
			if (string.IsNullOrWhiteSpace(val.DisplayName) && !string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals0.dependency.DisplayName))
			{
				val.DisplayName = CS_0024_003C_003E8__locals0.dependency.DisplayName;
			}
			using List<PropertySignature>.Enumerator enumerator2 = CS_0024_003C_003E8__locals0.dependency.Properties.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				_003C_003Ec__DisplayClass1_1<T> CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass1_1<T>();
				CS_0024_003C_003E8__locals1.dependencyProperty = enumerator2.Current;
				if (val.Properties.Find(delegate(PropertySignature a)
				{
					//Discarded unreachable code: IL_007b, IL_008a
					int num = 1;
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 2:
							return a.Name == CS_0024_003C_003E8__locals1.dependencyProperty.Name;
						default:
							return true;
						case 1:
							if (a.Uid == CS_0024_003C_003E8__locals1.dependencyProperty.Uid)
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
								{
									num2 = 0;
								}
								break;
							}
							goto case 2;
						}
					}
				}) == null)
				{
					val.Properties.Add(CS_0024_003C_003E8__locals1.dependencyProperty);
				}
			}
		}
		return list;
	}
}
