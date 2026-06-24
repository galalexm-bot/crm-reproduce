using System.Collections.Generic;
using EleWise.ELMA.UI.Metadata;

namespace EleWise.ELMA.UI.Scripts.Services;

public interface IUserDefinedListService
{
	IEnumerable<object> GetUserDefinedList(UserDefinedListInfo userDefinedListInfo);
}
