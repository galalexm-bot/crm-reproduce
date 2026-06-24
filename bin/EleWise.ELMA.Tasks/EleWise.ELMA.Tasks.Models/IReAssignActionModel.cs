using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Tasks.Models;

public interface IReAssignActionModel : IAutoImplement
{
	[DisplayName(typeof(__Resources_IReAssignActionModel), "P_TaskId_DisplayName")]
	long TaskId { get; set; }

	[DisplayName(typeof(__Resources_IReAssignActionModel), "P_StartDate_DisplayName")]
	DateTime StartDate { get; set; }

	[DisplayName(typeof(__Resources_IReAssignActionModel), "P_EndDate_DisplayName")]
	DateTime EndDate { get; set; }

	[DisplayName(typeof(__Resources_IReAssignActionModel), "P_Executor_DisplayName")]
	IUser Executor { get; set; }

	[DisplayName(typeof(__Resources_IReAssignActionModel), "P_Priority_DisplayName")]
	TaskPriority Priority { get; set; }

	[DisplayName(typeof(__Resources_IReAssignActionModel), "P_Comment_DisplayName")]
	IComment Comment { get; set; }
}
