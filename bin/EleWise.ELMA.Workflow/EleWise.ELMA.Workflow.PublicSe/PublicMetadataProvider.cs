using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services.Public;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.PublicService;

[Component(EnableInterceptiors = false)]
internal class PublicMetadataProvider : IPublicMetadataProvider
{
	internal class ProcessesGroupInfo : IPublicMetadataGroupInfo
	{
		public static readonly Guid UID;

		private static ProcessesGroupInfo fwjCuZZjRrSHqgE5F9MZ;

		public Guid GroupUid => UID;

		public int Order => 100;

		public string DisplayName => (string)YayqUHZjTSS6npOGTt41(ErNdXsZj3ZXNICMwpNv2(0x37E97159 ^ 0x37E97B9B));

		public ProcessesGroupInfo()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			qqyFUeZjQLbqbY4HragI();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static ProcessesGroupInfo()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					qqyFUeZjQLbqbY4HragI();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 1:
					UID = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6EB2F6));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static object ErNdXsZj3ZXNICMwpNv2(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object YayqUHZjTSS6npOGTt41(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool sC2JMyZj6NObdXeOwWTJ()
		{
			return fwjCuZZjRrSHqgE5F9MZ == null;
		}

		internal static ProcessesGroupInfo gBVR5iZjqf6fQMORwYKV()
		{
			return fwjCuZZjRrSHqgE5F9MZ;
		}

		internal static void qqyFUeZjQLbqbY4HragI()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	private readonly ITransformationProvider transformationProvider;

	private readonly string findRootsQuery;

	private readonly string findChildrenQuery;

	internal static PublicMetadataProvider sIG0WxbooeCKHyDoa2V;

	public PublicMetadataProvider(ITransformationProvider transformationProvider)
	{
		//Discarded unreachable code: IL_001a
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 8;
		string text13 = default(string);
		string text11 = default(string);
		string text12 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		string text2 = default(string);
		string text6 = default(string);
		string text7 = default(string);
		string text8 = default(string);
		string text9 = default(string);
		string text10 = default(string);
		string text = default(string);
		string text3 = default(string);
		while (true)
		{
			switch (num)
			{
			case 14:
				text13 = (string)aKwq32br01Xim1aLkVO(SnF43bbIK6VJL3moWHx(transformationProvider), IiupAAbaOvvJCCukaXR(-708128192 ^ -708143888));
				num = 16;
				break;
			case 10:
				text11 = (string)aKwq32br01Xim1aLkVO(transformationProvider.Dialect, IiupAAbaOvvJCCukaXR(-420003255 ^ -420018867));
				num = 11;
				break;
			case 1:
				text12 = (string)aKwq32br01Xim1aLkVO(transformationProvider.Dialect, IiupAAbaOvvJCCukaXR(0x7AC609FE ^ 0x7AC64F3E));
				num = 5;
				break;
			case 13:
				findChildrenQuery = (string)enFq1lbeVZaW9dvCZ0b(new string[37]
				{
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x1019629),
					text4,
					(string)IiupAAbaOvvJCCukaXR(0x246EEF98 ^ 0x246EA8D8),
					text5,
					(string)IiupAAbaOvvJCCukaXR(0x6C7F14 ^ 0x6C3854),
					text2,
					(string)IiupAAbaOvvJCCukaXR(0x42311138 ^ 0x42315674),
					text6,
					(string)IiupAAbaOvvJCCukaXR(0x1843E01F ^ 0x1843A753),
					text7,
					(string)IiupAAbaOvvJCCukaXR(0x1134D2C0 ^ 0x1134959A),
					text7,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x141C968 ^ 0x1418E00),
					text8,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2111219045 ^ -2111234591),
					text9,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720439553),
					text10,
					(string)IiupAAbaOvvJCCukaXR(-10408775 ^ -10392821),
					text,
					(string)IiupAAbaOvvJCCukaXR(0x1C663DA1 ^ 0x1C667A63),
					text11,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1574607501 ^ -1574624621),
					text3,
					(string)IiupAAbaOvvJCCukaXR(-768800937 ^ -768786271),
					text,
					(string)IiupAAbaOvvJCCukaXR(-935313063 ^ -935328101),
					text9,
					(string)IiupAAbaOvvJCCukaXR(-947937941 ^ -947923603),
					text10,
					(string)IiupAAbaOvvJCCukaXR(0x4940763B ^ 0x49403E25),
					text,
					(string)IiupAAbaOvvJCCukaXR(-495296780 ^ -495315238),
					text12,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-432000546 ^ -431982184),
					text13,
					(string)IiupAAbaOvvJCCukaXR(-935313063 ^ -935327443)
				});
				num = 9;
				break;
			case 3:
				text8 = transformationProvider.Dialect.QuoteIfNeeded((string)IiupAAbaOvvJCCukaXR(0x213F6477 ^ 0x213F2291));
				num = 10;
				break;
			case 15:
				text4 = (string)aKwq32br01Xim1aLkVO(SnF43bbIK6VJL3moWHx(transformationProvider), IiupAAbaOvvJCCukaXR(-947937941 ^ -947921939));
				num = 4;
				break;
			case 8:
				this.transformationProvider = transformationProvider;
				num = 2;
				break;
			case 16:
				text10 = ((Dialect)SnF43bbIK6VJL3moWHx(transformationProvider)).QuoteIfNeeded((string)IiupAAbaOvvJCCukaXR(-2057730233 ^ -2057725985));
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
				{
					num = 0;
				}
				break;
			case 9:
				return;
			case 5:
				text9 = (string)aKwq32br01Xim1aLkVO(SnF43bbIK6VJL3moWHx(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56F860D7 ^ 0x56F82607));
				num = 3;
				break;
			case 2:
				text7 = (string)aKwq32br01Xim1aLkVO(SnF43bbIK6VJL3moWHx(transformationProvider), IiupAAbaOvvJCCukaXR(0x13F63440 ^ 0x13F6723C));
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d != 0)
				{
					num = 0;
				}
				break;
			case 11:
			{
				findRootsQuery = (string)IiupAAbaOvvJCCukaXR(0x1C7F6FED ^ 0x1C7F28CB) + text4 + (string)IiupAAbaOvvJCCukaXR(0x614CF569 ^ 0x614CB229) + text5 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-432000546 ^ -431982946) + text2 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1393917570) + text6 + (string)IiupAAbaOvvJCCukaXR(--1212129906 ^ 0x483FE53E) + text7 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418337216 ^ 0x548A5C9A) + text7 + (string)IiupAAbaOvvJCCukaXR(0x246EEF98 ^ 0x246EA8F0) + text8 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F534A5C ^ 0x5F530D26) + text9 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25693066) + text10 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56F860D7 ^ 0x56F82765) + text + (string)IiupAAbaOvvJCCukaXR(0x738ABA6E ^ 0x738AFDAC) + text11 + (string)IiupAAbaOvvJCCukaXR(-1386448964 ^ -1386467236) + text3 + (string)IiupAAbaOvvJCCukaXR(0xD305CC2 ^ 0xD301B34) + text + (string)IiupAAbaOvvJCCukaXR(-1514166050 ^ -1514148068) + text9 + (string)IiupAAbaOvvJCCukaXR(-39189604 ^ -39171174) + text10 + (string)IiupAAbaOvvJCCukaXR(0x141C968 ^ 0x1418176) + text + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-949717965 ^ -949732323) + text12 + (string)IiupAAbaOvvJCCukaXR(-25709590 ^ -25691220) + text13 + (string)IiupAAbaOvvJCCukaXR(-1574607501 ^ -1574621933);
				int num2 = 13;
				num = num2;
				break;
			}
			case 4:
				text5 = (string)aKwq32br01Xim1aLkVO(SnF43bbIK6VJL3moWHx(transformationProvider), IiupAAbaOvvJCCukaXR(0x614274E3 ^ 0x6142329F));
				num = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
				{
					num = 6;
				}
				break;
			case 6:
				text6 = (string)aKwq32br01Xim1aLkVO(SnF43bbIK6VJL3moWHx(transformationProvider), IiupAAbaOvvJCCukaXR(0x614CF569 ^ 0x614CB3E7));
				num = 12;
				break;
			case 7:
				text3 = (string)aKwq32br01Xim1aLkVO(SnF43bbIK6VJL3moWHx(transformationProvider), IiupAAbaOvvJCCukaXR(0x361628FF ^ 0x36166E65));
				num = 14;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
				{
					num = 5;
				}
				break;
			case 12:
				text2 = (string)aKwq32br01Xim1aLkVO(SnF43bbIK6VJL3moWHx(transformationProvider), IiupAAbaOvvJCCukaXR(0x5F534A5C ^ 0x5F530CD2));
				num = 7;
				break;
			default:
				text = (string)aKwq32br01Xim1aLkVO(SnF43bbIK6VJL3moWHx(transformationProvider), IiupAAbaOvvJCCukaXR(-772614310 ^ -772632100));
				num = 15;
				break;
			}
		}
	}

	public IEnumerable<IPublicMetadataInfo> GetMetadataInfoList()
	{
		List<IPublicMetadataInfo> list = new List<IPublicMetadataInfo>();
		List<long> list2 = new List<long>();
		using (IDataReader dataReader = transformationProvider.ExecuteQuery(findRootsQuery))
		{
			while (dataReader.Read())
			{
				long @int = dataReader.GetInt64(0);
				IPublicMetadataInfo metadataInfo = GetMetadataInfo(dataReader);
				list.Add(metadataInfo);
				list2.Add(@int);
			}
		}
		while (list2.Count > 0)
		{
			_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.parameters = new Dictionary<string, object>();
			string arg = string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1393914184), list2.Take(100).Select(delegate(long id, int index)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						CS_0024_003C_003E8__locals0.parameters[(string)_003C_003Ec__DisplayClass5_0.GXbSUgZjUrtcw1j4BHCO(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1647793954 ^ -1647794332), index)] = id;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
						{
							num2 = 0;
						}
						break;
					default:
						return string.Concat(CS_0024_003C_003E8__locals0._003C_003E4__this.transformationProvider.ParameterSeparator, _003C_003Ec__DisplayClass5_0.n4vFHMZjVwnXs7OVLa2p(0x157D5AF4 ^ 0x157D554E), index);
					}
				}
			}));
			list2.RemoveRange(0, Math.Min(100, list2.Count));
			using IDataReader dataReader2 = transformationProvider.ExecuteQuery(string.Format(findChildrenQuery, arg), CS_0024_003C_003E8__locals0.parameters);
			while (dataReader2.Read())
			{
				long int2 = dataReader2.GetInt64(0);
				IPublicMetadataInfo metadataInfo2 = GetMetadataInfo(dataReader2);
				list.Add(metadataInfo2);
				list2.Add(int2);
			}
		}
		return list;
	}

	private IPublicMetadataInfo GetMetadataInfo(IDataReader reader)
	{
		return new ProcessContextMetadataInfo(pN4hS6bNGBdMhDElRqh(SnF43bbIK6VJL3moWHx(transformationProvider), reader[1]), (string)Da9DiRbxHokZafAanFc(reader, 2), (string)Da9DiRbxHokZafAanFc(reader, 3), pN4hS6bNGBdMhDElRqh(transformationProvider.Dialect, OiZft2bSYy0HaPpBEVp(reader, 4)), pN4hS6bNGBdMhDElRqh(SnF43bbIK6VJL3moWHx(transformationProvider), reader[5]));
	}

	public IEnumerable<IPublicMetadataGroupInfo> GetGroups()
	{
		return new IPublicMetadataGroupInfo[1]
		{
			new ProcessesGroupInfo()
		};
	}

	internal static object SnF43bbIK6VJL3moWHx(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object IiupAAbaOvvJCCukaXR(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object aKwq32br01Xim1aLkVO(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object enFq1lbeVZaW9dvCZ0b(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static bool ok9ICdbFjDNSLxsd0RU()
	{
		return sIG0WxbooeCKHyDoa2V == null;
	}

	internal static PublicMetadataProvider UpeKJKbiNiCm4o6dN5U()
	{
		return sIG0WxbooeCKHyDoa2V;
	}

	internal static Guid pN4hS6bNGBdMhDElRqh(object P_0, object P_1)
	{
		return ((Dialect)P_0).GetGuid(P_1);
	}

	internal static object Da9DiRbxHokZafAanFc(object P_0, int P_1)
	{
		return ((IDataRecord)P_0).GetString(P_1);
	}

	internal static object OiZft2bSYy0HaPpBEVp(object P_0, int P_1)
	{
		return ((IDataRecord)P_0)[P_1];
	}
}
