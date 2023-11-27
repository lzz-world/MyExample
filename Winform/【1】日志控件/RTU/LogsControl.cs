using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;

namespace RTU
{
    public partial class LogsControl : UserControl
    {
        private List<BaseLog> _allLogs = new List<BaseLog>();
        private static LogLevel _logMarkLevel = LogLevel.All;
        private int _infoCount = 0, _warnCount = 0, _errorCount = 0;

        public LogsControl()
        {
            InitializeComponent();

            this.LogListView.Columns.Add("日志", this.Width);
            this.LogListView.HeaderStyle = ColumnHeaderStyle.None;

            #region 测试添加
#if DEBUG
            this.AddBtn.Visible = true;
            Random random = new Random();
            this.AddBtn.Click += (s, e) =>
            {
                for (int i = 0; i < 100; i++)
                {
                    switch (random.Next(0, 3))
                    {
                        case 0: LogInfo("-------------------------Info"); break;
                        case 1: LogWarn("-------------------------Warn"); break;
                        case 2: LogError("-------------------------Error"); break;
                        default:
                            break;
                    }
                };
            };

            bool autoAddLog = false;
            this.AutoAddBtn.Click += (s, e) =>
            {
                autoAddLog = !autoAddLog;
                if (AutoAddBtn.Checked == true)
                {
                    Task.Run(async () =>
                    {
                        while (autoAddLog)
                        {
                            for (int i = 0; i < 100; i++)
                            {
                                switch (random.Next(0, 3))
                                {
                                    case 0: LogInfo("-------------------------Info"); break;
                                    case 1: LogWarn("-------------------------Warn"); break;
                                    case 2: LogError("-------------------------Error"); break;
                                    default:
                                        break;
                                }
                            };
                            await Task.Delay(1000);
                        }
                    });
                }
            };
#else
            this.AddBtn.Visible = false;
            this.AutoAddBtn.Visible = false;
#endif
            #endregion
        }

        private void InvokeLog(LogLevel level, string message, Color color)
        {
            // 检查是否需要 Invoke 到 UI 线程
            if (LogListView.InvokeRequired)
            {
                // 如果当前线程不是 UI 线程，则使用 Invoke 将操作传递到 UI 线程
                LogListView.Invoke((MethodInvoker)delegate
                {
                    // 在 UI 线程上执行更新操作
                    // 例如：更新 LogListView 控件的操作
                    Log(level, message, color);
                });
            }
            else
            {
                // 在 UI 线程上执行更新操作
                // 例如：更新 LogListView 控件的操作
                Log(level, message, color);
            }
        }

        private void Log(LogLevel level, string message, Color color)
        {
            DateTime currentTime = DateTime.Now;
            string milliseconds = currentTime.Millisecond.ToString("000");
            var log = new BaseLog { Level = level, Message = message, LogColor = color, DateTime = $"{currentTime}:{milliseconds}" };
            _allLogs.Add(log);

            this.LogListView.BeginUpdate();

            // 根据选择等级添加显示
            if (log.Level == _logMarkLevel)
            {
                this.LogListView.Items.Add(new ListViewItem()
                {
                    Text = $"{log.DateTime}     {log.Message}",
                    ForeColor = log.LogColor
                });
            }
            else if (_logMarkLevel == LogLevel.All)
            {
                this.LogListView.Items.Add(new ListViewItem()
                {
                    Text = $"{log.DateTime}     {log.Message}",
                    ForeColor = log.LogColor
                });
            }

            switch (level)
            {
                case LogLevel.Info: _infoCount += 1; InfoBtn.Text = $"正常({_infoCount})"; break;
                case LogLevel.Warn: _warnCount += 1; WarnBtn.Text = $"警告({_warnCount})"; break;
                case LogLevel.Error: _errorCount += 1; ErrorBtn.Text = $"报警({_errorCount})"; break;
                default: break;
            }

            // 自动滚动
            if (AutoRollBtn.Checked)
            {
                if (LogListView.Items.Count > 0)
                    LogListView.EnsureVisible(LogListView.Items.Count - 1);
            }

            // 日志限制数量
            if (_allLogs.Count > 3000)
            {
                var indexLevel = _allLogs.First();

                if (LogListView.Items.Count > 0)
                {
                    var viewItem = LogListView.Items[0];
                    if (viewItem.Text == $"{indexLevel.DateTime}     {indexLevel.Message}" &&
                        viewItem.ForeColor == indexLevel.LogColor)
                        LogListView.Items.RemoveAt(0);
                }
                _allLogs.RemoveAt(0);

                switch (indexLevel.Level)
                {
                    case LogLevel.Info: _infoCount -= 1; InfoBtn.Text = $"正常({_infoCount})"; break;
                    case LogLevel.Warn: _warnCount -= 1; WarnBtn.Text = $"警告({_warnCount})"; break;
                    case LogLevel.Error: _errorCount -= 1; ErrorBtn.Text = $"报警({_errorCount})"; break;
                    default: break;
                }
            }

            this.LogListView.EndUpdate();
        }

        private void FilterLog(IEnumerable<BaseLog> logs)
        {
            this.LogListView.BeginUpdate();
            this.LogListView.Items.Clear();

            List<ListViewItem> subViewItems = new List<ListViewItem>();

            foreach (var log in logs)
                subViewItems.Add(new ListViewItem()
                {
                    Text = $"{log.DateTime}     {log.Message}",
                    ForeColor = log.LogColor
                });

            this.LogListView.Items.AddRange(subViewItems.ToArray());
            this.LogListView.EndUpdate();

            // 自动滚动
            if (AutoRollBtn.Checked)
            {
                if (LogListView.Items.Count > 0)
                    LogListView.EnsureVisible(LogListView.Items.Count - 1);
            }
        }

        /// <summary>
        /// 打印正常信息
        /// </summary>
        /// <param name="text"></param>
        public void LogInfo(string text) => InvokeLog(LogLevel.Info, text, Color.Black);

        /// <summary>
        /// 记录警告信息
        /// </summary>
        /// <param name="text"></param>
        public void LogWarn(string text) => InvokeLog(LogLevel.Warn, text, Color.Blue);

        /// <summary>
        /// 记录错误信息
        /// </summary>
        /// <param name="text"></param>
        public void LogError(string text) => InvokeLog(LogLevel.Error, text, Color.Red);

        private void AllBtn_Click(object sender, EventArgs e)
        {
            _logMarkLevel = LogLevel.All;
            FilterLog(_allLogs.Select(s => s).ToList());
        }
        private void InfoBtn_Click(object sender, EventArgs e)
        {
            _logMarkLevel = LogLevel.Info;
            FilterLog(_allLogs.Where(w => w.Level == LogLevel.Info).ToList());
        }
        private void WarnBtn_Click(object sender, EventArgs e)
        {
            _logMarkLevel = LogLevel.Warn;
            FilterLog(_allLogs.Where(w => w.Level == LogLevel.Warn).ToList());
        }
        private void ErrorBtn_Click(object sender, EventArgs e)
        {
            _logMarkLevel = LogLevel.Error;
            FilterLog(_allLogs.Where(w => w.Level == LogLevel.Error).ToList());
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.LogListView.Items.Clear();
            _allLogs.Clear();
            _infoCount = 0;
            _warnCount = 0;
            _errorCount = 0;

            InfoBtn.Text = $"正常({_infoCount})";
            WarnBtn.Text = $"警告({_warnCount})";
            ErrorBtn.Text = $"报警({_errorCount})";
        }
    }

    enum LogLevel
    {
        All,
        Info,
        Warn,
        Error
    }

    class BaseLog
    {
        public LogLevel Level { get; set; }

        public string DateTime { get; set; }

        public string Message { get; set; }

        public Color LogColor { get; set; }
    }
}
