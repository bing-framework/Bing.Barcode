# Bing.Barcode
[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://mit-license.org/)

Bing.Barcode��BingӦ�ÿ�ܵ�������������Ŀ⡣
��Ҫ������������ع��ܲ�����

## Nuget Packages
|Nuget|�汾��|˵��|
|---|---|---|
|Bing.Barcode|[![NuGet Badge](https://buildstats.info/nuget/Bing.Barcode?includePreReleases=true)](https://www.nuget.org/packages/Bing.Barcode)|
|Bing.Barcode.ZXing|[![NuGet Badge](https://buildstats.info/nuget/Bing.Barcode.ZXing?includePreReleases=true)](https://www.nuget.org/packages/Bing.Barcode.ZXing)|

## ʵ�ֹ���
- ������������
- �Զ�����ɫ����������

## �������
- System.Drawing.Common
- [ZXing.Net](https://github.com/micjahn/ZXing.Net)
- [ZXing.Net.Bindings.ZKWeb.System.Drawing](https://github.com/micjahn/ZXing.Net)

## Demo
### ��������
```
IBarcodeService service = new ZXingBarcodeService();
service.Param(new BarcodeService()
{
    Content = "Test Name is Bing.Barcode.Zxing.Tests",
    Level = ErrorCorrectionLevel.Q,
    Width = 100,
    Height = 50,
});
service.ToBase64String();
```

## �ӿ�˵��
### ���ò���
- Width�����
- Height: �߶�
- Level���ݴ���
- Content����ά������
- Foreground��ǰ��ɫ
- Background������ɫ
- Margin: �߾�
- ShowText: ��ʾ�������ı�

### �ӿڷ���
- `Param(BarcodeParam param)`���������������
- `ToStream()`�������
- `ToBytes()`������ֽ�����
- `ToBase64String()`�����Base64�ַ���
- `ToBase64String(Base64ImageType type)`�����Base64�ַ�����������ǰ׺
- `WriteToFile(string path)`��������ļ�

### �ݴ���(`ErrorCorrectionLevel`)
- L��Ĭ�ϣ����Ծ������7%�Ĵ���
- M�����Ծ������15%�Ĵ���
- Q�����Ծ������25%�Ĵ���
- H�����Ծ������30%�Ĵ���

## ����

������

## �����뷴��

> ��������Ķ���ʹ��Bing������һ������Ƭ��ʱ����Bug�����и���ʵ�ַ�ʽ����֪ͨ���ǡ�

> Ϊ�˱��ִ���򵥣�Ŀǰ�ܶ๦��ֻ�����˻����ṹ��ϸ������δ����Ǩ�ƣ��ں�����Ҫʱ������ӣ�����㷢��ĳ�����޷��������������֪ͨ���ǡ�

> �����ͨ��github��Issue��Pull Request�������ύ����ʹ��룬������ϲ��ʹ��QQ���н�������������ǵĽ���QQȺ��

> �������ύ�Ĵ��룬������Ǿ������ɣ����ܻ������Ӧ�ع�����ͳһ������

> �������ĵ�ͬѧ�������������ַŵ�**������**�����С�

## ��������
- ��Ȼ���ǶԴ����Ѿ����и߶���飬�������Լ�����Ŀ�У�����Ȼ���ܴ���ĳЩδ֪��BUG������������ϵͳ������ʧ��Bing �ŶӲ���Դ˸���
- ���ڳɱ��Ŀ��ǣ����ǲ�����ѷ�����API���ּ��ݣ�ÿ�����´���ʱ����ע������⡣

## ��Դ��ַ
[https://github.com/bing-framework/Bing.Barcode](https://github.com/bing-framework/Bing.Barcode)

## License

**MIT**

> ����ζ������������ⳡ����ʹ�� Bing Ӧ�ÿ�ܶ�������������ҪǮ��

> Bing �ᾡ�����뿪Դ��ѵĵ�����������ܣ��������⣬���������˽⡣
