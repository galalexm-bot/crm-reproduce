using System;

namespace EleWise.ELMA.Packaging.FileSystems.Actions;

public class MoveFileAction : FSAction
{
	private string _sourceFileName;

	private string _targetFileName;

	public MoveFileAction(string sourceFileName, string targetFileName)
	{
		if (string.IsNullOrEmpty(sourceFileName))
		{
			throw new ArgumentNullException("sourceFileName");
		}
		if (string.IsNullOrEmpty(targetFileName))
		{
			throw new ArgumentNullException("targetFileName");
		}
		_sourceFileName = sourceFileName;
		_targetFileName = targetFileName;
	}

	public override void Commit()
	{
	}

	public override void Rollback()
	{
		FSHelper.MoveFile(_targetFileName, _sourceFileName, base.Transaction.ActionTimeout);
	}

	public override string ToString()
	{
		return SR.T("Перемещение файла из '{0}' в '{1}'", _sourceFileName, _targetFileName);
	}

	protected override void ExecuteCore()
	{
		FS.MoveFile(_sourceFileName, _targetFileName);
	}
}
