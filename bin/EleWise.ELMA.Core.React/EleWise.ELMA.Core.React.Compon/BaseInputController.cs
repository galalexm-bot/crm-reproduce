using System;
using System.Collections.Generic;
using System.Linq;
using Bridge.Html5;
using Bridge.React;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Core.React.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Components;

public abstract class BaseInputController<TM, TContext> : Controller<TContext>, IBaseInputController, IController, IRequireOwnerController where TContext : IBaseContext
{
	private long caretPosition;

	protected IViewModel RenderOwner;

	public void SetOwner(IViewModel owner)
	{
		RenderOwner = owner;
	}

	public virtual string GetName(string newName = "")
	{
		string text = newName;
		if (string.IsNullOrWhiteSpace(text))
		{
			if (base.Context.PropertyMetadata == null)
			{
				return "";
			}
			IPropertyMetadata val = base.Context.PropertyMetadata.Invoke();
			if (val == null)
			{
				return "";
			}
			text = ((INamedMetadata)val).get_Name();
		}
		if (!string.IsNullOrWhiteSpace(text))
		{
			if (RenderOwner != null && RenderOwner.GetDynamicData() is DataStack dataStack && ((HashSet<DataStackItem>)dataStack).get_Count() > 0 && Enumerable.LastOrDefault<DataStackItem>((System.Collections.Generic.IEnumerable<DataStackItem>)dataStack)?.Data != null)
			{
				return "";
			}
			IViewModel obj = base.Context.PropertyOwner?.Invoke();
			ClassMetadata val2 = (RenderOwner as IMetadataViewModel)?.ModelMetadata?.Metadata;
			ModelMetadata modelMetadata = obj?.Context.GetPlainPropertyValue<ModelMetadata>("ModelMetadata");
			if (modelMetadata == null)
			{
				return text;
			}
			string text2 = "";
			if (val2 is EntityMetadata || val2 is DataClassMetadata)
			{
				text2 = "Entity";
			}
			else if (val2 is ComponentContextMetadata)
			{
				text2 = "Context";
			}
			string[] prefix = modelMetadata.Prefix;
			if (prefix != null && prefix.Length != 0)
			{
				string text3 = string.Join(".", prefix);
				if (text3.StartsWith("{30C24112-052F-426C-AC26-6735A2B99C13}"))
				{
					text3 = text3.Replace("{30C24112-052F-426C-AC26-6735A2B99C13}.", "").Replace("{30C24112-052F-426C-AC26-6735A2B99C13}", "");
					if (text3 == "RegistrationCard" || text3.StartsWith("RegistrationCard."))
					{
						return text3 + "." + text;
					}
				}
				if (text3.StartsWith("{BB1D12A0-7814-48DC-BD8A-9C666BF9BEA8}"))
				{
					text3 = text3.Replace("{BB1D12A0-7814-48DC-BD8A-9C666BF9BEA8}.", "").Replace("{BB1D12A0-7814-48DC-BD8A-9C666BF9BEA8}", "");
					if (text3 == "RegistrationCard")
					{
						text3 += "[0]";
					}
					else if (text3.StartsWith("RegistrationCard."))
					{
						string[] array = text3.Split(new char[1] { '.' }, (StringSplitOptions)1);
						array[0] += "[0]";
						text3 = string.Join(".", array);
					}
				}
				if (!string.IsNullOrWhiteSpace(text3))
				{
					return string.Concat(new string[5] { text2, ".", text3, ".", text });
				}
				return text2 + "." + text;
			}
			return text2 + "." + text;
		}
		return "";
	}

	public void OnChange(TM value, ChangeEvent<HTMLInputElement> ev)
	{
		if (ev != null)
		{
			caretPosition = ((SyntheticEvent<HTMLInputElement>)(object)ev).CurrentTarget.SelectionStart;
		}
		KeyboardEvent<TM> keyboardEvent = new KeyboardEvent<TM>
		{
			CaretPosition = caretPosition,
			Value = value
		};
		((IInputComponentContainer)base.Component).OnKeyPress?.Invoke((IKeyboardEvent)keyboardEvent);
	}

	public void OnKeyPress(KeyboardEvent<HTMLInputElement> newEv)
	{
		caretPosition = ((SyntheticEvent<HTMLInputElement>)(object)newEv).CurrentTarget.SelectionStart;
		((IInputComponentContainer)base.Component).OnKeyPress?.Invoke((IKeyboardEvent)new KeyboardEvent<TM>
		{
			Value = ObjectExtensions.As<TM>(base.Context.Model),
			CaretPosition = caretPosition
		});
	}

	public void OnFocus(FocusEvent<HTMLInputElement> ev = null)
	{
		if (ev != null)
		{
			caretPosition = ((SyntheticEvent<HTMLInputElement>)(object)ev).CurrentTarget.SelectionStart;
		}
		((IInputComponentContainer)base.Component).OnFocus?.Invoke((IFocusEvent)new FocusEvent<TM>
		{
			CaretPosition = caretPosition,
			Value = ObjectExtensions.As<TM>(base.Context.Model)
		});
	}

	public void OnBlur(TM value, FocusEvent<HTMLInputElement> ev = null)
	{
		if (ev != null)
		{
			caretPosition = ((SyntheticEvent<HTMLInputElement>)(object)ev).CurrentTarget.SelectionStart;
		}
		ChangeEvent<TM> changeEvent = new ChangeEvent<TM>
		{
			CaretPosition = caretPosition,
			Value = value
		};
		((IInputComponentContainer)base.Component).OnBlur?.Invoke((IChangeEvent)changeEvent);
	}
}
public class BaseInputController<TM> : BaseInputController<TM, BaseContext<TM>>
{
}
public class BaseInputController : BaseInputController<object, IBaseContext>
{
}
