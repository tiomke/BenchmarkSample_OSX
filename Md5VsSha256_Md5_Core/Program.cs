using System;
using System.Diagnostics;
using System.Threading;
using System.Runtime.CompilerServices;
using BenchmarkDotNet;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Extensions;
using BenchmarkDotNet.Helpers;
using BenchmarkDotNet.Running;





namespace BenchmarkDotNet.Autogenerated
{
    public class Program : global::Md5VsSha256
    {
        private IJob job = Job.Default.With(BenchmarkDotNet.Jobs.Mode.Throughput).WithWarmupCount(-1).WithTargetCount(-1).WithIterationTime(-1).WithLaunchCount(-1); // TODO

        public static void Main(string[] args)
        {
            try
            {
				Program instance = new Program();
				
				instance.setupAction();
				instance.targetAction();

                System.Console.WriteLine();
                foreach (var infoLine in EnvironmentHelper.GetCurrentInfo().ToFormattedString())
                {
                    System.Console.WriteLine("// {0}", infoLine);
                }
                System.Console.WriteLine();

                instance.RunBenchmark();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                throw;
            }
        }

        public Program()
        {
            setupAction = () => { };
            idleAction = Idle;
            targetAction = Md5;
        }

        private System.Byte[] value;
        private Action setupAction;
        private Func<System.Byte[]>  targetAction;
        private Func<System.Byte[]>  idleAction;

        public void RunBenchmark()
        {
            new MethodInvoker().Invoke(job, 1, setupAction, targetAction, idleAction);
        }

        private System.Byte[] Idle()
        {
            return null;
        }
    }
}
