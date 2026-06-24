using System;
using System.IO;
using System.Linq;
using EleWise.ELMA.Packaging.FileSystems;

namespace EleWise.ELMA.Packaging.Components;

public abstract class ElmaProjectSystem : IElmaProjectSystem
{
	private IElmaComponent _component;

	private string _binDir;

	public IElmaComponent Component => _component;

	public bool UseSafeRemove { get; set; }

	public ElmaProjectSystem(IElmaComponent component, string relativeBinPath)
	{
		if (component == null)
		{
			throw new ArgumentNullException("component");
		}
		_component = component;
		_binDir = Path.Combine(component.ComponentRoot, relativeBinPath);
	}

	public void AddReference(string referencePath, Stream stream)
	{
		AddReference(referencePath, stream);
	}

	public void AddReference(string referencePath, Stream stream, DateTime? creationTime, DateTime? lastWriteTime)
	{
		string getRelativeReferencePath = GetGetRelativeReferencePath(referencePath);
		string text = Path.Combine(_binDir, getRelativeReferencePath);
		EnsureDirectoryExists(Path.GetDirectoryName(text));
		FS.CreateFile(text, stream, creationTime, lastWriteTime);
	}

	public virtual bool ReferenceExists(string referencePath)
	{
		string getRelativeReferencePath = GetGetRelativeReferencePath(referencePath);
		return File.Exists(Path.Combine(_binDir, getRelativeReferencePath));
	}

	public virtual void RemoveReference(string referencePath)
	{
		string getRelativeReferencePath = GetGetRelativeReferencePath(referencePath);
		string text = Path.Combine(_binDir, getRelativeReferencePath);
		if (File.Exists(text))
		{
			if (UseSafeRemove)
			{
				FS.SafeDeleteFile(text);
			}
			else
			{
				FS.DeleteFile(text);
			}
		}
	}

	protected virtual string GetGetRelativeReferencePath(string referencePath)
	{
		string[] array = referencePath.Split(new char[1] { Path.DirectorySeparatorChar }, StringSplitOptions.RemoveEmptyEntries);
		int num = 0;
		if (array[num].Equals("lib", StringComparison.InvariantCultureIgnoreCase))
		{
			num = ((array.Length <= 2) ? 1 : 2);
		}
		return Path.Combine(array.Skip(num).ToArray());
	}

	protected virtual void EnsureBinExists()
	{
		if (!Directory.Exists(_binDir))
		{
			FS.CreateDirectory(_binDir);
		}
	}

	protected virtual void EnsureDirectoryExists(string directory)
	{
		FS.CreateDirectory(directory);
	}
}
