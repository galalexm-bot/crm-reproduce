using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Packaging;

internal interface IParsedProject
{
	Guid Uid { get; }

	string ProjectFileName { get; }

	string AssemblyName { get; }

	IDictionary<string, IProjectConfiguration> Configs { get; }

	string DirectoryPath { get; }

	IEnumerable<IParsedProjectItem> Items { get; }

	string GetPropertyValue(string propertyName);

	void SetGlobalProperty(string propertyName, string value);

	void ReevaluateIfNecessary();

	void AddItem(ParsedProjectItemType type, string include, IDictionary<string, string> metadata = null);

	void RemoveItem(IParsedProjectItem item);

	void SetProperty(string name, string value);

	void Save(string path = null);

	string[] Build();
}
