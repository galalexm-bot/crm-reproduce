using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Comparers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.MetadataInternalContainer.Containers;

internal class PropertySetValueContainer : IPropertyDefaultValueContainer
{
	private class NestedValueContainer<TClass, TInterface> : IPropertyValueContainer<ISet<TClass>>, IPropertyValueContainer where TClass : class where TInterface : class
	{
		private ISet<TClass> value;

		private static object OOytdmClWRq3JKOSC4x8;

		Type IPropertyValueContainer.PropertyType => TypeOf<ISet<TClass>>.Raw;

		internal NestedValueContainer(ISet<TClass> value)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			Set(null, value);
		}

		public ISet<TClass> Get(object obj)
		{
			return value;
		}

		public void Set(object obj, ISet<TClass> value)
		{
			this.value = WrappedSetHelper.Wrap<TClass, TInterface>(value);
		}

		object IPropertyValueContainer.Get(object obj)
		{
			return Get(obj);
		}

		void IPropertyValueContainer.Set(object obj, object value)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					Set(obj, (ISet<TClass>)value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		internal static bool tyrhIuClo7TPQJbDFFJt()
		{
			return OOytdmClWRq3JKOSC4x8 == null;
		}

		internal static object RnAsCQClb5hCr5sWu2fd()
		{
			return OOytdmClWRq3JKOSC4x8;
		}
	}

	private class NestedDefaultValueContainer<TClass, TInterface> : IPropertyDefaultValueContainer where TClass : class where TInterface : class
	{
		private readonly IComparer<TClass> comparer;

		private static object EMBF9xClhc9RAtBfWgCk;

		public NestedDefaultValueContainer(IComparer<TClass> comparer)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.comparer = comparer;
		}

		IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
		{
			//Discarded unreachable code: IL_005c, IL_006b, IL_00b3
			int num = 3;
			int num2 = num;
			ISet<TClass> val = default(ISet<TClass>);
			ISet<TClass> value;
			while (true)
			{
				switch (num2)
				{
				default:
					val = new IesiSortedSet<TClass>(comparer);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					val = (ISet<TClass>)(object)new HashedSet<TClass>();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					if (comparer == null)
					{
						num2 = 2;
						continue;
					}
					goto default;
				case 1:
					value = val;
					break;
				case 4:
					value = val;
					break;
				}
				break;
			}
			return new NestedValueContainer<TClass, TInterface>(value);
		}

		internal static bool CNsShRClGOEn82xm5j6o()
		{
			return EMBF9xClhc9RAtBfWgCk == null;
		}

		internal static object fPr1iNClE2N7gQDjOebi()
		{
			return EMBF9xClhc9RAtBfWgCk;
		}
	}

	private class NestedDefaultValueContainer<T> : IPropertyDefaultValueContainer where T : class
	{
		private static object VKoJnKClficuaYw508JS;

		IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
		{
			return new PropertyValueContainer<ISet<T>>((ISet<T>)(object)new HashedSet<T>());
		}

		public NestedDefaultValueContainer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool zrrC8oClQq2PDbUOVLdD()
		{
			return VKoJnKClficuaYw508JS == null;
		}

		internal static object tymcqVClCJtOcVEOFDvr()
		{
			return VKoJnKClficuaYw508JS;
		}
	}

	private readonly PropertyMetadata propertyMetadata;

	private readonly Type tInterface;

	private readonly bool forFilter;

	private IPropertyDefaultValueContainer propContainer;

	private static PropertySetValueContainer Wp6F1PhWc2jDP69Nrcgp;

	public PropertySetValueContainer(PropertyMetadata propertyMetadata, Type tInterface, bool forFilter)
	{
		//Discarded unreachable code: IL_002a
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			default:
			{
				this.forFilter = forFilter;
				int num2 = 2;
				num = num2;
				break;
			}
			case 1:
				this.tInterface = tInterface;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num = 0;
				}
				break;
			case 3:
				this.propertyMetadata = propertyMetadata;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
	{
		//Discarded unreachable code: IL_0188, IL_0197, IL_01a6
		int num = 4;
		int num2 = num;
		Type typeByUid = default(Type);
		Type type2 = default(Type);
		Type type = default(Type);
		IComparer comparer = default(IComparer);
		while (true)
		{
			switch (num2)
			{
			case 7:
				typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(s2nFLphooeXTdrpuiSY3(propertyMetadata));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				type2 = aONSGShoBoa7HkN7FVSL(typeof(NestedDefaultValueContainer<>).TypeHandle).MakeGenericType(tInterface);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 6;
				}
				continue;
			case 2:
				propContainer = (IPropertyDefaultValueContainer)Activator.CreateInstance(type, comparer);
				num2 = 9;
				continue;
			case 4:
				if (propContainer != null)
				{
					num2 = 3;
					continue;
				}
				goto case 8;
			case 8:
				if (forFilter)
				{
					num2 = 5;
					continue;
				}
				goto case 7;
			case 6:
				propContainer = (IPropertyDefaultValueContainer)qhsr7LhoWWP82joOqVR4(type2);
				num2 = 10;
				continue;
			case 3:
			case 9:
			case 10:
				return propContainer.Initialize();
			case 1:
				comparer = propertyMetadata.CreateComparer();
				num2 = 2;
				continue;
			}
			type = aONSGShoBoa7HkN7FVSL(typeof(NestedDefaultValueContainer<, >).TypeHandle).MakeGenericType(typeByUid, tInterface);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
			{
				num2 = 1;
			}
		}
	}

	internal static bool m1OLGbhWzbL9MkNOBHl5()
	{
		return Wp6F1PhWc2jDP69Nrcgp == null;
	}

	internal static PropertySetValueContainer QpQn3whoFvMtaxTMoNGV()
	{
		return Wp6F1PhWc2jDP69Nrcgp;
	}

	internal static Type aONSGShoBoa7HkN7FVSL(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object qhsr7LhoWWP82joOqVR4(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static Guid s2nFLphooeXTdrpuiSY3(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}
}
