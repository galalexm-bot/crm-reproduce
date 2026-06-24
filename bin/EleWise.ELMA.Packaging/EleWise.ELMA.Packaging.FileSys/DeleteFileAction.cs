using System;
using System.IO;
using System.Linq;
using EleWise.ELMA.Packaging.Logging;

namespace EleWise.ELMA.Packaging.FileSystems.Actions;

public class DeleteFileAction : FSAction
{
	private string _fileName;

	private bool _deleteEmptyDirs;

	private string _emptyDirsRoot;

	private string _backupFileName;

	public bool UseSafeDelete { get; set; }

	public DeleteFileAction(string fileName, bool deleteEmptyDirs, string emptyDirsRoot)
	{
		if (string.IsNullOrEmpty(fileName))
		{
			throw new ArgumentNullException("fileName");
		}
		_fileName = fileName;
		_deleteEmptyDirs = deleteEmptyDirs;
		_emptyDirsRoot = emptyDirsRoot;
	}

	public override void Commit()
	{
		if (!string.IsNullOrEmpty(_backupFileName) && !UseSafeDelete)
		{
			FSHelper.DeleteFile(_backupFileName, base.Transaction.ActionTimeout);
		}
		if (!_deleteEmptyDirs || string.IsNullOrEmpty(_emptyDirsRoot))
		{
			return;
		}
		int num = _emptyDirsRoot.Count((char ch) => ch == '\\');
		string directoryName = Path.GetDirectoryName(_fileName);
		while (directoryName.Count((char ch) => ch == '\\') >= num)
		{
			try
			{
				if (!DeleteDirectoryIfEmpty(directoryName))
				{
					break;
				}
			}
			catch (Exception exception)
			{
				Logger.Log.Debug(SR.T("Не удалось удалить папку '{0}'.", directoryName), exception);
				break;
			}
			directoryName = Path.GetDirectoryName(directoryName);
		}
	}

	public override void Rollback()
	{
		if (!string.IsNullOrEmpty(_backupFileName))
		{
			FSHelper.MoveFile(_backupFileName, _fileName, base.Transaction.ActionTimeout);
		}
	}

	public override string ToString()
	{
		return SR.T("Удаление файла '{0}'", _fileName);
	}

	protected override void ExecuteCore()
	{
		if (File.Exists(_fileName))
		{
			_backupFileName = base.Transaction.BackupFile(_fileName);
		}
	}

	private bool DeleteDirectoryIfEmpty(string dirName)
	{
		if (Directory.Exists(dirName) && Directory.GetFiles(dirName).Length == 0 && (Directory.GetDirectories(dirName).Length == 0 || Directory.GetDirectories(dirName).All((string d) => DeleteDirectoryIfEmpty(d))))
		{
			FSHelper.DeleteDirectory(dirName, recursive: false, base.Transaction.ActionTimeout);
			return true;
		}
		return false;
	}
}
