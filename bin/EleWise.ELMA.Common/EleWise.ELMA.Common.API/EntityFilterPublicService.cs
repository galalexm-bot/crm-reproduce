using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Common.API;

[Component]
internal sealed class EntityFilterPublicService : IPublicService
{
	public static Guid UID = new Guid("{CED09CDF-CF54-4B6F-BE74-E095BECF9801}");

	public const string UID_S = "{CED09CDF-CF54-4B6F-BE74-E095BECF9801}";

	public Guid Uid => UID;

	public Guid ModuleUid => __ModuleInfo.UID;

	public string Name => "EntityFilter";

	public string Description => SR.T("Сервис для работы с фильтрами сущностей");
}
