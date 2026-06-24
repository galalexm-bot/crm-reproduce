using System;
using System.Xml.Serialization;
using EleWise.ELMA.Common.Enums;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.DTO;

namespace EleWise.ELMA.Common.DTO.Models;

[Serializable]
public class UnitMeasurePropertiesDTO : EntityDTO<long, IUnitMeasureProperties>
{
	private int doublePrecision = 2;

	private UnitMeasurePosition position;

	private string doubleSeparator = ",";

	private int groupMemberLenght = 3;

	private string groupSeparator = " ";

	private NegativeFormat negativeFormat = NegativeFormat.LeftMinus;

	public int DoublePrecision
	{
		get
		{
			return doublePrecision;
		}
		set
		{
			doublePrecision = value;
		}
	}

	public UnitMeasurePosition Position
	{
		get
		{
			return position;
		}
		set
		{
			position = value;
		}
	}

	public string DoubleSeparator
	{
		get
		{
			return doubleSeparator;
		}
		set
		{
			doubleSeparator = value;
		}
	}

	public int GroupMemberLenght
	{
		get
		{
			return groupMemberLenght;
		}
		set
		{
			groupMemberLenght = value;
		}
	}

	[XmlAttribute("GroupSeparator")]
	public string GroupSeparator
	{
		get
		{
			return groupSeparator;
		}
		set
		{
			groupSeparator = value;
		}
	}

	[XmlElement("NegitiveFormatEnum")]
	public NegativeFormat NegativeFormat
	{
		get
		{
			return negativeFormat;
		}
		set
		{
			negativeFormat = value;
		}
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
		if (obj.GetType() != typeof(UnitMeasurePropertiesDTO))
		{
			return false;
		}
		return Equals((UnitMeasurePropertiesDTO)obj);
	}

	public bool Equals(UnitMeasurePropertiesDTO other)
	{
		if (other.position.Equals(position) && other.doublePrecision.Equals(doublePrecision) && other.doubleSeparator.Equals(doubleSeparator) && other.groupSeparator.Equals(groupSeparator) && other.groupMemberLenght.Equals(groupMemberLenght))
		{
			return other.negativeFormat.Equals(negativeFormat);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((((((((doublePrecision.GetHashCode() * 397) ^ ((doubleSeparator != null) ? doubleSeparator.GetHashCode() : 0)) * 397) ^ position.GetHashCode()) * 397) ^ ((groupSeparator != null) ? groupSeparator.GetHashCode() : 0)) * 397) ^ groupMemberLenght.GetHashCode()) * 397) ^ negativeFormat.GetHashCode();
	}
}
