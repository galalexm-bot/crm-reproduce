using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.IO;

[Serializable]
internal sealed class NativeMemoryStream : MemoryStream, ISerializable
{
	private const int MaxByteArrayLength = 2147483591;

	private const string StreamLength = "StreamLength";

	private const string StreamData = "StreamData";

	private IntPtr bufferManagedPtr;

	private unsafe byte* bufferUnmanagedPtr;

	private int capacity;

	private int length;

	private int position;

	private bool isOpen;

	private bool disposed;

	private Task<int> lastReadTask;

	public override bool CanRead => isOpen;

	public override bool CanSeek => isOpen;

	public override bool CanWrite => isOpen;

	public unsafe override int Capacity
	{
		get
		{
			ThrowIfStreamClosed();
			return capacity;
		}
		set
		{
			ThrowIfStreamClosed();
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("Capacity", value, "The flow capacity cannot be negative");
			}
			if (value < length)
			{
				throw new ArgumentOutOfRangeException("Capacity", value, "The flow capacity cannot be less than the current flow length");
			}
			if (value != capacity)
			{
				IntPtr intPtr = Marshal.AllocHGlobal(value);
				byte* destination = (byte*)intPtr.ToPointer();
				Buffer.MemoryCopy(bufferUnmanagedPtr, destination, value, length);
				Marshal.FreeHGlobal(bufferManagedPtr);
				bufferManagedPtr = intPtr;
				bufferUnmanagedPtr = destination;
				capacity = value;
			}
		}
	}

	public override long Length
	{
		get
		{
			ThrowIfStreamClosed();
			return length;
		}
	}

	public override long Position
	{
		get
		{
			ThrowIfStreamClosed();
			return position;
		}
		set
		{
			ThrowIfStreamClosed();
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("Position", value, "Stream position cannot be negative");
			}
			if (value > capacity)
			{
				position = capacity;
			}
			else
			{
				position = (int)value;
			}
		}
	}

	public NativeMemoryStream()
		: this(0)
	{
	}

	public unsafe NativeMemoryStream(int capacity)
	{
		if (capacity < 0)
		{
			throw new ArgumentOutOfRangeException("capacity", capacity, "The flow capacity cannot be negative");
		}
		this.capacity = ((capacity == 0) ? 256 : capacity);
		length = (position = 0);
		isOpen = true;
		bufferManagedPtr = Marshal.AllocHGlobal(this.capacity);
		bufferUnmanagedPtr = (byte*)bufferManagedPtr.ToPointer();
	}

	public unsafe NativeMemoryStream(SerializationInfo info, StreamingContext context)
	{
		int @int = info.GetInt32("StreamLength");
		if (@int < 0)
		{
			throw new ArgumentOutOfRangeException("capacity", capacity, "The flow capacity cannot be negative");
		}
		capacity = ((@int == 0) ? 256 : @int);
		length = @int;
		position = 0;
		isOpen = true;
		bufferManagedPtr = Marshal.AllocHGlobal(capacity);
		bufferUnmanagedPtr = (byte*)bufferManagedPtr.ToPointer();
		fixed (byte* source = (byte[])info.GetValue("StreamData", typeof(byte[])))
		{
			Buffer.MemoryCopy(source, bufferUnmanagedPtr, length, length);
		}
	}

	~NativeMemoryStream()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public override byte[] GetBuffer()
	{
		return ToArray();
	}

	public override bool TryGetBuffer(out ArraySegment<byte> buffer)
	{
		throw new NotImplementedException();
	}

	public unsafe override int Read(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", offset, "Offset cannot be negative");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", count, "Number of elements cannot be negative");
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException("Incorrect array length", "buffer");
		}
		ThrowIfStreamClosed();
		int num = length - position;
		if (num > count)
		{
			num = count;
		}
		if (num <= 0)
		{
			return 0;
		}
		fixed (byte* ptr = buffer)
		{
			Buffer.MemoryCopy(bufferUnmanagedPtr + position, ptr + offset, buffer.Length - offset, num);
		}
		position += num;
		return num;
	}

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		try
		{
			int num = Read(buffer, offset, count);
			if (lastReadTask != null && lastReadTask.Result != num)
			{
				lastReadTask = Task.FromResult(num);
			}
			return lastReadTask;
		}
		catch (Exception exception)
		{
			return Task.FromException<int>(exception);
		}
	}

	public unsafe override int ReadByte()
	{
		ThrowIfStreamClosed();
		if (position >= length)
		{
			return -1;
		}
		return bufferUnmanagedPtr[position++];
	}

	public override long Seek(long offset, SeekOrigin loc)
	{
		ThrowIfStreamClosed();
		switch (loc)
		{
		case SeekOrigin.Begin:
			if (offset < 0)
			{
				throw new IOException($"Offset = {offset} is out of stream");
			}
			position = (int)offset;
			break;
		case SeekOrigin.Current:
		{
			int num2 = position + (int)offset;
			if (position + offset < 0 || num2 < 0)
			{
				throw new IOException($"Offset = {offset} is out of stream");
			}
			position = num2;
			break;
		}
		case SeekOrigin.End:
		{
			int num = length + (int)offset;
			if (length + offset < 0 || num < 0)
			{
				throw new IOException($"Offset = {offset} is out of stream");
			}
			position = num;
			break;
		}
		default:
			throw new ArgumentException("Incorrect parameter value", "loc");
		}
		return position;
	}

	public unsafe override void SetLength(long value)
	{
		if (value < 0 || value > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("value", value, "The set value of the flow length is out of range");
		}
		ThrowIfStreamClosed();
		if (!EnsureCapacity((int)value) && value > length)
		{
			for (int i = length; i < value - length; i++)
			{
				bufferUnmanagedPtr[i] = 0;
			}
		}
		if (position > length)
		{
			position = length;
		}
	}

	public unsafe override byte[] ToArray()
	{
		ThrowIfStreamClosed();
		byte[] array = new byte[length];
		fixed (byte* destination = array)
		{
			Buffer.MemoryCopy(bufferUnmanagedPtr, destination, length, length);
		}
		return array;
	}

	public unsafe override void Write(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", offset, "Offset cannot be negative");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", count, "Number of elements cannot be negative");
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException("Incorrect array length", "buffer");
		}
		ThrowIfStreamClosed();
		int num = position + count;
		if (num < 0)
		{
			throw new IOException("Stream size is too large");
		}
		if (num > length)
		{
			bool flag = position > length;
			if (num > capacity && EnsureCapacity(num))
			{
				flag = false;
			}
			if (flag)
			{
				for (int i = length; i < num - length; i++)
				{
					bufferUnmanagedPtr[i] = 0;
				}
			}
			length = num;
		}
		fixed (byte* ptr = buffer)
		{
			Buffer.MemoryCopy(ptr + offset, bufferUnmanagedPtr + position, capacity - position, count);
		}
		position = num;
	}

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		try
		{
			Write(buffer, offset, count);
			return Task.CompletedTask;
		}
		catch (Exception exception)
		{
			return Task.FromException(exception);
		}
	}

	public unsafe override void WriteByte(byte value)
	{
		ThrowIfStreamClosed();
		if (position >= length)
		{
			int num = position + 1;
			bool flag = position > length;
			if (num >= capacity && EnsureCapacity(num))
			{
				flag = false;
			}
			if (flag)
			{
				for (int i = length; i < position - length; i++)
				{
					bufferUnmanagedPtr[i] = 0;
				}
			}
			length = num;
		}
		bufferUnmanagedPtr[position++] = value;
	}

	public unsafe override void WriteTo(Stream stream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		ThrowIfStreamClosed();
		stream.SetLength(length);
		for (int i = 0; i < length; i++)
		{
			stream.WriteByte(bufferUnmanagedPtr[i]);
		}
	}

	public unsafe string AsString(Encoding encoding)
	{
		ThrowIfStreamClosed();
		return encoding.GetString(bufferUnmanagedPtr, length);
	}

	public unsafe int GetContentHashCode()
	{
		ThrowIfStreamClosed();
		int num = 1;
		for (int i = 0; i < length; i++)
		{
			num *= 31;
			num += bufferUnmanagedPtr[i];
		}
		return num;
	}

	protected unsafe override void Dispose(bool disposing)
	{
		if (disposed)
		{
			return;
		}
		try
		{
			bufferUnmanagedPtr = null;
			Marshal.FreeHGlobal(bufferManagedPtr);
			isOpen = false;
			lastReadTask = null;
			disposed = true;
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	internal unsafe byte* GetNativeBuffer()
	{
		ThrowIfStreamClosed();
		return bufferUnmanagedPtr;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void ThrowIfStreamClosed()
	{
		if (!isOpen)
		{
			throw new ObjectDisposedException("The stream is closed. Further work with him is not possible");
		}
	}

	private bool EnsureCapacity(int value)
	{
		if (value < 0)
		{
			throw new ArgumentOutOfRangeException("Capacity", value, "The flow capacity cannot be negative");
		}
		if (value > capacity)
		{
			int num = value;
			if (num < 256)
			{
				num = 256;
			}
			if (num < capacity << 1)
			{
				num = capacity << 1;
			}
			if ((uint)(capacity << 1) > 2147483591u)
			{
				num = ((value > 2147483591) ? value : 2147483591);
			}
			Capacity = num;
			return true;
		}
		return false;
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("StreamLength", length);
		info.AddValue("StreamData", ToArray(), typeof(byte[]));
	}
}
