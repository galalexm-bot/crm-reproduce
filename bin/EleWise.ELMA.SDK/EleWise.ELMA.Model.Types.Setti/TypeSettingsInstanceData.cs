using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Types.Settings;

public class TypeSettingsInstanceData
{
	[XmlType(TypeName = "TypeSettingsInstanceDataItem")]
	public class DataItem
	{
		private static DataItem DyshiHCKbrqqkHPLWRyv;

		public Guid PropertyUid
		{
			[CompilerGenerated]
			get
			{
				return _003CPropertyUid_003Ek__BackingField;
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
						_003CPropertyUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
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

		public TypeSettings Settings
		{
			[CompilerGenerated]
			get
			{
				return _003CSettings_003Ek__BackingField;
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
						_003CSettings_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public DataItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			oNeuENCKE0TSjXxSCOe8();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool sSLH90CKhp9oL6i9SmKD()
		{
			return DyshiHCKbrqqkHPLWRyv == null;
		}

		internal static DataItem hF9sXVCKG5a1H6wRHCwO()
		{
			return DyshiHCKbrqqkHPLWRyv;
		}

		internal static void oNeuENCKE0TSjXxSCOe8()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	internal static TypeSettingsInstanceData Yo7HdyocJBL6LxIZNvHP;

	public List<DataItem> Items { get; set; }

	public TypeSettings this[Guid uid]
	{
		get
		{
			int num = 2;
			_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
			DataItem dataItem = default(DataItem);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
						return null;
					case 2:
						_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
						{
							num2 = 1;
						}
						continue;
					case 3:
						if (dataItem != null)
						{
							return dataItem.Settings;
						}
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 4;
						}
						continue;
					case 1:
						_003C_003Ec__DisplayClass7_.uid = uid;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				dataItem = Items.FirstOrDefault(_003C_003Ec__DisplayClass7_._003Cget_Item_003Eb__0);
				num = 3;
			}
		}
		set
		{
			//Discarded unreachable code: IL_0049
			int num = 9;
			_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
			DataItem dataItem = default(DataItem);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 9:
						_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
						num = 8;
						break;
					case 4:
						fgy8Ioocrpphf23Ip9BI(dataItem, _003C_003Ec__DisplayClass8_.uid);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num2 = 1;
						}
						continue;
					case 6:
						if (dataItem != null)
						{
							num2 = 3;
							continue;
						}
						goto case 2;
					case 5:
						dataItem = Items.FirstOrDefault(_003C_003Ec__DisplayClass8_._003Cset_Item_003Eb__0);
						num2 = 6;
						continue;
					case 7:
						return;
					case 8:
						_003C_003Ec__DisplayClass8_.uid = uid;
						num2 = 5;
						continue;
					case 2:
						dataItem = new DataItem();
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num2 = 3;
						}
						continue;
					case 1:
						Items.Add(dataItem);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num2 = 0;
						}
						continue;
					default:
						mibXaIocgCIGQwDvSoXe(dataItem, value);
						num = 7;
						break;
					}
					break;
				}
			}
		}
	}

	public TypeSettingsInstanceData()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		eOnXu7oclbrbfgjo7bod();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Items = new List<DataItem>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public string SerializeToJson()
	{
		return (string)cGAELpoc5OcbbIyqTJFB(SerializeToJsonObject());
	}

	public Dictionary<string, SerializableDictionary<string, object>> SerializeToJsonObject()
	{
		Dictionary<string, SerializableDictionary<string, object>> dictionary = new Dictionary<string, SerializableDictionary<string, object>>();
		foreach (DataItem item in Items)
		{
			if (item.Settings != null)
			{
				SerializableDictionary<string, object> value = TypeSettingsSerializer.SerializeToJsonObject(item.Settings);
				dictionary[item.PropertyUid.ToString()] = value;
			}
		}
		return dictionary;
	}

	public void DeserializeFromJson(string json)
	{
		int num = 3;
		Dictionary<string, Dictionary<string, object>> dictionary = default(Dictionary<string, Dictionary<string, object>>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					return;
				case 2:
					return;
				case 4:
					if (dictionary == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num2 = 0;
						}
						break;
					}
					DeserializeFromJsonObject(((IEnumerable<KeyValuePair<string, Dictionary<string, object>>>)dictionary).ToDictionary((Func<KeyValuePair<string, Dictionary<string, object>>, string>)((KeyValuePair<string, Dictionary<string, object>> p) => p.Key), (Func<KeyValuePair<string, Dictionary<string, object>>, IDictionary<string, object>>)((KeyValuePair<string, Dictionary<string, object>> p) => p.Value)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					if (!string.IsNullOrEmpty(json))
					{
						dictionary = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, object>>>(json);
						num = 4;
						goto end_IL_0012;
					}
					num2 = 2;
					break;
				case 0:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
		}
	}

	public void DeserializeFromJsonObject(Dictionary<string, IDictionary<string, object>> jsonObject)
	{
		if (jsonObject == null)
		{
			return;
		}
		foreach (KeyValuePair<string, IDictionary<string, object>> item in jsonObject)
		{
			TypeSettings typeSettings = TypeSettingsSerializer.DeserializeFromJsonObject(item.Value);
			if (typeSettings != null)
			{
				Items.Add(new DataItem
				{
					PropertyUid = new Guid(item.Key),
					Settings = typeSettings
				});
			}
		}
	}

	internal static void eOnXu7oclbrbfgjo7bod()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool TkTkgyoc9xGG2tCUYSD6()
	{
		return Yo7HdyocJBL6LxIZNvHP == null;
	}

	internal static TypeSettingsInstanceData DkCVIrocdI38rxhqhVuh()
	{
		return Yo7HdyocJBL6LxIZNvHP;
	}

	internal static void fgy8Ioocrpphf23Ip9BI(object P_0, Guid value)
	{
		((DataItem)P_0).PropertyUid = value;
	}

	internal static void mibXaIocgCIGQwDvSoXe(object P_0, object P_1)
	{
		((DataItem)P_0).Settings = (TypeSettings)P_1;
	}

	internal static object cGAELpoc5OcbbIyqTJFB(object P_0)
	{
		return JsonConvert.SerializeObject(P_0);
	}
}
