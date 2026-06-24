// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.RollingFileAppender
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using log4net.Appender;
using log4net.Core;
using log4net.Util;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Logging
{
  /// <summary>
  /// Appender that rolls log files based on size or date or both.
  /// </summary>
  /// <remarks>
  /// <para>
  /// RollingFileAppender can roll log files based on size or date or both
  /// depending on the setting of the <see cref="P:EleWise.ELMA.Logging.RollingFileAppender.RollingStyle" /> property.
  /// When set to <see cref="F:log4net.Appender.RollingFileAppender.RollingMode.Size" /> the log file will be rolled
  /// once its size exceeds the <see cref="P:EleWise.ELMA.Logging.RollingFileAppender.MaximumFileSize" />.
  /// When set to <see cref="F:log4net.Appender.RollingFileAppender.RollingMode.Date" /> the log file will be rolled
  /// once the date boundary specified in the <see cref="P:EleWise.ELMA.Logging.RollingFileAppender.DatePattern" /> property
  /// is crossed.
  /// When set to <see cref="F:log4net.Appender.RollingFileAppender.RollingMode.Composite" /> the log file will be
  /// rolled once the date boundary specified in the <see cref="P:EleWise.ELMA.Logging.RollingFileAppender.DatePattern" /> property
  /// is crossed, but within a date boundary the file will also be rolled
  /// once its size exceeds the <see cref="P:EleWise.ELMA.Logging.RollingFileAppender.MaximumFileSize" />.
  /// When set to <see cref="F:log4net.Appender.RollingFileAppender.RollingMode.Once" /> the log file will be rolled when
  /// the appender is configured. This effectively means that the log file can be
  /// rolled once per program execution.
  /// </para>
  /// <para>
  /// A of few additional optional features have been added:
  /// <list type="bullet">
  /// <item>Attach date pattern for current log file <see cref="P:EleWise.ELMA.Logging.RollingFileAppender.StaticLogFileName" /></item>
  /// <item>Backup number increments for newer files <see cref="P:EleWise.ELMA.Logging.RollingFileAppender.CountDirection" /></item>
  /// <item>Infinite number of backups by file size <see cref="P:EleWise.ELMA.Logging.RollingFileAppender.MaxSizeRollBackups" /></item>
  /// </list>
  /// </para>
  /// 
  /// <note>
  /// <para>
  /// For large or infinite numbers of backup files a <see cref="P:EleWise.ELMA.Logging.RollingFileAppender.CountDirection" />
  /// greater than zero is highly recommended, otherwise all the backup files need
  /// to be renamed each time a new backup is created.
  /// </para>
  /// <para>
  /// When Date/Time based rolling is used setting <see cref="P:EleWise.ELMA.Logging.RollingFileAppender.StaticLogFileName" />
  /// to <see langword="true" /> will reduce the number of file renamings to few or none.
  /// </para>
  /// </note>
  /// 
  /// <note type="caution">
  /// <para>
  /// Changing <see cref="P:EleWise.ELMA.Logging.RollingFileAppender.StaticLogFileName" /> or <see cref="P:EleWise.ELMA.Logging.RollingFileAppender.CountDirection" /> without clearing
  /// the log file directory of backup files will cause unexpected and unwanted side effects.
  /// </para>
  /// </note>
  /// 
  /// <para>
  /// If Date/Time based rolling is enabled this appender will attempt to roll existing files
  /// in the directory without a Date/Time tag based on the last write date of the base log file.
  /// The appender only rolls the log file when a message is logged. If Date/Time based rolling
  /// is enabled then the appender will not roll the log file at the Date/Time boundary but
  /// at the point when the next message is logged after the boundary has been crossed.
  /// </para>
  /// 
  /// <para>
  /// The <see cref="T:EleWise.ELMA.Logging.RollingFileAppender" /> extends the <see cref="T:log4net.Appender.FileAppender" /> and
  /// has the same behavior when opening the log file.
  /// The appender will first try to open the file for writing when <see cref="M:EleWise.ELMA.Logging.RollingFileAppender.ActivateOptions" />
  /// is called. This will typically be during configuration.
  /// If the file cannot be opened for writing the appender will attempt
  /// to open the file again each time a message is logged to the appender.
  /// If the file cannot be opened for writing when a message is logged then
  /// the message will be discarded by this appender.
  /// </para>
  /// <para>
  /// When rolling a backup file necessitates deleting an older backup file the
  /// file to be deleted is moved to a temporary name before being deleted.
  /// </para>
  /// 
  /// <note type="caution">
  /// <para>
  /// A maximum number of backup files when rolling on date/time boundaries is not supported.
  /// </para>
  /// </note>
  /// </remarks>
  /// <author>Nicko Cadell</author>
  /// <author>Gert Driesen</author>
  /// <author>Aspi Havewala</author>
  /// <author>Douglas de la Torre</author>
  /// <author>Edward Smit</author>
  public class RollingFileAppender : FileAppender
  {
    /// <summary>
    /// The fully qualified type of the RollingFileAppender class.
    /// </summary>
    /// <remarks>
    /// Used by the internal logger to record the Type of the
    /// log message.
    /// </remarks>
    private static readonly Type declaringType;
    private static readonly Type localDateTimeType;
    protected static readonly Type universalDateTimeType;
    /// <summary>
    /// The actual formatted filename that is currently being written to
    /// or will be the file transferred to on roll over
    /// (based on staticLogFileName).
    /// </summary>
    protected string m_scheduledFilename;
    /// <summary>
    /// The timestamp when we shall next recompute the filename.
    /// </summary>
    private DateTime m_nextCheck;
    /// <summary>Holds date of last roll over</summary>
    protected DateTime m_now;
    /// <summary>The type of rolling done</summary>
    private RollingFileAppender.RollPoint m_rollPoint;
    /// <summary>How many sized based backups have been made so far</summary>
    private int m_curSizeRollBackups;
    /// <summary>The rolling mode used in this appender.</summary>
    private log4net.Appender.RollingFileAppender.RollingMode m_rollingStyle;
    /// <summary>Cache flag set if we are rolling by date.</summary>
    protected bool m_rollDate;
    /// <summary>Cache flag set if we are rolling by size.</summary>
    private bool m_rollSize;
    /// <summary>
    /// FileName provided in configuration.  Used for rolling properly
    /// </summary>
    private string m_baseFileName;
    /// <summary>The 1st of January 1970 in UTC</summary>
    private static readonly DateTime s_date1970;
    private static RollingFileAppender Ai0EvyhyYJi1upEKrP9d;

    /// <summary>
    /// Initializes a new instance of the <see cref="T:EleWise.ELMA.Logging.RollingFileAppender" /> class.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Default constructor.
    /// </para>
    /// </remarks>
    public RollingFileAppender()
    {
      RollingFileAppender.i3BMnghysbmkjd0Qxytt();
      this.m_nextCheck = DateTime.MaxValue;
      this.m_rollingStyle = log4net.Appender.RollingFileAppender.RollingMode.Composite;
      this.m_rollDate = true;
      this.m_rollSize = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.PreserveLogFileNameExtension = false;
            num = 4;
            continue;
          case 2:
            this.MaxDateRollBackups = -1;
            num = 7;
            continue;
          case 3:
            this.CountDirection = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
            continue;
          case 4:
            RollingFileAppender.KbFwdIhyzm1srC5SHZ0J((object) this, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 6 : 5;
            continue;
          case 5:
            this.DatePattern = (string) RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-1837662597 ^ -1837828397);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
            continue;
          case 6:
            goto label_3;
          case 7:
            this.MaxFileSize = 10485760L;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 3 : 1;
            continue;
          default:
            this.MaxSizeRollBackups = 0;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Gets or sets the strategy for determining the current date and time. The default
    /// implementation is to use LocalDateTime which internally calls through to DateTime.Now.
    /// DateTime.UtcNow may be used on frameworks newer than .NET 1.0 by specifying
    /// log4net.Appender.RollingFileAppender.UniversalDateTime.
    /// </summary>
    /// <value>
    /// An implementation of the <see cref="T:log4net.Appender.RollingFileAppender.IDateTime" /> interface which returns the current date and time.
    /// </value>
    /// <remarks>
    /// <para>
    /// Gets or sets the <see cref="T:log4net.Appender.RollingFileAppender.IDateTime" /> used to return the current date and time.
    /// </para>
    /// <para>
    /// There are two built strategies for determining the current date and time,
    /// log4net.Appender.RollingFileAppender.LocalDateTime
    /// and log4net.Appender.RollingFileAppender.UniversalDateTime.
    /// </para>
    /// <para>
    /// The default strategy is log4net.Appender.RollingFileAppender.LocalDateTime.
    /// </para>
    /// </remarks>
    public log4net.Appender.RollingFileAppender.IDateTime DateTimeStrategy
    {
      get => this.\u003CDateTimeStrategy\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CDateTimeStrategy\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
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

    /// <summary>
    /// Gets or sets the date pattern to be used for generating file names
    /// when rolling over on date.
    /// </summary>
    /// <value>
    /// The date pattern to be used for generating file names when rolling
    /// over on date.
    /// </value>
    /// <remarks>
    /// <para>
    /// Takes a string in the same format as expected by
    /// <see cref="T:log4net.DateFormatter.SimpleDateFormatter" />.
    /// </para>
    /// <para>
    /// This property determines the rollover schedule when rolling over
    /// on date.
    /// </para>
    /// </remarks>
    public string DatePattern
    {
      get => this.\u003CDatePattern\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CDatePattern\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
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

    /// <summary>
    /// Gets or sets the maximum number of backup files that are kept before
    /// the oldest is erased.
    /// </summary>
    /// <value>
    /// The maximum number of backup files that are kept before the oldest is
    /// erased.
    /// </value>
    /// <remarks>
    /// <para>
    /// If set to zero, then there will be no backup files and the log file
    /// will be truncated when it reaches <see cref="P:EleWise.ELMA.Logging.RollingFileAppender.MaxFileSize" />.
    /// </para>
    /// <para>
    /// If a negative number is supplied then no deletions will be made.  Note
    /// that this could result in very slow performance as a large number of
    /// files are rolled over unless <see cref="P:EleWise.ELMA.Logging.RollingFileAppender.CountDirection" /> is used.
    /// </para>
    /// <para>
    /// The maximum applies to <b>each</b> time based group of files and
    /// <b>not</b> the total.
    /// </para>
    /// </remarks>
    public int MaxSizeRollBackups
    {
      get => this.\u003CMaxSizeRollBackups\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CMaxSizeRollBackups\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
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

    /// <summary>
    /// Gets or sets the maximum number date of backup files that are kept before the oldest is erased.
    /// </summary>
    /// <value>
    /// The maximum number of date backup files that are kept before the oldest is erased.
    /// </value>
    /// <remarks>
    /// </remarks>
    public int MaxDateRollBackups
    {
      get => this.\u003CMaxDateRollBackups\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CMaxDateRollBackups\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
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

    /// <summary>
    /// Gets or sets the maximum size that the output file is allowed to reach
    /// before being rolled over to backup files.
    /// </summary>
    /// <value>
    /// The maximum size in bytes that the output file is allowed to reach before being
    /// rolled over to backup files.
    /// </value>
    /// <remarks>
    /// <para>
    /// This property is equivalent to <see cref="P:EleWise.ELMA.Logging.RollingFileAppender.MaximumFileSize" /> except
    /// that it is required for differentiating the setter taking a
    /// <see cref="T:System.Int64" /> argument from the setter taking a <see cref="T:System.String" />
    /// argument.
    /// </para>
    /// <para>
    /// The default maximum file size is 10MB (10*1024*1024).
    /// </para>
    /// </remarks>
    public long MaxFileSize
    {
      get => this.\u003CMaxFileSize\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CMaxFileSize\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
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

    /// <summary>
    /// Gets or sets the maximum size that the output file is allowed to reach
    /// before being rolled over to backup files.
    /// </summary>
    /// <value>
    /// The maximum size that the output file is allowed to reach before being
    /// rolled over to backup files.
    /// </value>
    /// <remarks>
    /// <para>
    /// This property allows you to specify the maximum size with the
    /// suffixes "KB", "MB" or "GB" so that the size is interpreted being
    /// expressed respectively in kilobytes, megabytes or gigabytes.
    /// </para>
    /// <para>
    /// For example, the value "10KB" will be interpreted as 10240 bytes.
    /// </para>
    /// <para>
    /// The default maximum file size is 10MB.
    /// </para>
    /// <para>
    /// If you have the option to set the maximum file size programmatically
    /// consider using the <see cref="P:EleWise.ELMA.Logging.RollingFileAppender.MaxFileSize" /> property instead as this
    /// allows you to set the size in bytes as a <see cref="T:System.Int64" />.
    /// </para>
    /// </remarks>
    public string MaximumFileSize
    {
      get
      {
        int num = 1;
        long maxFileSize;
        while (true)
        {
          switch (num)
          {
            case 1:
              maxFileSize = this.MaxFileSize;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return maxFileSize.ToString((IFormatProvider) RollingFileAppender.AAEJQYhMFdu9swff2Zw9());
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.MaxFileSize = OptionConverter.ToFileSize(value, this.MaxFileSize + 1L);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
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

    /// <summary>Gets or sets the rolling file count direction.</summary>
    /// <value>The rolling file count direction.</value>
    /// <remarks>
    /// <para>
    /// Indicates if the current file is the lowest numbered file or the
    /// highest numbered file.
    /// </para>
    /// <para>
    /// By default newer files have lower numbers (<see cref="P:EleWise.ELMA.Logging.RollingFileAppender.CountDirection" /> &lt; 0),
    /// i.e. log.1 is most recent, log.5 is the 5th backup, etc...
    /// </para>
    /// <para>
    /// <see cref="P:EleWise.ELMA.Logging.RollingFileAppender.CountDirection" /> &gt;= 0 does the opposite i.e.
    /// log.1 is the first backup made, log.5 is the 5th backup made, etc.
    /// For infinite backups use <see cref="P:EleWise.ELMA.Logging.RollingFileAppender.CountDirection" /> &gt;= 0 to reduce
    /// rollover costs.
    /// </para>
    /// <para>The default file count direction is -1.</para>
    /// </remarks>
    public int CountDirection
    {
      get => this.\u003CCountDirection\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CCountDirection\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
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

    /// <summary>Gets or sets the rolling style.</summary>
    /// <value>The rolling style.</value>
    /// <remarks>
    /// <para>
    /// The default rolling style is <see cref="F:log4net.Appender.RollingFileAppender.RollingMode.Composite" />.
    /// </para>
    /// <para>
    /// When set to <see cref="F:log4net.Appender.RollingFileAppender.RollingMode.Once" /> this appender's
    /// <see cref="P:log4net.Appender.FileAppender.AppendToFile" /> property is set to <c>false</c>, otherwise
    /// the appender would append to a single file rather than rolling
    /// the file each time it is opened.
    /// </para>
    /// </remarks>
    public log4net.Appender.RollingFileAppender.RollingMode RollingStyle
    {
      get => this.m_rollingStyle;
      set
      {
        int num = 11;
        log4net.Appender.RollingFileAppender.RollingMode rollingStyle;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.AppendToFile = false;
              num = 9;
              continue;
            case 2:
              goto label_2;
            case 3:
              this.m_rollSize = false;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
              continue;
            case 4:
              this.m_rollSize = false;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
              continue;
            case 5:
              switch (rollingStyle)
              {
                case log4net.Appender.RollingFileAppender.RollingMode.Once:
                  this.m_rollDate = false;
                  num = 4;
                  continue;
                case log4net.Appender.RollingFileAppender.RollingMode.Size:
                  this.m_rollDate = false;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 8 : 1;
                  continue;
                case log4net.Appender.RollingFileAppender.RollingMode.Date:
                  this.m_rollDate = true;
                  num = 3;
                  continue;
                case log4net.Appender.RollingFileAppender.RollingMode.Composite:
                  this.m_rollDate = true;
                  num = 6;
                  continue;
                default:
                  num = 12;
                  continue;
              }
            case 6:
              this.m_rollSize = true;
              num = 7;
              continue;
            case 7:
              goto label_15;
            case 8:
              this.m_rollSize = true;
              num = 2;
              continue;
            case 9:
              goto label_11;
            case 10:
              rollingStyle = this.m_rollingStyle;
              num = 5;
              continue;
            case 11:
              this.m_rollingStyle = value;
              num = 10;
              continue;
            case 12:
              goto label_8;
            default:
              goto label_20;
          }
        }
label_3:
        return;
label_2:
        return;
label_15:
        return;
label_11:
        return;
label_8:
        return;
label_20:;
      }
    }

    /// <summary>
    /// Gets or sets a value indicating whether to preserve the file name extension when rolling.
    /// </summary>
    /// <value>
    /// <c>true</c> if the file name extension should be preserved.
    /// </value>
    /// <remarks>
    /// <para>
    /// By default file.log is rolled to file.log.yyyy-MM-dd or file.log.curSizeRollBackup.
    /// However, under Windows the new file name will loose any program associations as the
    /// extension is changed. Optionally file.log can be renamed to file.yyyy-MM-dd.log or
    /// file.curSizeRollBackup.log to maintain any program associations.
    /// </para>
    /// </remarks>
    public bool PreserveLogFileNameExtension
    {
      get => this.\u003CPreserveLogFileNameExtension\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CPreserveLogFileNameExtension\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
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

    /// <summary>
    /// Gets or sets a value indicating whether to always log to
    /// the same file.
    /// </summary>
    /// <value>
    /// <c>true</c> if always should be logged to the same file, otherwise <c>false</c>.
    /// </value>
    /// <remarks>
    /// <para>
    /// By default file.log is always the current file.  Optionally
    /// file.log.yyyy-mm-dd for current formatted datePattern can by the currently
    /// logging file (or file.log.curSizeRollBackup or even
    /// file.log.yyyy-mm-dd.curSizeRollBackup).
    /// </para>
    /// <para>
    /// This will make time based rollovers with a large number of backups
    /// much faster as the appender it won't have to rename all the backups!
    /// </para>
    /// </remarks>
    public virtual bool StaticLogFileName
    {
      get => this.\u003CStaticLogFileName\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CStaticLogFileName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
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

    /// <summary>Sets the quiet writer being used.</summary>
    /// <remarks>This method can be overridden by sub classes.</remarks>
    /// <param name="writer">the writer to set</param>
    protected override void SetQWForFiles(TextWriter writer)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            RollingFileAppender.PBxr1HhMWfnuXDb8gs6g((object) this, (object) new CountingQuietTextWriter(writer, (IErrorHandler) RollingFileAppender.em6qRFhMBuS5prl7DqEp((object) this)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Write out a logging event.</summary>
    /// <param name="loggingEvent">the event to write to file.</param>
    /// <remarks>
    /// <para>
    /// Handles append time behavior for RollingFileAppender.  This checks
    /// if a roll over either by date (checked first) or time (checked second)
    /// is need and then appends to the file last.
    /// </para>
    /// </remarks>
    protected override void Append(LoggingEvent loggingEvent)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            RollingFileAppender.d7FqDNhMo377iDUAW7wM((object) this, (object) loggingEvent);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
            continue;
          case 2:
            this.AdjustFileBeforeAppend();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Write out an array of logging events.</summary>
    /// <param name="loggingEvents">the events to write to file.</param>
    /// <remarks>
    /// <para>
    /// Handles append time behavior for RollingFileAppender.  This checks
    /// if a roll over either by date (checked first) or time (checked second)
    /// is need and then appends to the file last.
    /// </para>
    /// </remarks>
    protected override void Append(LoggingEvent[] loggingEvents)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.AdjustFileBeforeAppend();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            RollingFileAppender.BIG5RvhMbePX3mAqsnn6((object) this, (object) loggingEvents);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// Performs any required rolling before outputting the next event
    /// </summary>
    /// <remarks>
    /// <para>
    /// Handles append time behavior for RollingFileAppender.  This checks
    /// if a roll over either by date (checked first) or time (checked second)
    /// is need and then appends to the file last.
    /// </para>
    /// </remarks>
    protected virtual void AdjustFileBeforeAppend()
    {
      int num = 8;
      DateTime dateTime;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (RollingFileAppender.PCg0gDhMfq8DNUmQyJTa((object) this) == null)
            {
              num = 4;
              continue;
            }
            goto case 9;
          case 2:
          case 6:
            if (!this.m_rollSize)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 13;
              continue;
            }
            goto case 1;
          case 3:
            this.RollOverSize();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 14 : 3;
            continue;
          case 4:
            goto label_17;
          case 5:
            this.m_nextCheck = this.NextCheckDate(this.m_now, this.m_rollPoint);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 10 : 12;
            continue;
          case 7:
            dateTime = RollingFileAppender.EKfIVBhMhyrTRQS9uoHT((object) this.DateTimeStrategy);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          case 8:
            if (this.m_rollDate)
            {
              num = 7;
              continue;
            }
            goto case 2;
          case 9:
            if (RollingFileAppender.iN4xR6hMCmQG70K7ZH2Q((object) (CountingQuietTextWriter) RollingFileAppender.aGX3YLhMQrAyJPLTXrHn((object) this)) < this.MaxFileSize)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 3 : 11;
              continue;
            }
            goto case 3;
          case 10:
            this.m_now = dateTime;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 5 : 4;
            continue;
          case 11:
            goto label_13;
          case 12:
            RollingFileAppender.ODVYEGhMEiLS4W47IZdu((object) this, true);
            num = 6;
            continue;
          case 13:
            goto label_10;
          case 14:
            goto label_2;
          default:
            if (!RollingFileAppender.bZwrCQhMGNFDxX5Vcrxg(dateTime, this.m_nextCheck))
            {
              num = 2;
              continue;
            }
            goto case 10;
        }
      }
label_17:
      return;
label_13:
      return;
label_10:
      return;
label_2:;
    }

    /// <summary>
    /// Creates and opens the file for logging.  If <see cref="P:EleWise.ELMA.Logging.RollingFileAppender.StaticLogFileName" />
    /// is false then the fully qualified name is determined and used.
    /// </summary>
    /// <param name="fileName">the name of the file to open</param>
    /// <param name="append">true to append to existing file</param>
    /// <remarks>
    /// <para>This method will ensure that the directory structure
    /// for the <paramref name="fileName" /> specified exists.</para>
    /// </remarks>
    protected override void OpenFile(string fileName, bool append)
    {
      int num1 = 3;
      RollingFileAppender rollingFileAppender;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_38;
          case 2:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
            continue;
          case 3:
            rollingFileAppender = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 2 : 2;
            continue;
          default:
            goto label_3;
        }
      }
label_38:
      return;
label_3:
      try
      {
        Monitor.Enter((object) rollingFileAppender, ref lockTaken);
        int num2 = 8;
        IDisposable disposable;
        long num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 7:
label_30:
              if (RollingFileAppender.o9tpxShMilIX8xy9TbUW((object) this))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 4 : 5;
                continue;
              }
              goto case 9;
            case 2:
              num3 = 0L;
              num2 = 10;
              continue;
            case 3:
              RollingFileAppender.vHnRcvhMqJNRguNlZpQx((object) (CountingQuietTextWriter) RollingFileAppender.aGX3YLhMQrAyJPLTXrHn((object) this), num3);
              num2 = 11;
              continue;
            case 4:
              if (RollingFileAppender.EM7X8ZhMIxNZCkg5lyZa())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 13 : 11;
                continue;
              }
              goto case 1;
            case 5:
            case 6:
              RollingFileAppender.ObuQyZhMRHfYPym5lM6o((object) this, (object) fileName, append);
              num2 = 3;
              continue;
            case 8:
              fileName = this.GetNextOutputFileName(fileName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 1;
              continue;
            case 9:
              this.m_scheduledFilename = fileName;
              num2 = 6;
              continue;
            case 10:
              if (append)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 11:
              goto label_37;
            case 12:
              RollingFileAppender.KdQYXuhMS1mYsOBcahDy(RollingFileAppender.declaringType, RollingFileAppender.jM0rpchMVIDgFAvLfkkZ(RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1470440286 ^ 1470540700), (object) fileName, RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-787452571 ^ -787225547)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 7 : 4;
              continue;
            case 13:
              if (this.MaxSizeRollBackups == 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 1;
                continue;
              }
              goto case 15;
            case 14:
              try
              {
                int num4;
                if (!System.IO.File.Exists(fileName))
                  num4 = 2;
                else
                  goto label_22;
label_21:
                switch (num4)
                {
                  case 1:
                  case 2:
                    goto label_30;
                }
label_22:
                num3 = RollingFileAppender.zBoY0yhMZngOSCZWivec((object) new FileInfo(fileName));
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
                {
                  num4 = 1;
                  goto label_21;
                }
                else
                  goto label_21;
              }
              finally
              {
                int num5;
                if (disposable == null)
                  num5 = 2;
                else
                  goto label_27;
label_26:
                switch (num5)
                {
                  case 1:
                  case 2:
                }
label_27:
                RollingFileAppender.k9ZxvwhMuwq0oItapG2U((object) disposable);
                num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
                {
                  num5 = 0;
                  goto label_26;
                }
                else
                  goto label_26;
              }
            case 15:
              if (this.FileExists(fileName))
              {
                num2 = 12;
                continue;
              }
              goto case 1;
            default:
              disposable = (IDisposable) RollingFileAppender.W1J3T0hM8whc1rWhGYWc(RollingFileAppender.dSmtiYhMvKTH81VK4DE1((object) this), (object) this);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 4 : 14;
              continue;
          }
        }
label_37:;
      }
      finally
      {
        int num6;
        if (!lockTaken)
          num6 = 2;
        else
          goto label_39;
label_36:
        switch (num6)
        {
          case 1:
          case 2:
        }
label_39:
        RollingFileAppender.m6cbtghMK2A3nNHWo0L6((object) rollingFileAppender);
        num6 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
        {
          num6 = 1;
          goto label_36;
        }
        else
          goto label_36;
      }
    }

    /// <summary>Get the current output file name</summary>
    /// <param name="fileName">the base file name</param>
    /// <returns>the output file name</returns>
    /// <remarks>
    /// The output file name is based on the base fileName specified.
    /// If <see cref="P:EleWise.ELMA.Logging.RollingFileAppender.StaticLogFileName" /> is set then the output
    /// file name is the same as the base file passed in. Otherwise
    /// the output file depends on the date pattern, on the count
    /// direction or both.
    /// </remarks>
    protected string GetNextOutputFileName(string fileName)
    {
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.m_rollDate)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
          case 7:
            goto label_10;
          case 3:
            if (this.CountDirection < 0)
            {
              num = 7;
              continue;
            }
            goto case 4;
          case 4:
            fileName = this.CombinePath(fileName, (string) RollingFileAppender.jxyUndhMTD8c1NOqeXhI((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289712978), (object) this.m_curSizeRollBackups));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 2;
            continue;
          case 5:
            fileName = fileName.Trim();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 1;
            continue;
          case 6:
            if (!RollingFileAppender.o9tpxShMilIX8xy9TbUW((object) this))
            {
              num = 5;
              continue;
            }
            goto label_10;
          default:
            fileName = this.CombinePath(fileName, this.m_now.ToString(this.DatePattern, (IFormatProvider) RollingFileAppender.voVQJqhMXF8vx2FTle3w()));
            num = 3;
            continue;
        }
      }
label_10:
      return fileName;
    }

    /// <summary>
    /// Determines curSizeRollBackups (only within the current roll point)
    /// </summary>
    private void DetermineCurSizeRollBackups()
    {
      int num1 = 9;
      while (true)
      {
        string lastFile;
        DateTime lastDate;
        IDisposable disposable;
        string baseFilePath;
        ArrayList existingFiles;
        string baseFile;
        switch (num1)
        {
          case 1:
            goto label_15;
          case 2:
            RollingFileAppender.IWZTBkhM2xlOlPISajtr((object) this, (object) lastFile, lastDate);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 1 : 1;
            continue;
          case 3:
            this.InitializeRollBackups(baseFile, existingFiles);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 3 : 6;
            continue;
          case 4:
            baseFile = (string) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 5;
            continue;
          case 5:
            disposable = ((SecurityContext) RollingFileAppender.dSmtiYhMvKTH81VK4DE1((object) this)).Impersonate((object) this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 5 : 7;
            continue;
          case 6:
            RollingFileAppender.DUAIlfhMO4Zb35bPZHRw(RollingFileAppender.declaringType, (object) (RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1218962250 ^ 1218734652).ToString() + (object) this.m_curSizeRollBackups + RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1574260816 ^ 1574282936)));
            num1 = 2;
            continue;
          case 7:
            try
            {
              baseFilePath = (string) RollingFileAppender.degUSchMksgL83QSefY4((object) this.m_baseFileName);
              int num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
                num2 = 0;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    baseFile = (string) RollingFileAppender.XeHRHKhMnAojGkoyLnd9((object) baseFilePath);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_5;
                }
              }
            }
            finally
            {
              if (disposable != null)
              {
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      RollingFileAppender.k9ZxvwhMuwq0oItapG2U((object) disposable);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_17;
                  }
                }
              }
label_17:;
            }
          case 8:
            baseFilePath = (string) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 4;
            continue;
          case 9:
            this.m_curSizeRollBackups = 0;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 8 : 2;
            continue;
        }
label_5:
        existingFiles = this.GetExistingFiles(baseFilePath, out lastFile, out lastDate);
        num1 = 3;
      }
label_15:;
    }

    /// <summary>
    /// Generates a wildcard pattern that can be used to find all files
    /// that are similar to the base file name.
    /// </summary>
    /// <param name="baseFileName"></param>
    /// <returns></returns>
    private string GetWildcardPatternForFile(string baseFileName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.PreserveLogFileNameExtension)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) RollingFileAppender.jM0rpchMVIDgFAvLfkkZ((object) Path.GetFileNameWithoutExtension(baseFileName), RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-1204263869 ^ -1341583247 ^ 137367708), RollingFileAppender.NvgiKmhMeurNaa1FktWK((object) baseFileName));
label_5:
      return (string) RollingFileAppender.dypyDwhMPx1WP9r2thtV((object) baseFileName, RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-420743386 ^ -420764298));
    }

    /// <summary>
    /// Builds a list of filenames for all files matching the base filename plus a file
    /// pattern.
    /// </summary>
    /// <param name="baseFilePath"></param>
    /// <returns></returns>
    private ArrayList GetExistingFiles(
      string baseFilePath,
      out string lastFile,
      out DateTime lastDate)
    {
      int num1 = 7;
      IDisposable disposable;
      ArrayList existingFiles;
      string path;
      while (true)
      {
        switch (num1)
        {
          case 1:
            path = (string) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 1;
            continue;
          case 2:
            disposable = ((SecurityContext) RollingFileAppender.dSmtiYhMvKTH81VK4DE1((object) this)).Impersonate((object) this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 5 : 5;
            continue;
          case 3:
            goto label_4;
          case 4:
label_5:
            LogLog.Debug(RollingFileAppender.declaringType, (string) RollingFileAppender.jM0rpchMVIDgFAvLfkkZ(RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-2099751081 ^ -2099519871), (object) path, RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-345420348 ^ -345392340)));
            num1 = 3;
            continue;
          case 5:
            try
            {
              string str1 = (string) RollingFileAppender.degUSchMksgL83QSefY4((object) baseFilePath);
              int num2 = 11;
              while (true)
              {
                int num3 = num2;
                DateTime currentDateTime;
                int num4;
                string str2;
                FileSystemInfo[] fileSystemInfoArray;
                string baseFileName;
                string str3;
                DateTime result;
                int index;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      index = 0;
                      num3 = 26;
                      continue;
                    case 2:
                      currentDateTime = DateTime.MinValue;
                      num3 = 3;
                      continue;
                    case 3:
                    case 13:
                      str3 = (string) RollingFileAppender.brSTS0hMpFDraR2D3jFX((object) baseFileName);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 1;
                      continue;
                    case 4:
                    case 7:
                    case 27:
                      goto label_5;
                    case 5:
label_46:
                      ++index;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 31 : 1;
                      continue;
                    case 6:
                    case 12:
                      if (num4 > this.MaxDateRollBackups)
                      {
                        num3 = 13;
                        continue;
                      }
                      goto case 17;
                    case 8:
                      if (RollingFileAppender.Mw7s1khMDnEgvIPr78U6((object) str2, (object) str3))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
                        continue;
                      }
                      goto case 5;
                    case 9:
                      lastFile = (string) RollingFileAppender.c1hAKshMAQKUXWJdqrDE((object) fileSystemInfoArray[index]);
                      num3 = 16;
                      continue;
                    case 10:
                      baseFileName = (string) RollingFileAppender.XeHRHKhMnAojGkoyLnd9((object) str1);
                      num3 = 22;
                      continue;
                    case 11:
                      path = (string) RollingFileAppender.GS4x8hhM1kooiWGW7QIE((object) str1);
                      num3 = 19;
                      continue;
                    case 14:
                      try
                      {
                        RollingFileAppender.DOIyAJhMw019YyKaNZIC((object) fileSystemInfoArray[index]);
                        int num5 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
                          num5 = 0;
                        switch (num5)
                        {
                          default:
                            goto label_46;
                        }
                      }
                      catch (Exception ex)
                      {
                        int num6 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
                          num6 = 0;
                        while (true)
                        {
                          switch (num6)
                          {
                            case 1:
                              goto label_46;
                            default:
                              RollingFileAppender.KBSKIahM4brId29E624l(RollingFileAppender.declaringType, RollingFileAppender.dypyDwhMPx1WP9r2thtV(RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1304605005 ^ 1304508667), (object) fileSystemInfoArray[index].FullName), (object) ex);
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
                              continue;
                          }
                        }
                      }
                    case 15:
                    case 24:
                      RollingFileAppender.YO9KBKhM6B2FnVX4AWW0((object) existingFiles, (object) str2);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 2 : 18;
                      continue;
                    case 16:
                      lastDate = result;
                      num3 = 5;
                      continue;
                    case 17:
                      currentDateTime = this.PrevDate(currentDateTime, this.m_rollPoint);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 21 : 13;
                      continue;
                    case 18:
                      if (RollingFileAppender.umKHfMhMHNcm2vY8M0TT(result, lastDate))
                      {
                        num3 = 9;
                        continue;
                      }
                      goto case 5;
                    case 19:
                      if (!RollingFileAppender.Qw8NZEhMNlXZ33Dkgp4w((object) path))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 6 : 27;
                        continue;
                      }
                      goto case 10;
                    case 20:
                      if (RollingFileAppender.Oj2cHPhMt5Yi3xIxZZa1(result, currentDateTime))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 14;
                        continue;
                      }
                      goto case 15;
                    case 21:
                      ++num4;
                      num3 = 6;
                      continue;
                    case 22:
                      fileSystemInfoArray = (FileSystemInfo[]) RollingFileAppender.c7DR4HhM3tYatLxS6TJv((object) new DirectoryInfo(path), (object) this.GetWildcardPatternForFile(baseFileName));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 30 : 22;
                      continue;
                    case 23:
                      num4 = 0;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 12 : 12;
                      continue;
                    case 25:
                      if (this.MaxDateRollBackups >= 0)
                      {
                        num3 = 29;
                        continue;
                      }
                      goto case 2;
                    case 26:
                    case 31:
                      if (index >= fileSystemInfoArray.Length)
                      {
                        num3 = 7;
                        continue;
                      }
                      goto label_45;
                    case 28:
                      goto label_45;
                    case 29:
                      currentDateTime = RollingFileAppender.EKfIVBhMhyrTRQS9uoHT((object) this.DateTimeStrategy);
                      num3 = 23;
                      continue;
                    case 30:
                      if (fileSystemInfoArray == null)
                      {
                        num3 = 4;
                        continue;
                      }
                      goto case 25;
                    default:
                      if (!DateTime.TryParseExact(((string) RollingFileAppender.brSTS0hMpFDraR2D3jFX((object) str2)).Substring(str3.Length), this.DatePattern, (IFormatProvider) RollingFileAppender.voVQJqhMXF8vx2FTle3w(), DateTimeStyles.None, out result))
                      {
                        num3 = 24;
                        continue;
                      }
                      goto case 20;
                  }
                }
label_45:
                str2 = (string) RollingFileAppender.KJ2CKghMaFScgRTphWye((object) fileSystemInfoArray[index]);
                num2 = 8;
              }
            }
            finally
            {
              int num7;
              if (disposable == null)
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
              else
                goto label_52;
label_51:
              switch (num7)
              {
                case 1:
                case 2:
              }
label_52:
              RollingFileAppender.k9ZxvwhMuwq0oItapG2U((object) disposable);
              num7 = 2;
              goto label_51;
            }
          case 6:
            lastFile = (string) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
            continue;
          case 7:
            existingFiles = new ArrayList();
            num1 = 6;
            continue;
          default:
            lastDate = DateTime.MinValue;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
            continue;
        }
      }
label_4:
      return existingFiles;
    }

    /// <summary>
    /// Initiates a roll over if needed for crossing a date boundary since the last run.
    /// </summary>
    protected virtual void RollOverIfDateBoundaryCrossing(string lastFile, DateTime lastDate)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_14;
            case 1:
              goto label_19;
            case 2:
              RollingFileAppender.ODVYEGhMEiLS4W47IZdu((object) this, false);
              num2 = 5;
              continue;
            case 3:
              if (lastFile != null)
              {
                num2 = 10;
                continue;
              }
              goto label_10;
            case 4:
              if (RollingFileAppender.nxhRrdhMxQZlCAJ6hGW6((object) lastDate.ToString(this.DatePattern, (IFormatProvider) RollingFileAppender.voVQJqhMXF8vx2FTle3w()), (object) this.m_now.ToString(this.DatePattern, (IFormatProvider) RollingFileAppender.voVQJqhMXF8vx2FTle3w())))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 4 : 7;
                continue;
              }
              goto label_11;
            case 5:
              RollingFileAppender.DUAIlfhMO4Zb35bPZHRw(RollingFileAppender.declaringType, (object) (RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(654297945 ^ 654065925).ToString() + (object) this.m_curSizeRollBackups + z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712466783)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
              continue;
            case 6:
              goto label_11;
            case 7:
              goto label_20;
            case 8:
              if (!this.m_rollDate)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 9:
              if (RollingFileAppender.o9tpxShMilIX8xy9TbUW((object) this))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 8 : 8;
                continue;
              }
              goto label_3;
            case 10:
              LogLog.Debug(RollingFileAppender.declaringType, (string) RollingFileAppender.wxwEVAhM75ehxT53DYO0((object) new string[5]
              {
                (string) RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(44884861 ^ 44832159),
                lastDate.ToString(this.DatePattern, (IFormatProvider) RollingFileAppender.voVQJqhMXF8vx2FTle3w()),
                (string) RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(825385222 ^ 825355036),
                this.m_now.ToString(this.DatePattern, (IFormatProvider) RollingFileAppender.voVQJqhMXF8vx2FTle3w()),
                (string) RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(--1418440330 ^ 1418418274)
              }));
              num2 = 4;
              continue;
            case 11:
              RollingFileAppender.DUAIlfhMO4Zb35bPZHRw(RollingFileAppender.declaringType, (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283612407) + this.m_scheduledFilename + (string) RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-2112703338 ^ -2112732546)));
              num2 = 2;
              continue;
            default:
              goto label_21;
          }
        }
label_11:
        this.m_scheduledFilename = this.m_baseFileName + lastDate.ToString(this.DatePattern, (IFormatProvider) DateTimeFormatInfo.InvariantInfo);
        num1 = 11;
      }
label_14:
      return;
label_19:
      return;
label_20:
      return;
label_21:
      return;
label_10:
      return;
label_3:;
    }

    /// <summary>
    /// Initializes based on existing conditions at time of <see cref="M:EleWise.ELMA.Logging.RollingFileAppender.ActivateOptions" />.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Initializes based on existing conditions at time of <see cref="M:EleWise.ELMA.Logging.RollingFileAppender.ActivateOptions" />.
    /// The following is done
    /// <list type="bullet">
    /// <item>determine curSizeRollBackups (only within the current roll point)</item>
    /// <item>initiates a roll over if needed for crossing a date boundary since the last run.</item>
    /// </list>
    /// </para>
    /// </remarks>
    protected void ExistingInit()
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        string nextOutputFileName;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_11;
            case 1:
              RollingFileAppender.DUAIlfhMO4Zb35bPZHRw(RollingFileAppender.declaringType, RollingFileAppender.jM0rpchMVIDgFAvLfkkZ(RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1021410165 ^ 1021506009), (object) nextOutputFileName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867856578)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 4 : 4;
              continue;
            case 2:
              if (!this.FileExists(nextOutputFileName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 11 : 0;
                continue;
              }
              goto case 7;
            case 3:
              goto label_10;
            case 4:
              this.RollOverRenameFiles(nextOutputFileName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            case 5:
              if (!RollingFileAppender.d37f3ohM0u6olBZwYikA((object) this))
                goto case 10;
              else
                goto label_15;
            case 6:
              this.DetermineCurSizeRollBackups();
              num2 = 5;
              continue;
            case 7:
              if (this.MaxSizeRollBackups != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 1;
                continue;
              }
              goto case 9;
            case 8:
              goto label_8;
            case 9:
              RollingFileAppender.DUAIlfhMO4Zb35bPZHRw(RollingFileAppender.declaringType, RollingFileAppender.jM0rpchMVIDgFAvLfkkZ(RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1470998129 - 231418599 ^ 1239544102), (object) nextOutputFileName, RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(~289714581 ^ -289880928)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 3 : 2;
              continue;
            case 10:
              nextOutputFileName = this.GetNextOutputFileName(this.m_baseFileName);
              num2 = 2;
              continue;
            case 11:
              goto label_4;
            default:
              goto label_3;
          }
        }
label_15:
        num1 = 8;
      }
label_11:
      return;
label_10:
      return;
label_8:
      return;
label_4:
      return;
label_3:;
    }

    /// <summary>
    /// Does the work of bumping the 'current' file counter higher
    /// to the highest count when an incremental file name is seen.
    /// The highest count is either the first file (when count direction
    /// is greater than 0) or the last file (when count direction less than 0).
    /// In either case, we want to know the highest count that is present.
    /// </summary>
    /// <param name="baseFile"></param>
    /// <param name="curFileName"></param>
    private void InitializeFromOneFile(string baseFile, string curFileName)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_31;
            case 1:
              if (curFileName.StartsWith((string) RollingFileAppender.brSTS0hMpFDraR2D3jFX((object) baseFile)))
              {
                if (RollingFileAppender.nxhRrdhMxQZlCAJ6hGW6((object) curFileName, (object) baseFile))
                {
                  num2 = 4;
                  continue;
                }
                if (!this.m_rollDate)
                {
                  num2 = 9;
                  continue;
                }
                goto case 6;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
                continue;
              }
            case 2:
              LogLog.Debug(RollingFileAppender.declaringType, (string) RollingFileAppender.jM0rpchMVIDgFAvLfkkZ(RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(--1333735954 ^ 1333575168), (object) curFileName, RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1925118608 << 2 ^ -889690508)));
              num2 = 3;
              continue;
            case 3:
              goto label_32;
            case 4:
              goto label_35;
            case 5:
              if (!RollingFileAppender.Mw7s1khMDnEgvIPr78U6((object) curFileName, (object) this.CombinePath(baseFile, this.DateTimeStrategy.Now.ToString(this.DatePattern, (IFormatProvider) DateTimeFormatInfo.InvariantInfo))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 2;
                continue;
              }
              goto case 9;
            case 6:
              if (this.StaticLogFileName)
                goto case 9;
              else
                goto label_43;
            case 7:
              goto label_39;
            case 8:
              goto label_3;
            case 9:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 8 : 0;
              continue;
            default:
              goto label_28;
          }
        }
label_43:
        num1 = 5;
      }
label_31:
      return;
label_32:
      return;
label_35:
      return;
label_39:
      return;
label_28:
      return;
label_3:
      try
      {
        int backUpIndex = this.GetBackUpIndex(curFileName);
        int num3 = 11;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
            case 6:
            case 10:
            case 13:
              RollingFileAppender.DUAIlfhMO4Zb35bPZHRw(RollingFileAppender.declaringType, RollingFileAppender.tmaCyVhMmDuDvSFPWGnl((object) new object[5]
              {
                (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146476109),
                (object) curFileName,
                RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1581325282 << 3 ^ -234138694),
                (object) this.m_curSizeRollBackups,
                RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(864270449 << 6 ^ -521213272)
              }));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 3 : 3;
              continue;
            case 2:
            case 7:
              if (backUpIndex <= this.MaxSizeRollBackups)
              {
                num3 = 8;
                continue;
              }
              goto case 1;
            case 3:
              goto label_26;
            case 4:
              if (-1 == this.MaxSizeRollBackups)
              {
                num3 = 5;
                continue;
              }
              goto case 9;
            case 5:
              this.m_curSizeRollBackups = backUpIndex;
              num3 = 6;
              continue;
            case 8:
              this.m_curSizeRollBackups = backUpIndex;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 3 : 10;
              continue;
            case 9:
              if (this.CountDirection < 0)
              {
                num3 = 2;
                continue;
              }
              goto case 12;
            case 11:
              if (backUpIndex > this.m_curSizeRollBackups)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
                continue;
              }
              goto label_22;
            case 12:
              this.m_curSizeRollBackups = backUpIndex;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 13 : 2;
              continue;
            default:
              if (this.MaxSizeRollBackups == 0)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 1;
                continue;
              }
              goto case 4;
          }
        }
label_26:
        return;
label_22:;
      }
      catch (FormatException ex)
      {
        int num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
          num4 = 1;
        while (true)
        {
          switch (num4)
          {
            case 0:
              goto label_10;
            case 1:
              LogLog.Debug(RollingFileAppender.declaringType, (string) RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-1886646897 ^ -1886420627) + curFileName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70045211));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
              continue;
            default:
              goto label_7;
          }
        }
label_10:
        return;
label_7:;
      }
    }

    /// <summary>
    /// Attempts to extract a number from the end of the file name that indicates
    /// the number of the times the file has been rolled over.
    /// </summary>
    /// <remarks>
    /// Certain date pattern extensions like yyyyMMdd will be parsed as valid backup indexes.
    /// </remarks>
    /// <param name="curFileName"></param>
    /// <returns></returns>
    private int GetBackUpIndex(string curFileName)
    {
      int num1 = 1;
      string path;
      int num2;
      int val;
      while (true)
      {
        switch (num1)
        {
          case 1:
            val = -1;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          case 2:
          case 5:
            num2 = RollingFileAppender.hOHWixhMyA1ldc663ash((object) path, RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1142330761 ^ 1541959139 ^ 536797870));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 2 : 4;
            continue;
          case 3:
            if (!this.PreserveLogFileNameExtension)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 2;
              continue;
            }
            goto case 9;
          case 4:
            if (num2 <= 0)
            {
              num1 = 7;
              continue;
            }
            goto case 6;
          case 6:
            SystemInfo.TryParse(path.Substring(num2 + 1), out val);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 8 : 8;
            continue;
          case 7:
          case 8:
            goto label_3;
          case 9:
            path = Path.GetFileNameWithoutExtension(path);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 5 : 2;
            continue;
          default:
            path = curFileName;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 2 : 3;
            continue;
        }
      }
label_3:
      return val;
    }

    /// <summary>
    /// Takes a list of files and a base file name, and looks for
    /// 'incremented' versions of the base file.  Bumps the max
    /// count up to the highest count seen.
    /// </summary>
    /// <param name="baseFile"></param>
    /// <param name="arrayFiles"></param>
    private void InitializeRollBackups(string baseFile, ArrayList arrayFiles)
    {
      int num1 = 4;
      string baseFile1;
      IEnumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_19;
          case 2:
            goto label_5;
          case 3:
            baseFile1 = (string) RollingFileAppender.K0lgfahMJMuK2hll9LTT((object) baseFile, RollingFileAppender.YMKWYOhMMO8tscaaI8up());
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
            continue;
          case 4:
            if (arrayFiles != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 3;
              continue;
            }
            goto label_15;
          default:
            enumerator = (IEnumerator) RollingFileAppender.kAhL11hM9NYMf8BEwBae((object) arrayFiles);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 2 : 1;
            continue;
        }
      }
label_19:
      return;
label_15:
      return;
label_5:
      try
      {
label_8:
        if (RollingFileAppender.nl74RxhMlpl2di5JK5Fl((object) enumerator))
          goto label_10;
        else
          goto label_9;
label_6:
        string str;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_12;
            case 2:
              goto label_10;
            case 3:
              goto label_8;
            default:
              this.InitializeFromOneFile(baseFile1, (string) RollingFileAppender.K0lgfahMJMuK2hll9LTT((object) str, RollingFileAppender.YMKWYOhMMO8tscaaI8up()));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 3 : 0;
              continue;
          }
        }
label_12:
        return;
label_9:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 1;
        goto label_6;
label_10:
        str = (string) RollingFileAppender.L4vkwKhMdqY8q9mKNjqd((object) enumerator);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
        {
          num2 = 0;
          goto label_6;
        }
        else
          goto label_6;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num3 = 3;
        while (true)
        {
          switch (num3)
          {
            case 1:
            case 2:
              goto label_20;
            case 3:
              if (disposable == null)
              {
                num3 = 2;
                continue;
              }
              break;
          }
          RollingFileAppender.k9ZxvwhMuwq0oItapG2U((object) disposable);
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 0;
        }
label_20:;
      }
    }

    /// <summary>
    /// Calculates the RollPoint for the datePattern supplied.
    /// </summary>
    /// <param name="datePattern">the date pattern to calculate the check period for</param>
    /// <returns>The RollPoint that is most accurate for the date pattern supplied</returns>
    /// <remarks>
    /// Essentially the date pattern is examined to determine what the
    /// most suitable roll point is. The roll point chosen is the roll point
    /// with the smallest period that can be detected using the date pattern
    /// supplied. i.e. if the date pattern only outputs the year, month, day
    /// and hour then the smallest roll point that can be detected would be
    /// and hourly roll point as minutes could not be detected.
    /// </remarks>
    private RollingFileAppender.RollPoint ComputeCheckPeriod(string datePattern)
    {
      int num = 1;
      int checkPeriod;
      DateTime dateTime;
      string str1;
      string str2;
      while (true)
      {
        switch (num)
        {
          case 1:
            dateTime = RollingFileAppender.s_date1970;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
            continue;
          case 2:
            if (!RollingFileAppender.nxhRrdhMxQZlCAJ6hGW6((object) str1, (object) str2))
            {
              num = 7;
              continue;
            }
            goto case 12;
          case 3:
            if (str1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 10 : 11;
              continue;
            }
            goto case 12;
          case 4:
            dateTime = this.NextCheckDate(RollingFileAppender.s_date1970, (RollingFileAppender.RollPoint) checkPeriod);
            num = 9;
            continue;
          case 5:
            goto label_17;
          case 6:
          case 10:
            if (checkPeriod > 5)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 5;
              continue;
            }
            goto case 4;
          case 7:
            goto label_2;
          case 8:
            RollingFileAppender.DUAIlfhMO4Zb35bPZHRw(RollingFileAppender.declaringType, (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957657218) + (object) checkPeriod + RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-477139494 ^ -477306744) + str1 + RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1251470110 >> 2 ^ 312899503) + str2 + RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(--1333735954 ^ 1333773562)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 3 : 1;
            continue;
          case 9:
            str2 = dateTime.ToString(datePattern, (IFormatProvider) RollingFileAppender.voVQJqhMXF8vx2FTle3w());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 8 : 3;
            continue;
          case 11:
            if (str2 == null)
            {
              num = 12;
              continue;
            }
            goto case 2;
          case 12:
            ++checkPeriod;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 6 : 6;
            continue;
          case 13:
            checkPeriod = 0;
            num = 10;
            continue;
          default:
            str1 = dateTime.ToString(datePattern, (IFormatProvider) RollingFileAppender.voVQJqhMXF8vx2FTle3w());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 13 : 3;
            continue;
        }
      }
label_2:
      return (RollingFileAppender.RollPoint) checkPeriod;
label_17:
      return RollingFileAppender.RollPoint.InvalidRollPoint;
    }

    /// <summary>Initialize the appender based on the options set</summary>
    /// <remarks>
    /// <para>
    /// This is part of the <see cref="T:log4net.Core.IOptionHandler" /> delayed object
    /// activation scheme. The <see cref="M:EleWise.ELMA.Logging.RollingFileAppender.ActivateOptions" /> method must
    /// be called on this object after the configuration properties have
    /// been set. Until <see cref="M:EleWise.ELMA.Logging.RollingFileAppender.ActivateOptions" /> is called this
    /// object is in an undefined state and must not be used.
    /// </para>
    /// <para>
    /// If any of the configuration properties are modified then
    /// <see cref="M:EleWise.ELMA.Logging.RollingFileAppender.ActivateOptions" /> must be called again.
    /// </para>
    /// <para>
    /// Sets initial conditions including date/time roll over information, first check,
    /// scheduledFilename, and calls <see cref="M:EleWise.ELMA.Logging.RollingFileAppender.ExistingInit" /> to initialize
    /// the current number of backups.
    /// </para>
    /// </remarks>
    public override void ActivateOptions()
    {
      int num1 = 15;
      while (true)
      {
        int num2 = num1;
        IDisposable disposable;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
            case 9:
            case 18:
              this.ExistingInit();
              num2 = 22;
              continue;
            case 3:
              if (this.m_scheduledFilename != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 1;
                continue;
              }
              goto case 4;
            case 4:
              this.m_scheduledFilename = this.CombinePath((string) RollingFileAppender.PCg0gDhMfq8DNUmQyJTa((object) this), this.m_now.ToString(this.DatePattern, (IFormatProvider) RollingFileAppender.voVQJqhMXF8vx2FTle3w()));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 6 : 9;
              continue;
            case 5:
              if (this.m_rollPoint == RollingFileAppender.RollPoint.InvalidRollPoint)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
                continue;
              }
              this.m_nextCheck = this.NextCheckDate(this.m_now, this.m_rollPoint);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 17 : 19;
              continue;
            case 6:
              if (this.m_rollDate)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 6 : 21;
                continue;
              }
              goto case 7;
            case 7:
              if (this.m_rollDate)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 6 : 12;
                continue;
              }
              goto case 8;
            case 8:
            case 19:
              if (RollingFileAppender.dSmtiYhMvKTH81VK4DE1((object) this) != null)
                goto case 20;
              else
                goto label_41;
            case 10:
              goto label_35;
            case 11:
              this.m_now = this.DateTimeStrategy.Now;
              num2 = 24;
              continue;
            case 12:
              RollingFileAppender.nnbPbthM5kQGvgKUaJE2(RollingFileAppender.em6qRFhMBuS5prl7DqEp((object) this), RollingFileAppender.jM0rpchMVIDgFAvLfkkZ(RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-867826612 ^ -867858042), RollingFileAppender.Arn0sxhMg75U5Y0ZxFPe((object) this), RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1514961705 ^ 1515189615)));
              num2 = 8;
              continue;
            case 13:
label_26:
              if (!this.m_rollDate)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 18 : 0;
                continue;
              }
              goto case 16;
            case 14:
              this.DateTimeStrategy = (log4net.Appender.RollingFileAppender.IDateTime) RollingFileAppender.u2LCGKhMrFErHKRpLN0c(RollingFileAppender.localDateTimeType);
              num2 = 6;
              continue;
            case 15:
              if (this.DateTimeStrategy != null)
                goto case 6;
              else
                goto label_17;
            case 16:
              if (RollingFileAppender.PCg0gDhMfq8DNUmQyJTa((object) this) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 1 : 2;
                continue;
              }
              goto case 3;
            case 17:
              try
              {
                RollingFileAppender.l12ZPShMs2RWXbRl08t5((object) this, RollingFileAppender.he41KfhMUwB5pVQQWxaj(RollingFileAppender.KZlvnhhMLRgYkXDXwTVI((object) this.File)));
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
                  num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      this.m_baseFileName = this.File;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_26;
                  }
                }
              }
              finally
              {
                if (disposable != null)
                {
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
                    num4 = 1;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        RollingFileAppender.k9ZxvwhMuwq0oItapG2U((object) disposable);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_13;
                    }
                  }
                }
label_13:;
              }
            case 20:
              disposable = (IDisposable) RollingFileAppender.W1J3T0hM8whc1rWhGYWc(RollingFileAppender.dSmtiYhMvKTH81VK4DE1((object) this), (object) this);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 6 : 17;
              continue;
            case 21:
              if (this.DatePattern == null)
                goto case 7;
              else
                goto label_15;
            case 22:
              RollingFileAppender.vZbye6hMcKLVC1qgp73q((object) this);
              num2 = 10;
              continue;
            case 23:
              this.SecurityContext = (SecurityContext) RollingFileAppender.VeBOGmhMYSDvG33hOppx(RollingFileAppender.wi3TxphMjSg5VECmmiPI(), (object) this);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 20 : 19;
              continue;
            case 24:
              this.m_rollPoint = this.ComputeCheckPeriod(this.DatePattern);
              num2 = 5;
              continue;
            default:
              goto label_31;
          }
        }
label_15:
        num1 = 11;
        continue;
label_17:
        num1 = 14;
        continue;
label_41:
        num1 = 23;
      }
label_35:
      return;
label_31:
      throw new ArgumentException((string) RollingFileAppender.jM0rpchMVIDgFAvLfkkZ(RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-488881205 ^ -488649035), (object) this.DatePattern, RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1461625753 ^ 1461605745)));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="path1"></param>
    /// <param name="path2">.1, .2, .3, etc.</param>
    /// <returns></returns>
    private string CombinePath(string path1, string path2)
    {
      int num = 1;
      string extension;
      while (true)
      {
        switch (num)
        {
          case 1:
            extension = Path.GetExtension(path1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            if (extension.Length > 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 2 : 2;
              continue;
            }
            goto label_6;
          default:
            if (this.PreserveLogFileNameExtension)
            {
              num = 3;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return (string) RollingFileAppender.ri1ksDhMzhXVaITvJSe6(RollingFileAppender.GS4x8hhM1kooiWGW7QIE((object) path1), RollingFileAppender.jM0rpchMVIDgFAvLfkkZ((object) Path.GetFileNameWithoutExtension(path1), (object) path2, (object) extension));
label_6:
      return (string) RollingFileAppender.dypyDwhMPx1WP9r2thtV((object) path1, (object) path2);
    }

    /// <summary>Rollover the file(s) to date/time tagged file(s).</summary>
    /// <param name="fileIsOpen">set to true if the file to be rolled is currently open</param>
    /// <remarks>
    /// <para>
    /// Rollover the file(s) to date/time tagged file(s).
    /// Resets curSizeRollBackups.
    /// If fileIsOpen is set then the new file is opened (through SafeOpenFile).
    /// </para>
    /// </remarks>
    protected virtual void RollOverTime(bool fileIsOpen)
    {
      int num1 = 4;
      string path2;
      int num2;
      string fromFile;
      string toFile;
      while (true)
      {
        switch (num1)
        {
          case 1:
            ((IErrorHandler) RollingFileAppender.em6qRFhMBuS5prl7DqEp((object) this)).Error((string) RollingFileAppender.mTRkCohJFgMRSggrqD6D(RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(~-306453669 ^ 306680320), (object) this.m_scheduledFilename, RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1461625753 ^ 1461579471), (object) this.CombinePath((string) RollingFileAppender.PCg0gDhMfq8DNUmQyJTa((object) this), path2)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 12 : 17;
            continue;
          case 2:
            if (fileIsOpen)
            {
              num1 = 10;
              continue;
            }
            goto case 5;
          case 3:
            if (this.DatePattern != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 3 : 14;
              continue;
            }
            goto case 15;
          case 4:
            if (RollingFileAppender.o9tpxShMilIX8xy9TbUW((object) this))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 3 : 0;
              continue;
            }
            goto case 8;
          case 5:
            this.ClearOverTime();
            num1 = 21;
            continue;
          case 6:
            goto label_7;
          case 7:
            if (RollingFileAppender.nxhRrdhMxQZlCAJ6hGW6((object) this.m_scheduledFilename, (object) this.CombinePath(this.File, path2)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 0;
              continue;
            }
            if (fileIsOpen)
            {
              num1 = 13;
              continue;
            }
            goto case 18;
          case 8:
            this.m_curSizeRollBackups = 0;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 13 : 19;
            continue;
          case 9:
            ++num2;
            num1 = 16;
            continue;
          case 10:
            RollingFileAppender.JjDBjHhJWcE6JZ1xyO4S((object) this, (object) this.m_baseFileName, false);
            num1 = 5;
            continue;
          case 11:
            toFile = this.CombinePath(this.m_scheduledFilename, (string) RollingFileAppender.jxyUndhMTD8c1NOqeXhI(RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-1350312861 << 3 ^ 2082404828), (object) num2));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 5 : 12;
            continue;
          case 12:
            this.RollFile(fromFile, toFile);
            num1 = 9;
            continue;
          case 13:
            RollingFileAppender.G84RwfhJBjyX8CtICkJQ((object) this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 18 : 14;
            continue;
          case 14:
            path2 = this.m_now.ToString(this.DatePattern, (IFormatProvider) DateTimeFormatInfo.InvariantInfo);
            num1 = 7;
            continue;
          case 15:
            RollingFileAppender.nnbPbthM5kQGvgKUaJE2(RollingFileAppender.em6qRFhMBuS5prl7DqEp((object) this), RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-2099751081 ^ -2099521255));
            num1 = 6;
            continue;
          case 17:
            goto label_10;
          case 18:
            num2 = 1;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
            continue;
          case 19:
            this.m_scheduledFilename = this.CombinePath((string) RollingFileAppender.PCg0gDhMfq8DNUmQyJTa((object) this), this.m_now.ToString(this.DatePattern, (IFormatProvider) RollingFileAppender.voVQJqhMXF8vx2FTle3w()));
            num1 = 2;
            continue;
          case 20:
            this.RollFile((string) RollingFileAppender.PCg0gDhMfq8DNUmQyJTa((object) this), this.m_scheduledFilename);
            num1 = 8;
            continue;
          case 21:
            goto label_8;
          case 22:
            fromFile = this.CombinePath(this.File, (string) RollingFileAppender.jxyUndhMTD8c1NOqeXhI(RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1232639661 >> 3 ^ 154077201), (object) num2));
            num1 = 11;
            continue;
          default:
            if (num2 > this.m_curSizeRollBackups)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 20 : 20;
              continue;
            }
            goto case 22;
        }
      }
label_7:
      return;
label_10:
      return;
label_8:;
    }

    private void ClearOverTime()
    {
      int num1 = 1;
      int num2;
      IDisposable disposable;
      DateTime currentDateTime;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_33;
          case 1:
            if (this.MaxDateRollBackups < 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            }
            goto case 9;
          case 2:
          case 5:
            if (num2 > this.MaxDateRollBackups)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 3;
              continue;
            }
            goto case 4;
          case 3:
            disposable = (IDisposable) RollingFileAppender.W1J3T0hM8whc1rWhGYWc((object) this.SecurityContext, (object) this);
            num1 = 6;
            continue;
          case 4:
            currentDateTime = this.PrevDate(currentDateTime, this.m_rollPoint);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 10 : 7;
            continue;
          case 6:
            goto label_11;
          case 7:
            goto label_28;
          case 8:
            num2 = 0;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 2 : 2;
            continue;
          case 9:
            currentDateTime = this.m_now;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 8 : 7;
            continue;
          case 10:
            ++num2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 5 : 5;
            continue;
          default:
            goto label_27;
        }
      }
label_33:
      return;
label_28:
      return;
label_27:
      return;
label_11:
      try
      {
        string[] strArray = (string[]) RollingFileAppender.SZX6MrhJo7fhp1r4jhGK(RollingFileAppender.GS4x8hhM1kooiWGW7QIE((object) this.m_baseFileName), RollingFileAppender.dypyDwhMPx1WP9r2thtV((object) this.CombinePath((string) RollingFileAppender.XeHRHKhMnAojGkoyLnd9((object) this.m_baseFileName), currentDateTime.ToString(this.DatePattern, (IFormatProvider) RollingFileAppender.voVQJqhMXF8vx2FTle3w())), RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-1120607109 - 305487170 ^ -1426136169)), SearchOption.TopDirectoryOnly);
        int num3 = 6;
        while (true)
        {
          int num4 = num3;
          int index;
          string str;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_19;
              case 2:
              case 4:
                if (index >= strArray.Length)
                {
                  num4 = 5;
                  continue;
                }
                goto case 3;
              case 3:
                str = strArray[index];
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
                continue;
              case 5:
                goto label_25;
              case 6:
                index = 0;
                num4 = 4;
                continue;
              default:
                goto label_16;
            }
          }
label_16:
          ++index;
          num3 = 2;
          continue;
label_19:
          try
          {
            RollingFileAppender.sptxmMhJbgtZkIHdqYZE((object) str);
            int num5 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
              num5 = 0;
            switch (num5)
            {
              default:
                goto label_16;
            }
          }
          catch (Exception ex)
          {
            int num6 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
              num6 = 0;
            while (true)
            {
              switch (num6)
              {
                case 1:
                  goto label_16;
                default:
                  RollingFileAppender.KBSKIahM4brId29E624l(RollingFileAppender.declaringType, RollingFileAppender.dypyDwhMPx1WP9r2thtV(RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-1710575414 ^ -1710671492), (object) str), (object) ex);
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 1 : 1;
                  continue;
              }
            }
          }
        }
label_25:;
      }
      finally
      {
        if (disposable != null)
        {
          int num7 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
            num7 = 0;
          while (true)
          {
            switch (num7)
            {
              case 1:
                goto label_35;
              default:
                RollingFileAppender.k9ZxvwhMuwq0oItapG2U((object) disposable);
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 1;
                continue;
            }
          }
        }
label_35:;
      }
    }

    /// <summary>
    /// Renames file <paramref name="fromFile" /> to file <paramref name="toFile" />.
    /// </summary>
    /// <param name="fromFile">Name of existing file to roll.</param>
    /// <param name="toFile">New name for file.</param>
    /// <remarks>
    /// <para>
    /// Renames file <paramref name="fromFile" /> to file <paramref name="toFile" />. It
    /// also checks for existence of target file and deletes if it does.
    /// </para>
    /// </remarks>
    protected void RollFile(string fromFile, string toFile)
    {
      int num1 = 4;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_24;
          case 2:
            goto label_3;
          case 3:
            this.DeleteFile(toFile);
            num1 = 2;
            continue;
          case 4:
            if (this.FileExists(fromFile))
            {
              num1 = 3;
              continue;
            }
            break;
        }
        RollingFileAppender.tK81W3hJGDbpuNIKb8Iq(RollingFileAppender.declaringType, (object) ((string) RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1253244298 - 1829393894 ^ -575985480) + fromFile + (string) RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-218496594 ^ -218525854) + toFile + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420972444)));
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
      }
label_24:
      return;
label_3:
      try
      {
        RollingFileAppender.DUAIlfhMO4Zb35bPZHRw(RollingFileAppender.declaringType, RollingFileAppender.wxwEVAhM75ehxT53DYO0((object) new string[5]
        {
          (string) RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-1290212282 ^ -644262414 ^ 1786918668),
          fromFile,
          (string) RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-1445902765 ^ -1980277732 ^ 539333763),
          toFile,
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106466004)
        }));
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
          num2 = 0;
        IDisposable disposable;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              goto label_22;
            default:
              disposable = (IDisposable) RollingFileAppender.W1J3T0hM8whc1rWhGYWc(RollingFileAppender.dSmtiYhMvKTH81VK4DE1((object) this), (object) this);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
              continue;
          }
        }
label_22:
        return;
label_6:
        try
        {
          System.IO.File.Move(fromFile, toFile);
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
            num3 = 0;
          switch (num3)
          {
          }
        }
        finally
        {
          if (disposable != null)
          {
            int num4 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
              num4 = 0;
            while (true)
            {
              switch (num4)
              {
                case 1:
                  goto label_16;
                default:
                  RollingFileAppender.k9ZxvwhMuwq0oItapG2U((object) disposable);
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
                  continue;
              }
            }
          }
label_16:;
        }
      }
      catch (Exception ex)
      {
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
          num5 = 0;
        while (true)
        {
          switch (num5)
          {
            case 1:
              goto label_9;
            default:
              RollingFileAppender.zuB3YohJhOt91rpnTdhx((object) this.ErrorHandler, (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740500728) + fromFile + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538618150) + toFile + (string) RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-1217523399 ^ -1217468463)), (object) ex, ErrorCode.GenericFailure);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 1;
              continue;
          }
        }
label_9:;
      }
    }

    /// <summary>Test if a file exists at a specified path</summary>
    /// <param name="path">the path to the file</param>
    /// <returns>true if the file exists</returns>
    /// <remarks>
    /// <para>
    /// Test if a file exists at a specified path
    /// </para>
    /// </remarks>
    protected bool FileExists(string path)
    {
      int num1 = 1;
      IDisposable disposable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            disposable = this.SecurityContext.Impersonate((object) this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_3;
        }
      }
label_3:
      bool flag;
      try
      {
        flag = RollingFileAppender.uXWOTehJEVBQAmq3Zl7a((object) path);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (disposable != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                RollingFileAppender.k9ZxvwhMuwq0oItapG2U((object) disposable);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                continue;
              default:
                goto label_12;
            }
          }
        }
label_12:;
      }
label_13:
      return flag;
    }

    /// <summary>Deletes the specified file if it exists.</summary>
    /// <param name="fileName">The file to delete.</param>
    /// <remarks>
    /// <para>
    /// Delete a file if is exists.
    /// The file is first moved to a new filename then deleted.
    /// This allows the file to be removed even when it cannot
    /// be deleted, but it still can be moved.
    /// </para>
    /// </remarks>
    protected void DeleteFile(string fileName)
    {
      int num1 = 1;
      string str1;
      while (true)
      {
        int num2 = num1;
        string str2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (this.FileExists(fileName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
                continue;
              }
              goto label_48;
            case 2:
              goto label_6;
            case 3:
label_25:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 0;
              continue;
            case 4:
              try
              {
                IDisposable disposable = (IDisposable) RollingFileAppender.W1J3T0hM8whc1rWhGYWc((object) this.SecurityContext, (object) this);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_25;
                    case 2:
label_43:
                      str1 = str2;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 1;
                      continue;
                    default:
                      try
                      {
                        RollingFileAppender.DaFoCNhJQ9H8Opvn6VR4((object) fileName, (object) str2);
                        int num4 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
                          num4 = 0;
                        switch (num4)
                        {
                          default:
                            goto label_43;
                        }
                      }
                      finally
                      {
                        int num5;
                        if (disposable == null)
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
                        else
                          goto label_40;
label_37:
                        switch (num5)
                        {
                          case 2:
                            break;
                          default:
                        }
label_40:
                        RollingFileAppender.k9ZxvwhMuwq0oItapG2U((object) disposable);
                        num5 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
                        {
                          num5 = 1;
                          goto label_37;
                        }
                        else
                          goto label_37;
                      }
                  }
                }
              }
              catch (Exception ex)
              {
                int num6 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
                  num6 = 0;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      RollingFileAppender.eGOhfchJCkhGjaAx1hAx(RollingFileAppender.declaringType, RollingFileAppender.wxwEVAhM75ehxT53DYO0((object) new string[5]
                      {
                        (string) RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1033719030 - 2012070891 ^ -978581859),
                        fileName,
                        (string) RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(222162814 ^ 222192050),
                        str2,
                        (string) RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-867826612 ^ -867765596)
                      }), (object) ex);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_25;
                  }
                }
              }
            case 5:
              goto label_50;
            case 6:
              goto label_3;
            default:
              str1 = fileName;
              num2 = 6;
              continue;
          }
        }
label_3:
        str2 = (string) RollingFileAppender.tmaCyVhMmDuDvSFPWGnl((object) new object[4]
        {
          (object) fileName,
          RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(95909607 + 343705423 ^ 439608562),
          (object) RollingFileAppender.mrfUNmhJfbKmwoEGZnts(),
          RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-2106517564 ^ -2106419022)
        });
        num1 = 4;
      }
label_50:
      return;
label_48:
      return;
label_6:
      try
      {
        IDisposable disposable = this.SecurityContext.Impersonate((object) this);
        int num7 = 2;
        while (true)
        {
          switch (num7)
          {
            case 0:
              goto label_44;
            case 1:
label_8:
              LogLog.Debug(RollingFileAppender.declaringType, (string) RollingFileAppender.jM0rpchMVIDgFAvLfkkZ(RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(236071375 ^ 236037695), (object) fileName, RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-787452571 ^ -787440755)));
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
              continue;
            case 2:
              try
              {
                RollingFileAppender.sptxmMhJbgtZkIHdqYZE((object) str1);
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
                  num8 = 0;
                switch (num8)
                {
                  default:
                    goto label_8;
                }
              }
              finally
              {
                int num9;
                if (disposable == null)
                  num9 = 2;
                else
                  goto label_15;
label_14:
                switch (num9)
                {
                  case 1:
                    break;
                  default:
                }
label_15:
                RollingFileAppender.k9ZxvwhMuwq0oItapG2U((object) disposable);
                num9 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
                {
                  num9 = 0;
                  goto label_14;
                }
                else
                  goto label_14;
              }
            default:
              goto label_39;
          }
        }
label_44:
        return;
label_39:;
      }
      catch (Exception ex)
      {
        int num10 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
          num10 = 1;
        while (true)
        {
          switch (num10)
          {
            case 0:
              goto label_38;
            case 1:
              if (RollingFileAppender.drDTnghJvxgnCTPIMulO((object) str1, (object) fileName))
              {
                num10 = 3;
                continue;
              }
              goto case 4;
            case 2:
              goto label_34;
            case 3:
              RollingFileAppender.zuB3YohJhOt91rpnTdhx(RollingFileAppender.em6qRFhMBuS5prl7DqEp((object) this), (object) ((string) RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(864270449 << 6 ^ -521302960) + str1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516859362)), (object) ex, ErrorCode.GenericFailure);
              num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
              continue;
            case 4:
              RollingFileAppender.eGOhfchJCkhGjaAx1hAx(RollingFileAppender.declaringType, (object) ((string) RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1505778440 - 1981636111 ^ -475960149) + str1 + (string) RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-53329496 >> 4 ^ -3288334)), (object) ex);
              num10 = 2;
              continue;
            default:
              goto label_33;
          }
        }
label_38:
        return;
label_34:
        return;
label_33:;
      }
    }

    /// <summary>Implements file roll base on file size.</summary>
    /// <remarks>
    /// <para>
    /// If the maximum number of size based backups is reached
    /// (<c>curSizeRollBackups == maxSizeRollBackups</c>) then the oldest
    /// file is deleted -- its index determined by the sign of countDirection.
    /// If <c>countDirection</c> &lt; 0, then files
    /// {<c>File.1</c>, ..., <c>File.curSizeRollBackups -1</c>}
    /// are renamed to {<c>File.2</c>, ...,
    /// <c>File.curSizeRollBackups</c>}. Moreover, <c>File</c> is
    /// renamed <c>File.1</c> and closed.
    /// </para>
    /// <para>
    /// A new file is created to receive further log output.
    /// </para>
    /// <para>
    /// If <c>maxSizeRollBackups</c> is equal to zero, then the
    /// <c>File</c> is truncated with no backup files created.
    /// </para>
    /// <para>
    /// If <c>maxSizeRollBackups</c> &lt; 0, then <c>File</c> is
    /// renamed if needed and no files are deleted.
    /// </para>
    /// </remarks>
    protected void RollOverSize()
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              RollingFileAppender.JjDBjHhJWcE6JZ1xyO4S((object) this, (object) this.m_baseFileName, false);
              num2 = 6;
              continue;
            case 2:
              goto label_9;
            case 3:
              RollingFileAppender.G84RwfhJBjyX8CtICkJQ((object) this);
              num2 = 2;
              continue;
            case 4:
              this.RollOverRenameFiles((string) RollingFileAppender.PCg0gDhMfq8DNUmQyJTa((object) this));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
              continue;
            case 5:
              RollingFileAppender.DUAIlfhMO4Zb35bPZHRw(RollingFileAppender.declaringType, RollingFileAppender.UtIS75hJ8VsKtEpjtNXn((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477299464), (object) this.CountDirection, RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1142330761 ^ 1541959139 ^ 536743554)));
              num2 = 4;
              continue;
            case 6:
              goto label_3;
            case 7:
              RollingFileAppender.DUAIlfhMO4Zb35bPZHRw(RollingFileAppender.declaringType, (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334965051) + (object) this.MaxSizeRollBackups + RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1669212571 ^ 1669259123)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
              continue;
            default:
              RollingFileAppender.DUAIlfhMO4Zb35bPZHRw(RollingFileAppender.declaringType, RollingFileAppender.UtIS75hJ8VsKtEpjtNXn((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426319409), (object) this.m_curSizeRollBackups, RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1917256330 ^ 1917318242)));
              num2 = 5;
              continue;
          }
        }
label_9:
        RollingFileAppender.DUAIlfhMO4Zb35bPZHRw(RollingFileAppender.declaringType, RollingFileAppender.UtIS75hJ8VsKtEpjtNXn(RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1597012150 ^ 1597237288), (object) RollingFileAppender.iN4xR6hMCmQG70K7ZH2Q((object) (CountingQuietTextWriter) RollingFileAppender.aGX3YLhMQrAyJPLTXrHn((object) this)), RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(~1767720452 ^ -1767747821)));
        num1 = 7;
      }
label_3:;
    }

    /// <summary>Implements file roll.</summary>
    /// <param name="baseFileName">the base name to rename</param>
    /// <remarks>
    /// <para>
    /// If the maximum number of size based backups is reached
    /// (<c>curSizeRollBackups == maxSizeRollBackups</c>) then the oldest
    /// file is deleted -- its index determined by the sign of countDirection.
    /// If <c>countDirection</c> &lt; 0, then files
    /// {<c>File.1</c>, ..., <c>File.curSizeRollBackups -1</c>}
    /// are renamed to {<c>File.2</c>, ...,
    /// <c>File.curSizeRollBackups</c>}.
    /// </para>
    /// <para>
    /// If <c>maxSizeRollBackups</c> is equal to zero, then the
    /// <c>File</c> is truncated with no backup files created.
    /// </para>
    /// <para>
    /// If <c>maxSizeRollBackups</c> &lt; 0, then <c>File</c> is
    /// renamed if needed and no files are deleted.
    /// </para>
    /// <para>
    /// This is called by <see cref="M:EleWise.ELMA.Logging.RollingFileAppender.RollOverSize" /> to rename the files.
    /// </para>
    /// </remarks>
    protected void RollOverRenameFiles(string baseFileName)
    {
      int num1 = 10;
      while (true)
      {
        int num2 = num1;
        string path1;
        int curSizeRollBackups;
        int num3;
        int num4;
        while (true)
        {
          switch (num2)
          {
            case 1:
              path1 = (string) RollingFileAppender.loZkyKhJZ2rWIYXqeZWC((object) path1, 0, num3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 5 : 20;
              continue;
            case 2:
              if (RollingFileAppender.o9tpxShMilIX8xy9TbUW((object) this))
              {
                num2 = 13;
                continue;
              }
              goto case 18;
            case 3:
              if (this.MaxSizeRollBackups > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 24;
                continue;
              }
              goto case 14;
            case 4:
              this.RollFile(baseFileName, this.CombinePath(baseFileName, RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(~-306453669 ^ 306447968).ToString() + (object) this.m_curSizeRollBackups));
              num2 = 8;
              continue;
            case 5:
              if (this.m_curSizeRollBackups == this.MaxSizeRollBackups)
              {
                num2 = 22;
                continue;
              }
              goto case 30;
            case 6:
              if (!this.StaticLogFileName)
              {
                num2 = 17;
                continue;
              }
              goto case 11;
            case 7:
              this.RollFile(baseFileName, this.CombinePath(baseFileName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978577331)));
              num2 = 12;
              continue;
            case 8:
              goto label_33;
            case 9:
              if (this.CountDirection >= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 16 : 8;
                continue;
              }
              goto case 5;
            case 10:
              if (this.MaxSizeRollBackups != 0)
              {
                num2 = 9;
                continue;
              }
              goto label_29;
            case 11:
              ++num4;
              num2 = 25;
              continue;
            case 12:
              goto label_40;
            case 13:
            case 20:
              this.DeleteFile(this.CombinePath(path1, (string) RollingFileAppender.jxyUndhMTD8c1NOqeXhI(RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(~541731958 ^ -541734579), (object) num4)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 3 : 14;
              continue;
            case 14:
            case 21:
              ++this.m_curSizeRollBackups;
              num2 = 29;
              continue;
            case 15:
            case 19:
              if (curSizeRollBackups < 1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
                continue;
              }
              goto label_13;
            case 16:
              if (this.m_curSizeRollBackups < this.MaxSizeRollBackups)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 13 : 21;
                continue;
              }
              goto case 3;
            case 17:
            case 25:
              path1 = baseFileName;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 2 : 0;
              continue;
            case 18:
              num3 = RollingFileAppender.hOHWixhMyA1ldc663ash((object) path1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757130746));
              num2 = 26;
              continue;
            case 22:
              this.DeleteFile(this.CombinePath(baseFileName, RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(-1852837372 ^ -1852839744).ToString() + (object) this.MaxSizeRollBackups));
              num2 = 23;
              continue;
            case 23:
              --this.m_curSizeRollBackups;
              num2 = 30;
              continue;
            case 24:
              num4 = this.m_curSizeRollBackups - this.MaxSizeRollBackups;
              num2 = 6;
              continue;
            case 26:
              if (num3 >= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 0;
                continue;
              }
              goto case 13;
            case 27:
              --curSizeRollBackups;
              num2 = 15;
              continue;
            case 28:
              goto label_13;
            case 29:
              if (RollingFileAppender.o9tpxShMilIX8xy9TbUW((object) this))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 4 : 4;
                continue;
              }
              goto label_36;
            case 30:
              curSizeRollBackups = this.m_curSizeRollBackups;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 19 : 0;
              continue;
            default:
              ++this.m_curSizeRollBackups;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 7 : 7;
              continue;
          }
        }
label_13:
        this.RollFile(this.CombinePath(baseFileName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825392066) + (object) curSizeRollBackups), this.CombinePath(baseFileName, RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1251470110 >> 2 ^ 312860675).ToString() + (object) (curSizeRollBackups + 1)));
        num1 = 27;
      }
label_33:
      return;
label_40:
      return;
label_36:
      return;
label_29:;
    }

    /// <summary>
    /// Get the start time of the next window for the current rollpoint
    /// </summary>
    /// <param name="currentDateTime">the current date</param>
    /// <param name="rollPoint">the type of roll point we are working with</param>
    /// <returns>the start time for the next roll point an interval after the currentDateTime date</returns>
    /// <remarks>
    /// <para>
    /// Returns the date of the next roll point after the currentDateTime date passed to the method.
    /// </para>
    /// <para>
    /// The basic strategy is to subtract the time parts that are less significant
    /// than the rollpoint from the current time. This should roll the time back to
    /// the start of the time window for the current rollpoint. Then we add 1 window
    /// worth of time and get the start time of the next window for the rollpoint.
    /// </para>
    /// </remarks>
    protected DateTime NextCheckDate(
      DateTime currentDateTime,
      RollingFileAppender.RollPoint rollPoint)
    {
      int num1 = 13;
      DateTime dateTime;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 5:
            case 18:
            case 19:
            case 22:
            case 29:
            case 36:
            case 39:
              goto label_19;
            case 2:
              dateTime = dateTime.AddHours((double) -dateTime.Hour);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 9;
              continue;
            case 3:
              dateTime = dateTime.AddHours((double) -dateTime.Hour);
              num2 = 20;
              continue;
            case 4:
              dateTime = dateTime.AddHours((double) (12 - dateTime.Hour));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 1;
              continue;
            case 6:
label_16:
              dateTime = dateTime.AddMilliseconds((double) -dateTime.Millisecond);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
              continue;
            case 7:
              dateTime = dateTime.AddSeconds((double) -dateTime.Second);
              num2 = 37;
              continue;
            case 8:
              goto label_24;
            case 9:
              dateTime = dateTime.AddDays(1.0);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 18 : 13;
              continue;
            case 10:
              dateTime = dateTime.AddSeconds((double) -dateTime.Second);
              num2 = 38;
              continue;
            case 11:
              dateTime = dateTime.AddSeconds((double) -dateTime.Second);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 22 : 27;
              continue;
            case 12:
              switch (rollPoint)
              {
                case RollingFileAppender.RollPoint.TopOfMinute:
                  goto label_13;
                case RollingFileAppender.RollPoint.TopOfHour:
                  goto label_23;
                case RollingFileAppender.RollPoint.HalfDay:
                  goto label_20;
                case RollingFileAppender.RollPoint.TopOfDay:
                  goto label_26;
                case RollingFileAppender.RollPoint.TopOfWeek:
                  goto label_16;
                case RollingFileAppender.RollPoint.TopOfMonth:
                  goto label_28;
                default:
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 39 : 3;
                  continue;
              }
            case 13:
              dateTime = currentDateTime;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 12 : 0;
              continue;
            case 14:
              dateTime = dateTime.AddHours(1.0);
              num2 = 5;
              continue;
            case 15:
              dateTime = dateTime.AddHours((double) -dateTime.Hour);
              num2 = 8;
              continue;
            case 16:
label_20:
              dateTime = dateTime.AddMilliseconds((double) -dateTime.Millisecond);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 11 : 7;
              continue;
            case 17:
              goto label_13;
            case 20:
              dateTime = dateTime.AddDays(1.0);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 22 : 7;
              continue;
            case 21:
              dateTime = dateTime.AddDays((double) (1 - dateTime.Day));
              num2 = 33;
              continue;
            case 23:
              goto label_25;
            case 24:
label_28:
              dateTime = dateTime.AddMilliseconds((double) -dateTime.Millisecond);
              num2 = 10;
              continue;
            case 25:
              dateTime = dateTime.AddMinutes(1.0);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 35 : 36;
              continue;
            case 26:
label_23:
              dateTime = dateTime.AddMilliseconds((double) -dateTime.Millisecond);
              num2 = 28;
              continue;
            case 27:
              goto label_21;
            case 28:
              dateTime = dateTime.AddSeconds((double) -dateTime.Second);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 11 : 35;
              continue;
            case 30:
              dateTime = dateTime.AddMinutes((double) -dateTime.Minute);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 15 : 1;
              continue;
            case 31:
              if (dateTime.Hour < 12)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 4;
                continue;
              }
              goto case 2;
            case 32:
label_26:
              dateTime = dateTime.AddMilliseconds((double) -dateTime.Millisecond);
              num2 = 7;
              continue;
            case 33:
              dateTime = dateTime.AddMonths(1);
              num2 = 29;
              continue;
            case 34:
              dateTime = dateTime.AddSeconds((double) -dateTime.Second);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 25 : 25;
              continue;
            case 35:
              dateTime = dateTime.AddMinutes((double) -dateTime.Minute);
              num2 = 14;
              continue;
            case 37:
              dateTime = dateTime.AddMinutes((double) -dateTime.Minute);
              num2 = 3;
              continue;
            case 38:
              dateTime = dateTime.AddMinutes((double) -dateTime.Minute);
              num2 = 23;
              continue;
            default:
              dateTime = dateTime.AddSeconds((double) -dateTime.Second);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 30 : 9;
              continue;
          }
        }
label_13:
        dateTime = dateTime.AddMilliseconds((double) -dateTime.Millisecond);
        num1 = 34;
        continue;
label_21:
        dateTime = dateTime.AddMinutes((double) -dateTime.Minute);
        num1 = 31;
        continue;
label_24:
        dateTime = dateTime.AddDays((double) (7 - dateTime.DayOfWeek));
        num1 = 19;
        continue;
label_25:
        dateTime = dateTime.AddHours((double) -dateTime.Hour);
        num1 = 21;
      }
label_19:
      return dateTime;
    }

    private DateTime PrevDate(DateTime currentDateTime, RollingFileAppender.RollPoint rollPoint)
    {
      int num1 = 23;
      DateTime dateTime;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
label_25:
              dateTime = dateTime.AddMilliseconds((double) -dateTime.Millisecond);
              num2 = 15;
              continue;
            case 2:
            case 3:
            case 7:
            case 13:
            case 18:
            case 29:
            case 34:
            case 39:
              goto label_6;
            case 4:
              dateTime = dateTime.AddHours((double) -dateTime.Hour);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 27 : 16;
              continue;
            case 5:
              dateTime = dateTime.AddMinutes((double) -dateTime.Minute);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 30 : 12;
              continue;
            case 6:
              dateTime = dateTime.AddSeconds((double) -dateTime.Second);
              num2 = 24;
              continue;
            case 8:
              dateTime = dateTime.AddSeconds((double) -dateTime.Second);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 33 : 32;
              continue;
            case 9:
              dateTime = dateTime.AddMinutes((double) -dateTime.Minute);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 2 : 4;
              continue;
            case 10:
label_19:
              dateTime = dateTime.AddMilliseconds((double) -dateTime.Millisecond);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 6 : 11;
              continue;
            case 11:
              dateTime = dateTime.AddSeconds((double) -dateTime.Second);
              num2 = 9;
              continue;
            case 12:
              dateTime = dateTime.AddMinutes((double) -dateTime.Minute);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
              continue;
            case 14:
              dateTime = dateTime.AddDays(-7.0);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 29 : 29;
              continue;
            case 15:
              dateTime = dateTime.AddSeconds((double) -dateTime.Second);
              num2 = 28;
              continue;
            case 16:
              dateTime = dateTime.AddHours((double) -dateTime.Hour);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 35 : 39;
              continue;
            case 17:
              dateTime = dateTime.AddMonths(-1);
              num2 = 3;
              continue;
            case 19:
              dateTime = dateTime.AddDays((double) -(int) dateTime.DayOfWeek);
              num2 = 14;
              continue;
            case 20:
label_12:
              dateTime = dateTime.AddMilliseconds((double) -dateTime.Millisecond);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 35 : 27;
              continue;
            case 21:
label_5:
              dateTime = dateTime.AddMilliseconds((double) -dateTime.Millisecond);
              num2 = 8;
              continue;
            case 22:
              switch (rollPoint)
              {
                case RollingFileAppender.RollPoint.TopOfMinute:
                  goto label_5;
                case RollingFileAppender.RollPoint.TopOfHour:
                  goto label_26;
                case RollingFileAppender.RollPoint.HalfDay:
                  goto label_12;
                case RollingFileAppender.RollPoint.TopOfDay:
                  goto label_25;
                case RollingFileAppender.RollPoint.TopOfWeek:
                  goto label_11;
                case RollingFileAppender.RollPoint.TopOfMonth:
                  goto label_19;
                default:
                  num2 = 18;
                  continue;
              }
            case 23:
              dateTime = currentDateTime;
              num2 = 22;
              continue;
            case 24:
              dateTime = dateTime.AddMinutes((double) -dateTime.Minute);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 32 : 6;
              continue;
            case 25:
              dateTime = dateTime.AddHours((double) (-12 - dateTime.Hour));
              num2 = 7;
              continue;
            case 26:
              goto label_13;
            case 27:
              goto label_17;
            case 28:
              dateTime = dateTime.AddMinutes((double) -dateTime.Minute);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 36 : 4;
              continue;
            case 30:
              if (dateTime.Hour < 12)
              {
                num2 = 25;
                continue;
              }
              goto case 16;
            case 31:
label_26:
              dateTime = dateTime.AddMilliseconds((double) -dateTime.Millisecond);
              num2 = 6;
              continue;
            case 32:
              dateTime = dateTime.AddHours(-1.0);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 28 : 34;
              continue;
            case 33:
              dateTime = dateTime.AddMinutes(-1.0);
              num2 = 2;
              continue;
            case 35:
              goto label_4;
            case 36:
              dateTime = dateTime.AddHours((double) -dateTime.Hour);
              num2 = 26;
              continue;
            case 37:
              dateTime = dateTime.AddSeconds((double) -dateTime.Second);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 6 : 12;
              continue;
            case 38:
label_11:
              dateTime = dateTime.AddMilliseconds((double) -dateTime.Millisecond);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 37 : 25;
              continue;
            default:
              dateTime = dateTime.AddHours((double) -dateTime.Hour);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 7 : 19;
              continue;
          }
        }
label_4:
        dateTime = dateTime.AddSeconds((double) -dateTime.Second);
        num1 = 5;
        continue;
label_13:
        dateTime = dateTime.AddDays(-1.0);
        num1 = 13;
        continue;
label_17:
        dateTime = dateTime.AddDays((double) (1 - dateTime.Day));
        num1 = 17;
      }
label_6:
      return dateTime;
    }

    static RollingFileAppender()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            // ISSUE: type reference
            RollingFileAppender.declaringType = RollingFileAppender.aGXWfQhJu10ItlyaBIli(__typeref (RollingFileAppender));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 4 : 4;
            continue;
          case 3:
            RollingFileAppender.i3BMnghysbmkjd0Qxytt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 2;
            continue;
          case 4:
            RollingFileAppender.localDateTimeType = RollingFileAppender.tGPG0jhJI0fd1ejtLMIB((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727461368));
            num = 5;
            continue;
          case 5:
            RollingFileAppender.universalDateTimeType = RollingFileAppender.tGPG0jhJI0fd1ejtLMIB(RollingFileAppender.FbXo5ShycRZT1KQ5yGPT(1819636893 << 3 ^ 1671968032));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
            continue;
          default:
            RollingFileAppender.s_date1970 = new DateTime(1970, 1, 1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static void i3BMnghysbmkjd0Qxytt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object FbXo5ShycRZT1KQ5yGPT(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void KbFwdIhyzm1srC5SHZ0J([In] object obj0, bool value) => ((RollingFileAppender) obj0).StaticLogFileName = value;

    internal static bool dENuathyLFDqJZraBkD3() => RollingFileAppender.Ai0EvyhyYJi1upEKrP9d == null;

    internal static RollingFileAppender GZcxqRhyU8LYqI6YE43o() => RollingFileAppender.Ai0EvyhyYJi1upEKrP9d;

    internal static object AAEJQYhMFdu9swff2Zw9() => (object) NumberFormatInfo.InvariantInfo;

    internal static object em6qRFhMBuS5prl7DqEp([In] object obj0) => (object) ((AppenderSkeleton) obj0).ErrorHandler;

    internal static void PBxr1HhMWfnuXDb8gs6g([In] object obj0, [In] object obj1) => ((TextWriterAppender) obj0).QuietWriter = (QuietTextWriter) obj1;

    internal static void d7FqDNhMo377iDUAW7wM([In] object obj0, [In] object obj1) => __nonvirtual (((FileAppender) obj0).Append((LoggingEvent) obj1));

    internal static void BIG5RvhMbePX3mAqsnn6([In] object obj0, [In] object obj1) => __nonvirtual (((FileAppender) obj0).Append((LoggingEvent[]) obj1));

    internal static DateTime EKfIVBhMhyrTRQS9uoHT([In] object obj0) => ((log4net.Appender.RollingFileAppender.IDateTime) obj0).Now;

    internal static bool bZwrCQhMGNFDxX5Vcrxg([In] DateTime obj0, [In] DateTime obj1) => obj0 >= obj1;

    internal static void ODVYEGhMEiLS4W47IZdu([In] object obj0, bool fileIsOpen) => ((RollingFileAppender) obj0).RollOverTime(fileIsOpen);

    internal static object PCg0gDhMfq8DNUmQyJTa([In] object obj0) => (object) ((FileAppender) obj0).File;

    internal static object aGX3YLhMQrAyJPLTXrHn([In] object obj0) => (object) ((TextWriterAppender) obj0).QuietWriter;

    internal static long iN4xR6hMCmQG70K7ZH2Q([In] object obj0) => ((CountingQuietTextWriter) obj0).Count;

    internal static object dSmtiYhMvKTH81VK4DE1([In] object obj0) => (object) ((FileAppender) obj0).SecurityContext;

    internal static object W1J3T0hM8whc1rWhGYWc([In] object obj0, [In] object obj1) => (object) ((SecurityContext) obj0).Impersonate(obj1);

    internal static long zBoY0yhMZngOSCZWivec([In] object obj0) => ((FileInfo) obj0).Length;

    internal static void k9ZxvwhMuwq0oItapG2U([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool EM7X8ZhMIxNZCkg5lyZa() => LogLog.IsErrorEnabled;

    internal static object jM0rpchMVIDgFAvLfkkZ([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static void KdQYXuhMS1mYsOBcahDy([In] Type obj0, [In] object obj1) => LogLog.Error(obj0, (string) obj1);

    internal static bool o9tpxShMilIX8xy9TbUW([In] object obj0) => ((RollingFileAppender) obj0).StaticLogFileName;

    internal static void ObuQyZhMRHfYPym5lM6o([In] object obj0, [In] object obj1, [In] bool obj2) => __nonvirtual (((FileAppender) obj0).OpenFile((string) obj1, obj2));

    internal static void vHnRcvhMqJNRguNlZpQx([In] object obj0, [In] long obj1) => ((CountingQuietTextWriter) obj0).Count = obj1;

    internal static void m6cbtghMK2A3nNHWo0L6([In] object obj0) => Monitor.Exit(obj0);

    internal static object voVQJqhMXF8vx2FTle3w() => (object) DateTimeFormatInfo.InvariantInfo;

    internal static object jxyUndhMTD8c1NOqeXhI([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object degUSchMksgL83QSefY4([In] object obj0) => (object) Path.GetFullPath((string) obj0);

    internal static object XeHRHKhMnAojGkoyLnd9([In] object obj0) => (object) Path.GetFileName((string) obj0);

    internal static void DUAIlfhMO4Zb35bPZHRw([In] Type obj0, [In] object obj1) => LogLog.Debug(obj0, (string) obj1);

    internal static void IWZTBkhM2xlOlPISajtr([In] object obj0, [In] object obj1, DateTime lastDate) => ((RollingFileAppender) obj0).RollOverIfDateBoundaryCrossing((string) obj1, lastDate);

    internal static object NvgiKmhMeurNaa1FktWK([In] object obj0) => (object) Path.GetExtension((string) obj0);

    internal static object dypyDwhMPx1WP9r2thtV([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object GS4x8hhM1kooiWGW7QIE([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static bool Qw8NZEhMNlXZ33Dkgp4w([In] object obj0) => Directory.Exists((string) obj0);

    internal static object c7DR4HhM3tYatLxS6TJv([In] object obj0, [In] object obj1) => (object) ((DirectoryInfo) obj0).GetFileSystemInfos((string) obj1);

    internal static object brSTS0hMpFDraR2D3jFX([In] object obj0) => (object) Path.GetFileNameWithoutExtension((string) obj0);

    internal static object KJ2CKghMaFScgRTphWye([In] object obj0) => (object) ((FileSystemInfo) obj0).Name;

    internal static bool Mw7s1khMDnEgvIPr78U6([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static bool Oj2cHPhMt5Yi3xIxZZa1([In] DateTime obj0, [In] DateTime obj1) => obj0 <= obj1;

    internal static void DOIyAJhMw019YyKaNZIC([In] object obj0) => ((FileSystemInfo) obj0).Delete();

    internal static void KBSKIahM4brId29E624l([In] Type obj0, [In] object obj1, [In] object obj2) => LogLog.Error(obj0, (string) obj1, (Exception) obj2);

    internal static int YO9KBKhM6B2FnVX4AWW0([In] object obj0, [In] object obj1) => ((ArrayList) obj0).Add(obj1);

    internal static bool umKHfMhMHNcm2vY8M0TT([In] DateTime obj0, [In] DateTime obj1) => obj0 > obj1;

    internal static object c1hAKshMAQKUXWJdqrDE([In] object obj0) => (object) ((FileSystemInfo) obj0).FullName;

    internal static object wxwEVAhM75ehxT53DYO0([In] object obj0) => (object) string.Concat((string[]) obj0);

    internal static bool nxhRrdhMxQZlCAJ6hGW6([In] object obj0, [In] object obj1) => ((string) obj0).Equals((string) obj1);

    internal static bool d37f3ohM0u6olBZwYikA([In] object obj0) => ((FileAppender) obj0).AppendToFile;

    internal static object tmaCyVhMmDuDvSFPWGnl([In] object obj0) => (object) string.Concat((object[]) obj0);

    internal static int hOHWixhMyA1ldc663ash([In] object obj0, [In] object obj1) => ((string) obj0).LastIndexOf((string) obj1);

    internal static object YMKWYOhMMO8tscaaI8up() => (object) CultureInfo.InvariantCulture;

    internal static object K0lgfahMJMuK2hll9LTT([In] object obj0, [In] object obj1) => (object) ((string) obj0).ToLower((CultureInfo) obj1);

    internal static object kAhL11hM9NYMf8BEwBae([In] object obj0) => (object) ((ArrayList) obj0).GetEnumerator();

    internal static object L4vkwKhMdqY8q9mKNjqd([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static bool nl74RxhMlpl2di5JK5Fl([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object u2LCGKhMrFErHKRpLN0c([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static object Arn0sxhMg75U5Y0ZxFPe([In] object obj0) => (object) __nonvirtual (((AppenderSkeleton) obj0).Name);

    internal static void nnbPbthM5kQGvgKUaJE2([In] object obj0, [In] object obj1) => ((IErrorHandler) obj0).Error((string) obj1);

    internal static object wi3TxphMjSg5VECmmiPI() => (object) SecurityContextProvider.DefaultProvider;

    internal static object VeBOGmhMYSDvG33hOppx([In] object obj0, [In] object obj1) => (object) ((SecurityContextProvider) obj0).CreateSecurityContext(obj1);

    internal static object KZlvnhhMLRgYkXDXwTVI([In] object obj0) => (object) ((string) obj0).Trim();

    internal static object he41KfhMUwB5pVQQWxaj([In] object obj0) => (object) FileAppender.ConvertToFullPath((string) obj0);

    internal static void l12ZPShMs2RWXbRl08t5([In] object obj0, [In] object obj1) => __nonvirtual (((FileAppender) obj0).File) = (string) obj1;

    internal static void vZbye6hMcKLVC1qgp73q([In] object obj0) => __nonvirtual (((FileAppender) obj0).ActivateOptions());

    internal static object ri1ksDhMzhXVaITvJSe6([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object mTRkCohJFgMRSggrqD6D(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static void G84RwfhJBjyX8CtICkJQ([In] object obj0) => ((FileAppender) obj0).CloseFile();

    internal static void JjDBjHhJWcE6JZ1xyO4S([In] object obj0, [In] object obj1, [In] bool obj2) => ((FileAppender) obj0).SafeOpenFile((string) obj1, obj2);

    internal static object SZX6MrhJo7fhp1r4jhGK([In] object obj0, [In] object obj1, [In] SearchOption obj2) => (object) Directory.GetFiles((string) obj0, (string) obj1, obj2);

    internal static void sptxmMhJbgtZkIHdqYZE([In] object obj0) => System.IO.File.Delete((string) obj0);

    internal static void zuB3YohJhOt91rpnTdhx(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] ErrorCode obj3)
    {
      ((IErrorHandler) obj0).Error((string) obj1, (Exception) obj2, obj3);
    }

    internal static void tK81W3hJGDbpuNIKb8Iq([In] Type obj0, [In] object obj1) => LogLog.Warn(obj0, (string) obj1);

    internal static bool uXWOTehJEVBQAmq3Zl7a([In] object obj0) => System.IO.File.Exists((string) obj0);

    internal static int mrfUNmhJfbKmwoEGZnts() => Environment.TickCount;

    internal static void DaFoCNhJQ9H8Opvn6VR4([In] object obj0, [In] object obj1) => System.IO.File.Move((string) obj0, (string) obj1);

    internal static void eGOhfchJCkhGjaAx1hAx([In] Type obj0, [In] object obj1, [In] object obj2) => LogLog.Debug(obj0, (string) obj1, (Exception) obj2);

    internal static bool drDTnghJvxgnCTPIMulO([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object UtIS75hJ8VsKtEpjtNXn([In] object obj0, [In] object obj1, [In] object obj2) => (object) (obj0.ToString() + obj1 + obj2);

    internal static object loZkyKhJZ2rWIYXqeZWC([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static Type aGXWfQhJu10ItlyaBIli([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static Type tGPG0jhJI0fd1ejtLMIB([In] object obj0) => Type.GetType((string) obj0);

    /// <summary>
    /// The code assumes that the following 'time' constants are in a increasing sequence.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The code assumes that the following 'time' constants are in a increasing sequence.
    /// </para>
    /// </remarks>
    protected enum RollPoint
    {
      /// <summary>Roll the log not based on the date</summary>
      InvalidRollPoint = -1, // 0xFFFFFFFF
      /// <summary>Roll the log for each minute</summary>
      TopOfMinute = 0,
      /// <summary>Roll the log for each hour</summary>
      TopOfHour = 1,
      /// <summary>Roll the log twice a day (midday and midnight)</summary>
      HalfDay = 2,
      /// <summary>Roll the log each day (midnight)</summary>
      TopOfDay = 3,
      /// <summary>Roll the log each week</summary>
      TopOfWeek = 4,
      /// <summary>Roll the log each month</summary>
      TopOfMonth = 5,
    }
  }
}
