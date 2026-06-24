namespace Orchard.UI;

public interface IZoneCollection
{
	IZone this[string key] { get; }
}
