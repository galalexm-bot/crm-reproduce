// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.NotifyPropertyChangedInvocatorAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Indicates that the method is contained in a type that implements
  /// <c>System.ComponentModel.INotifyPropertyChanged</c> interface and this method
  /// is used to notify that some property value changed.
  /// </summary>
  /// <remarks>
  /// The method should be non-static and conform to one of the supported signatures:
  /// <list>
  /// <item><c>NotifyChanged(string)</c></item>
  /// <item><c>NotifyChanged(params string[])</c></item>
  /// <item><c>NotifyChanged{T}(Expression{Func{T}})</c></item>
  /// <item><c>NotifyChanged{T,U}(Expression{Func{T,U}})</c></item>
  /// <item><c>SetProperty{T}(ref T, T, string)</c></item>
  /// </list>
  /// </remarks>
  /// <example><code>
  /// public class Foo : INotifyPropertyChanged {
  ///   public event PropertyChangedEventHandler PropertyChanged;
  ///   [NotifyPropertyChangedInvocator]
  ///   protected virtual void NotifyChanged(string propertyName) { ... }
  /// 
  ///   private string _name;
  ///   public string Name {
  ///     get { return _name; }
  ///     set { _name = value; NotifyChanged("LastName"); /* Warning */ }
  ///   }
  /// }
  /// </code>
  /// Examples of generated notifications:
  /// <list>
  /// <item><c>NotifyChanged("Property")</c></item>
  /// <item><c>NotifyChanged(() =&gt; Property)</c></item>
  /// <item><c>NotifyChanged((VM x) =&gt; x.Property)</c></item>
  /// <item><c>SetProperty(ref myField, value, "Property")</c></item>
  /// </list>
  /// </example>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class NotifyPropertyChangedInvocatorAttribute : Attribute
  {
    internal static NotifyPropertyChangedInvocatorAttribute wfeVKuffVPpuN5DOia8h;

    public NotifyPropertyChangedInvocatorAttribute()
    {
      NotifyPropertyChangedInvocatorAttribute.TCasy3ffROEboD50pGpb();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public NotifyPropertyChangedInvocatorAttribute(string parameterName)
    {
      NotifyPropertyChangedInvocatorAttribute.TCasy3ffROEboD50pGpb();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.ParameterName = parameterName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    public string ParameterName
    {
      get => this.\u003CParameterName\u003Ek__BackingField;
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
              this.\u003CParameterName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
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

    internal static void TCasy3ffROEboD50pGpb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool x4aKu0ffSNYhrLxrtsrF() => NotifyPropertyChangedInvocatorAttribute.wfeVKuffVPpuN5DOia8h == null;

    internal static NotifyPropertyChangedInvocatorAttribute KRG70JffiBfcToEdZklH() => NotifyPropertyChangedInvocatorAttribute.wfeVKuffVPpuN5DOia8h;
  }
}
