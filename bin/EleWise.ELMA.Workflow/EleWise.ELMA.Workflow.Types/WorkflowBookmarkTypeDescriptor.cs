using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Types;

public class WorkflowBookmarkTypeDescriptor : EntitySubTypeDescriptor<IWorkflowBookmark>
{
	private static class SerializationItems
	{
	}

	private static readonly Guid entityUid;

	internal static WorkflowBookmarkTypeDescriptor W8HS6yJyZUWDlMlCg3h;

	protected override Guid EntityUid => entityUid;

	public override TypeSerializationDescriptor GetSerializeDescriptor(ClassMetadata metadata, PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_007e
		int num = 2;
		int num2 = num;
		TypeSerializationDescriptor typeSerializationDescriptor = default(TypeSerializationDescriptor);
		while (true)
		{
			TypeSerializationItemDescriptor typeSerializationItemDescriptor;
			switch (num2)
			{
			case 3:
				return typeSerializationDescriptor;
			case 1:
				if (rRhO4uJgEDDfHRDNhq6((EntitySettings)NEKSUxJ5HOotCLiVOgR(propertyMetadata)) != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				typeSerializationItemDescriptor = typeSerializationDescriptor.Items.First();
				break;
			default:
				typeSerializationItemDescriptor = ((TypeSerializationDescriptor)vpThTJJBsFcQqs6LKYS(typeSerializationDescriptor.Items.First())).Items.First();
				break;
			case 2:
				typeSerializationDescriptor = (TypeSerializationDescriptor)gEIOdAJbEVZ69Vkss8V(this, metadata, propertyMetadata);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			new TypeSerializationDescriptorBuilder((TypeSerializationDescriptor)vpThTJJBsFcQqs6LKYS(typeSerializationItemDescriptor)).Item(delegate(TypeSerializationItemDescriptorBuilder i)
			{
				int num7 = 1;
				int num8 = num7;
				while (true)
				{
					switch (num8)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						_003C_003Ec.RH6WAQZ9ObHERBkL4Etb(_003C_003Ec.WOGpB1ZfzidkQc28RSa5(i, _003C_003Ec.PBLvRUZf4rn4upxs28cN(-947937941 ^ -947945471)), _003C_003Ec.uMWPAIZ9KyQwcbsJOkNi(_003C_003Ec.PBLvRUZf4rn4upxs28cN(0x1AF6F1F2 ^ 0x1AF704F4)));
						num8 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
						{
							num8 = 0;
						}
						break;
					}
				}
			}).Item(delegate(TypeSerializationItemDescriptorBuilder i)
			{
				int num5 = 1;
				int num6 = num5;
				while (true)
				{
					switch (num6)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						_003C_003Ec.RH6WAQZ9ObHERBkL4Etb(i.Name((string)_003C_003Ec.PBLvRUZf4rn4upxs28cN(0x34EA50D4 ^ 0x34EA4D56)), _003C_003Ec.uMWPAIZ9KyQwcbsJOkNi(_003C_003Ec.PBLvRUZf4rn4upxs28cN(0x1145BED7 ^ 0x1147778B)));
						num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
						{
							num6 = 0;
						}
						break;
					}
				}
			}).Item(delegate(TypeSerializationItemDescriptorBuilder i)
			{
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						_003C_003Ec.RH6WAQZ9ObHERBkL4Etb(_003C_003Ec.WOGpB1ZfzidkQc28RSa5(i, _003C_003Ec.PBLvRUZf4rn4upxs28cN(0xD305CC2 ^ 0xD30415C)), _003C_003Ec.uMWPAIZ9KyQwcbsJOkNi(_003C_003Ec.PBLvRUZf4rn4upxs28cN(-1514166050 ^ -1514255366)));
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
						{
							num4 = 0;
						}
						break;
					}
				}
			});
			num2 = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
			{
				num2 = 3;
			}
		}
	}

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		//Discarded unreachable code: IL_010d, IL_011c
		int num = 3;
		IWorkflowBookmark workflowBookmark = default(IWorkflowBookmark);
		object obj = default(object);
		IDictionary<string, object> dictionary = default(IDictionary<string, object>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					if (sBdeyGJPmqq2njlAIuY(settings) == EntitySerializationMode.Default)
					{
						num = 11;
						break;
					}
					goto case 4;
				case 10:
					if (workflowBookmark == null)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 7;
				case 3:
					workflowBookmark = value as IWorkflowBookmark;
					num = 2;
					break;
				case 2:
					obj = puLuy7JcKHRAtCPA1co(this, value, valueType, settings);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
				case 12:
					dictionary = obj as IDictionary<string, object>;
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
					{
						num2 = 10;
					}
					continue;
				default:
					if (settings == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 8;
				case 4:
				case 9:
					return obj;
				case 7:
					if (dictionary != null)
					{
						num2 = 6;
						continue;
					}
					goto case 4;
				case 6:
					dictionary[(string)t60D42JXYcHMywNE2Tx(-935313063 ^ -935306189)] = ((rNTWjmJdEs2g73480en(workflowBookmark) != null) ? ((IEntity<long>)rNTWjmJdEs2g73480en(workflowBookmark)).Id.ToString() : string.Empty);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
					{
						num2 = 5;
					}
					continue;
				case 5:
					dictionary[(string)t60D42JXYcHMywNE2Tx(-772614310 ^ -772617512)] = ((workflowBookmark.Instance != null) ? t1V1OjJuMvH7QUnjq5k(rNTWjmJdEs2g73480en(workflowBookmark)) : string.Empty);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					dictionary[(string)t60D42JXYcHMywNE2Tx(-2077784392 ^ -2077779162)] = ((workflowBookmark.Instance != null && ((IWorkflowInstance)rNTWjmJdEs2g73480en(workflowBookmark)).Process != null && ((IWorkflowInstance)rNTWjmJdEs2g73480en(workflowBookmark)).Process.Header != null) ? NZH9exJHBN4PjhINH4c(P9CuY8JnoxjDWZw2mpT(zLYUNLJDNTVMBLooYfX(rNTWjmJdEs2g73480en(workflowBookmark)))) : string.Empty);
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	public WorkflowBookmarkTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowBookmarkTypeDescriptor()
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
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				entityUid = new Guid((string)t60D42JXYcHMywNE2Tx(-495296780 ^ -495303860));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object gEIOdAJbEVZ69Vkss8V(object P_0, object P_1, object P_2)
	{
		return ((EntityDescriptor)P_0).GetSerializeDescriptor((ClassMetadata)P_1, (PropertyMetadata)P_2);
	}

	internal static object NEKSUxJ5HOotCLiVOgR(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static RelationType rRhO4uJgEDDfHRDNhq6(object P_0)
	{
		return ((EntitySettings)P_0).RelationType;
	}

	internal static object vpThTJJBsFcQqs6LKYS(object P_0)
	{
		return ((TypeSerializationItemDescriptor)P_0).Descriptor;
	}

	internal static bool VCCestJmj7NNrK5uVGH()
	{
		return W8HS6yJyZUWDlMlCg3h == null;
	}

	internal static WorkflowBookmarkTypeDescriptor HInhfWJt67KXDoAdjNx()
	{
		return W8HS6yJyZUWDlMlCg3h;
	}

	internal static object puLuy7JcKHRAtCPA1co(object P_0, object P_1, Type P_2, object P_3)
	{
		return ((EntityDescriptor)P_0).SerializeSimple(P_1, P_2, (EntitySerializationSettings)P_3);
	}

	internal static EntitySerializationMode sBdeyGJPmqq2njlAIuY(object P_0)
	{
		return ((EntitySerializationSettings)P_0).Mode;
	}

	internal static object t60D42JXYcHMywNE2Tx(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object rNTWjmJdEs2g73480en(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static object t1V1OjJuMvH7QUnjq5k(object P_0)
	{
		return ((IWorkflowInstance)P_0).Name;
	}

	internal static object zLYUNLJDNTVMBLooYfX(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object P9CuY8JnoxjDWZw2mpT(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static object NZH9exJHBN4PjhINH4c(object P_0)
	{
		return ((IProcessHeader)P_0).Name;
	}
}
