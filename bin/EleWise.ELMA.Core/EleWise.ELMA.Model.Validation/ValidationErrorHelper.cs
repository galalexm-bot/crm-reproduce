using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;

namespace EleWise.ELMA.Model.Validation;

public static class ValidationErrorHelper
{
	public static string GetMessage(object validationErrors)
	{
		return GetMessage(ObjectExtensions.As<System.Collections.Generic.ICollection<ValidationError>>(validationErrors));
	}

	internal static string GetMessage(System.Collections.Generic.ICollection<ValidationError> validationErrors)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (validationErrors == null)
		{
			return "";
		}
		StringBuilder val = new StringBuilder();
		System.Collections.Generic.IEnumerator<ValidationError> enumerator = ((System.Collections.Generic.IEnumerable<ValidationError>)validationErrors).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				GetMessage(enumerator.get_Current(), val);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return ((object)val).ToString();
	}

	private static void GetMessage(ValidationError validationError, StringBuilder builder)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(validationError.get_Message()))
		{
			return;
		}
		builder.AppendLine(validationError.get_Message());
		if (validationError.get_ElementTypeUid() != Guid.Empty)
		{
			builder.AppendLine("ElementType: " + GetElementTypeDisplayName(validationError.get_ElementTypeUid()));
		}
		if (validationError.get_ElementUid() != Guid.Empty)
		{
			builder.AppendLine(string.Concat((object)"ElementUid: ", (object)validationError.get_ElementUid()));
		}
		if (validationError.get_InnerErrors() != null)
		{
			ValidationError[] innerErrors = validationError.get_InnerErrors();
			for (int i = 0; i < innerErrors.Length; i++)
			{
				GetMessage(innerErrors[i], builder);
			}
		}
	}

	private static string GetElementTypeDisplayName(Guid elementTypeUid)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (elementTypeUid == ValidationElementType.ComponentViewItem)
		{
			return "ComponentViewItem";
		}
		if (elementTypeUid == ValidationElementType.ObjectFormViewItem)
		{
			return "ObjectFormViewItem";
		}
		if (elementTypeUid == ValidationElementType.Property)
		{
			return "Property";
		}
		if (elementTypeUid == ValidationElementType.ViewItem)
		{
			return "ViewItem";
		}
		return "Unknown";
	}
}
