using System;
using System.IO;

namespace EleWise.ELMA.Packaging.FileSystems.Actions;

public class CopyFileAction : FSAction
{
	private string _sourceFileName;

	private string _targetFileName;

	private bool _overwrite;

	private string _oldFileName;

	private bool _executed;

	public CopyFileAction(string sourceFileName, string targetFileName, bool overwrite)
	{
		if (string.IsNullOrEmpty(sourceFileName))
		{
			throw new ArgumentNullException("sourceFileName");
		}
		if (targetFileName == null)
		{
			throw new ArgumentNullException("targetFileName");
		}
		_sourceFileName = sourceFileName;
		_targetFileName = targetFileName;
		_overwrite = overwrite;
	}

	public override void Commit()
	{
		if (!string.IsNullOrEmpty(_oldFileName))
		{
			FSHelper.DeleteFile(_oldFileName, base.Transaction.ActionTimeout);
		}
	}

	public override void Rollback()
	{
		if (_executed && File.Exists(_targetFileName))
		{
			FSHelper.DeleteFile(_targetFileName, base.Transaction.ActionTimeout);
		}
		if (!string.IsNullOrEmpty(_oldFileName))
		{
			FSHelper.MoveFile(_oldFileName, _targetFileName, base.Transaction.ActionTimeout);
		}
	}

	public override string ToString()
	{
		return SR.T("Копирование файла из '{0}' в {1}", _sourceFileName, _targetFileName);
	}

	protected override void ExecuteCore()
	{
		if (!File.Exists(_sourceFileName))
		{
			throw new FileNotFoundException(_sourceFileName);
		}
		if (File.Exists(_targetFileName))
		{
			if (!_overwrite)
			{
				throw new IOException(SR.T("Файл '{0}' уже существует", _targetFileName));
			}
			_oldFileName = base.Transaction.BackupFile(_targetFileName);
		}
		File.Copy(_sourceFileName, _targetFileName, overwrite: true);
		_executed = true;
	}
}
