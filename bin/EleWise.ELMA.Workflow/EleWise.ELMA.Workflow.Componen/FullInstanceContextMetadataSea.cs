using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component(Order = 1)]
public class FullInstanceContextMetadataSearcher : IEntityMetadataSearcher
{
	private readonly IWorkflowMetadataLoaderService workflowMetadataLoaderService;

	private readonly WorkflowProcessManager workflowProcessManager;

	private readonly ITransformationProvider transformationProvider;

	private ConcurrentDictionary<string, long?> headerIds;

	private long checkCount;

	private EntityMetadata[] entityMetadataList;

	private readonly string findByNameQuery;

	private readonly string findByNameQuery2Format;

	private readonly string metadataListQuery;

	private readonly string metadataListQuery2Format;

	private readonly string findPropertiesByUidQuery1;

	private readonly string findPropertiesByUidQuery2;

	internal static FullInstanceContextMetadataSearcher xED4HkOsTVrhGfu17dZa;

	public string DisplayName => SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398691253 ^ -398688631));

	public FullInstanceContextMetadataSearcher(IWorkflowMetadataLoaderService workflowMetadataLoaderService, WorkflowProcessManager workflowProcessManager, ITransformationProvider transformationProvider)
	{
		//Discarded unreachable code: IL_002a
		ycPXFvOsCmvs25wIQnkq();
		headerIds = new ConcurrentDictionary<string, long?>();
		base._002Ector();
		int num = 27;
		string text5 = default(string);
		string text19 = default(string);
		string text10 = default(string);
		string text9 = default(string);
		string text16 = default(string);
		string text8 = default(string);
		string text = default(string);
		string text2 = default(string);
		string text11 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text17 = default(string);
		string text14 = default(string);
		string text13 = default(string);
		string text7 = default(string);
		string text18 = default(string);
		string text6 = default(string);
		string text15 = default(string);
		string text12 = default(string);
		while (true)
		{
			switch (num)
			{
			case 23:
				text5 = (string)Ypjrp7OsU6W4vJDkmWce(transformationProvider.Dialect, ccKFZnOskUjgKLmLO26m(0x157D5AF4 ^ 0x157D4A6C));
				num = 5;
				break;
			case 5:
				text19 = (string)Ypjrp7OsU6W4vJDkmWce(rUmxf9OsMkCfdLNB6EQl(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1214182792 ^ -1214149280));
				num = 18;
				break;
			case 16:
				text10 = (string)Ypjrp7OsU6W4vJDkmWce(rUmxf9OsMkCfdLNB6EQl(transformationProvider), ccKFZnOskUjgKLmLO26m(0x651FE29D ^ 0x651F537D));
				num = 24;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
				{
					num = 22;
				}
				break;
			case 28:
				text9 = (string)Ypjrp7OsU6W4vJDkmWce(transformationProvider.Dialect, ccKFZnOskUjgKLmLO26m(0x4943E3E4 ^ 0x49436E96));
				num = 16;
				break;
			case 24:
			{
				text16 = (string)Ypjrp7OsU6W4vJDkmWce(rUmxf9OsMkCfdLNB6EQl(transformationProvider), ccKFZnOskUjgKLmLO26m(-1001967776 ^ -1002038570));
				int num2 = 19;
				num = num2;
				break;
			}
			case 17:
				findByNameQuery = (string)ccKFZnOskUjgKLmLO26m(-772614310 ^ -772584074) + text8 + (string)ccKFZnOskUjgKLmLO26m(0xA7339EE ^ 0xA72A3A8) + text + (string)ccKFZnOskUjgKLmLO26m(-682910880 ^ -683015884) + text + (string)ccKFZnOskUjgKLmLO26m(0x37E97159 ^ 0x37E8EB3B) + text + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F534A5C ^ 0x5F52D02C) + text2 + (string)ccKFZnOskUjgKLmLO26m(0x6F6D7B44 ^ 0x6F6D3C2C) + text11 + (string)ccKFZnOskUjgKLmLO26m(0x56A753C9 ^ 0x56A6C9B7) + text3 + (string)ccKFZnOskUjgKLmLO26m(0x1C7F6FED ^ 0x1C7EF573) + text + (string)ccKFZnOskUjgKLmLO26m(0x747FFBE0 ^ 0x747E6156) + text + (string)ccKFZnOskUjgKLmLO26m(0x361628FF ^ 0x3617B23B) + text3 + (string)ccKFZnOskUjgKLmLO26m(0x361628FF ^ 0x3617B21F) + text + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4943E3E4 ^ 0x4942791C) + text2 + (string)ccKFZnOskUjgKLmLO26m(0x70EBB9F3 ^ 0x70EA2337) + text4 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF76AFA) + text5 + (string)ccKFZnOskUjgKLmLO26m(0x37F755F5 ^ 0x37F6CF43) + text + (string)ccKFZnOskUjgKLmLO26m(0x2F44D93A ^ 0x2F4543FE) + text4 + (string)ccKFZnOskUjgKLmLO26m(-1539486135 ^ -1539517079) + text5 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-768800937 ^ -768827985) + text2 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70EA2337) + text4 + (string)ccKFZnOskUjgKLmLO26m(0x56A753C9 ^ 0x56A6C8F1) + text5 + (string)ccKFZnOskUjgKLmLO26m(--1418337216 ^ 0x548B8090) + text2 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-360662087 ^ -360636199) + text8 + (string)ccKFZnOskUjgKLmLO26m(-360662087 ^ -360657797) + (string)BU9NPdOsVEs6HI6mqDV9(transformationProvider) + (string)ccKFZnOskUjgKLmLO26m(-2077784392 ^ -2077876800) + text + (string)ccKFZnOskUjgKLmLO26m(-1776305410 ^ -1776410268) + text + (string)ccKFZnOskUjgKLmLO26m(-539998957 ^ -539894111) + text + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-667465279 ^ -667495925);
				num = 10;
				break;
			case 4:
				text11 = (string)Ypjrp7OsU6W4vJDkmWce(rUmxf9OsMkCfdLNB6EQl(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1145BED7 ^ 0x1145F807));
				num = 12;
				break;
			case 6:
				text17 = ((Dialect)rUmxf9OsMkCfdLNB6EQl(transformationProvider)).QuoteIfNeeded((string)ccKFZnOskUjgKLmLO26m(-351369538 ^ -351345842));
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
				{
					num = 1;
				}
				break;
			case 18:
				text14 = ((Dialect)rUmxf9OsMkCfdLNB6EQl(transformationProvider)).QuoteIfNeeded((string)ccKFZnOskUjgKLmLO26m(0x3C1FFB55 ^ 0x3C1F5B61));
				num = 4;
				break;
			case 13:
				this.workflowProcessManager = workflowProcessManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
				{
					num = 0;
				}
				break;
			case 8:
				text4 = transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x19279C75));
				num = 17;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
				{
					num = 7;
				}
				break;
			case 26:
				text3 = transformationProvider.Dialect.QuoteIfNeeded((string)ccKFZnOskUjgKLmLO26m(--727842433 ^ 0x2B606487));
				num = 8;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
				{
					num = 3;
				}
				break;
			case 15:
				text13 = (string)Ypjrp7OsU6W4vJDkmWce(rUmxf9OsMkCfdLNB6EQl(transformationProvider), ccKFZnOskUjgKLmLO26m(-801808857 ^ -801847299));
				num = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
				{
					num = 23;
				}
				break;
			case 9:
				metadataListQuery = (string)ksK3x5OsAqgdaVkmFMTq(new string[67]
				{
					(string)ccKFZnOskUjgKLmLO26m(0xA7339EE ^ 0xA72A58C),
					text,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x628167BE ^ 0x628120F2),
					text7,
					(string)ccKFZnOskUjgKLmLO26m(0x350C0E8 ^ 0x35087A4),
					text8,
					(string)ccKFZnOskUjgKLmLO26m(-1647793954 ^ -1647775854),
					text9,
					(string)ccKFZnOskUjgKLmLO26m(0x69063C81 ^ 0x69067BCD),
					text10,
					(string)ccKFZnOskUjgKLmLO26m(0x1145BED7 ^ 0x11442253),
					text,
					(string)ccKFZnOskUjgKLmLO26m(0x1C663DA1 ^ 0x1C667AFB),
					text7,
					(string)ccKFZnOskUjgKLmLO26m(-772614310 ^ -772632576),
					text8,
					(string)ccKFZnOskUjgKLmLO26m(-63028171 ^ -63044753),
					text9,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C667AFB),
					text10,
					(string)ccKFZnOskUjgKLmLO26m(--1418337216 ^ 0x548B8758),
					text,
					(string)ccKFZnOskUjgKLmLO26m(0xB7793C9 ^ 0xB760F65),
					text7,
					(string)ccKFZnOskUjgKLmLO26m(-667465279 ^ -667495059),
					text8,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5BCD23A0 ^ 0x5BCCBF0C),
					text9,
					(string)ccKFZnOskUjgKLmLO26m(-452127399 ^ -452163083),
					text10,
					(string)ccKFZnOskUjgKLmLO26m(0x438A0E43 ^ 0x438A492B),
					text4,
					(string)ccKFZnOskUjgKLmLO26m(-1657582555 ^ -1657599137),
					text11,
					(string)ccKFZnOskUjgKLmLO26m(-1712492721 ^ -1712524299),
					text,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -452163189),
					text5,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-261315199 ^ -261299519),
					text19,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF6B6B2),
					text14,
					(string)ccKFZnOskUjgKLmLO26m(0x5BCD23A0 ^ 0x5BCCBF44),
					text3,
					(string)ccKFZnOskUjgKLmLO26m(-1716629332 ^ -1716532660),
					text2,
					(string)ccKFZnOskUjgKLmLO26m(-135674354 ^ -135691844),
					text,
					(string)ccKFZnOskUjgKLmLO26m(-1514166050 ^ -1514261990),
					text11,
					(string)ccKFZnOskUjgKLmLO26m(-949717965 ^ -949622479),
					text,
					(string)ccKFZnOskUjgKLmLO26m(0x614274E3 ^ 0x6143EFB3),
					text,
					(string)ccKFZnOskUjgKLmLO26m(0x17F0C5A2 ^ 0x17F15F66),
					text3,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1516552726 ^ -1516592912),
					text2,
					(string)ccKFZnOskUjgKLmLO26m(-935313063 ^ -935208439),
					text,
					(string)ccKFZnOskUjgKLmLO26m(0xDF4D1F8 ^ 0xDF54B3C),
					text11,
					(string)ccKFZnOskUjgKLmLO26m(0x4943E3E4 ^ 0x49427ED6),
					text,
					(string)ccKFZnOskUjgKLmLO26m(-130098986 ^ -130071140),
					text,
					(string)ccKFZnOskUjgKLmLO26m(-14356676 ^ -14323098)
				});
				num = 11;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
				{
					num = 5;
				}
				break;
			case 25:
				text7 = (string)Ypjrp7OsU6W4vJDkmWce(rUmxf9OsMkCfdLNB6EQl(transformationProvider), ccKFZnOskUjgKLmLO26m(-790221436 ^ -790205448));
				num = 7;
				break;
			case 27:
				this.workflowMetadataLoaderService = workflowMetadataLoaderService;
				num = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
				{
					num = 13;
				}
				break;
			case 12:
				text18 = (string)Ypjrp7OsU6W4vJDkmWce(rUmxf9OsMkCfdLNB6EQl(transformationProvider), ccKFZnOskUjgKLmLO26m(-43932417 ^ -43965937));
				num = 26;
				break;
			case 14:
				text = ((Dialect)rUmxf9OsMkCfdLNB6EQl(transformationProvider)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1539486135 ^ -1539503921));
				num = 16;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
				{
					num = 25;
				}
				break;
			default:
				this.transformationProvider = transformationProvider;
				num = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
				{
					num = 14;
				}
				break;
			case 22:
				findPropertiesByUidQuery1 = (string)ksK3x5OsAqgdaVkmFMTq(new string[27]
				{
					(string)ccKFZnOskUjgKLmLO26m(0x7381F16B ^ 0x73806CB1),
					text16,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25809378),
					text6,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-683713632 ^ -683751852),
					text17,
					(string)ccKFZnOskUjgKLmLO26m(0x246EEF98 ^ 0x246F726C),
					text8,
					(string)ccKFZnOskUjgKLmLO26m(0x56A753C9 ^ 0x56A6CE3D),
					text9,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF41900C),
					text10,
					(string)ccKFZnOskUjgKLmLO26m(-1647793954 ^ -1647758038),
					text7,
					(string)ccKFZnOskUjgKLmLO26m(0x246EEF98 ^ 0x246F726C),
					text15,
					(string)ccKFZnOskUjgKLmLO26m(0xA7339EE ^ 0xA737E86),
					text11,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-684210684 ^ -684303238),
					text18,
					(string)ccKFZnOskUjgKLmLO26m(0x2269BD32 ^ 0x22682332),
					text15,
					(string)ccKFZnOskUjgKLmLO26m(0x2F44D93A ^ 0x2F45438C),
					text,
					(string)ccKFZnOskUjgKLmLO26m(-1965291699 ^ -1965188051),
					text7,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108877388 ^ -1108983180)
				});
				num = 3;
				break;
			case 20:
				text12 = (string)Ypjrp7OsU6W4vJDkmWce(rUmxf9OsMkCfdLNB6EQl(transformationProvider), ccKFZnOskUjgKLmLO26m(--1418337216 ^ 0x548B826C));
				num = 15;
				break;
			case 1:
				text2 = (string)Ypjrp7OsU6W4vJDkmWce(rUmxf9OsMkCfdLNB6EQl(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F534A5C ^ 0x5F52D3D0));
				num = 20;
				break;
			case 21:
				text15 = (string)Ypjrp7OsU6W4vJDkmWce(rUmxf9OsMkCfdLNB6EQl(transformationProvider), ccKFZnOskUjgKLmLO26m(-495296780 ^ -495265330));
				num = 6;
				break;
			case 3:
				findPropertiesByUidQuery2 = (string)ksK3x5OsAqgdaVkmFMTq(new string[57]
				{
					(string)ccKFZnOskUjgKLmLO26m(-1050383744 ^ -1050282860),
					text,
					(string)ccKFZnOskUjgKLmLO26m(0x13F63440 ^ 0x13F6731A),
					text7,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-148495695 ^ -148391743),
					text12,
					(string)ccKFZnOskUjgKLmLO26m(-1716629332 ^ -1716643850),
					text9,
					(string)ccKFZnOskUjgKLmLO26m(0x1145BED7 ^ 0x1145F98D),
					text10,
					(string)ccKFZnOskUjgKLmLO26m(-197778752 ^ -197674832),
					text13,
					(string)ccKFZnOskUjgKLmLO26m(0x56F860D7 ^ 0x56F9FAA7),
					text2,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-135674354 ^ -135768014),
					text,
					(string)ccKFZnOskUjgKLmLO26m(-683713632 ^ -683751668),
					text7,
					(string)ccKFZnOskUjgKLmLO26m(-1716629332 ^ -1716531486),
					text12,
					(string)ccKFZnOskUjgKLmLO26m(-961162596 ^ -961262032),
					text9,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x1004DA3),
					text10,
					(string)ccKFZnOskUjgKLmLO26m(-2057730233 ^ -2057823991),
					text13,
					(string)ccKFZnOskUjgKLmLO26m(-1600060848 ^ -1600087010),
					text2,
					(string)ccKFZnOskUjgKLmLO26m(-1303601216 ^ -1303586648),
					text11,
					(string)ccKFZnOskUjgKLmLO26m(0x2ACCDD87 ^ 0x2ACD43DB),
					text3,
					(string)ccKFZnOskUjgKLmLO26m(-949717965 ^ -949621037),
					text2,
					(string)ccKFZnOskUjgKLmLO26m(0x56A753C9 ^ 0x56A7147B),
					text,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-360662087 ^ -360636035),
					text11,
					(string)ccKFZnOskUjgKLmLO26m(0x51EF0063 ^ 0x51EE9D61),
					text,
					(string)ccKFZnOskUjgKLmLO26m(-2077784392 ^ -2077876760),
					text,
					(string)ccKFZnOskUjgKLmLO26m(0x4940763B ^ 0x4941ECFF),
					text3,
					(string)ccKFZnOskUjgKLmLO26m(-39189604 ^ -39084410),
					text2,
					(string)ccKFZnOskUjgKLmLO26m(-1965291699 ^ -1965188067),
					text,
					(string)ccKFZnOskUjgKLmLO26m(-684210684 ^ -684303168),
					text11,
					(string)ccKFZnOskUjgKLmLO26m(0x5BCD23A0 ^ 0x5BCCBE92),
					text,
					(string)ccKFZnOskUjgKLmLO26m(0x6F6D7B44 ^ 0x6F6CE60E),
					text,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801808857 ^ -801849255),
					text7,
					(string)ccKFZnOskUjgKLmLO26m(0x7AC609FE ^ 0x7AC7943E)
				});
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
				{
					num = 2;
				}
				break;
			case 7:
				text8 = transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -452111401));
				num = 28;
				break;
			case 11:
				metadataListQuery2Format = (string)ccKFZnOskUjgKLmLO26m(-106528299 ^ -106488649) + text + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-45832783 ^ -45817109) + text7 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-768800937 ^ -768786419) + text8 + (string)ccKFZnOskUjgKLmLO26m(0x6CC04061 ^ 0x6CC0073B) + text9 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-10408775 ^ -10392605) + text10 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1843E01F ^ 0x18427C87) + text + (string)ccKFZnOskUjgKLmLO26m(0x2269BD32 ^ 0x2268219E) + text7 + (string)ccKFZnOskUjgKLmLO26m(0x12F686A ^ 0x12EF4C6) + text8 + (string)ccKFZnOskUjgKLmLO26m(0x63D6C913 ^ 0x63D755BF) + text9 + (string)ccKFZnOskUjgKLmLO26m(0x63D6C913 ^ 0x63D755BF) + text10 + (string)ccKFZnOskUjgKLmLO26m(0x1C663DA1 ^ 0x1C667AC9) + text3 + (string)ccKFZnOskUjgKLmLO26m(-11799394 ^ -11900646) + text11 + (string)ccKFZnOskUjgKLmLO26m(-1516552726 ^ -1516592920) + text + (string)ccKFZnOskUjgKLmLO26m(-2057730233 ^ -2057823209) + text + (string)ccKFZnOskUjgKLmLO26m(0x13F63440 ^ 0x13F7AE84) + text3 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB317C8) + text2 + (string)ccKFZnOskUjgKLmLO26m(0x56F860D7 ^ 0x56F9FB87) + text + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-45832783 ^ -45793419) + text11 + (string)ccKFZnOskUjgKLmLO26m(0x2269BD32 ^ 0x22682000) + text + (string)ccKFZnOskUjgKLmLO26m(0x1C7F6FED ^ 0x1C7EF2A7) + text + (string)ccKFZnOskUjgKLmLO26m(-495296780 ^ -495205550) + text2 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F534A5C ^ 0x5F52D79C);
				num = 22;
				break;
			case 2:
				return;
			case 19:
				text6 = (string)Ypjrp7OsU6W4vJDkmWce(rUmxf9OsMkCfdLNB6EQl(transformationProvider), ccKFZnOskUjgKLmLO26m(0x3C1FFB55 ^ 0x3C1E7F77));
				num = 21;
				break;
			case 10:
				findByNameQuery2Format = (string)ksK3x5OsAqgdaVkmFMTq(new string[33]
				{
					(string)ccKFZnOskUjgKLmLO26m(0x4943E3E4 ^ 0x49427838),
					text,
					(string)ccKFZnOskUjgKLmLO26m(-2111219045 ^ -2111258417),
					text,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747E6190),
					text2,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5BCD23A0 ^ 0x5BCD64C8),
					text3,
					(string)ccKFZnOskUjgKLmLO26m(0x1AF6F1F2 ^ 0x1AF76A06),
					text3,
					(string)ccKFZnOskUjgKLmLO26m(0x6871CA ^ 0x69EB2A),
					text,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-148495695 ^ -148391863),
					text2,
					(string)ccKFZnOskUjgKLmLO26m(-360662087 ^ -360636035),
					text4,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398691253 ^ -398594237),
					text5,
					(string)ccKFZnOskUjgKLmLO26m(0x6A69C5CD ^ 0x6A685F35),
					text2,
					(string)ccKFZnOskUjgKLmLO26m(0x350C0E8 ^ 0x3515A2C),
					text4,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1EA50FCC ^ 0x1EA494EC),
					text5,
					(string)ccKFZnOskUjgKLmLO26m(-961162596 ^ -961263156),
					text2,
					(string)ccKFZnOskUjgKLmLO26m(--1436248540 ^ 0x559AF5CA),
					text,
					(string)ccKFZnOskUjgKLmLO26m(-684210684 ^ -684303820),
					text,
					(string)ccKFZnOskUjgKLmLO26m(-949717965 ^ -949620823),
					text,
					(string)ccKFZnOskUjgKLmLO26m(0x4943E3E4 ^ 0x4942782E)
				});
				num = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
				{
					num = 9;
				}
				break;
			}
		}
	}

	public EntityMetadata FindEntityMetadata(string className)
	{
		int num = 4;
		int num2 = num;
		Type runtimeType = default(Type);
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		long? orAdd = default(long?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return GetAllMetadata((EntityMetadata)MetadataLoader.LoadMetadata(runtimeType)).FirstOrDefault(_003C_003Ec__DisplayClass6_._003CFindEntityMetadata_003Eb__2);
			default:
				runtimeType = jaKIwWOsGFdGySQTAyo1(workflowMetadataLoaderService, orAdd.Value, false);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				_003C_003Ec__DisplayClass6_.className = className;
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
				{
					num2 = 3;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num2 = 3;
				break;
			case 2:
				if (!orAdd.HasValue)
				{
					return null;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass6_._003C_003E4__this = this;
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
				{
					num2 = 5;
				}
				break;
			case 6:
				orAdd = headerIds.GetOrAdd(_003C_003Ec__DisplayClass6_.className, _003C_003Ec__DisplayClass6_._003CFindEntityMetadata_003Eb__0);
				num2 = 2;
				break;
			}
		}
		static IEnumerable<EntityMetadata> GetAllMetadata(EntityMetadata metadata)
		{
			return metadata.GetCompositeParts().Cast<EntityMetadata>().SelectMany(GetAllMetadata)
				.Prepend(metadata);
		}
	}

	public IEnumerable<EntityMetadata> GetEntityMetadataList()
	{
		long num = workflowProcessManager.Count();
		if (entityMetadataList != null && checkCount == num)
		{
			return entityMetadataList;
		}
		lock (this)
		{
			if (entityMetadataList != null && checkCount == num)
			{
				return entityMetadataList;
			}
			entityMetadataList = null;
			checkCount = num;
			Dictionary<long, EntityMetadata> result = new Dictionary<long, EntityMetadata>();
			List<long> list = new List<long>();
			using (IDataReader dataReader = transformationProvider.ExecuteQuery(metadataListQuery))
			{
				while (dataReader.Read())
				{
					Add(dataReader, 0);
					Add(dataReader, 5);
					long? num2 = Add(dataReader, 10);
					if (num2.HasValue)
					{
						list.Add(num2.Value);
					}
				}
			}
			while (list.Count > 0)
			{
				_003C_003Ec__DisplayClass7_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass7_1();
				CS_0024_003C_003E8__locals1._003C_003E4__this = this;
				CS_0024_003C_003E8__locals1.parameters = new Dictionary<string, object>();
				string arg = string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108877388 ^ -1108895938), list.Take(100).Select(delegate(long id, int index)
				{
					int num4 = 1;
					int num5 = num4;
					while (true)
					{
						switch (num5)
						{
						default:
							return (string)_003C_003Ec__DisplayClass7_1.un4vbhvK8gKAR9pV3lra(CS_0024_003C_003E8__locals1._003C_003E4__this.transformationProvider.ParameterSeparator, _003C_003Ec__DisplayClass7_1.x4kUokvKYPD29AMn1cJG(-1028861977 ^ -1028865955), index);
						case 1:
							CS_0024_003C_003E8__locals1.parameters[string.Concat(_003C_003Ec__DisplayClass7_1.x4kUokvKYPD29AMn1cJG(-2057730233 ^ -2057729795), index)] = id;
							num5 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
							{
								num5 = 0;
							}
							break;
						}
					}
				}));
				list.RemoveRange(0, Math.Min(100, list.Count));
				using IDataReader dataReader2 = transformationProvider.ExecuteQuery(string.Format(metadataListQuery2Format, arg), CS_0024_003C_003E8__locals1.parameters);
				while (dataReader2.Read())
				{
					Add(dataReader2, 0);
					long? num3 = Add(dataReader2, 5);
					if (num3.HasValue)
					{
						list.Add(num3.Value);
					}
				}
			}
			return entityMetadataList = result.Values.ToArray();
			long? Add(IDataReader reader, int startIndex)
			{
				if (reader.IsDBNull(startIndex))
				{
					return null;
				}
				long @int = reader.GetInt64(startIndex);
				result[@int] = new EntityMetadata
				{
					Id = @int,
					Uid = transformationProvider.Dialect.GetGuid(reader.GetValue(startIndex + 1)),
					Name = (reader.IsDBNull(startIndex + 2) ? null : reader.GetString(startIndex + 2)),
					DisplayName = (reader.IsDBNull(startIndex + 3) ? null : reader.GetString(startIndex + 3)),
					Description = (reader.IsDBNull(startIndex + 4) ? null : reader.GetString(startIndex + 4))
				};
				return @int;
			}
		}
	}

	public EntityMetadata FindEntityMetadata(Guid uid)
	{
		//Discarded unreachable code: IL_0098, IL_00a2, IL_0186, IL_01c9, IL_01d8, IL_0205, IL_0215, IL_0377, IL_03c8, IL_046d, IL_04a5, IL_04b4, IL_0530, IL_053a, IL_0657, IL_0666, IL_06d5, IL_06e4, IL_06f4, IL_07b7, IL_07ef, IL_08ca, IL_08d9, IL_0997, IL_09ef, IL_09fe, IL_0a88, IL_0ab8, IL_0ad7, IL_0ae6, IL_0b13, IL_0b42, IL_0b51
		int num = 9;
		int num2 = num;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		IDataReader dataReader2 = default(IDataReader);
		TablePartMetadata value2 = default(TablePartMetadata);
		PropertyMetadata property = default(PropertyMetadata);
		Dictionary<long, TablePartMetadata> dictionary = default(Dictionary<long, TablePartMetadata>);
		long propertyOwner = default(long);
		IDataReader dataReader = default(IDataReader);
		TablePartMetadata tablePart = default(TablePartMetadata);
		List<Guid> list2 = default(List<Guid>);
		TablePartMetadata tablePart2 = default(TablePartMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		IDataReader dataReader4 = default(IDataReader);
		TablePartMetadata tablePart3 = default(TablePartMetadata);
		TablePartMetadata tablePart4 = default(TablePartMetadata);
		long tablePartOwner = default(long);
		long tablePartOwner2 = default(long);
		List<Guid> list = default(List<Guid>);
		string arg = default(string);
		IDataReader dataReader3 = default(IDataReader);
		EntityMetadata result = default(EntityMetadata);
		PropertyMetadata property2 = default(PropertyMetadata);
		string text = default(string);
		while (true)
		{
			TablePartMetadata value;
			switch (num2)
			{
			case 8:
				_003C_003Ec__DisplayClass8_._003C_003E4__this = this;
				num2 = 18;
				break;
			case 1:
				try
				{
					while (true)
					{
						IL_016b:
						int num6;
						if (!msDhiPOs2gEiqpRj91gs(dataReader2))
						{
							num6 = 3;
							goto IL_00a6;
						}
						goto IL_0126;
						IL_00a6:
						while (true)
						{
							switch (num6)
							{
							case 2:
								value2.Properties.Add(property);
								num6 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
								{
									num6 = 0;
								}
								continue;
							case 7:
								if (!dictionary.TryGetValue(propertyOwner, out value2))
								{
									num6 = 6;
									continue;
								}
								goto case 2;
							case 4:
								propertyOwner = GetPropertyOwner(dataReader2);
								num6 = 7;
								continue;
							case 5:
								break;
							default:
								if (property != null)
								{
									num6 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
									{
										num6 = 2;
									}
									continue;
								}
								goto IL_016b;
							case 1:
							case 6:
								goto IL_016b;
							case 3:
								goto end_IL_016b;
							}
							break;
						}
						goto IL_0126;
						IL_0126:
						property = GetProperty(dataReader2);
						num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
						{
							num6 = 0;
						}
						goto IL_00a6;
						continue;
						end_IL_016b:
						break;
					}
				}
				finally
				{
					int num8;
					if (dataReader2 == null)
					{
						int num7 = 2;
						num8 = num7;
						goto IL_01ae;
					}
					goto IL_01e3;
					IL_01ae:
					switch (num8)
					{
					case 2:
						goto end_IL_0195;
					case 1:
						goto end_IL_0195;
					}
					goto IL_01e3;
					IL_01e3:
					L3qpOpOsoCb2sGv3QNsK(dataReader2);
					num8 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
					{
						num8 = 1;
					}
					goto IL_01ae;
					end_IL_0195:;
				}
				goto case 21;
			case 14:
				try
				{
					while (true)
					{
						int num3;
						if (!msDhiPOs2gEiqpRj91gs(dataReader))
						{
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
							{
								num3 = 4;
							}
							goto IL_0223;
						}
						goto IL_02b7;
						IL_02b7:
						tablePart = GetTablePart(dataReader, 0);
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
						{
							num3 = 0;
						}
						goto IL_0223;
						IL_0223:
						while (true)
						{
							int num4;
							switch (num3)
							{
							case 14:
								list2.Add(Ka8k2GOsiZ72GCM12YEN(tablePart2));
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
							case 2:
								break;
							case 9:
								goto IL_02b7;
							case 6:
							case 8:
								tablePart2 = GetTablePart(dataReader, 7);
								num3 = 3;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
								{
									num3 = 1;
								}
								continue;
							case 12:
								dictionary[tablePart.Id].TableParts.Add(tablePart2);
								num3 = 13;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
								{
									num3 = 14;
								}
								continue;
							case 11:
								if (dictionary.TryGetValue(tablePart2.Id, out value))
								{
									break;
								}
								num4 = 13;
								goto IL_021f;
							case 13:
								dictionary[tablePart2.Id] = tablePart2;
								num3 = 12;
								continue;
							case 3:
								if (tablePart2 == null)
								{
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
									{
										num3 = 2;
									}
									continue;
								}
								goto case 11;
							default:
								if (tablePart != null)
								{
									num3 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
									{
										num3 = 5;
									}
									continue;
								}
								break;
							case 10:
								dictionary[tablePart.Id] = tablePart;
								num3 = 7;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
								{
									num3 = 5;
								}
								continue;
							case 7:
								entityMetadata.TableParts.Add(tablePart);
								num3 = 8;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
								{
									num3 = 4;
								}
								continue;
							case 5:
								if (dictionary.TryGetValue(tablePart.Id, out value))
								{
									num4 = 6;
									goto IL_021f;
								}
								goto case 10;
							case 4:
								goto end_IL_0291;
								IL_021f:
								num3 = num4;
								continue;
							}
							break;
						}
						continue;
						end_IL_0291:
						break;
					}
				}
				finally
				{
					if (dataReader != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								dataReader.Dispose();
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
								{
									num5 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 19;
			default:
				dictionary = new Dictionary<long, TablePartMetadata>();
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
				{
					num2 = 7;
				}
				break;
			case 7:
				dataReader = transformationProvider.ExecuteQuery((string)BnVVZQOsFqOMXeWomj0e(findPropertiesByUidQuery2, transformationProvider.ParameterSeparator + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-684210684 ^ -684304228)), _003C_003Ec__DisplayClass8_.parameters);
				num2 = 14;
				break;
			case 24:
				try
				{
					while (true)
					{
						IL_073c:
						int num11;
						if (!msDhiPOs2gEiqpRj91gs(dataReader4))
						{
							num11 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
							{
								num11 = 0;
							}
							goto IL_053e;
						}
						goto IL_0727;
						IL_0727:
						tablePart3 = GetTablePart(dataReader4, 0);
						num11 = 14;
						goto IL_053e;
						IL_053e:
						while (true)
						{
							switch (num11)
							{
							case 12:
								if (dictionary.TryGetValue(tablePart3.Id, out value))
								{
									num11 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
									{
										num11 = 1;
									}
									continue;
								}
								goto case 2;
							case 1:
							case 6:
								tablePart4 = GetTablePart(dataReader4, 7);
								num11 = 7;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
								{
									num11 = 15;
								}
								continue;
							case 3:
								tablePartOwner = GetTablePartOwner(dataReader4, 0);
								num11 = 9;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
								{
									num11 = 10;
								}
								continue;
							case 11:
								dictionary[tablePart4.Id] = tablePart4;
								num11 = 4;
								continue;
							case 10:
								dictionary[tablePartOwner].TableParts.Add(tablePart3);
								num11 = 6;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
								{
									num11 = 5;
								}
								continue;
							case 4:
								tablePartOwner2 = GetTablePartOwner(dataReader4, 7);
								num11 = 5;
								continue;
							case 2:
								dictionary[tablePart3.Id] = tablePart3;
								num11 = 3;
								continue;
							case 14:
								if (tablePart3 != null)
								{
									num11 = 12;
									continue;
								}
								goto IL_073c;
							case 5:
								dictionary[tablePartOwner2].TableParts.Add(tablePart4);
								num11 = 16;
								continue;
							case 15:
								if (tablePart4 == null)
								{
									num11 = 7;
									continue;
								}
								goto case 9;
							case 16:
								list2.Add(tablePart4.Uid);
								num11 = 17;
								continue;
							case 13:
								goto IL_0727;
							case 7:
							case 8:
							case 17:
								goto IL_073c;
							case 9:
								if (dictionary.TryGetValue(tablePart4.Id, out value))
								{
									num11 = 8;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
									{
										num11 = 2;
									}
									continue;
								}
								goto case 11;
							case 0:
								break;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					if (dataReader4 != null)
					{
						int num12 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
						{
							num12 = 0;
						}
						while (true)
						{
							switch (num12)
							{
							default:
								L3qpOpOsoCb2sGv3QNsK(dataReader4);
								num12 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
								{
									num12 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 19;
			case 3:
				list2 = new List<Guid>();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 8;
				break;
			case 21:
			case 23:
				if (tkNLkpOsrtEbZr9t8dcL(list) <= 0)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 20;
			case 18:
				_003C_003Ec__DisplayClass8_.parameters = new Dictionary<string, object> { [(string)ccKFZnOskUjgKLmLO26m(0x75BAD659 ^ 0x75BB48C1)] = uid };
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				dataReader4 = transformationProvider.ExecuteQuery(string.Format(findPropertiesByUidQuery2, arg), _003C_003Ec__DisplayClass8_.parameters);
				num2 = 24;
				break;
			case 2:
				return entityMetadata;
			case 5:
				dataReader3 = transformationProvider.ExecuteQuery(string.Format(findPropertiesByUidQuery1, uFQIC7Os7pHGwFPOFjO2(transformationProvider.ParameterSeparator, ccKFZnOskUjgKLmLO26m(0x4FD00585 ^ 0x4FD19B1D))), _003C_003Ec__DisplayClass8_.parameters);
				num2 = 22;
				break;
			case 19:
				if (tkNLkpOsrtEbZr9t8dcL(list2) > 0)
				{
					num2 = 17;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
					{
						num2 = 10;
					}
					break;
				}
				goto case 6;
			case 20:
				_003C_003Ec__DisplayClass8_.parameters = new Dictionary<string, object>();
				num2 = 11;
				break;
			case 22:
				try
				{
					int num9;
					if (msDhiPOs2gEiqpRj91gs(dataReader3))
					{
						num9 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
						{
							num9 = 6;
						}
						goto IL_099b;
					}
					goto IL_09cd;
					IL_09cd:
					result = null;
					num9 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
					{
						num9 = 0;
					}
					goto IL_099b;
					IL_099b:
					while (true)
					{
						switch (num9)
						{
						default:
							return result;
						case 0:
							return result;
						case 7:
							break;
						case 9:
							entityMetadata.Properties.Add(property2);
							num9 = 4;
							continue;
						case 6:
						case 8:
							entityMetadata = new EntityMetadata
							{
								Uid = uid
							};
							num9 = 3;
							continue;
						case 4:
						case 5:
							if (!dataReader3.Read())
							{
								num9 = 2;
								continue;
							}
							goto case 3;
						case 3:
							property2 = GetProperty(dataReader3);
							num9 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
							{
								num9 = 1;
							}
							continue;
						case 1:
							if (property2 == null)
							{
								num9 = 5;
								continue;
							}
							goto case 9;
						case 2:
							goto end_IL_099b;
						}
						goto IL_09cd;
						continue;
						end_IL_099b:
						break;
					}
				}
				finally
				{
					int num10;
					if (dataReader3 == null)
					{
						num10 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
						{
							num10 = 1;
						}
						goto IL_0abc;
					}
					goto IL_0af1;
					IL_0af1:
					L3qpOpOsoCb2sGv3QNsK(dataReader3);
					num10 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
					{
						num10 = 0;
					}
					goto IL_0abc;
					IL_0abc:
					switch (num10)
					{
					default:
						goto end_IL_0a97;
					case 2:
						goto end_IL_0a97;
					case 1:
						break;
					case 0:
						goto end_IL_0a97;
					}
					goto IL_0af1;
					end_IL_0a97:;
				}
				goto case 3;
			case 15:
				yMdhlJOsa3rY9lcPBfNV(list2, 0, yXqc46OsISSSgB4RJ3DH(100, list2.Count));
				num2 = 4;
				break;
			case 16:
				dataReader2 = transformationProvider.ExecuteQuery((string)BnVVZQOsFqOMXeWomj0e(findPropertiesByUidQuery1, text), _003C_003Ec__DisplayClass8_.parameters);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
				{
					num2 = 1;
				}
				break;
			case 13:
			case 17:
				_003C_003Ec__DisplayClass8_.parameters = new Dictionary<string, object>();
				num2 = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
				{
					num2 = 10;
				}
				break;
			case 12:
				yMdhlJOsa3rY9lcPBfNV(list, 0, Math.Min(100, list.Count));
				num2 = 16;
				break;
			case 10:
				arg = string.Join((string)ccKFZnOskUjgKLmLO26m(-14356676 ^ -14374986), list2.Take(100).Select(_003C_003Ec__DisplayClass8_._003CFindEntityMetadata_003Eb__1));
				num2 = 15;
				break;
			case 6:
				list = dictionary.Values.Select((TablePartMetadata t) => _003C_003Ec.dOTg1fZzwMXIlkfrCA2C(t)).ToList();
				num2 = 8;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
				{
					num2 = 23;
				}
				break;
			case 11:
				text = string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351351244), list.Take(100).Select(_003C_003Ec__DisplayClass8_._003CFindEntityMetadata_003Eb__2));
				num2 = 12;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
				{
					num2 = 11;
				}
				break;
			}
		}
	}

	private TablePartMetadata GetTablePart(IDataReader reader, int startIndex)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				if (wXaRPMOsexwUJsCvQO5B(reader, startIndex))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
					{
						num2 = 0;
					}
					break;
				}
				TablePartMetadata obj = new TablePartMetadata
				{
					Id = pseB8pOsNFsAgP30CEEJ(reader, startIndex),
					Uid = ((Dialect)rUmxf9OsMkCfdLNB6EQl(transformationProvider)).GetGuid(hfXQInOsxvJfRm7geVta(reader, startIndex + 1))
				};
				miWupyOs1lUoiIhsRuK9(obj, wXaRPMOsexwUJsCvQO5B(reader, startIndex + 2) ? null : CQOKvTOsSxPfSx90LwcN(reader, startIndex + 2));
				obj.DisplayName = (string)(wXaRPMOsexwUJsCvQO5B(reader, startIndex + 3) ? null : CQOKvTOsSxPfSx90LwcN(reader, startIndex + 3));
				zaR1PTOsh0HoHHdsTJ9s(obj, wXaRPMOsexwUJsCvQO5B(reader, startIndex + 4) ? null : CQOKvTOsSxPfSx90LwcN(reader, startIndex + 4));
				obj.TablePartPropertyUid = O5EAA2OsEiCJZi51HCvk(transformationProvider.Dialect, reader.GetValue(startIndex + 5));
				return obj;
			}
			default:
				return null;
			}
		}
	}

	private long GetTablePartOwner(IDataReader reader, int startIndex)
	{
		return pseB8pOsNFsAgP30CEEJ(reader, startIndex + 6);
	}

	private PropertyMetadata GetProperty(IDataReader reader)
	{
		//Discarded unreachable code: IL_007d, IL_008c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!wXaRPMOsexwUJsCvQO5B(reader, 1))
				{
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
					{
						num2 = 3;
					}
					break;
				}
				return null;
			case 1:
				if (!wXaRPMOsexwUJsCvQO5B(reader, 0))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			default:
			{
				PropertyMetadata propertyMetadata = new PropertyMetadata();
				iUwSPVOswtg2EcEhsrRk(propertyMetadata, transformationProvider.Dialect.GetGuid(hfXQInOsxvJfRm7geVta(reader, 0)));
				pux5PCOs4C2ajUjNAW7L(propertyMetadata, O5EAA2OsEiCJZi51HCvk(rUmxf9OsMkCfdLNB6EQl(transformationProvider), reader.GetValue(1)));
				gDYtFBOsz2SqY7erELaF(propertyMetadata, LoadTypeSettings(reader.GetValue(2)));
				miWupyOs1lUoiIhsRuK9(propertyMetadata, wXaRPMOsexwUJsCvQO5B(reader, 3) ? null : CQOKvTOsSxPfSx90LwcN(reader, 3));
				pfPGLsOJKPOBpwxS8rZ5(propertyMetadata, wXaRPMOsexwUJsCvQO5B(reader, 4) ? null : reader.GetString(4));
				zaR1PTOsh0HoHHdsTJ9s(propertyMetadata, reader.IsDBNull(5) ? null : CQOKvTOsSxPfSx90LwcN(reader, 5));
				fxQOpQOJOSqlT70wOllx(propertyMetadata, O5EAA2OsEiCJZi51HCvk(rUmxf9OsMkCfdLNB6EQl(transformationProvider), hfXQInOsxvJfRm7geVta(reader, 6)));
				return propertyMetadata;
			}
			}
		}
	}

	private long GetPropertyOwner(IDataReader reader)
	{
		return pseB8pOsNFsAgP30CEEJ(reader, 7);
	}

	private TypeSettings LoadTypeSettings(object value)
	{
		//Discarded unreachable code: IL_0077, IL_00af, IL_00e7, IL_00f6
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		TypeSettings result = default(TypeSettings);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				memoryStream = (MemoryStream)X0vQIjOJZCfbiiBBtMlM((byte[])value, false);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				result = (TypeSettings)Id6qVsOJvr5qtyIBcs7D(memoryStream);
				int num3 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				if (memoryStream != null)
				{
					int num4 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							L3qpOpOsoCb2sGv3QNsK(memoryStream);
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
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
		}
	}

	internal static void ycPXFvOsCmvs25wIQnkq()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object rUmxf9OsMkCfdLNB6EQl(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object ccKFZnOskUjgKLmLO26m(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Ypjrp7OsU6W4vJDkmWce(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object BU9NPdOsVEs6HI6mqDV9(object P_0)
	{
		return ((ITransformationProvider)P_0).ParameterSeparator;
	}

	internal static object ksK3x5OsAqgdaVkmFMTq(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static bool rRL43iOsQEdBqXvPoRul()
	{
		return xED4HkOsTVrhGfu17dZa == null;
	}

	internal static FullInstanceContextMetadataSearcher mSblroOspWGBPH8uTXHq()
	{
		return xED4HkOsTVrhGfu17dZa;
	}

	internal static Type jaKIwWOsGFdGySQTAyo1(object P_0, long headerId, bool throwOnMissing)
	{
		return ((IWorkflowMetadataLoaderService)P_0).GetFullInstanceContextType(headerId, throwOnMissing);
	}

	internal static object uFQIC7Os7pHGwFPOFjO2(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool msDhiPOs2gEiqpRj91gs(object P_0)
	{
		return ((IDataReader)P_0).Read();
	}

	internal static void L3qpOpOsoCb2sGv3QNsK(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object BnVVZQOsFqOMXeWomj0e(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static Guid Ka8k2GOsiZ72GCM12YEN(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static int yXqc46OsISSSgB4RJ3DH(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static void yMdhlJOsa3rY9lcPBfNV(object P_0, int P_1, int P_2)
	{
		((List<Guid>)P_0).RemoveRange(P_1, P_2);
	}

	internal static int tkNLkpOsrtEbZr9t8dcL(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}

	internal static bool wXaRPMOsexwUJsCvQO5B(object P_0, int P_1)
	{
		return ((IDataRecord)P_0).IsDBNull(P_1);
	}

	internal static long pseB8pOsNFsAgP30CEEJ(object P_0, int P_1)
	{
		return ((IDataRecord)P_0).GetInt64(P_1);
	}

	internal static object hfXQInOsxvJfRm7geVta(object P_0, int P_1)
	{
		return ((IDataRecord)P_0).GetValue(P_1);
	}

	internal static object CQOKvTOsSxPfSx90LwcN(object P_0, int P_1)
	{
		return ((IDataRecord)P_0).GetString(P_1);
	}

	internal static void miWupyOs1lUoiIhsRuK9(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static void zaR1PTOsh0HoHHdsTJ9s(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Description = (string)P_1;
	}

	internal static Guid O5EAA2OsEiCJZi51HCvk(object P_0, object P_1)
	{
		return ((Dialect)P_0).GetGuid(P_1);
	}

	internal static void iUwSPVOswtg2EcEhsrRk(object P_0, Guid P_1)
	{
		((PropertyMetadata)P_0).TypeUid = P_1;
	}

	internal static void pux5PCOs4C2ajUjNAW7L(object P_0, Guid P_1)
	{
		((PropertyMetadata)P_0).SubTypeUid = P_1;
	}

	internal static void gDYtFBOsz2SqY7erELaF(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).Settings = (TypeSettings)P_1;
	}

	internal static void pfPGLsOJKPOBpwxS8rZ5(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static void fxQOpQOJOSqlT70wOllx(object P_0, Guid P_1)
	{
		((AbstractMetadata)P_0).Uid = P_1;
	}

	internal static object X0vQIjOJZCfbiiBBtMlM(object P_0, bool P_1)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, P_1);
	}

	internal static object Id6qVsOJvr5qtyIBcs7D(object P_0)
	{
		return TypeSettingsNHType.LoadTypeSettings((Stream)P_0);
	}
}
