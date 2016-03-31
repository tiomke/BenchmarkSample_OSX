
using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Extensions;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Toolchains.Results;
//using Microsoft.Build.Evaluation;
//using Microsoft.Build.Execution;


namespace BenchmarkDotnetCliProj
{
	class Program{

		public string Name{ get; }
		public override string ToString() => Name;

		public int Value { get; }
		public bool IsAuto => Value < 0;

		private const long TicksPerMiliSecond = TimeSpan.TicksPerSecond / 1000;

		public Program(){
			Name = "this is a program";
			Value = 5;
		}
		public static int Main(){

			var config = new ManualConfig ();
			config.Add (Job.Core);
			//var streamLogger = new StreamLogger ("./../ResultLog.txt");
			//config.Add (streamLogger);
			config.Add (ConsoleLogger.Default);
			config.Add (RPlotExporter.Default);
			config.Add (CsvMeasurementsExporter.Default);
			config.Add (CsvExporter.Default);
			config.Add (PlainExporter.Default);
			var summary = BenchmarkRunner.Run<Md5VsSha256>(config);

			return 0;
		}
	}
}

public class Md5VsSha256
{
	private const int N = 10000;
	private readonly byte[] data;

	private readonly SHA256 sha256 = SHA256.Create();
	private readonly MD5 md5 = MD5.Create();

	public Md5VsSha256()
	{
		data = new byte[N];
		new Random(42).NextBytes(data);
	}

	[Benchmark]
	public byte[] Sha256()
	{
		return sha256.ComputeHash(data);
	}

	[Benchmark]
	public byte[] Md5()
	{
		return md5.ComputeHash(data);
	}
}
