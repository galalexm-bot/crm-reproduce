using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Metadata;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class MetadataSignatureExtensions
{
	internal static MetadataSignatureExtensions mZOGr5GacO8UGN80jNH1;

	public static TSignature GetClassMetadataSignature<TSignature, TMetadata>(this TMetadata metadata, IEnumerable<IPropertyMetadata> properties) where TSignature : ClassDependency where TMetadata : ClassMetadata
	{
		TSignature val = InterfaceActivator.Create<TSignature>();
		if (metadata is EntityMetadata entityMetadata)
		{
			if (entityMetadata.Type == EntityMetadataType.Interface)
			{
				val.HeaderUid = entityMetadata.ImplementationUid;
			}
			else if (entityMetadata.Type == EntityMetadataType.InterfaceExtension)
			{
				val.HeaderUid = MetadataServiceContext.Service.GetMetadata(entityMetadata.BaseClassUid)?.Uid ?? entityMetadata.Uid;
			}
			else
			{
				val.HeaderUid = entityMetadata.Uid;
			}
		}
		else
		{
			val.HeaderUid = metadata.Uid;
		}
		val.ModuleUid = metadata.ModuleUid;
		val.Name = metadata.Name;
		val.DisplayName = metadata.DisplayName;
		foreach (IPropertyMetadata property in properties)
		{
			val.Properties.Add(property.CreatePropertySignature());
		}
		return val;
	}

	public static DataClassDependency GetSignature(this DataClassMetadata metadata, bool simple = false)
	{
		IEnumerable<PropertyMetadata> properties2;
		if (!simple)
		{
			IEnumerable<PropertyMetadata> properties = metadata.Properties;
			properties2 = properties;
		}
		else
		{
			properties2 = Enumerable.Empty<PropertyMetadata>();
		}
		return metadata.GetSignature(properties2);
	}

	public static DataClassDependency GetSignature(this DataClassMetadata metadata, IEnumerable<IPropertyMetadata> properties)
	{
		return metadata.GetClassMetadataSignature<DataClassDependency, DataClassMetadata>(properties);
	}

	public static EntityDependency GetSignature(this EntityMetadata metadata, bool simple = false)
	{
		//Discarded unreachable code: IL_0095, IL_00c5, IL_00d4, IL_00e4, IL_0165, IL_0174, IL_0200, IL_020f, IL_02ce
		int num = 7;
		IEnumerable<IPropertyMetadata> properties = default(IEnumerable<IPropertyMetadata>);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_2 = default(_003C_003Ec__DisplayClass3_0);
		IEnumerable<IPropertyMetadata> propertiesAndTableParts = default(IEnumerable<IPropertyMetadata>);
		List<IPropertyMetadata> list = default(List<IPropertyMetadata>);
		IPropertyMetadata propertyMetadata2 = default(IPropertyMetadata);
		IPropertyMetadata propertyMetadata = default(IPropertyMetadata);
		_003C_003Ec__DisplayClass3_1 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_1);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (!simple)
					{
						num2 = 3;
						break;
					}
					goto default;
				case 7:
					properties = Enumerable.Empty<IPropertyMetadata>();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 6;
					}
					break;
				case 3:
				case 24:
					properties = metadata.GetPropertiesAndTableParts();
					num2 = 4;
					break;
				case 8:
				case 13:
				case 19:
					_003C_003Ec__DisplayClass3_2.parentPropertyUid = lWTrv2GDbelpcmmO23Sn(metadata);
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 20;
					}
					break;
				case 17:
					propertiesAndTableParts = metadata.GetPropertiesAndTableParts();
					num2 = 15;
					break;
				case 1:
				case 4:
				case 14:
					return metadata.GetSignature(properties);
				case 9:
				case 18:
					properties = list;
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 9;
					}
					break;
				case 2:
					if (propertyMetadata2 == null)
					{
						num2 = 18;
						break;
					}
					goto case 22;
				case 21:
					if (propertyMetadata == null)
					{
						num2 = 13;
						break;
					}
					goto case 5;
				case 16:
					_003C_003Ec__DisplayClass3_2 = new _003C_003Ec__DisplayClass3_0();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 10;
					}
					break;
				case 15:
					if (qoNgF4GDWxHweRJXPK21(metadata) != 0)
					{
						goto end_IL_0012;
					}
					goto case 11;
				case 20:
					propertyMetadata2 = propertiesAndTableParts.FirstOrDefault(_003C_003Ec__DisplayClass3_2._003CGetSignature_003Eb__0);
					num2 = 2;
					break;
				case 5:
					list.Add(propertyMetadata);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 2;
					}
					break;
				case 11:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_1();
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 5;
					}
					break;
				case 10:
					list = new List<IPropertyMetadata>();
					num2 = 17;
					break;
				case 12:
					_003C_003Ec__DisplayClass3_.isGroupPropertyUid = goaR8uGDosDJHgKtUhmW(metadata);
					num2 = 23;
					break;
				case 22:
					list.Add(propertyMetadata2);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 9;
					}
					break;
				case 23:
					propertyMetadata = propertiesAndTableParts.FirstOrDefault(_003C_003Ec__DisplayClass3_._003CGetSignature_003Eb__1);
					num2 = 21;
					break;
				default:
					if (!OTbBggGDBg4pEtiCOqY8(metadata))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 16;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 19;
		}
	}

	public static EntityDependency GetSignature(this EntityMetadata metadata, IEnumerable<IPropertyMetadata> properties)
	{
		return metadata.GetClassMetadataSignature<EntityDependency, EntityMetadata>(properties);
	}

	public static FunctionDependency GetSignature(this FunctionMetadata metadata)
	{
		FunctionDependency obj = new FunctionDependency
		{
			HeaderUid = metadata.Uid
		};
		i5NXBgGDGC62PGq0aycJ(obj, n33rXiGDhqNtg7UwT1Xx(metadata));
		fiH35RGDfy4htl4100Iy(obj, aLklGDGDE5yksJrsmWTH(metadata));
		OwSC01GDCg80Tn5LUePD(obj, AHEiIMGDQJYl5XsJ4O6i(metadata));
		obj.ParameterType = (TypeSignature)b9MsMvGDvMGr5rmZ1wdu(metadata);
		w1vBeyGD8gf3fWgA9p3c(obj, metadata.ReturnType);
		return obj;
	}

	public static EnumDependency GetSignature(this EnumMetadata metadata)
	{
		EnumDependency enumDependency = new EnumDependency();
		bv3uZlGDZHUSPrcgIemk(enumDependency, metadata.Uid);
		i5NXBgGDGC62PGq0aycJ(enumDependency, n33rXiGDhqNtg7UwT1Xx(metadata));
		fiH35RGDfy4htl4100Iy(enumDependency, aLklGDGDE5yksJrsmWTH(metadata));
		OwSC01GDCg80Tn5LUePD(enumDependency, metadata.DisplayName);
		return enumDependency;
	}

	public static ComponentDependency GetDependency(this ComponentMetadata componentMetadata, ComponentViewItem component)
	{
		ComponentDependency obj = new ComponentDependency
		{
			ViewItemUid = Nbf3B8GDuaNJ1cFVP5k4(component)
		};
		bv3uZlGDZHUSPrcgIemk(obj, nd1NKpGDI6tAWHusdK7h(component));
		i5NXBgGDGC62PGq0aycJ(obj, n33rXiGDhqNtg7UwT1Xx(componentMetadata));
		fiH35RGDfy4htl4100Iy(obj, aLklGDGDE5yksJrsmWTH(componentMetadata));
		OwSC01GDCg80Tn5LUePD(obj, componentMetadata.DisplayName);
		obj.Async = component.LoadingType != ViewItemLoadingType.SyncLoading;
		return obj;
	}

	public static ComponentSignature GetSignature(this ComponentMetadata metadata)
	{
		//Discarded unreachable code: IL_0088, IL_0097, IL_0193, IL_01a2, IL_023e, IL_024d, IL_0290, IL_03bf, IL_0447, IL_0456, IL_04cf, IL_04de, IL_0506, IL_0590, IL_05a3, IL_05b2, IL_05e6, IL_05f5, IL_0605
		int num = 9;
		ComponentSignature componentSignature = default(ComponentSignature);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		PropertyMetadata current = default(PropertyMetadata);
		InputComputedValue inputComputedValue = default(InputComputedValue);
		EntitySettings entitySettings = default(EntitySettings);
		ActionSettings actionSettings2 = default(ActionSettings);
		TypeSettings settings = default(TypeSettings);
		ListOfSimpleTypeSettings listOfSimpleTypeSettings = default(ListOfSimpleTypeSettings);
		IViewModelPropertyMetadata viewModelPropertyMetadata = default(IViewModelPropertyMetadata);
		EntitySettings entitySettings2 = default(EntitySettings);
		ListOfSimpleTypeSettings listOfSimpleTypeSettings2 = default(ListOfSimpleTypeSettings);
		ActionSettings actionSettings = default(ActionSettings);
		DataClassSettings dataClassSettings2 = default(DataClassSettings);
		DataClassSettings dataClassSettings = default(DataClassSettings);
		List<PlaceholderViewItem> list = default(List<PlaceholderViewItem>);
		List<ExtensionPointViewItem> source = default(List<ExtensionPointViewItem>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					uU2H3bGDw2EGDcIRRFUd(componentSignature, XV0oOGGDtYsGeBkuJwQP(metadata));
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
				case 12:
					return componentSignature;
				case 5:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
								{
									num3 = 30;
								}
								goto IL_00a6;
							}
							goto IL_0330;
							IL_0330:
							current = enumerator.Current;
							num3 = 26;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
							{
								num3 = 25;
							}
							goto IL_00a6;
							IL_00a6:
							while (true)
							{
								switch (num3)
								{
								case 1:
								case 10:
								case 21:
									break;
								case 3:
									PeDxSwGDOmAnWJEuYAwF(inputComputedValue, YHlvi5GDnxARJHRYDRiG(entitySettings));
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
									{
										num3 = 7;
									}
									continue;
								case 22:
									if ((actionSettings2 = settings as ActionSettings) != null)
									{
										num3 = 14;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
										{
											num3 = 23;
										}
										continue;
									}
									goto case 13;
								case 17:
									yHjA0SGDkyPXc1Fx1L9k(inputComputedValue, rCODdqGDeVT8t9u3E2Ej(listOfSimpleTypeSettings));
									num3 = 32;
									continue;
								default:
									settings = current.Settings;
									num3 = 15;
									continue;
								case 29:
									inputComputedValue.ComputedValueType = ComputedValueType.Input;
									num3 = 35;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
									{
										num3 = 3;
									}
									continue;
								case 33:
								{
									PeDxSwGDOmAnWJEuYAwF(inputComputedValue, RelationType.ManyToMany);
									int num4 = 17;
									num3 = num4;
									continue;
								}
								case 19:
									if (NgkYqhGDRwAcFkoeEJax(viewModelPropertyMetadata))
									{
										num3 = 12;
										continue;
									}
									goto case 25;
								case 4:
									entitySettings = entitySettings2;
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
									{
										num3 = 0;
									}
									continue;
								case 11:
									componentSignature.Inputs.Add(inputComputedValue);
									num3 = 18;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
									{
										num3 = 21;
									}
									continue;
								case 18:
									if ((listOfSimpleTypeSettings2 = settings as ListOfSimpleTypeSettings) != null)
									{
										num3 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
										{
											num3 = 5;
										}
										continue;
									}
									goto case 2;
								case 16:
								case 23:
									actionSettings = actionSettings2;
									num3 = 6;
									continue;
								case 5:
								case 20:
									listOfSimpleTypeSettings = listOfSimpleTypeSettings2;
									num3 = 23;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
									{
										num3 = 33;
									}
									continue;
								case 31:
									if ((dataClassSettings2 = settings as DataClassSettings) == null)
									{
										num3 = 18;
										continue;
									}
									goto case 34;
								case 27:
									goto IL_0330;
								case 25:
									if (!NJXvrGGDq7d8buuTStVj(viewModelPropertyMetadata))
									{
										num3 = 10;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
										{
											num3 = 10;
										}
										continue;
									}
									goto case 12;
								case 26:
									if ((viewModelPropertyMetadata = current as IViewModelPropertyMetadata) == null)
									{
										num3 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
										{
											num3 = 1;
										}
										continue;
									}
									goto case 19;
								case 14:
									inputComputedValue.RelationType = uKFQdmGD21lnHKV8q1GU(dataClassSettings);
									num3 = 9;
									continue;
								case 34:
									dataClassSettings = dataClassSettings2;
									num3 = 14;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
									{
										num3 = 12;
									}
									continue;
								case 12:
								case 24:
									inputComputedValue = new InputComputedValue
									{
										SubTypeUid = adrkkCGDKkuTUhcNr9sU(current)
									};
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
									{
										num3 = 0;
									}
									continue;
								case 15:
									if (settings != null)
									{
										num3 = 22;
										continue;
									}
									goto case 2;
								case 8:
									inputComputedValue.Required = current.Required;
									num3 = 11;
									continue;
								case 35:
									rhXja4GD1VO5aRPuOsem(inputComputedValue, current.TypeUid);
									num3 = 28;
									continue;
								case 6:
								{
									ActionInputComputedValue actionInputComputedValue = new ActionInputComputedValue();
									pAGDy3GDXb9MypLP4gun(actionInputComputedValue, actionSettings.ParameterType);
									actionInputComputedValue.ReturnType = (TypeSignature)kD6c8fGDTri4VbNa4x0M(actionSettings);
									yHjA0SGDkyPXc1Fx1L9k(actionInputComputedValue, current.SubTypeUid);
									inputComputedValue = actionInputComputedValue;
									num3 = 2;
									continue;
								}
								case 13:
									if ((entitySettings2 = settings as EntitySettings) == null)
									{
										num3 = 31;
										continue;
									}
									goto case 4;
								case 28:
									IWAJ3dGD306iGhDcv0du(inputComputedValue, BpEhpWGDNNQ3wCTJrKXl(current));
									num3 = 8;
									continue;
								case 2:
								case 7:
								case 9:
								case 32:
									inputComputedValue.Name = (string)(NJXvrGGDq7d8buuTStVj(viewModelPropertyMetadata) ? Di7R8kGDPiSavwra1y3J(0x1ECE530A ^ 0x1ECEAE9A) : Di7R8kGDPiSavwra1y3J(-70037984 ^ -70012026)) + (string)aLklGDGDE5yksJrsmWTH(current);
									num3 = 29;
									continue;
								case 30:
									goto end_IL_0140;
								}
								break;
							}
							continue;
							end_IL_0140:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 3;
				case 9:
					sR1n50GDVVNg33deU2sk(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463A4602));
					num = 8;
					break;
				case 11:
					if (EqBK79GDad6enJjPwjXO(list) <= 0)
					{
						num2 = 14;
						continue;
					}
					goto case 10;
				case 8:
				{
					ComponentSignature componentSignature2 = new ComponentSignature();
					bv3uZlGDZHUSPrcgIemk(componentSignature2, metadata.Uid);
					i5NXBgGDGC62PGq0aycJ(componentSignature2, n33rXiGDhqNtg7UwT1Xx(metadata));
					fiH35RGDfy4htl4100Iy(componentSignature2, aLklGDGDE5yksJrsmWTH(metadata));
					OwSC01GDCg80Tn5LUePD(componentSignature2, AHEiIMGDQJYl5XsJ4O6i(metadata));
					componentSignature = componentSignature2;
					num2 = 6;
					continue;
				}
				case 2:
				case 14:
					if (!Ha4rofGDD9B2s2RRrcj6(n33rXiGDhqNtg7UwT1Xx(metadata), Guid.Empty))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 13;
				case 6:
					enumerator = ((ClassMetadata)f3hC2rGDit14b1eyeA2f(nxvEoWGDSw3cwObtcueW(metadata))).Properties.GetEnumerator();
					num2 = 5;
					continue;
				case 3:
					list = ((RootViewItem)gXBwrjGDpFo8USaKmcJK(metadata.Content)).FindItems(ignoreHide: true, (Func<ViewItem, bool>)((ViewItem s) => s is PlaceholderViewItem), (Func<ViewItem, bool>)null).Cast<PlaceholderViewItem>().ToList();
					num2 = 11;
					continue;
				case 10:
					componentSignature.Inputs.AddRange(list.Select(delegate(PlaceholderViewItem s)
					{
						InputComputedValue inputComputedValue2 = new InputComputedValue();
						_003C_003Ec.bFQPir8WNDuFAu4KSLDW(inputComputedValue2, _003C_003Ec.Y7Lg8N8W1MNNgpZSSKAN(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A047CD), _003C_003Ec.s3vZf78WP4mosKpYsuj3(s)));
						_003C_003Ec.qgGJje8W3BTRV5EHoSfK(inputComputedValue2, SlotViewItem.TypeUid);
						inputComputedValue2.SubTypeUid = s.Uid;
						return inputComputedValue2;
					}));
					num = 2;
					break;
				case 13:
					componentSignature.Implementations.AddRange(metadata.Implementations.Select(delegate(Implementation s)
					{
						ImplementationSignature implementationSignature = new ImplementationSignature();
						_003C_003Ec.KvCR3U8WaYM8yKUEOlZu(implementationSignature, _003C_003Ec.nlk3Yq8Wpty88Ls4K0wm(s));
						implementationSignature.TypeUid = _003C_003Ec.pwGtD68WDxFhg2vFHux6(s);
						return implementationSignature;
					}));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					source = ((ComponentContentMetadata)nxvEoWGDSw3cwObtcueW(metadata)).View.FindItems(ignoreHide: true, (ViewItem s) => s is ExtensionPointViewItem).Cast<ExtensionPointViewItem>().ToList();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 5;
					}
					continue;
				case 7:
					componentSignature.ExtensionPoints.AddRange(source.Select((ExtensionPointViewItem s) => new ImplementationSignature
					{
						PointId = (string)_003C_003Ec.wRDYjc8Wt3xxq8xsg9sw(s),
						TypeUid = s.TypeUid
					}));
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	public static ModuleSignature GetSignature(this ModuleInfoMetadata metadata)
	{
		//Discarded unreachable code: IL_008d, IL_0097, IL_00db, IL_00e5, IL_015d, IL_016c, IL_0245, IL_0258, IL_02be, IL_03f4, IL_0407, IL_0416, IL_054d, IL_0560, IL_056f
		int num = 2;
		ModuleSignature moduleSignature = default(ModuleSignature);
		List<ComponentMetadata>.Enumerator enumerator = default(List<ComponentMetadata>.Enumerator);
		ComponentMetadata current = default(ComponentMetadata);
		List<ExtensionPointViewItem>.Enumerator enumerator2 = default(List<ExtensionPointViewItem>.Enumerator);
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_2 = default(_003C_003Ec__DisplayClass9_0);
		List<ExtensionPointViewItem> list = default(List<ExtensionPointViewItem>);
		List<Implementation>.Enumerator enumerator3 = default(List<Implementation>.Enumerator);
		_003C_003Ec__DisplayClass9_1 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_1);
		while (true)
		{
			int num2 = num;
			List<DataClassDependency> dataClasses;
			IEnumerable<DataClassMetadata> source;
			Func<DataClassMetadata, DataClassDependency> selector;
			while (true)
			{
				switch (num2)
				{
				case 1:
					moduleSignature = new ModuleSignature();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 5;
					}
					continue;
				case 6:
					enumerator = metadata.Components.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return moduleSignature;
				case 2:
					sR1n50GDVVNg33deU2sk(metadata, Di7R8kGDPiSavwra1y3J(0x18A6761F ^ 0x18A63F21));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					dataClasses = moduleSignature.DataClasses;
					source = metadata.DataClasses.Where((DataClassMetadata d) => !_003C_003Ec.MZ4hEp8WwI8uVV9DqsGK(d));
					selector = (DataClassMetadata d) => d.GetSignature();
					goto end_IL_0012;
				case 7:
					moduleSignature.Components.AddRange(from d in metadata.Components
						where !_003C_003Ec.MZ4hEp8WwI8uVV9DqsGK(d)
						select d.GetSignature());
					num2 = 4;
					continue;
				case 4:
					moduleSignature.Functions.AddRange(from d in metadata.Functions
						where !d.Internal
						select (FunctionDependency)_003C_003Ec.nKjJpx8W4KXEF7QtYNoQ(d));
					num2 = 6;
					continue;
				}
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
							{
								num3 = 4;
							}
							goto IL_009b;
						}
						goto IL_04a0;
						IL_04a0:
						current = enumerator.Current;
						num3 = 3;
						goto IL_009b;
						IL_009b:
						while (true)
						{
							switch (num3)
							{
							case 4:
								return moduleSignature;
							case 8:
								try
								{
									while (true)
									{
										IL_019f:
										int num7;
										if (!enumerator2.MoveNext())
										{
											num7 = 6;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
											{
												num7 = 3;
											}
											goto IL_00e9;
										}
										goto IL_0147;
										IL_0147:
										_003C_003Ec__DisplayClass9_2 = new _003C_003Ec__DisplayClass9_0();
										num7 = 3;
										goto IL_00e9;
										IL_00e9:
										while (true)
										{
											switch (num7)
											{
											case 5:
												if (moduleSignature.ExtensionPoints.Any(_003C_003Ec__DisplayClass9_2._003CGetSignature_003Eb__7))
												{
													num7 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
													{
														num7 = 1;
													}
													continue;
												}
												goto case 4;
											case 2:
												break;
											case 3:
												_003C_003Ec__DisplayClass9_2.extensionPoint = enumerator2.Current;
												num7 = 5;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
												{
													num7 = 1;
												}
												continue;
											default:
												goto IL_019f;
											case 4:
												moduleSignature.ExtensionPoints.AddRange(list.Select(delegate(ExtensionPointViewItem s)
												{
													ImplementationSignature implementationSignature2 = new ImplementationSignature();
													_003C_003Ec.KvCR3U8WaYM8yKUEOlZu(implementationSignature2, _003C_003Ec.wRDYjc8Wt3xxq8xsg9sw(s));
													_003C_003Ec.fP5TUR8WHG4P81H99Nhb(implementationSignature2, _003C_003Ec.Q9bxIB8W6OMswTpLkSt6(s));
													return implementationSignature2;
												}));
												num7 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
												{
													num7 = 0;
												}
												continue;
											case 6:
												goto end_IL_019f;
											}
											break;
										}
										goto IL_0147;
										continue;
										end_IL_019f:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator2).Dispose();
									int num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
									{
										num8 = 0;
									}
									switch (num8)
									{
									case 0:
										break;
									}
								}
								goto case 6;
							case 1:
								if (Ao7w2FGD4bpdAQYfgOgk(current.CustomTypeImplementation.TypeUid, Guid.Empty))
								{
									num3 = 5;
									continue;
								}
								goto default;
							case 5:
								moduleSignature.CustomTypes.Add(current.CustomTypeImplementation);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
								{
									num3 = 0;
								}
								continue;
							case 10:
								try
								{
									while (true)
									{
										IL_031b:
										int num4;
										if (!enumerator3.MoveNext())
										{
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
											{
												num4 = 0;
											}
											goto IL_02cc;
										}
										goto IL_02ee;
										IL_02ee:
										_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_1();
										int num5 = 5;
										num4 = num5;
										goto IL_02cc;
										IL_02cc:
										while (true)
										{
											switch (num4)
											{
											case 2:
												goto IL_02ee;
											case 5:
												_003C_003Ec__DisplayClass9_.implementation = enumerator3.Current;
												num4 = 4;
												continue;
											case 1:
												goto IL_031b;
											case 3:
											{
												List<ImplementationSignature> implementations = moduleSignature.Implementations;
												ImplementationSignature implementationSignature = new ImplementationSignature();
												bXCWWKGDA0dHMxVXAfOP(implementationSignature, LVr7hrGDH4GYmylyChvi(_003C_003Ec__DisplayClass9_.implementation));
												SgaC93GDxMXPpeXBRO1g(implementationSignature, hbVPjlGD7ooJke6vmSsZ(_003C_003Ec__DisplayClass9_.implementation));
												implementations.Add(implementationSignature);
												num4 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
												{
													num4 = 1;
												}
												continue;
											}
											case 4:
												if (!moduleSignature.Implementations.Any(_003C_003Ec__DisplayClass9_._003CGetSignature_003Eb__9))
												{
													num4 = 3;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
													{
														num4 = 1;
													}
													continue;
												}
												goto IL_031b;
											case 0:
												break;
											}
											break;
										}
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator3).Dispose();
									int num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
									{
										num6 = 0;
									}
									switch (num6)
									{
									case 0:
										break;
									}
								}
								break;
							case 6:
								if (gYwFjdGD6bhaU80umd4y(current.Implementations) != 0)
								{
									num3 = 9;
									continue;
								}
								break;
							case 9:
								enumerator3 = current.Implementations.GetEnumerator();
								num3 = 10;
								continue;
							case 3:
								if (XV0oOGGDtYsGeBkuJwQP(current) != null)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto default;
							case 11:
								break;
							case 2:
								goto IL_04a0;
							case 7:
								enumerator2 = list.GetEnumerator();
								num3 = 8;
								continue;
							default:
								list = ((RootViewItem)gXBwrjGDpFo8USaKmcJK(nxvEoWGDSw3cwObtcueW(current))).FindItems(ignoreHide: true, (Func<ViewItem, bool>)((ViewItem s) => s is ExtensionPointViewItem), (Func<ViewItem, bool>)null).Cast<ExtensionPointViewItem>().ToList();
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
								{
									num3 = 7;
								}
								continue;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num9 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num9 = 0;
					}
					switch (num9)
					{
					case 0:
						break;
					}
				}
				continue;
				end_IL_0012:
				break;
			}
			dataClasses.AddRange(source.Select(selector));
			num = 7;
		}
	}

	public static PropertySignature CreatePropertySignature(this IPropertyMetadata property)
	{
		//Discarded unreachable code: IL_00a2, IL_00b1, IL_00d4, IL_00e3, IL_014b, IL_0178, IL_0187, IL_026d, IL_027c
		int num = 13;
		PropertySignature propertySignature = default(PropertySignature);
		ListOfSimpleTypeSettings listOfSimpleTypeSettings2 = default(ListOfSimpleTypeSettings);
		TypeSignature typeSignature = default(TypeSignature);
		EntitySettings entitySettings = default(EntitySettings);
		TypeSettings typeSettings = default(TypeSettings);
		EntitySettings entitySettings2 = default(EntitySettings);
		DataClassSettings dataClassSettings2 = default(DataClassSettings);
		DataClassSettings dataClassSettings = default(DataClassSettings);
		ListOfSimpleTypeSettings listOfSimpleTypeSettings = default(ListOfSimpleTypeSettings);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 14:
					InFYoSGDdyt7b8E6mmUh(SJpELpGDghJa3l5TthLt(propertySignature), rCODdqGDeVT8t9u3E2Ej(listOfSimpleTypeSettings2));
					num = 16;
					break;
				case 8:
					VNUaJwGDlPIbOgV5A20m(propertySignature, typeSignature);
					num2 = 21;
					continue;
				case 5:
					if ((entitySettings = typeSettings as EntitySettings) != null)
					{
						num = 7;
						break;
					}
					goto case 3;
				case 7:
				case 17:
					entitySettings2 = entitySettings;
					num2 = 6;
					continue;
				case 12:
				{
					TypeSignature typeSignature2 = new TypeSignature();
					YwSoeOGDJpYKjASlk1AX(typeSignature2, LG3MQSGDMmfv5VFIelb6(property));
					InFYoSGDdyt7b8E6mmUh(typeSignature2, v4a6pDGD9D5RokctG295(property));
					typeSignature = typeSignature2;
					num = 11;
					break;
				}
				case 15:
				case 19:
					dataClassSettings2 = dataClassSettings;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
					hQ7cLlGD5ncfUG70KI3F(SJpELpGDghJa3l5TthLt(propertySignature), entitySettings2.RelationType);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 22;
					}
					continue;
				case 9:
					hQ7cLlGD5ncfUG70KI3F(propertySignature.Type, dataClassSettings2.RelationType);
					num2 = 18;
					continue;
				case 21:
					typeSettings = (TypeSettings)GbC3M4GDrYK0qQyrSZA4(property);
					num2 = 2;
					continue;
				case 13:
				{
					PropertySignature propertySignature2 = new PropertySignature();
					MNs7hOGD04JPKojylJyE(propertySignature2, property.Name);
					hnwdaEGDy5F4IpNcrLhS(propertySignature2, P2m1k5GDmv3mRDtEMxZx(property));
					propertySignature = propertySignature2;
					num = 12;
					break;
				}
				case 20:
					if ((listOfSimpleTypeSettings = typeSettings as ListOfSimpleTypeSettings) != null)
					{
						goto case 4;
					}
					num2 = 23;
					continue;
				case 4:
				case 10:
					listOfSimpleTypeSettings2 = listOfSimpleTypeSettings;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					propertySignature.Type.RelationType = RelationType.ManyToMany;
					num2 = 14;
					continue;
				case 16:
				case 18:
				case 22:
				case 23:
					return propertySignature;
				default:
					typeSignature.Nullable = propertyMetadata.Nullable;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 7;
					}
					continue;
				case 3:
					if ((dataClassSettings = typeSettings as DataClassSettings) != null)
					{
						num2 = 19;
						continue;
					}
					goto case 20;
				case 11:
					if ((propertyMetadata = property as PropertyMetadata) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 2:
					if (typeSettings != null)
					{
						num2 = 5;
						continue;
					}
					goto case 16;
				}
				break;
			}
		}
	}

	public static CompatibilityResult Compatible(this TypeSignature old, TypeSignature @new)
	{
		//Discarded unreachable code: IL_0147, IL_0156, IL_0201
		int num = 14;
		List<string> list = default(List<string>);
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					wjSeWhGDjwW3XdW6v5Rx(@new, Di7R8kGDPiSavwra1y3J(0x35C0467B ^ 0x35C05C41));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					list = new List<string>();
					num2 = 11;
					continue;
				case 10:
					text = GetTypeDisplayName(@new);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 3;
					}
					continue;
				case 3:
					list.Add(SR.T((string)Di7R8kGDPiSavwra1y3J(-951514650 ^ -951388898), text2, text));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					if (old.Nullable != lmqtqfGDYwhiIkGeOiD1(@new))
					{
						num2 = 9;
						continue;
					}
					goto case 7;
				case 6:
					list.Add((string)pDb11lGDLTxF9MBoRlTb(Di7R8kGDPiSavwra1y3J(0x2A7797B7 ^ 0x2A746B2B)));
					num2 = 2;
					continue;
				case 14:
					goto end_IL_0012;
				case 7:
					if (HCVslLGDUvOQAGegXWVs(old) != HCVslLGDUvOQAGegXWVs(@new))
					{
						num2 = 6;
						continue;
					}
					goto case 2;
				case 9:
					list.Add((string)pDb11lGDLTxF9MBoRlTb(Di7R8kGDPiSavwra1y3J(-576149596 ^ -575972424)));
					num2 = 7;
					continue;
				case 5:
					if (!Ao7w2FGD4bpdAQYfgOgk(old.SubTypeUid, g12TBxGDcyJVMjY2rMDn(@new)))
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 4;
						}
						continue;
					}
					break;
				case 2:
					if (Ao7w2FGD4bpdAQYfgOgk(jjHeWFGDsaUJdhW9ZLAm(old), jjHeWFGDsaUJdhW9ZLAm(@new)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 5;
				default:
					return new CompatibilityResult(jFwma5GtFx7UjmZyU6fc(list) == 0, list);
				case 4:
				case 12:
					break;
				}
				text2 = (string)Fja1ZLGDz2cE1jjEAgQM(old);
				num2 = 10;
				continue;
				end_IL_0012:
				break;
			}
			wjSeWhGDjwW3XdW6v5Rx(old, Di7R8kGDPiSavwra1y3J(-1822890472 ^ -1822825900));
			num = 13;
		}
		static string GetTypeDisplayName(TypeSignature type)
		{
			//Discarded unreachable code: IL_0062, IL_0082, IL_0190, IL_019f
			string result = default(string);
			switch (1)
			{
			case 1:
				try
				{
					int num3;
					if (!(heae7DGtQMEVtVKRK2PI(WV1emyGtfQFGvdjyu0UP(), jjHeWFGDsaUJdhW9ZLAm(type), g12TBxGDcyJVMjY2rMDn(type)) is IPropertyTypeInfo propertyTypeInfo))
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num3 = 1;
						}
						goto IL_0066;
					}
					string text3 = propertyTypeInfo.GetTypeDisplayName(g12TBxGDcyJVMjY2rMDn(type));
					goto IL_0094;
					IL_0094:
					result = text3;
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num3 = 0;
					}
					goto IL_0066;
					IL_0066:
					switch (num3)
					{
					case 1:
						break;
					default:
						return result;
					case 0:
						return result;
					}
					text3 = string.Empty;
					goto IL_0094;
				}
				catch (Exception)
				{
					int num4 = 2;
					int num5 = num4;
					string text4 = default(string);
					while (true)
					{
						switch (num5)
						{
						case 3:
							Logger.Log.Error(SR.T((string)Di7R8kGDPiSavwra1y3J(-643786247 ^ -643603417), text4));
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
							{
								num5 = 0;
							}
							break;
						case 2:
							text4 = (string)Y4oYZLGtC5DnFFS1AsTF(Di7R8kGDPiSavwra1y3J(0x638095EB ^ 0x63816BBB), jjHeWFGDsaUJdhW9ZLAm(type), g12TBxGDcyJVMjY2rMDn(type));
							num5 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
							{
								num5 = 1;
							}
							break;
						default:
							result = text4;
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
							{
								num5 = 1;
							}
							break;
						case 1:
							return result;
						}
					}
				}
			default:
				return result;
			}
		}
	}

	public static CompatibilityResult Compatible(this DataClassDependency old, DataClassDependency @new)
	{
		//Discarded unreachable code: IL_0044, IL_0053, IL_00b9, IL_00c8, IL_026f, IL_0376, IL_0389, IL_0398
		int num = 3;
		int num2 = num;
		List<string> list = default(List<string>);
		List<PropertySignature>.Enumerator enumerator = default(List<PropertySignature>.Enumerator);
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		CompatibilityResult compatibilityResult = default(CompatibilityResult);
		_003C_003Ec__DisplayClass12_1 _003C_003Ec__DisplayClass12_2 = default(_003C_003Ec__DisplayClass12_1);
		PropertySignature propertySignature = default(PropertySignature);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return new CompatibilityResult(list.Count == 0, list);
			default:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 13;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
							{
								num3 = 13;
							}
							goto IL_0062;
						}
						goto IL_01d6;
						IL_01d6:
						_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num3 = 3;
						}
						goto IL_0062;
						IL_0062:
						while (true)
						{
							int num4;
							switch (num3)
							{
							case 5:
								list.AddRange(((IEnumerable<string>)sPYwuIGtbLTMtwku5D0u(compatibilityResult)).Select(_003C_003Ec__DisplayClass12_2._003CCompatible_003Eb__1));
								num4 = 15;
								goto IL_005e;
							case 6:
							case 15:
								break;
							default:
								if ((string)s2GC3JGtWdkBeZ9bWNPf(propertySignature) != _003C_003Ec__DisplayClass12_2.propertyName)
								{
									num3 = 16;
									continue;
								}
								goto case 8;
							case 3:
								_003C_003Ec__DisplayClass12_.currentProperty = enumerator.Current;
								num4 = 12;
								goto IL_005e;
							case 10:
								_003C_003Ec__DisplayClass12_2.propertyName = _003C_003Ec__DisplayClass12_2.CS_0024_003C_003E8__locals1.currentProperty.Name;
								num3 = 7;
								continue;
							case 11:
								if (!compatibilityResult.IsValid)
								{
									num3 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
									{
										num3 = 5;
									}
									continue;
								}
								break;
							case 8:
								compatibilityResult = (CompatibilityResult)cK6WPjGtoD7Fjvi4lPqg(SJpELpGDghJa3l5TthLt(_003C_003Ec__DisplayClass12_2.CS_0024_003C_003E8__locals1.currentProperty), SJpELpGDghJa3l5TthLt(propertySignature));
								num3 = 11;
								continue;
							case 9:
								goto IL_01d6;
							case 2:
								propertySignature = @new.Properties.Find(_003C_003Ec__DisplayClass12_2._003CCompatible_003Eb__0);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
								{
									num3 = 1;
								}
								continue;
							case 7:
								_003C_003Ec__DisplayClass12_2.basePhrase = SR.T((string)Di7R8kGDPiSavwra1y3J(0x571EA399 ^ 0x571D5ED7), OxBKYqGtBg4EfV7Qxn6k(old), _003C_003Ec__DisplayClass12_2.propertyName);
								num3 = 2;
								continue;
							case 1:
								if (propertySignature != null)
								{
									num3 = 17;
									continue;
								}
								goto case 14;
							case 4:
								_003C_003Ec__DisplayClass12_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass12_;
								num3 = 10;
								continue;
							case 16:
								list.Add(SR.T((string)Di7R8kGDPiSavwra1y3J(-87337865 ^ -87512597), _003C_003Ec__DisplayClass12_2.basePhrase, s2GC3JGtWdkBeZ9bWNPf(propertySignature)));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
								{
									num3 = 8;
								}
								continue;
							case 12:
								_003C_003Ec__DisplayClass12_2 = new _003C_003Ec__DisplayClass12_1();
								num3 = 4;
								continue;
							case 14:
								list.Add(SR.T((string)Di7R8kGDPiSavwra1y3J(0x66F566B6 ^ 0x66F69BCE), _003C_003Ec__DisplayClass12_2.basePhrase));
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
								{
									num3 = 6;
								}
								continue;
							case 13:
								goto end_IL_0101;
								IL_005e:
								num3 = num4;
								continue;
							}
							break;
						}
						continue;
						end_IL_0101:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto case 1;
			case 3:
				list = new List<string>();
				num2 = 2;
				break;
			case 2:
				enumerator = old.Properties.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static CompatibilityResult Compatible(this FunctionDependency old, FunctionDependency @new)
	{
		//Discarded unreachable code: IL_00bb, IL_00ca, IL_01f6, IL_0205
		int num = 6;
		int num2 = num;
		List<string> list = default(List<string>);
		CompatibilityResult compatibilityResult = default(CompatibilityResult);
		CompatibilityResult compatibilityResult2 = default(CompatibilityResult);
		while (true)
		{
			switch (num2)
			{
			case 3:
				list.AddRange((IEnumerable<string>)sPYwuIGtbLTMtwku5D0u(compatibilityResult));
				num2 = 2;
				break;
			case 4:
				compatibilityResult = (CompatibilityResult)cK6WPjGtoD7Fjvi4lPqg(V0V6MSGthRlWnXZVc13o(old), V0V6MSGthRlWnXZVc13o(@new));
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 9;
				}
				break;
			case 2:
			case 7:
				compatibilityResult2 = (CompatibilityResult)cK6WPjGtoD7Fjvi4lPqg(vFYdjwGtEVcDCRAQG6DH(old), vFYdjwGtEVcDCRAQG6DH(@new));
				num2 = 8;
				break;
			case 1:
				list.Add(SR.T((string)Di7R8kGDPiSavwra1y3J(-218496594 ^ -218554088), OxBKYqGtBg4EfV7Qxn6k(@new)));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 3;
				}
				break;
			case 6:
				wjSeWhGDjwW3XdW6v5Rx(old, Di7R8kGDPiSavwra1y3J(-978351861 ^ -978416313));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 2;
				}
				break;
			default:
				list.Add(SR.T((string)Di7R8kGDPiSavwra1y3J(-629844702 ^ -629771142), OxBKYqGtBg4EfV7Qxn6k(@new)));
				num2 = 11;
				break;
			case 11:
				list.AddRange((IEnumerable<string>)sPYwuIGtbLTMtwku5D0u(compatibilityResult2));
				num2 = 12;
				break;
			case 10:
			case 12:
				return new CompatibilityResult(jFwma5GtFx7UjmZyU6fc(list) == 0, list);
			case 8:
				if (xSuHjQGtG8C3G0RahZtv(compatibilityResult2))
				{
					num2 = 10;
					break;
				}
				goto default;
			case 5:
				wjSeWhGDjwW3XdW6v5Rx(@new, Di7R8kGDPiSavwra1y3J(-978351861 ^ -978349263));
				num2 = 13;
				break;
			case 9:
				if (xSuHjQGtG8C3G0RahZtv(compatibilityResult))
				{
					num2 = 7;
					break;
				}
				goto case 1;
			case 13:
				list = new List<string>();
				num2 = 4;
				break;
			}
		}
	}

	internal static bool gH68ZLGazFMjNbcLx5tl()
	{
		return mZOGr5GacO8UGN80jNH1 == null;
	}

	internal static MetadataSignatureExtensions k5LxwVGDF6bqtYwjMZjP()
	{
		return mZOGr5GacO8UGN80jNH1;
	}

	internal static bool OTbBggGDBg4pEtiCOqY8(object P_0)
	{
		return ((EntityMetadata)P_0).Hierarchical;
	}

	internal static HierarchyType qoNgF4GDWxHweRJXPK21(object P_0)
	{
		return ((EntityMetadata)P_0).HierarchyType;
	}

	internal static Guid goaR8uGDosDJHgKtUhmW(object P_0)
	{
		return ((EntityMetadata)P_0).IsGroupPropertyUid;
	}

	internal static Guid lWTrv2GDbelpcmmO23Sn(object P_0)
	{
		return ((EntityMetadata)P_0).ParentPropertyUid;
	}

	internal static Guid n33rXiGDhqNtg7UwT1Xx(object P_0)
	{
		return ((AbstractMetadata)P_0).ModuleUid;
	}

	internal static void i5NXBgGDGC62PGq0aycJ(object P_0, Guid value)
	{
		((Dependency)P_0).ModuleUid = value;
	}

	internal static object aLklGDGDE5yksJrsmWTH(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void fiH35RGDfy4htl4100Iy(object P_0, object P_1)
	{
		((Dependency)P_0).Name = (string)P_1;
	}

	internal static object AHEiIMGDQJYl5XsJ4O6i(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void OwSC01GDCg80Tn5LUePD(object P_0, object P_1)
	{
		((Dependency)P_0).DisplayName = (string)P_1;
	}

	internal static object b9MsMvGDvMGr5rmZ1wdu(object P_0)
	{
		return ((FunctionMetadata)P_0).ParameterType;
	}

	internal static void w1vBeyGD8gf3fWgA9p3c(object P_0, object P_1)
	{
		((FunctionDependency)P_0).ReturnType = (TypeSignature)P_1;
	}

	internal static void bv3uZlGDZHUSPrcgIemk(object P_0, Guid value)
	{
		((Dependency)P_0).HeaderUid = value;
	}

	internal static Guid Nbf3B8GDuaNJ1cFVP5k4(object P_0)
	{
		return ((ViewItem)P_0).Uid;
	}

	internal static Guid nd1NKpGDI6tAWHusdK7h(object P_0)
	{
		return ((ComponentViewItem)P_0).HeaderUid;
	}

	internal static void sR1n50GDVVNg33deU2sk(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object nxvEoWGDSw3cwObtcueW(object P_0)
	{
		return ((ComponentMetadata)P_0).Content;
	}

	internal static object f3hC2rGDit14b1eyeA2f(object P_0)
	{
		return ((ComponentContentMetadata)P_0).Context;
	}

	internal static bool NgkYqhGDRwAcFkoeEJax(object P_0)
	{
		return ((IViewModelPropertyMetadata)P_0).Input;
	}

	internal static bool NJXvrGGDq7d8buuTStVj(object P_0)
	{
		return ((IViewModelPropertyMetadata)P_0).Output;
	}

	internal static Guid adrkkCGDKkuTUhcNr9sU(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static void pAGDy3GDXb9MypLP4gun(object P_0, object P_1)
	{
		((ActionInputComputedValue)P_0).ParameterType = (TypeSignature)P_1;
	}

	internal static object kD6c8fGDTri4VbNa4x0M(object P_0)
	{
		return ((ActionSettings)P_0).ReturnType;
	}

	internal static void yHjA0SGDkyPXc1Fx1L9k(object P_0, Guid value)
	{
		((InputComputedValue)P_0).SubTypeUid = value;
	}

	internal static RelationType YHlvi5GDnxARJHRYDRiG(object P_0)
	{
		return ((EntitySettings)P_0).RelationType;
	}

	internal static void PeDxSwGDOmAnWJEuYAwF(object P_0, RelationType value)
	{
		((InputComputedValue)P_0).RelationType = value;
	}

	internal static RelationType uKFQdmGD21lnHKV8q1GU(object P_0)
	{
		return ((DataClassSettings)P_0).RelationType;
	}

	internal static Guid rCODdqGDeVT8t9u3E2Ej(object P_0)
	{
		return ((ListOfSimpleTypeSettings)P_0).SimpleTypeUid;
	}

	internal static object Di7R8kGDPiSavwra1y3J(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void rhXja4GD1VO5aRPuOsem(object P_0, Guid value)
	{
		((InputComputedValue)P_0).TypeUid = value;
	}

	internal static bool BpEhpWGDNNQ3wCTJrKXl(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static void IWAJ3dGD306iGhDcv0du(object P_0, bool value)
	{
		((InputComputedValue)P_0).Nullable = value;
	}

	internal static object gXBwrjGDpFo8USaKmcJK(object P_0)
	{
		return ((ComponentContentMetadata)P_0).View;
	}

	internal static int EqBK79GDad6enJjPwjXO(object P_0)
	{
		return ((List<PlaceholderViewItem>)P_0).Count;
	}

	internal static bool Ha4rofGDD9B2s2RRrcj6(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object XV0oOGGDtYsGeBkuJwQP(object P_0)
	{
		return ((ComponentMetadata)P_0).CustomTypeImplementation;
	}

	internal static void uU2H3bGDw2EGDcIRRFUd(object P_0, object P_1)
	{
		((ComponentSignature)P_0).CustomType = (CustomTypeImplementationModel)P_1;
	}

	internal static bool Ao7w2FGD4bpdAQYfgOgk(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static int gYwFjdGD6bhaU80umd4y(object P_0)
	{
		return ((List<Implementation>)P_0).Count;
	}

	internal static object LVr7hrGDH4GYmylyChvi(object P_0)
	{
		return ((Implementation)P_0).PointId;
	}

	internal static void bXCWWKGDA0dHMxVXAfOP(object P_0, object P_1)
	{
		((ImplementationSignature)P_0).PointId = (string)P_1;
	}

	internal static Guid hbVPjlGD7ooJke6vmSsZ(object P_0)
	{
		return ((Implementation)P_0).TypeUid;
	}

	internal static void SgaC93GDxMXPpeXBRO1g(object P_0, Guid value)
	{
		((ImplementationSignature)P_0).TypeUid = value;
	}

	internal static void MNs7hOGD04JPKojylJyE(object P_0, object P_1)
	{
		((PropertySignature)P_0).Name = (string)P_1;
	}

	internal static Guid P2m1k5GDmv3mRDtEMxZx(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static void hnwdaEGDy5F4IpNcrLhS(object P_0, Guid value)
	{
		((PropertySignature)P_0).Uid = value;
	}

	internal static Guid LG3MQSGDMmfv5VFIelb6(object P_0)
	{
		return ((IPropertyMetadata)P_0).TypeUid;
	}

	internal static void YwSoeOGDJpYKjASlk1AX(object P_0, Guid value)
	{
		((TypeSignature)P_0).TypeUid = value;
	}

	internal static Guid v4a6pDGD9D5RokctG295(object P_0)
	{
		return ((IPropertyMetadata)P_0).SubTypeUid;
	}

	internal static void InFYoSGDdyt7b8E6mmUh(object P_0, Guid value)
	{
		((TypeSignature)P_0).SubTypeUid = value;
	}

	internal static void VNUaJwGDlPIbOgV5A20m(object P_0, object P_1)
	{
		((PropertySignature)P_0).Type = (TypeSignature)P_1;
	}

	internal static object GbC3M4GDrYK0qQyrSZA4(object P_0)
	{
		return ((IPropertyMetadata)P_0).Settings;
	}

	internal static object SJpELpGDghJa3l5TthLt(object P_0)
	{
		return ((PropertySignature)P_0).Type;
	}

	internal static void hQ7cLlGD5ncfUG70KI3F(object P_0, RelationType value)
	{
		((TypeSignature)P_0).RelationType = value;
	}

	internal static void wjSeWhGDjwW3XdW6v5Rx(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static bool lmqtqfGDYwhiIkGeOiD1(object P_0)
	{
		return ((TypeSignature)P_0).Nullable;
	}

	internal static object pDb11lGDLTxF9MBoRlTb(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static RelationType HCVslLGDUvOQAGegXWVs(object P_0)
	{
		return ((TypeSignature)P_0).RelationType;
	}

	internal static Guid jjHeWFGDsaUJdhW9ZLAm(object P_0)
	{
		return ((TypeSignature)P_0).TypeUid;
	}

	internal static Guid g12TBxGDcyJVMjY2rMDn(object P_0)
	{
		return ((TypeSignature)P_0).SubTypeUid;
	}

	internal static object Fja1ZLGDz2cE1jjEAgQM(object P_0)
	{
		return GetTypeDisplayName((TypeSignature)P_0);
		static string GetTypeDisplayName(TypeSignature type)
		{
			//Discarded unreachable code: IL_0062, IL_0082, IL_0190, IL_019f
			string result = default(string);
			switch (1)
			{
			case 1:
				try
				{
					int num;
					if (!(heae7DGtQMEVtVKRK2PI(WV1emyGtfQFGvdjyu0UP(), jjHeWFGDsaUJdhW9ZLAm(type), g12TBxGDcyJVMjY2rMDn(type)) is IPropertyTypeInfo propertyTypeInfo))
					{
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num = 1;
						}
						goto IL_0066;
					}
					string text = propertyTypeInfo.GetTypeDisplayName(g12TBxGDcyJVMjY2rMDn(type));
					goto IL_0094;
					IL_0094:
					result = text;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num = 0;
					}
					goto IL_0066;
					IL_0066:
					switch (num)
					{
					case 1:
						break;
					default:
						return result;
					case 0:
						return result;
					}
					text = string.Empty;
					goto IL_0094;
				}
				catch (Exception)
				{
					int num2 = 2;
					int num3 = num2;
					string text2 = default(string);
					while (true)
					{
						switch (num3)
						{
						case 3:
							Logger.Log.Error(SR.T((string)Di7R8kGDPiSavwra1y3J(-643786247 ^ -643603417), text2));
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
							{
								num3 = 0;
							}
							break;
						case 2:
							text2 = (string)Y4oYZLGtC5DnFFS1AsTF(Di7R8kGDPiSavwra1y3J(0x638095EB ^ 0x63816BBB), jjHeWFGDsaUJdhW9ZLAm(type), g12TBxGDcyJVMjY2rMDn(type));
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
							{
								num3 = 1;
							}
							break;
						default:
							result = text2;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
							{
								num3 = 1;
							}
							break;
						case 1:
							return result;
						}
					}
				}
			default:
				return result;
			}
		}
	}

	internal static int jFwma5GtFx7UjmZyU6fc(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static object OxBKYqGtBg4EfV7Qxn6k(object P_0)
	{
		return ((Dependency)P_0).DisplayName;
	}

	internal static object s2GC3JGtWdkBeZ9bWNPf(object P_0)
	{
		return ((PropertySignature)P_0).Name;
	}

	internal static object cK6WPjGtoD7Fjvi4lPqg(object P_0, object P_1)
	{
		return ((TypeSignature)P_0).Compatible((TypeSignature)P_1);
	}

	internal static object sPYwuIGtbLTMtwku5D0u(object P_0)
	{
		return ((CompatibilityResult)P_0).Errors;
	}

	internal static object V0V6MSGthRlWnXZVc13o(object P_0)
	{
		return ((FunctionDependency)P_0).ParameterType;
	}

	internal static bool xSuHjQGtG8C3G0RahZtv(object P_0)
	{
		return ((CompatibilityResult)P_0).IsValid;
	}

	internal static object vFYdjwGtEVcDCRAQG6DH(object P_0)
	{
		return ((FunctionDependency)P_0).ReturnType;
	}

	internal static object WV1emyGtfQFGvdjyu0UP()
	{
		return MetadataServiceContext.Service;
	}

	internal static object heae7DGtQMEVtVKRK2PI(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static object Y4oYZLGtC5DnFFS1AsTF(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
