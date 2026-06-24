using System;
using System.Drawing;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.KPI.Common.Scales;

[Serializable]
public class ScaleStatus : ICloneable
{
	public static readonly ScaleStatus Good = new ScaleStatus(Color.Green, SR.T("Хорошо"), 10, ValueStatus.Good);

	public static readonly ScaleStatus Normal = new ScaleStatus(Color.DarkGoldenrod, SR.T("Допустимо"), 5, ValueStatus.Normal);

	public static readonly ScaleStatus Critical = new ScaleStatus(Color.Red, SR.T("Критично"), 0, ValueStatus.Critical);

	public static readonly ScaleStatus Unavailable = new ScaleStatus(Color.Empty, SR.T("Нет данных"), -10, ValueStatus.Unavailable);

	public Color Color { get; private set; }

	public string Text { get; private set; }

	public ValueStatus Code { get; private set; }

	public int Priority { get; private set; }

	public ScaleStatus(Color color, string text, int priority)
	{
		Color = color;
		Text = text;
		Priority = priority;
		Code = ValueStatus.Unavailable;
	}

	public ScaleStatus(Color color, string text, int priority, ValueStatus code)
	{
		Color = color;
		Text = text;
		Priority = priority;
		Code = code;
	}

	public bool Equals(ScaleStatus other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		if (other.Code.Equals(Code) && other.Color.Equals(Color))
		{
			return object.Equals(other.Text, Text);
		}
		return false;
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
		if (obj.GetType() != typeof(ScaleStatus))
		{
			return false;
		}
		return Equals((ScaleStatus)obj);
	}

	public override int GetHashCode()
	{
		return (Color.GetHashCode() * 397) ^ ((Text != null) ? Text.GetHashCode() : 0);
	}

	public override string ToString()
	{
		return $"Color: {Color}, Text: {Text}, Code : {ModelHelper.GetEnumDisplayName(Code)}";
	}

	public Color WebColor()
	{
		if (Color == Color.Red)
		{
			return StatusConstants.Red;
		}
		if (Color == Color.DarkGoldenrod)
		{
			return StatusConstants.Yellow;
		}
		if (Color == Color.Green)
		{
			return StatusConstants.Green;
		}
		return StatusConstants.Grey;
	}

	public object Clone()
	{
		return new ScaleStatus(Color, Text, Priority, Code);
	}
}
