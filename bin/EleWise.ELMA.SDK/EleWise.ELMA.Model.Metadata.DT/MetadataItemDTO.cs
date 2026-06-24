using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.DTO.Models;

[Serializable]
public class MetadataItemDTO : EntityDTO<long>, ISerializable
{
	private static MetadataItemDTO MISZhXbgoTULVSqp9MoQ;

	public long HeaderId
	{
		[CompilerGenerated]
		get
		{
			return _003CHeaderId_003Ek__BackingField;
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
					_003CHeaderId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
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
				case 1:
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
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

	public long HeaderGroupId
	{
		[CompilerGenerated]
		get
		{
			return _003CHeaderGroupId_003Ek__BackingField;
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
					_003CHeaderGroupId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DateTime HeaderCreationDate
	{
		[CompilerGenerated]
		get
		{
			return _003CHeaderCreationDate_003Ek__BackingField;
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
					_003CHeaderCreationDate_003Ek__BackingField = value;
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

	public long HeaderCreationAuthorId
	{
		[CompilerGenerated]
		get
		{
			return _003CHeaderCreationAuthorId_003Ek__BackingField;
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
					_003CHeaderCreationAuthorId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
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

	public string HeaderTag
	{
		[CompilerGenerated]
		get
		{
			return _003CHeaderTag_003Ek__BackingField;
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
					_003CHeaderTag_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
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

	public long CreationAuthorId
	{
		[CompilerGenerated]
		get
		{
			return _003CCreationAuthorId_003Ek__BackingField;
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
					_003CCreationAuthorId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DateTime PublishedCreationDate
	{
		[CompilerGenerated]
		get
		{
			return _003CPublishedCreationDate_003Ek__BackingField;
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
					_003CPublishedCreationDate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public long? PublishedCreationAuthorId { get; set; }

	public long? PublishedId { get; set; }

	public ScriptModuleDTO ScriptModule
	{
		[CompilerGenerated]
		get
		{
			return _003CScriptModule_003Ek__BackingField;
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
					_003CScriptModule_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
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

	public ScriptModuleDTO ClientScriptModule
	{
		[CompilerGenerated]
		get
		{
			return _003CClientScriptModule_003Ek__BackingField;
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
					_003CClientScriptModule_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
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

	public MetadataItemDTO()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ryHLubbgGHMMqMkibx4S();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override void CopyChanges(EntityDTO<long> saved)
	{
		base.CopyChanges(saved);
		if (saved is MetadataItemDTO metadataItemDTO)
		{
			Uid = metadataItemDTO.Uid;
			if (ScriptModule != null && metadataItemDTO.ScriptModule != null)
			{
				ScriptModule.CopyChanges(metadataItemDTO.ScriptModule);
			}
		}
	}

	protected MetadataItemDTO(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_001a, IL_00b2, IL_00c1, IL_00cc, IL_01a2, IL_01c1, IL_01f1, IL_0200, IL_0247, IL_0256
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 4;
		string xml = default(string);
		string text = default(string);
		Type type = default(Type);
		IEnumerator<PropertyInfo> enumerator = default(IEnumerator<PropertyInfo>);
		object obj = default(object);
		PropertyInfo current = default(PropertyInfo);
		while (true)
		{
			switch (num)
			{
			case 3:
				xml = (string)Q348swbgZPU03wbY94Jd(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710619128));
				num = 2;
				continue;
			case 7:
				if (pMNye2bguim4hay12Bgj(text))
				{
					num = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num = 6;
					}
					continue;
				}
				goto default;
			default:
				type = Type.GetType(text);
				num = 3;
				continue;
			case 5:
				try
				{
					while (true)
					{
						IL_0166:
						int num2;
						if (!MtNIn0bgvcNwagivvPnu(enumerator))
						{
							num2 = 4;
							goto IL_00d0;
						}
						goto IL_011e;
						IL_00d0:
						while (true)
						{
							switch (num2)
							{
							case 2:
								obj = HWgSi5bgQ3fSVDc0d8Hj(info, AUveFpbgEWql9Ze0752v(current), FwPPKKbgfQya1MB88ZNG(current));
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
								{
									num2 = 0;
								}
								continue;
							case 1:
								GAVJ99bgCVBMsHp3Dl4D(current, this, obj, null);
								num2 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
								{
									num2 = 3;
								}
								continue;
							case 3:
								goto IL_0166;
							case 4:
								goto end_IL_0166;
							}
							break;
						}
						goto IL_011e;
						IL_011e:
						current = enumerator.Current;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 2;
						}
						goto IL_00d0;
						continue;
						end_IL_0166:
						break;
					}
				}
				finally
				{
					int num3;
					if (enumerator == null)
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
						{
							num3 = 0;
						}
						goto IL_01a6;
					}
					goto IL_01cf;
					IL_01cf:
					wd7bx5bg8cGm5o1m2h21(enumerator);
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num3 = 1;
					}
					goto IL_01a6;
					IL_01a6:
					switch (num3)
					{
					default:
						goto end_IL_0181;
					case 0:
						goto end_IL_0181;
					case 2:
						break;
					case 1:
						goto end_IL_0181;
					}
					goto IL_01cf;
					end_IL_0181:;
				}
				break;
			case 6:
				return;
			case 8:
				return;
			case 2:
				Metadata = (IMetadata)ClassSerializationHelper.DeserializeObjectByXml(type, xml);
				num = 8;
				continue;
			case 4:
				enumerator = GetSerializableProperties().GetEnumerator();
				num = 5;
				continue;
			case 1:
				break;
			}
			text = (string)Q348swbgZPU03wbY94Jd(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16556507));
			int num4 = 7;
			num = num4;
		}
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_0036, IL_0045, IL_0050, IL_010d, IL_0145, IL_0154
		int num = 3;
		IEnumerator<PropertyInfo> enumerator = default(IEnumerator<PropertyInfo>);
		PropertyInfo current = default(PropertyInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					try
					{
						while (true)
						{
							int num3;
							if (!MtNIn0bgvcNwagivvPnu(enumerator))
							{
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
								{
									num3 = 3;
								}
								goto IL_0054;
							}
							goto IL_00c4;
							IL_00c4:
							current = enumerator.Current;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
							{
								num3 = 0;
							}
							goto IL_0054;
							IL_0054:
							while (true)
							{
								switch (num3)
								{
								case 1:
									sGwVGrbgIcFpcQTs4e1H(info, current.Name, current.GetValue(this, null));
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
									{
										num3 = 0;
									}
									continue;
								case 2:
									goto IL_00c4;
								case 3:
									goto end_IL_006e;
								}
								break;
							}
							continue;
							end_IL_006e:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									wd7bx5bg8cGm5o1m2h21(enumerator);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 1;
				case 3:
					enumerator = GetSerializableProperties().GetEnumerator();
					num2 = 2;
					continue;
				case 4:
					return;
				case 1:
					sGwVGrbgIcFpcQTs4e1H(info, JtYxVRbgV17PjpasSqpF(-1998538950 ^ -1998342152), (Metadata != null) ? Metadata.GetType().AssemblyQualifiedName : string.Empty);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					info.AddValue((string)JtYxVRbgV17PjpasSqpF(0x7247028A ^ 0x7247B448), (Metadata != null) ? ClassSerializationHelper.SerializeObjectByXml(Metadata) : null);
					num = 4;
					break;
				}
				break;
			}
		}
	}

	private IEnumerable<PropertyInfo> GetSerializableProperties()
	{
		return GetType().GetProperties().Where(delegate(PropertyInfo p)
		{
			//Discarded unreachable code: IL_0078, IL_0087
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return _003C_003Ec.GMPEtfC7yvdlstqXroiX(_003C_003Ec.M8UJqWC709k14GIT3ldt(p), _003C_003Ec.Xg1Dr4C7mlchYyKi8e5B(0x1637C429 ^ 0x163772EB));
				default:
					return false;
				case 2:
					if (_003C_003Ec.I49Mw7C77Va0jPQv2Rb3(p))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				case 3:
					if (p.GetIndexParameters().Length != 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				case 1:
					if (_003C_003Ec.ykVe2sC7x3ljwp0tyqLO(p))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
			}
		});
	}

	internal static void ryHLubbgGHMMqMkibx4S()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool BGXunCbgb9PMF5aCE6iB()
	{
		return MISZhXbgoTULVSqp9MoQ == null;
	}

	internal static MetadataItemDTO UCSuDvbghL15UIVomLpt()
	{
		return MISZhXbgoTULVSqp9MoQ;
	}

	internal static object AUveFpbgEWql9Ze0752v(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static Type FwPPKKbgfQya1MB88ZNG(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static object HWgSi5bgQ3fSVDc0d8Hj(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	internal static void GAVJ99bgCVBMsHp3Dl4D(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static bool MtNIn0bgvcNwagivvPnu(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void wd7bx5bg8cGm5o1m2h21(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object Q348swbgZPU03wbY94Jd(object P_0, object P_1)
	{
		return ((SerializationInfo)P_0).GetString((string)P_1);
	}

	internal static bool pMNye2bguim4hay12Bgj(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void sGwVGrbgIcFpcQTs4e1H(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	internal static object JtYxVRbgV17PjpasSqpF(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
