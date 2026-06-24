using System;
using System.IO;
using System.Threading;
using EleWise.ELMA.Packaging.Logging;

namespace EleWise.ELMA.Packaging.FileSystems;

public static class FSHelper
{
	public static void CreateFile(string fileName, Stream stream, TimeSpan timeout, DateTime? creationTime = null, DateTime? lastWriteTime = null)
	{
		if (string.IsNullOrEmpty(fileName))
		{
			throw new ArgumentNullException("fileName");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		FileStream outputStream = null;
		string dir = Path.GetDirectoryName(fileName);
		ExecuteWithTimeout(delegate
		{
			CreateDirectory(dir, timeout);
			outputStream = File.Create(fileName);
		}, timeout, SR.T("Не удалось создать файл '{0}'.", fileName));
		if (outputStream == null)
		{
			return;
		}
		try
		{
			stream.CopyTo(outputStream);
			if (creationTime.HasValue)
			{
				FileNative.SetCreationTime(outputStream.SafeFileHandle, creationTime.Value);
			}
			if (lastWriteTime.HasValue)
			{
				FileNative.SetLastWriteTime(outputStream.SafeFileHandle, lastWriteTime.Value);
			}
		}
		finally
		{
			outputStream.Dispose();
		}
	}

	public static void CreateFile(string fileName, Action createAction, TimeSpan timeout)
	{
		if (string.IsNullOrEmpty(fileName))
		{
			throw new ArgumentNullException("fileName");
		}
		if (createAction == null)
		{
			throw new ArgumentNullException("stream");
		}
		string dir = Path.GetDirectoryName(fileName);
		ExecuteWithTimeout(delegate
		{
			CreateDirectory(dir, timeout);
			createAction();
		}, timeout, SR.T("Не удалось создать файл '{0}'.", fileName));
	}

	public static void DeleteFile(string fileName, TimeSpan timeout)
	{
		if (string.IsNullOrEmpty(fileName))
		{
			throw new ArgumentNullException("fileName");
		}
		ExecuteWithTimeout(delegate
		{
			if (File.Exists(fileName))
			{
				File.Delete(fileName);
			}
		}, timeout, SR.T("Не удалось удалить файл '{0}'.", fileName));
	}

	public static void MoveFile(string sourceFileName, string targetFileName, TimeSpan timeout)
	{
		if (string.IsNullOrEmpty(sourceFileName))
		{
			throw new ArgumentNullException("sourceFileName");
		}
		if (string.IsNullOrEmpty(targetFileName))
		{
			throw new ArgumentNullException("targetFileName");
		}
		string dir = Path.GetDirectoryName(targetFileName);
		ExecuteWithTimeout(delegate
		{
			if (!Directory.Exists(dir))
			{
				CreateDirectory(dir, timeout);
			}
			File.Move(sourceFileName, targetFileName);
		}, timeout, SR.T("Не удалось переместить файл '{0}' -> {1}.", sourceFileName, targetFileName));
	}

	public static void CreateDirectory(string path, TimeSpan timeout)
	{
		if (string.IsNullOrEmpty(path))
		{
			throw new ArgumentNullException("path");
		}
		ExecuteWithTimeout(delegate
		{
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
		}, timeout, SR.T("Не удалось создать папку '{0}'.", path));
	}

	public static void DeleteDirectory(string path, bool recursive, TimeSpan timeout)
	{
		if (string.IsNullOrEmpty(path))
		{
			throw new ArgumentNullException("path");
		}
		ExecuteWithTimeout(delegate
		{
			if (Directory.Exists(path))
			{
				Directory.Delete(path, recursive);
			}
		}, timeout, SR.T("Не удалось удалить папку '{0}'.", path));
	}

	private static void ExecuteWithTimeout(Action action, TimeSpan timeout, string errorMessage)
	{
		DateTime now = DateTime.Now;
		int num = 0;
		while (true)
		{
			try
			{
				action();
				break;
			}
			catch (Exception ex)
			{
				if (DateTime.Now - now > timeout)
				{
					throw new InvalidOperationException(errorMessage, ex);
				}
				num++;
				Logger.Log.Debug(errorMessage + " " + SR.T("Попытка {0}.", num), ex);
				Thread.Sleep(100);
			}
		}
	}
}
