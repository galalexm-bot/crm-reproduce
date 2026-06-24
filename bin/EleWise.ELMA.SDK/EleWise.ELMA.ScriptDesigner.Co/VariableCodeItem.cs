using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.ScriptDesigner.Services;
using EleWise.ELMA.ScriptDesigner.ToolBoxItems;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ScriptDesigner.CodeItems;

[Serializable]
[DisplayName(typeof(ResourcesVariableCodeItem), "DisplayName")]
public class VariableCodeItem : CodeItem
{
	private List<string> propertyNames;

	private List<string> displayNames;

	private static VariableCodeItem kYj5ZSq7qbMbUfoLLdm;

	public List<string> DisplayNames
	{
		get
		{
			if (VariableCodeItemPoint != null)
			{
				string item = VariableCodeItemPoint.DisplayNames[0];
				List<string> list = displayNames;
				if (list.Count > 0)
				{
					list.RemoveAt(0);
					list.Insert(0, item);
				}
				return list;
			}
			return displayNames;
		}
		set
		{
			displayNames = value;
		}
	}

	public List<byte[]> BackItems { get; set; }

	public byte[] CurrentItem
	{
		[CompilerGenerated]
		get
		{
			return _003CCurrentItem_003Ek__BackingField;
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
					_003CCurrentItem_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<string> PropertyNames
	{
		get
		{
			if (VariableCodeItemPoint != null)
			{
				string item = VariableCodeItemPoint.DisplayNames[0];
				List<string> list = propertyNames;
				if (list.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C0026D)))
				{
					list.RemoveAt(1);
					list.Insert(1, item);
				}
				else
				{
					if (list.Count > 0)
					{
						list.RemoveAt(0);
					}
					list.Insert(0, item);
				}
				return list;
			}
			return propertyNames;
		}
		set
		{
			propertyNames = value;
		}
	}

	public Guid SourceCodeItemUid
	{
		[CompilerGenerated]
		get
		{
			return _003CSourceCodeItemUid_003Ek__BackingField;
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
					_003CSourceCodeItemUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
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
	public VariableCodeItemToolBoxItem VariableCodeItemPoint
	{
		get
		{
			//Discarded unreachable code: IL_0031, IL_0040
			int num = 2;
			int num2 = num;
			ICodeItemStoreService service = default(ICodeItemStoreService);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (service == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 3:
					return (VariableCodeItemToolBoxItem)cYi2SGqMyqpQBoTMx6M(service, SourceCodeItemUid);
				default:
					return null;
				case 2:
					service = Locator.GetService<ICodeItemStoreService>();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	public string VariableName
	{
		get
		{
			//Discarded unreachable code: IL_006a, IL_0074, IL_012f, IL_0142, IL_0151
			int num = 1;
			int num2 = num;
			List<string>.Enumerator enumerator = default(List<string>.Enumerator);
			List<string> list = default(List<string>);
			string current = default(string);
			while (true)
			{
				switch (num2)
				{
				default:
					enumerator = PropertyNames.GetEnumerator();
					num2 = 3;
					continue;
				case 1:
					list = new List<string>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					try
					{
						while (true)
						{
							IL_00dd:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
								{
									num3 = 1;
								}
								goto IL_0078;
							}
							goto IL_0092;
							IL_0092:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
							{
								num3 = 0;
							}
							goto IL_0078;
							IL_0078:
							while (true)
							{
								switch (num3)
								{
								case 2:
									break;
								default:
									list.Add((string)sQhbCpqJ5F3BO6f2Ldd(current));
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
									{
										num3 = 3;
									}
									continue;
								case 3:
									goto IL_00dd;
								case 1:
									goto end_IL_00dd;
								}
								break;
							}
							goto IL_0092;
							continue;
							end_IL_00dd:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					break;
				case 2:
					break;
				}
				break;
			}
			return string.Join((string)zEMxkZq9lZ5NpTby3uO(0x2A7797B7 ^ 0x2A778D73), list);
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
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

	public bool IsLocalFor
	{
		[CompilerGenerated]
		get
		{
			return _003CIsLocalFor_003Ek__BackingField;
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
					_003CIsLocalFor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string DisplayName
	{
		get
		{
			int num = 1;
			int num2 = num;
			List<string> values = default(List<string>);
			while (true)
			{
				switch (num2)
				{
				default:
					return string.Join((string)zEMxkZq9lZ5NpTby3uO(0x8317432 ^ 0x8316EF6), values);
				case 1:
					values = DisplayNames;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public IterationCodeItem OwnerForeachCodeItem
	{
		[CompilerGenerated]
		get
		{
			return _003COwnerForeachCodeItem_003Ek__BackingField;
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
					_003COwnerForeachCodeItem_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid MetadataUid
	{
		get
		{
			//Discarded unreachable code: IL_0064, IL_0073
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (Metadata != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				default:
					return Guid.Empty;
				case 1:
					return LEw15AqdkLthsMnTkWN(Metadata);
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
					Metadata = MetadataServiceContext.Service.GetMetadata(value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public IMetadata Metadata
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadata_003Ek__BackingField;
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
					_003CMetadata_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
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

	public string VariableTypeName
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return null;
				default:
					return VariableType.AssemblyQualifiedName;
				case 1:
					if (VariableType != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
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
					VariableType = (l0ryyLqls1YsdkCcf5f(value) ? null : jFBa3uqrDx0UwcsNjjw(value));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public VariableCodeItem()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		xJk37Aqm2lcyoyWvuRe();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				DisplayNames = new List<string>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num = 1;
				}
				break;
			case 2:
				BackItems = new List<byte[]>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				PropertyNames = new List<string>();
				num = 2;
				break;
			}
		}
	}

	public void Rename(string name)
	{
		//Discarded unreachable code: IL_0035
		int num = 2;
		int num2 = num;
		VariableCodeItemToolBoxItem variableCodeItemPoint = default(VariableCodeItemToolBoxItem);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				return;
			case 2:
				variableCodeItemPoint = VariableCodeItemPoint;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				Gnv3EVqywBycZcqiHmI(variableCodeItemPoint, name);
				num2 = 3;
				break;
			case 1:
				if (variableCodeItemPoint == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	public override bool IsValidParent(ICodeItem compositeCodeItem)
	{
		//Discarded unreachable code: IL_00e1, IL_0158, IL_0192, IL_01a1
		int num = 6;
		IterationCodeItem iterationCodeItem = default(IterationCodeItem);
		CompositeCodeItem item = default(CompositeCodeItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (LN6SFaqgThMGwKaniDI(iterationCodeItem).Equals(this))
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 7:
				case 12:
					return true;
				case 2:
				case 9:
				case 11:
					if (!IsInnerItem(OwnerForeachCodeItem, item))
					{
						return false;
					}
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 7;
					}
					break;
				case 13:
					iterationCodeItem = compositeCodeItem as IterationCodeItem;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 0;
					}
					break;
				case 10:
					return compositeCodeItem is MathCodeItem;
				case 1:
					return true;
				default:
					if (iterationCodeItem == null)
					{
						num2 = 2;
						break;
					}
					goto case 8;
				case 3:
					if (compositeCodeItem is ConditionCodeItem)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 10;
				case 5:
					item = compositeCodeItem as CompositeCodeItem;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 13;
					}
					break;
				case 8:
					if (iterationCodeItem.LocalVariableCodeItem == null)
					{
						num2 = 9;
						break;
					}
					goto case 4;
				case 6:
					if (!IsLocalFor)
					{
						if (!(compositeCodeItem is AssignCodeItem))
						{
							num2 = 3;
							break;
						}
						goto case 1;
					}
					num2 = 5;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 12;
		}
	}

	public bool IsInnerItem(CompositeCodeItem codeItem, CodeItem item)
	{
		//Discarded unreachable code: IL_002e, IL_003d, IL_0048, IL_00b1, IL_00c0, IL_0136, IL_0196, IL_01cc, IL_01df, IL_01ee
		int num = 2;
		int num2 = num;
		List<CodeItem>.Enumerator enumerator = default(List<CodeItem>.Enumerator);
		CodeItem current = default(CodeItem);
		CompositeCodeItem compositeCodeItem = default(CompositeCodeItem);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
							{
								num3 = 1;
							}
							goto IL_004c;
						}
						goto IL_017e;
						IL_017e:
						current = enumerator.Current;
						num3 = 5;
						goto IL_004c;
						IL_004c:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							case 9:
								if (compositeCodeItem != null)
								{
									num3 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
									{
										num3 = 7;
									}
									continue;
								}
								goto case 6;
							default:
								compositeCodeItem = current as CompositeCodeItem;
								num3 = 9;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
								{
									num3 = 6;
								}
								continue;
							case 11:
								result = true;
								num3 = 8;
								continue;
							case 7:
								result = IsInnerItem(compositeCodeItem, item);
								num3 = 2;
								continue;
							case 5:
								if (PM6lQqq5GFU2Bexq0tH(current.Uid, item.Uid))
								{
									num3 = 10;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
									{
										num3 = 11;
									}
									continue;
								}
								goto default;
							case 6:
								result = false;
								num3 = 10;
								continue;
							case 4:
								goto IL_017e;
							case 1:
								goto end_IL_0086;
							case 2:
								return result;
							case 8:
								return result;
							case 10:
								return result;
							}
							break;
						}
						continue;
						end_IL_0086:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto default;
			default:
				return false;
			case 2:
				enumerator = codeItem.Items.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override CodeStatement ToCodeStatement()
	{
		int num = 1;
		int num2 = num;
		CodeExpression codeExpression = default(CodeExpression);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return new CodeExpressionStatement(codeExpression);
			case 1:
				codeExpression = (CodeExpression)SpBJvDqjObMIBqENDXI(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (codeExpression != null)
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				continue;
			}
			return null;
		}
	}

	public override CodeExpression ToCodeExpression()
	{
		return new CodeVariableReferenceExpression(VariableName);
	}

	public override CodeStatement[] ToCodeStatementList()
	{
		return null;
	}

	public override List<Type> GetValidToInsert()
	{
		throw new NotImplementedException();
	}

	internal static void xJk37Aqm2lcyoyWvuRe()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool U3WgZeqxohXp3lHt53k()
	{
		return kYj5ZSq7qbMbUfoLLdm == null;
	}

	internal static VariableCodeItem eFSlEYq0UDMQF5WkqPq()
	{
		return kYj5ZSq7qbMbUfoLLdm;
	}

	internal static void Gnv3EVqywBycZcqiHmI(object P_0, object P_1)
	{
		((NewCodeItemToolBoxItem)P_0).Rename((string)P_1);
	}

	internal static object cYi2SGqMyqpQBoTMx6M(object P_0, Guid variableUid)
	{
		return ((ICodeItemStoreService)P_0).LoadLocalVariableByUid(variableUid);
	}

	internal static object sQhbCpqJ5F3BO6f2Ldd(object P_0)
	{
		return ((string)P_0).ToTranslit();
	}

	internal static object zEMxkZq9lZ5NpTby3uO(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Guid LEw15AqdkLthsMnTkWN(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static bool l0ryyLqls1YsdkCcf5f(object P_0)
	{
		return ((string)P_0).IsNullOrEmpty();
	}

	internal static Type jFBa3uqrDx0UwcsNjjw(object P_0)
	{
		return ReflectionType.GetType((string)P_0);
	}

	internal static object LN6SFaqgThMGwKaniDI(object P_0)
	{
		return ((IterationCodeItem)P_0).LocalVariableCodeItem;
	}

	internal static bool PM6lQqq5GFU2Bexq0tH(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object SpBJvDqjObMIBqENDXI(object P_0)
	{
		return ((CodeItem)P_0).ToCodeExpression();
	}
}
