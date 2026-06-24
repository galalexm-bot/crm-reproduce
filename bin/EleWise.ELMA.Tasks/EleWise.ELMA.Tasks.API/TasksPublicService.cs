using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Tasks.API;

[Component]
public class TasksPublicService : IPublicService
{
	public static Guid UID = new Guid("{895E5AB8-B31A-4696-BD55-FE2EA6988C11}");

	public const string UID_S = "{895E5AB8-B31A-4696-BD55-FE2EA6988C11}";

	public Guid Uid => UID;

	public Guid ModuleUid => __ModuleInfo.UID;

	public string Name => "Tasks";

	public string Description => SR.T("Сервис для работы с задачами");
}
