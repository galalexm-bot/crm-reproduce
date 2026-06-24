using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.DTO.Models;

[Serializable]
public class FormMetadataItemHeaderDTO : EntityDTO<long>, ISerializable
{
	private static FormMetadataItemHeaderDTO lquSQyJx0K31AVAVm6U;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
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
		[CompilerGenerated]
		get
		{
			return _003CDisplayName_003Ek__BackingField;
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
					_003CDisplayName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public long? GroupId { get; set; }

	public DateTime CreationDate
	{
		[CompilerGenerated]
		get
		{
			return _003CCreationDate_003Ek__BackingField;
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
					_003CCreationDate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
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

	public long? CreationAuthorId { get; set; }

	public Guid MetadataType
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadataType_003Ek__BackingField;
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
					_003CMetadataType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
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

	public bool IsDirtyItem
	{
		[CompilerGenerated]
		get
		{
			return _003CIsDirtyItem_003Ek__BackingField;
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
					_003CIsDirtyItem_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
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

	public long? DraftId { get; set; }

	public DateTime? Draft_CreationDate { get; set; }

	public long? PublishedId { get; set; }

	public DateTime? Published_CreationDate { get; set; }

	public FormMetadataItemHeaderDTO()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		K5QNV6JyOXxwadXmHvO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public void CopyFrom(FormMetadataItemHeaderDTO header)
	{
		//Discarded unreachable code: IL_0068, IL_0077, IL_0082, IL_013b, IL_016b, IL_017a, IL_0186
		int num = 2;
		int num2 = num;
		IEnumerator<PropertyInfo> enumerator = default(IEnumerator<PropertyInfo>);
		PropertyInfo current = default(PropertyInfo);
		while (true)
		{
			switch (num2)
			{
			case 2:
				Contract.ArgumentNotNull(header, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576189648));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				return;
			case 1:
				enumerator = kF9jgTJMdX6n8eNadTW(typeof(FormMetadataItemHeaderDTO).TypeHandle).GetProperties().Where(delegate(PropertyInfo p)
				{
					//Discarded unreachable code: IL_0035, IL_0044, IL_008e
					int num5 = 3;
					int num6 = num5;
					while (true)
					{
						switch (num6)
						{
						case 4:
							if (!p.CanWrite)
							{
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
								{
									num6 = 1;
								}
								break;
							}
							goto default;
						case 3:
							if (!_003C_003Ec.r4qL3Of58F6KAONVY9JL(p))
							{
								num6 = 2;
								break;
							}
							goto case 4;
						default:
							return ((Array)_003C_003Ec.U1IBFgf5ZqSatEGnYyEY(p)).Length == 0;
						case 1:
						case 2:
							return false;
						}
					}
				}).GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!xicJUpJdLAKoulkpXXp(enumerator))
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num3 = 3;
						}
						goto IL_0086;
					}
					goto IL_00c6;
					IL_00c6:
					current = enumerator.Current;
					num3 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num3 = 0;
					}
					goto IL_0086;
					IL_0086:
					while (true)
					{
						switch (num3)
						{
						case 1:
							goto IL_00c6;
						case 2:
							G4FY3QJ9nr06nDtmtWj(current, this, CSo8TDJJLJynvpaY3mQ(current, header, null), null);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
							{
								num3 = 0;
							}
							continue;
						case 3:
							return;
						}
						break;
					}
				}
			}
			finally
			{
				int num4;
				if (enumerator == null)
				{
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num4 = 1;
					}
					goto IL_013f;
				}
				goto IL_0155;
				IL_0155:
				BOR48VJlROjNJ2Vwae7(enumerator);
				num4 = 2;
				goto IL_013f;
				IL_013f:
				switch (num4)
				{
				case 1:
					goto end_IL_011a;
				case 2:
					goto end_IL_011a;
				}
				goto IL_0155;
				end_IL_011a:;
			}
		}
	}

	protected FormMetadataItemHeaderDTO(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002a, IL_0097, IL_00a6, IL_00b1, IL_015b, IL_019b, IL_01aa, IL_01b6, IL_01c5
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
		{
			num = 1;
		}
		string xml = default(string);
		IEnumerator<PropertyInfo> enumerator = default(IEnumerator<PropertyInfo>);
		PropertyInfo current = default(PropertyInfo);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
			{
				xml = (string)jG1F4lJrWDWZWnWUUnR(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957845816), kF9jgTJMdX6n8eNadTW(typeof(string).TypeHandle));
				int num2 = 4;
				num = num2;
				break;
			}
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
							{
								num3 = 0;
							}
							goto IL_00b5;
						}
						goto IL_00f5;
						IL_00f5:
						current = enumerator.Current;
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num3 = 2;
						}
						goto IL_00b5;
						IL_00b5:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								break;
							case 2:
								goto IL_00f5;
							case 3:
								current.SetValue(this, CSo8TDJJLJynvpaY3mQ(current, obj, null), null);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							break;
						}
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 2;
						goto IL_015f;
					}
					goto IL_0175;
					IL_015f:
					switch (num4)
					{
					case 2:
						goto end_IL_014a;
					case 1:
						goto end_IL_014a;
					}
					goto IL_0175;
					IL_0175:
					BOR48VJlROjNJ2Vwae7(enumerator);
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num4 = 1;
					}
					goto IL_015f;
					end_IL_014a:;
				}
			case 4:
				obj = ClassSerializationHelper.DeserializeObjectByXml(L9cI3tJgB95vOAbZvAD(this), xml);
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num = 5;
				}
				break;
			case 5:
				if (obj == null)
				{
					return;
				}
				num = 2;
				break;
			case 2:
				enumerator = obj.GetType().GetProperties().Where(delegate(PropertyInfo p)
				{
					int num5 = 2;
					int num6 = num5;
					while (true)
					{
						switch (num6)
						{
						default:
							return AttributeHelper<XmlIgnoreAttribute>.GetAttribute(p, inherited: true) == null;
						case 1:
							if (_003C_003Ec.SylJaXf5u6GjWo7arjpa(p))
							{
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
								{
									num6 = 0;
								}
								break;
							}
							goto IL_0033;
						case 2:
							{
								if (p.CanRead)
								{
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
									{
										num6 = 1;
									}
									break;
								}
								goto IL_0033;
							}
							IL_0033:
							return false;
						}
					}
				})
					.GetEnumerator();
				num = 3;
				break;
			}
		}
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
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
				YDG1dxJjgLo481dnAm3(info, FcWCK7J5c83NDq5SxeP(0x7247028A ^ 0x7247AE02), ClassSerializationHelper.SerializeObjectByXml(this));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void K5QNV6JyOXxwadXmHvO()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Pt6GraJ07CWNoW4v5PV()
	{
		return lquSQyJx0K31AVAVm6U == null;
	}

	internal static FormMetadataItemHeaderDTO at953uJmYWceNZQSU2w()
	{
		return lquSQyJx0K31AVAVm6U;
	}

	internal static Type kF9jgTJMdX6n8eNadTW(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object CSo8TDJJLJynvpaY3mQ(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static void G4FY3QJ9nr06nDtmtWj(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static bool xicJUpJdLAKoulkpXXp(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void BOR48VJlROjNJ2Vwae7(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object jG1F4lJrWDWZWnWUUnR(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	internal static Type L9cI3tJgB95vOAbZvAD(object P_0)
	{
		return P_0.GetType();
	}

	internal static object FcWCK7J5c83NDq5SxeP(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void YDG1dxJjgLo481dnAm3(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
