using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Binders;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class LongBinderProvider : IModelBinderProvider
{
	public IEnumerable<KeyValuePair<Type, IModelBinder>> GetModelBinders()
	{
		LongBinder byteBinder = LongBinder.Create(Convert.ToByte);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(byte), (IModelBinder)(object)byteBinder);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(byte?), (IModelBinder)(object)byteBinder);
		LongBinder sbyteBinder = LongBinder.Create(Convert.ToSByte);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(sbyte), (IModelBinder)(object)sbyteBinder);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(sbyte?), (IModelBinder)(object)sbyteBinder);
		LongBinder ushortBinder = LongBinder.Create(Convert.ToUInt16);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(ushort), (IModelBinder)(object)ushortBinder);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(ushort?), (IModelBinder)(object)ushortBinder);
		LongBinder shortBinder = LongBinder.Create(Convert.ToInt16);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(short), (IModelBinder)(object)shortBinder);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(short?), (IModelBinder)(object)shortBinder);
		LongBinder uintBinder = LongBinder.Create(Convert.ToUInt32);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(uint), (IModelBinder)(object)uintBinder);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(uint?), (IModelBinder)(object)uintBinder);
		LongBinder intBinder = LongBinder.Create(Convert.ToInt32);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(int), (IModelBinder)(object)intBinder);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(int?), (IModelBinder)(object)intBinder);
		LongBinder ulongBinder = LongBinder.Create(Convert.ToUInt64);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(ulong), (IModelBinder)(object)ulongBinder);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(ulong?), (IModelBinder)(object)ulongBinder);
		LongBinder longBinder = LongBinder.Create(Convert.ToInt64);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(long), (IModelBinder)(object)longBinder);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(long?), (IModelBinder)(object)longBinder);
	}
}
