using Microsoft.Extensions.DependencyInjection;
using Refit;
using TestRefit;

var services = new ServiceCollection();
services.AddRefitClient<IMyBudgetsService>()
    .ConfigureHttpClient(client => client.BaseAddress = new Uri("https://localhost:7168"));
var serviceProvider = services.BuildServiceProvider();

var myBudgetsService = serviceProvider.GetRequiredService<IMyBudgetsService>();
var budgets = await myBudgetsService.GetBudgets();
Console.WriteLine(budgets.Count);
