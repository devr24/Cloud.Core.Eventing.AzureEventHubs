using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Cloud.Core.Testing;
using Xunit;

namespace Cloud.Core.Eventing.AzureEventHubs.Tests.Performance
{
    [IsPerformance]
    public class PerformanceTests
    {
        [Fact]
        public void Test_PerformanceTesting_Run()
        {
            BenchmarkRunner.Run<PerformanceTests>();
        }
    }

    [MemoryDiagnoser]
    public class PerformanceBenchmarks : IDisposable
    {
        [Benchmark]
        public void Test_Performance_DoTest()
        {

        }

        public void Dispose()
        {

        }
    }
}
