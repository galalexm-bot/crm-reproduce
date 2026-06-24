using System.Collections.Generic;
using System.Linq;
using Orchard.ContentManagement.Handlers;

namespace Orchard.ContentManagement.Drivers;

public class CombinedResult : DriverResult
{
	private readonly IEnumerable<DriverResult> _results;

	public CombinedResult(IEnumerable<DriverResult> results)
	{
		_results = results.Where((DriverResult x) => x != null);
	}

	public override void Apply(BuildDisplayContext context)
	{
		foreach (DriverResult result in _results)
		{
			if (result.ContentPart == null && base.ContentPart != null)
			{
				result.ContentPart = base.ContentPart;
			}
			if (result.ContentField == null && base.ContentField != null)
			{
				result.ContentField = base.ContentField;
			}
			result.Apply(context);
		}
	}

	public override void Apply(BuildEditorContext context)
	{
		foreach (DriverResult result in _results)
		{
			if (result.ContentPart == null && base.ContentPart != null)
			{
				result.ContentPart = base.ContentPart;
			}
			if (result.ContentField == null && base.ContentField != null)
			{
				result.ContentField = base.ContentField;
			}
			result.Apply(context);
		}
	}

	public IEnumerable<DriverResult> GetResults()
	{
		return _results;
	}
}
