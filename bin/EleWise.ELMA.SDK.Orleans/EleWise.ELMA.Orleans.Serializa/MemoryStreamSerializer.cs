using System;
using System.IO;
using System.Reflection;
using EleWise.ELMA.Memory;
using Orleans.CodeGeneration;
using Orleans.Serialization;

namespace EleWise.ELMA.Orleans.Serialization;

internal sealed class MemoryStreamSerializer : IExternalSerializer
{
	public bool IsSupportedType(Type itemType)
	{
		if (itemType.IsSerializable)
		{
			return TypeOf<MemoryStream>.Raw.IsAssignableFrom(itemType);
		}
		return false;
	}

	[CopierMethod]
	public object DeepCopy(object source, ICopyContext context)
	{
		if (source == null)
		{
			return null;
		}
		MemoryStream obj = (MemoryStream)source;
		MemoryStream memoryStream = MemoryHelper.GetMemoryStream((int)obj.Length);
		obj.Seek(0L, SeekOrigin.Begin);
		obj.CopyTo(memoryStream);
		obj.Seek(0L, SeekOrigin.Begin);
		memoryStream.Seek(0L, SeekOrigin.Begin);
		return memoryStream;
	}

	[SerializerMethod]
	public void Serialize(object item, ISerializationContext context, Type expectedType)
	{
		Contract.ArgumentNotNull(context.get_StreamWriter(), "StreamWriter");
		if (!(item is MemoryStream memoryStream) || memoryStream.Length == 0L)
		{
			context.get_StreamWriter().WriteNull();
		}
		else
		{
			MemoryHelper.ActionWithMemoryBuffer<byte, (MemoryStream, ISerializationContext)>((int)memoryStream.Length, (memoryStream, context), SerializeAction);
		}
	}

	[DeserializerMethod]
	public object Deserialize(Type expectedType, IDeserializationContext context)
	{
		Contract.ArgumentNotNull(context.get_StreamReader(), "StreamReader");
		return MemoryHelper.ActionWithMemoryBuffer<byte, IDeserializationContext, MemoryStream>(context.get_StreamReader().ReadInt(), context, DeserializeAction);
	}

	private static MemoryStream DeserializeAction(byte[] buffer, int offset, int length, IDeserializationContext deserializationContext)
	{
		deserializationContext.get_StreamReader().ReadByteArray(buffer, offset, length);
		MemoryStream memoryStream = MemoryHelper.GetMemoryStream(length);
		memoryStream.Write(buffer, offset, length);
		memoryStream.Seek(0L, SeekOrigin.Begin);
		return memoryStream;
	}

	private static void SerializeAction(byte[] buffer, int offset, int length, (MemoryStream, ISerializationContext) param)
	{
		var (memoryStream, val) = param;
		memoryStream.Seek(0L, SeekOrigin.Begin);
		memoryStream.Read(buffer, offset, length);
		val.get_StreamWriter().Write(length);
		val.get_StreamWriter().Write(buffer, offset, length);
		memoryStream.Seek(0L, SeekOrigin.Begin);
	}
}
