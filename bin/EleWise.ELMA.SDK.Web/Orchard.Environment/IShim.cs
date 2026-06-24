namespace Orchard.Environment;

public interface IShim
{
	IOrchardHostContainer HostContainer { get; set; }
}
