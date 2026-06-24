using System;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.MetadataInternalContainer.Containers;

public class PropertyValueContainer<T> : IPropertyValueContainer<T>, IPropertyValueContainer, IPropertyDefaultValueContainer
{
	private T value;

	internal Func<T> valueFactory;

	internal static object Wxsgp3hWLFV9BpSDsSWx;

	Type IPropertyValueContainer.PropertyType => TypeOf<T>.Raw;

	public PropertyValueContainer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PropertyValueContainer(T value)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.value = value;
	}

	public PropertyValueContainer(Func<T> valueFactory)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.valueFactory = valueFactory;
	}

	T IPropertyValueContainer<T>.Get(object obj)
	{
		return value;
	}

	void IPropertyValueContainer<T>.Set(object obj, T value)
	{
		this.value = value;
	}

	object IPropertyValueContainer.Get(object obj)
	{
		return value;
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
			case 0:
				return;
			case 1:
				this.value = (T)value;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
	{
		//Discarded unreachable code: IL_0054
		int num = 1;
		int num2 = num;
		T val;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (valueFactory == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 0;
					}
					continue;
				}
				val = valueFactory();
				break;
			default:
				val = value;
				break;
			}
			break;
		}
		return new PropertyValueContainer<T>(val);
	}

	internal static bool o6E2b6hWUvkC58fkSYEV()
	{
		return Wxsgp3hWLFV9BpSDsSWx == null;
	}

	internal static object y1SmJXhWsck5nVlIiXbW()
	{
		return Wxsgp3hWLFV9BpSDsSWx;
	}
}
