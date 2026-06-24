using System;
using System.Buffers;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.IO;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Memory;

public static class MemoryHelper
{
	public delegate void ActionWithMemoryBufferDelegate<in T>(T[] buffer, int bufferOffset, int bufferLength);

	public delegate void ActionWithMemoryBufferAndParameterDelegate<in T, in TParam>(T[] buffer, int bufferOffset, int bufferLength, TParam param);

	public delegate Task ActionWithMemoryBufferAndParameterDelegateAsync<in T, in TParam>(T[] buffer, int bufferOffset, int bufferLength, TParam param);

	public delegate TResult ActionWithMemoryBufferDelegate<in T, out TResult>(T[] buffer, int bufferOffset, int bufferLength);

	public delegate TResult ActionWithMemoryBufferAndParameterDelegate<in T, in TParam, out TResult>(T[] buffer, int bufferOffset, int bufferLength, TParam param);

	public delegate Task<TResult> ActionWithMemoryBufferAndParameterDelegateAsync<in T, in TParam, TResult>(T[] buffer, int bufferOffset, int bufferLength, TParam param);

	private static MemoryHelper Ll3imgBeHpVGSsDffDVM;

	public static MemoryStream GetMemoryStream()
	{
		return new NativeMemoryStream();
	}

	public static MemoryStream GetMemoryStream(int requiredSize)
	{
		return new NativeMemoryStream(requiredSize);
	}

	public static MemoryStream GetMemoryStream(byte[] buffer, bool writable)
	{
		return new MemoryStream(buffer, writable);
	}

	public static MemoryStream GetMemoryStream(byte[] buffer, int offset, int length, bool writable)
	{
		return new MemoryStream(buffer, offset, length, writable);
	}

	public static void ActionWithMemoryBuffer<T>(int minimumBufferLength, ActionWithMemoryBufferDelegate<T> action)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		Contract.CheckArgument(minimumBufferLength > 0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751247332));
		Contract.ArgumentNotNull(action, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426153779));
		IMemoryOwner<T> val = MemoryPool<T>.get_Shared().Rent(minimumBufferLength);
		try
		{
			ArraySegment<T> arraySegment = default(ArraySegment<T>);
			if (MemoryMarshal.TryGetArray<T>(System.Memory<T>.op_Implicit(val.get_Memory().Slice(0, minimumBufferLength)), ref arraySegment))
			{
				action(arraySegment.Array, arraySegment.Offset, minimumBufferLength);
				return;
			}
			throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3401164)));
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static void ActionWithMemoryBuffer<T, TParam>(int minimumBufferLength, TParam param, ActionWithMemoryBufferAndParameterDelegate<T, TParam> action)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Contract.CheckArgument(minimumBufferLength > 0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822827548));
		Contract.ArgumentNotNull(action, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787385199));
		IMemoryOwner<T> val = MemoryPool<T>.get_Shared().Rent(minimumBufferLength);
		try
		{
			ArraySegment<T> arraySegment = default(ArraySegment<T>);
			if (MemoryMarshal.TryGetArray<T>(System.Memory<T>.op_Implicit(val.get_Memory().Slice(0, minimumBufferLength)), ref arraySegment))
			{
				action(arraySegment.Array, arraySegment.Offset, minimumBufferLength, param);
				return;
			}
			throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C17855)));
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	[AsyncStateMachine(typeof(_003CActionWithMemoryBufferAsync_003Ed__12<, >))]
	public static Task ActionWithMemoryBufferAsync<T, TParam>(int minimumBufferLength, TParam param, ActionWithMemoryBufferAndParameterDelegateAsync<T, TParam> action)
	{
		_003CActionWithMemoryBufferAsync_003Ed__12<T, TParam> stateMachine = default(_003CActionWithMemoryBufferAsync_003Ed__12<T, TParam>);
		stateMachine.minimumBufferLength = minimumBufferLength;
		stateMachine.param = param;
		stateMachine.action = action;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public static TResult ActionWithMemoryBuffer<T, TResult>(int minimumBufferLength, ActionWithMemoryBufferDelegate<T, TResult> action)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Contract.CheckArgument(minimumBufferLength > 0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824311711));
		Contract.ArgumentNotNull(action, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7ED0CCB));
		IMemoryOwner<T> val = MemoryPool<T>.get_Shared().Rent(minimumBufferLength);
		try
		{
			ArraySegment<T> arraySegment = default(ArraySegment<T>);
			if (MemoryMarshal.TryGetArray<T>(System.Memory<T>.op_Implicit(val.get_Memory().Slice(0, minimumBufferLength)), ref arraySegment))
			{
				return action(arraySegment.Array, arraySegment.Offset, minimumBufferLength);
			}
			throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6F6425)));
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static TResult ActionWithMemoryBuffer<T, TParam, TResult>(int minimumBufferLength, TParam param, ActionWithMemoryBufferAndParameterDelegate<T, TParam, TResult> action)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		Contract.CheckArgument(minimumBufferLength > 0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561016680));
		Contract.ArgumentNotNull(action, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335065093));
		IMemoryOwner<T> val = MemoryPool<T>.get_Shared().Rent(minimumBufferLength);
		try
		{
			ArraySegment<T> arraySegment = default(ArraySegment<T>);
			if (MemoryMarshal.TryGetArray<T>(System.Memory<T>.op_Implicit(val.get_Memory().Slice(0, minimumBufferLength)), ref arraySegment))
			{
				return action(arraySegment.Array, arraySegment.Offset, minimumBufferLength, param);
			}
			throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217450217)));
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	[AsyncStateMachine(typeof(_003CActionWithMemoryBufferAsync_003Ed__15<, , >))]
	public static Task<TResult> ActionWithMemoryBufferAsync<T, TParam, TResult>(int minimumBufferLength, TParam param, ActionWithMemoryBufferAndParameterDelegateAsync<T, TParam, TResult> action)
	{
		_003CActionWithMemoryBufferAsync_003Ed__15<T, TParam, TResult> stateMachine = default(_003CActionWithMemoryBufferAsync_003Ed__15<T, TParam, TResult>);
		stateMachine.minimumBufferLength = minimumBufferLength;
		stateMachine.param = param;
		stateMachine.action = action;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<TResult>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<TResult> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public static bool StreamEquals(Stream stream1, Stream stream2)
	{
		return ActionWithMemoryBuffer<byte, (Stream, Stream), bool>(2048, (stream1, stream2), StreamEquals);
	}

	private static bool StreamEquals(object buffer, int bufferOffset, int bufferLength, (Stream, Stream) param)
	{
		var (stream, stream2) = param;
		int num;
		int num2;
		do
		{
			num = stream.Read((byte[])buffer, bufferOffset, 1024);
			num2 = stream2.Read((byte[])buffer, bufferOffset + 1024, 1024);
			if (num != num2 || !MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>((byte[])buffer, bufferOffset, num), System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>((byte[])buffer, bufferOffset + 1024, num2))))
			{
				return false;
			}
		}
		while (num < 1024 && num2 < 1024);
		return true;
	}

	internal static bool sBUOAGBeAEJF0mBTyU7n()
	{
		return Ll3imgBeHpVGSsDffDVM == null;
	}

	internal static MemoryHelper w5CS7vBe7qkpxlXvavIb()
	{
		return Ll3imgBeHpVGSsDffDVM;
	}
}
