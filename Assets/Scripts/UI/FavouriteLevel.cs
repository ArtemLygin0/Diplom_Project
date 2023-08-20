using UnityEngine;
using UnityEngine.UI;

public class FavouriteLevel : MonoBehaviour
{
    [SerializeField] private int _numberOfLevel;
    [SerializeField] private Image _image;
    [SerializeField] private Sprite favourite;
    [SerializeField] private Sprite unFavourite;

    public void FavourLevel()
    {
        if (_image.sprite == favourite)
            _image.sprite = unFavourite;
        else
            _image.sprite = favourite;
        Favourite._favouriteLevel[_numberOfLevel] = !Favourite._favouriteLevel[_numberOfLevel];
        Favourite.SaveFavourite();
    }
}