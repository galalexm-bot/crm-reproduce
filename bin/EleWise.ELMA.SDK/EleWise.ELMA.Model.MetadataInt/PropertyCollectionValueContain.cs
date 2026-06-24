using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Model.Entities;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.MetadataInternalContainer.Containers;

internal class PropertyCollectionValueContainer : IPropertyDefaultValueContainer
{
	private class NestedDefaultValueContainer<T> : IPropertyDefaultValueContainer
	{
		private static object YhjwSBCdwUAebSKLQghb;

		IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (TypeOf<IEntity>.Raw.IsAssignableFrom(TypeOf<T>.Raw))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
						{
							num2 = 0;
						}
						break;
					}
					return new PropertyValueContainer<ICollection<T>>(new List<T>());
				default:
					return new PropertyValueContainer<ICollection<T>>((ICollection<T>)new HashedSet<T>());
				}
			}
		}

		public NestedDefaultValueContainer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool xtC02UCd4x59Zf2U3TAM()
		{
			return YhjwSBCdwUAebSKLQghb == null;
		}

		internal static object uGHnIWCd6RwRLI3R2Oi6()
		{
			return YhjwSBCdwUAebSKLQghb;
		}
	}

	protected internal readonly Type tTarget;

	protected IPropertyDefaultValueContainer propContainer;

	private static PropertyCollectionValueContainer w3mCR2hWNDgAauov65TH;

	public PropertyCollectionValueContainer(Type tTarget)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		V2HlJ0hWaGWfhp6B0u2v();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
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
				this.tTarget = tTarget;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
	{
		int num = 2;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				type = NgngUShWDWiS8c86t2Kc(typeof(NestedDefaultValueContainer<>).TypeHandle).MakeGenericType(tTarget);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return (IPropertyValueContainer)kNnw4jhWwXWWwNOe0BZN(propContainer);
			case 3:
				propContainer = (IPropertyDefaultValueContainer)vnNxWJhWtXkbIiSL2fBL(type);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (propContainer == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	internal static void V2HlJ0hWaGWfhp6B0u2v()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool I4BK7HhW3jmFNGoiDmT6()
	{
		return w3mCR2hWNDgAauov65TH == null;
	}

	internal static PropertyCollectionValueContainer mMKX4MhWpfMEV2gO24DC()
	{
		return w3mCR2hWNDgAauov65TH;
	}

	internal static Type NgngUShWDWiS8c86t2Kc(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object vnNxWJhWtXkbIiSL2fBL(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static object kNnw4jhWwXWWwNOe0BZN(object P_0)
	{
		return ((IPropertyDefaultValueContainer)P_0).Initialize();
	}
}
