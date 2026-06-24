using System;
using System.Collections;
using System.Collections.Generic;
using Bridge;

namespace EleWise.ELMA.Model;

public interface IDataStack : System.Collections.Generic.IEnumerable<DataStackItem>, System.Collections.IEnumerable, IBridgeClass, ICloneable
{
	IDataStack Clone();
}
