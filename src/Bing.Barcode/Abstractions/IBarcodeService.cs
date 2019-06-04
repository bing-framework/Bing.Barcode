using System.IO;
using Bing.Barcode.Core;
using Bing.Barcode.Enums;

namespace Bing.Barcode.Abstractions
{
    /// <summary>
    /// 条形码服务
    /// </summary>
    public interface IBarcodeService
    {
        /// <summary>
        /// 设置条形码参数
        /// </summary>
        /// <param name="param">条形码参数</param>
        IBarcodeService Param(BarcodeParam param);

        /// <summary>
        /// 转换成流
        /// </summary>
        Stream ToStream();

        /// <summary>
        /// 转换成字节数组
        /// </summary>
        byte[] ToBytes();

        /// <summary>
        /// 转换成Base64字符串
        /// </summary>
        string ToBase64String();

        /// <summary>
        /// 转换成Base64字符串，并附带前缀
        /// </summary>
        /// <param name="type">图片类型</param>
        string ToBase64String(Base64ImageType type);

        /// <summary>
        /// 写入到文件
        /// </summary>
        /// <param name="path">文件路径</param>
        string WriteToFile(string path);
    }
}
