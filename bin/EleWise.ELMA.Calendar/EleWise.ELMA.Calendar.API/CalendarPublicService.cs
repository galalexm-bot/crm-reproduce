using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Calendar.API;

[Component]
public class CalendarPublicService : IPublicService
{
	public static Guid UID = new Guid("{6CFA68E5-F08A-4935-8798-5C9608F76178}");

	public const string UID_S = "{6CFA68E5-F08A-4935-8798-5C9608F76178}";

	public Guid Uid => UID;

	public Guid ModuleUid => __ModuleInfo.UID;

	public string Name => "Calendar";

	public string Description => SR.T("Сервис для работы с календарем");
}
