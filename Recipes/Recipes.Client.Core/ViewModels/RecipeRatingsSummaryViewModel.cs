using System;

namespace Recipes.Client.Core.ViewModels;

public class RecipeRatingsSummaryViewModel
{
    public double MaxRating { get; } = 4d;
    public double? AverageRating { get; set; } = 3.5d;
}
