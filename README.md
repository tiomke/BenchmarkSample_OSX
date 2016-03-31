# BenchmarkSample_OSX
A simple presentation of benchmarking .NET Core via BenchmarkDotNet on OSX.

**Environment:**

```
BenchmarkDotNet=v0.9.4.0
OS=OSX 10.10.2
HostCLR=CORE, Arch=64-bit RELEASE [RyuJIT]
```

## Description

> **Main Contents**    
> - BenchmarkDotnetCliProj\
>   + Results\    
>   + Program.cs    
>   + project.json    
> - Md5VsSha256_Md5_Core\    
> - Md5VsSha256_Sha256_Core\    

**BenchmarkDotnetCliProj** is the main project created through `dotnet cli` . The only source file `Program.cs` benchmarks Md5 and Sha with the help of `BenchmarkDotNet`, the dependencies are configed in file `project.json` .

**Results** folder contains the result plots and rawdata files, as well as logs. I create this folder manually for conciseness.
**Md5VsSha256_Md5_Core** and **Md5VsSha256_Sha256_Core** are real benchmark projects generated at runtime.

> *Notice:* if you want to use DNXCore with BenchmarkDotNet, you should use `0.9.4-beta` instead of `0.9.4-*` . Because BenchmarkDotNet have some beta dependencies in dnxcore50 profile. And it is impossible to publish stable version of the package with unstable dependencies.


## Reference

[Here](https://github.com/PerfDotNet/BenchmarkDotNet) for more details about `BenchmarkDotNet` .

----
Thanks for the Warm Help of [@AdamSitnik](https://twitter.com/SitnikAdam) and [@AndreyAkinshin](http://aakinshin.net/).
