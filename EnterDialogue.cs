using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterDialogue : MonoBehaviour
{
    public GameObject Dialog1;
    public GameObject Dialog2;
    public GameObject Dialog3;
    

    void OpenDialog()
    {
        Dialog1.gameObject.SetActive(true);
    }

    void ContinueDialog()
    {
        Dialog1.gameObject.SetActive(false);
        Dialog2.gameObject.SetActive(true);
        if (Dialog2.gameObject.activeSelf)
        {
            Dialog2.gameObject.SetActive(false);
            Dialog3.gameObject.SetActive(true);
        }
    }

    void CloseDialog()
    {
        Dialog1.gameObject.SetActive(false);
        Dialog2.gameObject.SetActive(false);
        Dialog3.gameObject.SetActive(false);

    }
}
