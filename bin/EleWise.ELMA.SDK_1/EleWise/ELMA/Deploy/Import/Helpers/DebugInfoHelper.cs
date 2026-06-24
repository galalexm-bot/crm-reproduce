// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.Helpers.DebugInfoHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import.Helpers
{
  /// <summary>
  /// Хэлпер для добавления/удаления ссылок на файлы с исходными текстами для возможности удаленной отладки после компиляции
  /// </summary>
  internal class DebugInfoHelper
  {
    internal static DebugInfoHelper AXyEBNEyiRK1FONMRw2w;

    /// <summary>Добавить ссылку на файл с исходным кодом для дебага</summary>
    /// <param name="scriptModule">Исходный код</param>
    /// <param name="filenames">Словарь с оригинальными именами файлов</param>
    public static void AddDebugLine(
      ScriptModule scriptModule,
      IDictionary<string, string> filenames)
    {
      if (string.IsNullOrEmpty(scriptModule?.SourceCode))
        return;
      string key = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876112309), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951212114), (object) scriptModule.Uid);
      string filename;
      if (!filenames.TryGetValue(key, out filename) || string.IsNullOrEmpty(filename))
        return;
      string str = DebugInfoHelper.DebugLine((object) filename);
      scriptModule.SourceCode = str + scriptModule.SourceCode;
    }

    /// <summary>
    /// Удалить ссылку на файл с исходным кодом функций для дебага
    /// </summary>
    /// <param name="scriptModule">Исходный код</param>
    /// <param name="filenames">Словарь с оригинальными именами файлов</param>
    public static void RemoveDebugLine(
      ScriptModule scriptModule,
      IDictionary<string, string> filenames)
    {
      if (string.IsNullOrEmpty(scriptModule.SourceCode))
        return;
      string key = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515011021), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757354870), (object) scriptModule.Uid);
      string filename;
      if (!filenames.TryGetValue(key, out filename) || string.IsNullOrEmpty(filename))
        return;
      string str = DebugInfoHelper.DebugLine((object) filename);
      int startIndex = scriptModule.SourceCode.IndexOf(str);
      if (startIndex <= -1)
        return;
      scriptModule.SourceCode = scriptModule.SourceCode.Remove(startIndex, str.Length);
    }

    private static string DebugLine(object filename) => (string) DebugInfoHelper.zdDVgMEyXKNbDkRJcNLK(DebugInfoHelper.suSa54EyKiqNZPR3DK1Y(1994213607 >> 4 ^ 124353242), filename, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757354836));

    public DebugInfoHelper()
    {
      DebugInfoHelper.QeZcPnEyTO781sVBPtY3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object suSa54EyKiqNZPR3DK1Y(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object zdDVgMEyXKNbDkRJcNLK([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static bool dQocE6EyRodYuDqF6v9O() => DebugInfoHelper.AXyEBNEyiRK1FONMRw2w == null;

    internal static DebugInfoHelper KTdfdXEyqtXCuCkAy7QF() => DebugInfoHelper.AXyEBNEyiRK1FONMRw2w;

    internal static void QeZcPnEyTO781sVBPtY3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
