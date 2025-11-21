using System.Globalization;
using System.Text.RegularExpressions;

namespace Calculator_CSCB579;

public partial class Form1 : Form
{
    private decimal _num1;
    private decimal _num2;
    private Operation? _operation;
    private bool _clearTextBoxOnNextInput;
    public Form1()
    {
        InitializeComponent();
    }
    private void number0Button_Click(object sender, EventArgs e)
    {
        if (_clearTextBoxOnNextInput)
        {
            this.resultTextBox.Text = "";
            _clearTextBoxOnNextInput = false;
        }
        this.resultTextBox.Text += "0";
    }
    private void number1Button_Click(object sender, EventArgs e)
    {
        if (_clearTextBoxOnNextInput)
        {
            this.resultTextBox.Text = "";
            _clearTextBoxOnNextInput = false;
        }
        this.resultTextBox.Text += "1";
    }
    private void number2Button_Click(object sender, EventArgs e)
    {
        if (_clearTextBoxOnNextInput)
        {
            this.resultTextBox.Text = "";
            _clearTextBoxOnNextInput = false;
        }
        this.resultTextBox.Text += "2";
    }
    private void number3Button_Click(object sender, EventArgs e)
    {
        if (_clearTextBoxOnNextInput)
        {
            this.resultTextBox.Text = "";
            _clearTextBoxOnNextInput = false;
        }
        this.resultTextBox.Text += "3";
    }
    private void number4Button_Click(object sender, EventArgs e)
    {
        if (_clearTextBoxOnNextInput)
        {
            this.resultTextBox.Text = "";
            _clearTextBoxOnNextInput = false;
        }
        this.resultTextBox.Text += "4";
    }
    private void number5Button_Click(object sender, EventArgs e)
    {
        if (_clearTextBoxOnNextInput)
        {
            this.resultTextBox.Text = "";
            _clearTextBoxOnNextInput = false;
        }
        this.resultTextBox.Text += "5";
    }
    private void number6Button_Click(object sender, EventArgs e)
    {
        if (_clearTextBoxOnNextInput)
        {
            this.resultTextBox.Text = "";
            _clearTextBoxOnNextInput = false;
        }
        this.resultTextBox.Text += "6";
    }
    private void number7Button_Click(object sender, EventArgs e)
    {
        if (_clearTextBoxOnNextInput)
        {
            this.resultTextBox.Text = "";
            _clearTextBoxOnNextInput = false;
        }
        this.resultTextBox.Text += "7";
    }
    private void number8Button_Click(object sender, EventArgs e)
    {
        if (_clearTextBoxOnNextInput)
        {
            this.resultTextBox.Text = "";
            _clearTextBoxOnNextInput = false;
        }
        this.resultTextBox.Text += "8";
    }
    private void number9Button_Click(object sender, EventArgs e)
    {
        if (_clearTextBoxOnNextInput)
        {
            this.resultTextBox.Text = "";
            _clearTextBoxOnNextInput = false;
        }
        this.resultTextBox.Text += "9";
    }
    private void decimalPointButton_Click(object sender, EventArgs e)
    {
        if (_clearTextBoxOnNextInput)
        {
            this.resultTextBox.Text = "";
            _clearTextBoxOnNextInput = false;
            return;
        }
        if (!resultTextBox.Text.Contains('.') && Regex.IsMatch(resultTextBox.Text, @"^(?:-?\d+)?$"))
        {
            this.resultTextBox.Text += ".";
        }

    }
    private void changeSignButton_Click(object sender, EventArgs e)
    {
        if (_clearTextBoxOnNextInput)
        {
            this.resultTextBox.Text = "";
            _clearTextBoxOnNextInput = false;
            return;
        }
        decimal.TryParse(this.resultTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal number);
        number *= -1;

        this.resultTextBox.Text = number.ToString(CultureInfo.InvariantCulture);
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
        if (_clearTextBoxOnNextInput)
        {
            this.resultTextBox.Text = "";
            _clearTextBoxOnNextInput = false;
        }

        if (!string.IsNullOrEmpty(this.resultTextBox.Text))
        {
            this.resultTextBox.Text = this.resultTextBox.Text.Substring(0, this.resultTextBox.Text.Length - 1);
        }
    }
    private void additionButton_Click(object sender, EventArgs e)
    {
        if (_clearTextBoxOnNextInput)
        {
            this.resultTextBox.Text = "";
            _clearTextBoxOnNextInput = false;
            return;
        }
        if (string.IsNullOrEmpty(this.resultTextBox.Text) || _operation is not null)
            return;

        decimal.TryParse(this.resultTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal numberFromTextBox);
        _num1 = numberFromTextBox;
        _operation = Operation.Addition;
        _clearTextBoxOnNextInput = true;

    }


    private void subtractionButton_Click(object sender, EventArgs e)
    {
        if (_clearTextBoxOnNextInput)
        {
            this.resultTextBox.Text = "";
            _clearTextBoxOnNextInput = false;
            return;
        }
        if (string.IsNullOrEmpty(this.resultTextBox.Text) || _operation is not null)
            return;

        decimal.TryParse(this.resultTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal numberFromTextBox);
        _num1 = numberFromTextBox;
        _operation = Operation.Subtraction;
        _clearTextBoxOnNextInput = true;

    }
    private void multiplicationButton_Click(object sender, EventArgs e)
    {
        if (_clearTextBoxOnNextInput)
        {
            this.resultTextBox.Text = "";
            _clearTextBoxOnNextInput = false;
            return;
        }
        if (string.IsNullOrEmpty(this.resultTextBox.Text) || _operation is not null)
            return;

        decimal.TryParse(this.resultTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal numberFromTextBox);
        _num1 = numberFromTextBox;
        _operation = Operation.Multiplication;
        _clearTextBoxOnNextInput = true;
    }
    private void divisionButton_Click(object sender, EventArgs e)
    {
        if (_clearTextBoxOnNextInput)
        {
            this.resultTextBox.Text = "";
            _clearTextBoxOnNextInput = false;
            return;
        }
        if (string.IsNullOrEmpty(this.resultTextBox.Text) || _operation is not null)
            return;

        decimal.TryParse(this.resultTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal numberFromTextBox);
        _num1 = numberFromTextBox;
        _operation = Operation.Division;
        _clearTextBoxOnNextInput = true;
    }
    private void calculateButton_Click(object sender, EventArgs e)
    {
        if (_clearTextBoxOnNextInput)
        {
            this.resultTextBox.Text = "";
            _clearTextBoxOnNextInput = false;
            return;
        }
        if (string.IsNullOrEmpty(this.resultTextBox.Text) || _operation is null)
        {
            return;
        }

        decimal.TryParse(this.resultTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal numberFromTextBox);
        _num2 = numberFromTextBox;
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
        switch (_operation)
        {
            case Operation.Addition:
                result = _num1 + _num2;
                break;
            case Operation.Subtraction:
                result = _num1 - _num2;
                break;
            case Operation.Multiplication:
                result = _num1 * _num2;
                break;
            case Operation.Division:
                result = _num1 / _num2;
                break;
        }

        this.resultTextBox.Text = Math.Round(result, 10).ToString(CultureInfo.InvariantCulture);
        _num1 = 0;
        _num2 = 0;
        _operation = null;
        _clearTextBoxOnNextInput = true;
    }
}
