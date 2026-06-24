using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public class FormPropertyDescriptor : Dictionary<string, object>
{
	public string formTheme;

	public string caption;

	public string description;

	public string propertyName;

	public Expression expression;

	public string expressionText;

	public ModelMetadata metadata;

	public string partialName;

	public Func<dynamic, object> template;

	public Func<HtmlHelper, FormPropertyDescriptor, MvcHtmlString> renderer;

	public bool showValidationMessage;

	public bool required;

	public bool isReadOnly;

	public IDictionary<string, string> captionAttributes;

	public IDictionary<string, string> attributes;

	public IDictionary<string, string> valueAttributes;
}
