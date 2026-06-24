using System.Collections.Generic;

namespace EleWise.ELMA.Collections;

public delegate IList<T> DoQueryDelegate<T>(object sender, PagingQueryEventArgs e);
