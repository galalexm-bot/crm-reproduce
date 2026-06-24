using EleWise.ELMA.Model;

namespace EleWise.ELMA.Web.Content;

public static class ContentActionStatics
{
	public static string ConfigurationPageContentActionId(string name, RuntimeVersion version)
	{
		if (version != 0 && version == RuntimeVersion.Version2)
		{
			return "configuration_pagev2_" + name;
		}
		return "configuration-page-" + name;
	}
}
