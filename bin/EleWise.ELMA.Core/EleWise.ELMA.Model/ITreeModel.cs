namespace EleWise.ELMA.Model;

public interface ITreeModel
{
	string Key { get; }

	string ParentKey { get; }

	string Value { get; }
}
