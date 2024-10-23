CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
CancellationToken cancellationToken =  cancellationTokenSource.Token;

Console.CancelKeyPress += Console_CancelKeyPress;

void Console_CancelKeyPress(object? sender, ConsoleCancelEventArgs e)
{
    e.Cancel = true;
    cancellationTokenSource.Cancel();
}

Console.WriteLine("[PROGRAM START]");

while (!cancellationToken.IsCancellationRequested)
{
    Console.WriteLine("[{0:HH:mm:ss}] Ok", DateTime.UtcNow);
    Thread.Sleep(1000);
}

Console.WriteLine("[PROGRAM END]");