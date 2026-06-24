using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Types;

public class EntityUserDescriptor : EntitySubTypeDescriptor<EleWise.ELMA.Security.Models.IUser>
{
	private static readonly Guid UserEntityUid;

	private static EntityUserDescriptor T0UXgtZwmqEGcoab05r;

	public override Type SettingsType => fEde22ZvPyYG8Vtdida(typeof(EntityUserSettings).TypeHandle);

	protected override Guid EntityUid => UserEntityUid;

	public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		object obj = pde7urZC3ZR9V5lLevj(this, propertyMetadata);
		bfyAV9ZUUdgANr2iRRB((EntityUserSettings)obj, true);
		return (TypeSettings)obj;
	}

	public EntityUserDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ubuJvMZodaXcn1SKIRk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static EntityUserDescriptor()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				UserEntityUid = new Guid((string)aqZsceZJuJUgMefCIhG(-2068904634 ^ -2068890674));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				ubuJvMZodaXcn1SKIRk();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static Type fEde22ZvPyYG8Vtdida(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object pde7urZC3ZR9V5lLevj(object P_0, object P_1)
	{
		return ((EntityDescriptor)P_0).CreateSettingsForFilterProperty((PropertyMetadata)P_1);
	}

	internal static void bfyAV9ZUUdgANr2iRRB(object P_0, bool value)
	{
		((EntityUserSettings)P_0).ShowBlock = value;
	}

	internal static bool SU7O98Z2UVIwh6JdbeL()
	{
		return T0UXgtZwmqEGcoab05r == null;
	}

	internal static EntityUserDescriptor DmUU4kZPgPLSKF19ohc()
	{
		return T0UXgtZwmqEGcoab05r;
	}

	internal static void ubuJvMZodaXcn1SKIRk()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static object aqZsceZJuJUgMefCIhG(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
