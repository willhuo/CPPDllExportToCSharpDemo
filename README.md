# CPPDllExportToCSharpDemo
dotnet core to use C++ dll

注意
1. C++生成动态链接库DLL的时候，需要指定CPU为X64。

![Alt text](https://github.com/willhuo/CPPDllExportToCSharpDemo/blob/master/Imgs/1.png)


2. “__declspec(dllexport)”意思是将后面修饰的内容定义为DLL中要导出的内容。
当然你也可以不使用这个宏，可以直接将”__declspec(dllexport)”写在要导出的函数前面。C++中定义如下：
extern "C" __declspec(dllexport) int  Add(int n1, int n2);
