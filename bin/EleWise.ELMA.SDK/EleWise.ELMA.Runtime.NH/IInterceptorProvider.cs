using NHibernate;

namespace EleWise.ELMA.Runtime.NH;

public interface IInterceptorProvider
{
	IInterceptor GetInterceptor(ISessionFactory factory);
}
