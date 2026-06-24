using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Common.Mobile.API;

[Component]
internal class VCardPublicService : IPublicService
{
	public static Guid UID = new Guid("{AD4C21A0-93D0-432D-9265-425956765B53}");

	public const string UID_S = "{AD4C21A0-93D0-432D-9265-425956765B53}";

	public Guid Uid => UID;

	public Guid ModuleUid => __ModuleInfo.UID;

	public string Name => "VCard";

	public string Description => SR.T("Сервис для работы с карточками пользователей в формате vCard");
}
