using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

[Serializable]
[TypeConverter(typeof(EnumBaseConverter<TaskType>))]
[ShowInTypeTree(false)]
[ShowInDesigner(false)]
[EnumMetadataType(EnumMetadataType.ExtendableEnum)]
[Uid("ac229522-27ef-4ee3-a572-db509f29cf4d")]
[MetadataAccessLevel(MetadataAccessLevel.EleWise)]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskType), "DisplayName")]
[MetadataType(typeof(EnumMetadata))]
public class TaskType : EnumBase
{
	public const string UserValue = "User";

	public const int UserOrder = 10;

	public const string ScriptValue = "Script";

	public const int ScriptOrder = 20;

	public const string ManualValue = "Manual";

	public const int ManualOrder = 30;

	public const string NotificationValue = "Notification";

	public const int NotificationOrder = 40;

	public const string MessageSendValue = "MessageSend";

	public const int MessageSendOrder = 50;

	public const string MessageReceiveValue = "MessageReceive";

	public const int MessageReceiveOrder = 60;

	private static TaskType _user;

	private static TaskType _script;

	private static TaskType _manual;

	private static TaskType _notification;

	private static TaskType _messageSend;

	private static TaskType _messageReceive;

	internal static TaskType k3MXq5Zt2eBKAdavEOd3;

	[MetadataAccessLevel(MetadataAccessLevel.EleWise)]
	[Uid("6784e10e-c954-4a50-8a87-27582f101dc5")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskType), "P_User_DisplayName")]
	public static TaskType User => _user;

	[MetadataAccessLevel(MetadataAccessLevel.EleWise)]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskType), "P_Script_DisplayName")]
	[Uid("2551f345-cd8b-4f30-955c-9aee3b672d5a")]
	public static TaskType Script => _script;

	[Uid("27638d85-145f-4cf9-987a-0cdaae170009")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskType), "P_Manual_DisplayName")]
	[MetadataAccessLevel(MetadataAccessLevel.EleWise)]
	public static TaskType Manual => _manual;

	[Uid("6d7a86d7-f756-4d4e-95d9-991765b78078")]
	[MetadataAccessLevel(MetadataAccessLevel.EleWise)]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskType), "P_Notification_DisplayName")]
	public static TaskType Notification => _notification;

	[MetadataAccessLevel(MetadataAccessLevel.EleWise)]
	[Uid("f40e1051-504b-40af-80f8-0a69c61e0965")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskType), "P_MessageSend_DisplayName")]
	public static TaskType MessageSend => _messageSend;

	[Uid("73676c40-b38c-4625-87dd-1b9508223149")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TaskType), "P_MessageReceive_DisplayName")]
	[MetadataAccessLevel(MetadataAccessLevel.EleWise)]
	public static TaskType MessageReceive => _messageReceive;

	public TaskType(Guid value, string name)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		YPGAiiZtiBkfWLKFgfv3();
		base._002Ector(value, name);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected TaskType(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		YPGAiiZtiBkfWLKFgfv3();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static TaskType()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				_manual = new TaskType(new Guid((string)Kp45LGZtIehT7S2hqHCV(0x63D6C913 ^ 0x63D466C3)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-39189604 ^ -39275648));
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
				{
					num2 = 7;
				}
				break;
			case 3:
				_user = new TaskType(new Guid((string)Kp45LGZtIehT7S2hqHCV(0x614CF569 ^ 0x614E5A41)), (string)Kp45LGZtIehT7S2hqHCV(-1712492721 ^ -1712505157));
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				_notification = new TaskType(new Guid((string)Kp45LGZtIehT7S2hqHCV(-29981480 ^ -30133004)), (string)Kp45LGZtIehT7S2hqHCV(0x1EA50FCC ^ 0x1EA7BFB4));
				num2 = 6;
				break;
			case 1:
				return;
			case 5:
				_script = new TaskType(new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2125897096 ^ -2125738740)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-11799394 ^ -11969698));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_messageReceive = new TaskType(new Guid((string)Kp45LGZtIehT7S2hqHCV(0x651FE29D ^ 0x651D5267)), (string)Kp45LGZtIehT7S2hqHCV(0xB7793C9 ^ 0xB75228F));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				_messageSend = new TaskType(new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF6616C)), (string)Kp45LGZtIehT7S2hqHCV(-947937941 ^ -948097653));
				num2 = 2;
				break;
			case 4:
				YPGAiiZtiBkfWLKFgfv3();
				num2 = 3;
				break;
			}
		}
	}

	internal static void YPGAiiZtiBkfWLKFgfv3()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool X4s7ePZto2N5P7BUZxG7()
	{
		return (object)k3MXq5Zt2eBKAdavEOd3 == null;
	}

	internal static TaskType q09n5KZtFaieuwAlnE9a()
	{
		return k3MXq5Zt2eBKAdavEOd3;
	}

	internal static object Kp45LGZtIehT7S2hqHCV(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
