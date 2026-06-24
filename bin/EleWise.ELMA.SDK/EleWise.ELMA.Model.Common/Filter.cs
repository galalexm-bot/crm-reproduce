using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Common;

public class Filter : IEntityFilter
{
	private QueryParameters queryParameters;

	private static Filter Xev1eehTmpXcaC7oJODq;

	[View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
	[View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
	public string SearchString
	{
		[CompilerGenerated]
		get
		{
			return _003CSearchString_003Ek__BackingField;
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
				case 1:
					_003CSearchString_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
	[View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
	public Type Subtype
	{
		[CompilerGenerated]
		get
		{
			return _003CSubtype_003Ek__BackingField;
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
					_003CSubtype_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
	[View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
	public Guid? PermissionId { get; set; }

	[View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
	[View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
	public IUser PermissionUser
	{
		[CompilerGenerated]
		get
		{
			return _003CPermissionUser_003Ek__BackingField;
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
				case 1:
					_003CPermissionUser_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
	[View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
	public bool DisableSecurity
	{
		[CompilerGenerated]
		get
		{
			return _003CDisableSecurity_003Ek__BackingField;
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
				case 1:
					_003CDisableSecurity_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
	[View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
	public bool DisableSoftDeletable
	{
		[CompilerGenerated]
		get
		{
			return _003CDisableSoftDeletable_003Ek__BackingField;
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
				case 1:
					_003CDisableSoftDeletable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
	[View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
	public bool SkipAdminPermission
	{
		[CompilerGenerated]
		get
		{
			return _003CSkipAdminPermission_003Ek__BackingField;
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
				case 1:
					_003CSkipAdminPermission_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
	[View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
	public object Id
	{
		[CompilerGenerated]
		get
		{
			return _003CId_003Ek__BackingField;
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
				case 1:
					_003CId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
	[View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
	public object HierarchyParent
	{
		[CompilerGenerated]
		get
		{
			return _003CHierarchyParent_003Ek__BackingField;
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
					_003CHierarchyParent_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
	[View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
	public bool FilterByHierarchyParent
	{
		[CompilerGenerated]
		get
		{
			return _003CFilterByHierarchyParent_003Ek__BackingField;
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
					_003CFilterByHierarchyParent_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
	[View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
	public bool DisableAutoFilter
	{
		[CompilerGenerated]
		get
		{
			return _003CDisableAutoFilter_003Ek__BackingField;
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
					_003CDisableAutoFilter_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
	[View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
	public bool ShowOnlyGroups
	{
		[CompilerGenerated]
		get
		{
			return _003CShowOnlyGroups_003Ek__BackingField;
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
				case 1:
					_003CShowOnlyGroups_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
	[View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
	[DisplayName(typeof(__Resources_Filter), "P_FullTextInAttachments_DisplayName")]
	public bool FullTextInAttachments
	{
		[CompilerGenerated]
		get
		{
			return _003CFullTextInAttachments_003Ek__BackingField;
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
				case 1:
					_003CFullTextInAttachments_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
	[View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
	public string Query
	{
		[CompilerGenerated]
		get
		{
			return _003CQuery_003Ek__BackingField;
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
					_003CQuery_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
	[View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
	public QueryParameters QueryParameters => queryParameters;

	public virtual bool IsEmpty()
	{
		//Discarded unreachable code: IL_0095, IL_0159, IL_0168, IL_0266, IL_02dc, IL_0312, IL_0325, IL_0334, IL_0372, IL_0381
		int num = 4;
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		_003C_003Ec__DisplayClass58_1 _003C_003Ec__DisplayClass58_2 = default(_003C_003Ec__DisplayClass58_1);
		_003C_003Ec__DisplayClass58_0 _003C_003Ec__DisplayClass58_ = default(_003C_003Ec__DisplayClass58_0);
		object obj = default(object);
		PropertyInfo reflectionProperty = default(PropertyInfo);
		List<ISkipFilterEmptyProperty> source = default(List<ISkipFilterEmptyProperty>);
		PropertyMetadata current = default(PropertyMetadata);
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		bool result = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return false;
				case 2:
					break;
				case 5:
					try
					{
						while (true)
						{
							IL_0115:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 10;
								goto IL_009f;
							}
							goto IL_01dd;
							IL_00a3:
							int num4;
							while (true)
							{
								switch (num4)
								{
								case 9:
									break;
								case 14:
									_003C_003Ec__DisplayClass58_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass58_;
									num4 = 7;
									continue;
								default:
									goto IL_0115;
								case 16:
									obj = dQoSAWhT5XBl9QtCA6i4(reflectionProperty, this, null);
									num4 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
									{
										num4 = 12;
									}
									continue;
								case 6:
									if (source.FirstOrDefault(_003C_003Ec__DisplayClass58_2._003CIsEmpty_003Eb__0) == null)
									{
										num4 = 5;
										continue;
									}
									goto IL_0115;
								case 7:
									_003C_003Ec__DisplayClass58_2.pm = current;
									num4 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
									{
										num4 = 5;
									}
									continue;
								case 3:
									_003C_003Ec__DisplayClass58_2 = new _003C_003Ec__DisplayClass58_1();
									num4 = 11;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
									{
										num4 = 14;
									}
									continue;
								case 13:
									goto IL_01dd;
								case 5:
									typeDescriptor = (ITypeDescriptor)HEP29ZhTrV2Tm6aqyImp(HMo5PkhTdyZkP1ocTPMs(), DY8DUxhTl2mHUP2SApmu(_003C_003Ec__DisplayClass58_2.pm), _003C_003Ec__DisplayClass58_2.pm.SubTypeUid);
									num4 = 4;
									continue;
								case 2:
									reflectionProperty = GetType().GetReflectionProperty((string)DfLrxVhTgG3wQpWpmFpB(_003C_003Ec__DisplayClass58_2.pm));
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									if (!(reflectionProperty == null))
									{
										num4 = 16;
										continue;
									}
									goto IL_0115;
								case 12:
									if (yZWg8fhTjptg6FSAN674(typeDescriptor, _003C_003Ec__DisplayClass58_2.pm, obj))
									{
										num4 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
										{
											num4 = 11;
										}
										continue;
									}
									break;
								case 4:
									if (typeDescriptor == null)
									{
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
										{
											num4 = 0;
										}
										continue;
									}
									goto case 2;
								case 10:
									return result;
								case 15:
									return result;
								}
								break;
							}
							result = false;
							num3 = 15;
							goto IL_009f;
							IL_01dd:
							current = enumerator.Current;
							num4 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
							{
								num4 = 0;
							}
							goto IL_00a3;
							IL_009f:
							num4 = num3;
							goto IL_00a3;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
				case 4:
					_003C_003Ec__DisplayClass58_ = new _003C_003Ec__DisplayClass58_0();
					num2 = 3;
					continue;
				case 3:
					if (string.IsNullOrWhiteSpace(Query))
					{
						num2 = 2;
						continue;
					}
					goto default;
				case 1:
					return result;
				}
				break;
			}
			List<PropertyMetadata> list = new List<PropertyMetadata>();
			_003C_003Ec__DisplayClass58_.metadata = (ClassMetadata)MetadataLoader.LoadMetadata(JVCSaHhTJD0d4fljedYb(this));
			list.AddRange(_003C_003Ec__DisplayClass58_.metadata.Properties);
			source = ((ComponentManager)cKMUnfhT9Ji1cqYk2Ae5()).GetExtensionPoints<ISkipFilterEmptyProperty>().ToList();
			result = true;
			enumerator = list.GetEnumerator();
			num = 5;
		}
	}

	public Filter()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		queryParameters = new QueryParameters();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool CZt1k5hTyuB735hoyaPd()
	{
		return Xev1eehTmpXcaC7oJODq == null;
	}

	internal static Filter YIBI8XhTMr1GxZZFYvYI()
	{
		return Xev1eehTmpXcaC7oJODq;
	}

	internal static Type JVCSaHhTJD0d4fljedYb(object P_0)
	{
		return P_0.GetType();
	}

	internal static object cKMUnfhT9Ji1cqYk2Ae5()
	{
		return ComponentManager.Current;
	}

	internal static object HMo5PkhTdyZkP1ocTPMs()
	{
		return MetadataServiceContext.Service;
	}

	internal static Guid DY8DUxhTl2mHUP2SApmu(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static object HEP29ZhTrV2Tm6aqyImp(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static object DfLrxVhTgG3wQpWpmFpB(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object dQoSAWhT5XBl9QtCA6i4(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static bool yZWg8fhTjptg6FSAN674(object P_0, object P_1, object P_2)
	{
		return ((ITypeDescriptor)P_0).IsEmptyOrDefault((PropertyMetadata)P_1, P_2);
	}
}
