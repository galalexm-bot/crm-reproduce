using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Deploy.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IPostEntityXmlSerializer
{
	string Replace(string serializedObject);

	string UndoReplace(string serializedObject);
}
