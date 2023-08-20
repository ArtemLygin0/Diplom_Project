using UnityEngine;
// Settings
public class Favourite : MonoBehaviour
{
    public static bool[] _favouriteLevel = new bool[100];

    private void Start()
    {
        LoadFavourite();
    }

    public static void SaveFavourite()
    {
        string data = "";
        for (int i = 0; i < _favouriteLevel.Length; i++)
        {
            data += _favouriteLevel[i] ? "1" : "0";
        }
        PlayerPrefs.SetString("FavouriteLevels", data);
    }

    public void LoadFavourite()
    {
        string data = PlayerPrefs.GetString("FavouriteLevels", "");
        for (int i = 0; i < data.Length; i++)
        {
            _favouriteLevel[i] = data[i] == '1';
        }
    }
}
