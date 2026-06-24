using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

public class StartRouteInfoComponent
{
	private Lazy<List<IEntity<long>>> _objectList;

	private static StartRouteInfoComponent w4wetjOgxjOwr13K3yxo;

	public IStartRouteInfo Info
	{
		[CompilerGenerated]
		get
		{
			return _003CInfo_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CInfo_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<IEntity<long>> ObjectList
	{
		get
		{
			Contract.ArgumentNotNull(Info.Objects, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1145BED7 ^ 0x1144754D));
			if (Info.ObjectType == Guid.Empty)
			{
				return new List<IEntity<long>>();
			}
			if (_objectList == null)
			{
				_objectList = new Lazy<List<IEntity<long>>>(() => Info.Objects.Select((long i) => (IEntity<long>)ModelHelper.GetEntityManager(Locator.GetService<IMetadataRuntimeService>().GetTypeByUid(Info.ObjectType)).Load(i).CastAsRealType()).ToList());
			}
			return _objectList.Value;
		}
	}

	public string ContextVarName
	{
		get
		{
			//Discarded unreachable code: IL_0081, IL_0090, IL_00c1
			int num = 3;
			int num2 = num;
			IPropertyMetadata propertyMetadata = default(IPropertyMetadata);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return "";
				case 3:
					if (Info.ProcessHeader != null)
					{
						if (!oDx0QyOgwNdtLwMp4UPt(Is9u8oOgEhCjivVYWOCY(Info), Guid.Empty))
						{
							num2 = 6;
							break;
						}
						goto case 4;
					}
					num2 = 2;
					break;
				case 1:
					if (propertyMetadata != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				case 4:
					return "";
				case 6:
					propertyMetadata = (IPropertyMetadata)lb6XGrOBOGuCBdg2m042(s53MFYOg4rqdsj2A1bor(), DM8dEaOBKwMeNBbf5rNp(SdVGOmOgzpwtPOAdDZZn(Info)), Info.ContextVar);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					return "";
				default:
					return (string)spWF6SOBZkMEnJLFRNwy(propertyMetadata);
				}
			}
		}
	}

	public string ContextVarSystemName
	{
		get
		{
			int num = 1;
			IPropertyMetadata instanceContextPropertyMetadata = default(IPropertyMetadata);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						if (!oDx0QyOgwNdtLwMp4UPt(Is9u8oOgEhCjivVYWOCY(Info), Guid.Empty))
						{
							goto end_IL_0012;
						}
						num2 = 4;
						break;
					case 4:
						return "";
					case 3:
						if (instanceContextPropertyMetadata == null)
						{
							num2 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
							{
								num2 = 1;
							}
							break;
						}
						return (string)GkC9T0OBve9nhFv0Q50l(instanceContextPropertyMetadata);
					case 1:
						if (SdVGOmOgzpwtPOAdDZZn(Info) != null)
						{
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 4;
					case 2:
						return "";
					}
					continue;
					end_IL_0012:
					break;
				}
				instanceContextPropertyMetadata = ((WorkflowInstanceContextService)s53MFYOg4rqdsj2A1bor()).GetInstanceContextPropertyMetadata((IWorkflowProcess)DM8dEaOBKwMeNBbf5rNp(Info.ProcessHeader), Info.ContextVar);
				num = 3;
			}
		}
	}

	public RelationType ContextVarRelationType
	{
		get
		{
			//Discarded unreachable code: IL_00db, IL_00ea
			int num = 1;
			int num2 = num;
			IPropertyMetadata propertyMetadata = default(IPropertyMetadata);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return RelationType.OneToOne;
				case 4:
					return RelationType.OneToOne;
				case 3:
					propertyMetadata = (IPropertyMetadata)lb6XGrOBOGuCBdg2m042(s53MFYOg4rqdsj2A1bor(), ((IProcessHeader)SdVGOmOgzpwtPOAdDZZn(Info)).Published, Info.ContextVar);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
					{
						num2 = 5;
					}
					break;
				case 5:
					if (propertyMetadata != null)
					{
						return hTZQX8OB8e2mH8nV0Zrr((EntitySettings)LQwFlrOBY9P535aAr7Ru(propertyMetadata));
					}
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					if (SdVGOmOgzpwtPOAdDZZn(Info) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				default:
					if (!(Is9u8oOgEhCjivVYWOCY(Info) == Guid.Empty))
					{
						num2 = 3;
						break;
					}
					goto case 4;
				}
			}
		}
	}

	public StartRouteInfoComponent(IStartRouteInfo info)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qxQ8N4Ogh856uDEJfLiG();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Info = info;
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 != 0)
			{
				num = 1;
			}
		}
	}

	internal static bool NJ9S7AOgSALUfnZno9dd()
	{
		return w4wetjOgxjOwr13K3yxo == null;
	}

	internal static StartRouteInfoComponent avtVegOg1m7Yhw9qPyxg()
	{
		return w4wetjOgxjOwr13K3yxo;
	}

	internal static void qxQ8N4Ogh856uDEJfLiG()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static Guid Is9u8oOgEhCjivVYWOCY(object P_0)
	{
		return ((IStartRouteInfo)P_0).ContextVar;
	}

	internal static bool oDx0QyOgwNdtLwMp4UPt(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object s53MFYOg4rqdsj2A1bor()
	{
		return WorkflowInstanceContextService.Instance;
	}

	internal static object SdVGOmOgzpwtPOAdDZZn(object P_0)
	{
		return ((IStartRouteInfo)P_0).ProcessHeader;
	}

	internal static object DM8dEaOBKwMeNBbf5rNp(object P_0)
	{
		return ((IProcessHeader)P_0).Published;
	}

	internal static object lb6XGrOBOGuCBdg2m042(object P_0, object P_1, Guid propertyUid)
	{
		return ((WorkflowInstanceContextService)P_0).GetInstanceContextPropertyMetadata((IWorkflowProcess)P_1, propertyUid);
	}

	internal static object spWF6SOBZkMEnJLFRNwy(object P_0)
	{
		return ((INamedMetadata)P_0).DisplayName;
	}

	internal static object GkC9T0OBve9nhFv0Q50l(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static object LQwFlrOBY9P535aAr7Ru(object P_0)
	{
		return ((IPropertyMetadata)P_0).Settings;
	}

	internal static RelationType hTZQX8OB8e2mH8nV0Zrr(object P_0)
	{
		return ((EntitySettings)P_0).RelationType;
	}
}
