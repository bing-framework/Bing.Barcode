using System;
using System.DrawingCore;
using System.DrawingCore.Imaging;
using System.IO;
using Bing.Barcode.Abstractions;
using Bing.Barcode.Core;
using Bing.Barcode.Enums;
using ZXing;
using ZXing.OneD;
using ZXing.ZKWeb.Rendering;
using ZQI = global::ZXing.QrCode.Internal;

namespace Bing.Barcode.ZXing
{
    /// <summary>
    /// ZXing.Net 条形码服务
    /// </summary>
    public class ZXingBarcodeService : BarcodeServiceBase, IBarcodeService
    {
        /// <summary>
        /// ZXing.Net容错级别
        /// </summary>
        private ZQI.ErrorCorrectionLevel _level;

        /// <summary>
        /// 处理容错级别
        /// </summary>
        /// <param name="level">容错级别</param>
        protected override void HandlerCorrectionLevel(ErrorCorrectionLevel level)
        {
            switch (level)
            {
                case ErrorCorrectionLevel.L:
                    _level = ZQI.ErrorCorrectionLevel.L;
                    break;
                case ErrorCorrectionLevel.M:
                    _level = ZQI.ErrorCorrectionLevel.M;
                    break;
                case ErrorCorrectionLevel.Q:
                    _level = ZQI.ErrorCorrectionLevel.Q;
                    break;
                case ErrorCorrectionLevel.H:
                    _level = ZQI.ErrorCorrectionLevel.H;
                    break;
                default:
                    throw new NotImplementedException("未知容错级别");
            }
        }

        /// <summary>
        /// 创建条形码
        /// </summary>
        /// <param name="param">条形码参数</param>
        /// <returns></returns>
        protected override byte[] Create(BarcodeParam param)
        {
            using (var bitmap = GetBitmap(param))
            {
                using (var ms = new MemoryStream())
                {
                    bitmap.Save(ms, ImageFormat.Png);
                    return ms.ToArray();
                }
            }
        }

        /// <summary>
        /// 获取条形码图片
        /// </summary>
        /// <param name="param">条形码参数</param>
        /// <returns></returns>
        private Bitmap GetBitmap(BarcodeParam param)
        {
            // 使用ITF 格式，不能被现在常用的支付宝、微信扫出来
            // 如果想生成可识别的可以使用 CODE_128 格式
            BarcodeWriter<Bitmap> bitmapBarcodeWriter = new BarcodeWriter<Bitmap>()
            {
                Format = BarcodeFormat.CODE_128,
                Options = new Code128EncodingOptions()
                {
                    Margin = param.Margin,
                    Width = param.Width,
                    Height = param.Height,
                    PureBarcode = !param.ShowText,
                    Hints =
                    {
                        {EncodeHintType.CHARACTER_SET, "UTF-8"},
                        {EncodeHintType.ERROR_CORRECTION, _level}
                    }
                },
                Renderer = GetRenderer(param)
            };

            return bitmapBarcodeWriter.Write(param.Content);
        }

        /// <summary>
        /// 获取渲染器
        /// </summary>
        /// <param name="param">条形码参数</param>
        /// <returns></returns>
        private BitmapRenderer GetRenderer(BarcodeParam param)
        {
            var renderer = new BitmapRenderer();
            renderer.Foreground = Color.FromName(param.Foreground.Name);
            renderer.Background = Color.FromName(param.Background.Name);
            renderer.TextFont = new Font(param.FontName, param.FontSize, param.Bold ? FontStyle.Bold : FontStyle.Regular);
            return renderer;
        }
    }
}
