using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Entities;

[ShowInDesigner(false)]
[ShowInTypeTree(false)]
[Entity("DbLock")]
[ClassMap(typeof(DbLockMap))]
[MetadataType(typeof(EntityMetadata))]
[Uid("{8FCAA656-9215-401B-BDDD-BABE43A73D17}")]
[IdType("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
[NonUnique]
public class DbLock : Entity<string>
{
	internal static DbLock KtxKNYhZtg8ZfoYHiMt8;

	[Uid("{4EC047C9-3A2A-4ED1-B760-4619DECCF1A4}")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[EntityProperty]
	[StringSettings(FieldName = "MachineName")]
	public string MachineName
	{
		[CompilerGenerated]
		get
		{
			return _003CMachineName_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
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
					_003CMachineName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[CanBeNull]
	[DateTimeSettings(SetCurrentDate = true, WithoutOffset = true, FieldName = "CreationDate")]
	[Uid("{F1222FE7-B4A3-446A-B91E-DAFC230B55C0}")]
	[EntityProperty]
	public DateTime? CreationDate { get; set; }

	[CanBeNull]
	[EntityProperty]
	[Uid("{1268080F-A967-4CDE-A561-25B7F8C33A95}")]
	[DateTimeSettings(SetCurrentDate = true, WithoutOffset = true, FieldName = "ValidUntilDate")]
	public DateTime? ValidUntilDate { get; set; }

	[Uid("{031BCCAE-2D41-49BD-9669-DF999AB3386F}")]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[EntityProperty]
	[GuidSettings(FieldName = "Value")]
	public Guid Value
	{
		[CompilerGenerated]
		get
		{
			return _003CValue_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
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
					_003CValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DbLock()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		obBGGlhZ64PSpbVv7RRG();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool ffplZPhZwRB9EvC2mUPZ()
	{
		return KtxKNYhZtg8ZfoYHiMt8 == null;
	}

	internal static DbLock jSR5cShZ43QBRZ7sDuXH()
	{
		return KtxKNYhZtg8ZfoYHiMt8;
	}

	internal static void obBGGlhZ64PSpbVv7RRG()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
