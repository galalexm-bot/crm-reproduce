using System.Collections.Generic;
using System.Drawing;
using EleWise.ELMA.Packaging.Properties;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

public static class ManifestComponentTypeDescription
{
	public static List<ManifestComponentType> ImportedTypes => new List<ManifestComponentType>
	{
		ManifestComponentType.Module,
		ManifestComponentType.Process,
		ManifestComponentType.ProcessPackage,
		ManifestComponentType.Report,
		ManifestComponentType.Application,
		ManifestComponentType.ExternalApplication,
		ManifestComponentType.MobileApplication
	};

	public static string DisplayName(this ManifestComponentType type)
	{
		bool? flag = null;
		if (SR.DesignMode)
		{
			flag = SR.DesignMode;
			SR.DesignMode = false;
		}
		string result = type switch
		{
			ManifestComponentType.Module => SR.T("Модуль"), 
			ManifestComponentType.Application => SR.T("Приложение"), 
			ManifestComponentType.Solution => SR.T("Решение"), 
			ManifestComponentType.MobileApplication => SR.T("Мобильное приложение"), 
			ManifestComponentType.ProcessPackage => SR.T("Пакет процессов"), 
			ManifestComponentType.Process => SR.T("Бизнес-процесс"), 
			ManifestComponentType.ExternalApplication => SR.T("Внешнее приложение"), 
			ManifestComponentType.Report => SR.T("Отчет"), 
			ManifestComponentType.Platform => SR.T("Платформа"), 
			_ => null, 
		};
		if (!SR.DesignMode && flag.HasValue)
		{
			SR.DesignMode = flag == true;
		}
		return result;
	}

	public static Color Color(this ManifestComponentType type)
	{
		return type switch
		{
			ManifestComponentType.Application => ColorTranslator.FromHtml("#B3D1E8"), 
			ManifestComponentType.Module => ColorTranslator.FromHtml("#FDEB9B"), 
			ManifestComponentType.ExternalApplication => ColorTranslator.FromHtml("#D6D6D6"), 
			ManifestComponentType.MobileApplication => ColorTranslator.FromHtml("#F5B8B1"), 
			ManifestComponentType.Process => ColorTranslator.FromHtml("#CDE6BB"), 
			ManifestComponentType.ProcessPackage => ColorTranslator.FromHtml("#FCD4A5"), 
			ManifestComponentType.Report => ColorTranslator.FromHtml("#99DDD8"), 
			ManifestComponentType.Solution => ColorTranslator.FromHtml("#D4A9D2"), 
			_ => System.Drawing.Color.Gray, 
		};
	}

	public static Color TextColor(this ManifestComponentType type)
	{
		return type switch
		{
			ManifestComponentType.Application => ColorTranslator.FromHtml("#0962B9"), 
			ManifestComponentType.Module => ColorTranslator.FromHtml("#CE8616"), 
			ManifestComponentType.ExternalApplication => ColorTranslator.FromHtml("#808080"), 
			ManifestComponentType.MobileApplication => ColorTranslator.FromHtml("#E74D3D"), 
			ManifestComponentType.Process => ColorTranslator.FromHtml("#599831"), 
			ManifestComponentType.ProcessPackage => ColorTranslator.FromHtml("#D85523"), 
			ManifestComponentType.Report => ColorTranslator.FromHtml("#038478"), 
			ManifestComponentType.Solution => ColorTranslator.FromHtml("#663181"), 
			_ => System.Drawing.Color.Gray, 
		};
	}

	public static Image Icon(this ManifestComponentType type)
	{
		return type switch
		{
			ManifestComponentType.Application => Resources.Application, 
			ManifestComponentType.Module => Resources.Module, 
			ManifestComponentType.ExternalApplication => Resources.ExternalApplication, 
			ManifestComponentType.MobileApplication => Resources.MobileApplication, 
			ManifestComponentType.Process => Resources.BPM, 
			ManifestComponentType.ProcessPackage => Resources.ProcessPackage, 
			ManifestComponentType.Report => Resources.Report, 
			ManifestComponentType.Solution => Resources.Solution, 
			ManifestComponentType.Platform => Resources.Platform, 
			_ => Resources.BPM, 
		};
	}
}
