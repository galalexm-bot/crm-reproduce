using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.CodeGeneration;

public class PortletPersonalizationGenerator : EntityGenerator
{
	private static PortletPersonalizationGenerator zCx7ZDBVZsqJZvJsAE55;

	protected override ISyntaxNode GetBaseClass()
	{
		return ((string)l1LahIBVVcAY7ec5VXkA(-97972138 ^ -98039920)).CreateTypeSyntax();
	}

	public IEnumerable<ISyntaxNode> Generate()
	{
		return GenerateMainFile();
	}

	[IteratorStateMachine(typeof(_003CGetBaseInterfaces_003Ed__2))]
	protected override IEnumerable<ISyntaxNode> GetBaseInterfaces()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetBaseInterfaces_003Ed__2(-2);
	}

	protected override void WriteTypeAttributes(ISyntaxNode type)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				type.AddAttributes(typeof(SerializableAttribute).CreateAttribute());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override void WritePropertyAttributes(ISyntaxNode property, PropertyMetadata propertyMetadata, string resourcePrefix = null)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				base.WritePropertyAttributes(property, propertyMetadata, resourcePrefix);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			property.AddAttributes(((string)l1LahIBVVcAY7ec5VXkA(-812025778 ^ -812097416)).CreateAttribute(RHXSLYBVS2n0F46aJR73(l1LahIBVVcAY7ec5VXkA(0x3CE17B75 ^ 0x3CE063E1))));
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
			{
				num2 = 2;
			}
		}
	}

	protected override EntityGenerator CreateTablePartGenerator()
	{
		throw new NotImplementedException();
	}

	public PortletPersonalizationGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		iYeF4GBVih6tISTkVBc3();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object l1LahIBVVcAY7ec5VXkA(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool ReTlCxBVuhlB946FrWHV()
	{
		return zCx7ZDBVZsqJZvJsAE55 == null;
	}

	internal static PortletPersonalizationGenerator mLgww9BVIxWhM2vSUKik()
	{
		return zCx7ZDBVZsqJZvJsAE55;
	}

	internal static object RHXSLYBVS2n0F46aJR73(object P_0)
	{
		return ((string)P_0).ParseExpression();
	}

	internal static void iYeF4GBVih6tISTkVBc3()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
