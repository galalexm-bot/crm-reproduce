using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Serialization;

internal sealed class ReferenceResolver : IReferenceResolver
{
	private int referenceCount;

	private readonly BidirectionalDictionary<string, object> mappings;

	private readonly IDictionary<Guid, ISet<object>> mappingsWithMetadata;

	private static ReferenceResolver JmW1uBB9o6CNRIWwLgS2;

	public object ResolveReference(string reference)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass3_._003C_003E4__this = this;
				num2 = 3;
				break;
			default:
				return new Func<object>(_003C_003Ec__DisplayClass3_._003CResolveReference_003Eb__0);
			case 4:
			{
				if (mappings.TryGetByFirst(_003C_003Ec__DisplayClass3_.reference, out var second))
				{
					return second;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 2:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass3_.reference = reference;
				num2 = 4;
				break;
			}
		}
	}

	public void AddReference(string reference, object value)
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
				Set(reference, value);
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

	public bool TryGetReference(object value, IMetadata metadata, out string reference)
	{
		//Discarded unreachable code: IL_00ce, IL_01d2
		int num = 1;
		ISet<object> value2 = default(ISet<object>);
		ISet<object> set2 = default(ISet<object>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					if (metadata != null)
					{
						num2 = 11;
						continue;
					}
					goto case 3;
				case 15:
					value2.Add(value);
					num = 8;
					break;
				case 1:
					reference = "";
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
					value2 = set2;
					num = 3;
					break;
				case 5:
					return false;
				case 7:
					value2 = new HashSet<object>();
					num2 = 10;
					continue;
				case 11:
					if (!mappingsWithMetadata.TryGetValue(GIQf3vB9G0IkM4Jf10vS(metadata), out value2))
					{
						num2 = 6;
						continue;
					}
					goto case 3;
				case 13:
					Set(reference, value);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 15;
					}
					continue;
				case 12:
				{
					if (!mappings.TryGetBySecond(value, out var _))
					{
						num2 = 13;
						continue;
					}
					goto case 15;
				}
				default:
					if (value != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 5;
				case 4:
					referenceCount++;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 7;
					}
					continue;
				case 3:
					if (TryGetByValue(value, metadata, out reference))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 4;
				case 6:
					set2 = (mappingsWithMetadata[metadata.Uid] = new HashSet<object>());
					num2 = 14;
					continue;
				case 9:
					reference = referenceCount.ToString();
					num2 = 12;
					continue;
				case 8:
					return false;
				case 2:
					return true;
				}
				break;
			}
		}
	}

	private void Set(string key, object value)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 2;
		int num2 = num;
		object second = default(object);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				if (mappings.TryGetByFirst(key, out second))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 1;
					}
					break;
				}
				mappings.Set(key, value);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				throw new ArgumentException(SR.T((string)uuLeAoB9E5h15ggfMrUN(-1886646897 ^ -1886559893), key));
			case 1:
				if (second.Equals(value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 3:
				return;
			}
		}
	}

	private bool TryGetByValue(object value, IMetadata metadata, out string key)
	{
		//Discarded unreachable code: IL_009c, IL_00ab, IL_00d5, IL_00e4, IL_0113
		int num = 6;
		ISet<object> value2 = default(ISet<object>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return false;
				case 8:
					return true;
				case 7:
					if (!mappingsWithMetadata.TryGetValue(metadata.Uid, out value2))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num2 = 4;
						}
						break;
					}
					if (value2 != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return false;
				case 3:
					if (value2.Contains(value))
					{
						num2 = 8;
						break;
					}
					goto case 1;
				default:
					if (uL0oICB9fBHKs3Zvd982(value2) != 0)
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 6:
					key = null;
					num2 = 5;
					break;
				case 10:
					return false;
				case 4:
				case 9:
					return false;
				case 5:
					if (mappings.TryGetBySecond(value, out key))
					{
						if (metadata == null)
						{
							num2 = 9;
							break;
						}
						goto case 7;
					}
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 10;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public ReferenceResolver()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		FAmTteB9QZIMtINxNEnf();
		mappings = new BidirectionalDictionary<string, object>();
		mappingsWithMetadata = new Dictionary<Guid, ISet<object>>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool AjDbkXB9bfS8kZyA228j()
	{
		return JmW1uBB9o6CNRIWwLgS2 == null;
	}

	internal static ReferenceResolver twM4qOB9hTtwB81eOk7D()
	{
		return JmW1uBB9o6CNRIWwLgS2;
	}

	internal static Guid GIQf3vB9G0IkM4Jf10vS(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static object uuLeAoB9E5h15ggfMrUN(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static int uL0oICB9fBHKs3Zvd982(object P_0)
	{
		return ((ICollection<object>)P_0).Count;
	}

	internal static void FAmTteB9QZIMtINxNEnf()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
