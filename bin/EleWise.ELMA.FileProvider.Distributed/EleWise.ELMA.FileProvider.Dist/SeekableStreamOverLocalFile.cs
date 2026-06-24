using System.IO;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.FileProvider.Distributed.IO;

internal class SeekableStreamOverLocalFile : Stream
{
	private readonly string tempFilePath;

	private readonly Stream backingStream;

	public override bool CanRead => backingStream.CanRead;

	public override bool CanSeek => backingStream.CanSeek;

	public override bool CanWrite => backingStream.CanWrite;

	public override long Length => backingStream.Length;

	public override long Position
	{
		get
		{
			return backingStream.Position;
		}
		set
		{
			backingStream.Position = value;
		}
	}

	public SeekableStreamOverLocalFile()
	{
		tempFilePath = IOExtensions.GetTempFileNameWithoutExtension(createFile: true);
		backingStream = File.Open(tempFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
	}

	public override void Flush()
	{
		backingStream.Flush();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return backingStream.Read(buffer, offset, count);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return backingStream.Seek(offset, origin);
	}

	public override void SetLength(long value)
	{
		backingStream.SetLength(value);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		backingStream.Write(buffer, offset, count);
	}

	public override void Close()
	{
		base.Close();
		File.Delete(tempFilePath);
	}
}
