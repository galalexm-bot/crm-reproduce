using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.Packaging.Logging;
using NuGet;

namespace EleWise.ELMA.Packaging.FileSystems;

public class FSTransaction : IFSTransaction, IDisposable
{
	private class Wrapper : IFSTransaction, IDisposable
	{
		private IFSTransaction _owner;

		public Wrapper(IFSTransaction owner)
		{
			if (owner == null)
			{
				throw new ArgumentNullException("owner");
			}
			_owner = owner;
		}

		public bool Commit()
		{
			return false;
		}

		public bool Rollback()
		{
			return false;
		}

		public virtual void RegisterBeforeCommitAction(string actionName, Action action)
		{
			_owner.RegisterBeforeCommitAction(actionName, action);
		}

		public void Dispose()
		{
		}
	}

	[ThreadStatic]
	private static FSTransaction _current;

	private const string TempFolder = "Temp";

	private bool _finished;

	private string _root;

	private string _workDir;

	private List<FSAction> _actions = new List<FSAction>();

	private static int _backupFileIndex;

	private List<string> _tempFileNames = new List<string>();

	private Func<string> _oldCreateTempFileFunc;

	private Dictionary<string, Action> _beforeCommitActions = new Dictionary<string, Action>();

	private Dictionary<int, string> _creatingFileNames = new Dictionary<int, string>();

	public static FSTransaction Current
	{
		get
		{
			if (_current == null)
			{
				throw new InvalidOperationException(SR.T("Транзакция файловой системы не инициализирована"));
			}
			return _current;
		}
	}

	public static bool IsActive => _current != null;

	public string Root => _root;

	public string WorkDir => _workDir;

	public TimeSpan ActionTimeout { get; set; }

	public static IFSTransaction Create(string root)
	{
		if (_current == null)
		{
			return new FSTransaction(root);
		}
		return new Wrapper(_current);
	}

	private FSTransaction(string root)
	{
		if (string.IsNullOrEmpty(root))
		{
			throw new ArgumentNullException("root");
		}
		Logger.Log.Info(SR.T("Начало транзакции"));
		_root = root;
		_workDir = Path.Combine(root, "Temp");
		ActionTimeout = TimeSpan.FromSeconds(10.0);
		try
		{
			if (Directory.Exists(_workDir))
			{
				FSHelper.DeleteDirectory(_workDir, recursive: true, ActionTimeout);
			}
		}
		catch (Exception exception)
		{
			Logger.Log.Debug($"Cannot delete work directory '{_workDir}'", exception);
		}
		if (!Directory.Exists(_workDir))
		{
			FSHelper.CreateDirectory(_workDir, ActionTimeout);
		}
		_oldCreateTempFileFunc = StreamExtensions.CreateTempFileFunc;
		StreamExtensions.CreateTempFileFunc = delegate
		{
			string text = Path.Combine(_workDir, "Stream_" + Guid.NewGuid().ToString("n"));
			_tempFileNames.Add(text);
			return text;
		};
		_current = this;
	}

	public virtual bool Commit()
	{
		if (!_finished)
		{
			foreach (Action value in _beforeCommitActions.Values)
			{
				value();
			}
			Logger.Log.Info(SR.T("Подтверждение транзакции"));
			foreach (FSAction action in _actions)
			{
				try
				{
					action.Commit();
				}
				catch (Exception exception)
				{
					Logger.Log.Error(SR.T("Не удалось подтвердить действие '{0}'", action.ToString()), exception);
				}
			}
			_finished = true;
			_current = null;
			StreamExtensions.CreateTempFileFunc = _oldCreateTempFileFunc;
			DeleteTempFiles();
		}
		return true;
	}

	public virtual bool Rollback()
	{
		if (!_finished)
		{
			Logger.Log.Info(SR.T("Откат транзакции"));
			foreach (FSAction item in Enumerable.Reverse(_actions))
			{
				try
				{
					item.Rollback();
				}
				catch (Exception exception)
				{
					Logger.Log.Error(SR.T("Не удалось отменить действие '{0}'", item.ToString()), exception);
				}
			}
			_finished = true;
			_current = null;
			StreamExtensions.CreateTempFileFunc = _oldCreateTempFileFunc;
			DeleteTempFiles();
		}
		return true;
	}

	public virtual void RegisterBeforeCommitAction(string actionName, Action action)
	{
		if (actionName == null)
		{
			throw new ArgumentNullException("actionName");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		if (!_beforeCommitActions.ContainsKey(actionName))
		{
			_beforeCommitActions[actionName] = action;
		}
	}

	public virtual void Register(FSAction action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		_actions.Add(action);
	}

	public string BackupFile(string fileName)
	{
		_backupFileIndex++;
		string text = Path.Combine(_workDir, _backupFileIndex.ToString("D8") + "_" + Path.GetFileName(fileName));
		FSHelper.MoveFile(fileName, text, ActionTimeout);
		return text;
	}

	public void RememberCreatedFile(string fileName)
	{
		if (!string.IsNullOrEmpty(fileName))
		{
			int hashCode = fileName.ToUpper().GetHashCode();
			if (!_creatingFileNames.ContainsKey(hashCode))
			{
				_creatingFileNames[hashCode] = fileName;
			}
		}
	}

	public bool WasFileCreated(string fileName)
	{
		if (string.IsNullOrEmpty(fileName))
		{
			return false;
		}
		int hashCode = fileName.ToUpper().GetHashCode();
		return _creatingFileNames.ContainsKey(hashCode);
	}

	public void Dispose()
	{
		if (!_finished)
		{
			Rollback();
		}
	}

	private void DeleteTempFiles()
	{
		foreach (string tempFileName in _tempFileNames)
		{
			if (File.Exists(tempFileName))
			{
				try
				{
					File.Delete(tempFileName);
				}
				catch
				{
				}
			}
		}
	}
}
