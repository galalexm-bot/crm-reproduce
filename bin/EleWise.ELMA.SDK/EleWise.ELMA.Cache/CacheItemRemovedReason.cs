namespace EleWise.ELMA.Cache;

public enum CacheItemRemovedReason
{
	Removed = 1,
	Expired,
	Underused,
	DependencyChanged
}
