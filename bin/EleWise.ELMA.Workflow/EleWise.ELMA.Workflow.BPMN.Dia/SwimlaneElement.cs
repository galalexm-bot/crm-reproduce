using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Security.DTO.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Swimlanes;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Validation;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;

[Serializable]
public abstract class SwimlaneElement : ValidatableElement2D, IReplaceContextVar
{
	public static string BusinessRoleType;

	private SwimlaneType _swimlaneType;

	private bool _denyReplacement;

	private static readonly Guid ENTITY_USER_UID;

	private static readonly Guid ENTITY_USER_IMPL_UID;

	private static SwimlaneElement oatoglZYtDolQIRPFBL8;

	public override string DefaultName => (string)OH0Cn0ZYB0j74QjxlYAL(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657680419));

	public virtual SwimlaneType SwimlaneType
	{
		get
		{
			return _swimlaneType;
		}
		set
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
					YjF5o7ZYcp3HFce9SDvX(this);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					_swimlaneType = value;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public virtual long DepartmentId
	{
		[CompilerGenerated]
		get
		{
			return _003CDepartmentId_003Ek__BackingField;
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
				case 1:
					_003CDepartmentId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public virtual Guid ExecuterProperty
	{
		[CompilerGenerated]
		get
		{
			return _003CExecuterProperty_003Ek__BackingField;
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
					_003CExecuterProperty_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual List<Worker> Workers { get; set; }

	public virtual WorkerDetectionType WorkerDetectionType
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkerDetectionType_003Ek__BackingField;
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
					_003CWorkerDetectionType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual string ScriptName
	{
		[CompilerGenerated]
		get
		{
			return _003CScriptName_003Ek__BackingField;
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
					_003CScriptName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual bool ChangeResponsible
	{
		[CompilerGenerated]
		get
		{
			return _003CChangeResponsible_003Ek__BackingField;
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
				case 1:
					_003CChangeResponsible_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public virtual bool SenNotificationToNewResponsible
	{
		[CompilerGenerated]
		get
		{
			return _003CSenNotificationToNewResponsible_003Ek__BackingField;
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
					_003CSenNotificationToNewResponsible_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual bool DenyReplacement
	{
		get
		{
			return _denyReplacement;
		}
		set
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
					_denyReplacement = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					UpdateStyles();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[DefaultValue(false)]
	public bool ResetExecutorOnEnter
	{
		[CompilerGenerated]
		get
		{
			return _003CResetExecutorOnEnter_003Ek__BackingField;
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
					_003CResetExecutorOnEnter_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public SwimlaneElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		W3vlkEZYgvd2Rq8nO8Sk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Workers = new List<Worker>();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void Validate(WorkflowProcessValidator validator)
	{
		//Discarded unreachable code: IL_0255, IL_025f, IL_026e, IL_03ef, IL_0513, IL_0527, IL_0536, IL_059e
		int num = 3;
		IPropertyMetadata propertyMetadata = default(IPropertyMetadata);
		SwimlaneType swimlaneType = default(SwimlaneType);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		EntityUserSettings entityUserSettings = default(EntityUserSettings);
		IEnumerable<SwimlaneElement> enumerable = default(IEnumerable<SwimlaneElement>);
		List<Worker> workers = default(List<Worker>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 2:
					propertyMetadata = validator.AllProperties.FirstOrDefault((IPropertyMetadata p) => OIwBRyZYkIJCvtr4MtiP(p.Uid, vTYBtUZYHO1AU5JN37Fo(this)));
					num2 = 21;
					continue;
				case 5:
				case 8:
					swimlaneType = rIRsgnZYLyjf1AtEcYu6(this);
					num2 = 25;
					continue;
				case 16:
					return;
				case 33:
					propertyMetadata2 = validator.AllProperties.FirstOrDefault((IPropertyMetadata p) => OIwBRyZYkIJCvtr4MtiP(p.Uid, vTYBtUZYHO1AU5JN37Fo(this))) as PropertyMetadata;
					num2 = 23;
					continue;
				case 28:
					if (acl78tZYR6I5MVo6DAm7(this) <= 0)
					{
						num = 20;
						break;
					}
					if (yHKfYfZY6gEYQqRqd3CA(Locator.GetServiceNotNull<IOrganizationItemDTOManager>(), DepartmentId) != null)
					{
						num = 4;
						break;
					}
					goto case 31;
				case 3:
					base.Validate(validator);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
					{
						num2 = 2;
					}
					continue;
				case 25:
					switch (swimlaneType)
					{
					case SwimlaneType.Static:
						STlcQTZYjc3sUmn8Txsb(base.ValidationHelper, validator, vTYBtUZYHO1AU5JN37Fo(this), cGNOjmZYWUCo1Ng3YpaG(UL03PDZYfpxfmSojxRtc(-865213812 ^ -865115820), new object[1] { nWFAiYZY9ZHiBONiXw5N(this) }), false);
						num2 = 28;
						continue;
					case SwimlaneType.DynamicScript:
						base.ValidationHelper.ValidatePropertyExists(validator, vTYBtUZYHO1AU5JN37Fo(this), (string)cGNOjmZYWUCo1Ng3YpaG(UL03PDZYfpxfmSojxRtc(0x74AB4717 ^ 0x74A9C4CF), new object[1] { nWFAiYZY9ZHiBONiXw5N(this) }), errorOnEmptyUid: true);
						num2 = 30;
						continue;
					case SwimlaneType.Dynamic:
						base.ValidationHelper.ValidatePropertyExists(validator, ExecuterProperty, (string)cGNOjmZYWUCo1Ng3YpaG(UL03PDZYfpxfmSojxRtc(-1514166050 ^ -1514329338), new object[1] { nWFAiYZY9ZHiBONiXw5N(this) }), errorOnEmptyUid: true);
						num2 = 33;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
						{
							num2 = 33;
						}
						continue;
					}
					num = 16;
					break;
				case 6:
					if (entityUserSettings == null)
					{
						num2 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 27;
				case 24:
					enumerable = ((IEnumerable)HidFaaZYd3wkZbOnOFcN(PYWyVdZYX8utVcFtgjvl(nd8TKkZYP05df1Ef7Y3i(validator)))).OfType<SwimlaneElement>().Where(delegate(SwimlaneElement s)
					{
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								return OIwBRyZYkIJCvtr4MtiP(vTYBtUZYHO1AU5JN37Fo(s), vTYBtUZYHO1AU5JN37Fo(this));
							case 1:
								vTYBtUZYHO1AU5JN37Fo(s);
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					});
					num2 = 19;
					continue;
				case 20:
					validator.Messages.Add(base.ValidationHelper.CreateValidationError(SR.T((string)UL03PDZYfpxfmSojxRtc(-1361036319 ^ -1360871571), nWFAiYZY9ZHiBONiXw5N(this))));
					num2 = 13;
					continue;
				case 19:
					if (enumerable.Count() > 1)
					{
						num2 = 26;
						continue;
					}
					goto case 18;
				case 14:
					obj = null;
					goto IL_0607;
				case 7:
					return;
				case 13:
					return;
				case 1:
					if (workers != null)
					{
						num2 = 12;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 15;
				default:
				{
					ICollection<ProcessValidationMessage> messages = validator.Messages;
					ProcessValidationMessage processValidationMessage = new ProcessValidationMessage
					{
						Type = ProcessValidationMessageType.Error
					};
					EcNudgZYDbQVVRMyUdy6(processValidationMessage, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-768800937 ^ -768637495), lCCmK9ZYuBjwdGv7POaB(propertyMetadata)));
					sKjJSBZYnGPJ1i1aOD1q(processValidationMessage, enumerable);
					messages.Add(processValidationMessage);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				case 31:
					validator.Messages.Add((ProcessValidationMessage)JnndSXZYqcEAv8CVemao(base.ValidationHelper, cGNOjmZYWUCo1Ng3YpaG(UL03PDZYfpxfmSojxRtc(-2111219045 ^ -2111053933), new object[1] { nWFAiYZY9ZHiBONiXw5N(this) })));
					num2 = 22;
					continue;
				case 23:
					if (propertyMetadata2 == null)
					{
						num2 = 14;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					obj = KEVX0BZY3KNBDjW8PurG(propertyMetadata2) as EntityUserSettings;
					goto IL_0607;
				case 17:
					validator.Messages.Add((ProcessValidationMessage)d7HlcXZYTDVWOiV4lETo(base.ValidationHelper, OH0Cn0ZYB0j74QjxlYAL(UL03PDZYfpxfmSojxRtc(-29981480 ^ -30145904))));
					num2 = 29;
					continue;
				case 21:
					if (propertyMetadata != null)
					{
						num2 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
						{
							num2 = 24;
						}
						continue;
					}
					goto case 5;
				case 11:
					validator.Messages.Add((ProcessValidationMessage)d7HlcXZYTDVWOiV4lETo(base.ValidationHelper, SR.T((string)UL03PDZYfpxfmSojxRtc(-1108877388 ^ -1109043050))));
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
					{
						num2 = 32;
					}
					continue;
				case 15:
					validator.Messages.Add(base.ValidationHelper.CreateValidationError((string)OH0Cn0ZYB0j74QjxlYAL(UL03PDZYfpxfmSojxRtc(0x51EF0063 ^ 0x51ED85E5))));
					num = 9;
					break;
				case 26:
					if (enumerable.First() == this)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 18;
				case 27:
					workers = entityUserSettings.Workers;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
					{
						num2 = 1;
					}
					continue;
				case 32:
					return;
				case 4:
					return;
				case 10:
					return;
				case 30:
					return;
				case 22:
					return;
				case 18:
					base.ValidationHelper.ValidateProperty(validator, vTYBtUZYHO1AU5JN37Fo(this), delegate(IPropertyMetadata p)
					{
						//Discarded unreachable code: IL_0097, IL_00cb, IL_00da, IL_0133, IL_0142
						int num5 = 2;
						int num6 = num5;
						PropertyMetadata propertyMetadata3 = default(PropertyMetadata);
						while (true)
						{
							switch (num6)
							{
							case 2:
								propertyMetadata3 = p as PropertyMetadata;
								num6 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
								{
									num6 = 1;
								}
								break;
							case 8:
								if (!_003C_003Ec.BDoSXdvPgMX46Qxv3F6N(_003C_003Ec.PIFIDavPBTak7RDfBjFn(propertyMetadata3), ENTITY_USER_IMPL_UID))
								{
									num6 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
									{
										num6 = 2;
									}
									break;
								}
								goto default;
							case 1:
								if (propertyMetadata3 == null)
								{
									num6 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
									{
										num6 = 7;
									}
									break;
								}
								if (!_003C_003Ec.BDoSXdvPgMX46Qxv3F6N(_003C_003Ec.jkYtHIvP5yEWp7vsn8td(propertyMetadata3), EntityDescriptor.UID))
								{
									num6 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
									{
										num6 = 6;
									}
									break;
								}
								goto case 3;
							case 7:
								return false;
							default:
								return false;
							case 4:
							case 5:
								return ((EntitySettings)_003C_003Ec.GUhv9RvPcLBLSrtNxpxN(propertyMetadata3)).RelationType == RelationType.OneToOne;
							case 3:
								return false;
							case 6:
								if (!(_003C_003Ec.PIFIDavPBTak7RDfBjFn(propertyMetadata3) != ENTITY_USER_UID))
								{
									num6 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
									{
										num6 = 5;
									}
									break;
								}
								goto case 8;
							}
						}
					}, (string)OH0Cn0ZYB0j74QjxlYAL(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-683713632 ^ -683812680)));
					num2 = 8;
					continue;
				case 9:
					return;
				case 12:
					if (workers.Where((Worker a) => _003C_003Ec.HTsAiFvPdC9btmvahHt4(_003C_003Ec.CpDj1ivPPrY10M8OP1aF(a), _003C_003Ec.pheg0kvPXs5LDKeLfHpJ())).Any((Worker a) => _003C_003Ec.MTW6MsvPD1MtxOMMHte8(Locator.GetServiceNotNull<IUserGroupDTOManager>(), _003C_003Ec.LNWn7MvPuHMxnfZAm7o7(a)) == null))
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 29;
				case 29:
					{
						if (!workers.Where((Worker a) => _003C_003Ec.HTsAiFvPdC9btmvahHt4(_003C_003Ec.CpDj1ivPPrY10M8OP1aF(a), _003C_003Ec.sI26V4vPncJrrfhga0oK())).Any((Worker a) => Locator.GetServiceNotNull<IOrganizationItemDTOManager>().LoadOrNull((int)a.WorkerId) == null))
						{
							num2 = 10;
							continue;
						}
						goto case 11;
					}
					IL_0607:
					entityUserSettings = (EntityUserSettings)obj;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num2 = 6;
					}
					continue;
				}
				break;
			}
		}
	}

	protected override void OnShapeChanged(NShape oldShape, NShape newShape)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				FrcuDHZYQYFiKIKJ5BmA(this, oldShape, newShape);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				YjF5o7ZYcp3HFce9SDvX(this);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	protected virtual void UpdateStyles()
	{
		int num = 2;
		int num2 = num;
		SwimlaneShape swimlaneShape = default(SwimlaneShape);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			default:
				VxXldKZYM5Kj1miQAmCN(swimlaneShape, rIRsgnZYLyjf1AtEcYu6(this), xF7ytKZYC6v580bPHpm9(this));
				num2 = 3;
				break;
			case 2:
				swimlaneShape = yCbJHyZYpk0i07YNe8RQ(this) as SwimlaneShape;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (swimlaneShape == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ReplaceContextVar(Dictionary<Guid, Guid> ReplaceContextVar)
	{
		Guid value = Guid.Empty;
		if (ReplaceContextVar.TryGetValue(ExecuterProperty, out value))
		{
			ExecuterProperty = value;
		}
	}

	static SwimlaneElement()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				ENTITY_USER_IMPL_UID = new Guid((string)UL03PDZYfpxfmSojxRtc(0x2ACCDD87 ^ 0x2ACE55EB));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				ENTITY_USER_UID = new Guid((string)UL03PDZYfpxfmSojxRtc(-63028171 ^ -63124459));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				W3vlkEZYgvd2Rq8nO8Sk();
				num2 = 3;
				break;
			case 3:
				BusinessRoleType = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6EF8E8);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void W3vlkEZYgvd2Rq8nO8Sk()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool zFRCJfZYbLZ8aYq4ZYeq()
	{
		return oatoglZYtDolQIRPFBL8 == null;
	}

	internal static SwimlaneElement lbR7AYZY5NAuscQjdmOv()
	{
		return oatoglZYtDolQIRPFBL8;
	}

	internal static object OH0Cn0ZYB0j74QjxlYAL(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void YjF5o7ZYcp3HFce9SDvX(object P_0)
	{
		((SwimlaneElement)P_0).UpdateStyles();
	}

	internal static object nd8TKkZYP05df1Ef7Y3i(object P_0)
	{
		return ((WorkflowProcessValidator)P_0).Process;
	}

	internal static object PYWyVdZYX8utVcFtgjvl(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Diagram;
	}

	internal static object HidFaaZYd3wkZbOnOFcN(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static object lCCmK9ZYuBjwdGv7POaB(object P_0)
	{
		return ((INamedMetadata)P_0).DisplayName;
	}

	internal static void EcNudgZYDbQVVRMyUdy6(object P_0, object P_1)
	{
		((ProcessValidationMessage)P_0).Message = (string)P_1;
	}

	internal static void sKjJSBZYnGPJ1i1aOD1q(object P_0, object P_1)
	{
		((ProcessValidationMessage)P_0).Object = P_1;
	}

	internal static Guid vTYBtUZYHO1AU5JN37Fo(object P_0)
	{
		return ((SwimlaneElement)P_0).ExecuterProperty;
	}

	internal static SwimlaneType rIRsgnZYLyjf1AtEcYu6(object P_0)
	{
		return ((SwimlaneElement)P_0).SwimlaneType;
	}

	internal static object UL03PDZYfpxfmSojxRtc(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object nWFAiYZY9ZHiBONiXw5N(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object cGNOjmZYWUCo1Ng3YpaG(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void STlcQTZYjc3sUmn8Txsb(object P_0, object P_1, Guid propertyUid, object P_3, bool errorOnEmptyUid)
	{
		((ElementValidationHelper)P_0).ValidatePropertyExists((WorkflowProcessValidator)P_1, propertyUid, (string)P_3, errorOnEmptyUid);
	}

	internal static long acl78tZYR6I5MVo6DAm7(object P_0)
	{
		return ((SwimlaneElement)P_0).DepartmentId;
	}

	internal static object yHKfYfZY6gEYQqRqd3CA(object P_0, long P_1)
	{
		return ((IOrganizationItemDTOManager)P_0).LoadOrNull(P_1);
	}

	internal static object JnndSXZYqcEAv8CVemao(object P_0, object P_1)
	{
		return ((ElementValidationHelper)P_0).CreateValidationError((string)P_1);
	}

	internal static object KEVX0BZY3KNBDjW8PurG(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object d7HlcXZYTDVWOiV4lETo(object P_0, object P_1)
	{
		return ((ElementValidationHelper)P_0).CreateValidationWarning((string)P_1);
	}

	internal static void FrcuDHZYQYFiKIKJ5BmA(object P_0, object P_1, object P_2)
	{
		((Element)P_0).OnShapeChanged((NShape)P_1, (NShape)P_2);
	}

	internal static object yCbJHyZYpk0i07YNe8RQ(object P_0)
	{
		return ((Element)P_0).Shape;
	}

	internal static bool xF7ytKZYC6v580bPHpm9(object P_0)
	{
		return ((SwimlaneElement)P_0).DenyReplacement;
	}

	internal static void VxXldKZYM5Kj1miQAmCN(object P_0, SwimlaneType swimlaneType, bool iconVisible)
	{
		((SwimlaneShape)P_0).UpdateHeaderStyle(swimlaneType, iconVisible);
	}

	internal static bool OIwBRyZYkIJCvtr4MtiP(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
