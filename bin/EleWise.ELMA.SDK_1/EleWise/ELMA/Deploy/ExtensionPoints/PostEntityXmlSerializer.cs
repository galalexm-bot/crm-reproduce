// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ExtensionPoints.PostEntityXmlSerializer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.ExtensionPoints
{
  public abstract class PostEntityXmlSerializer : IPostEntityXmlSerializer
  {
    private static PostEntityXmlSerializer hX3rSxEgv8Au2vHAKflp;

    public virtual string Replace(string serializedObject) => serializedObject;

    public virtual string UndoReplace(string serializedObject) => serializedObject;

    protected PostEntityXmlSerializer()
    {
      PostEntityXmlSerializer.LZYDFUEguT2iuKaj4y5g();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void LZYDFUEguT2iuKaj4y5g() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool J9bDvsEg8J5Y6PJxTxkA() => PostEntityXmlSerializer.hX3rSxEgv8Au2vHAKflp == null;

    internal static PostEntityXmlSerializer qSRgnPEgZTa8y5GqudZT() => PostEntityXmlSerializer.hX3rSxEgv8Au2vHAKflp;
  }
}
