using System;
using System.Data;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security.Diagrams;
using EleWise.ELMA.Security.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Types;

public class OrganizationSubDiagramTypeDescriptor : CLRTypeDescriptor<OrganizationSubDiagram, OrganizationSubDiagramTypeSettings>
{
	public const string UID_S = "{1F571770-0498-4192-A076-C987A3A265F8}";

	public static readonly Guid UID;

	internal static OrganizationSubDiagramTypeDescriptor XkKbbBZerivF5EgN4Qj;

	public override Guid Uid => UID;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override string Name => SR.T((string)F2JNC4ZH0XlYF6O6GL6(0x5EE4A7B ^ 0x5EE778D));

	public override bool Visible
	{
		get
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
				case 1:
					if (MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.VisualStudio)
					{
						return true;
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (!L8fb9xZaT7SqjtB41RX(this))
					{
						return false;
					}
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Binary);
	}

	public OrganizationSubDiagramTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		seeFLQZRdR0ZwxWwPgZ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static OrganizationSubDiagramTypeDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				seeFLQZRdR0ZwxWwPgZ();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_488725796a2e487f95c022f5056d8a88 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				UID = new Guid((string)F2JNC4ZH0XlYF6O6GL6(0xCD88DD8 ^ 0xCD8B3E0));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object F2JNC4ZH0XlYF6O6GL6(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool UYqw3hZLHjS1E7PP8UR()
	{
		return XkKbbBZerivF5EgN4Qj == null;
	}

	internal static OrganizationSubDiagramTypeDescriptor wrnp6TZjoxQlxJJF1bg()
	{
		return XkKbbBZerivF5EgN4Qj;
	}

	internal static bool L8fb9xZaT7SqjtB41RX(object P_0)
	{
		return ((TypeDescriptor)P_0).Visible;
	}

	internal static void seeFLQZRdR0ZwxWwPgZ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
