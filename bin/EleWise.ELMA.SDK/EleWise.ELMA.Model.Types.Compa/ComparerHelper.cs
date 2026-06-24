using System;
using System.Collections;
using System.ComponentModel;
using System.Linq.Expressions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Comparers;

public static class ComparerHelper
{
	internal static ComparerHelper OvbxCboUZ755c59kIUi0;

	internal static IComparer CreateComparer(this PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_008b, IL_009a, IL_01ff, IL_022f, IL_023e
		int num = 6;
		LambdaExpression lambdaExpression = default(LambdaExpression);
		ParameterExpression parameterExpression = default(ParameterExpression);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		EntitySettings entitySettings = default(EntitySettings);
		Type typeByUid = default(Type);
		ISortedProperty sortedProperty = default(ISortedProperty);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					lambdaExpression = Expression.Lambda((Expression)rBAVtmoUO66bmMFe5s8l(parameterExpression, hn5vr0oUnR0M2flqaGZb(propertyMetadata2)), parameterExpression);
					num2 = 9;
					break;
				case 3:
				{
					propertyMetadata2 = RefTypeDescriptor<IEntity, EntitySettings>.FindProperty(entityMetadata, A2qC42oUSL6ZdqB5Qn0N(entitySettings), out var _);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					break;
				}
				case 15:
					typeByUid = ((IMetadataRuntimeService)jaXspkoUXCoMxw4Oldc4()).GetTypeByUid(tN5IyToUTetwIBKRl2N2(entityMetadata), loadImplementation: true);
					num2 = 11;
					break;
				case 5:
					if (!lVg0qqoUVUNPB8mmJnvP(entitySettings))
					{
						num2 = 10;
						break;
					}
					goto default;
				case 6:
					entitySettings = (EntitySettings)propertyMetadata.Settings;
					num2 = 5;
					break;
				case 4:
					entityMetadata = MetadataServiceContext.Service.GetMetadata(propertyMetadata.SubTypeUid, loadImplementation: false) as EntityMetadata;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 2;
					}
					break;
				default:
					if (!(A2qC42oUSL6ZdqB5Qn0N(entitySettings) != Guid.Empty))
					{
						goto end_IL_0012;
					}
					goto case 4;
				case 7:
					if (giQuRYoUKs3AMEwTEP6s(sortedProperty))
					{
						num2 = 15;
						break;
					}
					goto case 10;
				case 2:
					if (entityMetadata == null)
					{
						num2 = 13;
						break;
					}
					goto case 3;
				case 1:
					sortedProperty = cEF8neoUqVaE2kdv6rSh(wixK5ToUihlvO0uryjhF(), qHBuvFoURhH85EEeXUJQ(propertyMetadata2), propertyMetadata2.SubTypeUid) as ISortedProperty;
					num2 = 12;
					break;
				case 11:
					parameterExpression = (ParameterExpression)mf3fh5oUk76VQWehLvsx(typeByUid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487215126));
					num2 = 8;
					break;
				case 9:
					return (IComparer)jvmOdEoUe35AaPcsk8WN(sortedProperty, typeByUid, lambdaExpression, Eyo6sEoU2MVt2VVReR78(entitySettings));
				case 10:
				case 13:
				case 14:
					return null;
				case 12:
					if (sortedProperty != null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 10;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 14;
		}
	}

	public static IComparer Create(Type sourceType, LambdaExpression propertyFunc, ListSortDirection order)
	{
		//Discarded unreachable code: IL_00b9
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return null;
			default:
				return (IComparer)JZPuYGoU302LP2oKsDfb(q126pGoU12qUit2h5Qx1(typeof(Comparer<, >).TypeHandle).MakeGenericType(sourceType, a1llixoUNnlXnCSbpuRD(propertyFunc)), new object[2] { propertyFunc, order });
			case 2:
				if (!l0qEaZoUP1G6Mvg56adU(sourceType, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 1:
				if (propertyFunc != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	internal static bool lVg0qqoUVUNPB8mmJnvP(object P_0)
	{
		return ((EntitySettings)P_0).CanSortProperty;
	}

	internal static Guid A2qC42oUSL6ZdqB5Qn0N(object P_0)
	{
		return ((EntitySettings)P_0).SortPropertyUid;
	}

	internal static object wixK5ToUihlvO0uryjhF()
	{
		return MetadataServiceContext.Service;
	}

	internal static Guid qHBuvFoURhH85EEeXUJQ(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static object cEF8neoUqVaE2kdv6rSh(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static bool giQuRYoUKs3AMEwTEP6s(object P_0)
	{
		return ((ISortedProperty)P_0).IsSupportSort();
	}

	internal static object jaXspkoUXCoMxw4Oldc4()
	{
		return MetadataServiceContext.MetadataRuntimeService;
	}

	internal static Guid tN5IyToUTetwIBKRl2N2(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object mf3fh5oUk76VQWehLvsx(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object hn5vr0oUnR0M2flqaGZb(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object rBAVtmoUO66bmMFe5s8l(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (string)P_1);
	}

	internal static ListSortDirection Eyo6sEoU2MVt2VVReR78(object P_0)
	{
		return ((EntitySettings)P_0).SortPropertyOrder;
	}

	internal static object jvmOdEoUe35AaPcsk8WN(object P_0, Type sourceType, object P_2, ListSortDirection order)
	{
		return ((ISortedProperty)P_0).GetComparer(sourceType, (LambdaExpression)P_2, order);
	}

	internal static bool Ke4VP7oUuRCNrx0GOG7Y()
	{
		return OvbxCboUZ755c59kIUi0 == null;
	}

	internal static ComparerHelper fJD8P3oUIRgBeKqALxLe()
	{
		return OvbxCboUZ755c59kIUi0;
	}

	internal static bool l0qEaZoUP1G6Mvg56adU(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Type q126pGoU12qUit2h5Qx1(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Type a1llixoUNnlXnCSbpuRD(object P_0)
	{
		return ((LambdaExpression)P_0).ReturnType;
	}

	internal static object JZPuYGoU302LP2oKsDfb(Type P_0, object P_1)
	{
		return Activator.CreateInstance(P_0, (object[])P_1);
	}
}
