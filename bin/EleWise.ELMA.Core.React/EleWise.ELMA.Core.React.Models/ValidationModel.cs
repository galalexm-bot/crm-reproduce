using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Validation;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Models;

public class ValidationModel : IViewModelValidationModel, IValidationModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ValidationResult, bool> _003C_003E9__3_2;

		public static Func<ValidationResult, bool> _003C_003E9__5_0;

		public static Func<ValidationResult, bool> _003C_003E9__7_0;

		public static Func<ValidationResult, bool> _003C_003E9__7_1;

		public static Func<ValidationResult, ModelError> _003C_003E9__7_2;

		public static Func<ValidationResult, System.Collections.Generic.IEnumerable<ModelError>> _003C_003E9__7_3;

		internal bool _003C_002Ector_003Eb__3_2(ValidationResult v)
		{
			return v.IsValid != ValueResult.Error;
		}

		internal bool _003Cget_IsValid_003Eb__5_0(ValidationResult v)
		{
			return v.IsValid != ValueResult.Error;
		}

		internal bool _003Cget_Errors_003Eb__7_0(ValidationResult v)
		{
			return v.IsValid == ValueResult.Error;
		}

		internal bool _003Cget_Errors_003Eb__7_1(ValidationResult e)
		{
			return e.ErrorMessage != null;
		}

		internal ModelError _003Cget_Errors_003Eb__7_2(ValidationResult r)
		{
			return r.ErrorMessage;
		}

		internal System.Collections.Generic.IEnumerable<ModelError> _003Cget_Errors_003Eb__7_3(ValidationResult e)
		{
			return (System.Collections.Generic.IEnumerable<ModelError>)e.InnerErrors;
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public ValidationModel _003C_003E4__this;

		public Func<ValidationResult> validateFunc;

		internal void _003CAddValidator_003Eb__0(ValidationResult newResult)
		{
			ValidationResult validationResult = default(ValidationResult);
			if (((IDictionary<Func<ValidationResult>, ValidationResult>)_003C_003E4__this.list).TryGetValue(validateFunc, ref validationResult) && !((object)newResult).Equals((object)validationResult))
			{
				((IDictionary<Func<ValidationResult>, ValidationResult>)_003C_003E4__this.list).set_Item(validateFunc, newResult);
			}
		}
	}

	private readonly IViewModel viewModel;

	private bool isValid;

	private IReactiveDictionary<Func<ValidationResult>, ValidationResult> list;

	public bool IsValid
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			if (ReactiveHelper.InAction())
			{
				ValidationResult validationResult = default(ValidationResult);
				for (int i = 0; i < ((System.Collections.Generic.ICollection<KeyValuePair<Func<ValidationResult>, ValidationResult>>)list).get_Count(); i++)
				{
					Func<ValidationResult> key = Enumerable.ElementAt<KeyValuePair<Func<ValidationResult>, ValidationResult>>((System.Collections.Generic.IEnumerable<KeyValuePair<Func<ValidationResult>, ValidationResult>>)list, i).get_Key();
					if (((IDictionary<Func<ValidationResult>, ValidationResult>)list).TryGetValue(key, ref validationResult))
					{
						((IDictionary<Func<ValidationResult>, ValidationResult>)list).set_Item(key, key.Invoke());
					}
				}
				isValid = Enumerable.All<ValidationResult>((System.Collections.Generic.IEnumerable<ValidationResult>)((IDictionary<Func<ValidationResult>, ValidationResult>)list).get_Values(), (Func<ValidationResult, bool>)((ValidationResult v) => v.IsValid != ValueResult.Error));
				return isValid;
			}
			return isValid;
		}
	}

	public System.Collections.Generic.IReadOnlyCollection<ModelError> Errors
	{
		get
		{
			ValidationResult[] array = Enumerable.Where<ValidationResult>((System.Collections.Generic.IEnumerable<ValidationResult>)((IDictionary<Func<ValidationResult>, ValidationResult>)list).get_Values(), (Func<ValidationResult, bool>)((ValidationResult v) => v.IsValid == ValueResult.Error)).ToArray();
			if (array.Length == 0)
			{
				return (System.Collections.Generic.IReadOnlyCollection<ModelError>)(object)new ModelError[0];
			}
			return (System.Collections.Generic.IReadOnlyCollection<ModelError>)(object)Enumerable.Where<ValidationResult>((System.Collections.Generic.IEnumerable<ValidationResult>)array, (Func<ValidationResult, bool>)((ValidationResult e) => e.ErrorMessage != null)).Select<ModelError>((Func<ValidationResult, ModelError>)((ValidationResult r) => r.ErrorMessage)).Concat((System.Collections.Generic.IEnumerable<ModelError>)Enumerable.SelectMany<ValidationResult, ModelError>((System.Collections.Generic.IEnumerable<ValidationResult>)array, (Func<ValidationResult, System.Collections.Generic.IEnumerable<ModelError>>)((ValidationResult e) => (System.Collections.Generic.IEnumerable<ModelError>)e.InnerErrors)))
				.ToArray();
		}
	}

	public ValidationModel(IViewModel viewModel)
	{
		this.viewModel = viewModel;
		list = new ReactiveDictionary<Func<ValidationResult>, ValidationResult>();
		ViewModel.DefineProperty(this, new PropertyInfoExpression
		{
			ObjectExpression = "isValid",
			ExpressionForSerialize = "isValid"
		});
	}

	public ValidationResult GetSummaryResult()
	{
		if (IsValid)
		{
			return ValidationResult.Ok();
		}
		System.Collections.Generic.IReadOnlyCollection<ModelError> errors = Errors;
		if (errors.get_Count() == 0)
		{
			return ValidationResult.InProgress();
		}
		if (((System.Collections.Generic.ICollection<KeyValuePair<Func<ValidationResult>, ValidationResult>>)list).get_Count() == 0)
		{
			return ValidationResult.Ok();
		}
		return new ValidationResult
		{
			IsValid = ValueResult.Error,
			InnerErrors = errors
		};
	}

	public void AddValidator(Func<ValidationResult> validateFunc, string name = "")
	{
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
		_003C_003Ec__DisplayClass9_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass9_.validateFunc = validateFunc;
		ValidationResult validationResult = ValidationResult.InProgress();
		((IDictionary<Func<ValidationResult>, ValidationResult>)list).Add(_003C_003Ec__DisplayClass9_.validateFunc, validationResult);
	}

	public void RemoveValidator(Func<ValidationResult> validateFunc)
	{
		ValidationResult validationResult = default(ValidationResult);
		if (((IDictionary<Func<ValidationResult>, ValidationResult>)list).TryGetValue(validateFunc, ref validationResult))
		{
			((IDictionary<Func<ValidationResult>, ValidationResult>)list).Remove(validateFunc);
		}
	}

	public void Destroy()
	{
		((System.Collections.Generic.ICollection<KeyValuePair<Func<ValidationResult>, ValidationResult>>)list).Clear();
	}

	private bool _003C_002Ector_003Eb__3_0()
	{
		return Enumerable.All<ValidationResult>((System.Collections.Generic.IEnumerable<ValidationResult>)((IDictionary<Func<ValidationResult>, ValidationResult>)list).get_Values(), (Func<ValidationResult, bool>)((ValidationResult v) => v.IsValid != ValueResult.Error));
	}

	private void _003C_002Ector_003Eb__3_1(bool result)
	{
		isValid = result;
	}
}
