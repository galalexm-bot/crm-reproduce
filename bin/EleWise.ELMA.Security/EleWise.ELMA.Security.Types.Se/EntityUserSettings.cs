using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Common;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Types.Settings;

[Serializable]
public class EntityUserSettings : EntitySettings
{
	internal static EntityUserSettings UiYSjYZS7WhtXwdooLD;

	[XmlElement("ShowDifferentTimeZone")]
	[DefaultValue(false)]
	public bool ShowDifferentTimeZone
	{
		[CompilerGenerated]
		get
		{
			return _003CShowDifferentTimeZone_003Ek__BackingField;
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
					_003CShowDifferentTimeZone_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("Replaceable")]
	[DefaultValue(false)]
	[JsonSerializationIgnore]
	public bool Replaceable
	{
		[CompilerGenerated]
		get
		{
			return _003CReplaceable_003Ek__BackingField;
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
					_003CReplaceable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c == 0)
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
	public Guid ReplacedUserPropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CReplacedUserPropertyUid_003Ek__BackingField;
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
					_003CReplacedUserPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public virtual List<Worker> Workers { get; set; }

	[JsonSerializationIgnore]
	[DefaultValue(null)]
	[XmlElement("Workers")]
	public virtual string WorkersSerialized
	{
		get
		{
			//Discarded unreachable code: IL_0031, IL_0040
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (Workers.Count == 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 3:
					if (Workers != null)
					{
						num2 = 2;
						continue;
					}
					break;
				default:
					return (string)CaDUIQZzQLkAYOg5DyQ(new WorkerListContainer(Workers), false);
				case 1:
					break;
				}
				break;
			}
			return null;
		}
		set
		{
			//Discarded unreachable code: IL_00a8
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!jSMLaNxkucx5XHTRSHh(value))
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 3:
					Workers = null;
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
					{
						num2 = 4;
					}
					break;
				case 4:
					return;
				default:
					Workers = ClassSerializationHelper.DeserializeObjectByXml<WorkerListContainer>(value, useComponentManager: false).Workers;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				}
			}
		}
	}

	[DefaultValue("")]
	[JsonSerializationIgnore]
	[XmlElement("ReplacedUserPropertyUid")]
	public string ReplacedUserPropertyUidStr
	{
		get
		{
			//Discarded unreachable code: IL_0057, IL_0066
			int num = 1;
			int num2 = num;
			Guid replacedUserPropertyUid = default(Guid);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return "";
				default:
					replacedUserPropertyUid = ReplacedUserPropertyUid;
					num2 = 3;
					break;
				case 3:
					return replacedUserPropertyUid.ToString();
				case 1:
					if (iCxYR9xpesX42CLQLxK(ReplacedUserPropertyUid, Guid.Empty))
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 == 0)
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
					ReplacedUserPropertyUid = ((!string.IsNullOrEmpty(value)) ? new Guid(value) : Guid.Empty);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	public bool ShowBlock
	{
		[CompilerGenerated]
		get
		{
			return _003CShowBlock_003Ek__BackingField;
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
					_003CShowBlock_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	public bool CheckReplacement
	{
		[CompilerGenerated]
		get
		{
			return _003CCheckReplacement_003Ek__BackingField;
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
					_003CCheckReplacement_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public string ReplacementStartDateClientFunction
	{
		[CompilerGenerated]
		get
		{
			return _003CReplacementStartDateClientFunction_003Ek__BackingField;
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
					_003CReplacementStartDateClientFunction_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public string ReplacementEndDateClientFunction
	{
		[CompilerGenerated]
		get
		{
			return _003CReplacementEndDateClientFunction_003Ek__BackingField;
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
					_003CReplacementEndDateClientFunction_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public EntityUserSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YYuPUaZ1ypur7FToGi1();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected EntityUserSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		YYuPUaZ1ypur7FToGi1();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override void SerializeToJsonObject(SerializableDictionary<string, object> jsonObject)
	{
		base.SerializeToJsonObject(jsonObject);
		if (Workers == null || Workers.Count <= 0)
		{
			return;
		}
		SerializableList<object> serializableList = new SerializableList<object>();
		foreach (Worker worker in Workers)
		{
			SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
			serializableDictionary[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788380826 ^ -1788393750)] = worker.WorkerType;
			serializableDictionary[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-179348817 ^ -179346165)] = worker.WorkerId;
			serializableList.Add(serializableDictionary);
		}
		jsonObject[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7DABA580 ^ 0x7DAB9A38)] = serializableList;
	}

	public override void DeserializeFromJsonObject(IDictionary<string, object> jsonObject)
	{
		base.DeserializeFromJsonObject(jsonObject);
		if (jsonObject == null || !jsonObject.TryGetValue(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x78610A3D ^ 0x78613585), out var value))
		{
			return;
		}
		if (Workers == null)
		{
			Workers = new List<Worker>();
		}
		else
		{
			Workers.Clear();
		}
		if (!(value is IEnumerable enumerable))
		{
			return;
		}
		foreach (object item in enumerable)
		{
			if (item is IDictionary<string, object> dictionary && dictionary.TryGetValue(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D3A45F ^ 0x4D39BD3), out var value2) && dictionary.TryGetValue(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7A093321 ^ 0x7A090C85), out var value3) && value2 != null && value3 != null && Guid.TryParse(value2.ToString(), out var result) && long.TryParse(value3.ToString(), out var result2))
			{
				Workers.Add(new Worker
				{
					WorkerType = result,
					WorkerId = result2
				});
			}
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_00a4, IL_00b3
		int num = 2;
		int num2 = num;
		EntityUserSettings entityUserSettings = default(EntityUserSettings);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (entityUserSettings == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 4;
			case 2:
				entityUserSettings = obj as EntityUserSettings;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 != 0)
				{
					num2 = 1;
				}
				continue;
			case 4:
				if (entityUserSettings.CheckReplacement == CheckReplacement)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				return O78q8jx5M2UvwRjCO1O(this, obj);
			case 3:
				break;
			}
			break;
		}
		return false;
	}

	protected override void GetSerializationDescriptor(TypeSerializationDescriptor descriptor)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				LEtMclxAnWiT4tUWV7w(this, descriptor);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				new TypeSerializationDescriptorBuilder(descriptor).ItemWithDescriptor((string)CeXsVbxWGZR92Ir0Jgw(-566078848 ^ -566072008), delegate(TypeSerializationDescriptorBuilder i)
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
							((TypeSerializationDescriptorBuilder)_003C_003Ec.xMNvkmplk69PhhpyPLce(i, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7DABA580 ^ 0x7DAA8F38)))).Optional((object)null).ItemWithDescriptor((string)_003C_003Ec.WGEXfnplp74sEqhj4o7K(0xA5DAE86 ^ 0xA5D910A), delegate(TypeSerializationDescriptorBuilder i2)
							{
								int num7 = 1;
								int num8 = num7;
								while (true)
								{
									switch (num8)
									{
									default:
										return;
									case 0:
										return;
									case 1:
										((TypeSerializationDescriptorBuilder)_003C_003Ec.xMNvkmplk69PhhpyPLce(i2, _003C_003Ec.D5GUJHpl5WXXjmxffpnt(_003C_003Ec.WGEXfnplp74sEqhj4o7K(-1580392499 ^ -1580452559), new object[2]
										{
											_003C_003Ec.WGEXfnplp74sEqhj4o7K(0x61EAE816 ^ 0x61EAA31E),
											_003C_003Ec.WGEXfnplp74sEqhj4o7K(0x48E9668D ^ 0x48E92D61)
										}))).Type(typeof(Guid));
										num8 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
										{
											num8 = 0;
										}
										break;
									}
								}
							}).ItemWithDescriptor(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1518425080 ^ -1518431316), delegate(TypeSerializationDescriptorBuilder i2)
							{
								int num5 = 1;
								int num6 = num5;
								while (true)
								{
									switch (num6)
									{
									default:
										return;
									case 1:
										_003C_003Ec.bosbsCplW89arVJSWu1E(i2.Description((string)_003C_003Ec.xqLgC7plAkYeTZv5Av9y(_003C_003Ec.WGEXfnplp74sEqhj4o7K(0xAEB118D ^ 0xAEA3A47))), typeof(long));
										num6 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 != 0)
										{
											num6 = 0;
										}
										break;
									case 0:
										return;
									}
								}
							});
							num4 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 == 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void YYuPUaZ1ypur7FToGi1()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool iM4UUHZ9FGDv2UHQcqu()
	{
		return UiYSjYZS7WhtXwdooLD == null;
	}

	internal static EntityUserSettings vQ6f6gZfWg1DN2Ca2rM()
	{
		return UiYSjYZS7WhtXwdooLD;
	}

	internal static object CaDUIQZzQLkAYOg5DyQ(object P_0, bool P_1)
	{
		return ClassSerializationHelper.SerializeObjectByXml(P_0, P_1);
	}

	internal static bool jSMLaNxkucx5XHTRSHh(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool iCxYR9xpesX42CLQLxK(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool O78q8jx5M2UvwRjCO1O(object P_0, object P_1)
	{
		return ((EntitySettings)P_0).Equals(P_1);
	}

	internal static void LEtMclxAnWiT4tUWV7w(object P_0, object P_1)
	{
		((TypeSettings)P_0).GetSerializationDescriptor((TypeSerializationDescriptor)P_1);
	}

	internal static object CeXsVbxWGZR92Ir0Jgw(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
