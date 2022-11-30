using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] GameObject schranke1;
    [SerializeField] GameObject schranke2;
    [SerializeField] GameObject player;

    public void Open1Click()
    {
        schranke1.SetActive(false);
    }

    public void Close1Click()
    {
        schranke1.SetActive(true);
    }

    public void Open2Click()
    {
        schranke2.SetActive(false);
    }

    public void Close2Click()
    {
        schranke2.SetActive(true);
    }

    public void MoveClick()
    {
        if (schranke1.activeSelf == false && schranke2.activeSelf == false)
        {
            player.transform.position = new Vector3(550f, 240f, 0f);
            
        }
    }

    public void MoveBackClick()
    {
        if (schranke1.activeSelf == false && schranke2.activeSelf == false)
        {
            player.transform.position = new Vector3(100f, 240f, 0f);

        }
    }

}