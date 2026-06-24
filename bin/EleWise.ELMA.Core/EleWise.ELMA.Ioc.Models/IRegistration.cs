using System;

namespace EleWise.ELMA.Ioc.Models;

public interface IRegistration
{
	object Instance { get; }

	System.Type Type { get; }
}
