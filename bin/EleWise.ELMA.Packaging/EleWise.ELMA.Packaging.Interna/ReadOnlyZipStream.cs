using System;
using System.IO;
using System.IO.Packaging;

namespace EleWise.ELMA.Packaging.Internal.NuGet;

internal class ReadOnlyZipStream : Stream
{
	private const string Plus = "+";

	private const string EscapedPlus = "%2B";

	private const char PartPathSeparator = '/';

	private bool isOpened;

	private readonly Package package;

	private readonly Stream partStream;

	public override bool CanRead => partStream.CanRead;

	public override bool CanSeek => partStream.CanSeek;

	public override bool CanWrite => false;

	public override long Length => partStream.Length;

	public override long Position
	{
		get
		{
			return partStream.Position;
		}
		set
		{
			partStream.Position = value;
		}
	}

	public ReadOnlyZipStream(string packagePhysicalPath, string partPath)
	{
		package = Package.Open(packagePhysicalPath, FileMode.Open, FileAccess.Read, FileShare.Read);
		Uri partUri = GetPartUri(partPath);
		if (partPath.Contains("+") && !package.PartExists(partUri))
		{
			partUri = EscapePluses(partUri);
		}
		partStream = package.GetPart(partUri).GetStream(FileMode.Open, FileAccess.Read);
		isOpened = true;
	}

	public override void Flush()
	{
		ThrowIfClosed();
		partStream.Flush();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		ThrowIfClosed();
		return partStream.Read(buffer, offset, count);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		ThrowIfClosed();
		return partStream.Seek(offset, origin);
	}

	public override void SetLength(long value)
	{
		throw new NotImplementedException();
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotImplementedException();
	}

	public override void Close()
	{
		if (isOpened)
		{
			package.Close();
			partStream.Close();
			isOpened = false;
		}
		base.Close();
	}

	private static Uri GetPartUri(string partPath)
	{
		string text = partPath.Replace(Path.DirectorySeparatorChar, '/');
		if (text[0] != '/')
		{
			text = "/" + text;
		}
		return new Uri(text, UriKind.Relative);
	}

	private static Uri EscapePluses(Uri partUri)
	{
		return new Uri(partUri.OriginalString.Replace("+", "%2B"), UriKind.Relative);
	}

	private void ThrowIfClosed()
	{
		if (!isOpened)
		{
			throw new InvalidOperationException("Unable to operate on closed stream");
		}
	}
}
