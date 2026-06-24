using System;
using System.Reflection;

namespace EleWise.ELMA.Extensions;

public static class DelegateExtensions
{
	internal static DelegateExtensions CX3EZ3G7u9QaeIJOAmip;

	public static void RaiseSafe(this Delegate @event, params object[] args)
	{
		//Discarded unreachable code: IL_0058
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
			case 1:
				return;
			case 3:
				new Event(@event).Raise(args);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if ((object)@event == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public static void RaiseSafe(this Delegate @event, object sender, EventArgs eventArgObject)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				if ((object)@event == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				new Event(@event).Raise(sender, eventArgObject);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public static void Raise<T>(this EventHandler<T> @event, object sender, T args) where T : EventArgs
	{
		@event?.Invoke(sender, args);
	}

	public static void Raise(this EventHandler @event, object sender, EventArgs args)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				return;
			case 3:
				if (@event == null)
				{
					num2 = 2;
					continue;
				}
				break;
			case 0:
				return;
			case 1:
				break;
			}
			QatD4XG7SoCWHgalok3O(@event, sender, args);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
			{
				num2 = 0;
			}
		}
	}

	public static T Cast<T>(Delegate source) where T : class
	{
		return Cast(source, typeof(T)) as T;
	}

	public static Delegate Cast(Delegate source, Type type)
	{
		//Discarded unreachable code: IL_006e, IL_007d, IL_008c, IL_0158
		int num = 8;
		int num3 = default(int);
		Delegate[] array = default(Delegate[]);
		Delegate[] array2 = default(Delegate[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					num3 = 0;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 4;
					}
					continue;
				case 5:
					return Delegate.CreateDelegate(type, KnW5cuG7RiNrV6RbOYgM(array[0]), (MethodInfo)RNdHDUG7qAX9Yos9AEjw(array[0]));
				default:
					if (num3 < array.Length)
					{
						num = 11;
						break;
					}
					goto case 2;
				case 6:
					return null;
				case 7:
					array = (Delegate[])Ug2DDJG7iTWoQybRjiJ1(source);
					num2 = 3;
					continue;
				case 9:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return (Delegate)lOtoj9G7XkdVLRp5AsKC(array2);
				case 1:
				case 11:
					array2[num3] = (Delegate)M9qJAZG7KRNISvAyFZiw(type, KnW5cuG7RiNrV6RbOYgM(array[num3]), array[num3].Method);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 9;
					}
					continue;
				case 8:
					if ((object)source != null)
					{
						num = 7;
						break;
					}
					goto case 6;
				case 3:
					if (array.Length != 1)
					{
						array2 = new Delegate[array.Length];
						num2 = 10;
						continue;
					}
					num = 5;
					break;
				}
				break;
			}
		}
	}

	internal static bool ijw4XoG7IJYib8Juso2f()
	{
		return CX3EZ3G7u9QaeIJOAmip == null;
	}

	internal static DelegateExtensions PtvZiUG7Vd0V96xPO8dA()
	{
		return CX3EZ3G7u9QaeIJOAmip;
	}

	internal static void QatD4XG7SoCWHgalok3O(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (EventArgs)P_2);
	}

	internal static object Ug2DDJG7iTWoQybRjiJ1(object P_0)
	{
		return ((Delegate)P_0).GetInvocationList();
	}

	internal static object KnW5cuG7RiNrV6RbOYgM(object P_0)
	{
		return ((Delegate)P_0).Target;
	}

	internal static object RNdHDUG7qAX9Yos9AEjw(object P_0)
	{
		return ((Delegate)P_0).Method;
	}

	internal static object M9qJAZG7KRNISvAyFZiw(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (MethodInfo)P_2);
	}

	internal static object lOtoj9G7XkdVLRp5AsKC(object P_0)
	{
		return Delegate.Combine((Delegate[])P_0);
	}
}
