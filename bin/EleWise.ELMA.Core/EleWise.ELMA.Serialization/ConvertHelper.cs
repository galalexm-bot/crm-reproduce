using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using Bridge;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.References;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Serialization;

[Name("convertHelper")]
[Module("Reactive")]
[External]
public static class ConvertHelper
{
	[Template("{$}({target})")]
	public static extern object Serialize(object target);

	[Template("{$}({type}, {target})")]
	public static extern string SerializeWithType(System.Type type, object target);

	[Template("{$}({type}, {value}, {context})")]
	public static extern object DeserializeWithType(System.Type type, object value);

	[Template("{$}({type}, {value}, {context})")]
	public static extern object DeserializeWithType(System.Type type, object value, ConvertContext context);

	[Template("{$}({target}, {settings})")]
	public static extern object Serialize(object target, SerializationSettings settings);

	[Template("{$}({first}, {second})")]
	public static extern bool IsPlainObjectsEquals(object first, object second);

	[Template("{$}({target}, {expression}, {value})")]
	public static extern void RedefineProp(object target, PropertyInfoExpression expression, object value);

	[Template("{$}Func({target}, {expression}, {value})")]
	public static extern void RedefineProp(object target, PropertyInfoExpression expression, Func<object> value);

	[Template("{$}({target}, {expression})")]
	public static extern void DefineInput(object target, PropertyInfoExpression expression);

	[Template("{this}.GetBoolean({target}, {expression}, {shouldSerialize}, {initValue}, true)")]
	public static extern bool? GetNullableBoolean(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{this}.SetBoolean({target}, {expression}, {value}, {shouldSerialize}, {initValue}, true)")]
	public static extern void SetNullableBoolean(object target, PropertyInfoExpression expression, bool? value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue}, false)")]
	public static extern bool GetBoolean(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue}, false)")]
	public static extern void SetBoolean(object target, PropertyInfoExpression expression, bool value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{this}.GetDouble({target}, {expression}, {shouldSerialize}, {initValue}, true)")]
	public static extern double? GetNullableDouble(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{this}.SetDouble({target}, {expression}, {value}, {shouldSerialize}, {initValue}, true)")]
	public static extern void SetNullableDouble(object target, PropertyInfoExpression expression, double? value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue}, false)")]
	public static extern double GetDouble(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue}, false)")]
	public static extern void SetDouble(object target, PropertyInfoExpression expression, double value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue}, false)")]
	public static extern string GetString(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue}, false)")]
	public static extern void SetString(object target, PropertyInfoExpression expression, string value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue})")]
	public static extern HtmlString GetHtmlString(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue})")]
	public static extern void SetHtmlString(object target, PropertyInfoExpression expression, HtmlString value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue})")]
	public static extern Uri GetUri(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue})")]
	public static extern void SetUri(object target, PropertyInfoExpression expression, Uri value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{this}.GetDateTime({target}, {expression}, {shouldSerialize}, {initValue}, true)")]
	public static extern System.DateTime? GetNullableDateTime(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{this}.SetDateTime({target}, {expression}, {value}, {shouldSerialize}, {initValue}, true)")]
	public static extern void SetNullableDateTime(object target, PropertyInfoExpression expression, System.DateTime? value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue}, false)")]
	public static extern System.DateTime GetDateTime(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue}, false)")]
	public static extern void SetDateTime(object target, PropertyInfoExpression expression, System.DateTime value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{this}.GetTimeSpan({target}, {expression}, {shouldSerialize}, {initValue}, true)")]
	public static extern TimeSpan? GetNullableTimeSpan(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{this}.SetTimeSpan({target}, {expression}, {value}, {shouldSerialize}, {initValue}, true)")]
	public static extern void SetNullableTimeSpan(object target, PropertyInfoExpression expression, TimeSpan? value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue}, false)")]
	public static extern TimeSpan GetTimeSpan(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue}, false)")]
	public static extern void SetTimeSpan(object target, PropertyInfoExpression expression, TimeSpan value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue}, true)")]
	public static extern DateTimeRange? GetDateTimeRange(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue}, true)")]
	public static extern void SetDateTimeRange(object target, PropertyInfoExpression expression, DateTimeRange? value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue}, false)")]
	public static extern RelativeDateTime GetRelativeDateTime(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue})")]
	public static extern ExceptionData GetExceptionData(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue})")]
	public static extern void SetExceptionData(object target, PropertyInfoExpression expression, ExceptionData value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue}, false)")]
	public static extern void SetRelativeDateTime(object target, PropertyInfoExpression expression, RelativeDateTime value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{this}.GetGuid({target}, {expression}, {shouldSerialize}, {initValue}, true)")]
	public static extern Guid? GetNullableGuid(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{this}.SetGuid({target}, {expression}, {value}, {shouldSerialize}, {initValue}, true)")]
	public static extern void SetNullableGuid(object target, PropertyInfoExpression expression, Guid? value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue}, false)")]
	public static extern Guid GetGuid(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue}, false)")]
	public static extern void SetGuid(object target, PropertyInfoExpression expression, Guid value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{this}.GetInt16({target}, {expression}, {shouldSerialize}, {initValue}, true)")]
	public static extern short? GetNullableInt16(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{this}.SetInt16({target}, {expression}, {value}, {shouldSerialize}, {initValue}, true)")]
	public static extern void SetNullableInt16(object target, PropertyInfoExpression expression, short? value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue}, false)")]
	public static extern short GetInt16(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue}, false)")]
	public static extern void SetInt16(object target, PropertyInfoExpression expression, short value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{this}.GetInt32({target}, {expression}, {shouldSerialize}, {initValue}, true)")]
	public static extern int? GetNullableInt32(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{this}.SetInt32({target}, {expression}, {value}, {shouldSerialize}, {initValue}, true)")]
	public static extern void SetNullableInt32(object target, PropertyInfoExpression expression, int? value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue}, false)")]
	public static extern int GetInt32(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue}, false)")]
	public static extern void SetInt32(object target, PropertyInfoExpression expression, int value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{this}.GetInt64({target}, {expression}, {shouldSerialize}, {initValue}, true)")]
	public static extern long? GetNullableInt64(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{this}.SetInt64({target}, {expression}, {value}, {shouldSerialize}, {initValue}, true)")]
	public static extern void SetNullableInt64(object target, PropertyInfoExpression expression, long? value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue}, false)")]
	public static extern long GetInt64(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue}, false)")]
	public static extern void SetInt64(object target, PropertyInfoExpression expression, long value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({type}, {target}, {expression}, {shouldSerialize}, {initValue}, {context})")]
	internal static extern ReactiveProxy GetContract(ProxyType type, object target, PropertyInfoExpression expression, bool shouldSerialize, ConvertContext context, Func<object> initValue = null);

	[Template("{$}({type},  {target}, {expression}, {value}, {shouldSerialize}, {initValue}, {context})")]
	internal static extern void SetContract(ProxyType type, object target, PropertyInfoExpression expression, object value, bool shouldSerialize, ConvertContext context, Func<object> initValue = null);

	[Template("{$}({T}, {target}, {expression}, {shouldSerialize}, {initValue}, {TRangePropertyType})")]
	public static extern T GetRange<T, TRangePropertyType>(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({T}, {target}, {expression}, {value}, {shouldSerialize}, {initValue}, {TRangePropertyType})")]
	public static extern void SetRange<T, TRangePropertyType>(object target, PropertyInfoExpression expression, T value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({T}, {target}, {expression}, {shouldSerialize}, {initValue}, {context})")]
	public static extern System.Collections.Generic.ICollection<T> GetCollection<T>(object target, PropertyInfoExpression expression, bool shouldSerialize, ConvertContext context, Func<object> initValue = null);

	[Template("{$}({itemType}, {target}, {expression}, {shouldSerialize}, {initValue}, {context})")]
	public static extern System.Collections.ICollection GetCollection(System.Type itemType, object target, PropertyInfoExpression expression, bool shouldSerialize, ConvertContext context, Func<object> initValue = null);

	[Template("{$}({T}, {target}, {expression}, {value}, {shouldSerialize}, {initValue}, {context})")]
	public static extern void SetCollection<T>(object target, PropertyInfoExpression expression, System.Collections.Generic.ICollection<T> value, bool shouldSerialize, ConvertContext context, Func<object> initValue = null);

	[Template("{$}({itemType}, {target}, {expression}, {value}, {shouldSerialize}, {initValue}, {context})")]
	public static extern void SetCollection(System.Type itemType, object target, PropertyInfoExpression expression, System.Collections.ICollection value, bool shouldSerialize, ConvertContext context, Func<object> initValue = null);

	[Template("{$}({T}, {target}, {expression}, {shouldSerialize}, {initValue}, {context})")]
	public static extern ISet<T> GetSetCollection<T>(object target, PropertyInfoExpression expression, bool shouldSerialize, ConvertContext context, Func<object> initValue = null);

	[Template("{$}({itemType}, {target}, {expression}, {shouldSerialize}, {initValue}, {context})")]
	public static extern System.Collections.ICollection GetSetCollection(System.Type itemType, object target, PropertyInfoExpression expression, bool shouldSerialize, ConvertContext context, Func<object> initValue = null);

	[Template("{$}({T}, {target}, {expression}, {value}, {shouldSerialize}, {initValue}, {context})")]
	public static extern void SetSetCollection<T>(object target, PropertyInfoExpression expression, System.Collections.Generic.IEnumerable<T> value, bool shouldSerialize, ConvertContext context, Func<object> initValue = null);

	[Template("{$}({itemType}, {target}, {expression}, {value}, {shouldSerialize}, {initValue}, {context})")]
	public static extern void SetSetCollection(System.Type itemType, object target, PropertyInfoExpression expression, System.Collections.ICollection value, bool shouldSerialize, ConvertContext context, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {context}, {initValue})")]
	public static extern Entity GetEntityHeader(object target, PropertyInfoExpression expression, bool shouldSerialize, ConvertContext context, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {context}, {initValue})")]
	public static extern Entity SetEntityHeader(object target, PropertyInfoExpression expression, Entity value, bool shouldSerialize, ConvertContext context, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue})")]
	public static extern ReferenceOnEntity GetReferenceOnEntity(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue})")]
	public static extern void SetReferenceOnEntity(object target, PropertyInfoExpression expression, ReferenceOnEntity value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue}, {nullable}, {context})")]
	public static extern EnumWrapper GetEnum(object target, PropertyInfoExpression expression, bool shouldSerialize, bool nullable, EnumConvertContext context, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue}, {nullable}, {context})")]
	public static extern void SetEnum(object target, PropertyInfoExpression expression, EnumWrapper value, bool shouldSerialize, bool nullable, EnumConvertContext context, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue})")]
	public static extern DropDownItem GetDropDownItem(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue})")]
	public static extern void SetDropDownItem(object target, PropertyInfoExpression expression, DropDownItem value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue})")]
	public static extern ReferenceOnType GetReferenceOnType(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue})")]
	public static extern void SetReferenceOnType(object target, PropertyInfoExpression expression, ReferenceOnType value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue})")]
	public static extern ReferenceOnEntityType GetReferenceOnEntityType(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue})")]
	public static extern void SetReferenceOnEntityType(object target, PropertyInfoExpression expression, ReferenceOnEntityType value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue})")]
	public static extern BinaryFile GetBinaryFile(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue})")]
	public static extern void SetBinaryFile(object target, PropertyInfoExpression expression, BinaryFile value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue})")]
	public static extern PasswordInfo GetPassword(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue})")]
	public static extern void SetPassword(object target, PropertyInfoExpression expression, PasswordInfo value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue})")]
	public static extern dynamic GetObject(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue})")]
	public static extern void SetObject(object target, PropertyInfoExpression expression, dynamic value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize})")]
	public static extern FormViewItem GetViewItem(object target, PropertyInfoExpression expression, bool shouldSerialize);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize})")]
	public static extern void SetViewItem(object target, PropertyInfoExpression expression, FormViewItem value, bool shouldSerialize);

	[Rules(/*Could not decode attribute arguments.*/)]
	[Template("{this}.GetViewItem({target}, {expression}, {shouldSerialize})")]
	public static extern object GetObjectViewItem(object target, PropertyInfoExpression expression, bool shouldSerialize);

	[Rules(/*Could not decode attribute arguments.*/)]
	[Template("{this}.SetViewItem({target}, {expression}, {value}, {shouldSerialize})")]
	public static extern void SetObjectViewItem(object target, PropertyInfoExpression expression, object value, bool shouldSerialize);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue}, false)")]
	public static extern byte[] GetByteArray(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue}, false)")]
	public static extern void SetByteArray(object target, PropertyInfoExpression expression, byte[] value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue}, false)")]
	public static extern object[] GetArray(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue}, false)")]
	public static extern void SetArray(object target, PropertyInfoExpression expression, object[] value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {shouldSerialize}, {initValue})")]
	public static extern Book1C GetBook1C(object target, PropertyInfoExpression expression, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({target}, {expression}, {value}, {shouldSerialize}, {initValue})")]
	public static extern void SetBook1C(object target, PropertyInfoExpression expression, Book1C value, bool shouldSerialize, Func<object> initValue = null);

	[Template("{$}({oldInstance}, {obj})")]
	public static extern void Reconcile<T>(T oldInstance, object obj);

	[Template("{$}({propertyName}, {obj}, {value})")]
	public static extern void ReconcileProperty(string propertyName, object obj, object value);

	[Template("{$}({oldInstance}, {obj}, {context})")]
	public static extern void Reconcile<T>(T oldInstance, object obj, object context);

	[Template("{$}({propertyName}, {obj})")]
	internal static extern string GetStringPropertyValue(string propertyName, object obj);

	[Template("{$}({target}, {expression}, {value})")]
	internal static extern void DefinePropSetterCallback(object target, PropertyInfoExpression expression, object value);

	[Template("{$}({target}, {expression}, {targetSetter}, {expressionSetter})")]
	internal static extern void DefinePropSetters(object target, PropertyInfoExpression expression, object targetSetter, PropertyInfoExpression expressionSetter);
}
