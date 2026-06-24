using System;
using System.Web;
using Orchard.DisplayManagement.Implementation;

namespace Orchard.DisplayManagement.Descriptors;

public class ShapeBinding
{
	public ShapeDescriptor ShapeDescriptor { get; set; }

	public string BindingName { get; set; }

	public string BindingSource { get; set; }

	public Func<DisplayContext, IHtmlString> Binding { get; set; }
}
