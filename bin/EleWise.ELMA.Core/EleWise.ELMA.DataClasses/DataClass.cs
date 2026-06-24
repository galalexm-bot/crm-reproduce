using Bridge;

namespace EleWise.ELMA.DataClasses;

public abstract class DataClass : IDataClass
{
	[Template("Bridge.is({this}, {T})")]
	public extern bool Is<T>() where T : DataClass;

	[Template("Bridge.as({this}, {T})")]
	public extern T As<T>() where T : DataClass;
}
