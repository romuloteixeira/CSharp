<Query Kind="Program">
  <Reference>&lt;ProgramFilesX86&gt;\Microsoft Visual Studio\2019\Enterprise\CoreCon\Binaries\Phone Tools\Debugger\CoreClr\x64\System.Net.Http.dll</Reference>
  <Namespace>System.Net.Http</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
  <IncludeAspNet>true</IncludeAspNet>
</Query>

async void Main()
{
/*
Common Language Runtime
IL = Intermediate Language

async = transforma de function/method para objeto na state machine
*/
/*
A = Text
1 = second
*/
		Thread.CurrentThread.ManagedThreadId.Dump("A");
		var client = new HttpClient();
		Thread.CurrentThread.ManagedThreadId.Dump("B");
		var task = client.GetStringAsync("http://google.com");
		Thread.CurrentThread.ManagedThreadId.Dump("C");
		var a = 0;
        for (var i = 0; i > 1_000_000; i++)
        {
            a += i;
        }
		Thread.CurrentThread.ManagedThreadId.Dump("D");
		var page = await task;
		Thread.CurrentThread.ManagedThreadId.Dump("E");
		await Task.Delay(400);
		Thread.CurrentThread.ManagedThreadId.Dump("F");
}

// Define other methods, classes and namespaces here
