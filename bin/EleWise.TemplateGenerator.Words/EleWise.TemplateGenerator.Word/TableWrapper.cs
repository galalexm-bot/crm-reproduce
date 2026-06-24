using Aspose.Words;
using Aspose.Words.Tables;

namespace EleWise.TemplateGenerator.Words.Internal;

internal class TableWrapper : CompositeNodeWrapper
{
	public TableWrapper(Table t, NodeWrapper parent)
		: base((CompositeNode)(object)t, parent)
	{
	}
}
