using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.TemplateGenerator.Adl.Tree;

namespace EleWise.TemplateGenerator.Expressions;

public class GeneratorExpressionEvaluator : IGeneratorExpressionEvaluator
{
	private readonly GenerationContext context;

	protected GenerationContext Context => context;

	public GeneratorExpressionEvaluator(GenerationContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		this.context = context;
	}

	public virtual FormatedValue Evaluate(Expression expression)
	{
		if (expression is Variable variable)
		{
			return EvaluateVariable(variable);
		}
		if (expression is Globalvariable variable2)
		{
			return EvaluateGlobalVariable(variable2);
		}
		if (expression is FunctionCall function)
		{
			return EvaluateFunction(function);
		}
		if (expression is Constant constant)
		{
			return EvaluateConstant(constant);
		}
		if (expression is BinaryExpression expression2)
		{
			return EvaluateBinaryExpression(expression2);
		}
		if (expression is UnaryExpression expression3)
		{
			return EvaluateUnaryExpression(expression3);
		}
		return null;
	}

	protected FormatedValue EvaluateVariable(Variable variable)
	{
		return context.DataSource.GetVariableValue(variable.Name);
	}

	protected FormatedValue EvaluateGlobalVariable(Globalvariable variable)
	{
		return context.GlobalDataSource.GetVariableValue(variable.Name);
	}

	protected FormatedValue EvaluateConstant(Constant constant)
	{
		return new FormatedValue
		{
			Value = constant.Value
		};
	}

	protected FormatedValue EvaluateFunction(FunctionCall function)
	{
		List<FormatedValue> parameters = function.Params.Select(Evaluate).ToList();
		return context.FunctionEvaluator.Evaluate(function.Name, parameters);
	}

	protected virtual FormatedValue EvaluateBinaryExpression(BinaryExpression expression)
	{
		FormatedValue fv = Evaluate(expression.Operand1);
		FormatedValue fv2 = Evaluate(expression.Operand2);
		return EvaluateBinaryExpression(fv, expression.Operator, fv2);
	}

	protected virtual FormatedValue EvaluateBinaryExpression(FormatedValue fv1, BinaryOperator op, FormatedValue fv2)
	{
		object obj = fv1?.Value;
		object obj2 = fv2?.Value;
		switch (op)
		{
		case BinaryOperator.Equal:
		{
			int? num = CompareValues(obj, obj2);
			return new FormatedValue(num.HasValue && num.Value == 0);
		}
		case BinaryOperator.NEqual:
		{
			int? num = CompareValues(obj, obj2);
			return new FormatedValue(!num.HasValue || num.Value != 0);
		}
		case BinaryOperator.GE:
		{
			int? num = CompareValues(obj, obj2);
			return new FormatedValue(num.HasValue && num.Value >= 0);
		}
		case BinaryOperator.GT:
		{
			int? num = CompareValues(obj, obj2);
			return new FormatedValue(num.HasValue && num.Value > 0);
		}
		case BinaryOperator.LE:
		{
			int? num = CompareValues(obj, obj2);
			return new FormatedValue(num.HasValue && num.Value <= 0);
		}
		case BinaryOperator.LT:
		{
			int? num = CompareValues(obj, obj2);
			return new FormatedValue(num.HasValue && num.Value < 0);
		}
		case BinaryOperator.Plus:
			return EvaluatePlusExpression(fv1, fv2);
		case BinaryOperator.Minus:
			return EvaluateMinusExpression(fv1, fv2);
		case BinaryOperator.Mult:
			return EvaluateMultExpression(fv1, fv2);
		case BinaryOperator.Division:
			return EvaluateDivisionExpression(fv1, fv2);
		case BinaryOperator.And:
			return new FormatedValue(obj is bool && obj2 is bool && (bool)obj && (bool)obj2);
		case BinaryOperator.Or:
			return new FormatedValue((obj is bool && (bool)obj) || (obj2 is bool && (bool)obj2));
		default:
			throw new Exception("Unknown operator: " + op);
		}
	}

	protected virtual FormatedValue EvaluatePlusExpression(FormatedValue fv1, FormatedValue fv2)
	{
		object obj = fv1?.Value;
		object obj2 = fv2?.Value;
		if (obj == null && obj2 == null)
		{
			return null;
		}
		if (obj == null)
		{
			return fv2;
		}
		if (obj2 == null)
		{
			return fv1;
		}
		if (obj is string && obj2 is string)
		{
			return new FormatedValue((string)fv1.Value + (string)fv2.Value);
		}
		if (obj is string)
		{
			return new FormatedValue((string)fv1.Value + context.FormatProvider.FormatValue(fv2));
		}
		if (obj2 is string)
		{
			return new FormatedValue(context.FormatProvider.FormatValue(fv1) + (string)fv2.Value);
		}
		if (IsInt(obj) && IsInt(obj2))
		{
			long num = Convert.ToInt64(obj);
			long num2 = Convert.ToInt64(obj2);
			return new FormatedValue(num + num2, fv1.Format ?? fv2.Format);
		}
		if (IsNumber(obj) && IsNumber(obj2))
		{
			double num3 = Convert.ToDouble(obj);
			double num4 = Convert.ToDouble(obj2);
			return new FormatedValue(format: (IsFloat(obj) && fv1.Format != null) ? fv1.Format : (IsFloat(obj2) ? fv2.Format : null), value: num3 + num4);
		}
		if (obj is DateTime && obj2 is TimeSpan)
		{
			DateTime obj3 = (DateTime)obj;
			TimeSpan timeSpan = (TimeSpan)obj2;
			return new FormatedValue(obj3 + timeSpan, fv1.Format);
		}
		if (obj is DateTime && IsNumber(obj2))
		{
			DateTime obj4 = (DateTime)obj;
			TimeSpan timeSpan2 = TimeSpan.FromDays(Convert.ToDouble(obj2));
			return new FormatedValue(obj4 + timeSpan2, fv1.Format);
		}
		if (obj is TimeSpan && obj2 is TimeSpan)
		{
			TimeSpan obj5 = (TimeSpan)obj;
			TimeSpan timeSpan3 = (TimeSpan)obj2;
			return new FormatedValue(obj5 + timeSpan3, fv1.Format ?? fv2.Format);
		}
		if (obj is TimeSpan && IsNumber(obj2))
		{
			TimeSpan obj6 = (TimeSpan)obj;
			TimeSpan timeSpan4 = TimeSpan.FromDays(Convert.ToDouble(obj2));
			return new FormatedValue(obj6 + timeSpan4, fv1.Format);
		}
		return new FormatedValue($"[Cannot plus operands of type {obj.GetType().FullName} and {obj2.GetType().FullName}]");
	}

	protected virtual FormatedValue EvaluateMinusExpression(FormatedValue fv1, FormatedValue fv2)
	{
		object obj = fv1?.Value;
		object obj2 = fv2?.Value;
		if (obj == null && obj2 == null)
		{
			return null;
		}
		if (obj2 == null)
		{
			return fv1;
		}
		if (obj == null)
		{
			return EvaluateUMinusExpression(fv2);
		}
		if (IsInt(obj) && IsInt(obj2))
		{
			long num = Convert.ToInt64(obj);
			long num2 = Convert.ToInt64(obj2);
			return new FormatedValue(num - num2, fv1.Format ?? fv2.Format);
		}
		if (IsNumber(obj) && IsNumber(obj2))
		{
			double num3 = Convert.ToDouble(obj);
			double num4 = Convert.ToDouble(obj2);
			return new FormatedValue(format: (IsFloat(obj) && fv1.Format != null) ? fv1.Format : (IsFloat(obj2) ? fv2.Format : null), value: num3 - num4);
		}
		if (obj is DateTime && obj2 is TimeSpan)
		{
			DateTime obj3 = (DateTime)obj;
			TimeSpan timeSpan = (TimeSpan)obj2;
			return new FormatedValue(obj3 - timeSpan, fv1.Format);
		}
		if (obj is DateTime && IsNumber(obj2))
		{
			DateTime obj4 = (DateTime)obj;
			TimeSpan timeSpan2 = TimeSpan.FromDays(Convert.ToDouble(obj2));
			return new FormatedValue(obj4 - timeSpan2, fv1.Format);
		}
		if (obj is TimeSpan && obj2 is TimeSpan)
		{
			TimeSpan obj5 = (TimeSpan)obj;
			TimeSpan timeSpan3 = (TimeSpan)obj2;
			return new FormatedValue(obj5 - timeSpan3, fv1.Format ?? fv2.Format);
		}
		if (obj is TimeSpan && IsNumber(obj2))
		{
			TimeSpan obj6 = (TimeSpan)obj;
			TimeSpan timeSpan4 = TimeSpan.FromDays(Convert.ToDouble(obj2));
			return new FormatedValue(obj6 - timeSpan4, fv1.Format);
		}
		return new FormatedValue($"[Cannot minus operands of type {obj.GetType().FullName} and {obj2.GetType().FullName}]");
	}

	protected virtual FormatedValue EvaluateMultExpression(FormatedValue fv1, FormatedValue fv2)
	{
		object obj = fv1?.Value;
		object obj2 = fv2?.Value;
		if (obj == null || obj2 == null)
		{
			return null;
		}
		if (IsInt(obj) && IsInt(obj2))
		{
			long num = Convert.ToInt64(obj);
			long num2 = Convert.ToInt64(obj2);
			return new FormatedValue(num * num2, fv1.Format ?? fv2.Format);
		}
		if (IsNumber(obj) && IsNumber(obj2))
		{
			double num3 = Convert.ToDouble(obj);
			double num4 = Convert.ToDouble(obj2);
			return new FormatedValue(format: (IsFloat(obj) && fv1.Format != null) ? fv1.Format : (IsFloat(obj2) ? fv2.Format : null), value: num3 * num4);
		}
		return new FormatedValue($"[Cannot multiply operands of type {obj.GetType().FullName} and {obj2.GetType().FullName}]");
	}

	protected virtual FormatedValue EvaluateDivisionExpression(FormatedValue fv1, FormatedValue fv2)
	{
		object obj = fv1?.Value;
		object obj2 = fv2?.Value;
		if (obj == null || obj2 == null)
		{
			return null;
		}
		if (IsNumber(obj) && IsNumber(obj2))
		{
			double num = Convert.ToDouble(obj);
			double num2 = Convert.ToDouble(obj2);
			return new FormatedValue(format: (IsFloat(obj) && fv1.Format != null) ? fv1.Format : (IsFloat(obj2) ? fv2.Format : null), value: num / num2);
		}
		return new FormatedValue($"[Cannot divide operands of type {obj.GetType().FullName} and {obj2.GetType().FullName}]");
	}

	protected virtual FormatedValue EvaluateUnaryExpression(UnaryExpression expression)
	{
		FormatedValue fv = Evaluate(expression.Operand);
		if (expression.Operator == UnaryOperator.Minus)
		{
			return EvaluateUMinusExpression(fv);
		}
		throw new Exception("Unknown operator: " + expression.Operator);
	}

	protected virtual FormatedValue EvaluateUMinusExpression(FormatedValue fv)
	{
		object obj = fv?.Value;
		if (obj == null)
		{
			return null;
		}
		if (IsInt(obj))
		{
			return new FormatedValue(-Convert.ToInt64(obj));
		}
		if (IsFloat(obj))
		{
			return new FormatedValue(0.0 - Convert.ToDouble(obj));
		}
		if (obj is TimeSpan)
		{
			return new FormatedValue(-(TimeSpan)obj);
		}
		return fv;
	}

	protected virtual int? CompareValues(object v1, object v2)
	{
		if (v1 == null && v2 == null)
		{
			return 0;
		}
		if (v1 == null)
		{
			return -1;
		}
		if (v2 == null)
		{
			return 1;
		}
		if (IsNumber(v1) && IsNumber(v2))
		{
			double num = Convert.ToDouble(v1);
			double value = Convert.ToDouble(v2);
			return num.CompareTo(value);
		}
		if (v1 is DateTime && v2 is DateTime)
		{
			DateTime dateTime = Convert.ToDateTime(v1);
			DateTime value2 = Convert.ToDateTime(v2);
			return dateTime.CompareTo(value2);
		}
		if (v1 is TimeSpan && v2 is TimeSpan)
		{
			TimeSpan timeSpan = (TimeSpan)v1;
			TimeSpan value3 = (TimeSpan)v2;
			return timeSpan.CompareTo(value3);
		}
		string strA = v1.ToString();
		string strB = v2.ToString();
		return string.Compare(strA, strB, StringComparison.Ordinal);
	}

	private bool IsNumber(object v)
	{
		if (!IsInt(v))
		{
			return IsFloat(v);
		}
		return true;
	}

	private bool IsInt(object v)
	{
		if (!(v is byte) && !(v is short) && !(v is int))
		{
			return v is long;
		}
		return true;
	}

	private bool IsFloat(object v)
	{
		if (!(v is float) && !(v is decimal))
		{
			return v is double;
		}
		return true;
	}
}
