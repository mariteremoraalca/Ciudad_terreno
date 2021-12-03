using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WavesUI : MonoBehaviour
{
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        WavesManager.instance.onChanged.AddListener(RefreshText);
    }

    // Update is called once per frame
private void RefreshText()
    {
        text.text = "Olas Remanentes" + WavesManager.instance.waves.Count;
    }
}
