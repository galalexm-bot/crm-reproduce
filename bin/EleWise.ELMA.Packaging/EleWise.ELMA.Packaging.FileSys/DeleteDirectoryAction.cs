using System;
using System.IO;
using System.Linq;

namespace EleWise.ELMA.Packaging.FileSystems.Actions;

public class DeleteDirectoryAction : FSAction
{
	private string _path;

	private bool _deleteEmptyDirs;

	private string _emptyDirsRoot;

	private bool _executed;

	public DeleteDirectoryAction(string path, bool deleteEmptyDirs, string emptyDirsRoot)
	{
		if (string.IsNullOrEmpty(path))
		{
			throw new ArgumentNullException("path");
		}
		_path = path;
		_deleteEmptyDirs = deleteEmptyDirs;
		_emptyDirsRoot = emptyDirsRoot;
	}

	public override void Commit()
	{
	}

	public override void Rollback()
	{
		if (_executed)
		{
			FSHelper.CreateDirectory(_path, base.Transaction.ActionTimeout);
		}
	}

	protected override void ExecuteCore()
	{
		if (!Directory.Exists(_path))
		{
			return;
		}
		FSHelper.DeleteDirectory(_path, recursive: false, base.Transaction.ActionTimeout);
		_executed = true;
		if (_deleteEmptyDirs && !string.IsNullOrEmpty(_emptyDirsRoot))
		{
			int num = _emptyDirsRoot.Count((char ch) => ch == '\\');
			string directoryName = Path.GetDirectoryName(_path);
			while (directoryName.Count((char ch) => ch == '\\') >= num)
			{
				DeleteDirectoryIfEmpty(directoryName);
				directoryName = Path.GetDirectoryName(directoryName);
			}
		}
	}

	public override string ToString()
	{
		return SR.T("Удаление папки '{0}'", _path);
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
