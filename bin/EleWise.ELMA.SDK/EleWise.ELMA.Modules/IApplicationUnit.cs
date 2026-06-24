using System;

namespace EleWise.ELMA.Modules;

public interface IApplicationUnit
{
	string Id { get; }

	Guid Uid { get; }

	string Title { get; }

	string Description { get; }

	string Version { get; }

	string Author { get; }

	IApplicationUnit Owner { get; }
}
