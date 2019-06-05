using System.Drawing;
using Bing.Barcode.Enums;

namespace Bing.Barcode.Core
{
    /// <summary>
    /// 条形码参数
    /// </summary>
    public class BarcodeParam
    {
        /// <summary>
        /// 宽度
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// 高度
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// 容错级别
        /// </summary>
        public ErrorCorrectionLevel Level { get; set; }

        /// <summary>
        /// 前景色
        /// </summary>
        public Color Foreground { get; set; }

        /// <summary>
        /// 背景色
        /// </summary>
        public Color Background { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 边距
        /// </summary>
        public int Margin { get; set; }

        /// <summary>
        /// 是否显示文本
        /// </summary>
        public bool ShowText { get; set; }

        /// <summary>
        /// 字体名称
        /// </summary>
        public string FontName { get; set; }

        /// <summary>
        /// 字体大小
        /// </summary>
        public int FontSize { get; set; }

        /// <summary>
        /// 是否加粗
        /// </summary>
        public bool Bold { get; set; }

        /// <summary>
        /// 初始化一个<see cref="BarcodeParam"/>类型的实例
        /// </summary>
        public BarcodeParam()
        {
            Foreground = Color.Black;
            Background = Color.White;
            Level = ErrorCorrectionLevel.L;
            Content = string.Empty;
            Width = 200;
            Height = 50;
            Margin = 1;
            ShowText = false;
            FontName = "微软雅黑";
            FontSize = 18;
            Bold = false;
        }
    }
}
