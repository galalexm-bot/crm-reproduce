using System;
using System.Collections.Generic;
using System.Linq;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

public static class TaskMarkerUsage
{
	public static List<TaskMarker> GetMarkers(Type elementType)
	{
		Contract.ArgumentNotNull(elementType, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF42BFC8));
		IEnumerable<SupportedMarkerAttribute> source = elementType.GetCustomAttributes(typeof(SupportedMarkerAttribute), inherit: true).Cast<SupportedMarkerAttribute>();
		return new TaskMarker[1].Union(source.Select((SupportedMarkerAttribute a) => a.Marker)).Distinct().ToList();
	}
}
