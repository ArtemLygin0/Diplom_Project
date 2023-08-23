using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // ����� �������� ������������, �������� Rendering mode �� ���������
    // Transparent - � �������, Fade - ���!!!
    private Color color;
    /*
    private void OnMouseDrag()  // ����� � ���������� ���������� ������ ����
    { 
        GetComponent<Renderer>().material.color = Color.gray;
    }
    
    private void OnMouseEnter() //���������� ��� ��������� ���� �� ���������
    {
        GetComponent<Renderer>().material.color = Color.black;    
    }
        
    private void OnMouseExit()  // ����� � ����� �� ����������
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }

    private void OnMouseUp()    // ���� ��������
    {
        GetComponent<Renderer>().material.color = Color.magenta;
    }
    */
    private void OnMouseOver()  // ����� ���� �� ����������
    {
        GetComponent<Renderer>().material.color = Color.green;
    }
    
            
    private void OnMouseUpAsButton()    // ���������� ���� �������� �� ��� �� ������� ��� � ��������
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }
    
    //неиспользуемый код удалять, не комментировать
    private void OnMouseDown()  // ���� ��������
    {
        // ����� ������� ���� ENUM
        //GetComponent<Renderer>().material.color = Color.gray;

        // ����� ������ ���� � ����� ��������� RGB, ����� ���������� � ���������
        //GetComponent<Renderer>().material.color = new Color(1, 0.498f, 0.3137f, 0.1f);

        // ��������� ����� ����� ����������������� ���, �� ��� �����
        if (ColorUtility.TryParseHtmlString("#257435", out color))
        { GetComponent<Renderer>().material.color = color; }
    }
}