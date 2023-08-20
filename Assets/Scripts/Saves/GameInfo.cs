public class GameInfo
{
    public static bool[,] savedCoins = new bool[100, 3];        // Монетки собранные на всех уровнях (1,2,3)  Уровень/монета //+++
    public static float[] savedTimeRecord = new float[100];   // Рекордное время на всех уровнях                           //+++   Отрбросить часть 2 числа
    public static bool[] completeLVL = new bool[100];         // Пройденные уровни                                         //+++
}