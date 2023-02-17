using Refit;

namespace TestRefit;

public interface IMyBudgetsService
{
    [Get("/api/budgets")]
    Task<IList<Budget>> GetBudgets();
}