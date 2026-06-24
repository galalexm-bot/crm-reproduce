using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files;

[Service(Type = ComponentType.Server)]
public class SystemFileNHManager : NHManager
{
	internal static SystemFileNHManager JZ85S2GTYOu53EFS9COG;

	[Transaction]
	public virtual int InsertFile(SystemFile binaryFile)
	{
		//Discarded unreachable code: IL_004b, IL_00af, IL_00ed, IL_00fc
		int result = default(int);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				InsertFileIntoContext(binaryFile);
				int num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return result;
					case 0:
						return result;
					case 1:
						result = (int)RYGApuGTsM98XwtKNkjK(base.Session, binaryFile);
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num = 0;
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						throw;
					}
					QPCx25GTzX4jdyXMTX0Z(tjCrHTGTcSSGPy7tPPJd(), ex);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 1;
					}
				}
			}
		}
	}

	[Transaction]
	public virtual SystemFile RenameFile(int id, string fileName)
	{
		//Discarded unreachable code: IL_0041, IL_00b3, IL_0159, IL_0197, IL_01a6, IL_01db, IL_01ea
		int num = 2;
		int num2 = num;
		SystemFile result = default(SystemFile);
		while (true)
		{
			switch (num2)
			{
			case 4:
				throw new ArgumentOutOfRangeException((string)fOvkjAGkBu4ufEtrg2PV(-1638402543 ^ -1638430709), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882364290));
			case 7:
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 5;
				}
				break;
			case 3:
				return result;
			case 5:
				try
				{
					SystemFile systemFile = (SystemFile)TepYHKGkW8LWDYbt095h(this, id);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							return result;
						case 1:
							base.Session.Update((object)systemFile);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
							{
								num3 = 3;
							}
							break;
						default:
							TMfQJKGkohQI7l9HtFI0(systemFile, fileName);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
							{
								num3 = 1;
							}
							break;
						case 3:
							result = systemFile;
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							throw;
						}
						QPCx25GTzX4jdyXMTX0Z(tjCrHTGTcSSGPy7tPPJd(), ex);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num4 = 1;
						}
					}
				}
			case 2:
				if (!muPsZBGkFm0fmvkChjbD(fileName))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 6:
				if (!string.IsNullOrWhiteSpace(fileName))
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 4;
			default:
				throw new ArgumentOutOfRangeException((string)fOvkjAGkBu4ufEtrg2PV(0x61EC0CB8 ^ 0x61EC72A2), (string)fOvkjAGkBu4ufEtrg2PV(-1751176224 ^ -1751332064));
			case 1:
				fileName = TrimFileNameSpecialChars(fileName);
				num2 = 6;
				break;
			}
		}
	}

	[Transaction]
	public virtual SystemFile RenameFile(Guid uid, string fileName)
	{
		//Discarded unreachable code: IL_00c4, IL_01b0, IL_01ee
		int num = 2;
		int num2 = num;
		SystemFile result = default(SystemFile);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (muPsZBGkFm0fmvkChjbD(fileName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 3;
					}
				}
				break;
			default:
				throw new ArgumentOutOfRangeException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921205799), (string)fOvkjAGkBu4ufEtrg2PV(0x49E27B8A ^ 0x49E19A96));
			case 3:
				try
				{
					SystemFile systemFile = (SystemFile)q0PNSKGkhQR04W49pdSX(this, uid);
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num3 = 4;
					}
					while (true)
					{
						switch (num3)
						{
						case 4:
							if (systemFile == null)
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
								{
									num3 = 0;
								}
								break;
							}
							TMfQJKGkohQI7l9HtFI0(systemFile, fileName);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
							{
								num3 = 1;
							}
							break;
						case 2:
							result = systemFile;
							num3 = 3;
							break;
						default:
							throw new Exception(SR.T((string)fOvkjAGkBu4ufEtrg2PV(-1217523399 ^ -1217531835), uid.ToString()));
						case 1:
							llqBJ2GkG3ZhW1N0Jcxf(base.Session, systemFile);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
							{
								num3 = 2;
							}
							break;
						case 3:
							return result;
						}
					}
				}
				catch (Exception message)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							((ILogger)tjCrHTGTcSSGPy7tPPJd()).Error(message);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
							{
								num4 = 0;
							}
							break;
						default:
							throw;
						}
					}
				}
			case 2:
				if (muPsZBGkFm0fmvkChjbD(fileName))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 1;
					}
					break;
				}
				fileName = (string)bYdaGLGkbSFUTG3FCB9f(fileName);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				throw new ArgumentOutOfRangeException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53CD2B9), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767810757));
			case 5:
				return result;
			}
		}
	}

	private static string TrimFileNameSpecialChars(object fileName)
	{
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				text = (string)GvV2gYGkflPs81yS1RPH(new string((char[])NGNPTlGkEZZ659vF6ZhD()), new string(Path.GetInvalidPathChars()));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				fileName = oGNV9UGkvAn8N8NxXv0E(fileName, PCdkNuGkCkOeK90CJIfr(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939363826), fB4ZRPGkQvdlkYkwgHJu(text)), "");
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)fileName;
			}
		}
	}

	public virtual SystemFile LoadFile(int id)
	{
		//Discarded unreachable code: IL_0070, IL_007f
		int num = 2;
		int num2 = num;
		string text = default(string);
		SystemFile value = default(SystemFile);
		while (true)
		{
			switch (num2)
			{
			case 2:
				text = (string)PCdkNuGkCkOeK90CJIfr(fOvkjAGkBu4ufEtrg2PV(-1852837372 ^ -1853090882), id);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return value;
			case 1:
				if (!ContextVars.TryGetValue<SystemFile>(text, out value))
				{
					num2 = 5;
					break;
				}
				goto default;
			case 4:
				InsertFileIntoContext(value, text);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 3;
				}
				break;
			default:
				return value;
			case 5:
				value = base.Session.Get<SystemFile>((object)id);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	public virtual SystemFile LoadFile(Guid uid)
	{
		//Discarded unreachable code: IL_00e9
		int num = 3;
		int num2 = num;
		SystemFile value = default(SystemFile);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return value;
			case 5:
				value = ((ICriteria)bOjQX8GkuYhtL4AmK6Eu(ilgmW2GkZ5XbLco1N29r(base.Session.CreateCriteria<SystemFile>(), XXJRi5Gk8gJVwJWfTklM(fOvkjAGkBu4ufEtrg2PV(0x68BBB53E ^ 0x68BBDAAC), uid)), 1)).SetCacheable(true).UniqueResult<SystemFile>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				InsertFileIntoContext(value, null, text);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return value;
			case 3:
				text = (string)PCdkNuGkCkOeK90CJIfr(fOvkjAGkBu4ufEtrg2PV(-1638402543 ^ -1638656085), uid);
				num2 = 2;
				break;
			case 2:
				if (!ContextVars.TryGetValue<SystemFile>(text, out value))
				{
					num2 = 5;
					break;
				}
				goto case 4;
			}
		}
	}

	public virtual SystemFile LoadFile(string id)
	{
		//Discarded unreachable code: IL_0062, IL_0071
		int num = 5;
		int num2 = num;
		int result = default(int);
		Guid result2 = default(Guid);
		while (true)
		{
			switch (num2)
			{
			default:
				return (SystemFile)TepYHKGkW8LWDYbt095h(this, result);
			case 4:
				if (Guid.TryParse(id, out result2))
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 1:
				if (!int.TryParse(id, out result))
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 3:
				throw new ArgumentException((string)ILG1pjGkIrqZxSN6sBK2(fOvkjAGkBu4ufEtrg2PV(0x1C9495B4 ^ 0x1C953F46)));
			case 2:
				if (result2 != Guid.Empty)
				{
					return LoadFile(result2);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				result = 0;
				num2 = 4;
				break;
			}
		}
	}

	public virtual SystemFile[] LoadFiles(long[] idLong, Guid[] uids)
	{
		//Discarded unreachable code: IL_00f6, IL_0105, IL_017f, IL_018e, IL_019e, IL_01ad, IL_01d1, IL_01e0, IL_01f0, IL_0223, IL_0232, IL_0276, IL_0296
		int num = 5;
		AbstractCriterion val = default(AbstractCriterion);
		AbstractCriterion val3 = default(AbstractCriterion);
		ICriteria val2 = default(ICriteria);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 14:
					val = (AbstractCriterion)x6eaFcGkVWB5G9FnS1fJ(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FFA4CB), uids);
					num2 = 11;
					continue;
				case 10:
					if (uids.Length == 0)
					{
						num2 = 13;
						continue;
					}
					goto case 21;
				case 4:
					val3 = (AbstractCriterion)x6eaFcGkVWB5G9FnS1fJ(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824355645), idLong);
					num2 = 14;
					continue;
				case 9:
					if (uids != null)
					{
						num2 = 10;
						continue;
					}
					goto case 6;
				case 11:
					if (idLong != null)
					{
						num2 = 2;
						continue;
					}
					goto case 6;
				case 5:
					break;
				case 21:
					val2.Add((ICriterion)C4tanNGkSU9kyn6PwWn8(val3, val));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 20;
					}
					continue;
				case 7:
				case 16:
				case 23:
					return new SystemFile[0];
				case 17:
				case 19:
				case 20:
					return val2.List<SystemFile>().ToArray();
				default:
					if (uids == null)
					{
						num2 = 16;
						continue;
					}
					goto case 1;
				case 8:
					val2.Add((ICriterion)(object)val);
					num2 = 17;
					continue;
				case 18:
					ilgmW2GkZ5XbLco1N29r(val2, val3);
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 18;
					}
					continue;
				case 1:
					if (uids.Length == 0)
					{
						num2 = 7;
						continue;
					}
					goto case 8;
				case 6:
				case 12:
				case 13:
					if (idLong == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 22;
				case 2:
					if (idLong.Length == 0)
					{
						num2 = 6;
						continue;
					}
					goto case 9;
				case 22:
					if (idLong.Length == 0)
					{
						num2 = 3;
						continue;
					}
					goto case 18;
				}
				break;
			}
			val2 = base.Session.CreateCriteria<SystemFile>();
			num = 4;
		}
	}

	private void InsertFileIntoContext(SystemFile file, string idKey = null, string uidKey = null)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					idKey = (string)PCdkNuGkCkOeK90CJIfr(fOvkjAGkBu4ufEtrg2PV(0x638095EB ^ 0x63837451), oELs9UGkiDnJTTqBFY4T(file));
					num2 = 4;
					break;
				default:
					ContextVars.Set(uidKey, file);
					num2 = 6;
					break;
				case 6:
					return;
				case 7:
					ContextVars.Set(idKey, file);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					if (muPsZBGkFm0fmvkChjbD(uidKey))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 7;
				case 1:
					if (string.IsNullOrWhiteSpace(idKey))
					{
						goto end_IL_0012;
					}
					goto case 4;
				case 3:
					uidKey = (string)PCdkNuGkCkOeK90CJIfr(fOvkjAGkBu4ufEtrg2PV(--1418440330 ^ 0x54884F30), FPHbbrGkRhfHLI8aV2S9(file));
					num2 = 7;
					break;
				case 2:
					if (file == null)
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 1;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public SystemFileNHManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gZHkFoGkqXOAjThpTyjM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object RYGApuGTsM98XwtKNkjK(object P_0, object P_1)
	{
		return ((ISession)P_0).Save(P_1);
	}

	internal static object tjCrHTGTcSSGPy7tPPJd()
	{
		return Logger.Log;
	}

	internal static void QPCx25GTzX4jdyXMTX0Z(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static bool CGKDRQGTLOjTHQ5qK9DZ()
	{
		return JZ85S2GTYOu53EFS9COG == null;
	}

	internal static SystemFileNHManager lgL3ssGTUTQ9F02mQBL7()
	{
		return JZ85S2GTYOu53EFS9COG;
	}

	internal static bool muPsZBGkFm0fmvkChjbD(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object fOvkjAGkBu4ufEtrg2PV(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object TepYHKGkW8LWDYbt095h(object P_0, int id)
	{
		return ((SystemFileNHManager)P_0).LoadFile(id);
	}

	internal static void TMfQJKGkohQI7l9HtFI0(object P_0, object P_1)
	{
		((SystemFile)P_0).Name = (string)P_1;
	}

	internal static object bYdaGLGkbSFUTG3FCB9f(object P_0)
	{
		return TrimFileNameSpecialChars(P_0);
	}

	internal static object q0PNSKGkhQR04W49pdSX(object P_0, Guid uid)
	{
		return ((SystemFileNHManager)P_0).LoadFile(uid);
	}

	internal static void llqBJ2GkG3ZhW1N0Jcxf(object P_0, object P_1)
	{
		((ISession)P_0).Update(P_1);
	}

	internal static object NGNPTlGkEZZ659vF6ZhD()
	{
		return Path.GetInvalidFileNameChars();
	}

	internal static object GvV2gYGkflPs81yS1RPH(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object fB4ZRPGkQvdlkYkwgHJu(object P_0)
	{
		return Regex.Escape((string)P_0);
	}

	internal static object PCdkNuGkCkOeK90CJIfr(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object oGNV9UGkvAn8N8NxXv0E(object P_0, object P_1, object P_2)
	{
		return Regex.Replace((string)P_0, (string)P_1, (string)P_2);
	}

	internal static object XXJRi5Gk8gJVwJWfTklM(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object ilgmW2GkZ5XbLco1N29r(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object bOjQX8GkuYhtL4AmK6Eu(object P_0, int P_1)
	{
		return ((ICriteria)P_0).SetFetchSize(P_1);
	}

	internal static object ILG1pjGkIrqZxSN6sBK2(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object x6eaFcGkVWB5G9FnS1fJ(object P_0, object P_1)
	{
		return Restrictions.In((string)P_0, (ICollection)P_1);
	}

	internal static object C4tanNGkSU9kyn6PwWn8(object P_0, object P_1)
	{
		return Restrictions.Or((ICriterion)P_0, (ICriterion)P_1);
	}

	internal static int oELs9UGkiDnJTTqBFY4T(object P_0)
	{
		return ((SystemFile)P_0).Id;
	}

	internal static Guid FPHbbrGkRhfHLI8aV2S9(object P_0)
	{
		return ((SystemFile)P_0).Uid;
	}

	internal static void gZHkFoGkqXOAjThpTyjM()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
