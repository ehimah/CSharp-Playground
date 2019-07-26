using System;
using System.IO;
using System.Linq;
using CSharp_Playground.Code_Katas.Function;
using Xunit;
using FluentAssertions;

namespace CSharp_Playground.Tests
{
    public class CSVTabTests
    {
        [Fact]
        public void ShouldReturnExpectedResult()
        {
            var input = File.ReadAllLines(@"C:\code\C#\CSharp Playground\CSharp Playground.Tests\Code Katas\Function\CSVTab\input.txt");
            var expected = File.ReadAllLines(@"C:\code\C#\CSharp Playground\CSharp Playground.Tests\Code Katas\Function\CSVTab\output.txt");
            
            var result = CSVTab.Run(input.ToList());
            result.Should().BeEquivalentTo(expected);
        }
    }
}