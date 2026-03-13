using System;

Console.WriteLine("| 입력 | 결과 | 설명 |");
Console.WriteLine("|------|------|------|");
Console.WriteLine($"| \"토마토\" | {"토마토".IsPalindrome()} | 거꾸로 해도 \"토마토\" |");
Console.WriteLine($"| \"level\" | {"level".IsPalindrome()} | 영어 회문 |");
Console.WriteLine($"| \"A man, a plan, a canal: Panama\" | {"A man, a plan, a canal: Panama".IsPalindrome()} | 공백/문장부호 무시 시 \"amanaplanacanalpanama\" |");
Console.WriteLine($"| \"race a car\" | {"race a car".IsPalindrome()} | \"raceacar\"는 회문이 아님 |");
Console.WriteLine($"| \"\" / null | {"".IsPalindrome()} | 빈 문자열 또는 null |");
