using UnityEngine;

public class ResultGame
{
    public int kolMonet = 0;
    public int level = 0;
}


public class Forest : MonoBehaviour
{
    protected Jobic myConfig = new Jobic();
    public ResultGame resulyGame = new ResultGame();

    public int getMyConfigA() {
        return myConfig.a;
    }

    public void setMyConfigA(int newA)
    {

        myConfig.a = newA;
    }

    public int getResulyGame()
    {
        return resulyGame.kolMonet;
    }

    public void setetResulyGameA(int newA)
    {

        resulyGame.kolMonet = newA;
    }




    //public int job1;
    //[SerializeField] protected int trap1;
    //[SerializeField] private int hello1;
}


