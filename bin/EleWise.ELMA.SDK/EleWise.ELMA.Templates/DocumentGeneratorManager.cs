using System;
using System.IO;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Templates.TemplateGenerator;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Templates;

[Service]
[PublicApiMember("DocumentGeneratorServicesApi", "SR.M('Сервис генерации документов')", "SR.M('\r\n    /// <para>\r\n    /// <seealso href=\"http://www.elma-bpm.ru/kb/article-393.html\">Двойная генерация по шаблону</seealso>    \r\n    /// </para>\r\n    /// <code>\r\n    /// //Пример кода взят из статьи в базе знаний, посвящённой двойной генерации документа\r\n    /// <![CDATA[\r\n    /// var version = InterfaceActivator.Create<DocumentVersion>();\r\n    /// version.Document = context.Dokument;\r\n    /// var versionFile = Locator.GetServiceNotNull<IDocumentFileManager>().GetFileByDocumentId(context.Dokument.Id); \r\n    /// var file = Locator.GetServiceNotNull<ITemplateFileManager>().CreateFromTemplate(versionFile.Id); \r\n    /// // Создаем генератор \r\n    /// var generator = PublicAPI.Services.DocumentGenerator.Create(file);\r\n    /// // Генерируем документ \r\n    /// generator.Generate(context); \r\n    /// // Сохраняем файл сгенерированного документа \r\n    /// Locator.GetServiceNotNull<IFileManager>().SaveFile(file); \r\n    /// // Записываем результат в переменную \r\n    /// version.File=file;\r\n    /// version.Name = \"версия из генерации\";\r\n    /// //устанавливаем статус версии Текущая\r\n    /// version.Status = DocumentVersionStatus.Current;\r\n    /// version.File.Name=\"имя файла2.rtf\";\r\n    /// context.Dokument.Versions.Add(version);\r\n    /// context.Dokument.Save();\r\n    /// ]]>\r\n    /// </code>')")]
[DeveloperApi(DeveloperApiType.Service)]
public class DocumentGeneratorManager
{
	internal static DocumentGeneratorManager yfw6ukBPxqn5jH1Sqgl5;

	public virtual DocumentGeneratorBase Create(string templateFileName, IGeneratorProvider provider = null)
	{
		//Discarded unreachable code: IL_0041, IL_0088
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		IDocumentGeneratorProvider documentGeneratorProvider = default(IDocumentGeneratorProvider);
		while (true)
		{
			switch (num2)
			{
			case 5:
				throw new ArgumentNullException((string)TrFpUVBPMDMdtP3DOXBx(0x8317432 ^ 0x8304B92));
			default:
				_003C_003Ec__DisplayClass0_.ext = (string)NeM9ANBP96VBmLYOfA95(YyirXYBPJ66lCkSTTMaU(templateFileName));
				num2 = 7;
				break;
			case 3:
				if (!E7IvFSBPyurThUBAYJZo(templateFileName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 1:
				if (documentGeneratorProvider != null)
				{
					num2 = 2;
					break;
				}
				goto case 6;
			case 7:
				documentGeneratorProvider = ((ComponentManager)DTBwLCBPdgky5kQ6111f()).GetExtensionPoints<IDocumentGeneratorProvider>().FirstOrDefault(_003C_003Ec__DisplayClass0_._003CCreate_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				throw new InvalidOperationException(SR.T((string)TrFpUVBPMDMdtP3DOXBx(-2138160520 ^ -2138079812), _003C_003Ec__DisplayClass0_.ext));
			case 2:
				return documentGeneratorProvider.Create(templateFileName, provider ?? new ElmaGeneratorProvider());
			}
		}
	}

	public virtual DocumentGeneratorBase Create(Stream templateFileStream, string fileName, IGeneratorProvider provider = null)
	{
		int num = 6;
		int num2 = num;
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		IDocumentGeneratorProviderExtension documentGeneratorProviderExtension = default(IDocumentGeneratorProviderExtension);
		while (true)
		{
			switch (num2)
			{
			case 6:
				_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (documentGeneratorProviderExtension == null)
				{
					num2 = 2;
					break;
				}
				return documentGeneratorProviderExtension.Create(templateFileStream, provider ?? new ElmaGeneratorProvider());
			case 4:
				_003C_003Ec__DisplayClass1_.ext = (string)NeM9ANBP96VBmLYOfA95(YyirXYBPJ66lCkSTTMaU(fileName));
				num2 = 3;
				break;
			case 5:
				Contract.ArgumentNotNull(templateFileStream, (string)TrFpUVBPMDMdtP3DOXBx(-1822890472 ^ -1822841264));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				documentGeneratorProviderExtension = ((ComponentManager)DTBwLCBPdgky5kQ6111f()).GetExtensionPoints<IDocumentGeneratorProviderExtension>().FirstOrDefault(_003C_003Ec__DisplayClass1_._003CCreate_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				t6a1UxBPlJP5WuADRHsd(fileName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463A7126));
				num2 = 4;
				break;
			case 2:
				throw new InvalidOperationException(SR.T((string)TrFpUVBPMDMdtP3DOXBx(-234299632 ^ -234233644), _003C_003Ec__DisplayClass1_.ext));
			}
		}
	}

	[PublicApiNodeId("DocumentGeneratorServicesApi")]
	public virtual void Generate(BinaryFile file, object dataSource)
	{
		//Discarded unreachable code: IL_0087
		int num = 2;
		int num2 = num;
		string templateLocally = default(string);
		DocumentGeneratorBase documentGeneratorBase = default(DocumentGeneratorBase);
		while (true)
		{
			switch (num2)
			{
			case 2:
				templateLocally = GetTemplateLocally(file);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 1;
				}
				continue;
			default:
				UpdateBinaryFile(file, templateLocally);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 3;
				}
				continue;
			case 1:
				documentGeneratorBase = Create(templateLocally);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 5;
				}
				continue;
			case 4:
				if (documentGeneratorBase.LastExceptions == null)
				{
					num2 = 7;
					continue;
				}
				break;
			case 5:
				GqpFvnBPrCnKQH4MMLNE(documentGeneratorBase, dataSource);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 2;
				}
				continue;
			case 3:
				return;
			case 6:
				break;
			}
			documentGeneratorBase.LastExceptions.Each(delegate(Exception ex)
			{
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						((ILogger)_003C_003Ec.VxMntZQqxq6t3iFe2afx()).Error(_003C_003Ec.qF6shiQq0sXAVYfejj4F(ex), ex);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num4 = 0;
						}
						break;
					}
				}
			});
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
			{
				num2 = 0;
			}
		}
	}

	[PublicApiNodeId("DocumentGeneratorServicesApi")]
	public virtual void Generate(BinaryFile file, object dataSource, IGeneratorProvider provider)
	{
		//Discarded unreachable code: IL_006c
		int num = 3;
		string templateLocally = default(string);
		DocumentGeneratorBase documentGeneratorBase = default(DocumentGeneratorBase);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					UpdateBinaryFile(file, templateLocally);
					num2 = 4;
					continue;
				case 4:
					return;
				case 3:
					goto end_IL_0012;
				case 7:
					GqpFvnBPrCnKQH4MMLNE(documentGeneratorBase, dataSource);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					if (documentGeneratorBase.LastExceptions == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					break;
				case 2:
					documentGeneratorBase = Create(templateLocally, provider);
					num2 = 7;
					continue;
				case 6:
					break;
				}
				documentGeneratorBase.LastExceptions.Each(delegate(Exception ex)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							_003C_003Ec.HV0Q65QqmXYmPRD2diNR(Logger.Log, _003C_003Ec.qF6shiQq0sXAVYfejj4F(ex), ex);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			templateLocally = GetTemplateLocally(file);
			num = 2;
		}
	}

	private string GetTemplateLocally(BinaryFile file)
	{
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				MQg1GiBPji2dZkax6LZp(file, text);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return text;
			case 2:
				text = (string)TSnYh5BP5Hu6ZhYUdUHV(f6rOElBPgQB8I9jJhwGE(file));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void UpdateBinaryFile(BinaryFile file, string contentFilePath)
	{
		//Discarded unreachable code: IL_0076, IL_009e, IL_00de, IL_00ed, IL_00f9
		int num = 1;
		int num2 = num;
		FileStream fileStream = default(FileStream);
		while (true)
		{
			switch (num2)
			{
			case 3:
				gMrknGBPLf8ktdncTTLf(contentFilePath);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			default:
				try
				{
					((IBinaryFileStreams)Ps0BsCBPY2OmAJ1wIU8v()).PutContent(file, (Stream)fileStream, (PutContentOptions)null);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				finally
				{
					int num4;
					if (fileStream == null)
					{
						num4 = 2;
						goto IL_00a2;
					}
					goto IL_00b8;
					IL_00a2:
					switch (num4)
					{
					default:
						goto end_IL_008d;
					case 1:
						break;
					case 2:
						goto end_IL_008d;
					case 0:
						goto end_IL_008d;
					}
					goto IL_00b8;
					IL_00b8:
					((IDisposable)fileStream).Dispose();
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num4 = 0;
					}
					goto IL_00a2;
					end_IL_008d:;
				}
				goto case 3;
			case 1:
				fileStream = new FileStream(contentFilePath, FileMode.Open, FileAccess.Read);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[PublicApiNodeId("DocumentGeneratorServicesApi")]
	public virtual BinaryFile GenerateToBinaryFile(BinaryFile templateFile, object dataSource)
	{
		int num = 2;
		string templateLocally = default(string);
		DocumentGeneratorBase documentGeneratorBase = default(DocumentGeneratorBase);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					break;
				case 2:
					templateLocally = GetTemplateLocally(templateFile);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					if (documentGeneratorBase.LastExceptions != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 3:
					return ((BinaryFileBuilder)Lj2t3OBPUxIljxLG4vGi(templateFile)).Content(templateLocally, deleteContentFileAfterSave: true).Build();
				case 5:
					GqpFvnBPrCnKQH4MMLNE(documentGeneratorBase, dataSource);
					num2 = 4;
					continue;
				default:
					documentGeneratorBase.LastExceptions.Each(delegate(Exception ex)
					{
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								_003C_003Ec.HV0Q65QqmXYmPRD2diNR(_003C_003Ec.VxMntZQqxq6t3iFe2afx(), _003C_003Ec.qF6shiQq0sXAVYfejj4F(ex), ex);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					});
					num2 = 3;
					continue;
				}
				break;
			}
			documentGeneratorBase = Create(templateLocally);
			num = 5;
		}
	}

	public DocumentGeneratorManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		UrISpVBPskqyLjoQ7UZH();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool E7IvFSBPyurThUBAYJZo(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object TrFpUVBPMDMdtP3DOXBx(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object YyirXYBPJ66lCkSTTMaU(object P_0)
	{
		return Path.GetExtension((string)P_0);
	}

	internal static object NeM9ANBP96VBmLYOfA95(object P_0)
	{
		return ((string)P_0).ToUpper();
	}

	internal static object DTBwLCBPdgky5kQ6111f()
	{
		return ComponentManager.Current;
	}

	internal static bool XnFFlcBP0u6OS79wHvIh()
	{
		return yfw6ukBPxqn5jH1Sqgl5 == null;
	}

	internal static DocumentGeneratorManager WGOl9FBPmMvMUcldHEkA()
	{
		return yfw6ukBPxqn5jH1Sqgl5;
	}

	internal static void t6a1UxBPlJP5WuADRHsd(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static void GqpFvnBPrCnKQH4MMLNE(object P_0, object P_1)
	{
		((DocumentGeneratorBase)P_0).Generate(P_1);
	}

	internal static object f6rOElBPgQB8I9jJhwGE(object P_0)
	{
		return ((BinaryFile)P_0).Extension;
	}

	internal static object TSnYh5BP5Hu6ZhYUdUHV(object P_0)
	{
		return IOExtensions.GetTempFileName((string)P_0);
	}

	internal static void MQg1GiBPji2dZkax6LZp(object P_0, object P_1)
	{
		((BinaryFile)P_0).SaveToLocalPath((string)P_1);
	}

	internal static object Ps0BsCBPY2OmAJ1wIU8v()
	{
		return DataAccessManager.BinaryFileStreams;
	}

	internal static void gMrknGBPLf8ktdncTTLf(object P_0)
	{
		File.Delete((string)P_0);
	}

	internal static object Lj2t3OBPUxIljxLG4vGi(object P_0)
	{
		return BinaryFile.CreateFrom((BinaryFile)P_0);
	}

	internal static void UrISpVBPskqyLjoQ7UZH()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
