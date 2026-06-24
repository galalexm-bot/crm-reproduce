using System;
using System.Collections.Generic;
using System.IO;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.DTO.Managers;
using EleWise.ELMA.Files.DTO.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public class RegulationTemplateDTOManager : DTOManager, IRegulationTemplateDTOManager, IConfigurationService
{
	private static RegulationTemplateDTOManager xL5VnVexi40yh65GYED;

	public static IRegulationTemplateDTOManager Instance => Locator.GetServiceNotNull<IRegulationTemplateDTOManager>();

	private ITemplateFileDTOManager templateFileManager => Locator.GetServiceNotNull<ITemplateFileDTOManager>();

	public virtual RegulationTemplateDTO Load(Guid uid)
	{
		//Discarded unreachable code: IL_0041, IL_0050, IL_010a
		int num = 4;
		int num2 = num;
		IRegulationTemplate regulationTemplate = default(IRegulationTemplate);
		RegulationTemplateDTO result = default(RegulationTemplateDTO);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return null;
			case 3:
				if (regulationTemplate != null)
				{
					if (!RqLMprehh9DgxoliSlF(regulationTemplate))
					{
						num2 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 6;
				}
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
				{
					num2 = 5;
				}
				break;
			default:
				return result;
			case 2:
			case 7:
				result = Mapper.Map<IRegulationTemplate, RegulationTemplateDTO>(regulationTemplate);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				result = SubstituteFileIsSystem(regulationTemplate);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				regulationTemplate = EntityManager<IRegulationTemplate>.Instance.LoadOrNull(uid);
				num2 = 3;
				break;
			}
		}
	}

	public virtual RegulationTemplateDTO Load(long id)
	{
		//Discarded unreachable code: IL_007d, IL_008c, IL_00c2
		int num = 1;
		int num2 = num;
		IRegulationTemplate regulationTemplate = default(IRegulationTemplate);
		RegulationTemplateDTO result = default(RegulationTemplateDTO);
		while (true)
		{
			switch (num2)
			{
			case 1:
				regulationTemplate = EntityManager<IRegulationTemplate>.Instance.LoadOrNull(id);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				result = SubstituteFileIsSystem(regulationTemplate);
				num2 = 6;
				break;
			case 4:
			case 5:
				result = Mapper.Map<IRegulationTemplate, RegulationTemplateDTO>(regulationTemplate);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
			case 6:
				return result;
			default:
				if (!RqLMprehh9DgxoliSlF(regulationTemplate))
				{
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public virtual RegulationTemplateDTO Save(RegulationTemplateDTO template, bool saveFromPath = true)
	{
		//Discarded unreachable code: IL_00c6, IL_0138, IL_0147
		int num = 5;
		byte[] array = default(byte[]);
		BinaryFileDTO binaryFileDTO2 = default(BinaryFileDTO);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (saveFromPath)
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 3;
				case 3:
				case 6:
				case 8:
				{
					IRegulationTemplate regulationTemplate = Mapper.Map<RegulationTemplateDTO, IRegulationTemplate>(template);
					regulationTemplate.Save();
					return Mapper.Map<IRegulationTemplate, RegulationTemplateDTO>(regulationTemplate);
				}
				case 1:
					array = File.ReadAllBytes((string)S6JTSOeEydXYaGdalSJ(template));
					num = 7;
					break;
				case 4:
					if (g3FtxDewJhQgTv6Ajyb(S6JTSOeEydXYaGdalSJ(template)))
					{
						num = 8;
						break;
					}
					goto case 2;
				default:
					vihFJlNZKPZeTDdXO9a(template, binaryFileDTO2);
					num = 6;
					break;
				case 2:
					if (!wcd7dve4OJZWuehAfdU(S6JTSOeEydXYaGdalSJ(template)))
					{
						num2 = 3;
						continue;
					}
					goto case 1;
				case 7:
				{
					BinaryFileDTO binaryFileDTO = new BinaryFileDTO();
					DrPXDXNK5bactPIwaQi(binaryFileDTO, wwC03eezKhIasnH7NQG(S6JTSOeEydXYaGdalSJ(template)));
					BDGvYBNORtfc7aaGtYH(binaryFileDTO, array);
					binaryFileDTO.CreateDate = DateTime.Now;
					binaryFileDTO2 = binaryFileDTO;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
					{
						num2 = 0;
					}
					continue;
				}
				}
				break;
			}
		}
	}

	public virtual RegulationTemplateDTO LoadSystemTemlate()
	{
		int num = 1;
		int num2 = num;
		BinaryFileDTO binaryFileDTO = default(BinaryFileDTO);
		RegulationTemplateDTO regulationTemplateDTO = default(RegulationTemplateDTO);
		while (true)
		{
			switch (num2)
			{
			default:
				binaryFileDTO = (BinaryFileDTO)vXU4tkN87kmfYcY3aUO(templateFileManager, xOATEkNYO3vm1LmFdva(regulationTemplateDTO));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				vihFJlNZKPZeTDdXO9a(regulationTemplateDTO, binaryFileDTO);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				regulationTemplateDTO = (RegulationTemplateDTO)rHcmulNvlgXblhellS2(this, ProcessRegulation.SystemRegulationTemplateUid);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return regulationTemplateDTO;
			}
		}
	}

	public virtual List<RegulationTemplateDTO> LoadAll(bool fileTemplateWithContent = true)
	{
		List<RegulationTemplateDTO> list = new List<RegulationTemplateDTO>();
		foreach (IRegulationTemplate item2 in EntityManager<IRegulationTemplate>.Instance.FindAll())
		{
			if (item2.IsSystem)
			{
				list.Add(SubstituteFileIsSystem(item2));
				continue;
			}
			RegulationTemplateDTO item = Mapper.Map<IRegulationTemplate, RegulationTemplateDTO>(item2);
			list.Add(item);
		}
		if (!fileTemplateWithContent)
		{
			list.ForEach(delegate(RegulationTemplateDTO a)
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
						_003C_003Ec.hlHl09ZrPNoQ84BUmGVc(a.File, null);
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			});
		}
		return list;
	}

	public virtual bool Delete(long id)
	{
		int num = 2;
		int num2 = num;
		IRegulationTemplate regulationTemplate = default(IRegulationTemplate);
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 1:
				if (regulationTemplate != null)
				{
					pC5JYYNswVDScEP0ZR7(regulationTemplate);
					num2 = 3;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return true;
			case 2:
				regulationTemplate = EntityManager<IRegulationTemplate>.Instance.LoadOrNull(id);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private RegulationTemplateDTO SubstituteFileIsSystem(IRegulationTemplate templ)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 1;
		int num2 = num;
		BinaryFileDTO file = default(BinaryFileDTO);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!RqLMprehh9DgxoliSlF(templ))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 4:
				file = (BinaryFileDTO)vXU4tkN87kmfYcY3aUO(templateFileManager, FvOj9VNlYhlTXLgKBS2(templ));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				TjRVmXNJLGZh6t9GTP3(templ, null);
				num2 = 4;
				break;
			case 3:
			{
				RegulationTemplateDTO regulationTemplateDTO = Mapper.Map<IRegulationTemplate, RegulationTemplateDTO>(templ);
				regulationTemplateDTO.File = file;
				return regulationTemplateDTO;
			}
			default:
				return null;
			}
		}
	}

	public RegulationTemplateDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		NfmBx1N0wNpjAjtqmuu();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool RqLMprehh9DgxoliSlF(object P_0)
	{
		return ((IRegulationTemplate)P_0).IsSystem;
	}

	internal static bool ccTJQJeSWhwpCZOLw1U()
	{
		return xL5VnVexi40yh65GYED == null;
	}

	internal static RegulationTemplateDTOManager AMsJaxe1whnnIAUaKMg()
	{
		return xL5VnVexi40yh65GYED;
	}

	internal static object S6JTSOeEydXYaGdalSJ(object P_0)
	{
		return ((RegulationTemplateDTO)P_0).Path;
	}

	internal static bool g3FtxDewJhQgTv6Ajyb(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static bool wcd7dve4OJZWuehAfdU(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object wwC03eezKhIasnH7NQG(object P_0)
	{
		return Path.GetFileName((string)P_0);
	}

	internal static void DrPXDXNK5bactPIwaQi(object P_0, object P_1)
	{
		((BinaryFileDTO)P_0).Name = (string)P_1;
	}

	internal static void BDGvYBNORtfc7aaGtYH(object P_0, object P_1)
	{
		((BinaryFileDTO)P_0).Content = (byte[])P_1;
	}

	internal static void vihFJlNZKPZeTDdXO9a(object P_0, object P_1)
	{
		((RegulationTemplateDTO)P_0).File = (BinaryFileDTO)P_1;
	}

	internal static object rHcmulNvlgXblhellS2(object P_0, Guid uid)
	{
		return ((RegulationTemplateDTOManager)P_0).Load(uid);
	}

	internal static object xOATEkNYO3vm1LmFdva(object P_0)
	{
		return ((RegulationTemplateDTO)P_0).FileName;
	}

	internal static object vXU4tkN87kmfYcY3aUO(object P_0, object P_1)
	{
		return ((ITemplateFileDTOManager)P_0).LoadSystemTemplate((string)P_1);
	}

	internal static void pC5JYYNswVDScEP0ZR7(object P_0)
	{
		((IEntity)P_0).Delete();
	}

	internal static void TjRVmXNJLGZh6t9GTP3(object P_0, object P_1)
	{
		((IRegulationTemplate)P_0).File = (BinaryFile)P_1;
	}

	internal static object FvOj9VNlYhlTXLgKBS2(object P_0)
	{
		return ((IRegulationTemplate)P_0).FileName;
	}

	internal static void NfmBx1N0wNpjAjtqmuu()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
