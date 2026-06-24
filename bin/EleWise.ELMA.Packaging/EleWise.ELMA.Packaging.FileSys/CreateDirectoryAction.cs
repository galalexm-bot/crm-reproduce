using System;
using System.IO;

namespace EleWise.ELMA.Packaging.FileSystems.Actions;

public class CreateDirectoryAction : FSAction
{
	private string _path;

	private bool _executed;

	public CreateDirectoryAction(string path)
	{
		if (string.IsNullOrEmpty(path))
		{
			throw new ArgumentNullException("path");
		}
		_path = path;
	}

	public override void Commit()
	{
	}

	public override void Rollback()
	{
		if (_executed && Directory.Exists(_path) && Directory.GetFiles(_path).Length == 0 && Directory.GetDirectories(_path).Length == 0)
		{
			FSHelper.DeleteDirectory(_path, recursive: false, base.Transaction.ActionTimeout);
		}
	}

	protected override void ExecuteCore()
	{
		if (!Directory.Exists(_path))
		{
			FSHelper.CreateDirectory(_path, base.Transaction.ActionTimeout);
			_executed = true;
		}
	}

	public override string ToString()
	{
		return SR.T("Создание папки '{0}'", _path);
	}
}
