using System;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Serialization;

[ExtensionPoint]
public interface IDeserialization
{
	bool Check(System.Type type);

	object Deserialize(System.Type type, string json);
}
