using System;

namespace EleWise.ELMA.CAB.Commands;

public interface ICommandAdapterMapService
{
	void Register(Type invokerType, Type adapterType);

	CommandAdapter CreateAdapter(Type invokerType);

	void UnRegister(Type invokerType);
}
