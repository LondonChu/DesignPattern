using System;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            // Append : 加在字串後面
            stringBuilder.Append(new char[] { 'D', 'E', 'F' });
            stringBuilder.Append(true);
            Console.WriteLine(stringBuilder);
            // AppendFormat : 加在字串後面(加入的字串代format)
            stringBuilder.AppendFormat("GHI{0}{1}", 'J', 'k');
            Console.WriteLine("{0} chars: {1}", stringBuilder.Length, stringBuilder);
            // Insert : 插入字串至指定位置
            stringBuilder.Insert(4, "4444544444444444444444444444 ");
            // Replace : 取代指定字串
            stringBuilder.Replace('k', 'K');
            // Remove : 移除指定位置字串
            stringBuilder.Remove(4, 4);
            Console.WriteLine("{0} chars: {1}", stringBuilder.Length, stringBuilder);
        }
    }
}
