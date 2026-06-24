using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Common;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
public class DropDownListSettings : SimpleTypeSettings, IHasDefaultValue<DropDownItem>
{
	internal static DropDownListSettings T052CXozGYdB0PghEj4F;

	[DefaultValue("")]
	[CopyAction(CopyAction.Ignore)]
	[JsonSerializationIgnore]
	[XmlElement("Items")]
	public string ItemsString
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return string.Empty;
				case 1:
					if (Items != null)
					{
						return Items.ToString();
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					Items = new DropDownItemList();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					if (Items == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 3:
					break;
				case 0:
					return;
				}
				arEGLKozCjn9DE4qBWvI(Items, value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[XmlIgnore]
	public DropDownItemList Items
	{
		[CompilerGenerated]
		get
		{
			return _003CItems_003Ek__BackingField;
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
					_003CItems_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Если True, то разрешен только выбор из списка. Иначе можно вводить любое текстовое значение')")]
	[DefaultValue(false)]
	[XmlElement("SelectOnly")]
	public bool SelectOnly
	{
		[CompilerGenerated]
		get
		{
			return _003CSelectOnly_003Ek__BackingField;
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
					_003CSelectOnly_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
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

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Отображать в виде дерева')")]
	[DefaultValue(false)]
	[XmlElement("ShowTree")]
	public bool ShowTree
	{
		[CompilerGenerated]
		get
		{
			return _003CShowTree_003Ek__BackingField;
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
					_003CShowTree_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Можно ли выбирать родительские узлы')")]
	[XmlElement("SelectableParentNode")]
	[DefaultValue(false)]
	public bool SelectableParentNode
	{
		[CompilerGenerated]
		get
		{
			return _003CSelectableParentNode_003Ek__BackingField;
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
					_003CSelectableParentNode_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
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
	public DropDownItem DefaultValue
	{
		[CompilerGenerated]
		get
		{
			return _003CDefaultValue_003Ek__BackingField;
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
					_003CDefaultValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue("")]
	[JsonSerializationIgnore]
	[XmlElement("DefaultValueStr")]
	[PublicationBehaviour(PublicationType.Delta)]
	public string DefaultValueStr
	{
		get
		{
			//Discarded unreachable code: IL_003f, IL_004e
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return "";
				case 1:
					return DefaultValue.ToString();
				case 2:
					if (DefaultValue != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
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
					DefaultValue = ((!string.IsNullOrEmpty(value)) ? new DropDownItem(value) : null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Тип отображения')")]
	[XmlElement("DisplayType")]
	[DefaultValue(DropDownListDisplayType.Standard)]
	public DropDownListDisplayType DisplayType
	{
		[CompilerGenerated]
		get
		{
			return _003CDisplayType_003Ek__BackingField;
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
					_003CDisplayType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
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

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Максимальное количество элементов')")]
	[DefaultValue(100)]
	[XmlElement("MaxCount")]
	public int MaxCount
	{
		[CompilerGenerated]
		get
		{
			return _003CMaxCount_003Ek__BackingField;
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
					_003CMaxCount_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
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

	public DropDownListSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		JF0vpMozQCuvqXJ1SVMT();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Items = new DropDownItemList();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected DropDownListSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		JF0vpMozQCuvqXJ1SVMT();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Items = new DropDownItemList();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num = 2;
				}
				continue;
			case 2:
				return;
			}
			if (Items == null)
			{
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num = 0;
				}
				continue;
			}
			return;
		}
	}

	protected override void GetSerializationDescriptor(TypeSerializationDescriptor descriptor)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				base.GetSerializationDescriptor(descriptor);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			new TypeSerializationDescriptorBuilder(descriptor).ItemWithDescriptor((string)A2DV79ozvyFJPX203h4e(0x7E6E5A0B ^ 0x7E6CF7E9), delegate(TypeSerializationDescriptorBuilder i)
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
						((TypeSerializationDescriptorBuilder)_003C_003Ec.selwysCK2W4P5Us6b97t(i, _003C_003Ec.da5yrJCKOIC1ykkHfVOO(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -69807890)))).Optional((object)null).IsArray(delegate(TypeSerializationDescriptorBuilder a)
						{
							int num5 = 1;
							int num6 = num5;
							while (true)
							{
								switch (num6)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									a.ItemWithDescriptor((string)_003C_003Ec.j8m8HACKes95dYeQATFM(0x7C1EE318 ^ 0x7C1E4552), delegate(TypeSerializationDescriptorBuilder ai)
									{
										int num9 = 1;
										int num10 = num9;
										while (true)
										{
											switch (num10)
											{
											default:
												return;
											case 0:
												return;
											case 1:
												((TypeSerializationDescriptorBuilder)_003C_003Ec.CvrL5jCK1eoqdtlgfRx6(_003C_003Ec.selwysCK2W4P5Us6b97t(ai, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787090835))), _003C_003Ec.kNnvyXCKPReqSxSuPj1U(typeof(string).TypeHandle))).Optional((object)null);
												num10 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
												{
													num10 = 0;
												}
												break;
											}
										}
									}).ItemWithDescriptor((string)_003C_003Ec.j8m8HACKes95dYeQATFM(0x76DD48E ^ 0x76D72DA), delegate(TypeSerializationDescriptorBuilder ai)
									{
										int num7 = 1;
										int num8 = num7;
										while (true)
										{
											switch (num8)
											{
											default:
												return;
											case 1:
												((TypeSerializationDescriptorBuilder)_003C_003Ec.selwysCK2W4P5Us6b97t(ai, _003C_003Ec.da5yrJCKOIC1ykkHfVOO(_003C_003Ec.j8m8HACKes95dYeQATFM(-1088304168 ^ -1088138106)))).Type(_003C_003Ec.kNnvyXCKPReqSxSuPj1U(typeof(string).TypeHandle)).Optional();
												num8 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
												{
													num8 = 0;
												}
												break;
											case 0:
												return;
											}
										}
									});
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
									{
										num6 = 0;
									}
									break;
								}
							}
						});
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num4 = 0;
						}
						break;
					}
				}
			});
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
			{
				num2 = 0;
			}
		}
	}

	public override void SerializeToJsonObject(SerializableDictionary<string, object> jsonObject)
	{
		base.SerializeToJsonObject(jsonObject);
		if (Items == null)
		{
			return;
		}
		SerializableList<object> serializableList = new SerializableList<object>();
		foreach (DropDownItem item in Items)
		{
			SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object> { 
			{
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16713549),
				item.Value
			} };
			if (!string.IsNullOrEmpty(item.Key))
			{
				serializableDictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583768386)] = item.Key;
			}
			serializableList.Add(serializableDictionary);
		}
		jsonObject[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1765961528)] = serializableList;
	}

	public override void DeserializeFromJsonObject(IDictionary<string, object> jsonObject)
	{
		base.DeserializeFromJsonObject(jsonObject);
		if (jsonObject == null || !jsonObject.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x5117AFFF), out var value))
		{
			return;
		}
		if (Items == null)
		{
			Items = new DropDownItemList();
		}
		else
		{
			Items.Clear();
		}
		if (!(value is IEnumerable enumerable))
		{
			return;
		}
		foreach (object item2 in enumerable)
		{
			if (item2 is IDictionary<string, object> dictionary && dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637E8FCF), out var value2))
			{
				dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420785812), out var value3);
				DropDownItem item = new DropDownItem(value3?.ToString(), (value2 != null) ? value2.ToString() : "");
				Items.Add(item);
			}
		}
	}

	public override bool Equals(SimpleTypeSettings other)
	{
		//Discarded unreachable code: IL_007f, IL_008e
		int num = 4;
		DropDownListSettings dropDownListSettings = default(DropDownListSettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					dropDownListSettings = other as DropDownListSettings;
					num2 = 3;
					break;
				default:
					if (zCuihJozI8oRVq1pv4TH(dropDownListSettings) == DisplayType)
					{
						num2 = 2;
						break;
					}
					goto case 1;
				case 8:
					return base.Equals(other);
				case 11:
					if (dropDownListSettings == null)
					{
						num2 = 6;
						break;
					}
					if (this == dropDownListSettings)
					{
						num2 = 7;
						break;
					}
					if (base.Equals(other))
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 2:
					return iOypLSozV3mvpXcwCg1A(dropDownListSettings.DefaultValueStr, DefaultValueStr);
				case 1:
					return false;
				case 3:
					if (dropDownListSettings != null)
					{
						num2 = 11;
						break;
					}
					goto case 8;
				case 6:
					return false;
				case 5:
					if (glgBwpozu5DQmBTmdYqN(dropDownListSettings) == MaxCount)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				case 9:
					if (!((string)LSUoojoz8Vo9QsPCZ9Qh(dropDownListSettings) == ItemsString))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 10;
				case 10:
					if (LvM9LRozZVr3LbdlyZ5p(dropDownListSettings) == SelectOnly)
					{
						num2 = 5;
						break;
					}
					goto case 1;
				case 7:
					return true;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_008d, IL_009c
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return false;
				case 1:
					return true;
				default:
					return false;
				case 4:
					return DELIywoziBpKTBNwfj66(this, (DropDownListSettings)obj);
				case 3:
					if (obj == null)
					{
						break;
					}
					if (this == obj)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					if (!(obj.GetType() != tTiCEYozS1J6UScgUWCq(typeof(DropDownListSettings).TypeHandle)))
					{
						num2 = 4;
						continue;
					}
					goto default;
				}
				break;
			}
			num = 2;
		}
	}

	public override int GetHashCode()
	{
		return base.GetHashCode() ^ (((ItemsString != null) ? ItemsString.GetHashCode() : typeof(string).GetHashCode()) * 397) ^ (SelectOnly.GetHashCode() * 276) ^ (MaxCount.GetHashCode() * 213) ^ (DisplayType.GetHashCode() * 177) ^ (((DefaultValueStr != null) ? DefaultValueStr.GetHashCode() : tTiCEYozS1J6UScgUWCq(typeof(string).TypeHandle).GetHashCode()) * 13);
	}

	internal static void JF0vpMozQCuvqXJ1SVMT()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool UH0VV8ozEqYl85o40NrP()
	{
		return T052CXozGYdB0PghEj4F == null;
	}

	internal static DropDownListSettings NKmXsHozfSpa7TN4wVZq()
	{
		return T052CXozGYdB0PghEj4F;
	}

	internal static void arEGLKozCjn9DE4qBWvI(object P_0, object P_1)
	{
		((DropDownItemList)P_0).Parse((string)P_1);
	}

	internal static object A2DV79ozvyFJPX203h4e(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object LSUoojoz8Vo9QsPCZ9Qh(object P_0)
	{
		return ((DropDownListSettings)P_0).ItemsString;
	}

	internal static bool LvM9LRozZVr3LbdlyZ5p(object P_0)
	{
		return ((DropDownListSettings)P_0).SelectOnly;
	}

	internal static int glgBwpozu5DQmBTmdYqN(object P_0)
	{
		return ((DropDownListSettings)P_0).MaxCount;
	}

	internal static DropDownListDisplayType zCuihJozI8oRVq1pv4TH(object P_0)
	{
		return ((DropDownListSettings)P_0).DisplayType;
	}

	internal static bool iOypLSozV3mvpXcwCg1A(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static Type tTiCEYozS1J6UScgUWCq(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool DELIywoziBpKTBNwfj66(object P_0, object P_1)
	{
		return ((SimpleTypeSettings)P_0).Equals((SimpleTypeSettings)P_1);
	}
}
