namespace EleWise.ELMA.Cache;

public delegate void CacheItemRemovedCallback<in T>(string key, T value, CacheItemRemovedReason reason);
