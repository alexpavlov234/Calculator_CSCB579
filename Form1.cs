using System.Globalization;
using System.Text.RegularExpressions;

namespace Calculator_CSCB579;

public partial class Form1 : Form
{
    /// <summary>
    /// Първото число в изчислението
    /// </summary>
    private decimal _num1;
    /// <summary>
    /// Второто число в изчислението
    /// </summary>
    private decimal _num2;
    /// <summary>
    /// Операцията, извършвана върху числата.
    /// </summary>
    private Operation? _operation;
    
    /// <summary>
    /// Флаг, указващ дали текстовото поле трябва да бъде изчистено при следващото въвеждане.
    /// </summary>
    private bool _clearTextBoxOnNextInput;
    /// <summary>
    /// Информация за културата за форматиране на числата.
    /// </summary>
    private readonly CultureInfo _cultureInfo = CultureInfo.InvariantCulture;
    /// <summary>
    /// Koнструктор на формата.
    /// </summary>
    public Form1()
    {
        InitializeComponent();
    }
    /// <summary>
    /// Изчиства текстовото поле при следващо въвеждане, ако е зададен съответният флаг.
    /// </summary>
    private void ClearTextBoxOnNextInput()
    {
        if (!_clearTextBoxOnNextInput)
            return;

        this.resultTextBox.Text = "";
        _clearTextBoxOnNextInput = false;
    }
    /// <summary>
    /// Добавя символ към текстовото поле за резултата.
    /// Обработва специална логика за десетична точка, за да не се допуска въвеждането на невалидно число.
    /// </summary>
    /// <param name="symbol">Символът за въвеждане.</param>
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
    /// <summary>
    /// Опитва се да конвертира текст в десетично число.
    /// Показва съобщение за грешка при неуспешна конверсия.
    /// </summary>
    /// <param name="text">Текстът за конвертиране.</param>
    /// <param name="number">Резултатното число при успех.</param>
    /// <returns>true, ако конверсията е успешна; иначе false.</returns>
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

    /// <summary>
    /// Задава операцията, която да се изпълни върху числата.
    /// Запазва първото число и маркира текстовото поле за изчистване.
    /// </summary>
    /// <param name="operation">Операцията за задаване.</param>
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
    /// <summary>
    /// Обработва събитието при натискане на бутон за въвеждане на символ.
    /// Въвежда съответния символ в текстовото поле, чрез извикване на InputCharToTextBox.
    /// </summary>
    private void charInputButton_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        InputCharToTextBox(btn.Text[0]);
    }
    /// <summary>
    /// Обработва събитието при натискане на бутона за смяна на знака.
    /// Умножава текущото число по -1.
    /// </summary>
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
    /// <summary>
    /// Обработва събитието при натискане на бутона за изчистване.
    /// Нулира всички стойности и изчиства текстовото поле.
    /// </summary>
    private void clearButton_Click(object sender, EventArgs e)
    {
        this.resultTextBox.Text = "";
        _num1 = 0;
        _num2 = 0;
        _operation = null;
        _clearTextBoxOnNextInput = false;
    }
    /// <summary>
    /// Обработва събитието при натискане на бутона за изтриване.
    /// Премахва последния символ от текстовото поле.
    /// </summary>
    private void deleteButton_Click(object sender, EventArgs e)
    {
        ClearTextBoxOnNextInput();

        if (!string.IsNullOrEmpty(this.resultTextBox.Text))
        {
            this.resultTextBox.Text = this.resultTextBox.Text.Substring(0, this.resultTextBox.Text.Length - 1);
        }
    }
    /// <summary>
    /// Обработва събитието при натискане на бутона за събиране.
    /// </summary>
    private void additionButton_Click(object sender, EventArgs e)
    {
        SetOperation(Operation.Addition);
    }
    /// <summary>
    /// Обработва събитието при натискане на бутона за изваждане.
    /// </summary>
    private void subtractionButton_Click(object sender, EventArgs e)
    {
        SetOperation(Operation.Subtraction);
    }
    /// <summary>
    /// Обработва събитието при натискане на бутона за умножение.
    /// </summary>
    private void multiplicationButton_Click(object sender, EventArgs e)
    {
        SetOperation(Operation.Multiplication);
    }
    /// <summary>
    /// Обработва събитието при натискане на бутона за деление.
    /// </summary>
    private void divisionButton_Click(object sender, EventArgs e)
    {
        SetOperation(Operation.Division);
    }
    /// <summary>
    /// Обработва събитието при натискане на бутона за изчисление.
    /// Извършва зададената операция и показва резултата.
    /// </summary>
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
