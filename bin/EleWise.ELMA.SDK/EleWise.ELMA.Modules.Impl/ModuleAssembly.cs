using System;
using System.Reflection;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Modules.Impl;

internal class ModuleAssembly : ApplicationUnit, IModuleAssembly, IApplicationUnit
{
	private Assembly assembly;

	private AssemblyInfoMetadata info;

	internal static ModuleAssembly jxuZdD32VAlcBiQPG3I;

	public override string Id => (string)FW7rkX3pUD5nAx9hmOp(info);

	public override Guid Uid => info.Uid;

	public override string Title => (string)mYs9aU3aVacy6ocfqb8(info);

	public override string Description => (string)l0l38Z3DTpM971tb0Vg(info);

	public Assembly Assembly => assembly;

	public Guid ModuleUid => lNtpud3tN8MYcCYVquR(info);

	public override string Version => info.FileVersion;

	public override string Author => (string)qBh2KN3wRWGyhCEGFt4(info);

	public ModuleAssembly(Assembly assembly)
	{
		//Discarded unreachable code: IL_001a
		cRSKiL31kWeUsqAbZPm();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				if (Qv6hlA3NTZ9srFhoTyd(assembly, null))
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num = 0;
					}
				}
				else
				{
					this.assembly = assembly;
					int num2 = 3;
					num = num2;
				}
				break;
			case 3:
				info = new AssemblyInfoMetadata();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num = 1;
				}
				break;
			case 4:
				return;
			case 1:
				info.LoadFromAssembly(assembly);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num = 4;
				}
				break;
			default:
				throw new ArgumentNullException((string)voJMYf33vy8TPmFO4uu(-1858887263 ^ -1858874161));
			}
		}
	}

	internal static void cRSKiL31kWeUsqAbZPm()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Qv6hlA3NTZ9srFhoTyd(object P_0, object P_1)
	{
		return (Assembly)P_0 == (Assembly)P_1;
	}

	internal static object voJMYf33vy8TPmFO4uu(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool L9pdgw3euvldpBO80n1()
	{
		return jxuZdD32VAlcBiQPG3I == null;
	}

	internal static ModuleAssembly Pcv85V3PuxJxxhPsa93()
	{
		return jxuZdD32VAlcBiQPG3I;
	}

	internal static object FW7rkX3pUD5nAx9hmOp(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object mYs9aU3aVacy6ocfqb8(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object l0l38Z3DTpM971tb0Vg(object P_0)
	{
		return ((NamedMetadata)P_0).Description;
	}

	internal static Guid lNtpud3tN8MYcCYVquR(object P_0)
	{
		return ((AbstractMetadata)P_0).ModuleUid;
	}

	internal static object qBh2KN3wRWGyhCEGFt4(object P_0)
	{
		return ((AssemblyInfoMetadata)P_0).Company;
	}
}
