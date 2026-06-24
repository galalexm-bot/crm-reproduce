using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;

internal class PropertyInfoProxy : PropertyInfo
{
	private class MethodInfoProxy : MethodInfo
	{
		private readonly object methodInfo;

		internal static object eqlU7lvByh2f2ZussRI1;

		public override Type DeclaringType { get; }

		public override Type ReflectedType { get; }

		public override string Name => (string)pihNNUvBdueeNWlL7VA6(methodInfo);

		public override MethodAttributes Attributes => cuGAy4vBlLtIi15O29tX(methodInfo);

		public override CallingConventions CallingConvention => ((MethodBase)methodInfo).CallingConvention;

		public override IEnumerable<CustomAttributeData> CustomAttributes => ((MemberInfo)methodInfo).CustomAttributes;

		public override bool IsSecurityCritical => ((MethodBase)methodInfo).IsSecurityCritical;

		public override bool IsSecuritySafeCritical => TZM26cvBrwkQJY6hgs8E(methodInfo);

		public override bool IsSecurityTransparent => L196EGvBge0P6opEoTVk(methodInfo);

		public override MethodImplAttributes MethodImplementationFlags => hcZAZ1vB5WdbdojFlaFn(methodInfo);

		public override Type ReturnType => ((MethodInfo)methodInfo).ReturnType;

		public override ParameterInfo ReturnParameter => (ParameterInfo)VqUKt6vBjac9jvsl3LXS(methodInfo);

		public override ICustomAttributeProvider ReturnTypeCustomAttributes => ((MethodInfo)methodInfo).ReturnTypeCustomAttributes;

		public override Module Module => DeclaringType.Module;

		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public MethodInfoProxy(MethodInfo methodInfo, Type declaringType, Type reflectedType)
		{
			//Discarded unreachable code: IL_001a, IL_001f
			xS8hl6vB9LEpEvO0igl9();
			base._002Ector();
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 3:
					return;
				case 2:
					this.methodInfo = methodInfo;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num = 0;
					}
					break;
				case 1:
					DeclaringType = declaringType;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num = 0;
					}
					break;
				default:
					ReflectedType = reflectedType;
					num = 3;
					break;
				}
			}
		}

		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return ((MethodBase)methodInfo).GetMethodImplementationFlags();
		}

		public override ParameterInfo[] GetParameters()
		{
			return (ParameterInfo[])EijOUovBY6CA1jo4Pemp(methodInfo);
		}

		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			return bZCPZlvBLJPx2pb4JZb2(methodInfo, obj, invokeAttr, binder, parameters, culture);
		}

		public override string ToString()
		{
			return methodInfo.ToString();
		}

		public override IList<CustomAttributeData> GetCustomAttributesData()
		{
			return ((MemberInfo)methodInfo).GetCustomAttributesData();
		}

		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return IZQn1svBUG10HriBasng(methodInfo, attributeType, inherit);
		}

		public override object[] GetCustomAttributes(bool inherit)
		{
			return (object[])L0SGL1vBsPpI3GKwc9fr(methodInfo, inherit);
		}

		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return (object[])CoEqWkvBcclUKqy77vcI(methodInfo, attributeType, inherit);
		}

		public override MethodInfo GetBaseDefinition()
		{
			return this;
		}

		internal static void xS8hl6vB9LEpEvO0igl9()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool p4QI1MvBMN9Ir6HfrrS0()
		{
			return eqlU7lvByh2f2ZussRI1 == null;
		}

		internal static MethodInfoProxy uDadXxvBJTM1Fx4bU3hY()
		{
			return (MethodInfoProxy)eqlU7lvByh2f2ZussRI1;
		}

		internal static object pihNNUvBdueeNWlL7VA6(object P_0)
		{
			return ((MemberInfo)P_0).Name;
		}

		internal static MethodAttributes cuGAy4vBlLtIi15O29tX(object P_0)
		{
			return ((MethodBase)P_0).Attributes;
		}

		internal static bool TZM26cvBrwkQJY6hgs8E(object P_0)
		{
			return ((MethodBase)P_0).IsSecuritySafeCritical;
		}

		internal static bool L196EGvBge0P6opEoTVk(object P_0)
		{
			return ((MethodBase)P_0).IsSecurityTransparent;
		}

		internal static MethodImplAttributes hcZAZ1vB5WdbdojFlaFn(object P_0)
		{
			return ((MethodBase)P_0).MethodImplementationFlags;
		}

		internal static object VqUKt6vBjac9jvsl3LXS(object P_0)
		{
			return ((MethodInfo)P_0).ReturnParameter;
		}

		internal static object EijOUovBY6CA1jo4Pemp(object P_0)
		{
			return ((MethodBase)P_0).GetParameters();
		}

		internal static object bZCPZlvBLJPx2pb4JZb2(object P_0, object P_1, BindingFlags P_2, object P_3, object P_4, object P_5)
		{
			return ((MethodBase)P_0).Invoke(P_1, P_2, (Binder)P_3, (object[])P_4, (CultureInfo)P_5);
		}

		internal static bool IZQn1svBUG10HriBasng(object P_0, Type P_1, bool P_2)
		{
			return ((MemberInfo)P_0).IsDefined(P_1, P_2);
		}

		internal static object L0SGL1vBsPpI3GKwc9fr(object P_0, bool P_1)
		{
			return ((MemberInfo)P_0).GetCustomAttributes(P_1);
		}

		internal static object CoEqWkvBcclUKqy77vcI(object P_0, Type P_1, bool P_2)
		{
			return ((MemberInfo)P_0).GetCustomAttributes(P_1, P_2);
		}
	}

	private readonly PropertyInfo propertyInfo;

	internal static PropertyInfoProxy YbhiOEhSbN8n6dh4gwqR;

	public override Type DeclaringType { get; }

	public override Type ReflectedType { get; }

	public override PropertyAttributes Attributes => VDpeLmhSCY8kLPlRpkfj(propertyInfo);

	public override bool CanRead => TtZN41hSvnX4UyaPHkqB(propertyInfo);

	public override bool CanWrite => bawNqyhS89qDgEDBaH2a(propertyInfo);

	public override string Name => (string)JE3fQjhSZM0NtiDGVFY7(propertyInfo);

	public override Type PropertyType => wXKbxThSuDIcM9vnv6T0(propertyInfo);

	public override Module Module => (Module)OVVdNahSIEWLNfh52aJS(propertyInfo);

	public PropertyInfoProxy(PropertyInfo propertyInfo, Type declaringType = null, Type reflectedType = null)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		UkZy5dhSEhE5TFqsLxkl();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				this.propertyInfo = ((propertyInfo is PropertyInfoProxy propertyInfoProxy) ? propertyInfoProxy.propertyInfo : propertyInfo);
				num = 3;
				break;
			case 3:
				DeclaringType = declaringType ?? QZuSkVhSfWnKeNCcXxa9(propertyInfo);
				num = 2;
				break;
			case 2:
				ReflectedType = reflectedType ?? NOTwZghSQRkHKBAUoWEE(propertyInfo);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
	{
		return tU8mRuhSVRo5Q37AdSZv(propertyInfo, obj, invokeAttr, binder, index, culture);
	}

	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
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
				CH8vlohSSI1wJlGtv9Ia(propertyInfo, obj, value, invokeAttr, binder, index, culture);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override ParameterInfo[] GetIndexParameters()
	{
		return (ParameterInfo[])OWjxqNhSipJSjymLN1VG(propertyInfo);
	}

	public override MethodInfo GetGetMethod(bool nonPublic)
	{
		return new MethodInfoProxy((MethodInfo)S83YLXhSRygxhR5MsMe3(propertyInfo, nonPublic), QZuSkVhSfWnKeNCcXxa9(this), NOTwZghSQRkHKBAUoWEE(this));
	}

	public override MethodInfo GetSetMethod(bool nonPublic)
	{
		return new MethodInfoProxy((MethodInfo)AQt9nAhSqTkMKHF5GNAP(propertyInfo, nonPublic), QZuSkVhSfWnKeNCcXxa9(this), NOTwZghSQRkHKBAUoWEE(this));
	}

	public override MethodInfo[] GetAccessors(bool nonPublic)
	{
		int num = 1;
		int num2 = num;
		MethodInfo[] result = default(MethodInfo[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 1:
				result = ((IEnumerable<MethodInfo>)gRVX6ehSKZ1ost5ivk0R(propertyInfo, nonPublic)).Select((MethodInfo m) => new MethodInfoProxy(m, DeclaringType, NOTwZghSQRkHKBAUoWEE(this))).ToArray();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return propertyInfo.ToString();
	}

	public override IList<CustomAttributeData> GetCustomAttributesData()
	{
		return propertyInfo.GetCustomAttributesData();
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return Er1tuLhSXZkp1fHbeS8I(propertyInfo, attributeType, inherit);
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		return propertyInfo.GetCustomAttributes(inherit);
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return (object[])MCU8gshSTLmN4ndWgtaY(propertyInfo, attributeType, inherit);
	}

	internal static void UkZy5dhSEhE5TFqsLxkl()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type QZuSkVhSfWnKeNCcXxa9(object P_0)
	{
		return ((MemberInfo)P_0).DeclaringType;
	}

	internal static Type NOTwZghSQRkHKBAUoWEE(object P_0)
	{
		return ((MemberInfo)P_0).ReflectedType;
	}

	internal static bool CglsBahShFr8UkmMLIN2()
	{
		return (object)YbhiOEhSbN8n6dh4gwqR == null;
	}

	internal static PropertyInfoProxy ax1vlxhSGtTfD61e7IRA()
	{
		return YbhiOEhSbN8n6dh4gwqR;
	}

	internal static PropertyAttributes VDpeLmhSCY8kLPlRpkfj(object P_0)
	{
		return ((PropertyInfo)P_0).Attributes;
	}

	internal static bool TtZN41hSvnX4UyaPHkqB(object P_0)
	{
		return ((PropertyInfo)P_0).CanRead;
	}

	internal static bool bawNqyhS89qDgEDBaH2a(object P_0)
	{
		return ((PropertyInfo)P_0).CanWrite;
	}

	internal static object JE3fQjhSZM0NtiDGVFY7(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static Type wXKbxThSuDIcM9vnv6T0(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static object OVVdNahSIEWLNfh52aJS(object P_0)
	{
		return ((MemberInfo)P_0).Module;
	}

	internal static object tU8mRuhSVRo5Q37AdSZv(object P_0, object P_1, BindingFlags P_2, object P_3, object P_4, object P_5)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, P_2, (Binder)P_3, (object[])P_4, (CultureInfo)P_5);
	}

	internal static void CH8vlohSSI1wJlGtv9Ia(object P_0, object P_1, object P_2, BindingFlags P_3, object P_4, object P_5, object P_6)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, P_3, (Binder)P_4, (object[])P_5, (CultureInfo)P_6);
	}

	internal static object OWjxqNhSipJSjymLN1VG(object P_0)
	{
		return ((PropertyInfo)P_0).GetIndexParameters();
	}

	internal static object S83YLXhSRygxhR5MsMe3(object P_0, bool P_1)
	{
		return ((PropertyInfo)P_0).GetGetMethod(P_1);
	}

	internal static object AQt9nAhSqTkMKHF5GNAP(object P_0, bool P_1)
	{
		return ((PropertyInfo)P_0).GetSetMethod(P_1);
	}

	internal static object gRVX6ehSKZ1ost5ivk0R(object P_0, bool P_1)
	{
		return ((PropertyInfo)P_0).GetAccessors(P_1);
	}

	internal static bool Er1tuLhSXZkp1fHbeS8I(object P_0, Type P_1, bool P_2)
	{
		return ((MemberInfo)P_0).IsDefined(P_1, P_2);
	}

	internal static object MCU8gshSTLmN4ndWgtaY(object P_0, Type P_1, bool P_2)
	{
		return ((MemberInfo)P_0).GetCustomAttributes(P_1, P_2);
	}
}
