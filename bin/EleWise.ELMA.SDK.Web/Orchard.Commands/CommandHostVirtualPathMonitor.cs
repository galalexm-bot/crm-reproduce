using System;
using System.IO;
using Orchard.Caching;
using Orchard.FileSystems.VirtualPath;

namespace Orchard.Commands;

internal class CommandHostVirtualPathMonitor : IVirtualPathMonitor, IVolatileProvider, ISingletonDependency, IDependency
{
	public class EmptyVolativeToken : IVolatileToken
	{
		private readonly string _filename;

		public bool IsCurrent
		{
			get
			{
				if (Directory.Exists(_filename))
				{
					return false;
				}
				if (File.Exists(_filename))
				{
					return false;
				}
				return true;
			}
		}

		public EmptyVolativeToken(string filename)
		{
			_filename = filename;
		}
	}

	public class FileToken : IVolatileToken
	{
		private readonly string _filename;

		private readonly DateTime _lastWriteTimeUtc;

		public bool IsCurrent
		{
			get
			{
				try
				{
					if (_lastWriteTimeUtc != File.GetLastWriteTimeUtc(_filename))
					{
						return false;
					}
				}
				catch
				{
					return false;
				}
				return true;
			}
		}

		public FileToken(string filename)
		{
			_filename = filename;
			_lastWriteTimeUtc = File.GetLastWriteTimeUtc(filename);
		}
	}

	public class DirectoryToken : IVolatileToken
	{
		private readonly string _filename;

		private readonly DateTime _lastWriteTimeUtc;

		public bool IsCurrent
		{
			get
			{
				try
				{
					if (_lastWriteTimeUtc != Directory.GetLastWriteTimeUtc(_filename))
					{
						return false;
					}
				}
				catch
				{
					return false;
				}
				return true;
			}
		}

		public DirectoryToken(string filename)
		{
			_filename = filename;
			_lastWriteTimeUtc = Directory.GetLastWriteTimeUtc(filename);
		}
	}

	private readonly IVirtualPathProvider _virtualPathProvider;

	public CommandHostVirtualPathMonitor(IVirtualPathProvider virtualPathProvider)
	{
		_virtualPathProvider = virtualPathProvider;
	}

	public IVolatileToken WhenPathChanges(string virtualPath)
	{
		string text = _virtualPathProvider.MapPath(virtualPath);
		if (File.Exists(text))
		{
			return new FileToken(text);
		}
		if (Directory.Exists(text))
		{
			return new DirectoryToken(text);
		}
		return new EmptyVolativeToken(text);
	}
}
