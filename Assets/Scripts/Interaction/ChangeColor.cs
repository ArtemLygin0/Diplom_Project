using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Чтобы изменить Прозрачность, изменить Rendering mode на материале
    // Transparent - с бликами, Fade - без!!!
    private Color color;
    /*
    private void OnMouseDrag()  // Нажал и продолжает удерживать кнопку мыши
    { 
        GetComponent<Renderer>().material.color = Color.gray;
    }
    
    private void OnMouseEnter() //Вызывается при наведении мыши на коллайдер
    {
        GetComponent<Renderer>().material.color = Color.black;    
    }
        
    private void OnMouseExit()  // Когда и вышла из коллайдера
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }

    private void OnMouseUp()    // Мышь отжалась
    {
        GetComponent<Renderer>().material.color = Color.magenta;
    }
    */
    private void OnMouseOver()  // Когда мышь на коллайдере
    {
        GetComponent<Renderer>().material.color = Color.green;
    }
    
            
    private void OnMouseUpAsButton()    // Вызывается если отжалась на том же объекте что и нажалась
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }
    
    private void OnMouseDown()  // Мышь нажалась
    {
        // Можно выбрать цвет ENUM
        //GetComponent<Renderer>().material.color = Color.gray;

        // Чтобы узнать цвет в юнити поставить RGB, потом посмотреть в процентах
        //GetComponent<Renderer>().material.color = new Color(1, 0.498f, 0.3137f, 0.1f);

        // Изменение цвета через Шестнадцетеричный код, но без альфы
        if (ColorUtility.TryParseHtmlString("#257435", out color))
        { GetComponent<Renderer>().material.color = color; }
    }
}