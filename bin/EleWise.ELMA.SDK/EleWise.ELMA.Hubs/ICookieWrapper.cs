namespace EleWise.ELMA.Hubs;

public interface ICookieWrapper
{
	string Name { get; }

	string Domain { get; }

	string Path { get; }

	string Value { get; }
}
