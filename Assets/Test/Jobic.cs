public class Jobic
{
    public int a = 5;
    protected int b = 8;
    private int c = 10;

    public int C { get => c; set => c = value; }

    public int GetS(int ccc) => ccc;

    public void SetS(int ccc) => c = ccc;

}