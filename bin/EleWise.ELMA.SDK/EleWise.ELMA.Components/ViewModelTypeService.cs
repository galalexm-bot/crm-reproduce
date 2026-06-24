using System;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Components;

[Component]
public abstract class ViewModelTypeService : IViewModelTypeService
{
	private static ViewModelTypeService vMo7mJfGD8RdbrHEhcQG;

	public abstract bool Check(string metadataTypeCode);

	public virtual ViewModelTypeName GetViewPropertyModelType(IPropertyMetadata property, string metadataNamespace)
	{
		//Discarded unreachable code: IL_0111, IL_0141, IL_0151, IL_015b, IL_017f, IL_018e, IL_01fb, IL_023c, IL_024b
		int num = 11;
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		EntitySettings entitySettings = default(EntitySettings);
		Type type = default(Type);
		bool isNullable = default(bool);
		ClassMetadata classMetadata = default(ClassMetadata);
		bool isEnumerable = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				int num4;
				object obj;
				switch (num2)
				{
				case 13:
					typeDescriptor = (ITypeDescriptor)THWx5ZfGAFaoike68hDs(iLh2O6fG6j1DppFKGExP(), property.TypeUid, wOc8IefGH9o918HLQCcR(property));
					num2 = 12;
					continue;
				case 19:
					if (!(property is ClassMetadata))
					{
						num2 = 6;
						continue;
					}
					goto case 1;
				case 15:
					return new ViewModelTypeName((string)PBvQhPfG4MPXOYCUWLDL(property), metadataNamespace, isNullable: false, isEnumerable: true);
				case 10:
					if (property == null)
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 13;
				case 3:
					entitySettings = property.Settings as EntitySettings;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 9;
					}
					continue;
				case 16:
					num3 = (oo8VTefGm9AraSDBcOE7((PropertyMetadata)property) ? 1 : 0);
					goto IL_02b7;
				case 9:
					if (entitySettings != null)
					{
						num2 = 17;
						continue;
					}
					num4 = 0;
					goto IL_02c4;
				case 4:
					if (!(property is PropertyMetadata))
					{
						num2 = 7;
						continue;
					}
					goto case 16;
				case 18:
					obj = null;
					goto IL_02aa;
				case 11:
					if (!(property is ITablePartMetadata))
					{
						num2 = 10;
						continue;
					}
					goto case 19;
				case 20:
					return new ViewModelTypeName((string)fpsyhufGyhNjE25CJ3hi(type), type.Namespace, isNullable);
				case 5:
					classMetadata = (ClassMetadata)MetadataServiceContext.Service.GetMetadata(property.SubTypeUid);
					num2 = 3;
					continue;
				case 17:
					num4 = ((FQI544fGML2iogM0YQup(entitySettings) != RelationType.OneToOne) ? 1 : 0);
					goto IL_02c4;
				case 2:
					if (!SDE7y7fGx5Q217q8K2Dp(type, null))
					{
						if (typeDescriptor is EntityDescriptor)
						{
							num = 5;
							break;
						}
						goto case 6;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					if (metadataNamespace != null)
					{
						num2 = 15;
						continue;
					}
					goto case 6;
				case 8:
					return new ViewModelTypeName((string)QELlqsfGJtLisKWvv008(classMetadata), (string)nklVKdfG9Y829lpRK9Ww(classMetadata), isNullable: false, isEnumerable);
				case 6:
				case 14:
					return null;
				case 12:
					if (!(typeDescriptor is IRuntimeTypeDescriptor))
					{
						num2 = 18;
						continue;
					}
					obj = nZy2MXfG7Iyx25xrLJEr((IRuntimeTypeDescriptor)typeDescriptor);
					goto IL_02aa;
				default:
					if (!hTlsOgfG07ALk1hjp1L9(typeDescriptor))
					{
						num = 21;
						break;
					}
					goto case 4;
				case 7:
				case 21:
					{
						num3 = 0;
						goto IL_02b7;
					}
					IL_02c4:
					isEnumerable = (byte)num4 != 0;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 4;
					}
					continue;
					IL_02b7:
					isNullable = (byte)num3 != 0;
					num2 = 20;
					continue;
					IL_02aa:
					type = (Type)obj;
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	public virtual ViewModelTypeName GetViewModelType(string metadataName, string metadataNamespace, bool useOriginalModel)
	{
		return new ViewModelTypeName(metadataName, metadataNamespace);
	}

	protected ViewModelTypeService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WxxpUsfGdhuT4quc8nKO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object PBvQhPfG4MPXOYCUWLDL(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static object iLh2O6fG6j1DppFKGExP()
	{
		return MetadataServiceContext.Service;
	}

	internal static Guid wOc8IefGH9o918HLQCcR(object P_0)
	{
		return ((IPropertyMetadata)P_0).SubTypeUid;
	}

	internal static object THWx5ZfGAFaoike68hDs(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static Type nZy2MXfG7Iyx25xrLJEr(object P_0)
	{
		return ((IRuntimeTypeDescriptor)P_0).RuntimeType;
	}

	internal static bool SDE7y7fGx5Q217q8K2Dp(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool hTlsOgfG07ALk1hjp1L9(object P_0)
	{
		return ((ITypeDescriptor)P_0).CanBeNullable;
	}

	internal static bool oo8VTefGm9AraSDBcOE7(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static object fpsyhufGyhNjE25CJ3hi(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static RelationType FQI544fGML2iogM0YQup(object P_0)
	{
		return ((EntitySettings)P_0).RelationType;
	}

	internal static object QELlqsfGJtLisKWvv008(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object nklVKdfG9Y829lpRK9Ww(object P_0)
	{
		return ((ClassMetadata)P_0).Namespace;
	}

	internal static bool en1VX3fGtPkZkGZ3Jxnu()
	{
		return vMo7mJfGD8RdbrHEhcQG == null;
	}

	internal static ViewModelTypeService tDnNWkfGwpH5ubUMfiDV()
	{
		return vMo7mJfGD8RdbrHEhcQG;
	}

	internal static void WxxpUsfGdhuT4quc8nKO()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
