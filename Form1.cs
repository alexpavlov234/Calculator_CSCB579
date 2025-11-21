using System.Globalization;
using System.Text.RegularExpressions;

namespace Calculator_CSCB579;

public partial class Form1 : Form
{
    private decimal _num1;
    private decimal _num2;
    private Operation? _operation;
    private bool _clearTextBoxOnNextInput;
    private readonly CultureInfo _cultureInfo = CultureInfo.InvariantCulture;
    public Form1()
    {
        InitializeComponent();
    }
    private void ClearTextBoxOnNextInput()
    {
        if (!_clearTextBoxOnNextInput)
            return;

        this.resultTextBox.Text = "";
        _clearTextBoxOnNextInput = false;
    }
    private void InputCharToTextBox(char symbol)
    {
        ClearTextBoxOnNextInput();
        if (symbol == '.')
        {
            if (!resultTextBox.Text.Contains('.') && Regex.IsMatch(resultTextBox.Text, @"^(?:-?\d+)?$"))
            {
                this.resultTextBox.Text += ".";
            }
        }
        else if (char.IsDigit(symbol))
        {
            this.resultTextBox.Text += symbol;
        }

    }

    private bool TryParseNumber(string text, out decimal number)
    {
        number = 0;

        if (string.IsNullOrWhiteSpace(text))
        {
            MessageBox.Show("Моля, въведете число.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (!decimal.TryParse(text, NumberStyles.Any, _cultureInfo, out number))
        {
            MessageBox.Show("Невалидно число.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        return true;
    }

    private void SetOperation(Operation operation)
    {
        ClearTextBoxOnNextInput();
        if (_operation is not null)
            return;
        if (!TryParseNumber(this.resultTextBox.Text, out _num1))
        {
            return;
        }
        _operation = operation;
        _clearTextBoxOnNextInput = true;
    }

    private void number0Button_Click(object sender, EventArgs e)
    {
        InputCharToTextBox('0');
    }
    private void number1Button_Click(object sender, EventArgs e)
    {
        InputCharToTextBox('1');
    }
    private void number2Button_Click(object sender, EventArgs e)
    {
        InputCharToTextBox('2');
    }
    private void number3Button_Click(object sender, EventArgs e)
    {
        InputCharToTextBox('3');
    }
    private void number4Button_Click(object sender, EventArgs e)
    {
        InputCharToTextBox('4');
    }
    private void number5Button_Click(object sender, EventArgs e)
    {
        InputCharToTextBox('5');
    }
    private void number6Button_Click(object sender, EventArgs e)
    {
        InputCharToTextBox('6');
    }
    private void number7Button_Click(object sender, EventArgs e)
    {
        InputCharToTextBox('7');
    }
    private void number8Button_Click(object sender, EventArgs e)
    {
        InputCharToTextBox('8');
    }
    private void number9Button_Click(object sender, EventArgs e)
    {
        InputCharToTextBox('9');
    }
    private void decimalPointButton_Click(object sender, EventArgs e)
    {
        InputCharToTextBox('.');
    }
    private void changeSignButton_Click(object sender, EventArgs e)
    {
        ClearTextBoxOnNextInput();
        if (!TryParseNumber(this.resultTextBox.Text, out decimal number))
        {
            return;
        }
        number *= -1;

        this.resultTextBox.Text = number.ToString(_cultureInfo);
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
        this.resultTextBox.Text = "";
        _num1 = 0;
        _num2 = 0;
        _operation = null;
        _clearTextBoxOnNextInput = false;
    }
    private void deleteButton_Click(object sender, EventArgs e)
    {
        ClearTextBoxOnNextInput();

        if (!string.IsNullOrEmpty(this.resultTextBox.Text))
        {
            this.resultTextBox.Text = this.resultTextBox.Text.Substring(0, this.resultTextBox.Text.Length - 1);
        }
    }
    private void additionButton_Click(object sender, EventArgs e)
    {
        SetOperation(Operation.Addition);
    }
    private void subtractionButton_Click(object sender, EventArgs e)
    {
        SetOperation(Operation.Subtraction);
    }
    private void multiplicationButton_Click(object sender, EventArgs e)
    {
        SetOperation(Operation.Multiplication);
    }
    private void divisionButton_Click(object sender, EventArgs e)
    {
        SetOperation(Operation.Division);
    }
    private void calculateButton_Click(object sender, EventArgs e)
    {
        ClearTextBoxOnNextInput();
        if (_operation is null)
        {
            return;
        }

        if (!TryParseNumber(this.resultTextBox.Text, out _num2))
        {
            return;
        }
        
        decimal result = 0;
        
        if (_operation is Operation.Division && _num2 == 0)
        {
            this.resultTextBox.Text = "Грешка!";
            _num1 = 0;
            _num2 = 0;
            _operation = null;
            _clearTextBoxOnNextInput = true;
            return;
        }
        
        result = _operation switch
        {
            Operation.Addition => _num1 + _num2,
            Operation.Subtraction => _num1 - _num2,
            Operation.Multiplication => _num1 * _num2,
            Operation.Division => _num1 / _num2,
            _ => result
        };

        this.resultTextBox.Text = Math.Round(result, 10).ToString(_cultureInfo);
        _num1 = 0;
        _num2 = 0;
        _operation = null;
        _clearTextBoxOnNextInput = true;
    }
}
