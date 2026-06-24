namespace EleWise.ELMA.Security.Services;

public interface ISecurityExpressionSetIdHolder : IInstanceExpressionPermissionHolder
{
	long? UserSecuritySetCacheId { get; set; }
}
