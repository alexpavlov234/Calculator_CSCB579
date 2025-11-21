namespace Calculator_CSCB579;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        resultTextBox = new System.Windows.Forms.TextBox();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        multiplicationButton = new System.Windows.Forms.Button();
        subtractionButton = new System.Windows.Forms.Button();
        additionButton = new System.Windows.Forms.Button();
        number7Button = new System.Windows.Forms.Button();
        number4Button = new System.Windows.Forms.Button();
        number1Button = new System.Windows.Forms.Button();
        number5Button = new System.Windows.Forms.Button();
        number2Button = new System.Windows.Forms.Button();
        clearButton = new System.Windows.Forms.Button();
        number0Button = new System.Windows.Forms.Button();
        number9Button = new System.Windows.Forms.Button();
        number6Button = new System.Windows.Forms.Button();
        number3Button = new System.Windows.Forms.Button();
        decimalPointButton = new System.Windows.Forms.Button();
        changeSignButton = new System.Windows.Forms.Button();
        number8Button = new System.Windows.Forms.Button();
        calculateButton = new System.Windows.Forms.Button();
        divisionButton = new System.Windows.Forms.Button();
        deleteButton = new System.Windows.Forms.Button();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        SuspendLayout();
        // 
        // resultTextBox
        // 
        resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        resultTextBox.Font = new System.Drawing.Font("Rubik", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        resultTextBox.Location = new System.Drawing.Point(12, 12);
        resultTextBox.Name = "resultTextBox";
        resultTextBox.ReadOnly = true;
        resultTextBox.Size = new System.Drawing.Size(300, 45);
        resultTextBox.TabIndex = 0;
        resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        tableLayoutPanel1.ColumnCount = 4;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel1.Controls.Add(multiplicationButton, 3, 1);
        tableLayoutPanel1.Controls.Add(subtractionButton, 3, 2);
        tableLayoutPanel1.Controls.Add(additionButton, 3, 3);
        tableLayoutPanel1.Controls.Add(number7Button, 0, 0);
        tableLayoutPanel1.Controls.Add(number4Button, 0, 1);
        tableLayoutPanel1.Controls.Add(number1Button, 0, 2);
        tableLayoutPanel1.Controls.Add(number5Button, 1, 1);
        tableLayoutPanel1.Controls.Add(number2Button, 1, 2);
        tableLayoutPanel1.Controls.Add(clearButton, 0, 3);
        tableLayoutPanel1.Controls.Add(number0Button, 1, 3);
        tableLayoutPanel1.Controls.Add(number9Button, 2, 0);
        tableLayoutPanel1.Controls.Add(number6Button, 2, 1);
        tableLayoutPanel1.Controls.Add(number3Button, 2, 2);
        tableLayoutPanel1.Controls.Add(decimalPointButton, 2, 3);
        tableLayoutPanel1.Controls.Add(changeSignButton, 3, 0);
        tableLayoutPanel1.Controls.Add(number8Button, 1, 0);
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel1.Size = new System.Drawing.Size(240, 319);
        tableLayoutPanel1.TabIndex = 1;
        // 
        // multiplicationButton
        // 
        multiplicationButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        multiplicationButton.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        multiplicationButton.ForeColor = System.Drawing.Color.LightSkyBlue;
        multiplicationButton.Location = new System.Drawing.Point(180, 79);
        multiplicationButton.Margin = new System.Windows.Forms.Padding(0);
        multiplicationButton.Name = "multiplicationButton";
        multiplicationButton.Size = new System.Drawing.Size(60, 79);
        multiplicationButton.TabIndex = 15;
        multiplicationButton.Text = "×";
        multiplicationButton.UseVisualStyleBackColor = true;
        multiplicationButton.Click += operationButton_Click;
        // 
        // subtractionButton
        // 
        subtractionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        subtractionButton.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        subtractionButton.ForeColor = System.Drawing.Color.LightSkyBlue;
        subtractionButton.Location = new System.Drawing.Point(180, 158);
        subtractionButton.Margin = new System.Windows.Forms.Padding(0);
        subtractionButton.Name = "subtractionButton";
        subtractionButton.Size = new System.Drawing.Size(60, 79);
        subtractionButton.TabIndex = 16;
        subtractionButton.Text = "-";
        subtractionButton.UseVisualStyleBackColor = true;
        subtractionButton.Click += operationButton_Click;
        // 
        // additionButton
        // 
        additionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        additionButton.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        additionButton.ForeColor = System.Drawing.Color.LightSkyBlue;
        additionButton.Location = new System.Drawing.Point(180, 237);
        additionButton.Margin = new System.Windows.Forms.Padding(0);
        additionButton.Name = "additionButton";
        additionButton.Size = new System.Drawing.Size(60, 82);
        additionButton.TabIndex = 17;
        additionButton.Text = "+";
        additionButton.UseVisualStyleBackColor = true;
        additionButton.Click += operationButton_Click;
        // 
        // number7Button
        // 
        number7Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        number7Button.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        number7Button.ForeColor = System.Drawing.SystemColors.ControlText;
        number7Button.Location = new System.Drawing.Point(0, 0);
        number7Button.Margin = new System.Windows.Forms.Padding(0);
        number7Button.Name = "number7Button";
        number7Button.Size = new System.Drawing.Size(60, 79);
        number7Button.TabIndex = 9;
        number7Button.Text = "7";
        number7Button.UseVisualStyleBackColor = true;
        number7Button.Click += charInputButton_Click;
        // 
        // number4Button
        // 
        number4Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        number4Button.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        number4Button.ForeColor = System.Drawing.SystemColors.ControlText;
        number4Button.Location = new System.Drawing.Point(0, 79);
        number4Button.Margin = new System.Windows.Forms.Padding(0);
        number4Button.Name = "number4Button";
        number4Button.Size = new System.Drawing.Size(60, 79);
        number4Button.TabIndex = 6;
        number4Button.Text = "4";
        number4Button.UseVisualStyleBackColor = true;
        number4Button.Click += charInputButton_Click;
        // 
        // number1Button
        // 
        number1Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        number1Button.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        number1Button.ForeColor = System.Drawing.SystemColors.ControlText;
        number1Button.Location = new System.Drawing.Point(0, 158);
        number1Button.Margin = new System.Windows.Forms.Padding(0);
        number1Button.Name = "number1Button";
        number1Button.Size = new System.Drawing.Size(60, 79);
        number1Button.TabIndex = 2;
        number1Button.Text = "1";
        number1Button.UseVisualStyleBackColor = true;
        number1Button.Click += charInputButton_Click;
        // 
        // number5Button
        // 
        number5Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        number5Button.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        number5Button.ForeColor = System.Drawing.SystemColors.ControlText;
        number5Button.Location = new System.Drawing.Point(60, 79);
        number5Button.Margin = new System.Windows.Forms.Padding(0);
        number5Button.Name = "number5Button";
        number5Button.Size = new System.Drawing.Size(60, 79);
        number5Button.TabIndex = 7;
        number5Button.Text = "5";
        number5Button.UseVisualStyleBackColor = true;
        number5Button.Click += charInputButton_Click;
        // 
        // number2Button
        // 
        number2Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        number2Button.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        number2Button.ForeColor = System.Drawing.SystemColors.ControlText;
        number2Button.Location = new System.Drawing.Point(60, 158);
        number2Button.Margin = new System.Windows.Forms.Padding(0);
        number2Button.Name = "number2Button";
        number2Button.Size = new System.Drawing.Size(60, 79);
        number2Button.TabIndex = 3;
        number2Button.Text = "2";
        number2Button.UseVisualStyleBackColor = true;
        number2Button.Click += charInputButton_Click;
        // 
        // clearButton
        // 
        clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        clearButton.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        clearButton.ForeColor = System.Drawing.Color.Firebrick;
        clearButton.Location = new System.Drawing.Point(0, 237);
        clearButton.Margin = new System.Windows.Forms.Padding(0);
        clearButton.Name = "clearButton";
        clearButton.Size = new System.Drawing.Size(60, 82);
        clearButton.TabIndex = 0;
        clearButton.Text = "C";
        clearButton.UseVisualStyleBackColor = true;
        clearButton.Click += clearButton_Click;
        // 
        // number0Button
        // 
        number0Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        number0Button.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        number0Button.ForeColor = System.Drawing.SystemColors.ControlText;
        number0Button.Location = new System.Drawing.Point(60, 237);
        number0Button.Margin = new System.Windows.Forms.Padding(0);
        number0Button.Name = "number0Button";
        number0Button.Size = new System.Drawing.Size(60, 82);
        number0Button.TabIndex = 5;
        number0Button.Text = "0";
        number0Button.UseVisualStyleBackColor = true;
        number0Button.Click += charInputButton_Click;
        // 
        // number9Button
        // 
        number9Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        number9Button.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        number9Button.ForeColor = System.Drawing.SystemColors.ControlText;
        number9Button.Location = new System.Drawing.Point(120, 0);
        number9Button.Margin = new System.Windows.Forms.Padding(0);
        number9Button.Name = "number9Button";
        number9Button.Size = new System.Drawing.Size(60, 79);
        number9Button.TabIndex = 11;
        number9Button.Text = "9";
        number9Button.UseVisualStyleBackColor = true;
        number9Button.Click += charInputButton_Click;
        // 
        // number6Button
        // 
        number6Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        number6Button.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        number6Button.ForeColor = System.Drawing.SystemColors.ControlText;
        number6Button.Location = new System.Drawing.Point(120, 79);
        number6Button.Margin = new System.Windows.Forms.Padding(0);
        number6Button.Name = "number6Button";
        number6Button.Size = new System.Drawing.Size(60, 79);
        number6Button.TabIndex = 8;
        number6Button.Text = "6";
        number6Button.UseVisualStyleBackColor = true;
        number6Button.Click += charInputButton_Click;
        // 
        // number3Button
        // 
        number3Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        number3Button.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        number3Button.ForeColor = System.Drawing.SystemColors.ControlText;
        number3Button.Location = new System.Drawing.Point(120, 158);
        number3Button.Margin = new System.Windows.Forms.Padding(0);
        number3Button.Name = "number3Button";
        number3Button.Size = new System.Drawing.Size(60, 79);
        number3Button.TabIndex = 4;
        number3Button.Text = "3";
        number3Button.UseVisualStyleBackColor = true;
        number3Button.Click += charInputButton_Click;
        // 
        // decimalPointButton
        // 
        decimalPointButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        decimalPointButton.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        decimalPointButton.ForeColor = System.Drawing.SystemColors.ControlText;
        decimalPointButton.Location = new System.Drawing.Point(120, 237);
        decimalPointButton.Margin = new System.Windows.Forms.Padding(0);
        decimalPointButton.Name = "decimalPointButton";
        decimalPointButton.Size = new System.Drawing.Size(60, 82);
        decimalPointButton.TabIndex = 12;
        decimalPointButton.Text = ".";
        decimalPointButton.UseVisualStyleBackColor = true;
        decimalPointButton.Click += charInputButton_Click;
        // 
        // changeSignButton
        // 
        changeSignButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        changeSignButton.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        changeSignButton.ForeColor = System.Drawing.SystemColors.ControlDark;
        changeSignButton.Location = new System.Drawing.Point(180, 0);
        changeSignButton.Margin = new System.Windows.Forms.Padding(0);
        changeSignButton.Name = "changeSignButton";
        changeSignButton.Size = new System.Drawing.Size(60, 79);
        changeSignButton.TabIndex = 18;
        changeSignButton.Text = "+/-";
        changeSignButton.UseVisualStyleBackColor = true;
        changeSignButton.Click += changeSignButton_Click;
        // 
        // number8Button
        // 
        number8Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        number8Button.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        number8Button.ForeColor = System.Drawing.SystemColors.ControlText;
        number8Button.Location = new System.Drawing.Point(60, 0);
        number8Button.Margin = new System.Windows.Forms.Padding(0);
        number8Button.Name = "number8Button";
        number8Button.Size = new System.Drawing.Size(60, 79);
        number8Button.TabIndex = 10;
        number8Button.Text = "8";
        number8Button.UseVisualStyleBackColor = true;
        number8Button.Click += charInputButton_Click;
        // 
        // calculateButton
        // 
        calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        calculateButton.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        calculateButton.ForeColor = System.Drawing.Color.RoyalBlue;
        calculateButton.Location = new System.Drawing.Point(0, 158);
        calculateButton.Margin = new System.Windows.Forms.Padding(0);
        calculateButton.Name = "calculateButton";
        calculateButton.Size = new System.Drawing.Size(60, 161);
        calculateButton.TabIndex = 13;
        calculateButton.Text = "=";
        calculateButton.UseVisualStyleBackColor = true;
        calculateButton.Click += calculateButton_Click;
        // 
        // divisionButton
        // 
        divisionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        divisionButton.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        divisionButton.ForeColor = System.Drawing.Color.LightSkyBlue;
        divisionButton.Location = new System.Drawing.Point(0, 79);
        divisionButton.Margin = new System.Windows.Forms.Padding(0);
        divisionButton.Name = "divisionButton";
        divisionButton.Size = new System.Drawing.Size(60, 79);
        divisionButton.TabIndex = 14;
        divisionButton.Text = "÷";
        divisionButton.UseVisualStyleBackColor = true;
        divisionButton.Click += operationButton_Click;
        // 
        // deleteButton
        // 
        deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        deleteButton.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        deleteButton.ForeColor = System.Drawing.SystemColors.ControlDark;
        deleteButton.Location = new System.Drawing.Point(0, 0);
        deleteButton.Margin = new System.Windows.Forms.Padding(0);
        deleteButton.Name = "deleteButton";
        deleteButton.Size = new System.Drawing.Size(60, 79);
        deleteButton.TabIndex = 19;
        deleteButton.Text = "→";
        deleteButton.UseVisualStyleBackColor = true;
        deleteButton.Click += deleteButton_Click;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
        tableLayoutPanel2.Location = new System.Drawing.Point(12, 63);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.Size = new System.Drawing.Size(300, 319);
        tableLayoutPanel2.TabIndex = 2;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.Controls.Add(deleteButton, 0, 0);
        tableLayoutPanel3.Controls.Add(divisionButton, 0, 1);
        tableLayoutPanel3.Controls.Add(calculateButton, 0, 2);
        tableLayoutPanel3.Location = new System.Drawing.Point(240, 0);
        tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 3;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.Size = new System.Drawing.Size(60, 319);
        tableLayoutPanel3.TabIndex = 2;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(324, 394);
        Controls.Add(tableLayoutPanel2);
        Controls.Add(resultTextBox);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(700, 500);
        MinimumSize = new System.Drawing.Size(320, 400);
        ShowIcon = false;
        Text = "Калкулатор";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button deleteButton;
    private System.Windows.Forms.Button changeSignButton;
    private System.Windows.Forms.Button additionButton;
    private System.Windows.Forms.Button multiplicationButton;
    private System.Windows.Forms.Button subtractionButton;
    private System.Windows.Forms.Button divisionButton;
    private System.Windows.Forms.Button decimalPointButton;
    private System.Windows.Forms.Button calculateButton;
    private System.Windows.Forms.Button number2Button;
    private System.Windows.Forms.Button number3Button;
    private System.Windows.Forms.Button number0Button;
    private System.Windows.Forms.Button number4Button;
    private System.Windows.Forms.Button number5Button;
    private System.Windows.Forms.Button number6Button;
    private System.Windows.Forms.Button number7Button;
    private System.Windows.Forms.Button number8Button;
    private System.Windows.Forms.Button number9Button;
    private System.Windows.Forms.Button number1Button;
    private System.Windows.Forms.Button clearButton;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TextBox resultTextBox;

    #endregion
}
