using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ModCard : MonoBehaviour
{
    [SerializeField] private Image img;
    [SerializeField] private TextMeshProUGUI title;
    [SerializeField] private TextMeshProUGUI description;

    public void SetData(Mods mod)
    {
        title.text = mod.title;
        description.text = mod.description;
    }
}
