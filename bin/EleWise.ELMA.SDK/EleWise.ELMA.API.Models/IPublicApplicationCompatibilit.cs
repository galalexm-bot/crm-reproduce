namespace EleWise.ELMA.API.Models;

public interface IPublicApplicationCompatibilityError
{
	bool IsError { get; }

	string Message { get; }
}
