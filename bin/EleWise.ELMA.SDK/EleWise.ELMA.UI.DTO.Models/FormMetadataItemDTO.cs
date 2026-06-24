using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.DTO.Models;

[Serializable]
public class FormMetadataItemDTO : EntityDTO<long>, ISerializable
{
	internal static FormMetadataItemDTO Ur5iQgJ2bDH3uF8bpMj;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
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
				case 0:
					return;
				case 1:
					_003CCreationDate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public long? CreationAuthorId { get; set; }

	public object Metadata
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

	public FormMetadataItemHeaderDTO Header
	{
		[CompilerGenerated]
		get
		{
			return _003CHeader_003Ek__BackingField;
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
					_003CHeader_003Ek__BackingField = value;
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

	public FormMetadataItemDTO()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vOh5LlJ1Y46dOPx98O8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public void CopyIdsFrom(FormMetadataItemDTO item)
	{
		//Discarded unreachable code: IL_00bd, IL_00cc
		int num = 9;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					CreationAuthorId = item.CreationAuthorId;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 2;
					}
					continue;
				case 9:
					Contract.ArgumentNotNull(item, (string)Iv0WpPJNJVx1BAVwo8y(-345420348 ^ -345381446));
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 7;
					}
					continue;
				case 7:
					return;
				case 4:
					TNXRoJJDmW5YinZ3bRW(ScriptModule, ((ScriptModuleDTO)x5As77JaOBrfqs3lFjD(item)).Uid);
					num2 = 5;
					continue;
				case 10:
					ScriptModule.Id = ((EntityDTO<long>)x5As77JaOBrfqs3lFjD(item)).Id;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					return;
				case 3:
					if (ScriptModule == null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 2;
				case 2:
					if (x5As77JaOBrfqs3lFjD(item) == null)
					{
						return;
					}
					num2 = 10;
					continue;
				case 8:
					base.Id = item.Id;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					CreationDate = ulJ3n5JpCsQUCNul7SP(item);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			Uid = Bj8DndJ3QZy4m6uvc2p(item);
			num = 6;
		}
	}

	protected FormMetadataItemDTO(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_001a, IL_001f, IL_0097, IL_00a1, IL_014b, IL_0183
		vOh5LlJ1Y46dOPx98O8();
		base._002Ector();
		int num = 3;
		object obj = default(object);
		string xml = default(string);
		IEnumerator<PropertyInfo> enumerator = default(IEnumerator<PropertyInfo>);
		PropertyInfo current = default(PropertyInfo);
		while (true)
		{
			switch (num)
			{
			case 1:
				obj = ClassSerializationHelper.DeserializeObjectByXml(k36cAUJ4H6piG11G3AX(this), xml);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num = 0;
				}
				continue;
			case 5:
				return;
			case 2:
				try
				{
					while (true)
					{
						int num2;
						if (!enumerator.MoveNext())
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
							{
								num2 = 1;
							}
							goto IL_00a5;
						}
						goto IL_0102;
						IL_0102:
						current = enumerator.Current;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 0;
						}
						goto IL_00a5;
						IL_00a5:
						while (true)
						{
							switch (num2)
							{
							case 1:
								return;
							default:
								IowDwKJHIVlI3QMipLM(current, this, tGFYk4J6udbgSWF24L8(current, obj, null), null);
								num2 = 2;
								continue;
							case 2:
								break;
							case 3:
								goto IL_0102;
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								EjRaLKJAMlTdC2Meq2c(enumerator);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
								{
									num3 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 3:
				xml = (string)ITY63jJwnrQ9XagMNvn(info, Iv0WpPJNJVx1BAVwo8y(-29254301 ^ -29281813), wYa9ksJtJnsBAZpMMRk(typeof(string).TypeHandle));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num = 1;
				}
				continue;
			case 4:
				enumerator = obj.GetType().GetProperties().Where(delegate(PropertyInfo p)
				{
					//Discarded unreachable code: IL_0035, IL_0044, IL_0054
					int num4 = 3;
					int num5 = num4;
					while (true)
					{
						switch (num5)
						{
						case 4:
							if (!_003C_003Ec.IoDdDhf5EDWbIZOsB9cv(p))
							{
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
								{
									num5 = 0;
								}
								break;
							}
							goto default;
						default:
							return AttributeHelper<XmlIgnoreAttribute>.GetAttribute(p, inherited: true) == null;
						case 1:
						case 2:
							return false;
						case 3:
							if (!p.CanRead)
							{
								num5 = 2;
								break;
							}
							goto case 4;
						}
					}
				})
					.GetEnumerator();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num = 0;
				}
				continue;
			}
			if (obj != null)
			{
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num = 4;
				}
				continue;
			}
			return;
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
				Lx1wxsJ71to9pPbVeQe(info, Iv0WpPJNJVx1BAVwo8y(0x3A5D5EF ^ 0x3A57967), ClassSerializationHelper.SerializeObjectByXml(this));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void vOh5LlJ1Y46dOPx98O8()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool yXbF1XJeve0oR03pspY()
	{
		return Ur5iQgJ2bDH3uF8bpMj == null;
	}

	internal static FormMetadataItemDTO KvgweWJP0Zgxv0J8UgF()
	{
		return Ur5iQgJ2bDH3uF8bpMj;
	}

	internal static object Iv0WpPJNJVx1BAVwo8y(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Guid Bj8DndJ3QZy4m6uvc2p(object P_0)
	{
		return ((FormMetadataItemDTO)P_0).Uid;
	}

	internal static DateTime ulJ3n5JpCsQUCNul7SP(object P_0)
	{
		return ((FormMetadataItemDTO)P_0).CreationDate;
	}

	internal static object x5As77JaOBrfqs3lFjD(object P_0)
	{
		return ((FormMetadataItemDTO)P_0).ScriptModule;
	}

	internal static void TNXRoJJDmW5YinZ3bRW(object P_0, Guid value)
	{
		((ScriptModuleDTO)P_0).Uid = value;
	}

	internal static Type wYa9ksJtJnsBAZpMMRk(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object ITY63jJwnrQ9XagMNvn(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	internal static Type k36cAUJ4H6piG11G3AX(object P_0)
	{
		return P_0.GetType();
	}

	internal static object tGFYk4J6udbgSWF24L8(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static void IowDwKJHIVlI3QMipLM(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static void EjRaLKJAMlTdC2Meq2c(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void Lx1wxsJ71to9pPbVeQe(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
