using System;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.MetadataInternalContainer.Containers;

internal class PropertyAnyTypeValueContainer : IPropertyDefaultValueContainer
{
	private readonly object defaultValue;

	private readonly Type runtimeType;

	private IPropertyDefaultValueContainer propContainer;

	private static PropertyAnyTypeValueContainer Sfu5hwhWu8wkXdYpY4Rc;

	public PropertyAnyTypeValueContainer(IPropertyMetadata propertyMetadata, object defaultValue = null)
	{
		//Discarded unreachable code: IL_001e, IL_0134, IL_0143, IL_0164, IL_01d1, IL_02fe, IL_030d
		zHTUf5hWSbr3wnRZuY5Q();
		base._002Ector();
		int num = 17;
		int num2 = num;
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		ICodeItemMetadata codeItemMetadata = default(ICodeItemMetadata);
		Guid guid = default(Guid);
		AnyTypeSettings anyTypeSettings = default(AnyTypeSettings);
		IRuntimeTypeDescriptor runtimeTypeDescriptor = default(IRuntimeTypeDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 21:
				if ((propertyMetadata2 = propertyMetadata as PropertyMetadata) != null)
				{
					num2 = 6;
					break;
				}
				goto case 13;
			case 10:
				if ((codeItemMetadata = ((IMetadataService)W1GpgrhWXaD7Ls9bWkDl()).GetMetadata(guid, loadImplementation: true) as ICodeItemMetadata) != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 3;
			case 12:
				if (!t7ZI42hWq8UGLnEMkJ0D(runtimeType, null))
				{
					num2 = 3;
					break;
				}
				goto case 20;
			case 20:
				guid = n9HZ2QhWK5PNjv6fURif(propertyMetadata);
				num2 = 5;
				break;
			case 19:
				runtimeType = ((IMetadataRuntimeService)K9VluehWT6yJf3ELq5nC()).GetTypeByUidOrNull(guid, loadImplementation: true);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 1;
				}
				break;
			case 13:
				this.defaultValue = defaultValue;
				num2 = 18;
				break;
			case 7:
			case 9:
				if (!(guid != Guid.Empty))
				{
					num2 = 2;
					break;
				}
				goto case 19;
			case 4:
				runtimeType = ReflectionType.GetType((string)Oml4OfhWR64AnkUP4yQX(anyTypeSettings), throwOnError: false);
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				if (iAaMZYhWnIhRYVJ3q5ve(propertyMetadata2))
				{
					num2 = 14;
					break;
				}
				goto case 13;
			default:
				runtimeType = runtimeTypeDescriptor.RuntimeType;
				num2 = 15;
				break;
			case 18:
				return;
			case 8:
				runtimeType = Type.GetType(codeItemMetadata.FullTypeName);
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 10;
				}
				break;
			case 3:
			case 11:
			case 15:
				if (Txl1UQhWk9BHRJGpO8Vk(runtimeType, null))
				{
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 13;
			case 17:
				if ((anyTypeSettings = UhanTThWi5fxq17EG48k(propertyMetadata) as AnyTypeSettings) != null)
				{
					num2 = 4;
					break;
				}
				goto case 12;
			case 1:
			case 2:
				if (t7ZI42hWq8UGLnEMkJ0D(runtimeType, null))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 10;
					}
					break;
				}
				goto case 3;
			case 14:
				runtimeType = FHK2x1hWOZUU3pMU13Vk(typeof(Nullable<>).TypeHandle).MakeGenericType(runtimeType);
				num2 = 13;
				break;
			case 5:
				if ((runtimeTypeDescriptor = ((IMetadataService)W1GpgrhWXaD7Ls9bWkDl()).GetTypeDescriptor(propertyMetadata.TypeUid, guid) as IRuntimeTypeDescriptor) == null)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto default;
			case 16:
				if (runtimeType.IsValueType)
				{
					num2 = 21;
					break;
				}
				goto case 13;
			}
		}
	}

	IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (propContainer == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 2;
			case 2:
				return (IPropertyValueContainer)r98hfAhW2nkUjMtsi7n2(propContainer);
			}
			propContainer = (IPropertyDefaultValueContainer)Activator.CreateInstance(typeof(PropertyValueContainer<>).MakeGenericType(runtimeType), (defaultValue == null) ? null : new object[1] { defaultValue });
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
			{
				num2 = 2;
			}
		}
	}

	internal static void zHTUf5hWSbr3wnRZuY5Q()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object UhanTThWi5fxq17EG48k(object P_0)
	{
		return ((IPropertyMetadata)P_0).Settings;
	}

	internal static object Oml4OfhWR64AnkUP4yQX(object P_0)
	{
		return ((AnyTypeSettings)P_0).FullTypeName;
	}

	internal static bool t7ZI42hWq8UGLnEMkJ0D(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid n9HZ2QhWK5PNjv6fURif(object P_0)
	{
		return ((IPropertyMetadata)P_0).SubTypeUid;
	}

	internal static object W1GpgrhWXaD7Ls9bWkDl()
	{
		return MetadataServiceContext.Service;
	}

	internal static object K9VluehWT6yJf3ELq5nC()
	{
		return MetadataServiceContext.MetadataRuntimeService;
	}

	internal static bool Txl1UQhWk9BHRJGpO8Vk(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool iAaMZYhWnIhRYVJ3q5ve(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static Type FHK2x1hWOZUU3pMU13Vk(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool WAlGvchWIIIf2N6PTGjt()
	{
		return Sfu5hwhWu8wkXdYpY4Rc == null;
	}

	internal static PropertyAnyTypeValueContainer BePqEuhWVBnOcLH9gWU5()
	{
		return Sfu5hwhWu8wkXdYpY4Rc;
	}

	internal static object r98hfAhW2nkUjMtsi7n2(object P_0)
	{
		return ((IPropertyDefaultValueContainer)P_0).Initialize();
	}
}
