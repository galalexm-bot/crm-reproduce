using System;
using System.Collections.Generic;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.Managers;

internal class ModuleMetadataItemHeaderManager : EntityManager<ModuleMetadataItemHeader, long>
{
	internal static class _Resources_PropertyNames
	{
		public static readonly string Id;

		public static readonly string Uid;

		public static readonly string Name;

		public static readonly string DisplayName;

		public static readonly string CreationDate;

		public static readonly string CreationAuthorId;

		public static readonly string Draft;

		public static readonly string Published;

		internal static _Resources_PropertyNames k4eKqWCJV5tAgYrqPjCA;

		static _Resources_PropertyNames()
		{
			int num = 7;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 6:
						Id = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638434993);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num2 = 1;
						}
						continue;
					case 7:
						SingletonReader.JJCZtPuTvSt();
						num2 = 6;
						continue;
					case 3:
						Draft = (string)Yh928jCJRUTitmm0b4ZJ(0x92F12D5 ^ 0x92FBF29);
						num2 = 2;
						continue;
					case 5:
						CreationDate = (string)Yh928jCJRUTitmm0b4ZJ(0x637E299B ^ 0x637F7C35);
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 4;
						}
						continue;
					case 8:
						Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29233501);
						num2 = 9;
						continue;
					case 1:
						break;
					case 4:
						CreationAuthorId = (string)Yh928jCJRUTitmm0b4ZJ(0x5DD55050 ^ 0x5DD7A6B2);
						num2 = 3;
						continue;
					case 9:
						DisplayName = (string)Yh928jCJRUTitmm0b4ZJ(-1710575414 ^ -1710733698);
						num2 = 5;
						continue;
					case 2:
						Published = (string)Yh928jCJRUTitmm0b4ZJ(0x6A81B9B4 ^ 0x6A83C72E);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				Uid = (string)Yh928jCJRUTitmm0b4ZJ(-35995181 ^ -36000191);
				num = 8;
			}
		}

		internal static object Yh928jCJRUTitmm0b4ZJ(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool pCC5tXCJSVXRIJASdFVS()
		{
			return k4eKqWCJV5tAgYrqPjCA == null;
		}

		internal static _Resources_PropertyNames mVPBmuCJifppBSiYty11()
		{
			return k4eKqWCJV5tAgYrqPjCA;
		}
	}

	internal static Guid BuilderUiModuleUid;

	internal static readonly ISet<Guid> DesignerModules;

	internal static string WebDesignerPackageName;

	private static ModuleMetadataItemHeaderManager TjUbUdbziSrM4hcjtu1g;

	public new static ModuleMetadataItemHeaderManager Instance => Locator.GetServiceNotNull<ModuleMetadataItemHeaderManager>();

	public virtual bool ValidateName(long headerId, string name, out string errorMessage)
	{
		return ValidateName((ICriterion)AVNM1ubzKmV0xXHXHNDp(_Resources_PropertyNames.Id, headerId), name, out errorMessage);
	}

	public virtual bool ValidateName(Guid headerUid, string name, out string errorMessage)
	{
		return ValidateName((ICriterion)AVNM1ubzKmV0xXHXHNDp(_Resources_PropertyNames.Uid, headerUid), name, out errorMessage);
	}

	public virtual bool ValidateDisplayName(long headerId, string displayName, out string errorMessage)
	{
		return ValidateDisplayName((ICriterion)AVNM1ubzKmV0xXHXHNDp(_Resources_PropertyNames.Id, headerId), displayName, out errorMessage);
	}

	public virtual bool ValidateDisplayName(Guid headerUid, string displayName, out string errorMessage)
	{
		return ValidateDisplayName((ICriterion)AVNM1ubzKmV0xXHXHNDp(_Resources_PropertyNames.Uid, headerUid), displayName, out errorMessage);
	}

	public IEnumerable<ModuleMetadataItemHeader> GetAllPublished()
	{
		return CreateCriteria(new FetchOptions(0, 0)
		{
			FetchRelations = new List<string>
			{
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A31A95),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A623C82)
			}
		}, base.ImplementationType).Add((ICriterion)(object)Restrictions.IsNotNull(_Resources_PropertyNames.Published)).List<ModuleMetadataItemHeader>();
	}

	public override void Delete(ModuleMetadataItemHeader obj)
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			IList<ComponentMetadataItemHeader> enumeration;
			Action<ComponentMetadataItemHeader> action;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					base.Delete(obj);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 4:
					enumeration = ((ICriteria)B5WZJ4bznTpTCkYUCQFe(eTCja1bzXV4arygsEWTP(base.Session, InterfaceActivator.TypeOf<ComponentMetadataItemHeader>()), AVNM1ubzKmV0xXHXHNDp(FS84KubzTH5rP3C7P1RL(-2112703338 ^ -2112735846), IGDVMsbzk0junhH6KAoA(obj)))).List<ComponentMetadataItemHeader>();
					action = delegate(ComponentMetadataItemHeader h)
					{
						_003C_003Ec.YJZG7PCJkD8HZcEZTCwb(h);
					};
					goto end_IL_0012;
				case 3:
					((ICriteria)B5WZJ4bznTpTCkYUCQFe(base.Session.CreateCriteria(InterfaceActivator.TypeOf<DataClassMetadataItemHeader>()), AVNM1ubzKmV0xXHXHNDp(FS84KubzTH5rP3C7P1RL(-583745292 ^ -583777800), IGDVMsbzk0junhH6KAoA(obj)))).List<DataClassMetadataItemHeader>().ForEach(delegate(DataClassMetadataItemHeader h)
					{
						_003C_003Ec.YJZG7PCJkD8HZcEZTCwb(h);
					});
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					((ICriteria)B5WZJ4bznTpTCkYUCQFe(eTCja1bzXV4arygsEWTP(base.Session, InterfaceActivator.TypeOf<FunctionMetadataItemHeader>()), Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C0C777), (object)obj.Uid))).List<FunctionMetadataItemHeader>().ForEach(delegate(FunctionMetadataItemHeader h)
					{
						_003C_003Ec.YJZG7PCJkD8HZcEZTCwb(h);
					});
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 1;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			enumeration.ForEach(action);
			num = 3;
		}
	}

	protected virtual bool ValidateName(ICriterion compareCriterion, string name, out string errorMessage)
	{
		//Discarded unreachable code: IL_00f7, IL_0106, IL_0115
		int num = 10;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				errorMessage = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488852847));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				if (dskXLdbzOYn4AGh8ZTxn(name))
				{
					num2 = 6;
					break;
				}
				if (qX1aKrbz2giBGYPPqPwT(name))
				{
					num2 = 8;
					break;
				}
				goto case 4;
			case 1:
				return false;
			case 7:
				return false;
			case 4:
				errorMessage = (string)g1O1e4bzesqeKHjJq42v(FS84KubzTH5rP3C7P1RL(0xD3DEF7E ^ 0xD3D17E2));
				num2 = 2;
				break;
			case 3:
				return true;
			default:
				errorMessage = (string)g1O1e4bzesqeKHjJq42v(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76EDCF4));
				num2 = 7;
				break;
			case 2:
				return false;
			case 8:
				if (qXpqd1bztHNh1XgBejup(oyEAUZbzDVlveuj76AM2(sS8I6nbza7xx9juVas6B(B5WZJ4bznTpTCkYUCQFe(((ICriteria)vtF25ebzPW5sADjofuI6(this, null)).Add((ICriterion)Og4AyJbz1XAh5L2b3U9C(compareCriterion)), iHsmuwbz34LdTlaGPkwX(BrXv75bzNPjQlbtb6RVp(_Resources_PropertyNames.Name), name)), new IProjection[1] { (IProjection)YW79labzpeomysiqaM2A(_Resources_PropertyNames.Id) }))) > 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 10:
				Contract.ArgumentNotNull(compareCriterion, (string)FS84KubzTH5rP3C7P1RL(-2138160520 ^ -2138131634));
				num2 = 9;
				break;
			case 9:
				errorMessage = null;
				num2 = 5;
				break;
			}
		}
	}

	protected virtual bool ValidateDisplayName(ICriterion compareCriterion, string displayName, out string errorMessage)
	{
		//Discarded unreachable code: IL_00c8, IL_00d7
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				errorMessage = SR.T((string)FS84KubzTH5rP3C7P1RL(-1822890472 ^ -1822944068));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 4;
				}
				break;
			case 6:
				Xr4h2ObzwAP1QHiQkXBQ(compareCriterion, FS84KubzTH5rP3C7P1RL(-2138160520 ^ -2138131634));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (string.IsNullOrEmpty(displayName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 0;
					}
					break;
				}
				if (qXpqd1bztHNh1XgBejup(((ICriteria)sS8I6nbza7xx9juVas6B(B5WZJ4bznTpTCkYUCQFe(B5WZJ4bznTpTCkYUCQFe(vtF25ebzPW5sADjofuI6(this, null), Og4AyJbz1XAh5L2b3U9C(compareCriterion)), ElmaRestrictions.InsensitiveLike((IProjection)(object)Projections.Property(_Resources_PropertyNames.DisplayName), displayName)), new IProjection[1] { (IProjection)YW79labzpeomysiqaM2A(_Resources_PropertyNames.Id) })).UniqueResult()) > 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 5:
				errorMessage = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 3;
				}
				break;
			case 7:
				return false;
			case 2:
				return true;
			case 1:
				errorMessage = (string)g1O1e4bzesqeKHjJq42v(FS84KubzTH5rP3C7P1RL(0x7459E02 ^ 0x7456CC0));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 7;
				}
				break;
			case 4:
				return false;
			}
		}
	}

	public ModuleMetadataItemHeaderManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ModuleMetadataItemHeaderManager()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 1:
					JOmM0kbz49kL1fcbEfLV();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					WebDesignerPackageName = (string)FS84KubzTH5rP3C7P1RL(0x3A6135BE ^ 0x3A6229A6);
					num2 = 4;
					continue;
				default:
					BuilderUiModuleUid = new Guid((string)FS84KubzTH5rP3C7P1RL(-345420348 ^ -345357152));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					break;
				}
				break;
			}
			DesignerModules = new HashSet<Guid>
			{
				new Guid((string)FS84KubzTH5rP3C7P1RL(-629844702 ^ -629777262)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-787452571 ^ -787258215)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-576149596 ^ -575951380)),
				BuilderUiModuleUid,
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x8317432 ^ 0x8327EA6)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x53FA00CE ^ 0x53F90A2E)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x4A1640F ^ 0x4A26F23)),
				new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269D54B2)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-1978478350 ^ -1978541258)),
				new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97903546)),
				new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195812023)),
				new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53FA00B)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x1ECE530A ^ 0x1ECD5FFE)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-1876063057 ^ -1876000273)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-345420348 ^ -345358264)),
				new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EF18E7)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x76DD48E ^ 0x76EDAAA)),
				new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824455187)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-1852837372 ^ -1853031240)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-87337865 ^ -87532673)),
				new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1F11B0)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-675505729 ^ -675310049)),
				new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105265138)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-1765851862 ^ -1766052590)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x1C9495B4 ^ 0x1C978530)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x103FE975 ^ 0x103CF9A5)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x1ECE530A ^ 0x1ECD4216)),
				new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269D4EA2)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-867826612 ^ -867887624)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-70037984 ^ -70231008)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-1767720453 ^ -1767789641)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-1852837372 ^ -1853038436)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-538519530 ^ -538588430)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x42643203 ^ 0x42672133)),
				new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824450335)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x2A7797B7 ^ 0x2A74847F)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x4A1640F ^ 0x4A2701B)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x1A33FE36 ^ 0x1A30EA56)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-420743386 ^ -420945014)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-1426094279 ^ -1426287679)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-1217523399 ^ -1217592195)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x12441CA4 ^ 0x12470934)),
				new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C353A7)),
				new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108040650)),
				new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76EC2FA)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x4D1C1EE4 ^ 0x4D1F0824)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x1FFEF86A ^ 0x1FFDEF66)),
				new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C502FA7)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x4785BC0D ^ 0x4786ABA9)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x571EA399 ^ 0x571DB469)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x10E41EDB ^ 0x10E706E7)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x3A6135BE ^ 0x3A622D36)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x35C0467B ^ 0x35C35EAF)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-583745292 ^ -583542316)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-541731959 ^ -541668635)),
				new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218556394)),
				new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099557037)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-1710575414 ^ -1710642534)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x5F3078B6 ^ 0x5F33622A)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(0x4EA5403C ^ 0x4EA65AD4)),
				new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103CF241)),
				new Guid((string)FS84KubzTH5rP3C7P1RL(-1765851862 ^ -1766054230)),
				new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886448061))
			};
			num = 3;
		}
	}

	internal static object AVNM1ubzKmV0xXHXHNDp(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static bool PdHWunbzRwrW5tU0nN8i()
	{
		return TjUbUdbziSrM4hcjtu1g == null;
	}

	internal static ModuleMetadataItemHeaderManager kEeE50bzq0rXIMpt4IgP()
	{
		return TjUbUdbziSrM4hcjtu1g;
	}

	internal static object eTCja1bzXV4arygsEWTP(object P_0, Type P_1)
	{
		return ((ISession)P_0).CreateCriteria(P_1);
	}

	internal static object FS84KubzTH5rP3C7P1RL(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Guid IGDVMsbzk0junhH6KAoA(object P_0)
	{
		return ((ModuleMetadataItemHeader)P_0).Uid;
	}

	internal static object B5WZJ4bznTpTCkYUCQFe(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static bool dskXLdbzOYn4AGh8ZTxn(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool qX1aKrbz2giBGYPPqPwT(object P_0)
	{
		return ((string)P_0).IsValidIdentifier();
	}

	internal static object g1O1e4bzesqeKHjJq42v(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object vtF25ebzPW5sADjofuI6(object P_0, object P_1)
	{
		return ((EntityManager<ModuleMetadataItemHeader, long>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static object Og4AyJbz1XAh5L2b3U9C(object P_0)
	{
		return Restrictions.Not((ICriterion)P_0);
	}

	internal static object BrXv75bzNPjQlbtb6RVp(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static object iHsmuwbz34LdTlaGPkwX(object P_0, object P_1)
	{
		return ElmaRestrictions.InsensitiveLike((IProjection)P_0, P_1);
	}

	internal static object YW79labzpeomysiqaM2A(object P_0)
	{
		return Projections.Count((string)P_0);
	}

	internal static object sS8I6nbza7xx9juVas6B(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetProjection((IProjection[])P_1);
	}

	internal static object oyEAUZbzDVlveuj76AM2(object P_0)
	{
		return ((ICriteria)P_0).UniqueResult();
	}

	internal static long qXpqd1bztHNh1XgBejup(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static void Xr4h2ObzwAP1QHiQkXBQ(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void JOmM0kbz49kL1fcbEfLV()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
