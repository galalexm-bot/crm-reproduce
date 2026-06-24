using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Orleans.Serialization;
using Orleans.ApplicationParts;
using Orleans.Serialization;

namespace EleWise.ELMA.Orleans.Features;

internal sealed class MemoryStreamSerializerFeatureProvider : IApplicationFeatureProvider<SerializerFeature>, IApplicationFeatureProvider
{
	public void PopulateFeature(IEnumerable<IApplicationPart> parts, SerializerFeature feature)
	{
		Type[] array = (from type in typeof(IActor).Assembly.GetTypes()
			where TypeOf<MemoryStream>.Raw.IsAssignableFrom(type)
			select type).ToArray();
		Type typeFromHandle = typeof(MemoryStreamSerializer);
		using (MemoryStream memoryStream = MemoryHelper.GetMemoryStream())
		{
			feature.AddSerializerType(memoryStream.GetType(), typeFromHandle, true);
		}
		feature.AddSerializerType(TypeOf<MemoryStream>.Raw, typeFromHandle, true);
		Type[] array2 = array;
		foreach (Type type2 in array2)
		{
			feature.AddSerializerType(type2, typeFromHandle, true);
		}
	}
}
