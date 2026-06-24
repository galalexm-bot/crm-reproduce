using System;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Services;

[ServiceContract]
public interface IControllerFactory
{
	object CreateController(System.Type controllerType);
}
