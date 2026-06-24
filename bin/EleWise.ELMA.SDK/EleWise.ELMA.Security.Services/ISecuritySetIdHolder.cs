namespace EleWise.ELMA.Security.Services;

public interface ISecuritySetIdHolder : IInstanceSettingsPermissionHolder
{
	long? UserSecuritySetCacheId { get; set; }
}
