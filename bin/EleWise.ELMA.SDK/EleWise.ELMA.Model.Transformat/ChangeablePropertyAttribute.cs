using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Transformations;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class ChangeablePropertyAttribute : Attribute
{
	internal static ChangeablePropertyAttribute vrU9fVWUWolOZP3ap1ix;

	public string[] SubProperties
	{
		[CompilerGenerated]
		get
		{
			return _003CSubProperties_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
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
					_003CSubProperties_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ChangeablePropertyAttribute()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KYOxJrWUhcKZvJIyP762();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ChangeablePropertyAttribute(params string[] subProperty)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			SubProperties = subProperty;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
			{
				num = 1;
			}
		}
	}

	public ChangeablePropertyAttribute(Type changedPropertiesContainerType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KYOxJrWUhcKZvJIyP762();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
		{
			num = 0;
		}
		IAttributesChangeableProperties attributesChangeableProperties = default(IAttributesChangeableProperties);
		while (true)
		{
			switch (num)
			{
			case 1:
				SubProperties = (string[])kLFiLLWUEpS7dJo3EjUq(attributesChangeableProperties);
				num = 2;
				continue;
			case 2:
				return;
			}
			attributesChangeableProperties = (IAttributesChangeableProperties)mhDAE3WUGlnkln1L8xDI(changedPropertiesContainerType);
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
			{
				num = 1;
			}
		}
	}

	internal static void KYOxJrWUhcKZvJIyP762()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool sOYhsIWUoO88Hcb9Stwu()
	{
		return vrU9fVWUWolOZP3ap1ix == null;
	}

	internal static ChangeablePropertyAttribute LLvx4iWUbPpeRnvxiYlB()
	{
		return vrU9fVWUWolOZP3ap1ix;
	}

	internal static object mhDAE3WUGlnkln1L8xDI(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static object kLFiLLWUEpS7dJo3EjUq(object P_0)
	{
		return ((IAttributesChangeableProperties)P_0).GetProperties();
	}
}
