using EleWise.ELMA.Ioc.Models;

namespace EleWise.ELMA.Ioc.Abstract;

public interface IIocModule
{
	void OnComponentResolved(IRegistration registration);
}
