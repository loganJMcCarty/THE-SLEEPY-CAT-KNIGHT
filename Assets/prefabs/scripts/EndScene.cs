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

    //-----------------------------
    public TMP_Text text1;
    public TMP_Text text2;
    public TMP_Text text3;
    public TMP_Text text4;
    public TMP_Text text5;
    public TMP_Text text6;
    //public TMP_Text text7;
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

}
