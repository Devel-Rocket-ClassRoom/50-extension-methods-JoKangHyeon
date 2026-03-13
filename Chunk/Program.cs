using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("=== 컬렉션 청킹 테스트 ===");


Console.WriteLine();
Console.WriteLine("[숫자를 3개씩 그룹화]");
List<int> nums = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
foreach (var chunk in nums.Chunk(3))
{
    Console.WriteLine($"[{string.Join(", ", chunk)}]");
}


Console.WriteLine();
Console.WriteLine("[학생들을 2명씩 팀 구성]");
List<string> students = new() { "김철수", "이영희", "박민수", "최지연", "정우진" };
int c = 1;
foreach (var team in students)
{
    Console.WriteLine($"팀 {c++}: {string.Join(", ", team)}");
}


Console.WriteLine();
Console.WriteLine("[페이지별로 5개씩 나누기]");
c = 1;
foreach (var page in Enumerable.Sequence(1, 25, 1).Chunk(5))
{
    Console.WriteLine($"페이지 {c++}: {string.Join(", ", page)}");
}
