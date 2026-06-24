using System.Collections.Generic;
using System.Linq;
using System.Reflection.Extensions;
using System.Threading.Tasks;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace System.Reflection;

public static class TypeOf<T>
{
	public static readonly Type Raw;

	private static string name;

	private static string fullName;

	private static Assembly assembly;

	internal static object AwuRyIGjqmXS8lXd9La;

	public static string Name
	{
		get
		{
			int num = 1;
			int num2 = num;
			string text;
			while (true)
			{
				switch (num2)
				{
				case 1:
					text = name;
					if (text == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					text = (name = Raw.Name);
					break;
				}
				break;
			}
			return text;
		}
	}

	public static string FullName
	{
		get
		{
			int num = 1;
			int num2 = num;
			string text;
			while (true)
			{
				switch (num2)
				{
				case 1:
					text = fullName;
					if (text == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					text = (fullName = Raw.FullName);
					break;
				}
				break;
			}
			return text;
		}
	}

	public static Assembly Assembly
	{
		get
		{
			int num = 1;
			int num2 = num;
			Assembly obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = assembly;
					if ((object)obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					obj = (assembly = Raw.Assembly);
					break;
				}
				break;
			}
			return obj;
		}
	}

	static TypeOf()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				Raw = typeof(T);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool uN1pweGYtNJ7n0Mgnw7()
	{
		return AwuRyIGjqmXS8lXd9La == null;
	}

	internal static object yARsaGGLGf2wo8F6BeZ()
	{
		return AwuRyIGjqmXS8lXd9La;
	}
}
public static class TypeOf
{
	public static readonly RipeType Void;

	public static readonly RipeType Nullable;

	public static readonly RipeType List;

	public static readonly RipeType IList;

	public static readonly RipeType ICollection;

	public static readonly RipeType ISet;

	public static readonly RipeType Iesi_HashedSet;

	public static readonly RipeType Iesi_ISet;

	public static readonly RipeType Enumerable;

	public static readonly RipeType IEnumerable;

	public static readonly RipeType Dictionary;

	public static readonly RipeType IDictionary;

	public static readonly RipeType KeyValuePair;

	public static readonly RipeType Func1;

	public static readonly RipeType Func2;

	public static readonly RipeType Func3;

	public static readonly RipeType Task1;

	public static readonly RipeType ValueTask1;

	private static TypeOf M4fg6OEFZQZ6sjjP7ps;

	static TypeOf()
	{
		int num = 18;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					IList = (RipeType)XrZ9rsEbutKEbxa8JSG(GOiI9YEhKUlKSyQo157(typeof(IList<>).TypeHandle));
					num2 = 3;
					continue;
				case 14:
					Iesi_ISet = (RipeType)XrZ9rsEbutKEbxa8JSG(GOiI9YEhKUlKSyQo157(typeof(ISet<>).TypeHandle));
					num2 = 4;
					continue;
				case 12:
					return;
				case 15:
					Func2 = (RipeType)XrZ9rsEbutKEbxa8JSG(GOiI9YEhKUlKSyQo157(typeof(Func<, >).TypeHandle));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 6;
					}
					continue;
				case 16:
					Iesi_HashedSet = GOiI9YEhKUlKSyQo157(typeof(HashedSet<>).TypeHandle).ToRipeType();
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 1;
					}
					continue;
				case 11:
					ValueTask1 = (RipeType)XrZ9rsEbutKEbxa8JSG(GOiI9YEhKUlKSyQo157(typeof(System.Threading.Tasks.ValueTask<>).TypeHandle));
					num2 = 12;
					continue;
				case 10:
					Func1 = (RipeType)XrZ9rsEbutKEbxa8JSG(typeof(Func<>));
					num2 = 15;
					continue;
				case 4:
					Enumerable = (RipeType)XrZ9rsEbutKEbxa8JSG(GOiI9YEhKUlKSyQo157(typeof(Enumerable).TypeHandle));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					IDictionary = (RipeType)XrZ9rsEbutKEbxa8JSG(typeof(IDictionary<, >));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 18:
					cm11GBEo7IONZbujXCY();
					num2 = 17;
					continue;
				case 1:
					KeyValuePair = (RipeType)XrZ9rsEbutKEbxa8JSG(typeof(KeyValuePair<, >));
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 3;
					}
					continue;
				case 6:
					Func3 = (RipeType)XrZ9rsEbutKEbxa8JSG(GOiI9YEhKUlKSyQo157(typeof(Func<, , >).TypeHandle));
					num2 = 9;
					continue;
				case 13:
					Nullable = (RipeType)XrZ9rsEbutKEbxa8JSG(GOiI9YEhKUlKSyQo157(typeof(Nullable<>).TypeHandle));
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 19;
					}
					continue;
				case 9:
					Task1 = GOiI9YEhKUlKSyQo157(typeof(Task<>).TypeHandle).ToRipeType();
					num = 11;
					break;
				case 19:
					List = (RipeType)XrZ9rsEbutKEbxa8JSG(GOiI9YEhKUlKSyQo157(typeof(List<>).TypeHandle));
					num = 8;
					break;
				case 3:
					ICollection = GOiI9YEhKUlKSyQo157(typeof(ICollection<>).TypeHandle).ToRipeType();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 2;
					}
					continue;
				case 5:
					Dictionary = GOiI9YEhKUlKSyQo157(typeof(Dictionary<, >).TypeHandle).ToRipeType();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					IEnumerable = (RipeType)XrZ9rsEbutKEbxa8JSG(GOiI9YEhKUlKSyQo157(typeof(IEnumerable<>).TypeHandle));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 2;
					}
					continue;
				case 17:
					Void = (RipeType)XrZ9rsEbutKEbxa8JSG(typeof(void));
					num2 = 13;
					continue;
				case 2:
					ISet = (RipeType)XrZ9rsEbutKEbxa8JSG(GOiI9YEhKUlKSyQo157(typeof(ISet<>).TypeHandle));
					num2 = 16;
					continue;
				}
				break;
			}
		}
	}

	internal static void cm11GBEo7IONZbujXCY()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object XrZ9rsEbutKEbxa8JSG(Type type)
	{
		return type.ToRipeType();
	}

	internal static Type GOiI9YEhKUlKSyQo157(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool ImvA7AEBFsjl1M1Viri()
	{
		return M4fg6OEFZQZ6sjjP7ps == null;
	}

	internal static TypeOf Wts18eEWeyfyxeXXqRM()
	{
		return M4fg6OEFZQZ6sjjP7ps;
	}
}
