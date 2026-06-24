// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.ContractAnnotationAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>Describes dependency between method input and output.</summary>
  /// <syntax>
  /// <p>Function Definition Table syntax:</p>
  /// <list>
  /// <item>FDT      ::= FDTRow [;FDTRow]*</item>
  /// <item>FDTRow   ::= Input =&gt; Output | Output &lt;= Input</item>
  /// <item>Input    ::= ParameterName: Value [, Input]*</item>
  /// <item>Output   ::= [ParameterName: Value]* {halt|stop|void|nothing|Value}</item>
  /// <item>Value    ::= true | false | null | notnull | canbenull</item>
  /// </list>
  /// If method has single input parameter, it's name could be omitted.<br />
  /// Using <c>halt</c> (or <c>void</c>/<c>nothing</c>, which is the same)
  /// for method output means that the methos doesn't return normally.<br />
  /// <c>canbenull</c> annotation is only applicable for output parameters.<br />
  /// You can use multiple <c>[ContractAnnotation]</c> for each FDT row,
  /// or use single attribute with rows separated by semicolon.<br />
  /// </syntax>
  /// <examples><list>
  /// <item><code>
  /// [ContractAnnotation("=&gt; halt")]
  /// public void TerminationMethod()
  /// </code></item>
  /// <item><code>
  /// [ContractAnnotation("halt &lt;= condition: false")]
  /// public void Assert(bool condition, string text) // regular assertion method
  /// </code></item>
  /// <item><code>
  /// [ContractAnnotation("s:null =&gt; true")]
  /// public bool IsNullOrEmpty(string s) // string.IsNullOrEmpty()
  /// </code></item>
  /// <item><code>
  /// // A method that returns null if the parameter is null,
  /// // and not null if the parameter is not null
  /// [ContractAnnotation("null =&gt; null; notnull =&gt; notnull")]
  /// public object Transform(object data)
  /// </code></item>
  /// <item><code>
  /// [ContractAnnotation("s:null=&gt;false; =&gt;true,result:notnull; =&gt;false, result:null")]
  /// public bool TryParse(string s, out Person result)
  /// </code></item>
  /// </list></examples>
  [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
  public sealed class ContractAnnotationAttribute : Attribute
  {
    private static ContractAnnotationAttribute UvfRApffqquLgpruHaGy;

    public ContractAnnotationAttribute([NotNull] string contract)
    {
      ContractAnnotationAttribute.PvxCHeffTGwgiRoAP9aA();
      // ISSUE: explicit constructor call
      this.\u002Ector(contract, false);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ContractAnnotationAttribute([NotNull] string contract, bool forceFullStates)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Contract = contract;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.ForceFullStates = forceFullStates;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 2;
            continue;
        }
      }
label_3:;
    }

    public string Contract
    {
      get => this.\u003CContract\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CContract\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public bool ForceFullStates
    {
      get => this.\u003CForceFullStates\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CForceFullStates\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    internal static void PvxCHeffTGwgiRoAP9aA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool fBXXFBffKyDQoIlluDDA() => ContractAnnotationAttribute.UvfRApffqquLgpruHaGy == null;

    internal static ContractAnnotationAttribute gDpwg2ffX5Ds1NnswSCd() => ContractAnnotationAttribute.UvfRApffqquLgpruHaGy;
  }
}
