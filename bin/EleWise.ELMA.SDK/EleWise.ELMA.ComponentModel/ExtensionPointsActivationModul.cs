using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using Autofac.Core;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

internal class ExtensionPointsActivationModule : Module
{
	private ConcurrentDictionary<Type, bool> isExtPoints;

	private ConcurrentDictionary<Type, int> typeOrders;

	internal static ExtensionPointsActivationModule kwQsD0fEy1HpKLCRtbAR;

	protected override void AttachToComponentRegistration(IComponentRegistry componentRegistry, IComponentRegistration registration)
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
				registration.add_Activating((EventHandler<ActivatingEventArgs<object>>)RegistrationOnActivating);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void RegistrationOnActivating(object sender, ActivatingEventArgs<object> e)
	{
		Type type = e.get_Instance().GetType();
		if (!ComponentManager.Initialized || !type.IsArray)
		{
			return;
		}
		Type elementType = type.GetElementType();
		if (!(elementType != null) || !(elementType != typeof(object)))
		{
			return;
		}
		if (!isExtPoints.TryGetValue(elementType, out var value))
		{
			value = AttributeHelper<ExtensionPointAttribute>.GetAttribute(elementType, inherited: true) != null;
			isExtPoints[elementType] = value;
		}
		if (!value)
		{
			return;
		}
		IEnumerable<object> source = ((IEnumerable)e.get_Instance()).OfType<object>();
		if (source.Count() == 1)
		{
			return;
		}
		object[] array = source.OrderBy(delegate(object p)
		{
			//Discarded unreachable code: IL_0074, IL_00c1, IL_00fd, IL_0131, IL_0144
			int num = 5;
			Type type2 = default(Type);
			int value2 = default(int);
			ComponentOrderAttribute attribute = default(ComponentOrderAttribute);
			ComponentAttribute attribute2 = default(ComponentAttribute);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					switch (num2)
					{
					case 4:
						if (typeOrders.TryGetValue(type2, out value2))
						{
							num = 9;
							break;
						}
						goto case 11;
					case 6:
						num3 = 0;
						goto IL_0172;
					case 1:
						attribute = AttributeHelper<ComponentOrderAttribute>.GetAttribute(type2, inherited: true);
						num = 8;
						break;
					case 11:
						attribute2 = AttributeHelper<ComponentAttribute>.GetAttribute(type2, inherited: true);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 1;
						}
						continue;
					default:
						num3 = attribute2.Order;
						goto IL_0172;
					case 8:
						if (attribute != null)
						{
							num2 = 3;
							continue;
						}
						goto case 10;
					case 10:
						if (attribute2 != null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 6;
					case 7:
					case 9:
						return value2;
					case 5:
						type2 = p.GetType();
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 4;
						}
						continue;
					case 2:
						typeOrders[type2] = value2;
						num = 7;
						break;
					case 3:
						{
							num3 = attribute.Order;
							goto IL_0172;
						}
						IL_0172:
						value2 = num3;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
			}
		}).ToArray();
		Array array2 = Array.CreateInstance(elementType, array.Length);
		Array.Copy(array, array2, array.Length);
		e.set_Instance((object)array2);
	}

	public ExtensionPointsActivationModule()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		TZjnSXfE9TTixHiS6W3g();
		isExtPoints = new ConcurrentDictionary<Type, bool>();
		typeOrders = new ConcurrentDictionary<Type, int>();
		((Module)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool uF0GEjfEMqYmwGjCq8H3()
	{
		return kwQsD0fEy1HpKLCRtbAR == null;
	}

	internal static ExtensionPointsActivationModule FBHLIffEJ9cG65Molsw9()
	{
		return kwQsD0fEy1HpKLCRtbAR;
	}

	internal static void TZjnSXfE9TTixHiS6W3g()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
