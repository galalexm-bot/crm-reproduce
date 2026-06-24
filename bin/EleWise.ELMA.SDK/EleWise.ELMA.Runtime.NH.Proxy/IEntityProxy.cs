using NHibernate.Proxy;

namespace EleWise.ELMA.Runtime.NH.Proxy;

internal interface IEntityProxy : INHibernateProxy
{
	INHibernateProxy InitLazyInitializer(ILazyInitializer lazyInitializer);
}
