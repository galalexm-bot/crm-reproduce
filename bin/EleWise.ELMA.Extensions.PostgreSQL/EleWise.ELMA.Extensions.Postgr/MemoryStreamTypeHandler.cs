using System;
using System.Data.Common;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Memory;
using Npgsql;
using Npgsql.BackendMessages;
using Npgsql.PostgresTypes;
using Npgsql.TypeHandlers;
using Npgsql.TypeHandling;

namespace EleWise.ELMA.Extensions.PostgreSQL.TypeHandlers;

internal sealed class MemoryStreamTypeHandler : ByteaHandler, INpgsqlTypeHandler<MemoryStream>
{
	private struct WriteObjectParams
	{
		public MemoryStream MemoryStream;

		public NpgsqlWriteBuffer NpgsqlWriteBuffer;

		public NpgsqlLengthCache NpgsqlLengthCache;

		public NpgsqlParameter NpgsqlParameter;

		public bool Async;
	}

	public MemoryStreamTypeHandler([NotNull] PostgresType postgresType)
		: base(postgresType)
	{
	}

	protected override int ValidateObjectAndGetLength(object value, ref NpgsqlLengthCache lengthCache, NpgsqlParameter parameter)
	{
		if (!(value is MemoryStream memoryStream))
		{
			return ((NpgsqlTypeHandler<byte[]>)this).ValidateObjectAndGetLength(value, ref lengthCache, parameter);
		}
		return ((INpgsqlTypeHandler<MemoryStream>)this).ValidateAndGetLength(memoryStream, ref lengthCache, parameter);
	}

	protected override Task WriteObjectWithLength(object value, NpgsqlWriteBuffer buf, NpgsqlLengthCache lengthCache, NpgsqlParameter parameter, bool async)
	{
		if (!(value is MemoryStream memoryStream))
		{
			return ((NpgsqlTypeHandler<byte[]>)this).WriteObjectWithLength(value, buf, lengthCache, parameter, async);
		}
		return ((INpgsqlTypeHandler<MemoryStream>)this).Write(memoryStream, buf, lengthCache, parameter, async);
	}

	private async Task WriteActionAsync(byte[] buffer, int offset, int length, WriteObjectParams param)
	{
		param.MemoryStream.Read(buffer, offset, length);
		if (param.NpgsqlWriteBuffer.get_WriteSpaceLeft() < 4)
		{
			await param.NpgsqlWriteBuffer.Flush(param.Async);
		}
		param.NpgsqlWriteBuffer.WriteInt32(length);
		await ((ByteaHandler)this).Write(new ArraySegment<byte>(buffer, offset, length), param.NpgsqlWriteBuffer, param.NpgsqlLengthCache, param.NpgsqlParameter, param.Async);
	}

	private async Task<MemoryStream> ReadActionAsync(byte[] buffer, int offset, int length, NpgsqlReadBuffer npgsqlReadBuffer)
	{
		await npgsqlReadBuffer.ReadBytes(buffer, offset, length, true);
		MemoryStream memoryStream = MemoryHelper.GetMemoryStream(length);
		await memoryStream.WriteAsync(buffer, offset, length);
		memoryStream.Seek(0L, SeekOrigin.Begin);
		return memoryStream;
	}

	[AsyncStateMachine(typeof(_003CNpgsql_002DTypeHandling_002DINpgsqlTypeHandler_003CSystem_002DIO_002DMemoryStream_003E_002DRead_003Ed__6))]
	System.Threading.Tasks.ValueTask<MemoryStream> INpgsqlTypeHandler<MemoryStream>.Read(NpgsqlReadBuffer buf, int len, bool async, FieldDescription fieldDescription)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CNpgsql_002DTypeHandling_002DINpgsqlTypeHandler_003CSystem_002DIO_002DMemoryStream_003E_002DRead_003Ed__6 _003CNpgsql_002DTypeHandling_002DINpgsqlTypeHandler_003CSystem_002DIO_002DMemoryStream_003E_002DRead_003Ed__ = default(_003CNpgsql_002DTypeHandling_002DINpgsqlTypeHandler_003CSystem_002DIO_002DMemoryStream_003E_002DRead_003Ed__6);
		_003CNpgsql_002DTypeHandling_002DINpgsqlTypeHandler_003CSystem_002DIO_002DMemoryStream_003E_002DRead_003Ed__._003C_003E4__this = this;
		_003CNpgsql_002DTypeHandling_002DINpgsqlTypeHandler_003CSystem_002DIO_002DMemoryStream_003E_002DRead_003Ed__.buf = buf;
		_003CNpgsql_002DTypeHandling_002DINpgsqlTypeHandler_003CSystem_002DIO_002DMemoryStream_003E_002DRead_003Ed__.len = len;
		_003CNpgsql_002DTypeHandling_002DINpgsqlTypeHandler_003CSystem_002DIO_002DMemoryStream_003E_002DRead_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder<MemoryStream>.Create();
		_003CNpgsql_002DTypeHandling_002DINpgsqlTypeHandler_003CSystem_002DIO_002DMemoryStream_003E_002DRead_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder<MemoryStream> _003C_003Et__builder = _003CNpgsql_002DTypeHandling_002DINpgsqlTypeHandler_003CSystem_002DIO_002DMemoryStream_003E_002DRead_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CNpgsql_002DTypeHandling_002DINpgsqlTypeHandler_003CSystem_002DIO_002DMemoryStream_003E_002DRead_003Ed__6>(ref _003CNpgsql_002DTypeHandling_002DINpgsqlTypeHandler_003CSystem_002DIO_002DMemoryStream_003E_002DRead_003Ed__);
		return _003CNpgsql_002DTypeHandling_002DINpgsqlTypeHandler_003CSystem_002DIO_002DMemoryStream_003E_002DRead_003Ed__._003C_003Et__builder.get_Task();
	}

	int INpgsqlTypeHandler<MemoryStream>.ValidateAndGetLength(MemoryStream value, ref NpgsqlLengthCache lengthCache, NpgsqlParameter parameter)
	{
		if (parameter != null && ((DbParameter)(object)parameter).Size > 0 && ((DbParameter)(object)parameter).Size < value.Length)
		{
			return ((DbParameter)(object)parameter).Size;
		}
		return (int)value.Length;
	}

	async Task INpgsqlTypeHandler<MemoryStream>.Write(MemoryStream value, NpgsqlWriteBuffer buf, NpgsqlLengthCache lengthCache, NpgsqlParameter parameter, bool async)
	{
		if (value != null && value.Length != 0L)
		{
			value.Seek(0L, SeekOrigin.Begin);
			await MemoryHelper.ActionWithMemoryBufferAsync<byte, WriteObjectParams>((int)value.Length, new WriteObjectParams
			{
				MemoryStream = value,
				NpgsqlWriteBuffer = buf,
				NpgsqlLengthCache = lengthCache,
				NpgsqlParameter = parameter,
				Async = async
			}, WriteActionAsync);
			value.Seek(0L, SeekOrigin.Begin);
		}
	}
}
