using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.API.Models;

public class EntityFormData
{
	private static class Names
	{
		public static readonly object Items;

		internal static object TbPwctZB2LOcgEXGCrpr;

		static Names()
		{
			int num = 3;
			int num2 = num;
			ParameterExpression parameterExpression = default(ParameterExpression);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					SingletonReader.JJCZtPuTvSt();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 2:
					parameterExpression = Expression.Parameter(x4TQHSZB1ALBCchopEF3(typeof(EntityFormData).TypeHandle), (string)Avk3BPZBNFsLc3781fDO(-561074844 ^ -561096460));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					Items = LinqUtils.NameOf(Expression.Lambda<Func<EntityFormData, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static Type x4TQHSZB1ALBCchopEF3(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object Avk3BPZBNFsLc3781fDO(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool z5mo9ZZBe0kXKorwGlyZ()
		{
			return TbPwctZB2LOcgEXGCrpr == null;
		}

		internal static Names bAip6PZBPFCmJsgfhUJ5()
		{
			return (Names)TbPwctZB2LOcgEXGCrpr;
		}
	}

	internal static EntityFormData K1dGZOf1DAP0lXQOCcKs;

	public List<PropertyFormItemData> Items { get; set; }

	public EntityFormData()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		g9wDkDf14YLHP13ENw9B();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Items = new List<PropertyFormItemData>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public EntityFormData(Type entityType, RootViewItem viewItem)
	{
		//Discarded unreachable code: IL_002a
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
		{
			num = 0;
		}
		IMetadataRuntimeService serviceNotNull = default(IMetadataRuntimeService);
		IEnumerable<IEntityFilterProvider> extensionPoints = default(IEnumerable<IEntityFilterProvider>);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 2:
				Items = CreateItems(entityType, viewItem, serviceNotNull, extensionPoints);
				num2 = 3;
				goto IL_002f;
			case 1:
				extensionPoints = ((ComponentManager)ceiXQpf16xWDmE2pcHOY()).GetExtensionPoints<IEntityFilterProvider>();
				num2 = 2;
				goto IL_002f;
			case 3:
				return;
				IL_002f:
				num = num2;
				continue;
			}
			serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
			{
				num = 1;
			}
		}
	}

	private static Guid ProcessSubTypeUid(Guid subTypeUid)
	{
		//Discarded unreachable code: IL_00a8, IL_00b8
		int num = 4;
		int num2 = num;
		Type typeByUidOrNull = default(Type);
		IMetadata metadata = default(IMetadata);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 3:
				return subTypeUid;
			case 4:
				if (!(subTypeUid == Guid.Empty))
				{
					typeByUidOrNull = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(subTypeUid);
					num2 = 6;
					continue;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				if (l3yXjuf1Hpa8JKdSjYIW(typeByUidOrNull, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 2;
			case 2:
				obj = null;
				break;
			case 5:
				return subTypeUid;
			case 1:
				if (metadata != null)
				{
					return j2nMiqf1ACBonPDk7H3I(metadata);
				}
				num2 = 5;
				continue;
			default:
				obj = MetadataLoader.LoadMetadata(typeByUidOrNull);
				break;
			}
			metadata = (IMetadata)obj;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
			{
				num2 = 1;
			}
		}
	}

	private static List<PropertyFormItemData> CreateItems(Type type, object viewItem, object metadataService, IEnumerable<IEntityFilterProvider> providers)
	{
		IEnumerable<PropertyViewItem> allProperties = ((RootViewItem)viewItem).GetAllProperties(ignoreHide: true);
		List<PropertyFormItemData> list = new List<PropertyFormItemData>();
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(type);
		IEnumerable<IPropertyMetadata> enumerable;
		if (!(classMetadata is IEntityMetadata entityMetadata))
		{
			IEnumerable<IPropertyMetadata> properties = classMetadata.Properties;
			enumerable = properties;
		}
		else
		{
			enumerable = entityMetadata.GetPropertiesAndTableParts();
		}
		IEnumerable<IPropertyMetadata> source = enumerable;
		using IEnumerator<PropertyViewItem> enumerator = allProperties.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
			_003C_003Ec__DisplayClass7_.propertyItem = enumerator.Current;
			_003C_003Ec__DisplayClass7_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass7_;
			CS_0024_003C_003E8__locals0.p = source.FirstOrDefault((IPropertyMetadata p1) => _003C_003Ec__DisplayClass7_0.x0vXAsZBwiAufbZt3S0I(_003C_003Ec__DisplayClass7_0.nBhdtWZBDEiIiSdvXCat(p1), _003C_003Ec__DisplayClass7_0.P8SP0uZBt0bt6udZCkjJ(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.propertyItem)));
			if (CS_0024_003C_003E8__locals0.p == null)
			{
				continue;
			}
			PropertyFormItemData propertyFormItemData = new PropertyFormItemData
			{
				Name = CS_0024_003C_003E8__locals0.p.Name,
				DisplayName = ((!string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.propertyItem.Attributes.LocalizableName)) ? CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.propertyItem.Attributes.LocalizableName : CS_0024_003C_003E8__locals0.p.DisplayName),
				Description = (CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.propertyItem.Attributes.LocalizableDescription ?? CS_0024_003C_003E8__locals0.p.Description),
				TypeUid = CS_0024_003C_003E8__locals0.p.TypeUid,
				SubTypeUid = ProcessSubTypeUid(CS_0024_003C_003E8__locals0.p.SubTypeUid),
				Settings = CS_0024_003C_003E8__locals0.p.Settings,
				Required = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.propertyItem.Attributes.Required,
				ReadOnly = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.propertyItem.IsReadOnly(),
				Visible = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.propertyItem.Attributes.Visible,
				CustomView = (!string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.propertyItem.CustomViewName) || ComponentManager.Current.GetExtensionPoints<IPropertyCustomView>().Any((IPropertyCustomView pcv) => _003C_003Ec__DisplayClass7_1.ENvX23ZBx2dG8c5nbGtD(pcv, CS_0024_003C_003E8__locals0.p, _003C_003Ec__DisplayClass7_1.OVZtbtZB7rvi1d2MSppK(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.propertyItem)))),
				HideEmpty = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.propertyItem.IsHideEmpty()
			};
			PropertyMetadata propertyMetadata = CS_0024_003C_003E8__locals0.p as PropertyMetadata;
			if (providers != null && propertyMetadata != null && propertyMetadata.Settings is EntitySettings)
			{
				foreach (IEntityFilterProvider provider in providers)
				{
					string filterProviderData = provider.GetFilterProviderData(type, propertyMetadata, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.propertyItem.Attributes);
					if (filterProviderData != null)
					{
						propertyFormItemData.FilterProviderUid = provider.ProviderUid;
						propertyFormItemData.FilterProviderData = filterProviderData;
						break;
					}
				}
			}
			list.Add(propertyFormItemData);
			if (CS_0024_003C_003E8__locals0.p is ITablePartMetadata)
			{
				Type typeByUidOrNull = ((IMetadataRuntimeService)metadataService).GetTypeByUidOrNull(CS_0024_003C_003E8__locals0.p.Uid, loadImplementation: true);
				if (typeByUidOrNull != null)
				{
					propertyFormItemData.Items = CreateItems(typeByUidOrNull, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.propertyItem, metadataService, providers);
				}
			}
			else if (CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.propertyItem.Items.Count > 0)
			{
				Guid uid = ((CS_0024_003C_003E8__locals0.p.SubTypeUid != Guid.Empty) ? CS_0024_003C_003E8__locals0.p.SubTypeUid : CS_0024_003C_003E8__locals0.p.TypeUid);
				Type typeByUidOrNull2 = ((IMetadataRuntimeService)metadataService).GetTypeByUidOrNull(uid, loadImplementation: true);
				if (typeByUidOrNull2 != null)
				{
					propertyFormItemData.Items = CreateItems(typeByUidOrNull2, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.propertyItem, metadataService, providers);
				}
			}
		}
		return list;
	}

	public static void GetDescriptor(TypeSerializationDescriptorBuilder builder)
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
				builder.ItemWithDescriptor((string)Names.Items, delegate(TypeSerializationDescriptorBuilder i)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							((TypeSerializationDescriptorBuilder)_003C_003Ec.KUI443ZBd6hQRV7T666y(i, _003C_003Ec.SXpF6vZB9frrgcATsTUb(_003C_003Ec.ULE5L4ZBJStk8waiBMEH(-2138958856 ^ -2138832118)))).IsArray((Action<TypeSerializationDescriptorBuilder>)PropertyFormItemData.GetDescriptor);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public WebData ToWebData()
	{
		//Discarded unreachable code: IL_0062
		int num = 3;
		int num2 = num;
		Dictionary<string, object> dictionary = default(Dictionary<string, object>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (Items == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				return new WebData(dictionary);
			case 3:
				dictionary = new Dictionary<string, object>();
				num2 = 2;
				continue;
			case 4:
				break;
			}
			dictionary[(string)Names.Items] = new SerializableList<object>(Items.Select((PropertyFormItemData fi) => fi.ToWebData()));
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
			{
				num2 = 0;
			}
		}
	}

	internal static void g9wDkDf14YLHP13ENw9B()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool tik3ref1tqLk8mDRgJZ9()
	{
		return K1dGZOf1DAP0lXQOCcKs == null;
	}

	internal static EntityFormData XbGC02f1wsiMgFUtJQnR()
	{
		return K1dGZOf1DAP0lXQOCcKs;
	}

	internal static object ceiXQpf16xWDmE2pcHOY()
	{
		return ComponentManager.Current;
	}

	internal static bool l3yXjuf1Hpa8JKdSjYIW(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid j2nMiqf1ACBonPDk7H3I(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}
}
