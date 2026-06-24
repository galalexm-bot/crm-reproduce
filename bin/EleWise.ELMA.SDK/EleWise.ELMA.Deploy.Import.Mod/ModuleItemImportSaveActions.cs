using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.Modules;

[Component]
internal sealed class ModuleItemImportSaveActions : EntityImportSaveActions
{
	internal sealed class Tester
	{
		private static readonly string errorStart;

		private readonly Func<string, ModuleInfoMetadata> deserializer;

		private readonly Func<Guid, string, bool> nameChecker;

		private readonly Action<TestImportMessagesType, string> logger;

		private readonly IModulePublishDataProvider modulePublishDataProvider;

		private readonly ITagService tagService;

		private readonly XmlReader reader;

		private readonly TestModuleImportSettings settings;

		private readonly IModuleMetadataLoader moduleMetadataLoader;

		internal static Tester cH6ve38447FjMj6XQ8Sa;

		private static bool StrictModuleAvailabilityCheck => SR.GetSetting(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463C0BF6), defaultValue: true);

		public Tester(XmlReader reader, TestModuleImportSettings settings, IModuleMetadataLoader moduleMetadataLoader, IModulePublishDataProvider modulePublishDataProvider, ITagService tagService, Action<TestImportMessagesType, string> logger, Func<string, ModuleInfoMetadata> deserializer, Func<Guid, string, bool> nameChecker)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.reader = reader;
			this.settings = settings;
			this.moduleMetadataLoader = moduleMetadataLoader;
			this.modulePublishDataProvider = modulePublishDataProvider;
			this.tagService = tagService;
			this.logger = logger;
			this.deserializer = deserializer;
			this.nameChecker = nameChecker;
		}

		public ModuleInfoMetadata Test(IEnumerable<ModuleVersion> moduleVersions)
		{
			_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass10_0();
			if (!TestTags(settings.Manifest))
			{
				logger(TestImportMessagesType.Warning, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998239154)));
				settings.Incompatible = true;
			}
			if (Version.TryParse(settings.Manifest.Version, out CS_0024_003C_003E8__locals0.moduleVersion) && moduleMetadataLoader.GetModuleVersionHeaders(settings.Manifest.ModuleUid).Any((ModuleVersionHeader v) => _003C_003Ec__DisplayClass10_0.dWUF7fZeHwtkqq3LgsAO(_003C_003Ec__DisplayClass10_0.aWNhvUZe6Bylthi3BQW5(v), CS_0024_003C_003E8__locals0.moduleVersion)))
			{
				logger(TestImportMessagesType.Warning, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398910328)));
				settings.Incompatible = true;
				return null;
			}
			if (!settings.ModuleHeaderUid.HasValue)
			{
				LogError(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16408371)));
				return null;
			}
			if (settings.ModuleMetadata != null)
			{
				LogError(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A32CF2)));
				return settings.ModuleMetadata;
			}
			XElement xElement = XElement.Load(reader.ReadSubtree());
			XElement xElement2 = xElement.Descendants().FirstOrDefault(delegate(XElement e)
			{
				object obj = _003C_003Ec.U9FM0KZempGioemffQCY(e);
				ParameterExpression parameterExpression = (ParameterExpression)_003C_003Ec.NiQGw5ZeJjnA9IvsZTPO(_003C_003Ec.u7H9ceZeyY0HYphpbjGw(typeof(ModuleMetadataItem).TypeHandle), _003C_003Ec.j0T4CTZeM0YnKlbZJgDR(0x66F566B6 ^ 0x66F5CA02));
				return _003C_003Ec.dfNAPTZedpr277tr9fMC(obj, (XName)LinqUtils.NameOf(Expression.Lambda<Func<ModuleMetadataItem, object>>((Expression)_003C_003Ec.iaJGBbZe9mXKMLw7TVRj(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
			});
			if (xElement2 == null || !Guid.TryParse(xElement2.Value, out var result))
			{
				LogError(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123859274)));
				return null;
			}
			if (settings.ModuleHeaderUid != result)
			{
				LogError(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951257394)));
				return null;
			}
			ModuleInfoMetadata moduleMetadata;
			try
			{
				moduleMetadata = GetModuleMetadata(result, xElement);
			}
			catch (InvalidOperationException ex)
			{
				LogError(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC74ED3), ex.Message));
				return null;
			}
			catch (Exception ex2)
			{
				LogError(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1486995382), ex2.Message));
				defaultLogger.Log(LogLevel.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDABABC)), ex2);
				return null;
			}
			if (moduleMetadata.Name != settings.Manifest.Id)
			{
				LogError(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4BF115), moduleMetadata.Name, settings.Manifest.Id));
				return null;
			}
			if (!nameChecker(moduleMetadata.Uid, moduleMetadata.Name))
			{
				LogError(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1838055659)));
				return null;
			}
			try
			{
				ModuleVersion defaultModuleVersion = moduleMetadataLoader.GetDefaultModuleVersion(result);
				if (defaultModuleVersion != null && defaultModuleVersion.Metadata.Name != moduleMetadata.Name)
				{
					LogError(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3636F28B), defaultModuleVersion.Metadata.Name));
					return null;
				}
			}
			catch (ModuleNotFoundException)
			{
			}
			if (moduleMetadata.Dependency == null)
			{
				LogError(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C9297DA)));
				return null;
			}
			if (settings.Incompatible)
			{
				return moduleMetadata;
			}
			try
			{
				modulePublishDataProvider.PrepareData(moduleMetadata, moduleVersions);
				return moduleMetadata;
			}
			catch (ModuleNotFoundException ex4)
			{
				if (ex4.DisabledReason != 0 || !StrictModuleAvailabilityCheck)
				{
					logger(TestImportMessagesType.Warning, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EA17C9)));
					settings.Incompatible = true;
					return moduleMetadata;
				}
				LogError(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -607047124), ex4.Message, ex4.AdditionalInformation));
				return null;
			}
		}

		private ModuleInfoMetadata GetModuleMetadata(Guid moduleUid, XElement element)
		{
			int num = 1;
			int num2 = num;
			_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
			while (true)
			{
				switch (num2)
				{
				default:
					_003C_003Ec__DisplayClass11_.moduleUid = moduleUid;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return element.Elements((string)wWqd6e84AceRHEOw5s1x(-345420348 ^ -345375994)).Select(ReadMetadataNode).Single(_003C_003Ec__DisplayClass11_._003CGetModuleMetadata_003Eb__0);
				case 1:
					_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		private void LogError(string message)
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
					logger(TestImportMessagesType.Error, (string)wHZhSS847mANpuMBX164(errorStart, message));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		private ModuleInfoMetadata ReadMetadataNode(XElement element)
		{
			//Discarded unreachable code: IL_0055, IL_0064, IL_0074, IL_0083, IL_0152
			int num = 11;
			Type type = default(Type);
			string text = default(string);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 10:
						type = j3rNHu84mIlJIkkQ2ykE(RTUk3W8404o92Wds782R(text, 0, BkgONJ84xHwU2DHTpgNY(text, wWqd6e84AceRHEOw5s1x(--1333735954 ^ 0x4F7F7DD4))));
						num2 = 3;
						continue;
					case 8:
						LogError(SR.T((string)wWqd6e84AceRHEOw5s1x(0x1FFEF86A ^ 0x1FF8FC26), text));
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num2 = 0;
						}
						continue;
					case 6:
						return null;
					case 2:
						return deserializer(text);
					case 11:
						text = element.Value;
						num2 = 10;
						continue;
					case 12:
						if (!Exmrcp849qKRIa0cE2C0(text))
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
							{
								num2 = 2;
							}
							continue;
						}
						goto case 8;
					case 3:
						if (!AeJ4T984yYLdFvnpQ9bC(type, null))
						{
							num2 = 4;
							continue;
						}
						break;
					case 5:
						break;
					case 1:
						return null;
					default:
						text = (string)Od796p84J14PiVLfgoqv(text, 0, text.IndexOf((string)wWqd6e84AceRHEOw5s1x(-35995181 ^ -36008427)));
						num2 = 12;
						continue;
					case 7:
						LogError(SR.T((string)wWqd6e84AceRHEOw5s1x(-1998538950 ^ -1998146760), text));
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num2 = 0;
						}
						continue;
					case 9:
						return null;
					case 4:
						if (!fD9FMP84MIkEfP9vQ2xK(type, typeof(ModuleInfoMetadata)))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 7;
					}
					break;
				}
				LogError(SR.T((string)wWqd6e84AceRHEOw5s1x(0x2A7797B7 ^ 0x2A71942F), text));
				num = 9;
			}
		}

		private bool TestTags(ElmaStoreComponentManifest manifest)
		{
			//Discarded unreachable code: IL_0082, IL_008c, IL_014c, IL_015f, IL_016e
			int num = 2;
			int num2 = num;
			bool result = default(bool);
			List<TestImportMessages>.Enumerator enumerator = default(List<TestImportMessages>.Enumerator);
			List<TestImportMessages> messages = default(List<TestImportMessages>);
			TestImportMessages current = default(TestImportMessages);
			while (true)
			{
				switch (num2)
				{
				case 3:
					return result;
				case 1:
					enumerator = messages.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					result = tagService.ValidateTags(manifest, out messages);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				try
				{
					while (true)
					{
						IL_00cd:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
							{
								num3 = 1;
							}
							goto IL_0090;
						}
						goto IL_00aa;
						IL_00aa:
						current = enumerator.Current;
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
						{
							num3 = 0;
						}
						goto IL_0090;
						IL_0090:
						while (true)
						{
							switch (num3)
							{
							case 1:
								return result;
							case 3:
								break;
							default:
								goto IL_00cd;
							case 2:
								logger(TestImportMessagesType.InfoCommon, (string)j8G7Xa84d2GSjwBmWsSv(current));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
								{
									num3 = 0;
								}
								continue;
							}
							break;
						}
						goto IL_00aa;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			}
		}

		static Tester()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					errorStart = (string)ncVx5k84lTW9aDb5nt5T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA34534));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 2:
					SingletonReader.JJCZtPuTvSt();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static object wWqd6e84AceRHEOw5s1x(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool x964ob846ojrgn2Jn7lV()
		{
			return cH6ve38447FjMj6XQ8Sa == null;
		}

		internal static Tester mUaJN684HE1Hc3SDcjRx()
		{
			return cH6ve38447FjMj6XQ8Sa;
		}

		internal static object wHZhSS847mANpuMBX164(object P_0, object P_1)
		{
			return (string)P_0 + (string)P_1;
		}

		internal static int BkgONJ84xHwU2DHTpgNY(object P_0, object P_1)
		{
			return ((string)P_0).IndexOf((string)P_1);
		}

		internal static object RTUk3W8404o92Wds782R(object P_0, int P_1, int P_2)
		{
			return ((string)P_0).Substring(P_1, P_2);
		}

		internal static Type j3rNHu84mIlJIkkQ2ykE(object P_0)
		{
			return Type.GetType((string)P_0);
		}

		internal static bool AeJ4T984yYLdFvnpQ9bC(Type P_0, Type P_1)
		{
			return P_0 == P_1;
		}

		internal static bool fD9FMP84MIkEfP9vQ2xK(Type P_0, Type P_1)
		{
			return P_0 != P_1;
		}

		internal static object Od796p84J14PiVLfgoqv(object P_0, int P_1, int P_2)
		{
			return ((string)P_0).Remove(P_1, P_2);
		}

		internal static bool Exmrcp849qKRIa0cE2C0(object P_0)
		{
			return string.IsNullOrWhiteSpace((string)P_0);
		}

		internal static object j8G7Xa84d2GSjwBmWsSv(object P_0)
		{
			return ((TestImportMessages)P_0).Text;
		}

		internal static object ncVx5k84lTW9aDb5nt5T(object P_0)
		{
			return SR.T((string)P_0);
		}
	}

	private static ILogger defaultLogger;

	private readonly IModuleMetadataLoader moduleMetadataLoader;

	private readonly IModulePublishDataProvider modulePublishDataProvider;

	private readonly ITagService tagService;

	private readonly ISessionProvider sessionProvider;

	internal static ModuleItemImportSaveActions kuxwdlEJbOa01BZYMwgq;

	private ISession Session => sessionProvider.GetSession(string.Empty);

	public ModuleItemImportSaveActions(IModuleMetadataLoader moduleMetadataLoader, IModulePublishDataProvider modulePublishDataProvider, ITagService tagService, ISessionProvider sessionProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		wQ1I5kEJE0h2aeYQCCjy();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
		{
			num = 4;
		}
		while (true)
		{
			switch (num)
			{
			default:
				this.modulePublishDataProvider = modulePublishDataProvider;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num = 2;
				}
				break;
			case 2:
				this.tagService = tagService;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num = 1;
				}
				break;
			case 4:
				this.moduleMetadataLoader = moduleMetadataLoader;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				this.sessionProvider = sessionProvider;
				num = 3;
				break;
			case 3:
				return;
			}
		}
	}

	public override bool IsSupported(Guid typeGuid)
	{
		return typeGuid == DneLHHEJf7MSD7mF2Jrv();
	}

	public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
	{
		int num = 1;
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = default(_003C_003Ec__DisplayClass7_0);
		TestModuleImportSettings testModuleImportSettings = default(TestModuleImportSettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					CS_0024_003C_003E8__locals0.result = result;
					num2 = 5;
					continue;
				case 6:
					if (testModuleImportSettings == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num2 = 3;
						}
					}
					else
					{
						SFvceYEJvbFet49kq0gN(Vo3a1NEJCYuFNdCFpBW9(data));
						num2 = 7;
					}
					continue;
				case 7:
					QAUuQbEJ87qCmxrceHJF(CS_0024_003C_003E8__locals0.testModuleImportSettings, new Tester((XmlReader)Vo3a1NEJCYuFNdCFpBW9(data), CS_0024_003C_003E8__locals0.testModuleImportSettings, moduleMetadataLoader, modulePublishDataProvider, tagService, Logger, Deserializer, CheckName).Test(CS_0024_003C_003E8__locals0.testModuleImportSettings.ModuleMetadataContext));
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 3;
					}
					continue;
				case 8:
					return;
				case 5:
					CS_0024_003C_003E8__locals0._003C_003E4__this = this;
					num2 = 4;
					continue;
				case 2:
					return;
				case 3:
					CS_0024_003C_003E8__locals0.result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)xixuUrEJQA0DUgTDOpN2(-542721635 ^ -543000111), xixuUrEJQA0DUgTDOpN2(-1824388195 ^ -1824077165))));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 2;
					}
					continue;
				case 4:
					testModuleImportSettings = (CS_0024_003C_003E8__locals0.testModuleImportSettings = data?.ConfigImportSettings as TestModuleImportSettings);
					num = 6;
					break;
				}
				break;
			}
		}
		static ModuleInfoMetadata Deserializer(string metadata)
		{
			return ClassSerializationHelper.DeserializeObjectByXml<ModuleInfoMetadata>(metadata);
		}
	}

	static ModuleItemImportSaveActions()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				defaultLogger = Logger.Log;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void wQ1I5kEJE0h2aeYQCCjy()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool YGtKPJEJhJAfEaxpVRpf()
	{
		return kuxwdlEJbOa01BZYMwgq == null;
	}

	internal static ModuleItemImportSaveActions hLdv5TEJGG5IHlGEO9bw()
	{
		return kuxwdlEJbOa01BZYMwgq;
	}

	internal static Guid DneLHHEJf7MSD7mF2Jrv()
	{
		return ModuleMetadataItem.UID;
	}

	internal static object xixuUrEJQA0DUgTDOpN2(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Vo3a1NEJCYuFNdCFpBW9(object P_0)
	{
		return ((ImportTestReadData)P_0).Reader;
	}

	internal static XmlNodeType SFvceYEJvbFet49kq0gN(object P_0)
	{
		return ((XmlReader)P_0).MoveToContent();
	}

	internal static void QAUuQbEJ87qCmxrceHJF(object P_0, object P_1)
	{
		((TestModuleImportSettings)P_0).ModuleMetadata = (ModuleInfoMetadata)P_1;
	}
}
