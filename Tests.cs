using System;
using System.Collections.Generic;

public class Tests
{
  private static List<(int[] input, string expected)> _part1TestCases = new()
  {
    (new int[]{9, 3, 5, 2, 13, 4}, "2-5, 9, 13"),
    (new int[]{14, 13, 3}, "3, 13, 14"),
    (new int[]{5, 3, 1, 14, 11, 13, 10, 4, 19, 12}, "1, 3-5, 10-14, 19"),
    (new int[]{}, ""),
    (new int[]{3, 1, 18, 0, 2, 10, 17, 19}, "0-3, 10, 17-19")
  };

  private static List<(string[] input, string expected)> _part2TestCases = new()
  {
    (new string[]{"2021-08-25", "2021-08-24", "2021-08-23"}, "Mon - Wed"),
    (new string[]{"2021-08-24", "2021-08-25"}, "Tue, Wed"),
    (new string[]{"2021-08-28", "2021-08-25", "2021-08-26", "2021-08-24"}, "Tue - Thu, Sat")
  };

  public static void TestPart1(ISolution solver)
  {
    foreach ((int[] input, string expected) in _part1TestCases)
    {
      FormatTestOutput(expected, solver.FormatIntArray(input));
    }
  }

  private static void FormatTestOutput(string expected, string actual)
  {
    Console.WriteLine("Expected {0}  Received {1}", expected, actual);
  }

  public static void TestPart2(ISolution solver)
  {
    foreach((string[] input, string expected) in _part2TestCases)
    {
      FormatTestOutput(expected, solver.FormatDateStringArray(input));
    }
  }
}
