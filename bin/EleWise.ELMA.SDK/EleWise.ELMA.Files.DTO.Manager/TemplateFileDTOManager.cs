using System;
using System.IO;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Files.DTO.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Impl;
using EleWise.ELMA.Templates;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files.DTO.Managers;

public class TemplateFileDTOManager : DTOManager, ITemplateFileDTOManager, IConfigurationService
{
	internal static TemplateFileDTOManager DJpISkGOBOgf1eWdrRGA;

	protected ITemplateFileManager FileTemplateManager => Locator.GetServiceNotNull<ITemplateFileManager>();

	public virtual string SaveTemplate(BinaryFileDTO binaryFile)
	{
		int num = 2;
		int num2 = num;
		BinaryFile binaryFile2 = default(BinaryFile);
		while (true)
		{
			switch (num2)
			{
			case 1:
				throw new ArgumentNullException((string)in1IYnGObYvLgWN32Sng(0x4785BC0D ^ 0x478415B5));
			default:
				return FileTemplateManager.SaveTemplate(binaryFile2);
			case 2:
				if (binaryFile != null)
				{
					binaryFile2 = Mapper.Map<BinaryFileDTO, BinaryFile>(binaryFile);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 1;
					}
				}
				break;
			}
		}
	}

	public virtual BinaryFileDTO LoadTemplate(string id)
	{
		//Discarded unreachable code: IL_00a2, IL_00b1
		int num = 2;
		BinaryFile binaryFile = default(BinaryFile);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					throw new ArgumentNullException((string)in1IYnGObYvLgWN32Sng(0x2A7797B7 ^ 0x2A76A4CD));
				case 2:
					if (id != null)
					{
						binaryFile = (BinaryFile)hhhIELGOhH7kcObDyhPq(FileTemplateManager, id);
						num2 = 3;
						continue;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					if (binaryFile != null)
					{
						break;
					}
					goto default;
				default:
					return null;
				case 4:
					return Mapper.Map<BinaryFile, BinaryFileDTO>(binaryFile);
				}
				break;
			}
			num = 4;
		}
	}

	public virtual BinaryFileDTO CreateFromTemplate(string id)
	{
		//Discarded unreachable code: IL_0087, IL_0096, IL_00a5
		int num = 3;
		int num2 = num;
		BinaryFile binaryFile = default(BinaryFile);
		while (true)
		{
			switch (num2)
			{
			case 5:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146579367));
			case 2:
				binaryFile = (BinaryFile)ME2r1fGOGBPTy5GkUew6(FileTemplateManager, id);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (id != null)
				{
					num2 = 2;
					break;
				}
				goto case 5;
			case 1:
				if (binaryFile != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto default;
			default:
				return null;
			case 4:
				return Mapper.Map<BinaryFile, BinaryFileDTO>(binaryFile);
			}
		}
	}

	public virtual BinaryFileDTO LoadSystemTemplate(string name)
	{
		//Discarded unreachable code: IL_00ed
		int num = 7;
		int num2 = num;
		byte[] array = default(byte[]);
		string text = default(string);
		string name2 = default(string);
		string text2 = default(string);
		string text3 = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				array = (byte[])CQsyOUGOCiR3UhKTkQLN(text);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				return null;
			case 3:
				name2 = (string)cqUVg5GOQFJvF9PjbSZh(text);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				text2 = (string)yrvh5mGO8LcZOnC6xmsT(Locator.GetServiceNotNull<MimeMappingService>(), text3);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				text3 = (string)W7HRU3GOvVNxMh8vew6E(text);
				num2 = 5;
				break;
			case 1:
			{
				BinaryFileDTO obj = new BinaryFileDTO
				{
					Name = name2
				};
				vWRglYGOZ9OihSwl5G0S(obj, array);
				cu6MquGOud2IRwQeaDkW(obj, text2);
				DutiIdGOIOU17g0sEb1u(obj, DateTime.Now);
				return obj;
			}
			case 6:
				if (!X9ndOQGOfhTpKOpZOF0l(text))
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 7:
				text = (string)Exbb1wGOEWItQfkyiieM(TemplateLoader.Instance, name);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	public virtual string GetTemplateFileServerPath(string id)
	{
		return (string)aZFkD1GOVj6YScqagTKt(FileTemplateManager, id);
	}

	public TemplateFileDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vouQHcGOSFMZtq8071IF();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object in1IYnGObYvLgWN32Sng(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool HZ9QsVGOWqQnc4R5iaCu()
	{
		return DJpISkGOBOgf1eWdrRGA == null;
	}

	internal static TemplateFileDTOManager ybaM8dGOoWUmgwkemUnQ()
	{
		return DJpISkGOBOgf1eWdrRGA;
	}

	internal static object hhhIELGOhH7kcObDyhPq(object P_0, object P_1)
	{
		return ((ITemplateFileManager)P_0).LoadTemplate((string)P_1);
	}

	internal static object ME2r1fGOGBPTy5GkUew6(object P_0, object P_1)
	{
		return ((ITemplateFileManager)P_0).CreateFromTemplate((string)P_1);
	}

	internal static object Exbb1wGOEWItQfkyiieM(object P_0, object P_1)
	{
		return ((TemplateLoader)P_0).LoadTemplate((string)P_1);
	}

	internal static bool X9ndOQGOfhTpKOpZOF0l(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object cqUVg5GOQFJvF9PjbSZh(object P_0)
	{
		return Path.GetFileName((string)P_0);
	}

	internal static object CQsyOUGOCiR3UhKTkQLN(object P_0)
	{
		return File.ReadAllBytes((string)P_0);
	}

	internal static object W7HRU3GOvVNxMh8vew6E(object P_0)
	{
		return Path.GetExtension((string)P_0);
	}

	internal static object yrvh5mGO8LcZOnC6xmsT(object P_0, object P_1)
	{
		return ((MimeMappingService)P_0).GetTypeByExtension((string)P_1);
	}

	internal static void vWRglYGOZ9OihSwl5G0S(object P_0, object P_1)
	{
		((BinaryFileDTO)P_0).Content = (byte[])P_1;
	}

	internal static void cu6MquGOud2IRwQeaDkW(object P_0, object P_1)
	{
		((BinaryFileDTO)P_0).ContentType = (string)P_1;
	}

	internal static void DutiIdGOIOU17g0sEb1u(object P_0, DateTime value)
	{
		((BinaryFileDTO)P_0).CreateDate = value;
	}

	internal static object aZFkD1GOVj6YScqagTKt(object P_0, object P_1)
	{
		return ((ITemplateFileManager)P_0).GetTemplateFileServerPath((string)P_1);
	}

	internal static void vouQHcGOSFMZtq8071IF()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
