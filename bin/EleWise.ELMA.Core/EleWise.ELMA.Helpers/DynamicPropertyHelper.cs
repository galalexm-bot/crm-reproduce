using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Dependencies;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Signatures;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Views;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Helpers;

public static class DynamicPropertyHelper<T>
{
	public static string GetExpression<TResult>(Expression<Func<T, TResult>> propAccessor)
	{
		Expression body = ((LambdaExpression)propAccessor).get_Body();
		MemberExpression val = (MemberExpression)(object)((body is MemberExpression) ? body : null);
		if (val == null)
		{
			return "";
		}
		List<string> val2 = new List<string>();
		while (val != null)
		{
			val2.Insert(0, val.get_Member().get_Name());
			Expression expression = val.get_Expression();
			MemberExpression val3 = (MemberExpression)(object)((expression is MemberExpression) ? expression : null);
			if (val3 == null)
			{
				Expression expression2 = val.get_Expression();
				Expression obj = ((expression2 is UnaryExpression) ? expression2 : null);
				Expression obj2 = ((obj != null) ? ((UnaryExpression)obj).get_Operand() : null);
				val3 = (MemberExpression)(object)((obj2 is MemberExpression) ? obj2 : null);
			}
			val = val3;
		}
		return string.Join(".", (System.Collections.Generic.IEnumerable<string>)val2);
	}
}
public static class DynamicPropertyHelper
{
	public static TypeSignature TypeSignatureMapFromObject(TypeSignature typeSignature1)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		TypeSignature obj = InterfaceCreator.Create<TypeSignature>();
		obj.set_Nullable(typeSignature1.Nullable);
		obj.set_RelationType(typeSignature1.RelationType);
		obj.set_TypeUid(typeSignature1.TypeUid);
		obj.set_SubTypeUid(typeSignature1.SubTypeUid);
		return obj;
	}

	public static TypeSignature TypeSignatureMapToObject(TypeSignature typeSignature1, IReactiveModelFactory reactiveModelFactory = null)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (typeSignature1 == null)
		{
			return null;
		}
		TypeSignature obj = ((reactiveModelFactory != null) ? reactiveModelFactory.CreateModel<TypeSignature>() : new TypeSignature());
		obj.Nullable = typeSignature1.get_Nullable();
		obj.RelationType = typeSignature1.get_RelationType();
		obj.TypeUid = typeSignature1.get_TypeUid();
		obj.SubTypeUid = typeSignature1.get_SubTypeUid();
		return obj;
	}

	public static ComputedValue ComputedValueMapFromObject(ComputedValue computedValue)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		if (computedValue == null)
		{
			return null;
		}
		ComputedValue val = null;
		if (computedValue is ActionInputComputedValue actionInputComputedValue)
		{
			ActionInputComputedValue obj = InterfaceCreator.Create<ActionInputComputedValue>();
			obj.set_ParameterType(TypeSignatureMapFromObject(actionInputComputedValue.ParameterType));
			obj.set_ReturnType(TypeSignatureMapFromObject(actionInputComputedValue.ReturnType));
			val = (ComputedValue)(object)obj;
		}
		if (computedValue is InputComputedValue inputComputedValue)
		{
			InputComputedValue val2;
			if ((val2 = (InputComputedValue)(object)((val is InputComputedValue) ? val : null)) == null)
			{
				val2 = InterfaceCreator.Create<InputComputedValue>();
				val = (ComputedValue)(object)val2;
			}
			val2.set_Nullable(inputComputedValue.Nullable);
			val2.set_Required(inputComputedValue.Required);
			val2.set_RelationType(inputComputedValue.RelationType);
			val2.set_TypeUid(inputComputedValue.TypeUid);
			val2.set_SubTypeUid(inputComputedValue.SubTypeUid);
		}
		if (val == null)
		{
			val = InterfaceCreator.Create<ComputedValue>();
		}
		val.set_Name(computedValue.Name);
		val.set_Value(computedValue.Value);
		val.set_CalculateScript(computedValue.CalculateScript);
		val.set_MethodName(computedValue.MethodName);
		Guid[] propertyParents = computedValue.PropertyParents;
		if (propertyParents != null)
		{
			val.get_PropertyParents().AddRange(propertyParents);
		}
		val.set_PropertyUid(computedValue.PropertyUid);
		val.set_ComputedValueType(computedValue.ComputedValueType);
		return val;
	}

	public static ComputedValue ComputedValueMapToObject(ComputedValue computedValue, IReactiveModelFactory reactiveModelFactory = null)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		ComputedValue computedValue2 = null;
		ActionInputComputedValue val;
		if ((val = (ActionInputComputedValue)(object)((computedValue is ActionInputComputedValue) ? computedValue : null)) != null)
		{
			ActionInputComputedValue obj = ((reactiveModelFactory != null) ? reactiveModelFactory.CreateModel<ActionInputComputedValue>() : new ActionInputComputedValue());
			obj.ParameterType = TypeSignatureMapToObject(val.get_ParameterType(), reactiveModelFactory);
			obj.ReturnType = TypeSignatureMapToObject(val.get_ReturnType(), reactiveModelFactory);
			computedValue2 = obj;
		}
		InputComputedValue val2;
		if ((val2 = (InputComputedValue)(object)((computedValue is InputComputedValue) ? computedValue : null)) != null)
		{
			InputComputedValue inputComputedValue;
			if ((inputComputedValue = computedValue2 as InputComputedValue) == null)
			{
				inputComputedValue = ((reactiveModelFactory != null) ? reactiveModelFactory.CreateModel<InputComputedValue>() : new InputComputedValue());
				computedValue2 = inputComputedValue;
			}
			inputComputedValue.Nullable = val2.get_Nullable();
			inputComputedValue.Required = val2.get_Required();
			inputComputedValue.RelationType = val2.get_RelationType();
			inputComputedValue.TypeUid = val2.get_TypeUid();
			inputComputedValue.SubTypeUid = val2.get_SubTypeUid();
		}
		if (computedValue2 == null)
		{
			computedValue2 = ((reactiveModelFactory != null) ? reactiveModelFactory.CreateModel<ComputedValue>() : new ComputedValue());
		}
		computedValue2.Name = computedValue.get_Name();
		computedValue2.Value = computedValue.get_Value();
		computedValue2.CalculateScript = computedValue.get_CalculateScript();
		computedValue2.MethodName = computedValue.get_MethodName();
		computedValue2.PropertyParents = Enumerable.ToArray<Guid>((System.Collections.Generic.IEnumerable<Guid>)computedValue.get_PropertyParents());
		computedValue2.PropertyUid = computedValue.get_PropertyUid();
		computedValue2.ComputedValueType = computedValue.get_ComputedValueType();
		return computedValue2;
	}

	public static void ComputedValueMap(ComputedValue oldValue, ComputedValue newValue)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (oldValue != null && newValue != null)
		{
			oldValue.Name = newValue.Name;
			oldValue.Value = newValue.Value;
			oldValue.CalculateScript = newValue.CalculateScript;
			oldValue.MethodName = newValue.MethodName;
			Guid[] propertyParents = newValue.PropertyParents;
			oldValue.PropertyParents = (Guid[])(((object)((propertyParents != null) ? Enumerable.ToArray<Guid>((System.Collections.Generic.IEnumerable<Guid>)propertyParents) : null)) ?? ((object)new Guid[0]));
			oldValue.PropertyUid = newValue.PropertyUid;
			oldValue.ComputedValueType = newValue.ComputedValueType;
			if (oldValue is InputComputedValue inputComputedValue && newValue is InputComputedValue inputComputedValue2)
			{
				inputComputedValue.Nullable = inputComputedValue2.Nullable;
				inputComputedValue.Required = inputComputedValue2.Required;
				inputComputedValue.RelationType = inputComputedValue2.RelationType;
				inputComputedValue.TypeUid = inputComputedValue2.TypeUid;
				inputComputedValue.SubTypeUid = inputComputedValue2.SubTypeUid;
			}
			if (oldValue is ActionInputComputedValue actionInputComputedValue && newValue is ActionInputComputedValue actionInputComputedValue2)
			{
				TypeSignatureMap(actionInputComputedValue.ParameterType, actionInputComputedValue2.ParameterType);
				TypeSignatureMap(actionInputComputedValue.ReturnType, actionInputComputedValue2.ReturnType);
			}
		}
	}

	public static void TypeSignatureMap(TypeSignature oldValue, TypeSignature newValue)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (oldValue != null && newValue != null)
		{
			oldValue.Nullable = newValue.Nullable;
			oldValue.RelationType = newValue.RelationType;
			oldValue.TypeUid = newValue.TypeUid;
			oldValue.SubTypeUid = newValue.SubTypeUid;
		}
	}

	public static Tuple<object, string> GetDynamicPropertyInfo(object target, string dynamicPropertyName)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		string[] array = dynamicPropertyName.Split(new char[1] { '.' });
		string text = Enumerable.Last<string>((System.Collections.Generic.IEnumerable<string>)array);
		array = Enumerable.Take<string>((System.Collections.Generic.IEnumerable<string>)array, array.Length - 1).ToArray();
		string[] array2 = array;
		foreach (string propertyName in array2)
		{
			if (target == null)
			{
				break;
			}
			target = FindPath(target, propertyName).Item1;
		}
		if (target != null)
		{
			text = FindPath(target, text).Item2;
		}
		return new Tuple<object, string>(target, text);
	}

	public static bool IgnoreType(Guid typeUid)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (!(typeUid == Guid.Empty) && !(typeUid == EntityDescriptor.UID) && !(typeUid == DataClassDescriptor.UID) && !(typeUid == ListOfSimpleTypeDescriptor.UID))
		{
			return typeUid == FormViewItemDescriptor.UID;
		}
		return true;
	}

	private static ValueTuple<object, string> FindPath(object target, string propertyName)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		object obj = null;
		string text = propertyName;
		if (target.HasProperty(propertyName))
		{
			obj = target.GetPlainPropertyValue(propertyName);
		}
		else if (target.HasProperty("$t"))
		{
			string text2 = string.Format("{0}${1}", target.get_Item("$t"), (object)propertyName);
			if (target.HasProperty(text2))
			{
				text = text2;
				obj = target.GetPlainPropertyValue(text2);
			}
			else
			{
				ReactiveProxy reactiveProxy = ObjectExtensions.As<ReactiveProxy>(target);
				ClassMetadata metadata = reactiveProxy.Metadata;
				text2 = $"{propertyName}${((IMetadata)metadata).get_Uid():n}";
				DataClassMetadata dataClassMetadata;
				if (target.HasProperty(text2))
				{
					text = text2;
					obj = target.GetPlainPropertyValue(text2);
				}
				else if ((dataClassMetadata = (DataClassMetadata)(object)((metadata is DataClassMetadata) ? metadata : null)) != null)
				{
					ValueTuple<string, object> val = FindPart(reactiveProxy, propertyName, dataClassMetadata);
					string item = val.Item1;
					object item2 = val.Item2;
					if (!string.IsNullOrWhiteSpace(item))
					{
						text = item;
						obj = item2;
					}
				}
			}
		}
		else
		{
			obj = target.GetPlainPropertyValue(propertyName);
		}
		return new ValueTuple<object, string>(obj, text);
	}

	private static ValueTuple<string, object> FindPart(ReactiveProxy proxy, string propertyName, DataClassMetadata dataClassMetadata)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		System.Collections.Generic.IEnumerator<DataClassDependency> enumerator = ((System.Collections.Generic.IEnumerable<DataClassDependency>)dataClassMetadata.get_IncludeList()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				DataClassDependency current = enumerator.get_Current();
				Guid headerUid = ((Dependency)current).get_HeaderUid();
				string text = $"{propertyName}${headerUid:n}";
				if (proxy.HasProperty(text))
				{
					return new ValueTuple<string, object>(text, proxy.GetPlainPropertyValue(text));
				}
				IMetadata metadata = proxy.metadataService.GetMetadata(((Dependency)current).get_HeaderUid());
				DataClassMetadata dataClassMetadata2;
				if ((dataClassMetadata2 = (DataClassMetadata)(object)((metadata is DataClassMetadata) ? metadata : null)) != null)
				{
					ValueTuple<string, object> result = FindPart(proxy, propertyName, dataClassMetadata2);
					if (!string.IsNullOrWhiteSpace(result.Item1))
					{
						return result;
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return new ValueTuple<string, object>((string)null, (object)null);
	}
}
