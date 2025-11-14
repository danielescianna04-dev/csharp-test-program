using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CSharpTestApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _display = "0";

    private double _firstNumber = 0;
    private string _operation = "";
    private bool _newNumber = true;

    [RelayCommand]
    private void Number(string number)
    {
        if (_newNumber)
        {
            Display = number;
            _newNumber = false;
        }
        else
        {
            Display = Display == "0" ? number : Display + number;
        }
    }

    [RelayCommand]
    private void Operation(string operation)
    {
        _firstNumber = double.Parse(Display);
        _operation = operation;
        _newNumber = true;
    }

    [RelayCommand]
    private void Equals()
    {
        double secondNumber = double.Parse(Display);
        double result = _operation switch
        {
            "+" => _firstNumber + secondNumber,
            "-" => _firstNumber - secondNumber,
            "×" => _firstNumber * secondNumber,
            "÷" => secondNumber != 0 ? _firstNumber / secondNumber : 0,
            _ => secondNumber
        };
        Display = result.ToString();
        _newNumber = true;
    }

    [RelayCommand]
    private void Clear()
    {
        Display = "0";
        _firstNumber = 0;
        _operation = "";
        _newNumber = true;
    }
}
