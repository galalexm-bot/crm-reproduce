using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.UserDefinedList;

[ExtensionPoint(ComponentType.Server)]
public interface IUserDefinedListExecutionHandler
{
	IEnumerable<object> ExecuteGetUserDefinedList(Guid modelSubTypeUid, Guid userDefinedListUid);
}
