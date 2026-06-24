using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Serialization;

public class EntitySerializationFunctions
{
	internal static EntitySerializationFunctions jZrwQEBljB57v1RKldYc;

	public Func<object, ClassMetadata, PropertyMetadata, EntitySerializationSettings, bool> Filter { get; set; }

	public Func<ISerializableTypeDescriptor, object, ClassMetadata, PropertyMetadata, EntitySerializationSettings, IDictionary<string, object>> Serialize { get; set; }

	public Func<EntitySerializationFunctions, object, ClassMetadata, IPropertyMetadata, EntitySerializationSettings, EntitySerializationSettings, EntitySerializationFunctions> CopyForSettings { get; set; }

	public EntitySerializationFunctions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SubniiBlUtO4ZIWqjMWS();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void SubniiBlUtO4ZIWqjMWS()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool JKanKkBlYUhRIPw84MVt()
	{
		return jZrwQEBljB57v1RKldYc == null;
	}

	internal static EntitySerializationFunctions uMCx7QBlLM4Dc9AyRH6g()
	{
		return jZrwQEBljB57v1RKldYc;
	}
}
