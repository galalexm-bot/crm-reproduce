using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 300)]
public class PlatformTypeDescriptor : EntityDescriptor
{
	public new const string UID_S = "{853FA699-2756-49AD-A621-EC8158A565B0}";

	public new static readonly Guid UID;

	internal static PlatformTypeDescriptor orsHfRoMcopJEALYYkDC;

	public override Guid Uid => UID;

	public override string Name => (string)ffDocvoJW5bBoSgSymHu(UOdJLJoJBSa6NjqXpBPL(-1217523399 ^ -1217624025));

	public override Guid ParentUid => Guid.Empty;

	public override IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata)
	{
		IEnumerable<IPlatformTypeDescriptorProvider> service = Locator.GetService<IEnumerable<IPlatformTypeDescriptorProvider>>();
		if (service != null)
		{
			return from t in service.SelectMany((IPlatformTypeDescriptorProvider p) => p.GetTypeDescriptors())
				where t != null
				orderby (string)_003C_003Ec.lxGOtVCVrRt5sgo5qMH9(t)
				select t;
		}
		return new ITypeDescriptor[0];
	}

	public PlatformTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		mnSsAQoJoSDHXUKRTg88();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PlatformTypeDescriptor()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				mnSsAQoJoSDHXUKRTg88();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				UID = new Guid((string)UOdJLJoJBSa6NjqXpBPL(-1824388195 ^ -1824484647));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object UOdJLJoJBSa6NjqXpBPL(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object ffDocvoJW5bBoSgSymHu(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool YUyulNoMznvxpO5PDaQ6()
	{
		return orsHfRoMcopJEALYYkDC == null;
	}

	internal static PlatformTypeDescriptor FfvHvIoJFLGYIpO8pT2e()
	{
		return orsHfRoMcopJEALYYkDC;
	}

	internal static void mnSsAQoJoSDHXUKRTg88()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
