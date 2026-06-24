using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Messages.API;

[Component]
public class MessagesPublicService : IPublicService
{
	public static Guid UID = new Guid("{B27DCF16-BBDE-44CC-9729-D920DEFC303E}");

	public const string UID_S = "{B27DCF16-BBDE-44CC-9729-D920DEFC303E}";

	public Guid Uid => UID;

	public Guid ModuleUid => __ModuleInfo.UID;

	public string Name => "Messages";

	public string Description => SR.T("Сервис для работы с сообщениями");
}
