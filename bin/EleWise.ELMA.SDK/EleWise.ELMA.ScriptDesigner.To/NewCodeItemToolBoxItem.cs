using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.ScriptDesigner.CodeItems;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems;

[Serializable]
[Component]
public abstract class NewCodeItemToolBoxItem : INewCodeItemToolBoxItem, ICodeItemPoint, IXsiType
{
	private ITypeDescriptor _typeDescriptor;

	private static NewCodeItemToolBoxItem qLeascVuUFWVLdvIHyE;

	public abstract string Name { get; set; }

	public abstract Guid GroupUid { get; }

	public virtual Image Image => null;

	[XmlIgnore]
	public abstract Type CodeItemType { get; set; }

	public string CodeItemTypeName
	{
		get
		{
			//Discarded unreachable code: IL_003b, IL_004a
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return null;
				default:
					return KJj5YAVSpgDyyAQNEpD(this).AssemblyQualifiedName;
				case 1:
					if (ACtUTcVi0UsSJN3GGOq(KJj5YAVSpgDyyAQNEpD(this), null))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}
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
					CodeItemType = ((value != null) ? FkhTSDVRcIY8ClfHqJQ(value) : null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<string> DisplayNames { get; set; }

	public List<string> PropertyNames { get; set; }

	[XmlIgnore]
	public IMetadata PropertyMetadata
	{
		[CompilerGenerated]
		get
		{
			return _003CPropertyMetadata_003Ek__BackingField;
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
					_003CPropertyMetadata_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Path
	{
		[CompilerGenerated]
		get
		{
			return _003CPath_003Ek__BackingField;
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
					_003CPath_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
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

	public Guid TypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeUid_003Ek__BackingField;
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
					_003CTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid SubTypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CSubTypeUid_003Ek__BackingField;
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
					_003CSubTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
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

	[XmlIgnore]
	public ITypeDescriptor TypeDescriptor
	{
		get
		{
			int num = 2;
			int num2 = num;
			ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
			ITypeDescriptor typeDescriptor2;
			while (true)
			{
				switch (num2)
				{
				case 1:
					typeDescriptor = (_typeDescriptor = (ITypeDescriptor)uYAuxRVKa3dNPTrlBQQ(O7TA90VqqOW0WuRJ0YY(), TypeUid, SubTypeUid));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					typeDescriptor2 = _typeDescriptor;
					if (typeDescriptor2 != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					typeDescriptor2 = typeDescriptor;
					break;
				}
				break;
			}
			return typeDescriptor2;
		}
	}

	public virtual string DisplayName
	{
		get
		{
			//Discarded unreachable code: IL_004a, IL_0059
			int num = 1;
			int num2 = num;
			List<string> displayNames = default(List<string>);
			while (true)
			{
				switch (num2)
				{
				case 2:
					DisplayNames = new List<string>();
					num2 = 3;
					break;
				default:
					displayNames = DisplayNames;
					num2 = 4;
					break;
				case 4:
					return string.Join((string)e1T69bVX6kDMFZZeBjl(-488881205 ^ -488875761), displayNames);
				case 1:
					if (DisplayNames != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}
		set
		{
		}
	}

	public virtual string VariableName
	{
		get
		{
			//Discarded unreachable code: IL_004f, IL_005e, IL_0069, IL_0124, IL_0137
			int num = 2;
			int num2 = num;
			List<string>.Enumerator enumerator = default(List<string>.Enumerator);
			string current = default(string);
			List<string> list = default(List<string>);
			while (true)
			{
				switch (num2)
				{
				case 1:
					PropertyNames = new List<string>();
					num2 = 4;
					break;
				default:
					try
					{
						while (true)
						{
							IL_00d2:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
								{
									num3 = 2;
								}
								goto IL_006d;
							}
							goto IL_0087;
							IL_0087:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
							{
								num3 = 0;
							}
							goto IL_006d;
							IL_006d:
							while (true)
							{
								switch (num3)
								{
								case 3:
									break;
								default:
									list.Add(current.ToTranslit());
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
									{
										num3 = 0;
									}
									continue;
								case 1:
									goto IL_00d2;
								case 2:
									goto end_IL_00d2;
								}
								break;
							}
							goto IL_0087;
							continue;
							end_IL_00d2:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 3;
				case 3:
					return string.Join((string)e1T69bVX6kDMFZZeBjl(0x3CE17B75 ^ 0x3CE161B1), list);
				case 2:
					if (PropertyNames == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 4;
				case 4:
					list = new List<string>();
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					enumerator = PropertyNames.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
		set
		{
		}
	}

	public string VariableTypeName
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return null;
				case 1:
					return VariableType.AssemblyQualifiedName;
				case 2:
					if (VariableType != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
			}
		}
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
					VariableType = ((value != null) ? hHQERNVnGvo8TnDm6QN(value) : null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public Type VariableType
	{
		[CompilerGenerated]
		get
		{
			return _003CVariableType_003Ek__BackingField;
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
					_003CVariableType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
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

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return _003CDescription_003Ek__BackingField;
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
					_003CDescription_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsLocal
	{
		[CompilerGenerated]
		get
		{
			return _003CIsLocal_003Ek__BackingField;
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
					_003CIsLocal_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
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

	public Guid IterationUid
	{
		[CompilerGenerated]
		get
		{
			return _003CIterationUid_003Ek__BackingField;
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
					_003CIterationUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid Uid
	{
		[CompilerGenerated]
		get
		{
			return _003CUid_003Ek__BackingField;
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
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public abstract ICodeItem CreateCodeItem();

	public void Rename(string newName)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				PropertyNames.Insert(0, (string)cbc4dlVk1psvaGVcl1L(newName));
				num2 = 4;
				break;
			default:
				oUNQroVTlDyWsOOQhG7(PropertyNames, 0);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				DisplayNames.Insert(0, newName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return;
			case 3:
				DisplayNames.RemoveAt(0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public abstract bool IsAvailable(IMetadata metadata);

	protected NewCodeItemToolBoxItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type KJj5YAVSpgDyyAQNEpD(object P_0)
	{
		return ((NewCodeItemToolBoxItem)P_0).CodeItemType;
	}

	internal static bool ACtUTcVi0UsSJN3GGOq(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool FOpgB0VIQ86S3Q4v9JQ()
	{
		return qLeascVuUFWVLdvIHyE == null;
	}

	internal static NewCodeItemToolBoxItem HJAefeVVOXkXSN5vjT1()
	{
		return qLeascVuUFWVLdvIHyE;
	}

	internal static Type FkhTSDVRcIY8ClfHqJQ(object P_0)
	{
		return Type.GetType((string)P_0);
	}

	internal static object O7TA90VqqOW0WuRJ0YY()
	{
		return MetadataServiceContext.Service;
	}

	internal static object uYAuxRVKa3dNPTrlBQQ(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static object e1T69bVX6kDMFZZeBjl(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void oUNQroVTlDyWsOOQhG7(object P_0, int P_1)
	{
		((List<string>)P_0).RemoveAt(P_1);
	}

	internal static object cbc4dlVk1psvaGVcl1L(object P_0)
	{
		return ((string)P_0).ToTranslit();
	}

	internal static Type hHQERNVnGvo8TnDm6QN(object P_0)
	{
		return ReflectionType.GetType((string)P_0);
	}
}
[Serializable]
public abstract class NewCodeItemToolBoxItem<TCodeItem> : NewCodeItemToolBoxItem where TCodeItem : ICodeItem
{
	internal static object QcWRfWVOlteuRgmkLGB;

	public override string Name
	{
		get
		{
			//Discarded unreachable code: IL_003a, IL_0067
			int num = 5;
			int num2 = num;
			ViewItemInfoService viewItemInfoService = default(ViewItemInfoService);
			ViewItemTypeInfo viewItemTypeInfo = default(ViewItemTypeInfo);
			while (true)
			{
				object obj2;
				object obj;
				switch (num2)
				{
				case 2:
					obj2 = null;
					break;
				case 5:
					if (!Locator.Initialized)
					{
						num2 = 4;
						continue;
					}
					obj = Locator.GetService<ViewItemInfoService>();
					goto IL_00b3;
				default:
					return string.Empty;
				case 4:
					obj = null;
					goto IL_00b3;
				case 1:
					if (viewItemInfoService == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					obj2 = viewItemInfoService.GetInfo(typeof(TCodeItem));
					break;
				case 3:
					{
						if (viewItemTypeInfo != null)
						{
							return viewItemTypeInfo.Name;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num2 = 0;
						}
						continue;
					}
					IL_00b3:
					viewItemInfoService = (ViewItemInfoService)obj;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
					continue;
				}
				viewItemTypeInfo = (ViewItemTypeInfo)obj2;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 3;
				}
			}
		}
		set
		{
		}
	}

	[XmlIgnore]
	public override Type CodeItemType
	{
		get
		{
			return typeof(TCodeItem);
		}
		set
		{
		}
	}

	public override ICodeItem CreateCodeItem()
	{
		int num = 2;
		int num2 = num;
		TCodeItem val = default(TCodeItem);
		while (true)
		{
			switch (num2)
			{
			case 2:
				val = Activator.CreateInstance<TCodeItem>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				val.InitNew(null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return val;
			}
		}
	}

	public override bool IsAvailable(IMetadata metadata)
	{
		return ViewItemMetadataAttribute.IsAvailable<TCodeItem>(metadata);
	}

	protected NewCodeItemToolBoxItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool p7fcgAV2M31vqc8Z9gj()
	{
		return QcWRfWVOlteuRgmkLGB == null;
	}

	internal static object ds6rM1Ve08EdHZJEWb4()
	{
		return QcWRfWVOlteuRgmkLGB;
	}
}
