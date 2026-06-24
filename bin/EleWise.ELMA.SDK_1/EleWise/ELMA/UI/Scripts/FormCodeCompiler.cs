// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.FormCodeCompiler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.UI.Scripts
{
  /// <summary>Компилятор кода для форм (страниц и портлетов)</summary>
  public class FormCodeCompiler : ScriptCompiler
  {
    internal static FormCodeCompiler fcQknPj0Wh10wyERKVv;

    public static ICodeGenerator CreateGenerator(FormMetadata metadata)
    {
      int num = 2;
      FormMetadata metadata1;
      while (true)
      {
        switch (num)
        {
          case 1:
            metadata1 = metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      ICodeGenerator generator = (ICodeGenerator) FormCodeCompiler.T3Id46jrkIV5bqcxEGL(FormCodeCompiler.Q52McfjlK8KtcdV6kPU((object) (((ComponentManager) FormCodeCompiler.nBvY9ZjMxkGrQbHgT66()).GetExtensionPoints<IMetadataTypeInfo>().FirstOrDefault<IMetadataTypeInfo>((Func<IMetadataTypeInfo, bool>) (m => FormCodeCompiler.\u003C\u003Ec__DisplayClass0_0.fcieG9fY2LjMJE59WS7J((object) m) == metadata1.GetType())) ?? throw new Exception((string) FormCodeCompiler.V3fmOZjddEbUaBi5Zia(FormCodeCompiler.X7vOLaj9Xr58s6uFC85(FormCodeCompiler.DQfB0sjJNmfD32VSX3W(1051276242 - 990076387 ^ 61152285)), (object) metadata1.GetType())))));
      FormCodeCompiler.DZToE8jgwAy6kedxmJA((object) generator, (object) metadata1);
      ((GenerationParams) FormCodeCompiler.EAMT8mj56UnYPDx1adM((object) generator)).FileName = (string) FormCodeCompiler.InWFDRjjHxdGwSpuLLg((object) metadata1) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218914586);
      FormCodeCompiler.UQQNjpjLkXiGJe2SRP9(FormCodeCompiler.EAMT8mj56UnYPDx1adM((object) generator), FormCodeCompiler.UAEnsDjYxjgw8UCXnu2((object) metadata1));
      return generator;
    }

    /// <summary>Конструктор</summary>
    /// <param name="assemblyName">Имя сборки</param>
    /// <param name="metadata">Метаданные формы</param>
    /// <param name="module">Модуль сценариев</param>
    public FormCodeCompiler(string assemblyName, FormMetadata metadata, ScriptModule module)
    {
      FormCodeCompiler.tIc82ajU9Ay2nOLxHKZ();
      string assemblyName1 = assemblyName;
      IScriptModule[] modules;
      if (module == null)
        modules = new IScriptModule[0];
      else
        modules = new IScriptModule[1]
        {
          (IScriptModule) module
        };
      // ISSUE: explicit constructor call
      base.\u002Ector(assemblyName1, (IEnumerable<IScriptModule>) modules);
      int num = 12;
      string str1;
      GeneratedFileInfo generatedFileInfo;
      string str2;
      int index;
      GeneratedFileType generatedFileType;
      GeneratedFileInfo[] generatedFileInfoArray;
      while (true)
      {
        switch (num)
        {
          case 2:
            goto label_19;
          case 3:
            this.AddSourceCode((string) FormCodeCompiler.boeBgCYWG9yZRPJLAVa(FormCodeCompiler.oYex6wYB6Hhe57Q64kQ(), (object) generatedFileInfo.Data));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 6 : 1;
            continue;
          case 4:
            if (generatedFileType != GeneratedFileType.CS)
            {
              num = 16;
              continue;
            }
            goto case 3;
          case 5:
            generatedFileInfo = generatedFileInfoArray[index];
            num = 10;
            continue;
          case 6:
          case 13:
          case 15:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
            continue;
          case 7:
            object obj = FormCodeCompiler.W43B5NjzhdFhl42KQcg(FormCodeCompiler.dr31kXjc5mmiwcxFXLq((object) metadata));
            str1 = metadata.Namespace + (string) FormCodeCompiler.DQfB0sjJNmfD32VSX3W(1113862659 ^ 1113860295) + (string) FormCodeCompiler.InWFDRjjHxdGwSpuLLg((object) metadata);
            generatedFileInfoArray = (GeneratedFileInfo[]) obj;
            num = 8;
            continue;
          case 8:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
            continue;
          case 9:
            FormCodeCompiler.xleQw2YbrUk8YyBbSSx((object) this, (object) str2, (object) generatedFileInfo.Data);
            num = 15;
            continue;
          case 10:
            generatedFileType = FormCodeCompiler.SBFmLqYFEPpNWEdg76G((object) generatedFileInfo);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 4 : 4;
            continue;
          case 11:
            FormCodeCompiler.xleQw2YbrUk8YyBbSSx((object) this, FormCodeCompiler.mBtGIaYo3bcIhpBX4mL((object) str1, FormCodeCompiler.DQfB0sjJNmfD32VSX3W(1142330761 ^ 1541959139 ^ 536752698)), (object) ClassSerializationHelper.SerializeObjectByXmlToBytes((object) metadata));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 2;
            continue;
          case 12:
            FormCodeCompiler.MQmg4UjsSDjOPDiapKP((object) metadata, FormCodeCompiler.DQfB0sjJNmfD32VSX3W(--1418440330 ^ 1418454964));
            num = 7;
            continue;
          case 14:
            str2 = (string) FormCodeCompiler.mBtGIaYo3bcIhpBX4mL((object) str1, (object) generatedFileInfo.Extension);
            num = 9;
            continue;
          case 16:
            if (generatedFileType != GeneratedFileType.EmbeddedResource)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 13;
              continue;
            }
            goto case 14;
          default:
            if (index >= generatedFileInfoArray.Length)
            {
              num = 11;
              continue;
            }
            goto case 5;
        }
      }
label_19:;
    }

    public override void AddDefaultReferences()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            base.AddDefaultReferences();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.AddDefaultReferencesFromElmaConfig((string) FormCodeCompiler.DQfB0sjJNmfD32VSX3W(-398663332 ^ -398710010));
            num = 5;
            continue;
          case 4:
            FormCodeCompiler.nrGJURYh1aGFQ2LOQyB((object) this, FormCodeCompiler.DQfB0sjJNmfD32VSX3W(-218496594 ^ -218494080));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 2 : 2;
            continue;
          case 5:
            this.AddReferenceByName((string) FormCodeCompiler.DQfB0sjJNmfD32VSX3W(-1120607109 - 305487170 ^ -1426092707));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 6 : 4;
            continue;
          case 6:
            FormCodeCompiler.nrGJURYh1aGFQ2LOQyB((object) this, FormCodeCompiler.DQfB0sjJNmfD32VSX3W(95909607 + 343705423 ^ 439563440));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 3 : 4;
            continue;
          default:
            this.AddDefaultReferencesFromConfig((string) FormCodeCompiler.DQfB0sjJNmfD32VSX3W(1218962250 ^ 1218914576));
            num = 3;
            continue;
        }
      }
label_2:;
    }

    internal static object nBvY9ZjMxkGrQbHgT66() => (object) ComponentManager.Current;

    internal static object DQfB0sjJNmfD32VSX3W(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object X7vOLaj9Xr58s6uFC85([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object V3fmOZjddEbUaBi5Zia([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static Type Q52McfjlK8KtcdV6kPU([In] object obj0) => ((IMetadataTypeInfo) obj0).GeneratorType;

    internal static object T3Id46jrkIV5bqcxEGL([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static void DZToE8jgwAy6kedxmJA([In] object obj0, [In] object obj1) => ((ICodeGenerator) obj0).Metadata = (IMetadata) obj1;

    internal static object EAMT8mj56UnYPDx1adM([In] object obj0) => (object) ((ICodeGenerator) obj0).GenerationParams;

    internal static object InWFDRjjHxdGwSpuLLg([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object UAEnsDjYxjgw8UCXnu2([In] object obj0) => (object) ((FormMetadata) obj0).Namespace;

    internal static void UQQNjpjLkXiGJe2SRP9([In] object obj0, [In] object obj1) => ((GenerationParams) obj0).Namespace = (string) obj1;

    internal static bool niFcvUjmxi61B4fwvZ9() => FormCodeCompiler.fcQknPj0Wh10wyERKVv == null;

    internal static FormCodeCompiler fHQR0ujyrAWAavV1sCp() => FormCodeCompiler.fcQknPj0Wh10wyERKVv;

    internal static void tIc82ajU9Ay2nOLxHKZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void MQmg4UjsSDjOPDiapKP([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object dr31kXjc5mmiwcxFXLq([In] object obj0) => (object) FormCodeCompiler.CreateGenerator((FormMetadata) obj0);

    internal static object W43B5NjzhdFhl42KQcg([In] object obj0) => (object) ((ICodeGenerator) obj0).Generate();

    internal static GeneratedFileType SBFmLqYFEPpNWEdg76G([In] object obj0) => ((GeneratedFileInfo) obj0).Type;

    internal static object oYex6wYB6Hhe57Q64kQ() => (object) Encoding.UTF8;

    internal static object boeBgCYWG9yZRPJLAVa([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetString((byte[]) obj1);

    internal static object mBtGIaYo3bcIhpBX4mL([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void xleQw2YbrUk8YyBbSSx([In] object obj0, [In] object obj1, [In] object obj2) => ((AssemblyBuilder) obj0).AddEmbeddedResource((string) obj1, (byte[]) obj2);

    internal static bool nrGJURYh1aGFQ2LOQyB([In] object obj0, [In] object obj1) => ((AssemblyBuilder) obj0).AddReferenceByName((string) obj1);
  }
}
