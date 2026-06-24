namespace EleWise.ELMA.Model.Entities;

public interface IPersistent
{
	void Save();

	void Update();

	void Delete();

	void Refresh();
}
