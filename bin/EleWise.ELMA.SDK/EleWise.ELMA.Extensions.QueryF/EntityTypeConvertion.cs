using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Extensions.QueryFunctionResults;

[Component]
public class EntityTypeConvertion : IQueryTypeConvertion
{
	internal static EntityTypeConvertion vmke9hGmKaAqLoq1OJr3;

	public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
	{
		return WJoh7kGmkTn5s54iSVuY(typeof(IEntity).TypeHandle).IsAssignableFrom(valueType);
	}

	public object ConvertValue(EntityMetadata metadata, string propName, object value)
	{
		return Mgp9u3Gmnfc50n89HZKF((IEntity)value);
	}

	public EntityTypeConvertion()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HpWgJGGmOsNIL2i4ERkM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type WJoh7kGmkTn5s54iSVuY(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool TYGY82GmXAtnTyrk7HgT()
	{
		return vmke9hGmKaAqLoq1OJr3 == null;
	}

	internal static EntityTypeConvertion VepC1aGmTtVrGLJvTMte()
	{
		return vmke9hGmKaAqLoq1OJr3;
	}

	internal static object Mgp9u3Gmnfc50n89HZKF(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static void HpWgJGGmOsNIL2i4ERkM()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
