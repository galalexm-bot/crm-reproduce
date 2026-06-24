using System;
using System.Collections.Generic;
using System.Linq;
using Orchard.ContentManagement.MetaData.Models;

namespace Orchard.ContentManagement.MetaData.Builders;

public class ContentTypeDefinitionBuilder
{
	private class PartConfigurerImpl : ContentTypePartDefinitionBuilder
	{
		private readonly ContentPartDefinition _partDefinition;

		public ContentTypePartDefinition Current { get; private set; }

		public PartConfigurerImpl(ContentTypePartDefinition part)
			: base(part)
		{
			Current = part;
			_partDefinition = part.PartDefinition;
		}

		public override ContentTypePartDefinition Build()
		{
			return new ContentTypePartDefinition(_partDefinition, _settings);
		}
	}

	private string _name;

	private string _displayName;

	private readonly IList<ContentTypePartDefinition> _parts;

	private readonly SettingsDictionary _settings;

	public ContentTypeDefinition Current { get; private set; }

	public ContentTypeDefinitionBuilder()
		: this(new ContentTypeDefinition(null, null))
	{
	}

	public ContentTypeDefinitionBuilder(ContentTypeDefinition existing)
	{
		Current = existing;
		if (existing == null)
		{
			_parts = new List<ContentTypePartDefinition>();
			_settings = new SettingsDictionary();
			return;
		}
		_name = existing.Name;
		_displayName = existing.DisplayName;
		_parts = existing.Parts.ToList();
		_settings = new SettingsDictionary(existing.Settings.ToDictionary((KeyValuePair<string, string> kv) => kv.Key, (KeyValuePair<string, string> kv) => kv.Value));
	}

	public ContentTypeDefinition Build()
	{
		return new ContentTypeDefinition(_name, _displayName, _parts, _settings);
	}

	public ContentTypeDefinitionBuilder Named(string name)
	{
		_name = name;
		return this;
	}

	public ContentTypeDefinitionBuilder DisplayedAs(string displayName)
	{
		_displayName = displayName;
		return this;
	}

	public ContentTypeDefinitionBuilder WithSetting(string name, string value)
	{
		_settings[name] = value;
		return this;
	}

	public ContentTypeDefinitionBuilder RemovePart(string partName)
	{
		ContentTypePartDefinition contentTypePartDefinition = _parts.SingleOrDefault((ContentTypePartDefinition x) => x.PartDefinition.Name == partName);
		if (contentTypePartDefinition != null)
		{
			_parts.Remove(contentTypePartDefinition);
		}
		return this;
	}

	public ContentTypeDefinitionBuilder WithPart(string partName)
	{
		return WithPart(partName, delegate
		{
		});
	}

	public ContentTypeDefinitionBuilder WithPart(string partName, Action<ContentTypePartDefinitionBuilder> configuration)
	{
		return WithPart(new ContentPartDefinition(partName), configuration);
	}

	public ContentTypeDefinitionBuilder WithPart(ContentPartDefinition partDefinition, Action<ContentTypePartDefinitionBuilder> configuration)
	{
		ContentTypePartDefinition contentTypePartDefinition = _parts.SingleOrDefault((ContentTypePartDefinition x) => x.PartDefinition.Name == partDefinition.Name);
		if (contentTypePartDefinition != null)
		{
			_parts.Remove(contentTypePartDefinition);
		}
		else
		{
			contentTypePartDefinition = new ContentTypePartDefinition(partDefinition, new SettingsDictionary());
		}
		PartConfigurerImpl partConfigurerImpl = new PartConfigurerImpl(contentTypePartDefinition);
		configuration(partConfigurerImpl);
		_parts.Add(partConfigurerImpl.Build());
		return this;
	}
}
