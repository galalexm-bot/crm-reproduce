using System;
using System.Collections.Generic;
using Nemerle.Builtins;
using Nemerle.Core;
using Nemerle.Internal;
using Nemerle.Peg;

namespace EleWise.ELMA.NemerleParser;

public class EQLParser
{
	private int __GENERATED_PEG__Memeoize_Pos__detachedExpression__ = -1;

	private int __GENERATED_PEG__Memeoize_End__detachedExpression__ = -1;

	private Expression __GENERATED_PEG__Memeoize_Res__detachedExpression__;

	private int __GENERATED_PEG__MaxRollback___detachedExpression__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__expression__ = -1;

	private int __GENERATED_PEG__Memeoize_End__expression__ = -1;

	private Expression __GENERATED_PEG__Memeoize_Res__expression__;

	private int __GENERATED_PEG__MaxRollback___expression__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__expression_or__ = -1;

	private int __GENERATED_PEG__Memeoize_End__expression_or__ = -1;

	private Expression __GENERATED_PEG__Memeoize_Res__expression_or__;

	private int __GENERATED_PEG__MaxRollback___expression_or__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__expression_and__ = -1;

	private int __GENERATED_PEG__Memeoize_End__expression_and__ = -1;

	private Expression __GENERATED_PEG__Memeoize_Res__expression_and__;

	private int __GENERATED_PEG__MaxRollback___expression_and__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__expression_comp__ = -1;

	private int __GENERATED_PEG__Memeoize_End__expression_comp__ = -1;

	private Expression __GENERATED_PEG__Memeoize_Res__expression_comp__;

	private int __GENERATED_PEG__MaxRollback___expression_comp__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__expression_property_in_parameter__ = -1;

	private int __GENERATED_PEG__Memeoize_End__expression_property_in_parameter__ = -1;

	private Expression __GENERATED_PEG__Memeoize_Res__expression_property_in_parameter__;

	private int __GENERATED_PEG__MaxRollback___expression_property_in_parameter__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__parameter__ = -1;

	private int __GENERATED_PEG__Memeoize_End__parameter__ = -1;

	private Constant __GENERATED_PEG__Memeoize_Res__parameter__;

	private int __GENERATED_PEG__MaxRollback___parameter__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__query_parameter__ = -1;

	private int __GENERATED_PEG__Memeoize_End__query_parameter__ = -1;

	private Parameter __GENERATED_PEG__Memeoize_Res__query_parameter__;

	private int __GENERATED_PEG__MaxRollback___query_parameter__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__parameter_name__ = -1;

	private int __GENERATED_PEG__Memeoize_End__parameter_name__ = -1;

	private Identifier __GENERATED_PEG__Memeoize_Res__parameter_name__;

	private int __GENERATED_PEG__MaxRollback___parameter_name__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__sparen_parameter_name__ = -1;

	private int __GENERATED_PEG__Memeoize_End__sparen_parameter_name__ = -1;

	private Identifier __GENERATED_PEG__Memeoize_Res__sparen_parameter_name__;

	private int __GENERATED_PEG__MaxRollback___sparen_parameter_name__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__simple_identifier__ = -1;

	private int __GENERATED_PEG__Memeoize_End__simple_identifier__ = -1;

	private Identifier __GENERATED_PEG__Memeoize_Res__simple_identifier__;

	private int __GENERATED_PEG__MaxRollback___simple_identifier__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__property__ = -1;

	private int __GENERATED_PEG__Memeoize_End__property__ = -1;

	private Property __GENERATED_PEG__Memeoize_Res__property__;

	private int __GENERATED_PEG__MaxRollback___property__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__property_parent__ = -1;

	private int __GENERATED_PEG__Memeoize_End__property_parent__ = -1;

	private Property __GENERATED_PEG__Memeoize_Res__property_parent__;

	private int __GENERATED_PEG__MaxRollback___property_parent__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__identifier__ = -1;

	private int __GENERATED_PEG__Memeoize_End__identifier__ = -1;

	private Identifier __GENERATED_PEG__Memeoize_Res__identifier__;

	private int __GENERATED_PEG__MaxRollback___identifier__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__property_root__ = -1;

	private int __GENERATED_PEG__Memeoize_End__property_root__ = -1;

	private Property __GENERATED_PEG__Memeoize_Res__property_root__;

	private int __GENERATED_PEG__MaxRollback___property_root__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__not_expression__ = -1;

	private int __GENERATED_PEG__Memeoize_End__not_expression__ = -1;

	private Expression __GENERATED_PEG__Memeoize_Res__not_expression__;

	private int __GENERATED_PEG__MaxRollback___not_expression__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__expression_inbrackets__ = -1;

	private int __GENERATED_PEG__Memeoize_End__expression_inbrackets__ = -1;

	private Expression __GENERATED_PEG__Memeoize_Res__expression_inbrackets__;

	private int __GENERATED_PEG__MaxRollback___expression_inbrackets__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__expression_property_in_query_expression__ = -1;

	private int __GENERATED_PEG__Memeoize_End__expression_property_in_query_expression__ = -1;

	private Expression __GENERATED_PEG__Memeoize_Res__expression_property_in_query_expression__;

	private int __GENERATED_PEG__MaxRollback___expression_property_in_query_expression__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__query_expression__ = -1;

	private int __GENERATED_PEG__Memeoize_End__query_expression__ = -1;

	private SubqueryExpression __GENERATED_PEG__Memeoize_Res__query_expression__;

	private int __GENERATED_PEG__MaxRollback___query_expression__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__query_exp_from_second__ = -1;

	private int __GENERATED_PEG__Memeoize_End__query_exp_from_second__ = -1;

	private SubqueryExpression __GENERATED_PEG__Memeoize_Res__query_exp_from_second__;

	private int __GENERATED_PEG__MaxRollback___query_exp_from_second__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__query_exp_from_first__ = -1;

	private int __GENERATED_PEG__Memeoize_End__query_exp_from_first__ = -1;

	private SubqueryExpression __GENERATED_PEG__Memeoize_Res__query_exp_from_first__;

	private int __GENERATED_PEG__MaxRollback___query_exp_from_first__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__expression_property_in_function__ = -1;

	private int __GENERATED_PEG__Memeoize_End__expression_property_in_function__ = -1;

	private Expression __GENERATED_PEG__Memeoize_Res__expression_property_in_function__;

	private int __GENERATED_PEG__MaxRollback___expression_property_in_function__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__inFunction__ = -1;

	private int __GENERATED_PEG__Memeoize_End__inFunction__ = -1;

	private InFunction __GENERATED_PEG__Memeoize_Res__inFunction__;

	private int __GENERATED_PEG__MaxRollback___inFunction__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__in_func_2__ = -1;

	private int __GENERATED_PEG__Memeoize_End__in_func_2__ = -1;

	private InFunction __GENERATED_PEG__Memeoize_Res__in_func_2__;

	private int __GENERATED_PEG__MaxRollback___in_func_2__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__atom_collection__ = -1;

	private int __GENERATED_PEG__Memeoize_End__atom_collection__ = -1;

	private ExpressionCollection __GENERATED_PEG__Memeoize_Res__atom_collection__;

	private int __GENERATED_PEG__MaxRollback___atom_collection__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__constant__ = -1;

	private int __GENERATED_PEG__Memeoize_End__constant__ = -1;

	private Expression __GENERATED_PEG__Memeoize_Res__constant__;

	private int __GENERATED_PEG__MaxRollback___constant__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__const_empty__ = -1;

	private int __GENERATED_PEG__Memeoize_End__const_empty__ = -1;

	private Constant __GENERATED_PEG__Memeoize_Res__const_empty__;

	private int __GENERATED_PEG__MaxRollback___const_empty__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__const_null__ = -1;

	private int __GENERATED_PEG__Memeoize_End__const_null__ = -1;

	private Constant __GENERATED_PEG__Memeoize_Res__const_null__;

	private int __GENERATED_PEG__MaxRollback___const_null__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__function_const__ = -1;

	private int __GENERATED_PEG__Memeoize_End__function_const__ = -1;

	private Constant __GENERATED_PEG__Memeoize_Res__function_const__;

	private int __GENERATED_PEG__MaxRollback___function_const__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__constant_function__ = -1;

	private int __GENERATED_PEG__Memeoize_End__constant_function__ = -1;

	private ConstantFunction __GENERATED_PEG__Memeoize_Res__constant_function__;

	private int __GENERATED_PEG__MaxRollback___constant_function__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__const_func_2__ = -1;

	private int __GENERATED_PEG__Memeoize_End__const_func_2__ = -1;

	private ConstantFunction __GENERATED_PEG__Memeoize_Res__const_func_2__;

	private int __GENERATED_PEG__MaxRollback___const_func_2__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__const_func_1__ = -1;

	private int __GENERATED_PEG__Memeoize_End__const_func_1__ = -1;

	private ConstantFunction __GENERATED_PEG__Memeoize_Res__const_func_1__;

	private int __GENERATED_PEG__MaxRollback___const_func_1__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__const_false__ = -1;

	private int __GENERATED_PEG__Memeoize_End__const_false__ = -1;

	private Constant __GENERATED_PEG__Memeoize_Res__const_false__;

	private int __GENERATED_PEG__MaxRollback___const_false__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__const_true__ = -1;

	private int __GENERATED_PEG__Memeoize_End__const_true__ = -1;

	private Constant __GENERATED_PEG__Memeoize_Res__const_true__;

	private int __GENERATED_PEG__MaxRollback___const_true__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__character_string__ = -1;

	private int __GENERATED_PEG__Memeoize_End__character_string__ = -1;

	private Constant __GENERATED_PEG__Memeoize_Res__character_string__;

	private int __GENERATED_PEG__MaxRollback___character_string__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__number__ = -1;

	private int __GENERATED_PEG__Memeoize_End__number__ = -1;

	private Constant __GENERATED_PEG__Memeoize_Res__number__;

	private int __GENERATED_PEG__MaxRollback___number__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__integerLiteral__ = -1;

	private int __GENERATED_PEG__Memeoize_End__integerLiteral__ = -1;

	private Literal __GENERATED_PEG__Memeoize_Res__integerLiteral__;

	private int __GENERATED_PEG__MaxRollback___integerLiteral__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__realLiteral__ = -1;

	private int __GENERATED_PEG__Memeoize_End__realLiteral__ = -1;

	private Literal __GENERATED_PEG__Memeoize_Res__realLiteral__;

	private int __GENERATED_PEG__MaxRollback___realLiteral__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__in_func_1__ = -1;

	private int __GENERATED_PEG__Memeoize_End__in_func_1__ = -1;

	private InFunction __GENERATED_PEG__Memeoize_Res__in_func_1__;

	private int __GENERATED_PEG__MaxRollback___in_func_1__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__expression_property_in_comma_expression__ = -1;

	private int __GENERATED_PEG__Memeoize_End__expression_property_in_comma_expression__ = -1;

	private Expression __GENERATED_PEG__Memeoize_Res__expression_property_in_comma_expression__;

	private int __GENERATED_PEG__MaxRollback___expression_property_in_comma_expression__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__comma_expression__ = -1;

	private int __GENERATED_PEG__Memeoize_End__comma_expression__ = -1;

	private InExpression __GENERATED_PEG__Memeoize_Res__comma_expression__;

	private int __GENERATED_PEG__MaxRollback___comma_expression__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__expression_property_in_atom_collection__ = -1;

	private int __GENERATED_PEG__Memeoize_End__expression_property_in_atom_collection__ = -1;

	private Expression __GENERATED_PEG__Memeoize_Res__expression_property_in_atom_collection__;

	private int __GENERATED_PEG__MaxRollback___expression_property_in_atom_collection__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__expression_function_atom__ = -1;

	private int __GENERATED_PEG__Memeoize_End__expression_function_atom__ = -1;

	private Expression __GENERATED_PEG__Memeoize_Res__expression_function_atom__;

	private int __GENERATED_PEG__MaxRollback___expression_function_atom__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__atom__ = -1;

	private int __GENERATED_PEG__Memeoize_End__atom__ = -1;

	private Expression __GENERATED_PEG__Memeoize_Res__atom__;

	private int __GENERATED_PEG__MaxRollback___atom__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__property_exp__ = -1;

	private int __GENERATED_PEG__Memeoize_End__property_exp__ = -1;

	private Expression __GENERATED_PEG__Memeoize_Res__property_exp__;

	private int __GENERATED_PEG__MaxRollback___property_exp__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__operator_comp__ = -1;

	private int __GENERATED_PEG__Memeoize_End__operator_comp__ = -1;

	private BinaryOperator __GENERATED_PEG__Memeoize_Res__operator_comp__;

	private int __GENERATED_PEG__MaxRollback___operator_comp__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__function_expression__ = -1;

	private int __GENERATED_PEG__Memeoize_End__function_expression__ = -1;

	private Expression __GENERATED_PEG__Memeoize_Res__function_expression__;

	private int __GENERATED_PEG__MaxRollback___function_expression__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__count_expression__ = -1;

	private int __GENERATED_PEG__Memeoize_End__count_expression__ = -1;

	private AggregateSubqueryExpression __GENERATED_PEG__Memeoize_Res__count_expression__;

	private int __GENERATED_PEG__MaxRollback___count_expression__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__agg_count_query__ = -1;

	private int __GENERATED_PEG__Memeoize_End__agg_count_query__ = -1;

	private AggregateSubqueryExpression __GENERATED_PEG__Memeoize_Res__agg_count_query__;

	private int __GENERATED_PEG__MaxRollback___agg_count_query__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__agg_count_const_func__ = -1;

	private int __GENERATED_PEG__Memeoize_End__agg_count_const_func__ = -1;

	private AggregateSubqueryExpression __GENERATED_PEG__Memeoize_Res__agg_count_const_func__;

	private int __GENERATED_PEG__MaxRollback___agg_count_const_func__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__agg_count_property__ = -1;

	private int __GENERATED_PEG__Memeoize_End__agg_count_property__ = -1;

	private AggregateSubqueryExpression __GENERATED_PEG__Memeoize_Res__agg_count_property__;

	private int __GENERATED_PEG__MaxRollback___agg_count_property__ = -1;

	private int __GENERATED_PEG__Memeoize_Pos__expression_property_atom__ = -1;

	private int __GENERATED_PEG__Memeoize_End__expression_property_atom__ = -1;

	private Expression __GENERATED_PEG__Memeoize_Res__expression_property_atom__;

	private int __GENERATED_PEG__MaxRollback___expression_property_atom__ = -1;

	private SourceSnapshot _parsingSource;

	public SourceSnapshot ParsingSource => _parsingSource;

	private Expression detachedExpression(Expression exp)
	{
		return exp;
	}

	private Expression expression_or(Expression exp1, List<Expression> exp2)
	{
		return (exp2.Count <= 0) ? exp1 : getExp(exp1, BinaryOperator.Or, exp2);
	}

	private Expression expression_and(Expression exp1, List<Expression> exp2)
	{
		return (exp2.Count <= 0) ? exp1 : getExp(exp1, BinaryOperator.And, exp2);
	}

	private Expression expression_comp(Expression exp)
	{
		return exp;
	}

	private Expression expression_property_atom(Property prop, BinaryOperator op, Expression atom)
	{
		BinaryExpression binaryExpression = new BinaryExpression();
		binaryExpression.Operand1 = prop;
		binaryExpression.Operator = op;
		binaryExpression.Operand2 = atom;
		return binaryExpression;
	}

	private Expression expression_function_atom(Expression func, BinaryOperator op, Expression atom)
	{
		BinaryExpression binaryExpression = new BinaryExpression();
		binaryExpression.Operand1 = func;
		binaryExpression.Operator = op;
		binaryExpression.Operand2 = atom;
		return binaryExpression;
	}

	private Expression expression_property_in_atom_collection(Property prop, ExpressionCollection exp)
	{
		BinaryExpression binaryExpression = new BinaryExpression();
		binaryExpression.Operand1 = prop;
		binaryExpression.Operator = BinaryOperator.IN;
		binaryExpression.Operand2 = exp;
		return binaryExpression;
	}

	private Expression expression_property_in_comma_expression(Property prop, InExpression exp)
	{
		BinaryExpression binaryExpression = new BinaryExpression();
		binaryExpression.Operand1 = prop;
		binaryExpression.Operator = BinaryOperator.IN;
		binaryExpression.Operand2 = exp;
		return binaryExpression;
	}

	private Expression expression_property_in_function(Property prop, InFunction exp)
	{
		BinaryExpression binaryExpression = new BinaryExpression();
		binaryExpression.Operand1 = prop;
		binaryExpression.Operator = BinaryOperator.IN;
		binaryExpression.Operand2 = exp;
		return binaryExpression;
	}

	private Expression expression_property_in_query_expression(Property prop, SubqueryExpression exp)
	{
		BinaryExpression binaryExpression = new BinaryExpression();
		binaryExpression.Operand1 = prop;
		binaryExpression.Operator = BinaryOperator.IN;
		binaryExpression.Operand2 = exp;
		binaryExpression.Stop = checked(exp.Stop - 1);
		return binaryExpression;
	}

	private Expression expression_inbrackets(NToken _N_wildcard_4007, Expression exp, NToken _N_wildcard_4008)
	{
		return exp;
	}

	private Expression not_expression(Expression exp)
	{
		NotExpression notExpression = new NotExpression();
		notExpression.Expression = exp;
		return notExpression;
	}

	private Expression expression_property_in_parameter(Property prop, Constant param)
	{
		BinaryExpression binaryExpression = new BinaryExpression();
		binaryExpression.Operand1 = prop;
		binaryExpression.Operator = BinaryOperator.IN;
		binaryExpression.Operand2 = param;
		return binaryExpression;
	}

	private BinaryOperator operator_comp(NToken op)
	{
		return GetText(op).ToLower() switch
		{
			"=" => BinaryOperator.Equal, 
			"<>" => BinaryOperator.NEqual, 
			">=" => BinaryOperator.GE, 
			">" => BinaryOperator.GT, 
			"<=" => BinaryOperator.LE, 
			"<" => BinaryOperator.LT, 
			"is" => BinaryOperator.IS, 
			"like" => BinaryOperator.LIKE, 
			_ => throw new ArgumentOutOfRangeException("operator"), 
		};
	}

	private ExpressionCollection atom_collection(NToken l, Expression const1, List<Expression> const2, NToken r)
	{
		ExpressionCollection expressionCollection = new ExpressionCollection();
		expressionCollection.Start = l.StartPos;
		expressionCollection.Stop = checked(r.EndPos - 1);
		expressionCollection.Add(const1);
		foreach (Expression item in const2)
		{
			Expression expression = item;
			expressionCollection.Add(expression);
		}
		return expressionCollection;
	}

	private InExpression comma_expression(NToken l, Expression exp, NToken r)
	{
		InExpression inExpression = new InExpression();
		inExpression.Start = l.StartPos;
		inExpression.Stop = checked(r.EndPos - 1);
		inExpression.Expression = exp;
		return inExpression;
	}

	private Expression property_exp(Property exp)
	{
		return exp;
	}

	private Property property_parent(List<NToken> list, Identifier id)
	{
		Property property = new Property();
		property.Name = id.Value;
		property.ParentProperty = list.Count;
		if (list.Count > 0)
		{
			property.Start = list[0].StartPos;
		}
		else
		{
			property.Start = id.StartPos;
		}
		property.Stop = checked(id.EndPos - 1);
		return property;
	}

	private Property property_root(NToken r, Identifier s)
	{
		Property property = new Property();
		property.Name = s.Value;
		property.RootProperty = true;
		property.Start = r.StartPos;
		property.Stop = s.EndPos;
		return property;
	}

	private Expression constant(Constant @const)
	{
		return @const;
	}

	private Expression function_expression(AggregateSubqueryExpression agg)
	{
		return agg;
	}

	private AggregateSubqueryExpression agg_count_property(NToken count, NToken _N_wildcard_4009, Property prop, NToken r)
	{
		AggregateSubqueryExpression aggregateSubqueryExpression = new AggregateSubqueryExpression();
		aggregateSubqueryExpression.Short = true;
		aggregateSubqueryExpression.Function = new AggregateFunction();
		aggregateSubqueryExpression.Function.Name = "COUNT";
		aggregateSubqueryExpression.Function.Start = count.StartPos;
		checked
		{
			aggregateSubqueryExpression.Function.Stop = count.EndPos - 1;
			aggregateSubqueryExpression.Name = prop.Name;
			aggregateSubqueryExpression.Expression = prop;
			aggregateSubqueryExpression.Start = count.StartPos;
			aggregateSubqueryExpression.Stop = r.EndPos - 1;
			return aggregateSubqueryExpression;
		}
	}

	private AggregateSubqueryExpression agg_count_const_func(NToken count, NToken _N_wildcard_4010, ConstantFunction @const, NToken r)
	{
		AggregateSubqueryExpression aggregateSubqueryExpression = new AggregateSubqueryExpression();
		aggregateSubqueryExpression.Short = true;
		aggregateSubqueryExpression.Function = new AggregateFunction();
		aggregateSubqueryExpression.Function.Name = "COUNT";
		aggregateSubqueryExpression.Function.Start = count.StartPos;
		checked
		{
			aggregateSubqueryExpression.Function.Stop = count.EndPos - 1;
			aggregateSubqueryExpression.Name = @const.Name;
			aggregateSubqueryExpression.Expression = @const;
			aggregateSubqueryExpression.Start = count.StartPos;
			aggregateSubqueryExpression.Stop = r.EndPos - 1;
			return aggregateSubqueryExpression;
		}
	}

	private AggregateSubqueryExpression agg_count_query(NToken count, NToken _N_wildcard_4011, Identifier id, Expression exp, NToken _N_wildcard_4012)
	{
		AggregateSubqueryExpression aggregateSubqueryExpression = new AggregateSubqueryExpression();
		aggregateSubqueryExpression.Function = new AggregateFunction();
		aggregateSubqueryExpression.Function.Name = "COUNT";
		aggregateSubqueryExpression.Function.Start = count.StartPos;
		checked
		{
			aggregateSubqueryExpression.Function.Stop = count.EndPos - 1;
			aggregateSubqueryExpression.Name = "COUNT";
			aggregateSubqueryExpression.FromEntity = id.Value;
			aggregateSubqueryExpression.FromEntityStart = id.StartPos;
			aggregateSubqueryExpression.FromEntityStop = id.EndPos - 1;
			aggregateSubqueryExpression.Expression = exp;
			aggregateSubqueryExpression.Start = count.StartPos;
			aggregateSubqueryExpression.Stop = exp.Stop - 1;
			return aggregateSubqueryExpression;
		}
	}

	private SubqueryExpression query_expression(NToken _N_wildcard_4013, SubqueryExpression exp, NToken r)
	{
		exp.Stop = checked(r.EndPos - 1);
		return exp;
	}

	private SubqueryExpression query_exp_from_first(Identifier fromEntity, Identifier selectProperty, Expression exp)
	{
		SubqueryExpression subqueryExpression = new SubqueryExpression();
		subqueryExpression.SelectProperty = selectProperty.Value;
		subqueryExpression.FromEntity = fromEntity.Value;
		subqueryExpression.Expression = exp;
		subqueryExpression.Start = fromEntity.StartPos;
		checked
		{
			subqueryExpression.Stop = exp.Stop - 1;
			subqueryExpression.SelectPropertyStart = selectProperty.StartPos;
			subqueryExpression.SelectPropertyStop = selectProperty.EndPos - 1;
			subqueryExpression.FromEntityStart = fromEntity.StartPos;
			subqueryExpression.FromEntityStop = fromEntity.EndPos - 1;
			return subqueryExpression;
		}
	}

	private SubqueryExpression query_exp_from_second(Identifier selectProperty, Identifier fromEntity, Expression exp)
	{
		SubqueryExpression subqueryExpression = new SubqueryExpression();
		subqueryExpression.SelectProperty = selectProperty.Value;
		subqueryExpression.FromEntity = fromEntity.Value;
		subqueryExpression.Expression = exp;
		subqueryExpression.Start = selectProperty.StartPos;
		checked
		{
			subqueryExpression.Stop = exp.Stop - 1;
			subqueryExpression.SelectPropertyStart = selectProperty.StartPos;
			subqueryExpression.SelectPropertyStop = selectProperty.EndPos - 1;
			subqueryExpression.FromEntityStart = fromEntity.StartPos;
			subqueryExpression.FromEntityStop = fromEntity.EndPos - 1;
			return subqueryExpression;
		}
	}

	private Constant function_const(ConstantFunction c)
	{
		return c;
	}

	private Constant number(NToken m, Literal d1)
	{
		string text = null;
		text = null;
		text = ((!m.IsEmpty) ? ("-" + d1.ToString()) : d1.ToString());
		Constant constant = Constant.ParseNumberConstant(text);
		constant.Start = d1.StartPos;
		constant.Stop = checked(d1.EndPos - 1);
		return constant;
	}

	private Constant character_string(NToken val)
	{
		Constant constant = Constant.ParseStringConstant(GetText(val));
		constant.Start = val.StartPos;
		constant.Stop = checked(val.EndPos - 1);
		return constant;
	}

	private Constant parameter(Parameter p)
	{
		return p;
	}

	private Constant const_true(NToken bt)
	{
		Constant constant = new Constant();
		constant.Value = true;
		constant.Start = bt.StartPos;
		constant.Stop = checked(bt.EndPos - 1);
		return constant;
	}

	private Constant const_false(NToken bf)
	{
		Constant constant = new Constant();
		constant.Value = false;
		constant.Start = bf.StartPos;
		constant.Stop = checked(bf.EndPos - 1);
		return constant;
	}

	private Constant const_null(NToken nl)
	{
		Constant constant = new Constant();
		constant.Value = null;
		constant.Start = nl.StartPos;
		constant.Stop = checked(nl.EndPos - 1);
		return constant;
	}

	private Constant const_empty(NToken nl)
	{
		Constant constant = new Constant();
		constant.Value = null;
		constant.Start = nl.StartPos;
		constant.Stop = checked(nl.EndPos - 1);
		return constant;
	}

	private Parameter query_parameter(NToken _N_wildcard_4014, Identifier val)
	{
		Parameter parameter = new Parameter();
		parameter.Value = val.Value;
		parameter.Name = "@" + val.Value;
		parameter.Start = val.StartPos;
		parameter.Stop = checked(val.EndPos - 1);
		return parameter;
	}

	private Identifier sparen_parameter_name(NToken s)
	{
		Identifier identifier = new Identifier();
		identifier.Value = GetText(s).Replace("[[", "[").Replace("]]", "]");
		return identifier;
	}

	private Literal integerLiteral(NToken decimalDigits)
	{
		ulong result = 0uL;
		return (!ulong.TryParse(GetText(decimalDigits), out result)) ? ((Literal)new Literal.ErrorOverflow(GetText(decimalDigits))) : ((Literal)new Literal.Integer(result, is_hexadecimal: false, ""));
	}

	private Literal realLiteral(NToken mantissa1, NToken mantissa2)
	{
		string mantissa3 = string.Concat(GetText(mantissa1) + ".", GetText(mantissa2));
		return new Literal.Real(mantissa3, "", "");
	}

	private ConstantFunction const_func_1(Identifier id, NToken l, NToken r)
	{
		ConstantFunction constantFunction = new ConstantFunction();
		constantFunction.Name = id.Value;
		constantFunction.Parameters = new ExpressionCollection();
		constantFunction.Parameters.Start = l.StartPos;
		constantFunction.Parameters.Stop = checked(r.EndPos - 1);
		constantFunction.Start = id.StartPos;
		return constantFunction;
	}

	private ConstantFunction const_func_2(Identifier id, ExpressionCollection atom)
	{
		ConstantFunction constantFunction = new ConstantFunction();
		constantFunction.Name = id.Value;
		constantFunction.Parameters = atom;
		constantFunction.Start = id.StartPos;
		return constantFunction;
	}

	private InFunction in_func_1(Identifier id, NToken l, NToken r)
	{
		InFunction inFunction = new InFunction();
		inFunction.Name = id.Value;
		inFunction.Parameters = new ExpressionCollection();
		inFunction.Parameters.Start = l.StartPos;
		inFunction.Parameters.Stop = checked(r.EndPos - 1);
		inFunction.Start = id.StartPos;
		return inFunction;
	}

	private InFunction in_func_2(Identifier id, ExpressionCollection atom)
	{
		InFunction inFunction = new InFunction();
		inFunction.Name = id.Value;
		inFunction.Parameters = atom;
		inFunction.Start = id.StartPos;
		return inFunction;
	}

	private Identifier simple_identifier(NToken s1, NToken s2)
	{
		Identifier identifier = new Identifier();
		identifier.Value = GetText(s1) + GetText(s2);
		return identifier;
	}

	private Expression getExp(Expression exp1, BinaryOperator @operator, List<Expression> exp2)
	{
		BinaryExpression binaryExpression = new BinaryExpression();
		binaryExpression.Operator = @operator;
		checked
		{
			BinaryExpression result;
			if (exp2.Count > 1)
			{
				binaryExpression.Operand2 = exp2[exp2.Count - 1];
				exp2.RemoveAt(exp2.Count - 1);
				binaryExpression.Operand1 = getExp(exp1, @operator, exp2);
				result = binaryExpression;
			}
			else
			{
				binaryExpression.Operand1 = exp1;
				binaryExpression.Operand2 = exp2[0];
				result = binaryExpression;
			}
			return result;
		}
	}

	private int __GENERATED_PEG__RULE__detachedExpression__(int pos, string text, ref Expression result)
	{
		char c = '\0';
		Expression result2 = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__detachedExpression__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__detachedExpression__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__detachedExpression__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__detachedExpression__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__s__(pos, text);
			int num6;
			if (num >= 0)
			{
				int num2 = __GENERATED_PEG__RULE__expression__(num, text, ref result2);
				if (num2 >= 0)
				{
					int num3 = -1;
					int num4 = num2;
					if (num4 < text.Length)
					{
						c = text[num4];
						num4++;
						if (0 == 0)
						{
							num3 = num4;
						}
					}
					int num5 = num3;
					num6 = ((num5 >= 0) ? (-1) : num2);
				}
				else
				{
					num6 = -1;
				}
			}
			else
			{
				num6 = -1;
			}
			int num7 = num6;
			__GENERATED_PEG__Memeoize_Pos__detachedExpression__ = pos;
			__GENERATED_PEG__Memeoize_End__detachedExpression__ = num7;
			if (num7 >= 0)
			{
				result = detachedExpression(result2);
				__GENERATED_PEG__Memeoize_Res__detachedExpression__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___detachedExpression__ < pos)
			{
				__GENERATED_PEG__MaxRollback___detachedExpression__ = pos;
			}
			result3 = num7;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__expression__(int pos, string text, ref Expression result)
	{
		char c = '\0';
		Expression result2 = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__expression__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__expression__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__expression__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__expression__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__expression_or__(pos, text, ref result2);
			__GENERATED_PEG__Memeoize_Pos__expression__ = pos;
			__GENERATED_PEG__Memeoize_End__expression__ = num;
			if (num >= 0)
			{
				result = result2;
				__GENERATED_PEG__Memeoize_Res__expression__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___expression__ < pos)
			{
				__GENERATED_PEG__MaxRollback___expression__ = pos;
			}
			result3 = num;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__expression_or__(int pos, string text, ref Expression result)
	{
		char c = '\0';
		Expression result2 = null;
		List<Expression> list = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__expression_or__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__expression_or__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__expression_or__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__expression_or__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__expression_and__(pos, text, ref result2);
			int num7;
			if (num >= 0)
			{
				list = new List<Expression>();
				Expression result4 = null;
				int num2 = num;
				while (true)
				{
					int num3 = __GENERATED_PEG__RULE__OR__(num2, text);
					int num5;
					if (num3 >= 0)
					{
						int num4 = __GENERATED_PEG__RULE__S__(num3, text);
						num5 = ((num4 < 0) ? (-1) : __GENERATED_PEG__RULE__expression_and__(num4, text, ref result4));
					}
					else
					{
						num5 = -1;
					}
					int num6 = num5;
					if (num6 < 0)
					{
						break;
					}
					list.Add(result4);
					num2 = num6;
				}
				num7 = num2;
			}
			else
			{
				num7 = -1;
			}
			int num8 = num7;
			__GENERATED_PEG__Memeoize_Pos__expression_or__ = pos;
			__GENERATED_PEG__Memeoize_End__expression_or__ = num8;
			if (num8 >= 0)
			{
				result = expression_or(result2, list);
				__GENERATED_PEG__Memeoize_Res__expression_or__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___expression_or__ < pos)
			{
				__GENERATED_PEG__MaxRollback___expression_or__ = pos;
			}
			result3 = num8;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__S__(int pos, string text)
	{
		char c = '\0';
		c = '\0';
		int num = __GENERATED_PEG__RULE__identifierPartCharacters__(pos, text);
		num = ((num >= 0) ? (-1) : pos);
		return (num < 0) ? (-1) : __GENERATED_PEG__RULE__s__(num, text);
	}

	private int __GENERATED_PEG__RULE__identifierPartCharacters__(int pos, string text)
	{
		char c = '\0';
		int num = 0;
		int num2 = 0;
		c = '\0';
		num2 = -1;
		num = pos;
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c >= '0' && ((c >= 'ቚ') ? ((c >= 'Ⱡ') ? ((c >= 'ꧏ') ? ((c >= 'שׁ') ? ((c >= 'ﹰ') ? ((c >= 'ｦ') ? ((c >= 'ￒ') ? ((c >= '\ufff9') ? (c <= '\ufffb') : ((c < 'ￚ') ? (c <= 'ￗ') : (c <= 'ￜ'))) : ((c >= 'ￊ') ? (c <= 'ￏ') : ((c < 'ￂ') ? (c <= 'ﾾ') : (c <= 'ￇ')))) : ((c >= 'Ａ') ? ((c >= 'ａ') ? (c <= 'ｚ') : ((c < '\uff3f') ? (c <= 'Ｚ') : (c <= '\uff3f'))) : ((c >= '\ufeff') ? ((c < '０') ? (c <= '\ufeff') : (c <= '９')) : ((c < 'ﹶ') ? (c <= 'ﹴ') : (c <= 'ﻼ'))))) : ((c >= 'ﵐ') ? ((c >= '\ufe20') ? ((c >= '\ufe4d') ? (c <= '\ufe4f') : ((c < '\ufe33') ? (c <= '\ufe2f') : (c <= '\ufe34'))) : ((c >= 'ﷰ') ? ((c < '\ufe00') ? (c <= 'ﷻ') : (c <= '\ufe0f')) : ((c < 'ﶒ') ? (c <= 'ﶏ') : (c <= 'ﷇ')))) : ((c >= 'ףּ') ? ((c >= 'ﯓ') ? (c <= 'ﴽ') : ((c < 'צּ') ? (c <= 'פּ') : (c <= 'ﮱ'))) : ((c >= 'מּ') ? ((c < 'נּ') ? (c <= 'מּ') : (c <= 'סּ')) : ((c < 'טּ') ? (c <= 'זּ') : (c <= 'לּ')))))) : ((c >= 'ꬨ') ? ((c >= 'ힰ') ? ((c >= 'ﬀ') ? ((c >= 'יִ') ? (c <= 'ﬨ') : ((c < 'ﬓ') ? (c <= 'ﬆ') : (c <= 'ﬗ'))) : ((c >= '豈') ? ((c < '並') ? (c <= '舘') : (c <= '龎')) : ((c < 'ퟋ') ? (c <= 'ퟆ') : (c <= 'ퟻ')))) : ((c >= '\uabec') ? ((c >= '가') ? (c <= '힣') : ((c < '꯰') ? (c <= '\uabed') : (c <= '꯹'))) : ((c >= 'ꭜ') ? ((c < 'ꭰ') ? (c <= 'ꭥ') : (c <= '\uabea')) : ((c < 'ꬰ') ? (c <= 'ꬮ') : (c <= 'ꭚ'))))) : ((c >= 'ꫛ') ? ((c >= 'ꬉ') ? ((c >= 'ꬠ') ? (c <= 'ꬦ') : ((c < 'ꬑ') ? (c <= 'ꬎ') : (c <= 'ꬖ'))) : ((c >= 'ꫲ') ? ((c < 'ꬁ') ? (c <= '\uaaf6') : (c <= 'ꬆ')) : ((c < 'ꫠ') ? (c <= 'ꫝ') : (c <= '\uaaef')))) : ((c >= '꩐') ? ((c >= 'ꩺ') ? (c <= 'ꫂ') : ((c < 'ꩠ') ? (c <= '꩙') : (c <= 'ꩶ'))) : ((c >= 'ꨀ') ? ((c < 'ꩀ') ? (c <= '\uaa36') : (c <= '\uaa4d')) : ((c < 'ꧠ') ? (c <= '꧙') : (c <= 'ꧾ'))))))) : ((c >= 'ㄱ') ? ((c >= 'Ꞌ') ? ((c >= 'ꣻ') ? ((c >= 'ꤰ') ? ((c >= '\ua980') ? (c <= '\ua9c0') : ((c < 'ꥠ') ? (c <= '\ua953') : (c <= 'ꥼ'))) : ((c >= '꤀') ? (c <= '\ua92d') : ((c < 'ꣽ') ? (c <= 'ꣻ') : (c <= 'ꣽ')))) : ((c >= '\ua880') ? ((c >= '\ua8e0') ? (c <= 'ꣷ') : ((c < '꣐') ? (c <= '\ua8c4') : (c <= '꣙'))) : ((c >= 'ꟷ') ? ((c < 'ꡀ') ? (c <= '\ua827') : (c <= 'ꡳ')) : ((c < 'Ʞ') ? (c <= 'Ɬ') : (c <= 'ꞷ'))))) : ((c >= 'ꔀ') ? ((c >= 'ꙿ') ? ((c >= 'Ꜣ') ? (c <= 'ꞈ') : ((c < 'ꜗ') ? (c <= '\ua6f1') : (c <= 'ꜟ'))) : ((c >= 'Ꙁ') ? ((c < '\ua674') ? (c <= '\ua66f') : (c <= '\ua67d')) : ((c < 'ꘐ') ? (c <= 'ꘌ') : (c <= 'ꘫ')))) : ((c >= '一') ? ((c >= 'ꓐ') ? (c <= 'ꓽ') : ((c < 'ꀀ') ? (c <= '鿕') : (c <= 'ꒌ'))) : ((c >= 'ㇰ') ? ((c < '㐀') ? (c <= 'ㇿ') : (c <= '䶵')) : ((c < 'ㆠ') ? (c <= 'ㆎ') : (c <= 'ㆺ')))))) : ((c >= 'ⷐ') ? ((c >= '〸') ? ((c >= 'ァ') ? ((c >= 'ㄅ') ? (c <= 'ㄭ') : ((c < 'ー') ? (c <= 'ヺ') : (c <= 'ヿ'))) : ((c >= '\u3099') ? ((c < 'ゝ') ? (c <= '\u309a') : (c <= 'ゟ')) : ((c < 'ぁ') ? (c <= '〼') : (c <= 'ゖ')))) : ((c >= '々') ? ((c >= '〱') ? (c <= '〵') : ((c < '〡') ? (c <= '〇') : (c <= '\u302f'))) : ((c >= '\u2de0') ? ((c < 'ⸯ') ? (c <= '\u2dff') : (c <= 'ⸯ')) : ((c < 'ⷘ') ? (c <= 'ⷖ') : (c <= 'ⷞ'))))) : ((c >= '\u2d7f') ? ((c >= 'ⶸ') ? ((c >= 'ⷈ') ? (c <= 'ⷎ') : ((c < 'ⷀ') ? (c <= 'ⶾ') : (c <= 'ⷆ'))) : ((c >= 'ⶨ') ? ((c < 'ⶰ') ? (c <= 'ⶮ') : (c <= 'ⶶ')) : ((c < 'ⶠ') ? (c <= 'ⶖ') : (c <= 'ⶦ')))) : ((c >= 'ⴭ') ? ((c >= 'ⵯ') ? (c <= 'ⵯ') : ((c < 'ⴰ') ? (c <= 'ⴭ') : (c <= 'ⵧ'))) : ((c >= 'ⴀ') ? ((c < 'ⴧ') ? (c <= 'ⴥ') : (c <= 'ⴧ')) : ((c < 'Ⳬ') ? (c <= 'ⳤ') : (c <= 'ⳳ')))))))) : ((c >= '\u1b80') ? ((c >= '\u202a') ? ((c >= 'ℕ') ? ((c >= 'ℼ') ? ((c >= 'Ⅰ') ? ((c >= 'ⰰ') ? (c <= 'ⱞ') : ((c < 'Ⰰ') ? (c <= 'ↈ') : (c <= 'Ⱞ'))) : ((c >= 'ⅎ') ? (c <= 'ⅎ') : ((c < 'ⅅ') ? (c <= 'ℿ') : (c <= 'ⅉ')))) : ((c >= 'ℨ') ? ((c >= 'ℯ') ? (c <= 'ℹ') : ((c < 'K') ? (c <= 'ℨ') : (c <= 'ℭ'))) : ((c >= 'ℤ') ? ((c < 'Ω') ? (c <= 'ℤ') : (c <= 'Ω')) : ((c < 'ℙ') ? (c <= 'ℕ') : (c <= 'ℝ'))))) : ((c >= 'ₐ') ? ((c >= 'ℂ') ? ((c >= 'ℊ') ? (c <= 'ℓ') : ((c < 'ℇ') ? (c <= 'ℂ') : (c <= 'ℇ'))) : ((c >= '\u20e1') ? ((c < '\u20e5') ? (c <= '\u20e1') : (c <= '\u20f0')) : ((c < '\u20d0') ? (c <= 'ₜ') : (c <= '\u20dc')))) : ((c >= '\u2066') ? ((c >= 'ⁿ') ? (c <= 'ⁿ') : ((c < 'ⁱ') ? (c <= '\u206f') : (c <= 'ⁱ'))) : ((c >= '\u2054') ? ((c < '\u2060') ? (c <= '\u2054') : (c <= '\u2064')) : ((c < '\u203f') ? (c <= '\u202e') : (c <= '\u2040')))))) : ((c >= 'Ὓ') ? ((c >= 'ῆ') ? ((c >= 'ῲ') ? ((c >= '\u200b') ? (c <= '\u200f') : ((c < 'ῶ') ? (c <= 'ῴ') : (c <= 'ῼ'))) : ((c >= 'ῖ') ? ((c < 'ῠ') ? (c <= 'Ί') : (c <= 'Ῥ')) : ((c < 'ῐ') ? (c <= 'ῌ') : (c <= 'ΐ')))) : ((c >= 'ᾶ') ? ((c >= 'ῂ') ? (c <= 'ῄ') : ((c < 'ι') ? (c <= 'ᾼ') : (c <= 'ι'))) : ((c >= 'Ὗ') ? ((c < 'ᾀ') ? (c <= 'ώ') : (c <= 'ᾴ')) : ((c < 'Ὕ') ? (c <= 'Ὓ') : (c <= 'Ὕ'))))) : ((c >= 'ᴀ') ? ((c >= 'Ὀ') ? ((c >= 'Ὑ') ? (c <= 'Ὑ') : ((c < 'ὐ') ? (c <= 'Ὅ') : (c <= 'ὗ'))) : ((c >= 'Ἐ') ? ((c < 'ἠ') ? (c <= 'Ἕ') : (c <= 'ὅ')) : ((c < '\u1dfc') ? (c <= '\u1df5') : (c <= 'ἕ')))) : ((c >= '\u1cd0') ? ((c >= '\u1cf8') ? (c <= '\u1cf9') : ((c < '\u1cd4') ? (c <= '\u1cd2') : (c <= 'ᳶ'))) : ((c >= '᱀') ? ((c < 'ᱍ') ? (c <= '᱉') : (c <= 'ᱽ')) : ((c < 'ᰀ') ? (c <= '\u1bf3') : (c <= '\u1c37'))))))) : ((c >= 'ក') ? ((c >= 'ᦀ') ? ((c >= '᪐') ? ((c >= '\u1b00') ? ((c >= '\u1b6b') ? (c <= '\u1b73') : ((c < '᭐') ? (c <= 'ᭋ') : (c <= '᭙'))) : ((c >= '\u1ab0') ? (c <= '\u1abd') : ((c < 'ᪧ') ? (c <= '᪙') : (c <= 'ᪧ')))) : ((c >= 'ᨠ') ? ((c >= '\u1a7f') ? (c <= '᪉') : ((c < '\u1a60') ? (c <= '\u1a5e') : (c <= '\u1a7c'))) : ((c >= '᧐') ? ((c < 'ᨀ') ? (c <= '᧙') : (c <= '\u1a1b')) : ((c < 'ᦰ') ? (c <= 'ᦫ') : (c <= 'ᧉ'))))) : ((c >= 'ᢀ') ? ((c >= '\u1930') ? ((c >= 'ᥰ') ? (c <= 'ᥴ') : ((c < '᥆') ? (c <= '\u193b') : (c <= 'ᥭ'))) : ((c >= 'ᤀ') ? ((c < '\u1920') ? (c <= 'ᤞ') : (c <= '\u192b')) : ((c < 'ᢰ') ? (c <= 'ᢪ') : (c <= 'ᣵ')))) : ((c >= '\u180b') ? ((c >= 'ᠠ') ? (c <= 'ᡷ') : ((c < '᠐') ? (c <= '\u180e') : (c <= '᠙'))) : ((c >= 'ៜ') ? ((c < '០') ? (c <= '\u17dd') : (c <= '៩')) : ((c < 'ៗ') ? (c <= '\u17d3') : (c <= 'ៗ')))))) : ((c >= 'Ꭰ') ? ((c >= 'ᜀ') ? ((c >= 'ᝠ') ? ((c >= '\u1772') ? (c <= '\u1773') : ((c < 'ᝮ') ? (c <= 'ᝬ') : (c <= 'ᝰ'))) : ((c >= 'ᜠ') ? ((c < 'ᝀ') ? (c <= '\u1734') : (c <= '\u1753')) : ((c < 'ᜎ') ? (c <= 'ᜌ') : (c <= '\u1714')))) : ((c >= 'ᚁ') ? ((c >= 'ᛮ') ? (c <= 'ᛸ') : ((c < 'ᚠ') ? (c <= 'ᚚ') : (c <= 'ᛪ'))) : ((c >= 'ᐁ') ? ((c < 'ᙯ') ? (c <= 'ᙬ') : (c <= 'ᙿ')) : ((c < 'ᏸ') ? (c <= 'Ᏽ') : (c <= 'ᏽ'))))) : ((c >= 'ዂ') ? ((c >= 'ጘ') ? ((c >= 'ᎀ') ? (c <= 'ᎏ') : ((c < '\u135d') ? (c <= 'ፚ') : (c <= '\u135f'))) : ((c >= 'ዘ') ? ((c < 'ጒ') ? (c <= 'ጐ') : (c <= 'ጕ')) : ((c < 'ወ') ? (c <= 'ዅ') : (c <= 'ዖ')))) : ((c >= 'ኲ') ? ((c >= 'ዀ') ? (c <= 'ዀ') : ((c < 'ኸ') ? (c <= 'ኵ') : (c <= 'ኾ'))) : ((c >= 'ኊ') ? ((c < 'ነ') ? (c <= 'ኍ') : (c <= 'ኰ')) : ((c < 'በ') ? (c <= 'ቝ') : (c <= 'ኈ'))))))))) : ((c >= '୦') ? ((c >= '\u0d82') ? ((c >= 'ເ') ? ((c >= '\u0f86') ? ((c >= 'Ⴭ') ? ((c >= 'ቊ') ? ((c >= 'ቘ') ? (c <= 'ቘ') : ((c < 'ቐ') ? (c <= 'ቍ') : (c <= 'ቖ'))) : ((c >= 'ჼ') ? (c <= 'ቈ') : ((c < 'ა') ? (c <= 'Ⴭ') : (c <= 'ჺ')))) : ((c >= 'ၐ') ? ((c >= 'Ⴧ') ? (c <= 'Ⴧ') : ((c < 'Ⴀ') ? (c <= '\u109d') : (c <= 'Ⴥ'))) : ((c >= '\u0fc6') ? ((c < 'က') ? (c <= '\u0fc6') : (c <= '၉')) : ((c < '\u0f99') ? (c <= '\u0f97') : (c <= '\u0fbc'))))) : ((c >= '༠') ? ((c >= '\u0f3e') ? ((c >= '\u0f71') ? (c <= '\u0f84') : ((c < 'ཉ') ? (c <= 'ཇ') : (c <= 'ཬ'))) : ((c >= '\u0f37') ? ((c < '\u0f39') ? (c <= '\u0f37') : (c <= '\u0f39')) : ((c < '\u0f35') ? (c <= '༩') : (c <= '\u0f35')))) : ((c >= 'ໜ') ? ((c >= '\u0f18') ? (c <= '\u0f19') : ((c < 'ༀ') ? (c <= 'ໟ') : (c <= 'ༀ'))) : ((c >= '\u0ec8') ? ((c < '໐') ? (c <= '\u0ecd') : (c <= '໙')) : ((c < 'ໆ') ? (c <= 'ໄ') : (c <= 'ໆ')))))) : ((c >= '๐') ? ((c >= 'ນ') ? ((c >= 'ສ') ? ((c >= '\u0ebb') ? (c <= 'ຽ') : ((c < 'ອ') ? (c <= 'ຫ') : (c <= '\u0eb9'))) : ((c >= 'ລ') ? ((c < 'ວ') ? (c <= 'ລ') : (c <= 'ວ')) : ((c < 'ມ') ? (c <= 'ຟ') : (c <= 'ຣ')))) : ((c >= 'ຊ') ? ((c >= 'ດ') ? (c <= 'ທ') : ((c < 'ຍ') ? (c <= 'ຊ') : (c <= 'ຍ'))) : ((c >= 'ຄ') ? ((c < 'ງ') ? (c <= 'ຄ') : (c <= 'ຈ')) : ((c < 'ກ') ? (c <= '๙') : (c <= 'ຂ'))))) : ((c >= '\u0dcf') ? ((c >= '\u0df2') ? ((c >= 'เ') ? (c <= '\u0e4e') : ((c < 'ก') ? (c <= '\u0df3') : (c <= '\u0e3a'))) : ((c >= '\u0dd8') ? ((c < '෦') ? (c <= '\u0ddf') : (c <= '෯')) : ((c < '\u0dd6') ? (c <= '\u0dd4') : (c <= '\u0dd6')))) : ((c >= 'ල') ? ((c >= '\u0dca') ? (c <= '\u0dca') : ((c < 'ව') ? (c <= 'ල') : (c <= 'ෆ'))) : ((c >= 'ක') ? ((c < 'ඳ') ? (c <= 'න') : (c <= 'ර')) : ((c < 'අ') ? (c <= '\u0d83') : (c <= 'ඖ'))))))) : ((c >= 'ౠ') ? ((c >= '೦') ? ((c >= '\u0d46') ? ((c >= 'ൟ') ? ((c >= 'ൺ') ? (c <= 'ൿ') : ((c < '൦') ? (c <= '\u0d63') : (c <= '൯'))) : ((c >= '\u0d57') ? (c <= '\u0d57') : ((c < '\u0d4a') ? (c <= '\u0d48') : (c <= 'ൎ')))) : ((c >= 'എ') ? ((c >= 'ഽ') ? (c <= '\u0d44') : ((c < 'ഒ') ? (c <= 'ഐ') : (c <= 'ഺ'))) : ((c >= '\u0d01') ? ((c < 'അ') ? (c <= '\u0d03') : (c <= 'ഌ')) : ((c < 'ೱ') ? (c <= '೯') : (c <= 'ೲ'))))) : ((c >= 'ವ') ? ((c >= '\u0cd5') ? ((c >= 'ೠ') ? (c <= '\u0ce3') : ((c < 'ೞ') ? (c <= '\u0cd6') : (c <= 'ೞ'))) : ((c >= '\u0cc6') ? ((c < '\u0cca') ? (c <= '\u0cc8') : (c <= '\u0ccd')) : ((c < '\u0cbc') ? (c <= 'ಹ') : (c <= '\u0cc4')))) : ((c >= 'ಎ') ? ((c >= 'ಪ') ? (c <= 'ಳ') : ((c < 'ಒ') ? (c <= 'ಐ') : (c <= 'ನ'))) : ((c >= '\u0c81') ? ((c < 'ಅ') ? (c <= '\u0c83') : (c <= 'ಌ')) : ((c < '౦') ? (c <= '\u0c63') : (c <= '౯')))))) : ((c >= '\u0bca') ? ((c >= 'ఒ') ? ((c >= '\u0c4a') ? ((c >= 'ౘ') ? (c <= 'ౚ') : ((c < '\u0c55') ? (c <= '\u0c4d') : (c <= '\u0c56'))) : ((c >= 'ఽ') ? ((c < '\u0c46') ? (c <= '\u0c44') : (c <= '\u0c48')) : ((c < 'ప') ? (c <= 'న') : (c <= 'హ')))) : ((c >= '\u0c00') ? ((c >= 'ఎ') ? (c <= 'ఐ') : ((c < 'అ') ? (c <= '\u0c03') : (c <= 'ఌ'))) : ((c >= '\u0bd7') ? ((c < '௦') ? (c <= '\u0bd7') : (c <= '௯')) : ((c < 'ௐ') ? (c <= '\u0bcd') : (c <= 'ௐ'))))) : ((c >= 'ஜ') ? ((c >= 'ம') ? ((c >= '\u0bc6') ? (c <= '\u0bc8') : ((c < '\u0bbe') ? (c <= 'ஹ') : (c <= '\u0bc2'))) : ((c >= 'ண') ? ((c < 'ந') ? (c <= 'த') : (c <= 'ப')) : ((c < 'ஞ') ? (c <= 'ஜ') : (c <= 'ட')))) : ((c >= 'எ') ? ((c >= 'ங') ? (c <= 'ச') : ((c < 'ஒ') ? (c <= 'ஐ') : (c <= 'க'))) : ((c >= '\u0b82') ? ((c < 'அ') ? (c <= 'ஃ') : (c <= 'ஊ')) : ((c < 'ୱ') ? (c <= '୯') : (c <= 'ୱ')))))))) : ((c >= 'এ') ? ((c >= '\u0a81') ? ((c >= '\u0b01') ? ((c >= '\u0b3c') ? ((c >= '\u0b56') ? ((c >= 'ୟ') ? (c <= '\u0b63') : ((c < 'ଡ଼') ? (c <= '\u0b57') : (c <= 'ଢ଼'))) : ((c >= '\u0b4b') ? (c <= '\u0b4d') : ((c < '\u0b47') ? (c <= '\u0b44') : (c <= '\u0b48')))) : ((c >= 'ପ') ? ((c >= 'ଵ') ? (c <= 'ହ') : ((c < 'ଲ') ? (c <= 'ର') : (c <= 'ଳ'))) : ((c >= 'ଏ') ? ((c < 'ଓ') ? (c <= 'ଐ') : (c <= 'ନ')) : ((c < 'ଅ') ? (c <= '\u0b03') : (c <= 'ଌ'))))) : ((c >= '\u0abc') ? ((c >= 'ૠ') ? ((c >= 'ૹ') ? (c <= 'ૹ') : ((c < '૦') ? (c <= '\u0ae3') : (c <= '૯'))) : ((c >= '\u0acb') ? ((c < 'ૐ') ? (c <= '\u0acd') : (c <= 'ૐ')) : ((c < '\u0ac7') ? (c <= '\u0ac5') : (c <= '\u0ac9')))) : ((c >= 'પ') ? ((c >= 'વ') ? (c <= 'હ') : ((c < 'લ') ? (c <= 'ર') : (c <= 'ળ'))) : ((c >= 'એ') ? ((c < 'ઓ') ? (c <= 'ઑ') : (c <= 'ન')) : ((c < 'અ') ? (c <= '\u0a83') : (c <= 'ઍ')))))) : ((c >= 'ਏ') ? ((c >= '\u0a3e') ? ((c >= 'ਖ਼') ? ((c >= '੦') ? (c <= '\u0a75') : ((c < 'ਫ਼') ? (c <= 'ੜ') : (c <= 'ਫ਼'))) : ((c >= '\u0a4b') ? ((c < '\u0a51') ? (c <= '\u0a4d') : (c <= '\u0a51')) : ((c < '\u0a47') ? (c <= '\u0a42') : (c <= '\u0a48')))) : ((c >= 'ਵ') ? ((c >= '\u0a3c') ? (c <= '\u0a3c') : ((c < 'ਸ') ? (c <= 'ਸ਼') : (c <= 'ਹ'))) : ((c >= 'ਪ') ? ((c < 'ਲ') ? (c <= 'ਰ') : (c <= 'ਲ਼')) : ((c < 'ਓ') ? (c <= 'ਐ') : (c <= 'ਨ'))))) : ((c >= '\u09cb') ? ((c >= '০') ? ((c >= 'ਅ') ? (c <= 'ਊ') : ((c < '\u0a01') ? (c <= 'ৱ') : (c <= '\u0a03'))) : ((c >= 'ড়') ? ((c < 'য়') ? (c <= 'ঢ়') : (c <= '\u09e3')) : ((c < '\u09d7') ? (c <= 'ৎ') : (c <= '\u09d7')))) : ((c >= 'শ') ? ((c >= '\u09c7') ? (c <= '\u09c8') : ((c < '\u09bc') ? (c <= 'হ') : (c <= '\u09c4'))) : ((c >= 'প') ? ((c < 'ল') ? (c <= 'র') : (c <= 'ল')) : ((c < 'ও') ? (c <= 'ঐ') : (c <= 'ন'))))))) : ((c >= 'ա') ? ((c >= '\u06df') ? ((c >= 'ࠀ') ? ((c >= '०') ? ((c >= 'অ') ? (c <= 'ঌ') : ((c < 'ॱ') ? (c <= '९') : (c <= '\u0983'))) : ((c >= 'ࢠ') ? ((c < '\u08e3') ? (c <= 'ࢴ') : (c <= '\u0963')) : ((c < 'ࡀ') ? (c <= '\u082d') : (c <= '\u085b')))) : ((c >= 'ݍ') ? ((c >= 'ߺ') ? (c <= 'ߺ') : ((c < '߀') ? (c <= 'ޱ') : (c <= 'ߵ'))) : ((c >= 'ۿ') ? ((c < '\u070f') ? (c <= 'ۿ') : (c <= '\u074a')) : ((c < '\u06ea') ? (c <= '\u06e8') : (c <= 'ۼ'))))) : ((c >= 'װ') ? ((c >= 'ؠ') ? ((c >= 'ە') ? (c <= '\u06dd') : ((c < 'ٮ') ? (c <= '٩') : (c <= 'ۓ'))) : ((c >= '\u0610') ? ((c < '\u061c') ? (c <= '\u061a') : (c <= '\u061c')) : ((c < '\u0600') ? (c <= 'ײ') : (c <= '\u0605')))) : ((c >= '\u05c4') ? ((c >= 'א') ? (c <= 'ת') : ((c < '\u05c7') ? (c <= '\u05c5') : (c <= '\u05c7'))) : ((c >= '\u05bf') ? ((c < '\u05c1') ? (c <= '\u05bf') : (c <= '\u05c2')) : ((c < '\u0591') ? (c <= 'և') : (c <= '\u05bd')))))) : ((c >= '\u0300') ? ((c >= 'Ύ') ? ((c >= 'Ҋ') ? ((c >= 'ՙ') ? (c <= 'ՙ') : ((c < 'Ա') ? (c <= 'ԯ') : (c <= 'Ֆ'))) : ((c >= 'Ϸ') ? ((c < '\u0483') ? (c <= 'ҁ') : (c <= '\u0487')) : ((c < 'Σ') ? (c <= 'Ρ') : (c <= 'ϵ')))) : ((c >= 'Ά') ? ((c >= 'Ό') ? (c <= 'Ό') : ((c < 'Έ') ? (c <= 'Ά') : (c <= 'Ί'))) : ((c >= 'ͺ') ? ((c < 'Ϳ') ? (c <= 'ͽ') : (c <= 'Ϳ')) : ((c < 'Ͷ') ? (c <= 'ʹ') : (c <= 'ͷ'))))) : ((c >= 'À') ? ((c >= 'ˠ') ? ((c >= 'ˮ') ? (c <= 'ˮ') : ((c < 'ˬ') ? (c <= 'ˤ') : (c <= 'ˬ'))) : ((c >= 'ø') ? ((c < 'ˆ') ? (c <= 'ˁ') : (c <= 'ˑ')) : ((c < 'Ø') ? (c <= 'Ö') : (c <= 'ö')))) : ((c >= 'ª') ? ((c >= 'º') ? (c <= 'º') : ((c < 'µ') ? (c <= 'ª') : (c <= 'µ'))) : ((c >= '_') ? ((c < 'a') ? (c <= '_') : (c <= 'z')) : ((c < 'A') ? (c <= '9') : (c <= 'Z')))))))))))
			{
				num2 = num;
			}
		}
		return num2;
	}

	private int __GENERATED_PEG__RULE__OR__(int pos, string text)
	{
		int num = 0;
		char c = '\0';
		int num2 = 0;
		c = '\0';
		num2 = -1;
		num = pos;
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c == 'o' && num < text.Length)
			{
				c = text[num];
				num++;
				if (c == 'r')
				{
					num2 = num;
				}
			}
		}
		return num2;
	}

	private int __GENERATED_PEG__RULE__expression_and__(int pos, string text, ref Expression result)
	{
		char c = '\0';
		Expression result2 = null;
		List<Expression> list = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__expression_and__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__expression_and__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__expression_and__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__expression_and__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__expression_comp__(pos, text, ref result2);
			int num7;
			if (num >= 0)
			{
				list = new List<Expression>();
				Expression result4 = null;
				int num2 = num;
				while (true)
				{
					int num3 = __GENERATED_PEG__RULE__AND__(num2, text);
					int num5;
					if (num3 >= 0)
					{
						int num4 = __GENERATED_PEG__RULE__S__(num3, text);
						num5 = ((num4 < 0) ? (-1) : __GENERATED_PEG__RULE__expression_comp__(num4, text, ref result4));
					}
					else
					{
						num5 = -1;
					}
					int num6 = num5;
					if (num6 < 0)
					{
						break;
					}
					list.Add(result4);
					num2 = num6;
				}
				num7 = num2;
			}
			else
			{
				num7 = -1;
			}
			int num8 = num7;
			__GENERATED_PEG__Memeoize_Pos__expression_and__ = pos;
			__GENERATED_PEG__Memeoize_End__expression_and__ = num8;
			if (num8 >= 0)
			{
				result = expression_and(result2, list);
				__GENERATED_PEG__Memeoize_Res__expression_and__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___expression_and__ < pos)
			{
				__GENERATED_PEG__MaxRollback___expression_and__ = pos;
			}
			result3 = num8;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__AND__(int pos, string text)
	{
		int num = 0;
		char c = '\0';
		int num2 = 0;
		c = '\0';
		num2 = -1;
		num = pos;
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c == 'a' && num < text.Length)
			{
				c = text[num];
				num++;
				if (c == 'n' && num < text.Length)
				{
					c = text[num];
					num++;
					if (c == 'd')
					{
						num2 = num;
					}
				}
			}
		}
		return num2;
	}

	private int __GENERATED_PEG__RULE__expression_comp__(int pos, string text, ref Expression result)
	{
		char c = '\0';
		Expression result2 = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__expression_comp__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__expression_comp__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__expression_comp__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__expression_comp__;
		}
		else
		{
			int num = 0;
			int num2 = __GENERATED_PEG__RULE__expression_property_atom__(pos, text, ref result2);
			if (num2 >= 0)
			{
				num = num2;
			}
			else
			{
				int num3 = __GENERATED_PEG__RULE__expression_function_atom__(pos, text, ref result2);
				if (num3 >= 0)
				{
					num = num3;
				}
				else
				{
					int num4 = __GENERATED_PEG__RULE__expression_property_in_atom_collection__(pos, text, ref result2);
					if (num4 >= 0)
					{
						num = num4;
					}
					else
					{
						int num5 = __GENERATED_PEG__RULE__expression_property_in_comma_expression__(pos, text, ref result2);
						if (num5 >= 0)
						{
							num = num5;
						}
						else
						{
							int num6 = __GENERATED_PEG__RULE__expression_property_in_function__(pos, text, ref result2);
							if (num6 >= 0)
							{
								num = num6;
							}
							else
							{
								int num7 = __GENERATED_PEG__RULE__expression_property_in_query_expression__(pos, text, ref result2);
								if (num7 >= 0)
								{
									num = num7;
								}
								else
								{
									int num8 = __GENERATED_PEG__RULE__expression_inbrackets__(pos, text, ref result2);
									if (num8 >= 0)
									{
										num = num8;
									}
									else
									{
										int num9 = __GENERATED_PEG__RULE__not_expression__(pos, text, ref result2);
										num = ((num9 < 0) ? __GENERATED_PEG__RULE__expression_property_in_parameter__(pos, text, ref result2) : num9);
									}
								}
							}
						}
					}
				}
			}
			int num10 = num;
			__GENERATED_PEG__Memeoize_Pos__expression_comp__ = pos;
			__GENERATED_PEG__Memeoize_End__expression_comp__ = num10;
			if (num10 >= 0)
			{
				result = expression_comp(result2);
				__GENERATED_PEG__Memeoize_Res__expression_comp__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___expression_comp__ < pos)
			{
				__GENERATED_PEG__MaxRollback___expression_comp__ = pos;
			}
			result3 = num10;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__expression_property_in_parameter__(int pos, string text, ref Expression result)
	{
		char c = '\0';
		Property result2 = null;
		Constant result3 = null;
		int result4;
		if (__GENERATED_PEG__Memeoize_Pos__expression_property_in_parameter__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__expression_property_in_parameter__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__expression_property_in_parameter__;
			}
			result4 = __GENERATED_PEG__Memeoize_End__expression_property_in_parameter__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__property__(pos, text, ref result2);
			int num4;
			if (num >= 0)
			{
				int num2 = __GENERATED_PEG__RULE__IN__(num, text);
				if (num2 >= 0)
				{
					int num3 = __GENERATED_PEG__RULE__S__(num2, text);
					num4 = ((num3 < 0) ? (-1) : __GENERATED_PEG__RULE__parameter__(num3, text, ref result3));
				}
				else
				{
					num4 = -1;
				}
			}
			else
			{
				num4 = -1;
			}
			int num5 = num4;
			__GENERATED_PEG__Memeoize_Pos__expression_property_in_parameter__ = pos;
			__GENERATED_PEG__Memeoize_End__expression_property_in_parameter__ = num5;
			if (num5 >= 0)
			{
				result = expression_property_in_parameter(result2, result3);
				__GENERATED_PEG__Memeoize_Res__expression_property_in_parameter__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___expression_property_in_parameter__ < pos)
			{
				__GENERATED_PEG__MaxRollback___expression_property_in_parameter__ = pos;
			}
			result4 = num5;
		}
		return result4;
	}

	private int __GENERATED_PEG__RULE__parameter__(int pos, string text, ref Constant result)
	{
		char c = '\0';
		Parameter result2 = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__parameter__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__parameter__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__parameter__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__parameter__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__query_parameter__(pos, text, ref result2);
			__GENERATED_PEG__Memeoize_Pos__parameter__ = pos;
			__GENERATED_PEG__Memeoize_End__parameter__ = num;
			if (num >= 0)
			{
				result = parameter(result2);
				__GENERATED_PEG__Memeoize_Res__parameter__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___parameter__ < pos)
			{
				__GENERATED_PEG__MaxRollback___parameter__ = pos;
			}
			result3 = num;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__query_parameter__(int pos, string text, ref Parameter result)
	{
		char c = '\0';
		NToken n_wildcard_ = default(NToken);
		Identifier result2 = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__query_parameter__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__query_parameter__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__query_parameter__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__query_parameter__;
		}
		else
		{
			int num = -1;
			int num2 = pos;
			if (num2 < text.Length)
			{
				c = text[num2];
				num2++;
				if (c == '@')
				{
					num = num2;
				}
			}
			int num3 = num;
			if (num3 >= 0)
			{
				n_wildcard_ = new NToken(pos, num3);
			}
			int num4 = num3;
			int num6;
			if (num4 >= 0)
			{
				int num5 = __GENERATED_PEG__RULE__parameter_name__(num4, text, ref result2);
				num6 = ((num5 < 0) ? (-1) : __GENERATED_PEG__RULE__s__(num5, text));
			}
			else
			{
				num6 = -1;
			}
			int num7 = num6;
			__GENERATED_PEG__Memeoize_Pos__query_parameter__ = pos;
			__GENERATED_PEG__Memeoize_End__query_parameter__ = num7;
			if (num7 >= 0)
			{
				result = query_parameter(n_wildcard_, result2);
				__GENERATED_PEG__Memeoize_Res__query_parameter__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___query_parameter__ < pos)
			{
				__GENERATED_PEG__MaxRollback___query_parameter__ = pos;
			}
			result3 = num7;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__parameter_name__(int pos, string text, ref Identifier result)
	{
		char c = '\0';
		Identifier result2 = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__parameter_name__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__parameter_name__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__parameter_name__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__parameter_name__;
		}
		else
		{
			int num = 0;
			int num2 = __GENERATED_PEG__RULE__simple_identifier__(pos, text, ref result2);
			num = ((num2 < 0) ? __GENERATED_PEG__RULE__sparen_parameter_name__(pos, text, ref result2) : num2);
			int num3 = num;
			__GENERATED_PEG__Memeoize_Pos__parameter_name__ = pos;
			__GENERATED_PEG__Memeoize_End__parameter_name__ = num3;
			if (num3 >= 0)
			{
				result = result2;
				result.Location = new Location(_parsingSource, result2.StartPos, result2.EndPos);
				__GENERATED_PEG__Memeoize_Res__parameter_name__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___parameter_name__ < pos)
			{
				__GENERATED_PEG__MaxRollback___parameter_name__ = pos;
			}
			result3 = num3;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__sparen_parameter_name__(int pos, string text, ref Identifier result)
	{
		char c = '\0';
		NToken s = default(NToken);
		int result2;
		if (__GENERATED_PEG__Memeoize_Pos__sparen_parameter_name__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__sparen_parameter_name__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__sparen_parameter_name__;
			}
			result2 = __GENERATED_PEG__Memeoize_End__sparen_parameter_name__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__LSPAREN__(pos, text);
			int num19;
			if (num >= 0)
			{
				int num2 = 0;
				int num3 = num;
				while (true)
				{
					int num4 = 0;
					int num5 = -1;
					int num6 = num3;
					if (num6 < text.Length)
					{
						c = text[num6];
						num6++;
						if (c != '[')
						{
							if (c == ']' && num6 < text.Length)
							{
								c = text[num6];
								num6++;
								if (c == ']')
								{
									goto IL_0176;
								}
							}
						}
						else if (num6 < text.Length)
						{
							c = text[num6];
							num6++;
							if (c == '[')
							{
								goto IL_0176;
							}
						}
					}
					goto IL_017d;
					IL_017d:
					int num7 = num5;
					if (num7 >= 0)
					{
						num4 = num7;
					}
					else
					{
						int num8 = __GENERATED_PEG__RULE__LSPAREN__(num3, text);
						int num9 = ((num8 >= 0) ? (-1) : num3);
						int num14;
						if (num9 >= 0)
						{
							int num10 = __GENERATED_PEG__RULE__RSPAREN__(num9, text);
							int num11 = ((num10 >= 0) ? (-1) : num9);
							if (num11 >= 0)
							{
								int num12 = -1;
								int num13 = num11;
								if (num13 < text.Length)
								{
									c = text[num13];
									num13++;
									if (0 == 0)
									{
										num12 = num13;
									}
								}
								num14 = num12;
							}
							else
							{
								num14 = -1;
							}
						}
						else
						{
							num14 = -1;
						}
						num4 = num14;
					}
					int num15 = num4;
					if (num15 < 0)
					{
						break;
					}
					int num16 = num2 + 1;
					num3 = num15;
					num2 = num16;
					continue;
					IL_0176:
					num5 = num6;
					goto IL_017d;
				}
				int num17 = ((num2 < 1) ? (-1) : num3);
				if (num17 >= 0)
				{
					s = new NToken(num, num17);
				}
				int num18 = num17;
				num19 = ((num18 < 0) ? (-1) : __GENERATED_PEG__RULE__RSPAREN__(num18, text));
			}
			else
			{
				num19 = -1;
			}
			int num20 = num19;
			__GENERATED_PEG__Memeoize_Pos__sparen_parameter_name__ = pos;
			__GENERATED_PEG__Memeoize_End__sparen_parameter_name__ = num20;
			if (num20 >= 0)
			{
				result = sparen_parameter_name(s);
				result.Location = new Location(_parsingSource, s.StartPos, s.EndPos);
				__GENERATED_PEG__Memeoize_Res__sparen_parameter_name__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___sparen_parameter_name__ < pos)
			{
				__GENERATED_PEG__MaxRollback___sparen_parameter_name__ = pos;
			}
			result2 = num20;
		}
		return result2;
	}

	private int __GENERATED_PEG__RULE__RSPAREN__(int pos, string text)
	{
		int num = 0;
		char c = '\0';
		int num2 = 0;
		c = '\0';
		num2 = -1;
		num = pos;
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c == ']')
			{
				num2 = num;
			}
		}
		return num2;
	}

	private int __GENERATED_PEG__RULE__LSPAREN__(int pos, string text)
	{
		int num = 0;
		char c = '\0';
		int num2 = 0;
		c = '\0';
		num2 = -1;
		num = pos;
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c == '[')
			{
				num2 = num;
			}
		}
		return num2;
	}

	private int __GENERATED_PEG__RULE__simple_identifier__(int pos, string text, ref Identifier result)
	{
		char c = '\0';
		NToken s = default(NToken);
		NToken s2 = default(NToken);
		int result2;
		if (__GENERATED_PEG__Memeoize_Pos__simple_identifier__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__simple_identifier__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__simple_identifier__;
			}
			result2 = __GENERATED_PEG__Memeoize_End__simple_identifier__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__letter__(pos, text);
			if (num >= 0)
			{
				s = new NToken(pos, num);
			}
			int num2 = num;
			int num8;
			if (num2 >= 0)
			{
				int num3 = num2;
				while (true)
				{
					int num4 = 0;
					int num5 = __GENERATED_PEG__RULE__letter__(num3, text);
					num4 = ((num5 < 0) ? __GENERATED_PEG__RULE__digit__(num3, text) : num5);
					int num6 = num4;
					if (num6 < 0)
					{
						break;
					}
					num3 = num6;
				}
				int num7 = num3;
				if (num7 >= 0)
				{
					s2 = new NToken(num2, num7);
				}
				num8 = num7;
			}
			else
			{
				num8 = -1;
			}
			int num9 = num8;
			__GENERATED_PEG__Memeoize_Pos__simple_identifier__ = pos;
			__GENERATED_PEG__Memeoize_End__simple_identifier__ = num9;
			if (num9 >= 0)
			{
				result = simple_identifier(s, s2);
				result.Location = new Location(_parsingSource, s.StartPos, s2.EndPos);
				__GENERATED_PEG__Memeoize_Res__simple_identifier__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___simple_identifier__ < pos)
			{
				__GENERATED_PEG__MaxRollback___simple_identifier__ = pos;
			}
			result2 = num9;
		}
		return result2;
	}

	private int __GENERATED_PEG__RULE__digit__(int pos, string text)
	{
		char c = '\0';
		int num = 0;
		int num2 = 0;
		c = '\0';
		num2 = -1;
		num = pos;
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c >= '0' && ((c >= '௧') ? ((c >= '๐') ? ((c >= '၀') ? (c <= '၉') : ((c < '໐') ? (c <= '๙') : (c <= '໙'))) : ((c >= '೦') ? ((c < '൦') ? (c <= '೯') : (c <= '൯')) : ((c < '౦') ? (c <= '௯') : (c <= '౯')))) : ((c >= '০') ? ((c >= '૦') ? ((c < '୦') ? (c <= '૯') : (c <= '୯')) : ((c < '੦') ? (c <= '৯') : (c <= '੯'))) : ((c >= '۰') ? ((c < '०') ? (c <= '۹') : (c <= '९')) : ((c < '٠') ? (c <= '9') : (c <= '٩'))))))
			{
				num2 = num;
			}
		}
		return num2;
	}

	private int __GENERATED_PEG__RULE__letter__(int pos, string text)
	{
		char c = '\0';
		int num = 0;
		int num2 = 0;
		c = '\0';
		num2 = -1;
		num = pos;
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c >= '$' && ((c >= 'ø') ? ((c >= '㐀') ? ((c >= '豈') ? (c <= '\ufaff') : ((c < '一') ? (c <= '㴭') : (c <= '\u9fff'))) : ((c >= '㌀') ? (c <= '㍿') : ((c < '\u3040') ? (c <= '\u1fff') : (c <= '\u318f')))) : ((c >= 'a') ? ((c >= 'Ø') ? (c <= 'ö') : ((c < 'À') ? (c <= 'z') : (c <= 'Ö'))) : ((c >= '_') ? (c <= '_') : ((c < 'A') ? (c <= '$') : (c <= 'Z'))))))
			{
				num2 = num;
			}
		}
		return num2;
	}

	private int __GENERATED_PEG__RULE__IN__(int pos, string text)
	{
		int num = 0;
		char c = '\0';
		int num2 = 0;
		c = '\0';
		num2 = -1;
		num = pos;
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c == 'i' && num < text.Length)
			{
				c = text[num];
				num++;
				if (c == 'n')
				{
					num2 = num;
				}
			}
		}
		return num2;
	}

	private int __GENERATED_PEG__RULE__property__(int pos, string text, ref Property result)
	{
		char c = '\0';
		Property result2 = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__property__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__property__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__property__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__property__;
		}
		else
		{
			int num = 0;
			int num2 = __GENERATED_PEG__RULE__property_root__(pos, text, ref result2);
			num = ((num2 < 0) ? __GENERATED_PEG__RULE__property_parent__(pos, text, ref result2) : num2);
			int num3 = num;
			__GENERATED_PEG__Memeoize_Pos__property__ = pos;
			__GENERATED_PEG__Memeoize_End__property__ = num3;
			if (num3 >= 0)
			{
				result = result2;
				__GENERATED_PEG__Memeoize_Res__property__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___property__ < pos)
			{
				__GENERATED_PEG__MaxRollback___property__ = pos;
			}
			result3 = num3;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__property_parent__(int pos, string text, ref Property result)
	{
		char c = '\0';
		List<NToken> list = null;
		Identifier result2 = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__property_parent__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__property_parent__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__property_parent__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__property_parent__;
		}
		else
		{
			list = new List<NToken>();
			NToken item = default(NToken);
			int num = pos;
			while (true)
			{
				int num2 = -1;
				int num3 = num;
				if (num3 < text.Length)
				{
					c = text[num3];
					num3++;
					if (c == 'p' && num3 < text.Length)
					{
						c = text[num3];
						num3++;
						if (c == 'a' && num3 < text.Length)
						{
							c = text[num3];
							num3++;
							if (c == 'r' && num3 < text.Length)
							{
								c = text[num3];
								num3++;
								if (c == 'e' && num3 < text.Length)
								{
									c = text[num3];
									num3++;
									if (c == 'n' && num3 < text.Length)
									{
										c = text[num3];
										num3++;
										if (c == 't')
										{
											num2 = num3;
										}
									}
								}
							}
						}
					}
				}
				int num4 = num2;
				if (num4 >= 0)
				{
					item = new NToken(num, num4);
				}
				int num5 = num4;
				int num6 = ((num5 < 0) ? (-1) : __GENERATED_PEG__RULE__DOT__(num5, text));
				if (num6 < 0)
				{
					break;
				}
				list.Add(item);
				num = num6;
			}
			int num7 = num;
			int num9;
			if (num7 >= 0)
			{
				int num8 = __GENERATED_PEG__RULE__identifier__(num7, text, ref result2);
				num9 = ((num8 < 0) ? (-1) : __GENERATED_PEG__RULE__s__(num8, text));
			}
			else
			{
				num9 = -1;
			}
			int num10 = num9;
			__GENERATED_PEG__Memeoize_Pos__property_parent__ = pos;
			__GENERATED_PEG__Memeoize_End__property_parent__ = num10;
			if (num10 >= 0)
			{
				result = property_parent(list, result2);
				__GENERATED_PEG__Memeoize_Res__property_parent__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___property_parent__ < pos)
			{
				__GENERATED_PEG__MaxRollback___property_parent__ = pos;
			}
			result3 = num10;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__identifier__(int pos, string text, ref Identifier result)
	{
		char c = '\0';
		Identifier result2 = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__identifier__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__identifier__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__identifier__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__identifier__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__keyword__(pos, text);
			int num2 = ((num >= 0) ? (-1) : pos);
			int num10;
			if (num2 >= 0)
			{
				int num3 = __GENERATED_PEG__RULE__LSPAREN__(num2, text);
				int num4 = ((num3 < 0) ? num2 : num3);
				if (num4 >= 0)
				{
					int num5 = __GENERATED_PEG__RULE__s__(num4, text);
					if (num5 >= 0)
					{
						int num6 = __GENERATED_PEG__RULE__simple_identifier__(num5, text, ref result2);
						if (num6 >= 0)
						{
							int num7 = __GENERATED_PEG__RULE__s__(num6, text);
							if (num7 >= 0)
							{
								int num8 = __GENERATED_PEG__RULE__RSPAREN__(num7, text);
								int num9 = ((num8 < 0) ? num7 : num8);
								num10 = ((num9 < 0) ? (-1) : __GENERATED_PEG__RULE__s__(num9, text));
							}
							else
							{
								num10 = -1;
							}
						}
						else
						{
							num10 = -1;
						}
					}
					else
					{
						num10 = -1;
					}
				}
				else
				{
					num10 = -1;
				}
			}
			else
			{
				num10 = -1;
			}
			int num11 = num10;
			__GENERATED_PEG__Memeoize_Pos__identifier__ = pos;
			__GENERATED_PEG__Memeoize_End__identifier__ = num11;
			if (num11 >= 0)
			{
				result = result2;
				result.Location = new Location(_parsingSource, result2.StartPos, result2.EndPos);
				__GENERATED_PEG__Memeoize_Res__identifier__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___identifier__ < pos)
			{
				__GENERATED_PEG__MaxRollback___identifier__ = pos;
			}
			result3 = num11;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__keyword__(int pos, string text)
	{
		int num = 0;
		char c = '\0';
		int num2 = 0;
		c = '\0';
		num2 = -1;
		num = pos;
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c != 'f')
			{
				if (c == 't' && num < text.Length)
				{
					c = text[num];
					num++;
					if (c == 'r' && num < text.Length)
					{
						c = text[num];
						num++;
						if (c == 'u')
						{
							goto IL_0131;
						}
					}
				}
			}
			else if (num < text.Length)
			{
				c = text[num];
				num++;
				if (c == 'a' && num < text.Length)
				{
					c = text[num];
					num++;
					if (c == 'l' && num < text.Length)
					{
						c = text[num];
						num++;
						if (c == 's')
						{
							goto IL_0131;
						}
					}
				}
			}
		}
		goto IL_01fc;
		IL_0846:
		num = num2;
		if (num >= 0)
		{
			num = num;
		}
		else
		{
			num = __GENERATED_PEG__RULE__FROM__(pos, text);
			if (num >= 0)
			{
				num = num;
			}
			else
			{
				num = __GENERATED_PEG__RULE__SELECT__(pos, text);
				if (num >= 0)
				{
					num = num;
				}
				else
				{
					num = __GENERATED_PEG__RULE__WHERE__(pos, text);
					if (num >= 0)
					{
						num = num;
					}
					else
					{
						num2 = -1;
						num = pos;
						if (num < text.Length)
						{
							c = text[num];
							num++;
							if (c == 'c' && num < text.Length)
							{
								c = text[num];
								num++;
								if (c == 'o' && num < text.Length)
								{
									c = text[num];
									num++;
									if (c == 'u' && num < text.Length)
									{
										c = text[num];
										num++;
										if (c == 'n' && num < text.Length)
										{
											c = text[num];
											num++;
											if (c == 't')
											{
												num2 = num;
											}
										}
									}
								}
							}
						}
						num = num2;
					}
				}
			}
		}
		goto IL_0a1f;
		IL_01fc:
		num = num2;
		if (num >= 0)
		{
			num = num;
		}
		else
		{
			num = __GENERATED_PEG__RULE__AND__(pos, text);
			if (num >= 0)
			{
				num = num;
			}
			else
			{
				num = __GENERATED_PEG__RULE__OR__(pos, text);
				if (num >= 0)
				{
					num = num;
				}
				else
				{
					num = __GENERATED_PEG__RULE__IN__(pos, text);
					if (num < 0)
					{
						num2 = -1;
						num = pos;
						if (num < text.Length)
						{
							c = text[num];
							num++;
							if (c != 'e')
							{
								if (c != 'i')
								{
									if (c != 'l')
									{
										if (c == 'n' && num < text.Length)
										{
											c = text[num];
											num++;
											if (c == 'u' && num < text.Length)
											{
												c = text[num];
												num++;
												if (c == 'l' && num < text.Length)
												{
													c = text[num];
													num++;
													if (c == 'l')
													{
														goto IL_05d4;
													}
												}
											}
										}
									}
									else if (num < text.Length)
									{
										c = text[num];
										num++;
										if (c == 'i' && num < text.Length)
										{
											c = text[num];
											num++;
											if (c == 'k' && num < text.Length)
											{
												c = text[num];
												num++;
												if (c == 'e')
												{
													goto IL_05d4;
												}
											}
										}
									}
								}
								else if (num < text.Length)
								{
									c = text[num];
									num++;
									if (c == 's')
									{
										goto IL_05d4;
									}
								}
							}
							else if (num < text.Length)
							{
								c = text[num];
								num++;
								if (c == 'm' && num < text.Length)
								{
									c = text[num];
									num++;
									if (c == 'p' && num < text.Length)
									{
										c = text[num];
										num++;
										if (c == 't' && num < text.Length)
										{
											c = text[num];
											num++;
											if (c == 'y')
											{
												goto IL_05d4;
											}
										}
									}
								}
							}
						}
						goto IL_05d9;
					}
					num = num;
				}
			}
		}
		goto IL_0a1f;
		IL_06f7:
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c == 't')
			{
				num2 = num;
			}
		}
		goto IL_0846;
		IL_05d4:
		num2 = num;
		goto IL_05d9;
		IL_0131:
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c == 'e')
			{
				num2 = num;
			}
		}
		goto IL_01fc;
		IL_0a1f:
		num = num;
		int result;
		if (num >= 0)
		{
			num2 = __GENERATED_PEG__RULE__identifierPartCharacters__(num, text);
			result = ((num2 >= 0) ? (-1) : num);
		}
		else
		{
			result = -1;
		}
		return result;
		IL_05d9:
		num = num2;
		if (num >= 0)
		{
			num = num;
		}
		else
		{
			num = __GENERATED_PEG__RULE__NOT__(pos, text);
			if (num < 0)
			{
				num2 = -1;
				num = pos;
				if (num < text.Length)
				{
					c = text[num];
					num++;
					if (c != 'p')
					{
						if (c == 'r' && num < text.Length)
						{
							c = text[num];
							num++;
							if (c == 'o' && num < text.Length)
							{
								c = text[num];
								num++;
								if (c == 'o')
								{
									goto IL_06f7;
								}
							}
						}
					}
					else if (num < text.Length)
					{
						c = text[num];
						num++;
						if (c == 'a' && num < text.Length)
						{
							c = text[num];
							num++;
							if (c == 'r' && num < text.Length)
							{
								c = text[num];
								num++;
								if (c == 'e' && num < text.Length)
								{
									c = text[num];
									num++;
									if (c == 'n')
									{
										goto IL_06f7;
									}
								}
							}
						}
					}
				}
				goto IL_0846;
			}
			num = num;
		}
		goto IL_0a1f;
	}

	private int __GENERATED_PEG__RULE__WHERE__(int pos, string text)
	{
		int num = 0;
		char c = '\0';
		int num2 = 0;
		c = '\0';
		num2 = -1;
		num = pos;
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c == 'w' && num < text.Length)
			{
				c = text[num];
				num++;
				if (c == 'h' && num < text.Length)
				{
					c = text[num];
					num++;
					if (c == 'e' && num < text.Length)
					{
						c = text[num];
						num++;
						if (c == 'r' && num < text.Length)
						{
							c = text[num];
							num++;
							if (c == 'e')
							{
								num2 = num;
							}
						}
					}
				}
			}
		}
		return num2;
	}

	private int __GENERATED_PEG__RULE__SELECT__(int pos, string text)
	{
		int num = 0;
		char c = '\0';
		int num2 = 0;
		c = '\0';
		num2 = -1;
		num = pos;
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c == 's' && num < text.Length)
			{
				c = text[num];
				num++;
				if (c == 'e' && num < text.Length)
				{
					c = text[num];
					num++;
					if (c == 'l' && num < text.Length)
					{
						c = text[num];
						num++;
						if (c == 'e' && num < text.Length)
						{
							c = text[num];
							num++;
							if (c == 'c' && num < text.Length)
							{
								c = text[num];
								num++;
								if (c == 't')
								{
									num2 = num;
								}
							}
						}
					}
				}
			}
		}
		return num2;
	}

	private int __GENERATED_PEG__RULE__FROM__(int pos, string text)
	{
		int num = 0;
		char c = '\0';
		int num2 = 0;
		c = '\0';
		num2 = -1;
		num = pos;
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c == 'f' && num < text.Length)
			{
				c = text[num];
				num++;
				if (c == 'r' && num < text.Length)
				{
					c = text[num];
					num++;
					if (c == 'o' && num < text.Length)
					{
						c = text[num];
						num++;
						if (c == 'm')
						{
							num2 = num;
						}
					}
				}
			}
		}
		return num2;
	}

	private int __GENERATED_PEG__RULE__NOT__(int pos, string text)
	{
		int num = 0;
		char c = '\0';
		int num2 = 0;
		c = '\0';
		num2 = -1;
		num = pos;
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c == 'n' && num < text.Length)
			{
				c = text[num];
				num++;
				if (c == 'o' && num < text.Length)
				{
					c = text[num];
					num++;
					if (c == 't')
					{
						num2 = num;
					}
				}
			}
		}
		return num2;
	}

	private int __GENERATED_PEG__RULE__DOT__(int pos, string text)
	{
		int num = 0;
		char c = '\0';
		int num2 = 0;
		c = '\0';
		num2 = -1;
		num = pos;
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c == '.')
			{
				num2 = num;
			}
		}
		return num2;
	}

	private int __GENERATED_PEG__RULE__property_root__(int pos, string text, ref Property result)
	{
		char c = '\0';
		NToken r = default(NToken);
		Identifier result2 = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__property_root__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__property_root__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__property_root__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__property_root__;
		}
		else
		{
			int num = -1;
			int num2 = pos;
			if (num2 < text.Length)
			{
				c = text[num2];
				num2++;
				if (c == 'r' && num2 < text.Length)
				{
					c = text[num2];
					num2++;
					if (c == 'o' && num2 < text.Length)
					{
						c = text[num2];
						num2++;
						if (c == 'o' && num2 < text.Length)
						{
							c = text[num2];
							num2++;
							if (c == 't')
							{
								num = num2;
							}
						}
					}
				}
			}
			int num3 = num;
			if (num3 >= 0)
			{
				r = new NToken(pos, num3);
			}
			int num4 = num3;
			int num7;
			if (num4 >= 0)
			{
				int num5 = __GENERATED_PEG__RULE__DOT__(num4, text);
				if (num5 >= 0)
				{
					int num6 = __GENERATED_PEG__RULE__identifier__(num5, text, ref result2);
					num7 = ((num6 < 0) ? (-1) : __GENERATED_PEG__RULE__s__(num6, text));
				}
				else
				{
					num7 = -1;
				}
			}
			else
			{
				num7 = -1;
			}
			int num8 = num7;
			__GENERATED_PEG__Memeoize_Pos__property_root__ = pos;
			__GENERATED_PEG__Memeoize_End__property_root__ = num8;
			if (num8 >= 0)
			{
				result = property_root(r, result2);
				__GENERATED_PEG__Memeoize_Res__property_root__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___property_root__ < pos)
			{
				__GENERATED_PEG__MaxRollback___property_root__ = pos;
			}
			result3 = num8;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__not_expression__(int pos, string text, ref Expression result)
	{
		char c = '\0';
		Expression result2 = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__not_expression__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__not_expression__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__not_expression__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__not_expression__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__NOT__(pos, text);
			int num3;
			if (num >= 0)
			{
				int num2 = __GENERATED_PEG__RULE__S__(num, text);
				num3 = ((num2 < 0) ? (-1) : __GENERATED_PEG__RULE__expression_comp__(num2, text, ref result2));
			}
			else
			{
				num3 = -1;
			}
			int num4 = num3;
			__GENERATED_PEG__Memeoize_Pos__not_expression__ = pos;
			__GENERATED_PEG__Memeoize_End__not_expression__ = num4;
			if (num4 >= 0)
			{
				result = not_expression(result2);
				__GENERATED_PEG__Memeoize_Res__not_expression__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___not_expression__ < pos)
			{
				__GENERATED_PEG__MaxRollback___not_expression__ = pos;
			}
			result3 = num4;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__expression_inbrackets__(int pos, string text, ref Expression result)
	{
		char c = '\0';
		NToken n_wildcard_ = default(NToken);
		Expression result2 = null;
		NToken n_wildcard_2 = default(NToken);
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__expression_inbrackets__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__expression_inbrackets__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__expression_inbrackets__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__expression_inbrackets__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__LPAREN__(pos, text);
			if (num >= 0)
			{
				n_wildcard_ = new NToken(pos, num);
			}
			int num2 = num;
			int num5;
			if (num2 >= 0)
			{
				int num3 = __GENERATED_PEG__RULE__expression__(num2, text, ref result2);
				if (num3 >= 0)
				{
					int num4 = __GENERATED_PEG__RULE__RPAREN__(num3, text);
					if (num4 >= 0)
					{
						n_wildcard_2 = new NToken(num3, num4);
					}
					num5 = num4;
				}
				else
				{
					num5 = -1;
				}
			}
			else
			{
				num5 = -1;
			}
			int num6 = num5;
			__GENERATED_PEG__Memeoize_Pos__expression_inbrackets__ = pos;
			__GENERATED_PEG__Memeoize_End__expression_inbrackets__ = num6;
			if (num6 >= 0)
			{
				result = expression_inbrackets(n_wildcard_, result2, n_wildcard_2);
				__GENERATED_PEG__Memeoize_Res__expression_inbrackets__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___expression_inbrackets__ < pos)
			{
				__GENERATED_PEG__MaxRollback___expression_inbrackets__ = pos;
			}
			result3 = num6;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__RPAREN__(int pos, string text)
	{
		int num = 0;
		char c = '\0';
		int num2 = 0;
		c = '\0';
		num2 = -1;
		num = pos;
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c == ')')
			{
				num2 = num;
			}
		}
		num = num2;
		return (num < 0) ? (-1) : __GENERATED_PEG__RULE__s__(num, text);
	}

	private int __GENERATED_PEG__RULE__LPAREN__(int pos, string text)
	{
		int num = 0;
		char c = '\0';
		int num2 = 0;
		c = '\0';
		num2 = -1;
		num = pos;
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c == '(')
			{
				num2 = num;
			}
		}
		num = num2;
		return (num < 0) ? (-1) : __GENERATED_PEG__RULE__s__(num, text);
	}

	private int __GENERATED_PEG__RULE__expression_property_in_query_expression__(int pos, string text, ref Expression result)
	{
		char c = '\0';
		Property result2 = null;
		SubqueryExpression result3 = null;
		int result4;
		if (__GENERATED_PEG__Memeoize_Pos__expression_property_in_query_expression__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__expression_property_in_query_expression__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__expression_property_in_query_expression__;
			}
			result4 = __GENERATED_PEG__Memeoize_End__expression_property_in_query_expression__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__property__(pos, text, ref result2);
			int num4;
			if (num >= 0)
			{
				int num2 = __GENERATED_PEG__RULE__IN__(num, text);
				if (num2 >= 0)
				{
					int num3 = __GENERATED_PEG__RULE__S__(num2, text);
					num4 = ((num3 < 0) ? (-1) : __GENERATED_PEG__RULE__query_expression__(num3, text, ref result3));
				}
				else
				{
					num4 = -1;
				}
			}
			else
			{
				num4 = -1;
			}
			int num5 = num4;
			__GENERATED_PEG__Memeoize_Pos__expression_property_in_query_expression__ = pos;
			__GENERATED_PEG__Memeoize_End__expression_property_in_query_expression__ = num5;
			if (num5 >= 0)
			{
				result = expression_property_in_query_expression(result2, result3);
				__GENERATED_PEG__Memeoize_Res__expression_property_in_query_expression__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___expression_property_in_query_expression__ < pos)
			{
				__GENERATED_PEG__MaxRollback___expression_property_in_query_expression__ = pos;
			}
			result4 = num5;
		}
		return result4;
	}

	private int __GENERATED_PEG__RULE__query_expression__(int pos, string text, ref SubqueryExpression result)
	{
		char c = '\0';
		NToken n_wildcard_ = default(NToken);
		SubqueryExpression result2 = null;
		NToken r = default(NToken);
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__query_expression__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__query_expression__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__query_expression__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__query_expression__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__LPAREN__(pos, text);
			if (num >= 0)
			{
				n_wildcard_ = new NToken(pos, num);
			}
			int num2 = num;
			int num7;
			if (num2 >= 0)
			{
				int num3 = 0;
				int num4 = __GENERATED_PEG__RULE__query_exp_from_first__(num2, text, ref result2);
				num3 = ((num4 < 0) ? __GENERATED_PEG__RULE__query_exp_from_second__(num2, text, ref result2) : num4);
				int num5 = num3;
				if (num5 >= 0)
				{
					int num6 = __GENERATED_PEG__RULE__RPAREN__(num5, text);
					if (num6 >= 0)
					{
						r = new NToken(num5, num6);
					}
					num7 = num6;
				}
				else
				{
					num7 = -1;
				}
			}
			else
			{
				num7 = -1;
			}
			int num8 = num7;
			__GENERATED_PEG__Memeoize_Pos__query_expression__ = pos;
			__GENERATED_PEG__Memeoize_End__query_expression__ = num8;
			if (num8 >= 0)
			{
				result = query_expression(n_wildcard_, result2, r);
				__GENERATED_PEG__Memeoize_Res__query_expression__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___query_expression__ < pos)
			{
				__GENERATED_PEG__MaxRollback___query_expression__ = pos;
			}
			result3 = num8;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__query_exp_from_second__(int pos, string text, ref SubqueryExpression result)
	{
		char c = '\0';
		Identifier result2 = null;
		Identifier result3 = null;
		Expression result4 = null;
		int result5;
		if (__GENERATED_PEG__Memeoize_Pos__query_exp_from_second__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__query_exp_from_second__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__query_exp_from_second__;
			}
			result5 = __GENERATED_PEG__Memeoize_End__query_exp_from_second__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__SELECT__(pos, text);
			int num9;
			if (num >= 0)
			{
				int num2 = __GENERATED_PEG__RULE__S__(num, text);
				if (num2 >= 0)
				{
					int num3 = __GENERATED_PEG__RULE__identifier__(num2, text, ref result2);
					if (num3 >= 0)
					{
						int num4 = __GENERATED_PEG__RULE__FROM__(num3, text);
						if (num4 >= 0)
						{
							int num5 = __GENERATED_PEG__RULE__S__(num4, text);
							if (num5 >= 0)
							{
								int num6 = __GENERATED_PEG__RULE__identifier__(num5, text, ref result3);
								if (num6 >= 0)
								{
									int num7 = __GENERATED_PEG__RULE__WHERE__(num6, text);
									if (num7 >= 0)
									{
										int num8 = __GENERATED_PEG__RULE__S__(num7, text);
										num9 = ((num8 < 0) ? (-1) : __GENERATED_PEG__RULE__expression__(num8, text, ref result4));
									}
									else
									{
										num9 = -1;
									}
								}
								else
								{
									num9 = -1;
								}
							}
							else
							{
								num9 = -1;
							}
						}
						else
						{
							num9 = -1;
						}
					}
					else
					{
						num9 = -1;
					}
				}
				else
				{
					num9 = -1;
				}
			}
			else
			{
				num9 = -1;
			}
			int num10 = num9;
			__GENERATED_PEG__Memeoize_Pos__query_exp_from_second__ = pos;
			__GENERATED_PEG__Memeoize_End__query_exp_from_second__ = num10;
			if (num10 >= 0)
			{
				result = query_exp_from_second(result2, result3, result4);
				__GENERATED_PEG__Memeoize_Res__query_exp_from_second__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___query_exp_from_second__ < pos)
			{
				__GENERATED_PEG__MaxRollback___query_exp_from_second__ = pos;
			}
			result5 = num10;
		}
		return result5;
	}

	private int __GENERATED_PEG__RULE__query_exp_from_first__(int pos, string text, ref SubqueryExpression result)
	{
		char c = '\0';
		Identifier result2 = null;
		Identifier result3 = null;
		Expression result4 = null;
		int result5;
		if (__GENERATED_PEG__Memeoize_Pos__query_exp_from_first__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__query_exp_from_first__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__query_exp_from_first__;
			}
			result5 = __GENERATED_PEG__Memeoize_End__query_exp_from_first__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__FROM__(pos, text);
			int num9;
			if (num >= 0)
			{
				int num2 = __GENERATED_PEG__RULE__S__(num, text);
				if (num2 >= 0)
				{
					int num3 = __GENERATED_PEG__RULE__identifier__(num2, text, ref result2);
					if (num3 >= 0)
					{
						int num4 = __GENERATED_PEG__RULE__SELECT__(num3, text);
						if (num4 >= 0)
						{
							int num5 = __GENERATED_PEG__RULE__S__(num4, text);
							if (num5 >= 0)
							{
								int num6 = __GENERATED_PEG__RULE__identifier__(num5, text, ref result3);
								if (num6 >= 0)
								{
									int num7 = __GENERATED_PEG__RULE__WHERE__(num6, text);
									if (num7 >= 0)
									{
										int num8 = __GENERATED_PEG__RULE__S__(num7, text);
										num9 = ((num8 < 0) ? (-1) : __GENERATED_PEG__RULE__expression__(num8, text, ref result4));
									}
									else
									{
										num9 = -1;
									}
								}
								else
								{
									num9 = -1;
								}
							}
							else
							{
								num9 = -1;
							}
						}
						else
						{
							num9 = -1;
						}
					}
					else
					{
						num9 = -1;
					}
				}
				else
				{
					num9 = -1;
				}
			}
			else
			{
				num9 = -1;
			}
			int num10 = num9;
			__GENERATED_PEG__Memeoize_Pos__query_exp_from_first__ = pos;
			__GENERATED_PEG__Memeoize_End__query_exp_from_first__ = num10;
			if (num10 >= 0)
			{
				result = query_exp_from_first(result2, result3, result4);
				__GENERATED_PEG__Memeoize_Res__query_exp_from_first__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___query_exp_from_first__ < pos)
			{
				__GENERATED_PEG__MaxRollback___query_exp_from_first__ = pos;
			}
			result5 = num10;
		}
		return result5;
	}

	private int __GENERATED_PEG__RULE__expression_property_in_function__(int pos, string text, ref Expression result)
	{
		char c = '\0';
		Property result2 = null;
		InFunction result3 = null;
		int result4;
		if (__GENERATED_PEG__Memeoize_Pos__expression_property_in_function__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__expression_property_in_function__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__expression_property_in_function__;
			}
			result4 = __GENERATED_PEG__Memeoize_End__expression_property_in_function__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__property__(pos, text, ref result2);
			int num4;
			if (num >= 0)
			{
				int num2 = __GENERATED_PEG__RULE__IN__(num, text);
				if (num2 >= 0)
				{
					int num3 = __GENERATED_PEG__RULE__S__(num2, text);
					num4 = ((num3 < 0) ? (-1) : __GENERATED_PEG__RULE__inFunction__(num3, text, ref result3));
				}
				else
				{
					num4 = -1;
				}
			}
			else
			{
				num4 = -1;
			}
			int num5 = num4;
			__GENERATED_PEG__Memeoize_Pos__expression_property_in_function__ = pos;
			__GENERATED_PEG__Memeoize_End__expression_property_in_function__ = num5;
			if (num5 >= 0)
			{
				result = expression_property_in_function(result2, result3);
				__GENERATED_PEG__Memeoize_Res__expression_property_in_function__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___expression_property_in_function__ < pos)
			{
				__GENERATED_PEG__MaxRollback___expression_property_in_function__ = pos;
			}
			result4 = num5;
		}
		return result4;
	}

	private int __GENERATED_PEG__RULE__inFunction__(int pos, string text, ref InFunction result)
	{
		char c = '\0';
		InFunction result2 = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__inFunction__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__inFunction__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__inFunction__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__inFunction__;
		}
		else
		{
			int num = 0;
			int num2 = __GENERATED_PEG__RULE__in_func_1__(pos, text, ref result2);
			num = ((num2 < 0) ? __GENERATED_PEG__RULE__in_func_2__(pos, text, ref result2) : num2);
			int num3 = num;
			__GENERATED_PEG__Memeoize_Pos__inFunction__ = pos;
			__GENERATED_PEG__Memeoize_End__inFunction__ = num3;
			if (num3 >= 0)
			{
				result = result2;
				__GENERATED_PEG__Memeoize_Res__inFunction__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___inFunction__ < pos)
			{
				__GENERATED_PEG__MaxRollback___inFunction__ = pos;
			}
			result3 = num3;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__in_func_2__(int pos, string text, ref InFunction result)
	{
		char c = '\0';
		Identifier result2 = null;
		ExpressionCollection result3 = null;
		int result4;
		if (__GENERATED_PEG__Memeoize_Pos__in_func_2__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__in_func_2__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__in_func_2__;
			}
			result4 = __GENERATED_PEG__Memeoize_End__in_func_2__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__identifier__(pos, text, ref result2);
			int num2 = ((num < 0) ? (-1) : __GENERATED_PEG__RULE__atom_collection__(num, text, ref result3));
			__GENERATED_PEG__Memeoize_Pos__in_func_2__ = pos;
			__GENERATED_PEG__Memeoize_End__in_func_2__ = num2;
			if (num2 >= 0)
			{
				result = in_func_2(result2, result3);
				__GENERATED_PEG__Memeoize_Res__in_func_2__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___in_func_2__ < pos)
			{
				__GENERATED_PEG__MaxRollback___in_func_2__ = pos;
			}
			result4 = num2;
		}
		return result4;
	}

	private int __GENERATED_PEG__RULE__atom_collection__(int pos, string text, ref ExpressionCollection result)
	{
		char c = '\0';
		NToken l = default(NToken);
		Expression result2 = null;
		List<Expression> list = null;
		NToken r = default(NToken);
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__atom_collection__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__atom_collection__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__atom_collection__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__atom_collection__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__LPAREN__(pos, text);
			if (num >= 0)
			{
				l = new NToken(pos, num);
			}
			int num2 = num;
			int num9;
			if (num2 >= 0)
			{
				int num3 = __GENERATED_PEG__RULE__constant__(num2, text, ref result2);
				if (num3 >= 0)
				{
					list = new List<Expression>();
					Expression result4 = null;
					int num4 = num3;
					while (true)
					{
						int num5 = __GENERATED_PEG__RULE__COMMA__(num4, text);
						int num6 = ((num5 < 0) ? (-1) : __GENERATED_PEG__RULE__constant__(num5, text, ref result4));
						if (num6 < 0)
						{
							break;
						}
						list.Add(result4);
						num4 = num6;
					}
					int num7 = num4;
					if (num7 >= 0)
					{
						int num8 = __GENERATED_PEG__RULE__RPAREN__(num7, text);
						if (num8 >= 0)
						{
							r = new NToken(num7, num8);
						}
						num9 = num8;
					}
					else
					{
						num9 = -1;
					}
				}
				else
				{
					num9 = -1;
				}
			}
			else
			{
				num9 = -1;
			}
			int num10 = num9;
			__GENERATED_PEG__Memeoize_Pos__atom_collection__ = pos;
			__GENERATED_PEG__Memeoize_End__atom_collection__ = num10;
			if (num10 >= 0)
			{
				result = atom_collection(l, result2, list, r);
				__GENERATED_PEG__Memeoize_Res__atom_collection__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___atom_collection__ < pos)
			{
				__GENERATED_PEG__MaxRollback___atom_collection__ = pos;
			}
			result3 = num10;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__COMMA__(int pos, string text)
	{
		int num = 0;
		char c = '\0';
		int num2 = 0;
		c = '\0';
		num2 = -1;
		num = pos;
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c == ',')
			{
				num2 = num;
			}
		}
		num = num2;
		return (num < 0) ? (-1) : __GENERATED_PEG__RULE__s__(num, text);
	}

	private int __GENERATED_PEG__RULE__constant__(int pos, string text, ref Expression result)
	{
		char c = '\0';
		Constant result2 = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__constant__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__constant__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__constant__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__constant__;
		}
		else
		{
			int num = 0;
			int num2 = __GENERATED_PEG__RULE__number__(pos, text, ref result2);
			if (num2 >= 0)
			{
				num = num2;
			}
			else
			{
				int num3 = __GENERATED_PEG__RULE__character_string__(pos, text, ref result2);
				if (num3 >= 0)
				{
					num = num3;
				}
				else
				{
					int num4 = __GENERATED_PEG__RULE__parameter__(pos, text, ref result2);
					if (num4 >= 0)
					{
						num = num4;
					}
					else
					{
						int num5 = __GENERATED_PEG__RULE__const_true__(pos, text, ref result2);
						if (num5 >= 0)
						{
							num = num5;
						}
						else
						{
							int num6 = __GENERATED_PEG__RULE__const_false__(pos, text, ref result2);
							if (num6 >= 0)
							{
								num = num6;
							}
							else
							{
								int num7 = __GENERATED_PEG__RULE__function_const__(pos, text, ref result2);
								if (num7 >= 0)
								{
									num = num7;
								}
								else
								{
									int num8 = __GENERATED_PEG__RULE__const_null__(pos, text, ref result2);
									num = ((num8 < 0) ? __GENERATED_PEG__RULE__const_empty__(pos, text, ref result2) : num8);
								}
							}
						}
					}
				}
			}
			int num9 = num;
			__GENERATED_PEG__Memeoize_Pos__constant__ = pos;
			__GENERATED_PEG__Memeoize_End__constant__ = num9;
			if (num9 >= 0)
			{
				result = constant(result2);
				__GENERATED_PEG__Memeoize_Res__constant__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___constant__ < pos)
			{
				__GENERATED_PEG__MaxRollback___constant__ = pos;
			}
			result3 = num9;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__const_empty__(int pos, string text, ref Constant result)
	{
		char c = '\0';
		NToken nl = default(NToken);
		int result2;
		if (__GENERATED_PEG__Memeoize_Pos__const_empty__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__const_empty__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__const_empty__;
			}
			result2 = __GENERATED_PEG__Memeoize_End__const_empty__;
		}
		else
		{
			int num = -1;
			int num2 = pos;
			if (num2 < text.Length)
			{
				c = text[num2];
				num2++;
				if (c == 'e' && num2 < text.Length)
				{
					c = text[num2];
					num2++;
					if (c == 'm' && num2 < text.Length)
					{
						c = text[num2];
						num2++;
						if (c == 'p' && num2 < text.Length)
						{
							c = text[num2];
							num2++;
							if (c == 't' && num2 < text.Length)
							{
								c = text[num2];
								num2++;
								if (c == 'y')
								{
									num = num2;
								}
							}
						}
					}
				}
			}
			int num3 = num;
			if (num3 >= 0)
			{
				nl = new NToken(pos, num3);
			}
			int num4 = num3;
			int num5 = ((num4 < 0) ? (-1) : __GENERATED_PEG__RULE__S__(num4, text));
			__GENERATED_PEG__Memeoize_Pos__const_empty__ = pos;
			__GENERATED_PEG__Memeoize_End__const_empty__ = num5;
			if (num5 >= 0)
			{
				result = const_empty(nl);
				__GENERATED_PEG__Memeoize_Res__const_empty__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___const_empty__ < pos)
			{
				__GENERATED_PEG__MaxRollback___const_empty__ = pos;
			}
			result2 = num5;
		}
		return result2;
	}

	private int __GENERATED_PEG__RULE__const_null__(int pos, string text, ref Constant result)
	{
		char c = '\0';
		NToken nl = default(NToken);
		int result2;
		if (__GENERATED_PEG__Memeoize_Pos__const_null__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__const_null__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__const_null__;
			}
			result2 = __GENERATED_PEG__Memeoize_End__const_null__;
		}
		else
		{
			int num = -1;
			int num2 = pos;
			if (num2 < text.Length)
			{
				c = text[num2];
				num2++;
				if (c == 'n' && num2 < text.Length)
				{
					c = text[num2];
					num2++;
					if (c == 'u' && num2 < text.Length)
					{
						c = text[num2];
						num2++;
						if (c == 'l' && num2 < text.Length)
						{
							c = text[num2];
							num2++;
							if (c == 'l')
							{
								num = num2;
							}
						}
					}
				}
			}
			int num3 = num;
			if (num3 >= 0)
			{
				nl = new NToken(pos, num3);
			}
			int num4 = num3;
			int num5 = ((num4 < 0) ? (-1) : __GENERATED_PEG__RULE__S__(num4, text));
			__GENERATED_PEG__Memeoize_Pos__const_null__ = pos;
			__GENERATED_PEG__Memeoize_End__const_null__ = num5;
			if (num5 >= 0)
			{
				result = const_null(nl);
				__GENERATED_PEG__Memeoize_Res__const_null__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___const_null__ < pos)
			{
				__GENERATED_PEG__MaxRollback___const_null__ = pos;
			}
			result2 = num5;
		}
		return result2;
	}

	private int __GENERATED_PEG__RULE__function_const__(int pos, string text, ref Constant result)
	{
		char c = '\0';
		ConstantFunction result2 = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__function_const__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__function_const__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__function_const__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__function_const__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__constant_function__(pos, text, ref result2);
			__GENERATED_PEG__Memeoize_Pos__function_const__ = pos;
			__GENERATED_PEG__Memeoize_End__function_const__ = num;
			if (num >= 0)
			{
				result = function_const(result2);
				__GENERATED_PEG__Memeoize_Res__function_const__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___function_const__ < pos)
			{
				__GENERATED_PEG__MaxRollback___function_const__ = pos;
			}
			result3 = num;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__constant_function__(int pos, string text, ref ConstantFunction result)
	{
		char c = '\0';
		ConstantFunction result2 = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__constant_function__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__constant_function__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__constant_function__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__constant_function__;
		}
		else
		{
			int num = 0;
			int num2 = __GENERATED_PEG__RULE__const_func_1__(pos, text, ref result2);
			num = ((num2 < 0) ? __GENERATED_PEG__RULE__const_func_2__(pos, text, ref result2) : num2);
			int num3 = num;
			__GENERATED_PEG__Memeoize_Pos__constant_function__ = pos;
			__GENERATED_PEG__Memeoize_End__constant_function__ = num3;
			if (num3 >= 0)
			{
				result = result2;
				__GENERATED_PEG__Memeoize_Res__constant_function__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___constant_function__ < pos)
			{
				__GENERATED_PEG__MaxRollback___constant_function__ = pos;
			}
			result3 = num3;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__const_func_2__(int pos, string text, ref ConstantFunction result)
	{
		char c = '\0';
		Identifier result2 = null;
		ExpressionCollection result3 = null;
		int result4;
		if (__GENERATED_PEG__Memeoize_Pos__const_func_2__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__const_func_2__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__const_func_2__;
			}
			result4 = __GENERATED_PEG__Memeoize_End__const_func_2__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__identifier__(pos, text, ref result2);
			int num2 = ((num < 0) ? (-1) : __GENERATED_PEG__RULE__atom_collection__(num, text, ref result3));
			__GENERATED_PEG__Memeoize_Pos__const_func_2__ = pos;
			__GENERATED_PEG__Memeoize_End__const_func_2__ = num2;
			if (num2 >= 0)
			{
				result = const_func_2(result2, result3);
				__GENERATED_PEG__Memeoize_Res__const_func_2__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___const_func_2__ < pos)
			{
				__GENERATED_PEG__MaxRollback___const_func_2__ = pos;
			}
			result4 = num2;
		}
		return result4;
	}

	private int __GENERATED_PEG__RULE__const_func_1__(int pos, string text, ref ConstantFunction result)
	{
		char c = '\0';
		Identifier result2 = null;
		NToken l = default(NToken);
		NToken r = default(NToken);
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__const_func_1__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__const_func_1__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__const_func_1__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__const_func_1__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__identifier__(pos, text, ref result2);
			int num5;
			if (num >= 0)
			{
				int num2 = __GENERATED_PEG__RULE__LPAREN__(num, text);
				if (num2 >= 0)
				{
					l = new NToken(num, num2);
				}
				int num3 = num2;
				if (num3 >= 0)
				{
					int num4 = __GENERATED_PEG__RULE__RPAREN__(num3, text);
					if (num4 >= 0)
					{
						r = new NToken(num3, num4);
					}
					num5 = num4;
				}
				else
				{
					num5 = -1;
				}
			}
			else
			{
				num5 = -1;
			}
			int num6 = num5;
			__GENERATED_PEG__Memeoize_Pos__const_func_1__ = pos;
			__GENERATED_PEG__Memeoize_End__const_func_1__ = num6;
			if (num6 >= 0)
			{
				result = const_func_1(result2, l, r);
				__GENERATED_PEG__Memeoize_Res__const_func_1__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___const_func_1__ < pos)
			{
				__GENERATED_PEG__MaxRollback___const_func_1__ = pos;
			}
			result3 = num6;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__const_false__(int pos, string text, ref Constant result)
	{
		char c = '\0';
		NToken bf = default(NToken);
		int result2;
		if (__GENERATED_PEG__Memeoize_Pos__const_false__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__const_false__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__const_false__;
			}
			result2 = __GENERATED_PEG__Memeoize_End__const_false__;
		}
		else
		{
			int num = -1;
			int num2 = pos;
			if (num2 < text.Length)
			{
				c = text[num2];
				num2++;
				if (c == 'f' && num2 < text.Length)
				{
					c = text[num2];
					num2++;
					if (c == 'a' && num2 < text.Length)
					{
						c = text[num2];
						num2++;
						if (c == 'l' && num2 < text.Length)
						{
							c = text[num2];
							num2++;
							if (c == 's' && num2 < text.Length)
							{
								c = text[num2];
								num2++;
								if (c == 'e')
								{
									num = num2;
								}
							}
						}
					}
				}
			}
			int num3 = num;
			if (num3 >= 0)
			{
				bf = new NToken(pos, num3);
			}
			int num4 = num3;
			int num5 = ((num4 < 0) ? (-1) : __GENERATED_PEG__RULE__S__(num4, text));
			__GENERATED_PEG__Memeoize_Pos__const_false__ = pos;
			__GENERATED_PEG__Memeoize_End__const_false__ = num5;
			if (num5 >= 0)
			{
				result = const_false(bf);
				__GENERATED_PEG__Memeoize_Res__const_false__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___const_false__ < pos)
			{
				__GENERATED_PEG__MaxRollback___const_false__ = pos;
			}
			result2 = num5;
		}
		return result2;
	}

	private int __GENERATED_PEG__RULE__const_true__(int pos, string text, ref Constant result)
	{
		char c = '\0';
		NToken bt = default(NToken);
		int result2;
		if (__GENERATED_PEG__Memeoize_Pos__const_true__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__const_true__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__const_true__;
			}
			result2 = __GENERATED_PEG__Memeoize_End__const_true__;
		}
		else
		{
			int num = -1;
			int num2 = pos;
			if (num2 < text.Length)
			{
				c = text[num2];
				num2++;
				if (c == 't' && num2 < text.Length)
				{
					c = text[num2];
					num2++;
					if (c == 'r' && num2 < text.Length)
					{
						c = text[num2];
						num2++;
						if (c == 'u' && num2 < text.Length)
						{
							c = text[num2];
							num2++;
							if (c == 'e')
							{
								num = num2;
							}
						}
					}
				}
			}
			int num3 = num;
			if (num3 >= 0)
			{
				bt = new NToken(pos, num3);
			}
			int num4 = num3;
			int num5 = ((num4 < 0) ? (-1) : __GENERATED_PEG__RULE__S__(num4, text));
			__GENERATED_PEG__Memeoize_Pos__const_true__ = pos;
			__GENERATED_PEG__Memeoize_End__const_true__ = num5;
			if (num5 >= 0)
			{
				result = const_true(bt);
				__GENERATED_PEG__Memeoize_Res__const_true__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___const_true__ < pos)
			{
				__GENERATED_PEG__MaxRollback___const_true__ = pos;
			}
			result2 = num5;
		}
		return result2;
	}

	private int __GENERATED_PEG__RULE__character_string__(int pos, string text, ref Constant result)
	{
		char c = '\0';
		NToken val = default(NToken);
		int result2;
		if (__GENERATED_PEG__Memeoize_Pos__character_string__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__character_string__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__character_string__;
			}
			result2 = __GENERATED_PEG__Memeoize_End__character_string__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__CHARACTER_STRING__(pos, text);
			if (num >= 0)
			{
				val = new NToken(pos, num);
			}
			int num2 = num;
			int num3 = ((num2 < 0) ? (-1) : __GENERATED_PEG__RULE__S__(num2, text));
			__GENERATED_PEG__Memeoize_Pos__character_string__ = pos;
			__GENERATED_PEG__Memeoize_End__character_string__ = num3;
			if (num3 >= 0)
			{
				result = character_string(val);
				__GENERATED_PEG__Memeoize_Res__character_string__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___character_string__ < pos)
			{
				__GENERATED_PEG__MaxRollback___character_string__ = pos;
			}
			result2 = num3;
		}
		return result2;
	}

	private int __GENERATED_PEG__RULE__CHARACTER_STRING__(int pos, string text)
	{
		int num = 0;
		char c = '\0';
		int num2 = 0;
		c = '\0';
		int num3 = -1;
		num = pos;
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c >= '\'' && ((c >= '‘') ? (c <= '’') : ((c < '`') ? (c <= '\'') : (c <= '`'))))
			{
				num3 = num;
			}
		}
		num = num3;
		int result;
		if (num >= 0)
		{
			num3 = num;
			while (true)
			{
				num2 = -1;
				num = num3;
				if (num < text.Length)
				{
					c = text[num];
					num++;
					if (c != '\'')
					{
						if (c != '`')
						{
							if (c != '‘')
							{
								if (c == '’' && num < text.Length)
								{
									c = text[num];
									num++;
									if (c == '’')
									{
										goto IL_0272;
									}
								}
							}
							else if (num < text.Length)
							{
								c = text[num];
								num++;
								if (c == '‘')
								{
									goto IL_0272;
								}
							}
						}
						else if (num < text.Length)
						{
							c = text[num];
							num++;
							if (c == '`')
							{
								goto IL_0272;
							}
						}
					}
					else if (num < text.Length)
					{
						c = text[num];
						num++;
						if (c == '\'')
						{
							goto IL_0272;
						}
					}
				}
				goto IL_0277;
				IL_0277:
				num = num2;
				if (num >= 0)
				{
					num = num;
				}
				else
				{
					num2 = -1;
					num = num3;
					if (num < text.Length)
					{
						c = text[num];
						num++;
						if (c >= '\'' && ((c >= '‘') ? (c <= '’') : ((c < '`') ? (c <= '\'') : (c <= '`'))))
						{
							num2 = num;
						}
					}
					num = num2;
					num = ((num >= 0) ? (-1) : num3);
					int num4;
					if (num >= 0)
					{
						num2 = -1;
						num = num;
						if (num < text.Length)
						{
							c = text[num];
							num++;
							if (0 == 0)
							{
								num2 = num;
							}
						}
						num4 = num2;
					}
					else
					{
						num4 = -1;
					}
					num = num4;
				}
				num = num;
				if (num < 0)
				{
					break;
				}
				num3 = num;
				continue;
				IL_0272:
				num2 = num;
				goto IL_0277;
			}
			num = num3;
			if (num >= 0)
			{
				num3 = -1;
				num = num;
				if (num < text.Length)
				{
					c = text[num];
					num++;
					if (c >= '\'' && ((c >= '‘') ? (c <= '’') : ((c < '`') ? (c <= '\'') : (c <= '`'))))
					{
						num3 = num;
					}
				}
				result = num3;
			}
			else
			{
				result = -1;
			}
		}
		else
		{
			result = -1;
		}
		return result;
	}

	private int __GENERATED_PEG__RULE__number__(int pos, string text, ref Constant result)
	{
		char c = '\0';
		NToken m = default(NToken);
		Literal result2 = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__number__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__number__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__number__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__number__;
		}
		else
		{
			int num = -1;
			int num2 = pos;
			num = num2;
			if (num2 < text.Length)
			{
				c = text[num2];
				num2++;
				if (c == '-')
				{
					num = num2;
				}
			}
			int num3 = num;
			if (num3 >= 0)
			{
				m = new NToken(pos, num3);
			}
			int num4 = num3;
			int num8;
			if (num4 >= 0)
			{
				int num5 = 0;
				int num6 = __GENERATED_PEG__RULE__realLiteral__(num4, text, ref result2);
				num5 = ((num6 < 0) ? __GENERATED_PEG__RULE__integerLiteral__(num4, text, ref result2) : num6);
				int num7 = num5;
				num8 = ((num7 < 0) ? (-1) : __GENERATED_PEG__RULE__S__(num7, text));
			}
			else
			{
				num8 = -1;
			}
			int num9 = num8;
			__GENERATED_PEG__Memeoize_Pos__number__ = pos;
			__GENERATED_PEG__Memeoize_End__number__ = num9;
			if (num9 >= 0)
			{
				result = number(m, result2);
				__GENERATED_PEG__Memeoize_Res__number__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___number__ < pos)
			{
				__GENERATED_PEG__MaxRollback___number__ = pos;
			}
			result3 = num9;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__integerLiteral__(int pos, string text, ref Literal result)
	{
		char c = '\0';
		NToken decimalDigits = default(NToken);
		int result2;
		if (__GENERATED_PEG__Memeoize_Pos__integerLiteral__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__integerLiteral__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__integerLiteral__;
			}
			result2 = __GENERATED_PEG__Memeoize_End__integerLiteral__;
		}
		else
		{
			int num = 0;
			int num2 = pos;
			while (true)
			{
				int num3 = __GENERATED_PEG__RULE__digit__(num2, text);
				if (num3 < 0)
				{
					break;
				}
				int num4 = num + 1;
				num2 = num3;
				num = num4;
			}
			int num5 = ((num < 1) ? (-1) : num2);
			if (num5 >= 0)
			{
				decimalDigits = new NToken(pos, num5);
			}
			int num6 = num5;
			__GENERATED_PEG__Memeoize_Pos__integerLiteral__ = pos;
			__GENERATED_PEG__Memeoize_End__integerLiteral__ = num6;
			if (num6 >= 0)
			{
				result = integerLiteral(decimalDigits);
				result.Location = new Location(_parsingSource, decimalDigits.StartPos, decimalDigits.EndPos);
				__GENERATED_PEG__Memeoize_Res__integerLiteral__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___integerLiteral__ < pos)
			{
				__GENERATED_PEG__MaxRollback___integerLiteral__ = pos;
			}
			result2 = num6;
		}
		return result2;
	}

	private int __GENERATED_PEG__RULE__realLiteral__(int pos, string text, ref Literal result)
	{
		char c = '\0';
		NToken mantissa = default(NToken);
		NToken mantissa2 = default(NToken);
		int result2;
		if (__GENERATED_PEG__Memeoize_Pos__realLiteral__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__realLiteral__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__realLiteral__;
			}
			result2 = __GENERATED_PEG__Memeoize_End__realLiteral__;
		}
		else
		{
			int num = 0;
			int num2 = pos;
			while (true)
			{
				int num3 = __GENERATED_PEG__RULE__digit__(num2, text);
				if (num3 < 0)
				{
					break;
				}
				int num4 = num + 1;
				num2 = num3;
				num = num4;
			}
			int num5 = ((num < 1) ? (-1) : num2);
			if (num5 >= 0)
			{
				mantissa = new NToken(pos, num5);
			}
			int num6 = num5;
			int num13;
			if (num6 >= 0)
			{
				int num7 = __GENERATED_PEG__RULE__DOT__(num6, text);
				if (num7 >= 0)
				{
					int num8 = 0;
					int num9 = num7;
					while (true)
					{
						int num10 = __GENERATED_PEG__RULE__digit__(num9, text);
						if (num10 < 0)
						{
							break;
						}
						int num11 = num8 + 1;
						num9 = num10;
						num8 = num11;
					}
					int num12 = ((num8 < 1) ? (-1) : num9);
					if (num12 >= 0)
					{
						mantissa2 = new NToken(num7, num12);
					}
					num13 = num12;
				}
				else
				{
					num13 = -1;
				}
			}
			else
			{
				num13 = -1;
			}
			int num14 = num13;
			__GENERATED_PEG__Memeoize_Pos__realLiteral__ = pos;
			__GENERATED_PEG__Memeoize_End__realLiteral__ = num14;
			if (num14 >= 0)
			{
				result = realLiteral(mantissa, mantissa2);
				result.Location = new Location(_parsingSource, mantissa.StartPos, mantissa2.EndPos);
				__GENERATED_PEG__Memeoize_Res__realLiteral__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___realLiteral__ < pos)
			{
				__GENERATED_PEG__MaxRollback___realLiteral__ = pos;
			}
			result2 = num14;
		}
		return result2;
	}

	private int __GENERATED_PEG__RULE__in_func_1__(int pos, string text, ref InFunction result)
	{
		char c = '\0';
		Identifier result2 = null;
		NToken l = default(NToken);
		NToken r = default(NToken);
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__in_func_1__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__in_func_1__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__in_func_1__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__in_func_1__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__identifier__(pos, text, ref result2);
			int num5;
			if (num >= 0)
			{
				int num2 = __GENERATED_PEG__RULE__LPAREN__(num, text);
				if (num2 >= 0)
				{
					l = new NToken(num, num2);
				}
				int num3 = num2;
				if (num3 >= 0)
				{
					int num4 = __GENERATED_PEG__RULE__RPAREN__(num3, text);
					if (num4 >= 0)
					{
						r = new NToken(num3, num4);
					}
					num5 = num4;
				}
				else
				{
					num5 = -1;
				}
			}
			else
			{
				num5 = -1;
			}
			int num6 = num5;
			__GENERATED_PEG__Memeoize_Pos__in_func_1__ = pos;
			__GENERATED_PEG__Memeoize_End__in_func_1__ = num6;
			if (num6 >= 0)
			{
				result = in_func_1(result2, l, r);
				__GENERATED_PEG__Memeoize_Res__in_func_1__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___in_func_1__ < pos)
			{
				__GENERATED_PEG__MaxRollback___in_func_1__ = pos;
			}
			result3 = num6;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__expression_property_in_comma_expression__(int pos, string text, ref Expression result)
	{
		char c = '\0';
		Property result2 = null;
		InExpression result3 = null;
		int result4;
		if (__GENERATED_PEG__Memeoize_Pos__expression_property_in_comma_expression__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__expression_property_in_comma_expression__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__expression_property_in_comma_expression__;
			}
			result4 = __GENERATED_PEG__Memeoize_End__expression_property_in_comma_expression__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__property__(pos, text, ref result2);
			int num4;
			if (num >= 0)
			{
				int num2 = __GENERATED_PEG__RULE__IN__(num, text);
				if (num2 >= 0)
				{
					int num3 = __GENERATED_PEG__RULE__S__(num2, text);
					num4 = ((num3 < 0) ? (-1) : __GENERATED_PEG__RULE__comma_expression__(num3, text, ref result3));
				}
				else
				{
					num4 = -1;
				}
			}
			else
			{
				num4 = -1;
			}
			int num5 = num4;
			__GENERATED_PEG__Memeoize_Pos__expression_property_in_comma_expression__ = pos;
			__GENERATED_PEG__Memeoize_End__expression_property_in_comma_expression__ = num5;
			if (num5 >= 0)
			{
				result = expression_property_in_comma_expression(result2, result3);
				__GENERATED_PEG__Memeoize_Res__expression_property_in_comma_expression__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___expression_property_in_comma_expression__ < pos)
			{
				__GENERATED_PEG__MaxRollback___expression_property_in_comma_expression__ = pos;
			}
			result4 = num5;
		}
		return result4;
	}

	private int __GENERATED_PEG__RULE__comma_expression__(int pos, string text, ref InExpression result)
	{
		char c = '\0';
		NToken l = default(NToken);
		Expression result2 = null;
		NToken r = default(NToken);
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__comma_expression__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__comma_expression__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__comma_expression__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__comma_expression__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__LPAREN__(pos, text);
			if (num >= 0)
			{
				l = new NToken(pos, num);
			}
			int num2 = num;
			int num5;
			if (num2 >= 0)
			{
				int num3 = __GENERATED_PEG__RULE__expression__(num2, text, ref result2);
				if (num3 >= 0)
				{
					int num4 = __GENERATED_PEG__RULE__RPAREN__(num3, text);
					if (num4 >= 0)
					{
						r = new NToken(num3, num4);
					}
					num5 = num4;
				}
				else
				{
					num5 = -1;
				}
			}
			else
			{
				num5 = -1;
			}
			int num6 = num5;
			__GENERATED_PEG__Memeoize_Pos__comma_expression__ = pos;
			__GENERATED_PEG__Memeoize_End__comma_expression__ = num6;
			if (num6 >= 0)
			{
				result = comma_expression(l, result2, r);
				__GENERATED_PEG__Memeoize_Res__comma_expression__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___comma_expression__ < pos)
			{
				__GENERATED_PEG__MaxRollback___comma_expression__ = pos;
			}
			result3 = num6;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__expression_property_in_atom_collection__(int pos, string text, ref Expression result)
	{
		char c = '\0';
		Property result2 = null;
		ExpressionCollection result3 = null;
		int result4;
		if (__GENERATED_PEG__Memeoize_Pos__expression_property_in_atom_collection__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__expression_property_in_atom_collection__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__expression_property_in_atom_collection__;
			}
			result4 = __GENERATED_PEG__Memeoize_End__expression_property_in_atom_collection__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__property__(pos, text, ref result2);
			int num4;
			if (num >= 0)
			{
				int num2 = __GENERATED_PEG__RULE__IN__(num, text);
				if (num2 >= 0)
				{
					int num3 = __GENERATED_PEG__RULE__S__(num2, text);
					num4 = ((num3 < 0) ? (-1) : __GENERATED_PEG__RULE__atom_collection__(num3, text, ref result3));
				}
				else
				{
					num4 = -1;
				}
			}
			else
			{
				num4 = -1;
			}
			int num5 = num4;
			__GENERATED_PEG__Memeoize_Pos__expression_property_in_atom_collection__ = pos;
			__GENERATED_PEG__Memeoize_End__expression_property_in_atom_collection__ = num5;
			if (num5 >= 0)
			{
				result = expression_property_in_atom_collection(result2, result3);
				__GENERATED_PEG__Memeoize_Res__expression_property_in_atom_collection__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___expression_property_in_atom_collection__ < pos)
			{
				__GENERATED_PEG__MaxRollback___expression_property_in_atom_collection__ = pos;
			}
			result4 = num5;
		}
		return result4;
	}

	private int __GENERATED_PEG__RULE__expression_function_atom__(int pos, string text, ref Expression result)
	{
		char c = '\0';
		Expression result2 = null;
		BinaryOperator result3 = default(BinaryOperator);
		Expression result4 = null;
		int result5;
		if (__GENERATED_PEG__Memeoize_Pos__expression_function_atom__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__expression_function_atom__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__expression_function_atom__;
			}
			result5 = __GENERATED_PEG__Memeoize_End__expression_function_atom__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__function_expression__(pos, text, ref result2);
			int num3;
			if (num >= 0)
			{
				int num2 = __GENERATED_PEG__RULE__operator_comp__(num, text, ref result3);
				num3 = ((num2 < 0) ? (-1) : __GENERATED_PEG__RULE__atom__(num2, text, ref result4));
			}
			else
			{
				num3 = -1;
			}
			int num4 = num3;
			__GENERATED_PEG__Memeoize_Pos__expression_function_atom__ = pos;
			__GENERATED_PEG__Memeoize_End__expression_function_atom__ = num4;
			if (num4 >= 0)
			{
				result = expression_function_atom(result2, result3, result4);
				__GENERATED_PEG__Memeoize_Res__expression_function_atom__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___expression_function_atom__ < pos)
			{
				__GENERATED_PEG__MaxRollback___expression_function_atom__ = pos;
			}
			result5 = num4;
		}
		return result5;
	}

	private int __GENERATED_PEG__RULE__atom__(int pos, string text, ref Expression result)
	{
		char c = '\0';
		Expression result2 = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__atom__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__atom__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__atom__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__atom__;
		}
		else
		{
			int num = 0;
			int num2 = __GENERATED_PEG__RULE__constant__(pos, text, ref result2);
			if (num2 >= 0)
			{
				num = num2;
			}
			else
			{
				int num3 = __GENERATED_PEG__RULE__property_exp__(pos, text, ref result2);
				num = ((num3 < 0) ? __GENERATED_PEG__RULE__function_expression__(pos, text, ref result2) : num3);
			}
			int num4 = num;
			__GENERATED_PEG__Memeoize_Pos__atom__ = pos;
			__GENERATED_PEG__Memeoize_End__atom__ = num4;
			if (num4 >= 0)
			{
				result = result2;
				__GENERATED_PEG__Memeoize_Res__atom__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___atom__ < pos)
			{
				__GENERATED_PEG__MaxRollback___atom__ = pos;
			}
			result3 = num4;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__property_exp__(int pos, string text, ref Expression result)
	{
		char c = '\0';
		Property result2 = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__property_exp__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__property_exp__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__property_exp__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__property_exp__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__property__(pos, text, ref result2);
			__GENERATED_PEG__Memeoize_Pos__property_exp__ = pos;
			__GENERATED_PEG__Memeoize_End__property_exp__ = num;
			if (num >= 0)
			{
				result = property_exp(result2);
				__GENERATED_PEG__Memeoize_Res__property_exp__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___property_exp__ < pos)
			{
				__GENERATED_PEG__MaxRollback___property_exp__ = pos;
			}
			result3 = num;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__operator_comp__(int pos, string text, ref BinaryOperator result)
	{
		char c = '\0';
		NToken op = default(NToken);
		int result2;
		if (__GENERATED_PEG__Memeoize_Pos__operator_comp__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__operator_comp__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__operator_comp__;
			}
			result2 = __GENERATED_PEG__Memeoize_End__operator_comp__;
			goto IL_037e;
		}
		int num = -1;
		int num2 = pos;
		if (num2 < text.Length)
		{
			c = text[num2];
			num2++;
			if (c != '<')
			{
				if (c == '=')
				{
					goto IL_02b9;
				}
				if (c != '>')
				{
					if (c != 'i')
					{
						if (c == 'l' && num2 < text.Length)
						{
							c = text[num2];
							num2++;
							if (c == 'i' && num2 < text.Length)
							{
								c = text[num2];
								num2++;
								if (c == 'k' && num2 < text.Length)
								{
									c = text[num2];
									num2++;
									if (c == 'e')
									{
										goto IL_02b9;
									}
								}
							}
						}
					}
					else if (num2 < text.Length)
					{
						c = text[num2];
						num2++;
						if (c == 's')
						{
							goto IL_02b9;
						}
					}
				}
				else
				{
					num = num2;
					if (num2 < text.Length)
					{
						c = text[num2];
						num2++;
						if (c == '=')
						{
							goto IL_02b9;
						}
					}
				}
			}
			else
			{
				num = num2;
				if (num2 < text.Length)
				{
					c = text[num2];
					num2++;
					if (c == '=' || c == '>')
					{
						goto IL_02b9;
					}
				}
			}
		}
		goto IL_02bf;
		IL_02bf:
		int num3 = num;
		if (num3 >= 0)
		{
			op = new NToken(pos, num3);
		}
		int num4 = num3;
		int num5 = ((num4 < 0) ? (-1) : __GENERATED_PEG__RULE__s__(num4, text));
		__GENERATED_PEG__Memeoize_Pos__operator_comp__ = pos;
		__GENERATED_PEG__Memeoize_End__operator_comp__ = num5;
		if (num5 >= 0)
		{
			result = operator_comp(op);
			__GENERATED_PEG__Memeoize_Res__operator_comp__ = result;
		}
		else if (__GENERATED_PEG__MaxRollback___operator_comp__ < pos)
		{
			__GENERATED_PEG__MaxRollback___operator_comp__ = pos;
		}
		result2 = num5;
		goto IL_037e;
		IL_02b9:
		num = num2;
		goto IL_02bf;
		IL_037e:
		return result2;
	}

	private int __GENERATED_PEG__RULE__function_expression__(int pos, string text, ref Expression result)
	{
		char c = '\0';
		AggregateSubqueryExpression result2 = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__function_expression__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__function_expression__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__function_expression__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__function_expression__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__count_expression__(pos, text, ref result2);
			__GENERATED_PEG__Memeoize_Pos__function_expression__ = pos;
			__GENERATED_PEG__Memeoize_End__function_expression__ = num;
			if (num >= 0)
			{
				result = function_expression(result2);
				__GENERATED_PEG__Memeoize_Res__function_expression__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___function_expression__ < pos)
			{
				__GENERATED_PEG__MaxRollback___function_expression__ = pos;
			}
			result3 = num;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__count_expression__(int pos, string text, ref AggregateSubqueryExpression result)
	{
		char c = '\0';
		AggregateSubqueryExpression result2 = null;
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__count_expression__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__count_expression__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__count_expression__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__count_expression__;
		}
		else
		{
			int num = 0;
			int num2 = __GENERATED_PEG__RULE__agg_count_property__(pos, text, ref result2);
			if (num2 >= 0)
			{
				num = num2;
			}
			else
			{
				int num3 = __GENERATED_PEG__RULE__agg_count_const_func__(pos, text, ref result2);
				num = ((num3 < 0) ? __GENERATED_PEG__RULE__agg_count_query__(pos, text, ref result2) : num3);
			}
			int num4 = num;
			__GENERATED_PEG__Memeoize_Pos__count_expression__ = pos;
			__GENERATED_PEG__Memeoize_End__count_expression__ = num4;
			if (num4 >= 0)
			{
				result = result2;
				__GENERATED_PEG__Memeoize_Res__count_expression__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___count_expression__ < pos)
			{
				__GENERATED_PEG__MaxRollback___count_expression__ = pos;
			}
			result3 = num4;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__agg_count_query__(int pos, string text, ref AggregateSubqueryExpression result)
	{
		char c = '\0';
		NToken count = default(NToken);
		NToken n_wildcard_ = default(NToken);
		Identifier result2 = null;
		Expression result3 = null;
		NToken n_wildcard_2 = default(NToken);
		int result4;
		if (__GENERATED_PEG__Memeoize_Pos__agg_count_query__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__agg_count_query__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__agg_count_query__;
			}
			result4 = __GENERATED_PEG__Memeoize_End__agg_count_query__;
		}
		else
		{
			int num = -1;
			int num2 = pos;
			if (num2 < text.Length)
			{
				c = text[num2];
				num2++;
				if (c == 'c' && num2 < text.Length)
				{
					c = text[num2];
					num2++;
					if (c == 'o' && num2 < text.Length)
					{
						c = text[num2];
						num2++;
						if (c == 'u' && num2 < text.Length)
						{
							c = text[num2];
							num2++;
							if (c == 'n' && num2 < text.Length)
							{
								c = text[num2];
								num2++;
								if (c == 't')
								{
									num = num2;
								}
							}
						}
					}
				}
			}
			int num3 = num;
			if (num3 >= 0)
			{
				count = new NToken(pos, num3);
			}
			int num4 = num3;
			int num14;
			if (num4 >= 0)
			{
				int num5 = __GENERATED_PEG__RULE__LPAREN__(num4, text);
				if (num5 >= 0)
				{
					n_wildcard_ = new NToken(num4, num5);
				}
				int num6 = num5;
				if (num6 >= 0)
				{
					int num7 = __GENERATED_PEG__RULE__FROM__(num6, text);
					if (num7 >= 0)
					{
						int num8 = __GENERATED_PEG__RULE__S__(num7, text);
						if (num8 >= 0)
						{
							int num9 = __GENERATED_PEG__RULE__identifier__(num8, text, ref result2);
							if (num9 >= 0)
							{
								int num10 = __GENERATED_PEG__RULE__WHERE__(num9, text);
								if (num10 >= 0)
								{
									int num11 = __GENERATED_PEG__RULE__S__(num10, text);
									if (num11 >= 0)
									{
										int num12 = __GENERATED_PEG__RULE__expression__(num11, text, ref result3);
										if (num12 >= 0)
										{
											int num13 = __GENERATED_PEG__RULE__RPAREN__(num12, text);
											if (num13 >= 0)
											{
												n_wildcard_2 = new NToken(num12, num13);
											}
											num14 = num13;
										}
										else
										{
											num14 = -1;
										}
									}
									else
									{
										num14 = -1;
									}
								}
								else
								{
									num14 = -1;
								}
							}
							else
							{
								num14 = -1;
							}
						}
						else
						{
							num14 = -1;
						}
					}
					else
					{
						num14 = -1;
					}
				}
				else
				{
					num14 = -1;
				}
			}
			else
			{
				num14 = -1;
			}
			int num15 = num14;
			__GENERATED_PEG__Memeoize_Pos__agg_count_query__ = pos;
			__GENERATED_PEG__Memeoize_End__agg_count_query__ = num15;
			if (num15 >= 0)
			{
				result = agg_count_query(count, n_wildcard_, result2, result3, n_wildcard_2);
				__GENERATED_PEG__Memeoize_Res__agg_count_query__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___agg_count_query__ < pos)
			{
				__GENERATED_PEG__MaxRollback___agg_count_query__ = pos;
			}
			result4 = num15;
		}
		return result4;
	}

	private int __GENERATED_PEG__RULE__agg_count_const_func__(int pos, string text, ref AggregateSubqueryExpression result)
	{
		char c = '\0';
		NToken count = default(NToken);
		NToken n_wildcard_ = default(NToken);
		ConstantFunction result2 = null;
		NToken r = default(NToken);
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__agg_count_const_func__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__agg_count_const_func__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__agg_count_const_func__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__agg_count_const_func__;
		}
		else
		{
			int num = -1;
			int num2 = pos;
			if (num2 < text.Length)
			{
				c = text[num2];
				num2++;
				if (c == 'c' && num2 < text.Length)
				{
					c = text[num2];
					num2++;
					if (c == 'o' && num2 < text.Length)
					{
						c = text[num2];
						num2++;
						if (c == 'u' && num2 < text.Length)
						{
							c = text[num2];
							num2++;
							if (c == 'n' && num2 < text.Length)
							{
								c = text[num2];
								num2++;
								if (c == 't')
								{
									num = num2;
								}
							}
						}
					}
				}
			}
			int num3 = num;
			if (num3 >= 0)
			{
				count = new NToken(pos, num3);
			}
			int num4 = num3;
			int num9;
			if (num4 >= 0)
			{
				int num5 = __GENERATED_PEG__RULE__LPAREN__(num4, text);
				if (num5 >= 0)
				{
					n_wildcard_ = new NToken(num4, num5);
				}
				int num6 = num5;
				if (num6 >= 0)
				{
					int num7 = __GENERATED_PEG__RULE__constant_function__(num6, text, ref result2);
					if (num7 >= 0)
					{
						int num8 = __GENERATED_PEG__RULE__RPAREN__(num7, text);
						if (num8 >= 0)
						{
							r = new NToken(num7, num8);
						}
						num9 = num8;
					}
					else
					{
						num9 = -1;
					}
				}
				else
				{
					num9 = -1;
				}
			}
			else
			{
				num9 = -1;
			}
			int num10 = num9;
			__GENERATED_PEG__Memeoize_Pos__agg_count_const_func__ = pos;
			__GENERATED_PEG__Memeoize_End__agg_count_const_func__ = num10;
			if (num10 >= 0)
			{
				result = agg_count_const_func(count, n_wildcard_, result2, r);
				__GENERATED_PEG__Memeoize_Res__agg_count_const_func__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___agg_count_const_func__ < pos)
			{
				__GENERATED_PEG__MaxRollback___agg_count_const_func__ = pos;
			}
			result3 = num10;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__agg_count_property__(int pos, string text, ref AggregateSubqueryExpression result)
	{
		char c = '\0';
		NToken count = default(NToken);
		NToken n_wildcard_ = default(NToken);
		Property result2 = null;
		NToken r = default(NToken);
		int result3;
		if (__GENERATED_PEG__Memeoize_Pos__agg_count_property__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__agg_count_property__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__agg_count_property__;
			}
			result3 = __GENERATED_PEG__Memeoize_End__agg_count_property__;
		}
		else
		{
			int num = -1;
			int num2 = pos;
			if (num2 < text.Length)
			{
				c = text[num2];
				num2++;
				if (c == 'c' && num2 < text.Length)
				{
					c = text[num2];
					num2++;
					if (c == 'o' && num2 < text.Length)
					{
						c = text[num2];
						num2++;
						if (c == 'u' && num2 < text.Length)
						{
							c = text[num2];
							num2++;
							if (c == 'n' && num2 < text.Length)
							{
								c = text[num2];
								num2++;
								if (c == 't')
								{
									num = num2;
								}
							}
						}
					}
				}
			}
			int num3 = num;
			if (num3 >= 0)
			{
				count = new NToken(pos, num3);
			}
			int num4 = num3;
			int num9;
			if (num4 >= 0)
			{
				int num5 = __GENERATED_PEG__RULE__LPAREN__(num4, text);
				if (num5 >= 0)
				{
					n_wildcard_ = new NToken(num4, num5);
				}
				int num6 = num5;
				if (num6 >= 0)
				{
					int num7 = __GENERATED_PEG__RULE__property__(num6, text, ref result2);
					if (num7 >= 0)
					{
						int num8 = __GENERATED_PEG__RULE__RPAREN__(num7, text);
						if (num8 >= 0)
						{
							r = new NToken(num7, num8);
						}
						num9 = num8;
					}
					else
					{
						num9 = -1;
					}
				}
				else
				{
					num9 = -1;
				}
			}
			else
			{
				num9 = -1;
			}
			int num10 = num9;
			__GENERATED_PEG__Memeoize_Pos__agg_count_property__ = pos;
			__GENERATED_PEG__Memeoize_End__agg_count_property__ = num10;
			if (num10 >= 0)
			{
				result = agg_count_property(count, n_wildcard_, result2, r);
				__GENERATED_PEG__Memeoize_Res__agg_count_property__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___agg_count_property__ < pos)
			{
				__GENERATED_PEG__MaxRollback___agg_count_property__ = pos;
			}
			result3 = num10;
		}
		return result3;
	}

	private int __GENERATED_PEG__RULE__expression_property_atom__(int pos, string text, ref Expression result)
	{
		char c = '\0';
		Property result2 = null;
		BinaryOperator result3 = default(BinaryOperator);
		Expression result4 = null;
		int result5;
		if (__GENERATED_PEG__Memeoize_Pos__expression_property_atom__ == pos)
		{
			if (__GENERATED_PEG__Memeoize_End__expression_property_atom__ >= 0)
			{
				result = __GENERATED_PEG__Memeoize_Res__expression_property_atom__;
			}
			result5 = __GENERATED_PEG__Memeoize_End__expression_property_atom__;
		}
		else
		{
			int num = __GENERATED_PEG__RULE__property__(pos, text, ref result2);
			int num3;
			if (num >= 0)
			{
				int num2 = __GENERATED_PEG__RULE__operator_comp__(num, text, ref result3);
				num3 = ((num2 < 0) ? (-1) : __GENERATED_PEG__RULE__atom__(num2, text, ref result4));
			}
			else
			{
				num3 = -1;
			}
			int num4 = num3;
			__GENERATED_PEG__Memeoize_Pos__expression_property_atom__ = pos;
			__GENERATED_PEG__Memeoize_End__expression_property_atom__ = num4;
			if (num4 >= 0)
			{
				result = expression_property_atom(result2, result3, result4);
				__GENERATED_PEG__Memeoize_Res__expression_property_atom__ = result;
			}
			else if (__GENERATED_PEG__MaxRollback___expression_property_atom__ < pos)
			{
				__GENERATED_PEG__MaxRollback___expression_property_atom__ = pos;
			}
			result5 = num4;
		}
		return result5;
	}

	private int __GENERATED_PEG__RULE__s__(int pos, string text)
	{
		char c = '\0';
		c = '\0';
		int num = pos;
		while (true)
		{
			int num2 = __GENERATED_PEG__RULE__space__(num, text);
			if (num2 < 0)
			{
				break;
			}
			num = num2;
		}
		return num;
	}

	private int __GENERATED_PEG__RULE__space__(int pos, string text)
	{
		char c = '\0';
		int num = 0;
		int num2 = 0;
		c = '\0';
		num2 = -1;
		num = pos;
		if (num < text.Length)
		{
			c = text[num];
			num++;
			if (c != '\r')
			{
				if (c >= '\t' && ((c >= '\u2028') ? ((c >= '\u205f') ? ((c < '\u3000') ? (c <= '\u205f') : (c <= '\u3000')) : ((c < '\u202f') ? (c <= '\u2029') : (c <= '\u202f'))) : ((c >= '\u1680') ? ((c < '\u2000') ? (c <= '\u1680') : (c <= '\u200a')) : ((c >= '\u00a0') ? (c <= '\u00a0') : ((c < ' ') ? (c <= '\f') : (c <= ' '))))))
				{
					goto IL_0200;
				}
			}
			else
			{
				num2 = num;
				if (num < text.Length)
				{
					c = text[num];
					num++;
					if (c == '\n')
					{
						goto IL_0200;
					}
				}
			}
		}
		goto IL_0205;
		IL_0205:
		return num2;
		IL_0200:
		num2 = num;
		goto IL_0205;
	}

	public Nemerle.Builtins.Tuple<int, List<int>> GetMaxRollbackPosAndIds()
	{
		int num = 0;
		List<int> list = new List<int>(42);
		num = -1;
		if (num < __GENERATED_PEG__MaxRollback___detachedExpression__)
		{
			num = __GENERATED_PEG__MaxRollback___detachedExpression__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___detachedExpression__ > 0 && num == __GENERATED_PEG__MaxRollback___detachedExpression__)
		{
			list.Add(0);
		}
		if (num < __GENERATED_PEG__MaxRollback___expression__)
		{
			num = __GENERATED_PEG__MaxRollback___expression__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___expression__ > 0 && num == __GENERATED_PEG__MaxRollback___expression__)
		{
			list.Add(1);
		}
		if (num < __GENERATED_PEG__MaxRollback___expression_or__)
		{
			num = __GENERATED_PEG__MaxRollback___expression_or__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___expression_or__ > 0 && num == __GENERATED_PEG__MaxRollback___expression_or__)
		{
			list.Add(2);
		}
		if (num < __GENERATED_PEG__MaxRollback___expression_and__)
		{
			num = __GENERATED_PEG__MaxRollback___expression_and__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___expression_and__ > 0 && num == __GENERATED_PEG__MaxRollback___expression_and__)
		{
			list.Add(3);
		}
		if (num < __GENERATED_PEG__MaxRollback___expression_comp__)
		{
			num = __GENERATED_PEG__MaxRollback___expression_comp__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___expression_comp__ > 0 && num == __GENERATED_PEG__MaxRollback___expression_comp__)
		{
			list.Add(4);
		}
		if (num < __GENERATED_PEG__MaxRollback___expression_property_in_parameter__)
		{
			num = __GENERATED_PEG__MaxRollback___expression_property_in_parameter__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___expression_property_in_parameter__ > 0 && num == __GENERATED_PEG__MaxRollback___expression_property_in_parameter__)
		{
			list.Add(13);
		}
		if (num < __GENERATED_PEG__MaxRollback___parameter__)
		{
			num = __GENERATED_PEG__MaxRollback___parameter__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___parameter__ > 0 && num == __GENERATED_PEG__MaxRollback___parameter__)
		{
			list.Add(24);
		}
		if (num < __GENERATED_PEG__MaxRollback___query_parameter__)
		{
			num = __GENERATED_PEG__MaxRollback___query_parameter__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___query_parameter__ > 0 && num == __GENERATED_PEG__MaxRollback___query_parameter__)
		{
			list.Add(29);
		}
		if (num < __GENERATED_PEG__MaxRollback___parameter_name__)
		{
			num = __GENERATED_PEG__MaxRollback___parameter_name__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___parameter_name__ > 0 && num == __GENERATED_PEG__MaxRollback___parameter_name__)
		{
			list.Add(30);
		}
		if (num < __GENERATED_PEG__MaxRollback___sparen_parameter_name__)
		{
			num = __GENERATED_PEG__MaxRollback___sparen_parameter_name__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___sparen_parameter_name__ > 0 && num == __GENERATED_PEG__MaxRollback___sparen_parameter_name__)
		{
			list.Add(31);
		}
		if (num < __GENERATED_PEG__MaxRollback___simple_identifier__)
		{
			num = __GENERATED_PEG__MaxRollback___simple_identifier__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___simple_identifier__ > 0 && num == __GENERATED_PEG__MaxRollback___simple_identifier__)
		{
			list.Add(51);
		}
		if (num < __GENERATED_PEG__MaxRollback___property__)
		{
			num = __GENERATED_PEG__MaxRollback___property__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___property__ > 0 && num == __GENERATED_PEG__MaxRollback___property__)
		{
			list.Add(19);
		}
		if (num < __GENERATED_PEG__MaxRollback___property_parent__)
		{
			num = __GENERATED_PEG__MaxRollback___property_parent__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___property_parent__ > 0 && num == __GENERATED_PEG__MaxRollback___property_parent__)
		{
			list.Add(20);
		}
		if (num < __GENERATED_PEG__MaxRollback___identifier__)
		{
			num = __GENERATED_PEG__MaxRollback___identifier__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___identifier__ > 0 && num == __GENERATED_PEG__MaxRollback___identifier__)
		{
			list.Add(50);
		}
		if (num < __GENERATED_PEG__MaxRollback___property_root__)
		{
			num = __GENERATED_PEG__MaxRollback___property_root__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___property_root__ > 0 && num == __GENERATED_PEG__MaxRollback___property_root__)
		{
			list.Add(21);
		}
		if (num < __GENERATED_PEG__MaxRollback___not_expression__)
		{
			num = __GENERATED_PEG__MaxRollback___not_expression__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___not_expression__ > 0 && num == __GENERATED_PEG__MaxRollback___not_expression__)
		{
			list.Add(12);
		}
		if (num < __GENERATED_PEG__MaxRollback___expression_inbrackets__)
		{
			num = __GENERATED_PEG__MaxRollback___expression_inbrackets__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___expression_inbrackets__ > 0 && num == __GENERATED_PEG__MaxRollback___expression_inbrackets__)
		{
			list.Add(11);
		}
		if (num < __GENERATED_PEG__MaxRollback___expression_property_in_query_expression__)
		{
			num = __GENERATED_PEG__MaxRollback___expression_property_in_query_expression__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___expression_property_in_query_expression__ > 0 && num == __GENERATED_PEG__MaxRollback___expression_property_in_query_expression__)
		{
			list.Add(10);
		}
		if (num < __GENERATED_PEG__MaxRollback___query_expression__)
		{
			num = __GENERATED_PEG__MaxRollback___query_expression__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___query_expression__ > 0 && num == __GENERATED_PEG__MaxRollback___query_expression__)
		{
			list.Add(44);
		}
		if (num < __GENERATED_PEG__MaxRollback___query_exp_from_second__)
		{
			num = __GENERATED_PEG__MaxRollback___query_exp_from_second__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___query_exp_from_second__ > 0 && num == __GENERATED_PEG__MaxRollback___query_exp_from_second__)
		{
			list.Add(46);
		}
		if (num < __GENERATED_PEG__MaxRollback___query_exp_from_first__)
		{
			num = __GENERATED_PEG__MaxRollback___query_exp_from_first__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___query_exp_from_first__ > 0 && num == __GENERATED_PEG__MaxRollback___query_exp_from_first__)
		{
			list.Add(45);
		}
		if (num < __GENERATED_PEG__MaxRollback___expression_property_in_function__)
		{
			num = __GENERATED_PEG__MaxRollback___expression_property_in_function__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___expression_property_in_function__ > 0 && num == __GENERATED_PEG__MaxRollback___expression_property_in_function__)
		{
			list.Add(9);
		}
		if (num < __GENERATED_PEG__MaxRollback___inFunction__)
		{
			num = __GENERATED_PEG__MaxRollback___inFunction__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___inFunction__ > 0 && num == __GENERATED_PEG__MaxRollback___inFunction__)
		{
			list.Add(36);
		}
		if (num < __GENERATED_PEG__MaxRollback___in_func_2__)
		{
			num = __GENERATED_PEG__MaxRollback___in_func_2__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___in_func_2__ > 0 && num == __GENERATED_PEG__MaxRollback___in_func_2__)
		{
			list.Add(38);
		}
		if (num < __GENERATED_PEG__MaxRollback___atom_collection__)
		{
			num = __GENERATED_PEG__MaxRollback___atom_collection__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___atom_collection__ > 0 && num == __GENERATED_PEG__MaxRollback___atom_collection__)
		{
			list.Add(15);
		}
		if (num < __GENERATED_PEG__MaxRollback___constant__)
		{
			num = __GENERATED_PEG__MaxRollback___constant__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___constant__ > 0 && num == __GENERATED_PEG__MaxRollback___constant__)
		{
			list.Add(22);
		}
		if (num < __GENERATED_PEG__MaxRollback___const_empty__)
		{
			num = __GENERATED_PEG__MaxRollback___const_empty__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___const_empty__ > 0 && num == __GENERATED_PEG__MaxRollback___const_empty__)
		{
			list.Add(28);
		}
		if (num < __GENERATED_PEG__MaxRollback___const_null__)
		{
			num = __GENERATED_PEG__MaxRollback___const_null__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___const_null__ > 0 && num == __GENERATED_PEG__MaxRollback___const_null__)
		{
			list.Add(27);
		}
		if (num < __GENERATED_PEG__MaxRollback___function_const__)
		{
			num = __GENERATED_PEG__MaxRollback___function_const__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___function_const__ > 0 && num == __GENERATED_PEG__MaxRollback___function_const__)
		{
			list.Add(32);
		}
		if (num < __GENERATED_PEG__MaxRollback___constant_function__)
		{
			num = __GENERATED_PEG__MaxRollback___constant_function__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___constant_function__ > 0 && num == __GENERATED_PEG__MaxRollback___constant_function__)
		{
			list.Add(33);
		}
		if (num < __GENERATED_PEG__MaxRollback___const_func_2__)
		{
			num = __GENERATED_PEG__MaxRollback___const_func_2__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___const_func_2__ > 0 && num == __GENERATED_PEG__MaxRollback___const_func_2__)
		{
			list.Add(35);
		}
		if (num < __GENERATED_PEG__MaxRollback___const_func_1__)
		{
			num = __GENERATED_PEG__MaxRollback___const_func_1__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___const_func_1__ > 0 && num == __GENERATED_PEG__MaxRollback___const_func_1__)
		{
			list.Add(34);
		}
		if (num < __GENERATED_PEG__MaxRollback___const_false__)
		{
			num = __GENERATED_PEG__MaxRollback___const_false__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___const_false__ > 0 && num == __GENERATED_PEG__MaxRollback___const_false__)
		{
			list.Add(26);
		}
		if (num < __GENERATED_PEG__MaxRollback___const_true__)
		{
			num = __GENERATED_PEG__MaxRollback___const_true__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___const_true__ > 0 && num == __GENERATED_PEG__MaxRollback___const_true__)
		{
			list.Add(25);
		}
		if (num < __GENERATED_PEG__MaxRollback___character_string__)
		{
			num = __GENERATED_PEG__MaxRollback___character_string__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___character_string__ > 0 && num == __GENERATED_PEG__MaxRollback___character_string__)
		{
			list.Add(23);
		}
		if (num < __GENERATED_PEG__MaxRollback___number__)
		{
			num = __GENERATED_PEG__MaxRollback___number__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___number__ > 0 && num == __GENERATED_PEG__MaxRollback___number__)
		{
			list.Add(47);
		}
		if (num < __GENERATED_PEG__MaxRollback___integerLiteral__)
		{
			num = __GENERATED_PEG__MaxRollback___integerLiteral__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___integerLiteral__ > 0 && num == __GENERATED_PEG__MaxRollback___integerLiteral__)
		{
			list.Add(48);
		}
		if (num < __GENERATED_PEG__MaxRollback___realLiteral__)
		{
			num = __GENERATED_PEG__MaxRollback___realLiteral__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___realLiteral__ > 0 && num == __GENERATED_PEG__MaxRollback___realLiteral__)
		{
			list.Add(49);
		}
		if (num < __GENERATED_PEG__MaxRollback___in_func_1__)
		{
			num = __GENERATED_PEG__MaxRollback___in_func_1__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___in_func_1__ > 0 && num == __GENERATED_PEG__MaxRollback___in_func_1__)
		{
			list.Add(37);
		}
		if (num < __GENERATED_PEG__MaxRollback___expression_property_in_comma_expression__)
		{
			num = __GENERATED_PEG__MaxRollback___expression_property_in_comma_expression__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___expression_property_in_comma_expression__ > 0 && num == __GENERATED_PEG__MaxRollback___expression_property_in_comma_expression__)
		{
			list.Add(8);
		}
		if (num < __GENERATED_PEG__MaxRollback___comma_expression__)
		{
			num = __GENERATED_PEG__MaxRollback___comma_expression__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___comma_expression__ > 0 && num == __GENERATED_PEG__MaxRollback___comma_expression__)
		{
			list.Add(16);
		}
		if (num < __GENERATED_PEG__MaxRollback___expression_property_in_atom_collection__)
		{
			num = __GENERATED_PEG__MaxRollback___expression_property_in_atom_collection__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___expression_property_in_atom_collection__ > 0 && num == __GENERATED_PEG__MaxRollback___expression_property_in_atom_collection__)
		{
			list.Add(7);
		}
		if (num < __GENERATED_PEG__MaxRollback___expression_function_atom__)
		{
			num = __GENERATED_PEG__MaxRollback___expression_function_atom__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___expression_function_atom__ > 0 && num == __GENERATED_PEG__MaxRollback___expression_function_atom__)
		{
			list.Add(6);
		}
		if (num < __GENERATED_PEG__MaxRollback___atom__)
		{
			num = __GENERATED_PEG__MaxRollback___atom__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___atom__ > 0 && num == __GENERATED_PEG__MaxRollback___atom__)
		{
			list.Add(17);
		}
		if (num < __GENERATED_PEG__MaxRollback___property_exp__)
		{
			num = __GENERATED_PEG__MaxRollback___property_exp__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___property_exp__ > 0 && num == __GENERATED_PEG__MaxRollback___property_exp__)
		{
			list.Add(18);
		}
		if (num < __GENERATED_PEG__MaxRollback___operator_comp__)
		{
			num = __GENERATED_PEG__MaxRollback___operator_comp__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___operator_comp__ > 0 && num == __GENERATED_PEG__MaxRollback___operator_comp__)
		{
			list.Add(14);
		}
		if (num < __GENERATED_PEG__MaxRollback___function_expression__)
		{
			num = __GENERATED_PEG__MaxRollback___function_expression__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___function_expression__ > 0 && num == __GENERATED_PEG__MaxRollback___function_expression__)
		{
			list.Add(39);
		}
		if (num < __GENERATED_PEG__MaxRollback___count_expression__)
		{
			num = __GENERATED_PEG__MaxRollback___count_expression__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___count_expression__ > 0 && num == __GENERATED_PEG__MaxRollback___count_expression__)
		{
			list.Add(40);
		}
		if (num < __GENERATED_PEG__MaxRollback___agg_count_query__)
		{
			num = __GENERATED_PEG__MaxRollback___agg_count_query__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___agg_count_query__ > 0 && num == __GENERATED_PEG__MaxRollback___agg_count_query__)
		{
			list.Add(43);
		}
		if (num < __GENERATED_PEG__MaxRollback___agg_count_const_func__)
		{
			num = __GENERATED_PEG__MaxRollback___agg_count_const_func__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___agg_count_const_func__ > 0 && num == __GENERATED_PEG__MaxRollback___agg_count_const_func__)
		{
			list.Add(42);
		}
		if (num < __GENERATED_PEG__MaxRollback___agg_count_property__)
		{
			num = __GENERATED_PEG__MaxRollback___agg_count_property__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___agg_count_property__ > 0 && num == __GENERATED_PEG__MaxRollback___agg_count_property__)
		{
			list.Add(41);
		}
		if (num < __GENERATED_PEG__MaxRollback___expression_property_atom__)
		{
			num = __GENERATED_PEG__MaxRollback___expression_property_atom__;
			list.Clear();
		}
		if (__GENERATED_PEG__MaxRollback___expression_property_atom__ > 0 && num == __GENERATED_PEG__MaxRollback___expression_property_atom__)
		{
			list.Add(5);
		}
		return new Nemerle.Builtins.Tuple<int, List<int>>(num, list);
	}

	public Nemerle.Builtins.Tuple<int, List<string>> GetMaxRollbackPosAndNames()
	{
		Nemerle.Builtins.Tuple<int, List<int>> maxRollbackPosAndIds = GetMaxRollbackPosAndIds();
		int field = maxRollbackPosAndIds.Field0;
		List<int> field2 = maxRollbackPosAndIds.Field1;
		List<string> list = new List<string>(field2.Count);
		foreach (int item in field2)
		{
			int id = item;
			list.Add(GetRuleName(id));
		}
		return new Nemerle.Builtins.Tuple<int, List<string>>(field, list);
	}

	public string GetRuleName(int id)
	{
		return id switch
		{
			0 => "detachedExpression", 
			1 => "expression", 
			2 => "expression_or", 
			3 => "expression_and", 
			4 => "expression_comp", 
			5 => "expression_property_atom", 
			6 => "expression_function_atom", 
			7 => "expression_property_in_atom_collection", 
			8 => "expression_property_in_comma_expression", 
			9 => "expression_property_in_function", 
			10 => "expression_property_in_query_expression", 
			11 => "expression_inbrackets", 
			12 => "not_expression", 
			13 => "expression_property_in_parameter", 
			14 => "operator_comp", 
			15 => "atom_collection", 
			16 => "comma_expression", 
			17 => "atom", 
			18 => "property_exp", 
			19 => "property", 
			20 => "property_parent", 
			21 => "property_root", 
			22 => "constant", 
			23 => "character_string", 
			24 => "parameter", 
			25 => "const_true", 
			26 => "const_false", 
			27 => "const_null", 
			28 => "const_empty", 
			29 => "query_parameter", 
			30 => "parameter_name", 
			31 => "sparen_parameter_name", 
			32 => "function_const", 
			33 => "constant_function", 
			34 => "const_func_1", 
			35 => "const_func_2", 
			36 => "inFunction", 
			37 => "in_func_1", 
			38 => "in_func_2", 
			39 => "function_expression", 
			40 => "count_expression", 
			41 => "agg_count_property", 
			42 => "agg_count_const_func", 
			43 => "agg_count_query", 
			44 => "query_expression", 
			45 => "query_exp_from_first", 
			46 => "query_exp_from_second", 
			47 => "number", 
			48 => "integerLiteral", 
			49 => "realLiteral", 
			50 => "identifier", 
			51 => "simple_identifier", 
			52 => "CHARACTER_STRING", 
			53 => "LPAREN", 
			54 => "RPAREN", 
			55 => "LSPAREN", 
			56 => "RSPAREN", 
			57 => "ESCAPELSPAREN", 
			58 => "ESCAPERSPAREN", 
			59 => "COMMA", 
			60 => "DOT", 
			61 => "TRUE", 
			62 => "FALSE", 
			63 => "NULL", 
			64 => "EMPTY", 
			65 => "IN", 
			66 => "IS", 
			67 => "NOT", 
			68 => "LIKE", 
			69 => "QUOTE", 
			70 => "ESCAPEQUOTE", 
			71 => "OR", 
			72 => "AND", 
			73 => "PARENT", 
			74 => "ROOT", 
			75 => "COUNT", 
			76 => "FROM", 
			77 => "WHERE", 
			78 => "SELECT", 
			79 => "newLineCharacter", 
			80 => "newLine", 
			81 => "whitespace", 
			82 => "space", 
			83 => "s", 
			84 => "S", 
			85 => "letterCharacter", 
			86 => "combiningCharacter", 
			87 => "decimalDigitCharacter", 
			88 => "connectingCharacter", 
			89 => "formattingCharacter", 
			90 => "identifierStartCharacter", 
			91 => "identifierPartCharacters", 
			92 => "keyword", 
			93 => "ANY", 
			94 => "digit", 
			95 => "letter", 
			_ => "Unknown rule id.", 
		};
	}

	private void ResetMaxRollbackPos()
	{
		__GENERATED_PEG__MaxRollback___detachedExpression__ = -1;
		__GENERATED_PEG__MaxRollback___expression__ = -1;
		__GENERATED_PEG__MaxRollback___expression_or__ = -1;
		__GENERATED_PEG__MaxRollback___expression_and__ = -1;
		__GENERATED_PEG__MaxRollback___expression_comp__ = -1;
		__GENERATED_PEG__MaxRollback___expression_property_in_parameter__ = -1;
		__GENERATED_PEG__MaxRollback___parameter__ = -1;
		__GENERATED_PEG__MaxRollback___query_parameter__ = -1;
		__GENERATED_PEG__MaxRollback___parameter_name__ = -1;
		__GENERATED_PEG__MaxRollback___sparen_parameter_name__ = -1;
		__GENERATED_PEG__MaxRollback___simple_identifier__ = -1;
		__GENERATED_PEG__MaxRollback___property__ = -1;
		__GENERATED_PEG__MaxRollback___property_parent__ = -1;
		__GENERATED_PEG__MaxRollback___identifier__ = -1;
		__GENERATED_PEG__MaxRollback___property_root__ = -1;
		__GENERATED_PEG__MaxRollback___not_expression__ = -1;
		__GENERATED_PEG__MaxRollback___expression_inbrackets__ = -1;
		__GENERATED_PEG__MaxRollback___expression_property_in_query_expression__ = -1;
		__GENERATED_PEG__MaxRollback___query_expression__ = -1;
		__GENERATED_PEG__MaxRollback___query_exp_from_second__ = -1;
		__GENERATED_PEG__MaxRollback___query_exp_from_first__ = -1;
		__GENERATED_PEG__MaxRollback___expression_property_in_function__ = -1;
		__GENERATED_PEG__MaxRollback___inFunction__ = -1;
		__GENERATED_PEG__MaxRollback___in_func_2__ = -1;
		__GENERATED_PEG__MaxRollback___atom_collection__ = -1;
		__GENERATED_PEG__MaxRollback___constant__ = -1;
		__GENERATED_PEG__MaxRollback___const_empty__ = -1;
		__GENERATED_PEG__MaxRollback___const_null__ = -1;
		__GENERATED_PEG__MaxRollback___function_const__ = -1;
		__GENERATED_PEG__MaxRollback___constant_function__ = -1;
		__GENERATED_PEG__MaxRollback___const_func_2__ = -1;
		__GENERATED_PEG__MaxRollback___const_func_1__ = -1;
		__GENERATED_PEG__MaxRollback___const_false__ = -1;
		__GENERATED_PEG__MaxRollback___const_true__ = -1;
		__GENERATED_PEG__MaxRollback___character_string__ = -1;
		__GENERATED_PEG__MaxRollback___number__ = -1;
		__GENERATED_PEG__MaxRollback___integerLiteral__ = -1;
		__GENERATED_PEG__MaxRollback___realLiteral__ = -1;
		__GENERATED_PEG__MaxRollback___in_func_1__ = -1;
		__GENERATED_PEG__MaxRollback___expression_property_in_comma_expression__ = -1;
		__GENERATED_PEG__MaxRollback___comma_expression__ = -1;
		__GENERATED_PEG__MaxRollback___expression_property_in_atom_collection__ = -1;
		__GENERATED_PEG__MaxRollback___expression_function_atom__ = -1;
		__GENERATED_PEG__MaxRollback___atom__ = -1;
		__GENERATED_PEG__MaxRollback___property_exp__ = -1;
		__GENERATED_PEG__MaxRollback___operator_comp__ = -1;
		__GENERATED_PEG__MaxRollback___function_expression__ = -1;
		__GENERATED_PEG__MaxRollback___count_expression__ = -1;
		__GENERATED_PEG__MaxRollback___agg_count_query__ = -1;
		__GENERATED_PEG__MaxRollback___agg_count_const_func__ = -1;
		__GENERATED_PEG__MaxRollback___agg_count_property__ = -1;
		__GENERATED_PEG__MaxRollback___expression_property_atom__ = -1;
	}

	private void ResetMemoization()
	{
		__GENERATED_PEG__Memeoize_Pos__detachedExpression__ = -1;
		__GENERATED_PEG__Memeoize_End__detachedExpression__ = -1;
		__GENERATED_PEG__Memeoize_Res__detachedExpression__ = null;
		__GENERATED_PEG__Memeoize_Pos__expression__ = -1;
		__GENERATED_PEG__Memeoize_End__expression__ = -1;
		__GENERATED_PEG__Memeoize_Res__expression__ = null;
		__GENERATED_PEG__Memeoize_Pos__expression_or__ = -1;
		__GENERATED_PEG__Memeoize_End__expression_or__ = -1;
		__GENERATED_PEG__Memeoize_Res__expression_or__ = null;
		__GENERATED_PEG__Memeoize_Pos__expression_and__ = -1;
		__GENERATED_PEG__Memeoize_End__expression_and__ = -1;
		__GENERATED_PEG__Memeoize_Res__expression_and__ = null;
		__GENERATED_PEG__Memeoize_Pos__expression_comp__ = -1;
		__GENERATED_PEG__Memeoize_End__expression_comp__ = -1;
		__GENERATED_PEG__Memeoize_Res__expression_comp__ = null;
		__GENERATED_PEG__Memeoize_Pos__expression_property_in_parameter__ = -1;
		__GENERATED_PEG__Memeoize_End__expression_property_in_parameter__ = -1;
		__GENERATED_PEG__Memeoize_Res__expression_property_in_parameter__ = null;
		__GENERATED_PEG__Memeoize_Pos__parameter__ = -1;
		__GENERATED_PEG__Memeoize_End__parameter__ = -1;
		__GENERATED_PEG__Memeoize_Res__parameter__ = null;
		__GENERATED_PEG__Memeoize_Pos__query_parameter__ = -1;
		__GENERATED_PEG__Memeoize_End__query_parameter__ = -1;
		__GENERATED_PEG__Memeoize_Res__query_parameter__ = null;
		__GENERATED_PEG__Memeoize_Pos__parameter_name__ = -1;
		__GENERATED_PEG__Memeoize_End__parameter_name__ = -1;
		__GENERATED_PEG__Memeoize_Res__parameter_name__ = null;
		__GENERATED_PEG__Memeoize_Pos__sparen_parameter_name__ = -1;
		__GENERATED_PEG__Memeoize_End__sparen_parameter_name__ = -1;
		__GENERATED_PEG__Memeoize_Res__sparen_parameter_name__ = null;
		__GENERATED_PEG__Memeoize_Pos__simple_identifier__ = -1;
		__GENERATED_PEG__Memeoize_End__simple_identifier__ = -1;
		__GENERATED_PEG__Memeoize_Res__simple_identifier__ = null;
		__GENERATED_PEG__Memeoize_Pos__property__ = -1;
		__GENERATED_PEG__Memeoize_End__property__ = -1;
		__GENERATED_PEG__Memeoize_Res__property__ = null;
		__GENERATED_PEG__Memeoize_Pos__property_parent__ = -1;
		__GENERATED_PEG__Memeoize_End__property_parent__ = -1;
		__GENERATED_PEG__Memeoize_Res__property_parent__ = null;
		__GENERATED_PEG__Memeoize_Pos__identifier__ = -1;
		__GENERATED_PEG__Memeoize_End__identifier__ = -1;
		__GENERATED_PEG__Memeoize_Res__identifier__ = null;
		__GENERATED_PEG__Memeoize_Pos__property_root__ = -1;
		__GENERATED_PEG__Memeoize_End__property_root__ = -1;
		__GENERATED_PEG__Memeoize_Res__property_root__ = null;
		__GENERATED_PEG__Memeoize_Pos__not_expression__ = -1;
		__GENERATED_PEG__Memeoize_End__not_expression__ = -1;
		__GENERATED_PEG__Memeoize_Res__not_expression__ = null;
		__GENERATED_PEG__Memeoize_Pos__expression_inbrackets__ = -1;
		__GENERATED_PEG__Memeoize_End__expression_inbrackets__ = -1;
		__GENERATED_PEG__Memeoize_Res__expression_inbrackets__ = null;
		__GENERATED_PEG__Memeoize_Pos__expression_property_in_query_expression__ = -1;
		__GENERATED_PEG__Memeoize_End__expression_property_in_query_expression__ = -1;
		__GENERATED_PEG__Memeoize_Res__expression_property_in_query_expression__ = null;
		__GENERATED_PEG__Memeoize_Pos__query_expression__ = -1;
		__GENERATED_PEG__Memeoize_End__query_expression__ = -1;
		__GENERATED_PEG__Memeoize_Res__query_expression__ = null;
		__GENERATED_PEG__Memeoize_Pos__query_exp_from_second__ = -1;
		__GENERATED_PEG__Memeoize_End__query_exp_from_second__ = -1;
		__GENERATED_PEG__Memeoize_Res__query_exp_from_second__ = null;
		__GENERATED_PEG__Memeoize_Pos__query_exp_from_first__ = -1;
		__GENERATED_PEG__Memeoize_End__query_exp_from_first__ = -1;
		__GENERATED_PEG__Memeoize_Res__query_exp_from_first__ = null;
		__GENERATED_PEG__Memeoize_Pos__expression_property_in_function__ = -1;
		__GENERATED_PEG__Memeoize_End__expression_property_in_function__ = -1;
		__GENERATED_PEG__Memeoize_Res__expression_property_in_function__ = null;
		__GENERATED_PEG__Memeoize_Pos__inFunction__ = -1;
		__GENERATED_PEG__Memeoize_End__inFunction__ = -1;
		__GENERATED_PEG__Memeoize_Res__inFunction__ = null;
		__GENERATED_PEG__Memeoize_Pos__in_func_2__ = -1;
		__GENERATED_PEG__Memeoize_End__in_func_2__ = -1;
		__GENERATED_PEG__Memeoize_Res__in_func_2__ = null;
		__GENERATED_PEG__Memeoize_Pos__atom_collection__ = -1;
		__GENERATED_PEG__Memeoize_End__atom_collection__ = -1;
		__GENERATED_PEG__Memeoize_Res__atom_collection__ = null;
		__GENERATED_PEG__Memeoize_Pos__constant__ = -1;
		__GENERATED_PEG__Memeoize_End__constant__ = -1;
		__GENERATED_PEG__Memeoize_Res__constant__ = null;
		__GENERATED_PEG__Memeoize_Pos__const_empty__ = -1;
		__GENERATED_PEG__Memeoize_End__const_empty__ = -1;
		__GENERATED_PEG__Memeoize_Res__const_empty__ = null;
		__GENERATED_PEG__Memeoize_Pos__const_null__ = -1;
		__GENERATED_PEG__Memeoize_End__const_null__ = -1;
		__GENERATED_PEG__Memeoize_Res__const_null__ = null;
		__GENERATED_PEG__Memeoize_Pos__function_const__ = -1;
		__GENERATED_PEG__Memeoize_End__function_const__ = -1;
		__GENERATED_PEG__Memeoize_Res__function_const__ = null;
		__GENERATED_PEG__Memeoize_Pos__constant_function__ = -1;
		__GENERATED_PEG__Memeoize_End__constant_function__ = -1;
		__GENERATED_PEG__Memeoize_Res__constant_function__ = null;
		__GENERATED_PEG__Memeoize_Pos__const_func_2__ = -1;
		__GENERATED_PEG__Memeoize_End__const_func_2__ = -1;
		__GENERATED_PEG__Memeoize_Res__const_func_2__ = null;
		__GENERATED_PEG__Memeoize_Pos__const_func_1__ = -1;
		__GENERATED_PEG__Memeoize_End__const_func_1__ = -1;
		__GENERATED_PEG__Memeoize_Res__const_func_1__ = null;
		__GENERATED_PEG__Memeoize_Pos__const_false__ = -1;
		__GENERATED_PEG__Memeoize_End__const_false__ = -1;
		__GENERATED_PEG__Memeoize_Res__const_false__ = null;
		__GENERATED_PEG__Memeoize_Pos__const_true__ = -1;
		__GENERATED_PEG__Memeoize_End__const_true__ = -1;
		__GENERATED_PEG__Memeoize_Res__const_true__ = null;
		__GENERATED_PEG__Memeoize_Pos__character_string__ = -1;
		__GENERATED_PEG__Memeoize_End__character_string__ = -1;
		__GENERATED_PEG__Memeoize_Res__character_string__ = null;
		__GENERATED_PEG__Memeoize_Pos__number__ = -1;
		__GENERATED_PEG__Memeoize_End__number__ = -1;
		__GENERATED_PEG__Memeoize_Res__number__ = null;
		__GENERATED_PEG__Memeoize_Pos__integerLiteral__ = -1;
		__GENERATED_PEG__Memeoize_End__integerLiteral__ = -1;
		__GENERATED_PEG__Memeoize_Res__integerLiteral__ = null;
		__GENERATED_PEG__Memeoize_Pos__realLiteral__ = -1;
		__GENERATED_PEG__Memeoize_End__realLiteral__ = -1;
		__GENERATED_PEG__Memeoize_Res__realLiteral__ = null;
		__GENERATED_PEG__Memeoize_Pos__in_func_1__ = -1;
		__GENERATED_PEG__Memeoize_End__in_func_1__ = -1;
		__GENERATED_PEG__Memeoize_Res__in_func_1__ = null;
		__GENERATED_PEG__Memeoize_Pos__expression_property_in_comma_expression__ = -1;
		__GENERATED_PEG__Memeoize_End__expression_property_in_comma_expression__ = -1;
		__GENERATED_PEG__Memeoize_Res__expression_property_in_comma_expression__ = null;
		__GENERATED_PEG__Memeoize_Pos__comma_expression__ = -1;
		__GENERATED_PEG__Memeoize_End__comma_expression__ = -1;
		__GENERATED_PEG__Memeoize_Res__comma_expression__ = null;
		__GENERATED_PEG__Memeoize_Pos__expression_property_in_atom_collection__ = -1;
		__GENERATED_PEG__Memeoize_End__expression_property_in_atom_collection__ = -1;
		__GENERATED_PEG__Memeoize_Res__expression_property_in_atom_collection__ = null;
		__GENERATED_PEG__Memeoize_Pos__expression_function_atom__ = -1;
		__GENERATED_PEG__Memeoize_End__expression_function_atom__ = -1;
		__GENERATED_PEG__Memeoize_Res__expression_function_atom__ = null;
		__GENERATED_PEG__Memeoize_Pos__atom__ = -1;
		__GENERATED_PEG__Memeoize_End__atom__ = -1;
		__GENERATED_PEG__Memeoize_Res__atom__ = null;
		__GENERATED_PEG__Memeoize_Pos__property_exp__ = -1;
		__GENERATED_PEG__Memeoize_End__property_exp__ = -1;
		__GENERATED_PEG__Memeoize_Res__property_exp__ = null;
		__GENERATED_PEG__Memeoize_Pos__operator_comp__ = -1;
		__GENERATED_PEG__Memeoize_End__operator_comp__ = -1;
		__GENERATED_PEG__Memeoize_Res__operator_comp__ = default(BinaryOperator);
		__GENERATED_PEG__Memeoize_Pos__function_expression__ = -1;
		__GENERATED_PEG__Memeoize_End__function_expression__ = -1;
		__GENERATED_PEG__Memeoize_Res__function_expression__ = null;
		__GENERATED_PEG__Memeoize_Pos__count_expression__ = -1;
		__GENERATED_PEG__Memeoize_End__count_expression__ = -1;
		__GENERATED_PEG__Memeoize_Res__count_expression__ = null;
		__GENERATED_PEG__Memeoize_Pos__agg_count_query__ = -1;
		__GENERATED_PEG__Memeoize_End__agg_count_query__ = -1;
		__GENERATED_PEG__Memeoize_Res__agg_count_query__ = null;
		__GENERATED_PEG__Memeoize_Pos__agg_count_const_func__ = -1;
		__GENERATED_PEG__Memeoize_End__agg_count_const_func__ = -1;
		__GENERATED_PEG__Memeoize_Res__agg_count_const_func__ = null;
		__GENERATED_PEG__Memeoize_Pos__agg_count_property__ = -1;
		__GENERATED_PEG__Memeoize_End__agg_count_property__ = -1;
		__GENERATED_PEG__Memeoize_Res__agg_count_property__ = null;
		__GENERATED_PEG__Memeoize_Pos__expression_property_atom__ = -1;
		__GENERATED_PEG__Memeoize_End__expression_property_atom__ = -1;
		__GENERATED_PEG__Memeoize_Res__expression_property_atom__ = null;
	}

	public option<Expression> Parse(string text)
	{
		Nemerle.Builtins.Tuple<int, Expression> tuple = TryParse(text);
		int field = tuple.Field0;
		Expression field2 = tuple.Field1;
		return (field >= 0) ? ((option<Expression>)new option<Expression>.Some(field2)) : ((option<Expression>)option<Expression>.None._N_constant_object);
	}

	public option<Expression> Parse(SourceSnapshot source)
	{
		Nemerle.Builtins.Tuple<int, Expression> tuple = TryParse(source);
		int field = tuple.Field0;
		Expression field2 = tuple.Field1;
		return (field >= 0) ? ((option<Expression>)new option<Expression>.Some(field2)) : ((option<Expression>)option<Expression>.None._N_constant_object);
	}

	public Nemerle.Builtins.Tuple<int, Expression> TryParse(string text)
	{
		return TryParse(new SourceSnapshot(text));
	}

	public Nemerle.Builtins.Tuple<int, Expression> TryParse([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] SourceSnapshot source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source", "The ``NotNull'' contract of parameter ``source'' has been violated. See EQLParser.n:12:6:176:7: .");
		}
		ResetMemoization();
		ResetMaxRollbackPos();
		_parsingSource = source;
		Expression result = null;
		int field = __GENERATED_PEG__RULE__detachedExpression__(0, _parsingSource.Text, ref result);
		return new Nemerle.Builtins.Tuple<int, Expression>(field, result);
	}

	protected string GetText(NToken tok)
	{
		return _parsingSource.OriginalText.Substring(tok.StartPos, checked(tok.EndPos - tok.StartPos));
	}

	protected Location GetLocation(NToken tok)
	{
		return new Location(_parsingSource, tok.StartPos, tok.EndPos);
	}
}
