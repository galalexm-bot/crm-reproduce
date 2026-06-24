using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Types;

public class CustomActivityParametersContainerTypeDescriptor : EntityMetadataTypeDescriptor<CustomActivityParameters>
{
	public new const string UID_S = "{72ED98CA-F260-4671-9BCD-FF1D80235F47}";

	public new static readonly Guid UID;

	private static readonly Guid ParametersEntityUid;

	private static CustomActivityParametersContainerTypeDescriptor rErG6BC0Sgme96Fgmmi;

	public override Guid Uid => UID;

	protected override Guid EntityUid => ParametersEntityUid;

	public override Guid ParentUid => new Guid((string)cGSn5vCHIMGug6WIv4L(-474638327 ^ -474644325));

	public override string Name => SR.T((string)cGSn5vCHIMGug6WIv4L(-1917423727 ^ -1917421709));

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		throw new NotImplementedException();
	}

	public CustomActivityParametersContainerTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		g3tyV2CeOu7PWklTsZU();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4756c9eca18a4abd877173fe66f77852 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static CustomActivityParametersContainerTypeDescriptor()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				UID = new Guid((string)cGSn5vCHIMGug6WIv4L(-361150192 ^ -361148382));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bfa1473b6a64d0f975c9b2348e2eb28 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				ParametersEntityUid = new Guid((string)cGSn5vCHIMGug6WIv4L(-275456087 ^ -275462613));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ad15cce9717f4dd880232fa1f5e3eab0 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
				num2 = 2;
				break;
			case 1:
				return;
			}
		}
	}

	internal static object cGSn5vCHIMGug6WIv4L(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool pstFfiCBgUG1sScjmu3()
	{
		return rErG6BC0Sgme96Fgmmi == null;
	}

	internal static CustomActivityParametersContainerTypeDescriptor pAIsCeCW8itBmIWGnw6()
	{
		return rErG6BC0Sgme96Fgmmi;
	}

	internal static void g3tyV2CeOu7PWklTsZU()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
