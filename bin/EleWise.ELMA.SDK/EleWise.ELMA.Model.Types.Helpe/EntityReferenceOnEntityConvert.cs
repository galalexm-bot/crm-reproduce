using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class EntityReferenceOnEntityConvertTypeMapper : IConvertTypeMapper
{
	private static Guid ReferenceOnEntityTypeUid;

	internal static EntityReferenceOnEntityConvertTypeMapper ruGSZ9bonuk1At85sfdN;

	public bool RelativeConvertNeeded(IPropertyMetadata originalPropertyMetadata, IPropertyMetadata convertPropertyMetadata)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!(svCjKXboelKr0LTGjHR5(convertPropertyMetadata) != ReferenceOnEntityTypeUid))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return false;
			case 1:
				return originalPropertyMetadata.SubTypeUid != Guid.Empty;
			}
		}
	}

	public object Convert(object obj)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		int num2 = num;
		IEntity<long> entity = default(IEntity<long>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (entity != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
				entity = obj as IEntity<long>;
				num2 = 2;
				break;
			case 1:
				return null;
			default:
			{
				ReferenceOnEntity referenceOnEntity = new ReferenceOnEntity();
				jplx8HboPhXkDGXaK4Zs(referenceOnEntity, entity);
				return referenceOnEntity;
			}
			}
		}
	}

	public EntityReferenceOnEntityConvertTypeMapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GaxuEXbo1PS2agHFd3qr();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static EntityReferenceOnEntityConvertTypeMapper()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				ReferenceOnEntityTypeUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53F8B1EA));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				GaxuEXbo1PS2agHFd3qr();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static Guid svCjKXboelKr0LTGjHR5(object P_0)
	{
		return ((IPropertyMetadata)P_0).TypeUid;
	}

	internal static bool jVMZKUboOCyBXbeGHmPy()
	{
		return ruGSZ9bonuk1At85sfdN == null;
	}

	internal static EntityReferenceOnEntityConvertTypeMapper QKUisBbo2pbLIyTKZVSq()
	{
		return ruGSZ9bonuk1At85sfdN;
	}

	internal static void jplx8HboPhXkDGXaK4Zs(object P_0, object P_1)
	{
		((ReferenceOnEntity)P_0).Object = (IEntity)P_1;
	}

	internal static void GaxuEXbo1PS2agHFd3qr()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
