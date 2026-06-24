// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.BasePasswordFilePreviewCreatorEx
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>
  /// Расширение базового класса генератора файлов предпросмотра зашифрованных файлов
  /// </summary>
  public abstract class BasePasswordFilePreviewCreatorEx : 
    BaseFilePreviewCreatorEx,
    IPasswordFilePreviewCreatorEx,
    IFilePreviewCreatorEx,
    IFilePreviewCreator,
    IPasswordFilePreviewCreator
  {
    internal static BasePasswordFilePreviewCreatorEx l8bB8vGOaUWrgjpCa9Nr;

    /// <inheritdoc />
    public abstract bool CheckPassword(BinaryFile file, string password);

    /// <inheritdoc />
    public virtual void Create(string path, BinaryFile file, string password)
    {
    }

    Process IPasswordFilePreviewCreatorEx.CreateWithExternalCreator(
      string filePreviewDir,
      BinaryFile file,
      string password)
    {
      return (Process) BasePasswordFilePreviewCreatorEx.jZVp8dGOwQvdId0VUW8E((object) this, (object) filePreviewDir, (object) file, (object) password);
    }

    protected BasePasswordFilePreviewCreatorEx()
    {
      BasePasswordFilePreviewCreatorEx.BHRMTRGO4Cjr6kkacl0N();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object jZVp8dGOwQvdId0VUW8E(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((BaseFilePreviewCreatorEx) obj0).CreateWithExternalCreator((string) obj1, (BinaryFile) obj2, (string) obj3);
    }

    internal static bool imiXQEGODknZbd2AdSHp() => BasePasswordFilePreviewCreatorEx.l8bB8vGOaUWrgjpCa9Nr == null;

    internal static BasePasswordFilePreviewCreatorEx hB86NtGOtP3HCRgwl7ZA() => BasePasswordFilePreviewCreatorEx.l8bB8vGOaUWrgjpCa9Nr;

    internal static void BHRMTRGO4Cjr6kkacl0N() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
