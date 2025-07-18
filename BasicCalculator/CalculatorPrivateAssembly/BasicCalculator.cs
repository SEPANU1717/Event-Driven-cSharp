namespace CalculatorPrivateAssembly;

public static class BasicCalculator
{
    public static float Addition(float a, float b) => a + b;
    public static float Subtraction(float a, float b) => a - b;
    public static float Multiplication(float a, float b) => a * b;
    public static float Division(float a, float b) => b != 0 ? a / b : 
        throw new DivideByZeroException("Cannot divide by zero sorry.");
}