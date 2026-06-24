using System;
using System.IO;
using EleWise.ELMA.Packaging.FileSystems.Actions;

namespace EleWise.ELMA.Packaging.FileSystems;

public static class FS
{
	private static readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10.0);

	public static void CreateFile(string fileName, Stream stream, DateTime? creationTime = null, DateTime? lastWriteTime = null)
	{
		if (FSTransaction.IsActive)
		{
			new CreateFileAction(fileName, stream, creationTime, lastWriteTime).Execute();
			FSTransaction.Current.RememberCreatedFile(fileName);
		}
		else
		{
			FSHelper.CreateFile(fileName, stream, DefaultTimeout, creationTime, lastWriteTime);
		}
	}

	public static void CreateFile(string fileName, Action createAction)
	{
		if (createAction == null)
		{
			throw new ArgumentNullException("createAction");
		}
		if (FSTransaction.IsActive)
		{
			new CreateFileAction(fileName, createAction).Execute();
			FSTransaction.Current.RememberCreatedFile(fileName);
			return;
		}
		if (File.Exists(fileName))
		{
			File.Delete(fileName);
		}
		createAction();
	}

	public static void CopyFile(string sourceFileName, string targetFileName, bool overwrite)
	{
		if (FSTransaction.IsActive)
		{
			new CopyFileAction(sourceFileName, targetFileName, overwrite).Execute();
			FSTransaction.Current.RememberCreatedFile(targetFileName);
		}
		else
		{
			File.Copy(sourceFileName, targetFileName, overwrite);
		}
	}

	public static void MoveFile(string sourceFileName, string targetFileName)
	{
		if (FSTransaction.IsActive)
		{
			new MoveFileAction(sourceFileName, targetFileName).Execute();
		}
		else
		{
			FSHelper.MoveFile(sourceFileName, targetFileName, DefaultTimeout);
		}
	}

	public static void DeleteFile(string fileName, bool deleteEmptyDirs = false, string emptyDirsRoot = null)
	{
		if (FSTransaction.IsActive)
		{
			if (!FSTransaction.Current.WasFileCreated(fileName))
			{
				new DeleteFileAction(fileName, deleteEmptyDirs, emptyDirsRoot).Execute();
			}
		}
		else
		{
			FSHelper.DeleteFile(fileName, DefaultTimeout);
		}
	}

	public static void SafeDeleteFile(string fileName, bool deleteEmptyDirs = false, string emptyDirsRoot = null)
	{
		if (FSTransaction.IsActive)
		{
			DeleteFileAction deleteFileAction = new DeleteFileAction(fileName, deleteEmptyDirs, emptyDirsRoot);
			deleteFileAction.UseSafeDelete = true;
			deleteFileAction.Execute();
			return;
		}
		throw new InvalidOperationException(SR.T("Вызов метода доступен только при наличии активной файловой транзакции"));
	}

	public static void CreateDirectory(string path)
	{
		if (FSTransaction.IsActive)
		{
			new CreateDirectoryAction(path).Execute();
		}
		else
		{
			FSHelper.CreateDirectory(path, DefaultTimeout);
		}
	}

	public static void DeleteDirectory(string path, bool deleteEmptyDirs, string emptyDirsRoot)
	{
		if (FSTransaction.IsActive)
		{
			new DeleteDirectoryAction(path, deleteEmptyDirs, emptyDirsRoot).Execute();
		}
		else
		{
			FSHelper.DeleteDirectory(path, recursive: false, DefaultTimeout);
		}
	}
}
