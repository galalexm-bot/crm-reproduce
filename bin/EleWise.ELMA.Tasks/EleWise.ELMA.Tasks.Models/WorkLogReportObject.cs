using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Tasks.Models;

public class WorkLogReportObject
{
	public WorkLogReportObject Parent { get; set; }

	public List<WorkLogReportObject> Items { get; set; }

	public Type ObjectType { get; set; }

	public Guid ObjectTypeUid { get; set; }

	public string ObjectTypeName { get; set; }
}
