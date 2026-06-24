using System;
using System.IO;

namespace EleWise.ELMA.Packaging.FileSystems.Actions;

public class CreateFileAction : FSAction
{
	private string _fileName;

	private Stream _stream;

	private Action _createAction;

	private DateTime? _creationTime;

	private DateTime? _lastWriteTime;

	private string _oldFileName;

	private bool _executed;

	public CreateFileAction(string fileName, Stream stream, DateTime? creationTime, DateTime? lastWriteTime)
	{
		if (string.IsNullOrEmpty(fileName))
		{
			throw new ArgumentNullException("fileName");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		_fileName = fileName;
		_stream = stream;
		_creationTime = creationTime;
		_lastWriteTime = lastWriteTime;
	}

	public CreateFileAction(string fileName, Action createAction)
	{
		if (string.IsNullOrEmpty(fileName))
		{
			throw new ArgumentNullException("fileName");
		}
		if (createAction == null)
		{
			throw new ArgumentNullException("createAction");
		}
		_fileName = fileName;
		_createAction = createAction;
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
		if (_executed && File.Exists(_fileName))
		{
			FSHelper.DeleteFile(_fileName, base.Transaction.ActionTimeout);
		}
		if (!string.IsNullOrEmpty(_oldFileName))
		{
			FSHelper.MoveFile(_oldFileName, _fileName, base.Transaction.ActionTimeout);
		}
	}

	public override string ToString()
	{
		return SR.T("Создание файла '{0}'", _fileName);
	}

	protected override void ExecuteCore()
	{
		if (File.Exists(_fileName))
		{
			_oldFileName = base.Transaction.BackupFile(_fileName);
		}
		if (_stream != null)
		{
			try
			{
				FSHelper.CreateFile(_fileName, _stream, base.Transaction.ActionTimeout, _creationTime, _lastWriteTime);
			}
			finally
			{
				_stream = null;
			}
		}
		else if (_createAction != null)
		{
			_createAction();
		}
		_executed = true;
	}
}
