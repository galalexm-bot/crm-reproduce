using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.FullTextSearch.Model;

public interface IFullTextSearchObject : IAutoImplement
{
	[DisplayName("TypeUid")]
	string TypeUid { get; set; }

	string Id { get; set; }
}
