using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EleWise.ELMA.CAB.Events;

internal delegate void EventTopicFireDelegate(object sender, EventArgs e, List<Exception> exceptions, TraceSource traceSource);
