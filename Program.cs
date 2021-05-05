using System;
using IntervalMerge.Models;
using IntervalMerge.Services;
using IntervalMerge.Services.Test;

namespace IntervalMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            var intervalService = new IntervalService();
            var mergeResult = intervalService.mergeIntervals(MockData.exampleInput);
            foreach (var value in MockData.exampleInput) {
                Console.WriteLine($"Input interval: {value.ToString()}");
            }
            Console.WriteLine("========================");
            foreach(var result in mergeResult) {
                Console.WriteLine($"Result interval: {result.ToString()}");
            }
        }
    }
}
