using System;

namespace EleWise.ELMA.XmlSerializers;

public class UnreferencedObjectEventArgs : EventArgs
{
	private object o;

	private string id;

	public object UnreferencedObject => o;

	public string UnreferencedId => id;

	public UnreferencedObjectEventArgs(object o, string id)
	{
		this.o = o;
		this.id = id;
	}
}
