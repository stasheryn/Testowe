using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Plugins.Dropbox;
using UnityEngine;

public class ActualMods : MonoBehaviour
{
    [SerializeField] private ModCard _modCard;
    [SerializeField] private Transform parentTransform;
    public void GenerateMods(string json)
    {
        var content = JsonConvert.DeserializeObject<ModsList>(json);
        var mods = content.mods;
        var categories = content.categories;
        for (int i = 0; i < mods.Count; i++)
        {
            var card = Instantiate(_modCard, parentTransform);
            card.SetData(mods[i]);
        }
    }

    private void Start()
    {
        DropboxHelper.DownloadCompleted += GenerateMods;
    }
}
