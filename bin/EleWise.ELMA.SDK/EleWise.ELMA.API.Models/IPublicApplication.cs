using System;

namespace EleWise.ELMA.API.Models;

public interface IPublicApplication
{
	Guid Uid { get; }

	string Name { get; }

	string Description { get; }

	string Author { get; }

	string Site { get; }
}
