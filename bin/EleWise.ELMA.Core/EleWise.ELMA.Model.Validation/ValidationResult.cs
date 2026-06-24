using System.Collections.Generic;
using EleWise.ELMA.Core;

namespace EleWise.ELMA.Model.Validation;

public sealed class ValidationResult
{
	private ValueResult _003CIsValid_003Ek__BackingField;

	private ModelError _003CErrorMessage_003Ek__BackingField;

	private System.Collections.Generic.IReadOnlyCollection<ModelError> _003CInnerErrors_003Ek__BackingField;

	public ValueResult IsValid
	{
		get
		{
			return _003CIsValid_003Ek__BackingField;
		}
		set
		{
			_003CIsValid_003Ek__BackingField = value;
		}
	}

	public ModelError ErrorMessage
	{
		get
		{
			return _003CErrorMessage_003Ek__BackingField;
		}
		set
		{
			_003CErrorMessage_003Ek__BackingField = value;
		}
	}

	public System.Collections.Generic.IReadOnlyCollection<ModelError> InnerErrors
	{
		get
		{
			return _003CInnerErrors_003Ek__BackingField;
		}
		set
		{
			_003CInnerErrors_003Ek__BackingField = value;
		}
	}

	public static ValidationResult Ok()
	{
		return new ValidationResult
		{
			IsValid = ValueResult.Success
		};
	}

	public static ValidationResult InProgress()
	{
		return new ValidationResult
		{
			IsValid = ValueResult.InProgress
		};
	}

	public static ValidationResult Error(string message)
	{
		return new ValidationResult
		{
			IsValid = ValueResult.Error,
			ErrorMessage = new ModelError
			{
				ErrorMessage = message
			}
		};
	}

	public static implicit operator ValidationResult(bool isValid)
	{
		if (!isValid)
		{
			return Error(SR.T("Значение не верно"));
		}
		return Ok();
	}

	public static implicit operator ValidationResult(string errorMessage)
	{
		return Error(errorMessage);
	}

	public static implicit operator bool(ValidationResult validationResult)
	{
		if (validationResult == null)
		{
			return false;
		}
		return validationResult.IsValid == ValueResult.Success;
	}

	public override bool Equals(object o)
	{
		if (!(o is ValidationResult validationResult))
		{
			return false;
		}
		if (IsValid != validationResult.IsValid)
		{
			return false;
		}
		if (ErrorMessage?.ErrorMessage != validationResult.ErrorMessage?.ErrorMessage)
		{
			return false;
		}
		if (InnerErrors?.get_Count() == validationResult.InnerErrors?.get_Count())
		{
			return true;
		}
		return base.Equals(o);
	}
}
