using System;
using System.Activities;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Services;

public interface IWorkflowExecutingContext : IDisposable
{
	WorkflowApplication Application { get; }

	IWorkflowInstance Instance { get; }

	bool IsTerminated { get; }

	void ResumeBookmark(string bookmarkName, object value);

	void ResumeBookmark(Guid bookmarkUid, object value);

	void Run();

	void Terminate(string reason);
}
