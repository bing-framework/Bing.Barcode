using System.Drawing;
using Bing.Barcode.Abstractions;
using Bing.Barcode.Core;
using Bing.Barcode.Enums;
using Bing.Barcode.ZXing;
using Xunit;
using Xunit.Abstractions;

namespace Bing.Barcode.Tests
{
    /// <summary>
    /// ZXing.Net 条形码服务
    /// Base64转图片工具：http://tool.chinaz.com/tools/imgtobase/
    /// </summary>
    public class ZXingBarcodeServiceTest : TestBase
    {
        /// <summary>
        /// 条形码服务
        /// </summary>
        private IBarcodeService _service;

        /// <summary>
        /// 内容
        /// </summary>
        private const string Content = "Test Name is Bing.Barcode.ZXing.Tests";

        /// <summary>
        /// 初始化一个<see cref="ZXingBarcodeServiceTest"/>类型的实例
        /// </summary>
        public ZXingBarcodeServiceTest(ITestOutputHelper output) : base(output)
        {
            _service = new ZXingBarcodeService();
        }

        /// <summary>
        /// 测试输出基础条形码Base64字符串
        /// </summary>
        [Fact]
        public void Test_Output_BaseCode_Base64()
        {
            _service.Param(new BarcodeParam()
            {
                Content = Content,
                Level = ErrorCorrectionLevel.Q,
                Width = 100,
                Height = 50,
            });
            var result = _service.ToBase64String();
            Output.WriteLine(result);
        }

        /// <summary>
        /// 测试输出基础条形码Base64字符串并带前缀
        /// </summary>
        [Fact]
        public void Test_Output_BaseCode_Base64_Prefix()
        {
            _service.Param(new BarcodeParam()
            {
                Content = Content,
                Level = ErrorCorrectionLevel.Q,
                Width = 300,
                Height = 100,
            });
            var result = _service.ToBase64String(Base64ImageType.Jpeg);
            Output.WriteLine(result);
        }

        /// <summary>
        /// 测试输出基础条形码Base64字符串并带前缀以及显示文本
        /// </summary>
        [Fact]
        public void Test_Output_BaseCode_Base64_Prefix_ShowText()
        {
            _service.Param(new BarcodeParam()
            {
                Content = Content,
                Level = ErrorCorrectionLevel.Q,
                Width = 300,
                Height = 100,
                ShowText = true
            });
            var result = _service.ToBase64String(Base64ImageType.Jpeg);
            Output.WriteLine(result);
        }

        /// <summary>
        /// 测试输出基础条形码Base64字符串并带前缀以及自定义颜色
        /// </summary>
        [Fact]
        public void Test_Output_BaseCode_Base64_Prefix_CustomColor()
        {
            _service.Param(new BarcodeParam()
            {
                Content = Content,
                Level = ErrorCorrectionLevel.Q,
                Width = 300,
                Height = 100,
                ShowText = true,
                Foreground = Color.Red
            });
            var result = _service.ToBase64String(Base64ImageType.Jpeg);
            Output.WriteLine(result);
        }
    }
}
