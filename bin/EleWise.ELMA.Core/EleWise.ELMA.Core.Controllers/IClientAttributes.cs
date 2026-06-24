namespace EleWise.ELMA.Core.Controllers;

public interface IClientAttributes
{
	string Name { get; }

	string Description { get; }

	bool Required { get; }

	bool Disabled { get; }

	string Placeholder { get; }

	string Tooltip { get; }
}
