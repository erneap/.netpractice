using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Recipes.Client.Core.ViewModels;

public class RecipeDetailViewModel : INotifyPropertyChanged
{
    private void SetFavorite(bool isFavorite) => IsFavorite = isFavorite;
    private bool CanSetFavorite(bool isFavorite) => IsFavorite != isFavorite;
    public RecipeDetailViewModel()
    {
        SetFavoriteCommand = new Command<bool>(SetFavorite, CanSetFavorite);
    }
    public string Title { get; set; } = "Classic Caesar Salad";
    public IngredientListViewModel IngredientsList { get; set; } = new ();

    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName]string? propertyName = null) 
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    private bool _hideAllergenInformation = true;
    public bool HideAllergenInformation
    {
        get => _hideAllergenInformation;
        set
        {
            if (_hideAllergenInformation != value)
            {
                _hideAllergenInformation = value;
                OnPropertyChanged();
            }
        }
    }

    private bool _isFavorite = false;
    public bool IsFavorite
    {
        get => _isFavorite;
        set
        {
            if (_isFavorite != value)
            {
                _isFavorite = value;
                OnPropertyChanged();

                ((Command)SetFavoriteCommand).ChangeCanExecute();
            }
        }
    }

    public ICommand SetFavoriteCommand
    {
        get;
    }

    public RecipeRatingsSummaryViewModel RatingDetail { get; set; } = new();

    public int? Calories { get; set; } = 240;
    public int? ReadyInMinutes { get; set; } = 35;
    public DateTime LastUpdated { get; set; } = new DateTime(2020, 7, 3);
}
