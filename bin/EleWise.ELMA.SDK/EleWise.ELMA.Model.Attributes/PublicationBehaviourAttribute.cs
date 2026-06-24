using System;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.PublicationBehaviours;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public sealed class PublicationBehaviourAttribute : Attribute
{
	private readonly IPublicationBehaviourChecker publicationBehaviourChecker;

	internal static PublicationBehaviourAttribute uOpcCUof2xhnG6whbARM;

	public PublicationBehaviourAttribute(PublicationType type)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sQ0YmEof1PrguQi4s0rf();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 4:
				return;
			case 2:
				switch (type)
				{
				case (PublicationType)2:
					return;
				default:
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num = 0;
					}
					break;
				case PublicationType.Soft:
					publicationBehaviourChecker = new SoftBehaviour();
					num = 3;
					break;
				case PublicationType.Restart:
					publicationBehaviourChecker = new RestartBehaviour();
					num = 4;
					break;
				case PublicationType.Delta:
					publicationBehaviourChecker = new DeltaBehaviour();
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num = 0;
					}
					break;
				}
				break;
			case 0:
				return;
			case 1:
				return;
			case 3:
				return;
			}
		}
	}

	public PublicationBehaviourAttribute(Type publicationBehaviourChecker)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sQ0YmEof1PrguQi4s0rf();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.publicationBehaviourChecker = (IPublicationBehaviourChecker)zuFP9CofNGaA6hMZe6VC(publicationBehaviourChecker);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public PublicationType CheckProperty(CheckType checkType, object oldValue, object newValue)
	{
		return nAvvTyof3Hq8NA9Pt2Ax(publicationBehaviourChecker, checkType, oldValue, newValue);
	}

	internal static void sQ0YmEof1PrguQi4s0rf()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool CD36pTofeSIrlCYJdddN()
	{
		return uOpcCUof2xhnG6whbARM == null;
	}

	internal static PublicationBehaviourAttribute J9p0gNofP2KoAk9kplhT()
	{
		return uOpcCUof2xhnG6whbARM;
	}

	internal static object zuFP9CofNGaA6hMZe6VC(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static PublicationType nAvvTyof3Hq8NA9Pt2Ax(object P_0, CheckType action, object P_2, object P_3)
	{
		return ((IPublicationBehaviourChecker)P_0).Check(action, P_2, P_3);
	}
}
