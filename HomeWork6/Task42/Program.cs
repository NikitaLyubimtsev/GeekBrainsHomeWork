// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

using static System.Console;
Clear();

LinePoint one = AskToUserLinePoint("первой");
LinePoint two = AskToUserLinePoint("второй");
Write(SeekCrossLinePoint(one, two));


LinePoint AskToUserLinePoint(string line)
{
    LinePoint res = new LinePoint();
    Write("Введите через пробел параметры " + line + " линии, сначала b, затем k: ");
    string[] inputParamArray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if (
        double.TryParse(inputParamArray[0],out double b)
        & double.TryParse(inputParamArray[1],out double k)
        )
        {
            res.b = b;
            res.k = k;
        }
    return res;
}

string SeekCrossLinePoint(LinePoint one, LinePoint two)
{
    if (one.k == two.k) {
            return "Линии параллельны!";
    } else {
        string crossLinePoint = "";
        double x = (one.b - two.b) / (two.k - one.k);
        double y = one.k * x + one.b;
        crossLinePoint = "(" + Convert.ToString(Math.Round(x, 1)) + ";" + Convert.ToString(Math.Round(y, 1)) + ")";
        return crossLinePoint;
    }
}

struct LinePoint
{
    public double b;
    public double k;
}