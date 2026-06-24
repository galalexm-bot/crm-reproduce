using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Security.Mobile.API.Services;

[Component]
public class PermissionPublicService : IPublicService
{
	public static Guid UID = new Guid("{5AE3C9CA-CE63-4185-8B07-F4539CC76050}");

	public const string UID_S = "{5AE3C9CA-CE63-4185-8B07-F4539CC76050}";

	public Guid Uid => UID;

	public Guid ModuleUid => __ModuleInfo.UID;

	public string Name => "Permission";

	public string Description => SR.T("Cервис для работы с привилегиями.");
}
