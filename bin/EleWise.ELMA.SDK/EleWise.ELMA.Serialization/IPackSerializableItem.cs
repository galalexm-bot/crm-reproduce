namespace EleWise.ELMA.Serialization;

public interface IPackSerializableItem
{
	string Serialize();

	void DeserializeFrom(string value);
}
