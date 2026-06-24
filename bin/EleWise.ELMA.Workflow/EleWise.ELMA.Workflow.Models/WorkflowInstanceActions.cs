using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

public class WorkflowInstanceActions : DefaultEntityActions
{
	[DisplayName("SR.M('Оповещение')")]
	[Uid("38a2df7e-f6db-472d-8eba-632066e8710b")]
	[Image(typeof(WorkflowInstanceActions), "channel", 16, ImageFormatType.IconPack, false)]
	public const string Notification = "38a2df7e-f6db-472d-8eba-632066e8710b";

	private static Guid _notificationGuid;

	[Image(typeof(WorkflowInstanceActions), "error", 16, ImageFormatType.IconPack, false)]
	[DisplayName("SR.M('Прерывание')")]
	[Uid("c828c2eb-7fb5-42dc-af0d-be34111b8292")]
	public const string Terminate = "c828c2eb-7fb5-42dc-af0d-be34111b8292";

	private static Guid _terminateGuid;

	[Image(typeof(WorkflowInstanceActions), "comment_outline", 16, ImageFormatType.IconPack, false)]
	[DisplayName("SR.M('Добавление комментария')")]
	[Uid("4499b326-be63-4926-adb9-ef353f9623b4")]
	public const string AddComment = "4499b326-be63-4926-adb9-ef353f9623b4";

	private static Guid _addCommentGuid;

	[Uid("576fd42d-fc15-4a0b-a31a-e33870792923")]
	[Image(typeof(WorkflowInstanceActions), "help", 16, ImageFormatType.IconPack, false)]
	[DisplayName("SR.M('Задать вопрос')")]
	public const string AddQuestion = "576fd42d-fc15-4a0b-a31a-e33870792923";

	private static Guid _addQuestionGuid;

	[DisplayName("SR.M('Запуск таймера')")]
	[Uid("cd2a1910-e1e8-4f11-abad-ba5d0c0357d2")]
	[Image(typeof(WorkflowInstanceActions), "clock", 16, ImageFormatType.IconPack, false)]
	public const string TimerStarted = "cd2a1910-e1e8-4f11-abad-ba5d0c0357d2";

	private static Guid _timerStartedGuid;

	[Uid("be11dccd-48b5-4014-90f8-63b2beb66fda")]
	[DisplayName("SR.M('Таймер выполнен')")]
	[Image(typeof(WorkflowInstanceActions), "complete", 16, ImageFormatType.IconPack, false)]
	public const string TimerExecuted = "be11dccd-48b5-4014-90f8-63b2beb66fda";

	private static Guid _timerExecutedGuid;

	[Uid("299054d7-3c2c-43f4-ba75-d3ed4c1af9c1")]
	[DisplayName("SR.M('Начало ожидания сообщения')")]
	public const string MessageReceiveStarted = "299054d7-3c2c-43f4-ba75-d3ed4c1af9c1";

	private static Guid _messageReceiveStartedGuid;

	[DisplayName("SR.M('Завершение ожидания сообщения')")]
	[Uid("7c99c551-f9ae-4f9c-bd75-645c048f7411")]
	public const string MessageReceiveCompleted = "7c99c551-f9ae-4f9c-bd75-645c048f7411";

	private static Guid _messageReceiveCompletedGuid;

	[DisplayName("SR.M('Ожидание сообщения прервано')")]
	[Uid("f0c6f773-595d-4aec-9447-fb7e91cef8d1")]
	public const string MessageReceiveTerminated = "f0c6f773-595d-4aec-9447-fb7e91cef8d1";

	private static Guid _messageReceiveTerminatedGuid;

	[Uid("7ce4586b-e190-4c73-9b85-a3cc184b774c")]
	[Image(typeof(WorkflowInstanceActions), "edit", 16, ImageFormatType.IconPack, false)]
	[DisplayName("SR.M('Изменен ответственный')")]
	public const string ChangeResponsible = "7ce4586b-e190-4c73-9b85-a3cc184b774c";

	private static Guid _changeResponsibleGuid;

	[DisplayName("SR.M('Эскалация')")]
	[Uid("5b5c7b54-dd2a-4c19-9f98-ca738933a4a9")]
	[Image(typeof(WorkflowInstanceActions), "escalation", 16, ImageFormatType.IconPack, false)]
	public const string Escalation = "5b5c7b54-dd2a-4c19-9f98-ca738933a4a9";

	private static Guid _escalationGuid;

	[Image(typeof(WorkflowInstanceActions), "escalation", 16, ImageFormatType.IconPack, false)]
	[DisplayName("SR.M('Сообщение при ошибках работы с очередью сообщений')")]
	[Uid("a540ccc2-e4d1-4ad6-9b7f-c4cbffff1a6e")]
	public const string QueueMess = "a540ccc2-e4d1-4ad6-9b7f-c4cbffff1a6e";

	private static Guid _queueMessGuid;

	[Uid("31154101-c639-4fa1-9c77-87284ed9fba9")]
	[DisplayName("SR.M('Эскалация по ошибке')")]
	[Image(typeof(WorkflowInstanceActions), "close_outline", 16, ImageFormatType.IconPack, false)]
	public const string EscalationException = "31154101-c639-4fa1-9c77-87284ed9fba9";

	private static Guid _escalationExceptionGuid;

	[Uid("c591067f-ae72-403c-853c-b3df1568d4e1")]
	[Image(typeof(WorkflowInstanceActions), "escalation_warning", 16, ImageFormatType.IconPack, false)]
	[DisplayName("SR.M('Ошибка выполнения процесса')")]
	public const string ProcessQueueError = "c591067f-ae72-403c-853c-b3df1568d4e1";

	private static Guid _processQueueErrorGuid;

	[Image(typeof(WorkflowInstanceActions), "document_change", 16, ImageFormatType.IconPack, false)]
	[Uid("e93ccf45-3ff5-4bf5-a83b-7ff73130e432")]
	[DisplayName("SR.M('Изменена версия процесса')")]
	public const string ChangeProcessVersion = "e93ccf45-3ff5-4bf5-a83b-7ff73130e432";

	private static Guid _changeProcessVersionGuid;

	internal static WorkflowInstanceActions uoZ7ScOjYQMaZQNoFPkT;

	public static Guid NotificationGuid => _notificationGuid;

	public static Guid TerminateGuid => _terminateGuid;

	public static Guid AddCommentGuid => _addCommentGuid;

	public static Guid AddQuestionGuid => _addQuestionGuid;

	public static Guid TimerStartedGuid => _timerStartedGuid;

	public static Guid TimerExecutedGuid => _timerExecutedGuid;

	public static Guid MessageReceiveStartedGuid => _messageReceiveStartedGuid;

	public static Guid MessageReceiveCompletedGuid => _messageReceiveCompletedGuid;

	public static Guid MessageReceiveTerminatedGuid => _messageReceiveTerminatedGuid;

	public static Guid ChangeResponsibleGuid => _changeResponsibleGuid;

	public static Guid EscalationGuid => _escalationGuid;

	public static Guid QueueMessGuid => _queueMessGuid;

	public static Guid EscalationExceptionGuid => _escalationExceptionGuid;

	public static Guid ProcessQueueErrorGuid => _processQueueErrorGuid;

	public static Guid ChangeProcessVersionGuid => _changeProcessVersionGuid;

	protected WorkflowInstanceActions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OKc7P9OjJLR6FBhw53UU();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowInstanceActions()
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					_messageReceiveCompletedGuid = new Guid((string)MtPNhpOjln9wrXjTLpOY(0x157D5AF4 ^ 0x157F52C8));
					num2 = 7;
					continue;
				case 6:
					_addCommentGuid = new Guid((string)MtPNhpOjln9wrXjTLpOY(-865213812 ^ -865082292));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
					_escalationExceptionGuid = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-17847711 ^ -17904101));
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
					{
						num2 = 5;
					}
					continue;
				case 8:
					_changeProcessVersionGuid = new Guid((string)MtPNhpOjln9wrXjTLpOY(0x56A753C9 ^ 0x56A55AA5));
					num2 = 5;
					continue;
				case 11:
					_timerStartedGuid = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712363497));
					num = 2;
					break;
				case 5:
					return;
				case 12:
					_queueMessGuid = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-684210684 ^ -684339420));
					num2 = 13;
					continue;
				case 15:
					_changeResponsibleGuid = new Guid((string)MtPNhpOjln9wrXjTLpOY(0x1C663DA1 ^ 0x1C643575));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					_processQueueErrorGuid = new Guid((string)MtPNhpOjln9wrXjTLpOY(0x5DB28AD2 ^ 0x5DB39B0A));
					num2 = 8;
					continue;
				default:
					_escalationGuid = new Guid((string)MtPNhpOjln9wrXjTLpOY(-935313063 ^ -935255397));
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num2 = 12;
					}
					continue;
				case 3:
					_notificationGuid = new Guid((string)MtPNhpOjln9wrXjTLpOY(-1965291699 ^ -1965176031));
					num2 = 14;
					continue;
				case 14:
					_terminateGuid = new Guid((string)MtPNhpOjln9wrXjTLpOY(-2111219045 ^ -2111087377));
					num2 = 6;
					continue;
				case 16:
					_messageReceiveStartedGuid = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790353292));
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					OKc7P9OjJLR6FBhw53UU();
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					_messageReceiveTerminatedGuid = new Guid((string)MtPNhpOjln9wrXjTLpOY(0x75BAD659 ^ 0x75B8DED1));
					num2 = 15;
					continue;
				case 1:
					_addQuestionGuid = new Guid((string)MtPNhpOjln9wrXjTLpOY(-684210684 ^ -684343032));
					num = 11;
					break;
				case 2:
					_timerExecutedGuid = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2269BD32 ^ 0x226BBA96));
					num2 = 16;
					continue;
				}
				break;
			}
		}
	}

	internal static void OKc7P9OjJLR6FBhw53UU()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool kPncxNOj8pyymixouU02()
	{
		return uoZ7ScOjYQMaZQNoFPkT == null;
	}

	internal static WorkflowInstanceActions A7v9ymOjs5MZbalTmwBY()
	{
		return uoZ7ScOjYQMaZQNoFPkT;
	}

	internal static object MtPNhpOjln9wrXjTLpOY(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
