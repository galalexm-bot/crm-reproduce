using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc;

public class CompositeActionResult : PartialViewResult, ITypedActionResult
{
	private IEnumerable<ActionResult> _results;

	private Action<ControllerContext, IEnumerable<ActionResult>> _processResults;

	public ActionResultType ResultType { get; set; }

	public CompositeActionResult(IEnumerable<ActionResult> results, Action<ControllerContext, IEnumerable<ActionResult>> processResults = null)
	{
		if (results == null)
		{
			throw new ArgumentNullException("results");
		}
		_results = results.Where((ActionResult r) => r != null).ToList();
		_processResults = processResults;
	}

	public override void ExecuteResult(ControllerContext context)
	{
		if (_results != null)
		{
			foreach (ActionResult result in _results)
			{
				result.ExecuteResult(context);
			}
		}
		if (_processResults != null)
		{
			_processResults(context, _results);
		}
	}
}
