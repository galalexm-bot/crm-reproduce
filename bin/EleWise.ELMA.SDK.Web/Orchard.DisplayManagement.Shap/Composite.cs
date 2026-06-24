using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Castle.DynamicProxy;
using Microsoft.CSharp.RuntimeBinder;

namespace Orchard.DisplayManagement.Shapes;

public class Composite : DynamicObject
{
	private class Interceptor : IInterceptor
	{
		private static readonly ConcurrentDictionary<MethodInfo, Action<IInvocation>> Invokers = new ConcurrentDictionary<MethodInfo, Action<IInvocation>>();

		public object Self { get; private set; }

		public Interceptor(object self)
		{
			Self = self;
		}

		public void Intercept(IInvocation invocation)
		{
			if (invocation.get_Method() == DynamicMetaObjectProviderGetMetaObject)
			{
				Expression expression = (Expression)invocation.get_Arguments().Single();
				invocation.set_ReturnValue((object)new ForwardingMetaObject(expression, BindingRestrictions.Empty, invocation.get_Proxy(), (IDynamicMetaObjectProvider)Self, (Expression exprProxy) => Expression.Field(exprProxy, "__target")));
			}
			else
			{
				BindInvoker(invocation)(invocation);
			}
		}

		private static Action<IInvocation> BindInvoker(IInvocation invocation)
		{
			return Invokers.GetOrAdd(invocation.get_Method(), CompileInvoker);
		}

		private static Action<IInvocation> CompileInvoker(MethodInfo method)
		{
			ParameterInfo[] parameters = method.GetParameters();
			ParameterExpression invocationParameter = Expression.Parameter(typeof(IInvocation), "invocation");
			CSharpArgumentInfo[] argumentInfo = Pack(CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null), parameters.Select((ParameterInfo mp) => CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.NamedArgument, mp.Name))).ToArray();
			Expression[] arguments = Pack((Expression)Expression.Coalesce(Expression.Property(invocationParameter, invocationParameter.Type, "InvocationTarget"), Expression.Property(invocationParameter, invocationParameter.Type, "Proxy")), (IEnumerable<Expression>)parameters.Select((ParameterInfo mp, int index) => Expression.Convert(Expression.ArrayIndex(Expression.Property(invocationParameter, invocationParameter.Type, "Arguments"), Expression.Constant(index)), mp.ParameterType))).ToArray();
			Expression expression = null;
			if (method.IsSpecialName)
			{
				if (method.Name.Equals("get_Item"))
				{
					expression = Expression.Dynamic(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.InvokeSpecialName, typeof(object), argumentInfo), typeof(object), arguments);
				}
				if (expression == null && method.Name.Equals("set_Item"))
				{
					IEnumerable<CSharpArgumentInfo> argumentInfo2 = Pack(CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null), parameters.Select((ParameterInfo mp) => (!(mp.Name == "value")) ? CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.NamedArgument, mp.Name) : CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)));
					expression = Expression.Dynamic(Microsoft.CSharp.RuntimeBinder.Binder.SetIndex(CSharpBinderFlags.InvokeSpecialName, typeof(object), argumentInfo2), typeof(object), arguments);
				}
				if (expression == null && method.Name.StartsWith("get_"))
				{
					expression = Expression.Dynamic(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.InvokeSpecialName, method.Name.Substring("get_".Length), typeof(object), argumentInfo), typeof(object), arguments);
				}
				if (expression == null && method.Name.StartsWith("set_"))
				{
					expression = Expression.Dynamic(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.InvokeSpecialName, method.Name.Substring("set_".Length), typeof(object), argumentInfo), typeof(object), arguments);
				}
			}
			if (expression == null)
			{
				expression = Expression.Dynamic(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, method.Name, null, typeof(object), argumentInfo), typeof(object), arguments);
			}
			if (method.ReturnType != typeof(void))
			{
				expression = Expression.Assign(Expression.Property(invocationParameter, invocationParameter.Type, "ReturnValue"), Expression.Convert(expression, typeof(object)));
			}
			return Expression.Lambda<Action<IInvocation>>(expression, new ParameterExpression[1] { invocationParameter }).Compile();
		}
	}

	public sealed class ForwardingMetaObject : DynamicMetaObject
	{
		private readonly DynamicMetaObject _metaForwardee;

		public ForwardingMetaObject(Expression expression, BindingRestrictions restrictions, object forwarder, IDynamicMetaObjectProvider forwardee, Func<Expression, Expression> forwardeeGetter)
			: base(expression, restrictions, forwarder)
		{
			_metaForwardee = forwardee.GetMetaObject(forwardeeGetter(Expression.Convert(expression, forwarder.GetType())));
		}

		private DynamicMetaObject AddRestrictions(DynamicMetaObject result)
		{
			return new DynamicMetaObject(result.Expression, BindingRestrictions.GetTypeRestriction(base.Expression, base.Value.GetType()).Merge(result.Restrictions), _metaForwardee.Value);
		}

		public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
		{
			return AddRestrictions(_metaForwardee.BindGetMember(binder));
		}

		public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
		{
			return AddRestrictions(_metaForwardee.BindSetMember(binder, value));
		}

		public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
		{
			return AddRestrictions(_metaForwardee.BindDeleteMember(binder));
		}

		public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes)
		{
			return AddRestrictions(_metaForwardee.BindGetIndex(binder, indexes));
		}

		public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value)
		{
			return AddRestrictions(_metaForwardee.BindSetIndex(binder, indexes, value));
		}

		public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes)
		{
			return AddRestrictions(_metaForwardee.BindDeleteIndex(binder, indexes));
		}

		public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
		{
			return AddRestrictions(_metaForwardee.BindInvokeMember(binder, args));
		}

		public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args)
		{
			return AddRestrictions(_metaForwardee.BindInvoke(binder, args));
		}

		public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args)
		{
			return AddRestrictions(_metaForwardee.BindCreateInstance(binder, args));
		}

		public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder)
		{
			return AddRestrictions(_metaForwardee.BindUnaryOperation(binder));
		}

		public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
		{
			return AddRestrictions(_metaForwardee.BindBinaryOperation(binder, arg));
		}

		public override DynamicMetaObject BindConvert(ConvertBinder binder)
		{
			return AddRestrictions(_metaForwardee.BindConvert(binder));
		}
	}

	private readonly IDictionary _props = new HybridDictionary();

	private static readonly IProxyBuilder ProxyBuilder = (IProxyBuilder)new DefaultProxyBuilder();

	private static readonly MethodInfo DynamicMetaObjectProviderGetMetaObject = typeof(IDynamicMetaObjectProvider).GetMethod("GetMetaObject");

	public IDictionary Properties => _props;

	public override bool TryGetMember(GetMemberBinder binder, out object result)
	{
		return TryGetMemberImpl(binder.Name, out result);
	}

	protected virtual bool TryGetMemberImpl(string name, out object result)
	{
		if (_props.Contains(name))
		{
			result = _props[name];
			return true;
		}
		result = null;
		return true;
	}

	public override bool TrySetMember(SetMemberBinder binder, object value)
	{
		return TrySetMemberImpl(binder.Name, value);
	}

	protected bool TrySetMemberImpl(string name, object value)
	{
		_props[name] = value;
		return true;
	}

	public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
	{
		if (!args.Any())
		{
			return TryGetMemberImpl(binder.Name, out result);
		}
		if (args.Count() == 1)
		{
			result = this;
			return TrySetMemberImpl(binder.Name, args.Single());
		}
		if (!base.TryInvokeMember(binder, args, out result))
		{
			if (binder.Name == "ToString")
			{
				result = string.Empty;
				return true;
			}
			return false;
		}
		return true;
	}

	public override bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result)
	{
		if (indexes.Count() != 1)
		{
			return base.TryGetIndex(binder, indexes, out result);
		}
		object obj = indexes.Single();
		if (_props.Contains(obj))
		{
			result = _props[obj];
			return true;
		}
		if (obj is string name && TryGetMemberImpl(name, out result))
		{
			return true;
		}
		return base.TryGetIndex(binder, indexes, out result);
	}

	public override bool TrySetIndex(SetIndexBinder binder, object[] indexes, object value)
	{
		if (indexes.Count() != 1)
		{
			return base.TrySetIndex(binder, indexes, value);
		}
		if (indexes.Single() is string name && TrySetMemberImpl(name, value))
		{
			return true;
		}
		_props[indexes.Single()] = value;
		return true;
	}

	public static bool operator ==(Composite a, Nil b)
	{
		return (object)a == null;
	}

	public static bool operator !=(Composite a, Nil b)
	{
		return !(a == b);
	}

	protected bool Equals(Composite other)
	{
		return object.Equals(_props, other._props);
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() != GetType())
		{
			return false;
		}
		return Equals((Composite)obj);
	}

	public override int GetHashCode()
	{
		if (_props == null)
		{
			return 0;
		}
		return _props.GetHashCode();
	}

	public override bool TryConvert(ConvertBinder binder, out object result)
	{
		Type returnType = binder.ReturnType;
		if (returnType.IsInterface && returnType != typeof(IDynamicMetaObjectProvider))
		{
			Type type = ProxyBuilder.CreateInterfaceProxyTypeWithoutTarget(returnType, new Type[1] { typeof(IDynamicMetaObjectProvider) }, ProxyGenerationOptions.Default);
			IInterceptor[] array = (IInterceptor[])(object)new IInterceptor[1]
			{
				new Interceptor(this)
			};
			object obj = (result = Activator.CreateInstance(type, array, this));
			return true;
		}
		result = null;
		return false;
	}

	private static IEnumerable<T> Pack<T>(T t1)
	{
		if (!object.Equals(t1, default(T)))
		{
			yield return t1;
		}
	}

	private static IEnumerable<T> Pack<T>(T t1, IEnumerable<T> t2)
	{
		if (!object.Equals(t1, default(T)))
		{
			yield return t1;
		}
		foreach (T item in t2)
		{
			yield return item;
		}
	}

	private static IEnumerable<T> Pack<T>(T t1, IEnumerable<T> t2, T t3)
	{
		if (!object.Equals(t1, default(T)))
		{
			yield return t1;
		}
		foreach (T item in t2)
		{
			yield return item;
		}
		if (!object.Equals(t3, default(T)))
		{
			yield return t3;
		}
	}
}
