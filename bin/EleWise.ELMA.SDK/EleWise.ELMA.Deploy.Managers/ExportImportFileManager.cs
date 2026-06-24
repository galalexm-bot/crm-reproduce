using System;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Managers;

public class ExportImportFileManager : DTOManager, IExportImportFileManager, IConfigurationService
{
	internal static ExportImportFileManager r6AAMwEt11xrifuNsCI7;

	protected IExportImportFileService ExportImportFileService => Locator.GetServiceNotNull<IExportImportFileService>();

	public virtual long GetBufferLength()
	{
		return ExportImportFileService.GetBufferLength();
	}

	public virtual string CreateFolderName(string id)
	{
		return (string)zqvWcKEtpl0UisC7gk7M(ExportImportFileService, id);
	}

	public virtual string CreateDeployFolderName(string id)
	{
		return (string)b9eCmrEtaMttFUD2rguU(ExportImportFileService, id);
	}

	public virtual string CreateZipFileName(string id)
	{
		return (string)AQKUM2EtDqucFEW7PEcF(ExportImportFileService, id);
	}

	public virtual string CreateFileName(string id)
	{
		return ExportImportFileService.CreateFileName(id, null, null);
	}

	public virtual string CreateFileName(string id, string name, string ext)
	{
		return ExportImportFileService.CreateFileName(id, name, ext);
	}

	public virtual byte[] LoadFile(string id, long i)
	{
		return (byte[])iVXidXEtt64941Ebs1rK(ExportImportFileService, id, i);
	}

	public virtual void DeleteFiles(string id)
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
				ExportImportFileService.DeleteFiles(id);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual void AddToFile(string id, byte[] buf)
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
				ExportImportFileService.AddToFile(id, buf);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual void AddToNestedFile(string id, string nestedId, string path, byte[] buf)
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
				k1ij3PEtwdtP3dvswM4O(ExportImportFileService, id, nestedId, path, buf);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual void LoadFileToCache(string fileName, string fullFileName, Guid uid)
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
				F4Ca20Et4RnPsKGxOBj9(ExportImportFileService, fileName, fullFileName, uid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public ExportImportFileManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sqHhLhEt6gvrmDN1gCHf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool MwJ94GEtNBhHkjRPCyEj()
	{
		return r6AAMwEt11xrifuNsCI7 == null;
	}

	internal static ExportImportFileManager rttCf0Et3hReWsuILExk()
	{
		return r6AAMwEt11xrifuNsCI7;
	}

	internal static object zqvWcKEtpl0UisC7gk7M(object P_0, object P_1)
	{
		return ((IExportImportFileService)P_0).CreateFolderName((string)P_1);
	}

	internal static object b9eCmrEtaMttFUD2rguU(object P_0, object P_1)
	{
		return ((IExportImportFileService)P_0).CreateDeployFolderName((string)P_1);
	}

	internal static object AQKUM2EtDqucFEW7PEcF(object P_0, object P_1)
	{
		return ((IExportImportFileService)P_0).CreateZipFileName((string)P_1);
	}

	internal static object iVXidXEtt64941Ebs1rK(object P_0, object P_1, long i)
	{
		return ((IExportImportFileService)P_0).LoadFile((string)P_1, i);
	}

	internal static void k1ij3PEtwdtP3dvswM4O(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		((IExportImportFileService)P_0).AddToNestedFile((string)P_1, (string)P_2, (string)P_3, (byte[])P_4);
	}

	internal static void F4Ca20Et4RnPsKGxOBj9(object P_0, object P_1, object P_2, Guid uid)
	{
		((IExportImportFileService)P_0).LoadFileToCache((string)P_1, (string)P_2, uid);
	}

	internal static void sqHhLhEt6gvrmDN1gCHf()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
