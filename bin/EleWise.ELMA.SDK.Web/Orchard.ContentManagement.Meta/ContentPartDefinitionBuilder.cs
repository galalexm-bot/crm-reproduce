using System;
using System.Collections.Generic;
using System.Linq;
using Orchard.ContentManagement.MetaData.Models;

namespace Orchard.ContentManagement.MetaData.Builders;

public class ContentPartDefinitionBuilder
{
	private class FieldConfigurerImpl : ContentPartFieldDefinitionBuilder
	{
		private ContentFieldDefinition _fieldDefinition;

		private readonly ContentPartDefinition _partDefinition;

		private readonly string _fieldName;

		public override string Name => _fieldName;

		public override string FieldType => _fieldDefinition.Name;

		public override string PartName => _partDefinition.Name;

		public FieldConfigurerImpl(ContentPartFieldDefinition field, ContentPartDefinition part)
			: base(field)
		{
			_fieldDefinition = field.FieldDefinition;
			_fieldName = field.Name;
			_partDefinition = part;
		}

		public override ContentPartFieldDefinition Build()
		{
			return new ContentPartFieldDefinition(_fieldDefinition, _fieldName, _settings);
		}

		public override ContentPartFieldDefinitionBuilder OfType(ContentFieldDefinition fieldDefinition)
		{
			_fieldDefinition = fieldDefinition;
			return this;
		}

		public override ContentPartFieldDefinitionBuilder OfType(string fieldType)
		{
			_fieldDefinition = new ContentFieldDefinition(fieldType);
			return this;
		}
	}

	private readonly ContentPartDefinition _part;

	private string _name;

	private readonly IList<ContentPartFieldDefinition> _fields;

	private readonly SettingsDictionary _settings;

	public ContentPartDefinition Current { get; private set; }

	public string Name => _name;

	public ContentPartDefinitionBuilder()
		: this(new ContentPartDefinition(null))
	{
	}

	public ContentPartDefinitionBuilder(ContentPartDefinition existing)
	{
		_part = existing;
		if (existing == null)
		{
			_fields = new List<ContentPartFieldDefinition>();
			_settings = new SettingsDictionary();
			return;
		}
		_name = existing.Name;
		_fields = existing.Fields.ToList();
		_settings = new SettingsDictionary(existing.Settings.ToDictionary((KeyValuePair<string, string> kv) => kv.Key, (KeyValuePair<string, string> kv) => kv.Value));
	}

	public ContentPartDefinition Build()
	{
		return new ContentPartDefinition(_name, _fields, _settings);
	}

	public ContentPartDefinitionBuilder Named(string name)
	{
		_name = name;
		return this;
	}

	public ContentPartDefinitionBuilder RemoveField(string fieldName)
	{
		ContentPartFieldDefinition contentPartFieldDefinition = _fields.FirstOrDefault((ContentPartFieldDefinition x) => x.Name == fieldName);
		if (contentPartFieldDefinition != null)
		{
			_fields.Remove(contentPartFieldDefinition);
		}
		return this;
	}

	public ContentPartDefinitionBuilder WithSetting(string name, string value)
	{
		_settings[name] = value;
		return this;
	}

	public ContentPartDefinitionBuilder WithField(string fieldName)
	{
		return WithField(fieldName, delegate
		{
		});
	}

	public ContentPartDefinitionBuilder WithField(string fieldName, Action<ContentPartFieldDefinitionBuilder> configuration)
	{
		ContentPartFieldDefinition contentPartFieldDefinition = _fields.FirstOrDefault((ContentPartFieldDefinition x) => x.Name == fieldName);
		if (contentPartFieldDefinition != null)
		{
			ContentPartFieldDefinition[] array = _fields.Where((ContentPartFieldDefinition x) => x.Name == fieldName).ToArray();
			foreach (ContentPartFieldDefinition item in array)
			{
				_fields.Remove(item);
			}
		}
		else
		{
			contentPartFieldDefinition = new ContentPartFieldDefinition(fieldName);
		}
		FieldConfigurerImpl fieldConfigurerImpl = new FieldConfigurerImpl(contentPartFieldDefinition, _part);
		configuration(fieldConfigurerImpl);
		_fields.Add(fieldConfigurerImpl.Build());
		return this;
	}
}
