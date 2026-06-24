using System;
using EleWise.ELMA.Files;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Services;

internal abstract class ExportImportFileServiceBase : IExportImportFileService
{
	internal static ExportImportFileServiceBase eNSJdnE4LwSEc2uBGDI5;

	public virtual void AddToFile(string id, BinaryFile file)
	{
		throw new NotImplementedException();
	}

	public virtual void AddToFile(string id, byte[] buf)
	{
		throw new NotImplementedException();
	}

	public virtual void AddToNestedFile(string id, string nestedId, string path, byte[] buf)
	{
		throw new NotImplementedException();
	}

	public virtual void AddToNestedFile(string id, string nestedId, string fileExtension, string path, byte[] buf)
	{
		throw new NotImplementedException();
	}

	public virtual string CreateDeployFolderName(string id)
	{
		throw new NotImplementedException();
	}

	public virtual string CreateDeployFolderName(string id, string folder)
	{
		throw new NotImplementedException();
	}

	public virtual string CreateFileName(string id, string name, string ext)
	{
		throw new NotImplementedException();
	}

	public virtual string CreateFileName(string id, string folder, string name, string ext)
	{
		throw new NotImplementedException();
	}

	public virtual string CreateFolderName(string id)
	{
		throw new NotImplementedException();
	}

	public virtual string CreateZipFileName(string id)
	{
		throw new NotImplementedException();
	}

	public virtual string CreateZipFileName(string id, string ext)
	{
		throw new NotImplementedException();
	}

	public virtual void DeleteFiles(string id)
	{
		throw new NotImplementedException();
	}

	public virtual void DeleteFiles(string id, string ext)
	{
		throw new NotImplementedException();
	}

	public virtual bool Exists(string id, string ext)
	{
		throw new NotImplementedException();
	}

	public virtual bool Exists(string id)
	{
		throw new NotImplementedException();
	}

	public virtual long GetBufferLength()
	{
		throw new NotImplementedException();
	}

	public virtual string GetFilesFolderName()
	{
		throw new NotImplementedException();
	}

	public virtual string GetFilesFolderPath()
	{
		throw new NotImplementedException();
	}

	public virtual byte[] LoadFile(string id, long i)
	{
		throw new NotImplementedException();
	}

	public virtual byte[] LoadFile(string id, long i, string ext)
	{
		throw new NotImplementedException();
	}

	public virtual void LoadFileToCache(string fileName, string fullFileName, Guid uid)
	{
		throw new NotImplementedException();
	}

	protected ExportImportFileServiceBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BFAg3lE4cFwC2vZ2vXGl();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void BFAg3lE4cFwC2vZ2vXGl()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool NqEV1RE4UeM3kJUeJCnr()
	{
		return eNSJdnE4LwSEc2uBGDI5 == null;
	}

	internal static ExportImportFileServiceBase hNW4TME4sguqqTqwOZkR()
	{
		return eNSJdnE4LwSEc2uBGDI5;
	}
}
