using System;
using System.Collections.Generic;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("=== 컬렉션 셔플 테스트 ===");


Console.WriteLine();
Console.WriteLine("[숫자 리스트 셔플]");
List<int> nums = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine($"원본: {string.Join(", ", nums)}");
nums.Shuffle();
Console.WriteLine($"셔플: {string.Join(", ", nums)}");


Console.WriteLine();
Console.WriteLine("[카드 덱 셔플]");
List<string> cards = new() { "♠A", "♥K", "♦Q", "♣J" };
Console.WriteLine($"원본: {string.Join(", ", cards)}");
cards.Shuffle();
Console.WriteLine($"셔플: {string.Join(", ", cards)}");


Console.WriteLine();
Console.WriteLine("[학생 순서 무작위 배치]");
List<string> students = new() { "김철수", "이영희", "박민수", "최지연", "정우진" };
Console.WriteLine($"원본: {string.Join(", ", students)}");
students.Shuffle();
Console.WriteLine($"셔플: {string.Join(", ", students)}");
