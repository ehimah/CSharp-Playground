using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CSharp_Playground.Code_Katas.Function;
using FluentAssertions;
using Xunit;

namespace CSharp_Playground.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void ShouldReturnExpectedResult()
        {
            var expected =
                File.ReadAllLines(
                    @"C:\code\C#\CSharp Playground\CSharp Playground.Tests\Code Katas\Function\FizzBuzz\input.txt");
            var result = FizzBuzz.Run(expected.Length);
            result.Should().BeEquivalentTo(expected);


        }
    }
}
