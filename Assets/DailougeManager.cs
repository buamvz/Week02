using NUnit.Framework;
using TMPro;
using System.Collections.Generic;
using UnityEngine;

public class DailougeManager : MonoBehaviour
{
    [SerializeField] int dialougeIndex;
    [SerializeField] TextMeshProUGUI dialougeText;
    [TextArea]
    [SerializeField] List<string> dialouge;

    private void Start()
    {
        dialougeText.text = dialouge[dialougeIndex];
    }

    public void NextDialouge()
    {
        dialougeIndex += 1;
        if (dialougeIndex >= dialouge.Count)
        {
            Debug.Log("No more diakouge");
        }

        dialougeText.text = dialouge[dialougeIndex];
    }


}
