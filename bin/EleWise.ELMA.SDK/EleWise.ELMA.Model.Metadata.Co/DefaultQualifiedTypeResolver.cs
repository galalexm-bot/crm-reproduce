using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.Components;

[Component(Order = int.MaxValue)]
internal class DefaultQualifiedTypeResolver : IQualifiedTypeResolverExtension
{
	private readonly Guid uid;

	internal static DefaultQualifiedTypeResolver ci3q9IhByFY0kA41E27y;

	public Guid Uid => uid;

	public bool CheckType(Type type)
	{
		return true;
	}

	public IEnumerable<byte> GetQualifiedTypeData(Type type)
	{
		return Encoding.UTF8.GetBytes(type.AssemblyQualifiedName);
	}

	public Type GetType(IEnumerable<byte> data)
	{
		return ReflectionType.GetType(Encoding.UTF8.GetString(data.ToArray()));
	}

	public DefaultQualifiedTypeResolver()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		TupQxJhB9K36iTuxRsl6();
		uid = new Guid((string)sHlnyphBdXYfV7gukeFP(0x4EA5403C ^ 0x4EA65FEE));
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void TupQxJhB9K36iTuxRsl6()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object sHlnyphBdXYfV7gukeFP(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool mKXFiShBMFVJtlZdFtZ1()
	{
		return ci3q9IhByFY0kA41E27y == null;
	}

	internal static DefaultQualifiedTypeResolver VF7CTWhBJHgYItnQXGie()
	{
		return ci3q9IhByFY0kA41E27y;
	}
}
