using System;
using System.ComponentModel.DataAnnotations;

public class CedulaAttribute : ValidationAttribute
{
    public string LengthErrorMessage { get; set; }
    public new string FormatErrorMessage { get; set; }
    public string ValidErrorMessage { get; set; }

    public CedulaAttribute() {
        ErrorMessage = ValidErrorMessage;
    }

    public override bool IsValid(object value)
    {
        string cedula = (string) value;

        if (cedula.Length != 11) {
            ErrorMessage = LengthErrorMessage;
            return false;
        }

        try {
            int digitoVerificador = Convert.ToInt32(cedula.Substring(10, 1));
            int verificador = 0;
            int digito = 0;
            int digitoImpar = 0;
            int sumaPar = 0;
            int sumaImpar = 0;

            for (int i = 9; i >= 0; i--) {
                digito = Convert.ToInt32(cedula.Substring(i, 1));
                if ((i % 2) != 0) {
                    digitoImpar = digito * 2;
                    if (digitoImpar >= 10) digitoImpar = digitoImpar - 9;
                    sumaImpar = sumaImpar + digitoImpar;
                }
                else sumaPar = sumaPar + digito;
            }

            verificador = 10 - ((sumaPar + sumaImpar) % 10);

            if (((verificador == 10) && (digitoVerificador == 0)) || (verificador == digitoVerificador)) {
                return true;
            } else {
                ErrorMessage = ValidErrorMessage;
                return false;
            }

        }
        catch (FormatException) {
            ErrorMessage = FormatErrorMessage;
            return false;
        }

    }
}

public class DateTimeGreaterThan : ValidationAttribute
{
    private string DateTime;

    public DateTimeGreaterThan(string dateTime) {
        this.DateTime = dateTime;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        try {
            DateTime thisDateTime = Convert.ToDateTime(value);
            DateTime otherDateTime = Convert.ToDateTime(
                validationContext.ObjectType.GetProperty(DateTime)
                    .GetValue(validationContext.ObjectInstance, null));

            if (thisDateTime > otherDateTime) return ValidationResult.Success;
        }
        catch {}

        return new ValidationResult(
            ErrorMessage ??
            $"the {validationContext.MemberName} field is smaller or equal to the {this.DateTime} field."
        );
    }
}
