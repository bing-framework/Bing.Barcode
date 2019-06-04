using Xunit.Abstractions;

namespace Bing.Barcode.Tests
{
    /// <summary>
    /// ���Ի���
    /// </summary>
    public class TestBase
    {
        /// <summary>
        /// ���
        /// </summary>
        protected ITestOutputHelper Output;

        /// <summary>
        /// ��ʼ��һ��<see cref="TestBase"/>���͵�ʵ��
        /// </summary>
        public TestBase(ITestOutputHelper output)
        {
            Output = output;
        }
    }
}
