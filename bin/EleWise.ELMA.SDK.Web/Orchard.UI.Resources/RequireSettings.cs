using System;
using System.Collections.Generic;
using System.Linq;

namespace Orchard.UI.Resources;

public class RequireSettings
{
	private Dictionary<string, string> _attributes;

	public string BasePath { get; set; }

	public string Type { get; set; }

	public string Name { get; set; }

	public string Culture { get; set; }

	public bool DebugMode { get; set; }

	public bool CdnMode { get; set; }

	public ResourceLocation Location { get; set; }

	public string Condition { get; set; }

	public Action<ResourceDefinition> InlineDefinition { get; set; }

	public Dictionary<string, string> Attributes
	{
		get
		{
			return _attributes ?? (_attributes = new Dictionary<string, string>());
		}
		set
		{
			_attributes = value;
		}
	}

	public bool HasAttributes
	{
		get
		{
			if (_attributes != null)
			{
				return _attributes.Any((KeyValuePair<string, string> a) => a.Value != null);
			}
			return false;
		}
	}

	public RequireSettings AtHead()
	{
		return AtLocation(ResourceLocation.Head);
	}

	public RequireSettings AtFoot()
	{
		return AtLocation(ResourceLocation.Foot);
	}

	public RequireSettings AtLocation(ResourceLocation location)
	{
		Location = (ResourceLocation)Math.Max((int)Location, (int)location);
		return this;
	}

	public RequireSettings UseCulture(string cultureName)
	{
		if (!string.IsNullOrEmpty(cultureName))
		{
			Culture = cultureName;
		}
		return this;
	}

	public RequireSettings UseDebugMode()
	{
		return UseDebugMode(debugMode: true);
	}

	public RequireSettings UseDebugMode(bool debugMode)
	{
		DebugMode |= debugMode;
		return this;
	}

	public RequireSettings UseCdn()
	{
		return UseCdn(cdn: true);
	}

	public RequireSettings UseCdn(bool cdn)
	{
		CdnMode |= cdn;
		return this;
	}

	public RequireSettings WithBasePath(string basePath)
	{
		BasePath = basePath;
		return this;
	}

	public RequireSettings UseCondition(string condition)
	{
		Condition = Condition ?? condition;
		return this;
	}

	public RequireSettings Define(Action<ResourceDefinition> resourceDefinition)
	{
		if (resourceDefinition != null)
		{
			Action<ResourceDefinition> previous = InlineDefinition;
			if (previous != null)
			{
				InlineDefinition = delegate(ResourceDefinition r)
				{
					previous(r);
					resourceDefinition(r);
				};
			}
			else
			{
				InlineDefinition = resourceDefinition;
			}
		}
		return this;
	}

	public RequireSettings SetAttribute(string name, string value)
	{
		if (_attributes == null)
		{
			_attributes = new Dictionary<string, string>();
		}
		_attributes[name] = value;
		return this;
	}

	private Dictionary<string, string> MergeAttributes(RequireSettings other)
	{
		if (_attributes == null)
		{
			if (other._attributes != null)
			{
				return new Dictionary<string, string>(other._attributes);
			}
			return null;
		}
		if (other._attributes == null)
		{
			return new Dictionary<string, string>(_attributes);
		}
		Dictionary<string, string> dictionary = new Dictionary<string, string>(_attributes);
		foreach (KeyValuePair<string, string> attribute in other._attributes)
		{
			dictionary[attribute.Key] = attribute.Value;
		}
		return dictionary;
	}

	public RequireSettings Combine(RequireSettings other)
	{
		RequireSettings requireSettings = new RequireSettings
		{
			Name = Name,
			Type = Type
		}.AtLocation(Location).AtLocation(other.Location).WithBasePath(BasePath)
			.WithBasePath(other.BasePath)
			.UseCdn(CdnMode)
			.UseCdn(other.CdnMode)
			.UseDebugMode(DebugMode)
			.UseDebugMode(other.DebugMode)
			.UseCulture(Culture)
			.UseCulture(other.Culture)
			.UseCondition(Condition)
			.UseCondition(other.Condition)
			.Define(InlineDefinition)
			.Define(other.InlineDefinition);
		requireSettings._attributes = MergeAttributes(other);
		return requireSettings;
	}
}
