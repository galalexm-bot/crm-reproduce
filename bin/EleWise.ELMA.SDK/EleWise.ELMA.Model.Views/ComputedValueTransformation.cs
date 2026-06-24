using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Transformations.Class;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[XmlInclude(typeof(ComputedValueTransformationAdd))]
[XmlInclude(typeof(ComputedValueTransformationHide))]
[XmlInclude(typeof(ComputedValueTransformationChange))]
[XmlInclude(typeof(ComputedValueTransformationMove))]
[Component]
public class ComputedValueTransformation : Transformation<ComputedValue, ComputedValueTransformation, string, ComputedValueTransformationAdd, ComputedValueTransformationMove, ComputedValueTransformationHide, ComputedValueTransformationChange>
{
	private sealed class ComputedValueCollectionContainer : ComputedValue
	{
		public IList<ComputedValue> Items { get; }

		public ComputedValueCollectionContainer(IList<ComputedValue> items)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			Items = items ?? new ComputedValue[0];
		}
	}

	internal static ComputedValueTransformation P07ROOoSv2cq8v3OKKox;

	public void Apply(IList<ComputedValue> items)
	{
		Apply(new ComputedValueCollectionContainer(items));
	}

	public static ComputedValueTransformation CreateTransformation(IList<ComputedValue> items, IList<ComputedValue> originalItems)
	{
		if (items == null)
		{
			return null;
		}
		if (originalItems == null)
		{
			return null;
		}
		if (items.Count == 0 && originalItems.Count == 0)
		{
			return null;
		}
		if (items != originalItems)
		{
			return Transformation<ComputedValue, ComputedValueTransformation, string, string>.CreateTransformation(new ComputedValueCollectionContainer(items), new ComputedValueCollectionContainer(originalItems));
		}
		return null;
	}

	protected internal override IList<ComputedValue> GetSubItems(ComputedValue item)
	{
		if (!(item is ComputedValueCollectionContainer computedValueCollectionContainer))
		{
			return new ComputedValue[0];
		}
		return computedValueCollectionContainer.Items;
	}

	protected internal override string GetUid(ComputedValue item)
	{
		return (string)G7RKQLoSuPbudq0HMLRC(item);
	}

	protected internal override bool IsHide(ComputedValue item)
	{
		return false;
	}

	protected internal override void SetHide(ComputedValue parentItem, ComputedValue item, bool hide = true)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				RemoveItem(parentItem, item);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected internal override ComputedValue CreateCopy(ComputedValue item)
	{
		return Clone(item);
	}

	protected internal override ComputedValue Clone(ComputedValue item)
	{
		return ClassSerializationHelper.CloneObject(item);
	}

	protected override IEnumerable<BaseTransformation<ComputedValue, string>> ChangeTransformations(ComputedValue item, ComputedValue originalItem, ComputedValue originalItemRoot)
	{
		if (item is ComputedValueCollectionContainer && originalItem is ComputedValueCollectionContainer)
		{
			return base.ChangeTransformations(item, originalItem, originalItemRoot);
		}
		string uid = GetUid(item);
		bool flag = true;
		List<ComputedValueTransformationChange> list = new List<ComputedValueTransformationChange>();
		bool flag2 = originalItem == null;
		if (flag2 || !object.Equals(item.Value, originalItem.Value))
		{
			list.Add(CreateTransformationChange(uid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123672534), item.Value));
			if (item.ComputedValueType == ComputedValueType.Input)
			{
				flag = false;
				list.Add(CreateTransformationChange(uid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811916894), item.ComputedValueType));
			}
		}
		if (flag2 || item.MethodName != originalItem.MethodName)
		{
			list.Add(CreateTransformationChange(uid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138302358), item.MethodName));
			if (item.ComputedValueType == ComputedValueType.Function)
			{
				flag = false;
				list.Add(CreateTransformationChange(uid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92D4B39), item.ComputedValueType));
			}
		}
		if (flag2 || item.CalculateScript != originalItem.CalculateScript)
		{
			list.Add(CreateTransformationChange(uid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217639661), item.CalculateScript));
			if (item.ComputedValueType == ComputedValueType.CalculateScript)
			{
				flag = false;
				list.Add(CreateTransformationChange(uid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -671978281), item.ComputedValueType));
			}
		}
		if (flag && (flag2 || item.ComputedValueType != originalItem.ComputedValueType))
		{
			list.Add(CreateTransformationChange(uid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8332DDE), item.ComputedValueType));
		}
		return list;
	}

	private static ComputedValueTransformationChange CreateTransformationChange(object uid, object propertyName, object value)
	{
		ComputedValueTransformationChange obj = new ComputedValueTransformationChange
		{
			Uid = (string)uid,
			PropertyName = (string)propertyName
		};
		Mo5pnyoSIWJqvj6j36Xu(obj, value);
		obj.Localizable = false;
		return obj;
	}

	public ComputedValueTransformation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Wp1dukoSVR1qs0BlI8ps();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object G7RKQLoSuPbudq0HMLRC(object P_0)
	{
		return ((ComputedValue)P_0).Name;
	}

	internal static bool reVhRmoS8cVsPfPpQEU0()
	{
		return P07ROOoSv2cq8v3OKKox == null;
	}

	internal static ComputedValueTransformation VHxSeloSZ2koNys5EhlA()
	{
		return P07ROOoSv2cq8v3OKKox;
	}

	internal static void Mo5pnyoSIWJqvj6j36Xu(object P_0, object P_1)
	{
		((TransformationChange<ComputedValue, ComputedValueTransformation, string, string>)P_0).Value = P_1;
	}

	internal static void Wp1dukoSVR1qs0BlI8ps()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
