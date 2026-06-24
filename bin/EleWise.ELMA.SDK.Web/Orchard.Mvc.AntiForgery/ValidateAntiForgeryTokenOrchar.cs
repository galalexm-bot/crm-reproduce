using System;
using System.Web.Mvc;

namespace Orchard.Mvc.AntiForgery;

[AttributeUsage(AttributeTargets.Method)]
public class ValidateAntiForgeryTokenOrchardAttribute : FilterAttribute
{
	private readonly bool _enabled = true;

	public bool Enabled => _enabled;

	public ValidateAntiForgeryTokenOrchardAttribute()
		: this(enabled: true)
	{
	}

	public ValidateAntiForgeryTokenOrchardAttribute(bool enabled)
	{
		_enabled = enabled;
	}
}
