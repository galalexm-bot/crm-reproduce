namespace EleWise.ELMA.XmlSerializers;

internal interface INameScope
{
	object this[string name, string ns] { get; set; }
}
