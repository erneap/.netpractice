using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Recipes.Client.Core.ViewModels;

public class IngredientListViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName]string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    private int _numberOfServings = 4;
    public int NumberOfServings
    {
        get => _numberOfServings;
        set
        {
            if (_numberOfServings != value)
            {
                _numberOfServings = value;
                OnPropertyChanged();
            }
        }
    }

    // TODO: add list of ingredients
}
