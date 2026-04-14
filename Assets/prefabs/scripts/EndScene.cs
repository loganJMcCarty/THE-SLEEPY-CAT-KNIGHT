using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class EndScene : MonoBehaviour
{
    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;
    public Image image5;
    public Image image6;
    public Image image7;
    public Image image8;
    public Image image9;
    public Image image10;
    public Image image11;
    //public Image image12;
    //--------------------------
    public Image imagetext1;
    public Image imagetext2;
    public Image imagetext3;
    public Image imagetext4;
    public Image imagetext5;
    public Image imagetext6;
    //public Image imagetext7;
    public Image imagetext8;
    public Image imagetext9;
    public Image imagetext10;
    //-----------------------------
    public TMP_Text text1;
    public TMP_Text text2;
    public TMP_Text text3;
    public TMP_Text text4;
    public TMP_Text text5;
    public TMP_Text text6;
    public TMP_Text text7;
    public TMP_Text text8;
    public TMP_Text text9;
    public TMP_Text text10;
   
    //-------------------------
    public GameObject NextText1;
    public GameObject NextText2;
    public GameObject NextText3;
    public GameObject NextText4;
    public GameObject NextText5;
    public GameObject NextText6;
    public GameObject NextText7;
    public GameObject NextText8;
    public GameObject NextText9;
    public GameObject NextText10;
    public GameObject TotheMenu;
    //----------------------------
    
    //----------------------------
    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void Nexttext1()
    {
        image2.gameObject.SetActive(true);
        image1.gameObject.SetActive(false);
        imagetext1.gameObject.SetActive(false);
        NextText2.gameObject.SetActive(true);
        NextText1.gameObject.SetActive(false);
        text1.gameObject.SetActive(false);
        
        
    }

    public void Nexttext2()
    {
        image3.gameObject.SetActive(true);
        image2.gameObject.SetActive(false);
        NextText3.gameObject.SetActive(true);
        NextText2.gameObject.SetActive(false);
        
        imagetext2.gameObject.SetActive(true);
        
        text2.gameObject.SetActive(true);
    }

    public void Nexttext3()
    {
        image4.gameObject.SetActive(true);
        image3.gameObject.SetActive(false);
        NextText4.gameObject.SetActive(true);
        NextText3.gameObject.SetActive(false);
        imagetext4.gameObject.SetActive(false);
        imagetext3.gameObject.SetActive(true);
        text2.gameObject.SetActive(false);
        text3.gameObject.SetActive(true);
    }

    public void Nexttext4()
    {
        image5.gameObject.SetActive(true);
        image4.gameObject.SetActive(false);
        NextText5.gameObject.SetActive(true);
        NextText4.gameObject.SetActive(false);
        imagetext5.gameObject.SetActive(false);
        imagetext4.gameObject.SetActive(true);
        text3.gameObject.SetActive(false);
        text4.gameObject.SetActive(true);
    }

    public void Nexttext5()
    {
        image6.gameObject.SetActive(true);
        image5.gameObject.SetActive(false);
        NextText6.gameObject.SetActive(true);
        NextText5.gameObject.SetActive(false);
        imagetext6.gameObject.SetActive(false);
        imagetext5.gameObject.SetActive(true);
        text4.gameObject.SetActive(false);
        text5.gameObject.SetActive(true);
    }

    public void Nexttext6()
    {
        image7.gameObject.SetActive(true);
        image6.gameObject.SetActive(false);
        NextText7.gameObject.SetActive(true);
        NextText6.gameObject.SetActive(false);
        imagetext5.gameObject.SetActive(false);
        imagetext6.gameObject.SetActive(true);
        text5.gameObject.SetActive(false);
        text6.gameObject.SetActive(true);
    }

    public void Nexttext7()
    {
        image8.gameObject.SetActive(true);
        image7.gameObject.SetActive(false);
        NextText8.gameObject.SetActive(true);
        NextText7.gameObject.SetActive(false);
        imagetext6.gameObject.SetActive(false);
        
        text6.gameObject.SetActive(false);
        
    }

    public void Nexttext8()
    {
        image9.gameObject.SetActive(true);
        image8.gameObject.SetActive(false);
        NextText8.gameObject.SetActive(true);
        NextText7.gameObject.SetActive(false);
        imagetext8.gameObject.SetActive(true);
        
        text8.gameObject.SetActive(true);
        
    }

    public void Nexttext9()
    {
        image10.gameObject.SetActive(true);
        image9.gameObject.SetActive(false);
        NextText9.gameObject.SetActive(true);
        NextText8.gameObject.SetActive(false);
        imagetext9.gameObject.SetActive(true);
        imagetext8.gameObject.SetActive(false);
        text9.gameObject.SetActive(true);
        text8.gameObject.SetActive(false);
    }

    public void Nexttext10()
    {
        image11.gameObject.SetActive(true);
        image10.gameObject.SetActive(false);
        NextText10.gameObject.SetActive(true);
        NextText9.gameObject.SetActive(false);
        imagetext10.gameObject.SetActive(true);
        imagetext9.gameObject.SetActive(false);
        text10.gameObject.SetActive(true);
        text9.gameObject.SetActive(false);
    }

    public void Tothemenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }
}
