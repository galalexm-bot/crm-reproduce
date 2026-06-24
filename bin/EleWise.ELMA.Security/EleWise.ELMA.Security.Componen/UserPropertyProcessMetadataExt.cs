using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Components;

[Component]
internal sealed class UserPropertyProcessMetadataExtension : IAdditionalProcessMetadataExtension
{
	private static readonly Guid UserEntityUid;

	private static readonly Guid OrgItemEntityUid;

	internal static UserPropertyProcessMetadataExtension ztKeNu1Mspqe1FdHvYk;

	public bool Check(IPropertyMetadata propertyMetadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return Fwx1d914u2FwYEXUq2D(wfvjb31INPi0mgivACV(propertyMetadata), UserEntityUid);
			case 1:
				if (propertyMetadata == null)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ProcessMetadata(IPropertyMetadata propertyMetadata, Guid currentModuleUid, DependencyServiceOptions options, Dictionary<Guid, EnumDependency> enumDependencies, Dictionary<Guid, EntityDependency> entityDependencies, Dictionary<Guid, DataClassDependency> dataClassDependencies)
	{
		IMetadata metadata = MetadataServiceContext.Service.GetMetadata(OrgItemEntityUid);
		if (metadata != null)
		{
			DependencyServiceHelper.ProcessMetadata(currentModuleUid, metadata, options, enumDependencies, entityDependencies, dataClassDependencies);
		}
	}

	public UserPropertyProcessMetadataExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ih4ey11VNqPhOVI10mu();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static UserPropertyProcessMetadataExtension()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				ih4ey11VNqPhOVI10mu();
				num2 = 2;
				break;
			case 2:
				UserEntityUid = new Guid((string)q0SLvw1QHElOuSgZoOY(0x40944BC4 ^ 0x4094754C));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c270ab2f5854923a44daf526a7f59af != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				OrgItemEntityUid = new Guid((string)q0SLvw1QHElOuSgZoOY(-208231202 ^ -208212010));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static Guid wfvjb31INPi0mgivACV(object P_0)
	{
		return ((IPropertyMetadata)P_0).SubTypeUid;
	}

	internal static bool Fwx1d914u2FwYEXUq2D(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool KDY1Jo1sCProfusSAeK()
	{
		return ztKeNu1Mspqe1FdHvYk == null;
	}

	internal static UserPropertyProcessMetadataExtension TQ5quX1YJhsQMU2jmw1()
	{
		return ztKeNu1Mspqe1FdHvYk;
	}

	internal static void ih4ey11VNqPhOVI10mu()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static object q0SLvw1QHElOuSgZoOY(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
