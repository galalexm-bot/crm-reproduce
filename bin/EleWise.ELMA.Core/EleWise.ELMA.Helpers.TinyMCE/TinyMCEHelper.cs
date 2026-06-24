using Bridge;

namespace EleWise.ELMA.Helpers.TinyMCE;

[External]
public static class TinyMCEHelper
{
	[Template("tinyMCE.get({textAreaId})")]
	public static extern Editor Get(string textAreaId);

	[Template("tinyMCE_GZ.init({themes: 'modern', languages: 'universal', disk_cache: false, accessibility_warnings: false }, runTinyMCESetupFunction, {settings})")]
	public static extern void Init(Settings settings);

	[Template("(typeof(runTinyMCESetupFunction) !== 'undefined')")]
	public static extern bool ScriptLoaded();
}
