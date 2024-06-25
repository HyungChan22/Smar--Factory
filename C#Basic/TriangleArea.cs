using YamlDotNet.Core;
using System.IO;
namespace ConsoleApp5
{
    internal class TriangleArea
    {
        static void Main(string[] args)
        {
            //1. 변수선언 및 입력부
            Console.WriteLine("가로값을 입력해주세요");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("높이값을 입력해주세요");
            double height = double.Parse(Console.ReadLine());

            //2. 알고리즘 수식
            double result = width * height / 2.0;

            //3. 출력부
            Console.WriteLine($"넓이는 {result} 입니다.");
        }
    }
}