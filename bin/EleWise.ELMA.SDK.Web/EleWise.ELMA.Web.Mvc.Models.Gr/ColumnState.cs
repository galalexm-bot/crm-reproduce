using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;

namespace EleWise.ELMA.Web.Mvc.Models.Grids;

[Serializable]
public class ColumnState : IComparable, ICloneable
{
	[OptionalField]
	private bool required;

	[NonSerialized]
	private string _lastDbName;

	[NonSerialized]
	private string _lastDbNameWithParent;

	[NonSerialized]
	private Guid _lastTypeUid;

	[NonSerialized]
	private string _lastUniqueName;

	[DefaultValue(false)]
	public bool Required
	{
		get
		{
			return required;
		}
		set
		{
			required = value;
		}
	}

	[DefaultValue(int.MinValue)]
	public int Order { get; set; }

	public string UniqueName { get; set; }

	public string DisplayName { get; set; }

	public string Name { get; set; }

	public string ContainerName { get; set; }

	public Guid TypeUid { get; set; }

	public bool Hidden { get; set; }

	[DefaultValue(false)]
	public bool ForceHidden { get; set; }

	public bool IsOnView { get; set; }

	public string WidthAttribute { get; set; }

	public bool Sortable { get; set; }

	public ColumnState()
	{
		Order = int.MinValue;
		Hidden = true;
	}

	public string GetDbName(bool withParent = false)
	{
		return GetDbName(withParent, forSortExpression: false);
	}

	internal string GetDbName(bool withParent, bool forSortExpression = false)
	{
		if (TypeUid == Guid.Empty)
		{
			return Name;
		}
		forSortExpression = forSortExpression && withParent;
		if (_lastTypeUid == TypeUid && _lastUniqueName == UniqueName && !forSortExpression)
		{
			if (!withParent)
			{
				return _lastDbName;
			}
			return _lastDbNameWithParent;
		}
		lock (this)
		{
			Type typeByUidOrNull = MetadataServiceContext.MetadataRuntimeService.GetTypeByUidOrNull(TypeUid);
			if (typeByUidOrNull != null)
			{
				IEntityMetadata entityMetadata = (IEntityMetadata)MetadataLoader.LoadMetadata(typeByUidOrNull);
				ClassMetadata classMetadata = entityMetadata as ClassMetadata;
				if (entityMetadata != null && classMetadata != null)
				{
					IEntityMetadata entityMetadata2;
					PropertyMetadata propertyMetadata;
					if (Guid.TryParse(UniqueName, out var propertyUid))
					{
						if (propertyUid == Guid.Empty)
						{
							return null;
						}
						entityMetadata2 = (IEntityMetadata)MetadataLoader.GetRealMetadataForProperty(classMetadata, propertyUid);
						propertyMetadata = classMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == propertyUid);
					}
					else
					{
						entityMetadata2 = (IEntityMetadata)MetadataLoader.GetRealMetadataForProperty(classMetadata, UniqueName);
						propertyMetadata = classMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == UniqueName);
					}
					if (propertyMetadata != null)
					{
						string text = FormatFullColumnDescription(entityMetadata2 ?? entityMetadata, propertyMetadata, forSortExpression);
						if (forSortExpression)
						{
							return text;
						}
						_lastDbName = propertyMetadata.Name;
						_lastDbNameWithParent = text;
						_lastTypeUid = TypeUid;
						_lastUniqueName = UniqueName;
						return withParent ? text : propertyMetadata.Name;
					}
				}
			}
			_lastDbName = null;
			_lastDbNameWithParent = null;
			_lastTypeUid = TypeUid;
			_lastUniqueName = UniqueName;
			return null;
		}
	}

	public int CompareTo(object obj)
	{
		if (!(obj is ColumnState columnState))
		{
			return -1;
		}
		if (columnState == this)
		{
			return 0;
		}
		int num = Math.Sign(columnState.Order - Order);
		if (num == 0 && columnState != this)
		{
			return Math.Sign(columnState.GetHashCode() - GetHashCode());
		}
		return num;
	}

	public static string FormatFullColumnDescription(IEntityMetadata metadata, PropertyMetadata property)
	{
		return FormatFullColumnDescription(metadata, property, forSortExpression: false);
	}

	internal static string FormatFullColumnDescription(IEntityMetadata metadata, PropertyMetadata property, bool forSortExpression)
	{
		string arg = ((metadata is EntityMetadata) ? ((EntityMetadata)metadata).TableName : string.Empty);
		string arg2 = (forSortExpression ? PropertyHelper.GetSortExpression(property, property.Name) : property.Name);
		return $"{metadata.FullTypeName}:{arg}:{arg2}";
	}

	public static string GetDbColumnDescription(string desc)
	{
		if (string.IsNullOrEmpty(desc))
		{
			return string.Empty;
		}
		string[] array = desc.Split(new char[1] { ':' }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length != 3)
		{
			return string.Empty;
		}
		string entityName = array[0];
		return CustomPropertyProjection.GetStringFromExpression(array[2], entityName);
	}

	public object Clone()
	{
		return new ColumnState
		{
			Required = Required,
			Order = Order,
			UniqueName = UniqueName,
			DisplayName = DisplayName,
			Name = Name,
			ContainerName = ContainerName,
			TypeUid = TypeUid,
			Hidden = Hidden,
			ForceHidden = ForceHidden,
			IsOnView = IsOnView,
			WidthAttribute = WidthAttribute,
			Sortable = Sortable
		};
	}
}
