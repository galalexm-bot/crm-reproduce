using EleWise.ELMA.FullTextSearch.Descriptors;

namespace EleWise.ELMA.Model.Types;

public interface IFullTextTypeDescriptor
{
	IFullTextPropertyDescriptor FullTextPropertyDescriptor { get; }
}
