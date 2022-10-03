using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    
    /*
     
    private readonly AppViewModel viewModel;
    
    public MainWindow()
    {
        InitializeComponent();
        this.viewModel = new ();
        this.DataContext = this.viewModel;
    }

    private void AddDigitToDisplay(string? digitText)
    {
        if (int.TryParse(digitText, out var digit) is false)
        {
            return;
        }
        this.viewModel.CurrentValue = this.viewModel.CurrentValue * 10 + digit;
    }

    
    
    private static string? GetContentControlText(object? sender)
        => (sender as ContentControl)?.Content?.ToString();
    
    
    
    private void Digit_Click(object sender, RoutedEventArgs e) 
        => AddDigitToDisplay(GetContentControlText(sender));
    
    private void Negate_Click(object sender, RoutedEventArgs e) 
        => this.viewModel.CurrentValue *= -1;

    private void Operator_Click(object sender, RoutedEventArgs e)
    {
        var text = GetContentControlText(sender);
        if (text?.Length is not 1)
            return;
        PerformOperation();
        this.viewModel.Operator = text[0] switch
        {
            '+' => Operator.Add,
            '-' => Operator.Subtract,
            '*' => Operator.Multiply,
            '/' => Operator.Divide,
            _ => throw new InvalidOperationException(),
        };
        this.viewModel.PreviousValue = this.viewModel.CurrentValue;
        this.viewModel.CurrentValue = 0;
    }
    private void PerformOperation()
    {
        if (this.viewModel.Operator != default)
        {
            this.viewModel.CurrentValue = PerformOperation(this.viewModel.Operator, this.viewModel.PreviousValue, this.viewModel.CurrentValue);
        }
    }
    private static double PerformOperation(Operator op, double left, double right) => op switch
    {
        Operator.Add => left + right,
        Operator.Subtract => left - right,
        Operator.Multiply => left * right,
        Operator.Divide => left / right,
        _ => right,
    };

    private void Equals_Click(object sender, RoutedEventArgs e) => PerformOperation();
    
    */
}