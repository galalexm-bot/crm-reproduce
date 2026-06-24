namespace Orchard.Tasks;

public interface IBackgroundService : IDependency
{
	void Sweep();
}
