using System;
using Plugins.Dropbox;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadBarFunc : MonoBehaviour
{
    public TextMeshProUGUI textMeshUGUI;
    public Slider slider;
    public GameObject loadScreen;

    private void Start()
    {
        textMeshUGUI.text = "Starting download data";
        slider.value += 1;
        GetData1();
    }

    public async void GetData1()
    {
        string filename0 = "data1.json";
        string filename1 = "data2.json";
        string filename2 = "data3.json";
        string filename3 = "mods.json";
        // string filename4 = "mods/";
        await DropboxHelper.Initialize();
        textMeshUGUI.text = "Initialization";
        slider.value += 1;
        
        textMeshUGUI.text = "Loading " + "data1.json" + " ...";
        await DropboxHelper.DownloadAndSaveFile(filename0);
        
        slider.value += 1;
        textMeshUGUI.text = "Loading " + "data2.json" + " ...";
        await DropboxHelper.DownloadAndSaveFile(filename1);

        slider.value += 1;
        textMeshUGUI.text = "Loading " + "data3.json" + " ...";
        await DropboxHelper.DownloadAndSaveFile(filename2);

        slider.value += 1;
        // await DropboxHelper.DownloadAndSaveFile(filename4);
        textMeshUGUI.text = "Loading " + "mods.json" + " ...";
        await DropboxHelper.DownloadAndSaveFile(filename3);
        slider.value += 1;
        await DropboxHelper.ReadFileFrmDropbox(filename3);
        slider.value += 1;

        loadScreen.SetActive(false);
    }
}