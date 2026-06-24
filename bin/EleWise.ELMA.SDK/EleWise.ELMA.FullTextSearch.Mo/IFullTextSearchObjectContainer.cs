using System.Dynamic;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.FullTextSearch.Model;

public interface IFullTextSearchObjectContainer
{
	IFullTextSearchObject SearchObject { get; set; }

	IEntity IndexedObject { get; set; }

	ExpandoObject Properties { get; set; }
}
