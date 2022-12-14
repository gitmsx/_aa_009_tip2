


using System.Collections;
using System.IO;

using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class GameStart : MonoBehaviour
{
    [SerializeField]  TextMeshProUGUI[] TextButton = new TextMeshProUGUI[4];
    [SerializeField] Button[] ButtonS = new Button[4];
    
    public TextAsset jsonFile;
    public Image ImageMain;
    string ImageMain1;


    string currentScene = "s001e001";
    bool StoryOn = true;

    private string BackgroundsPath = "/_res/bg/";
    private string ScenePath = "/scenes/";


    [SerializeField] public RawImage RawImage2;

    

    [System.Serializable]
    public class Scene
    {
        public string Button0;
        public string Button1;
        public string Button2;
        public string Button3;
        

        public string SceneClick0; 
        public string SceneClick1;
        public string SceneClick2;
        public string SceneClick3;

        public string Points0;
        public string Points1;
        public string Points2;
        public string Points3;

        public string Pictures;
        

    }
    void Start()
    {
        ButtonsTextSetiing();
        ButtonsLisening();


         while (StoryOn)
            {
                ButtonsTextSetiing();

            }


    }



    void ButtonsLisening()
    {
        ButtonS[0].onClick.AddListener(TaskOnClick0);
        ButtonS[1].onClick.AddListener(TaskOnClick1);
        ButtonS[2].onClick.AddListener(TaskOnClick2);
        ButtonS[3].onClick.AddListener(TaskOnClick3);
    }

    public void ButtonsTextSetiing()
    {

        string jsonFile0 = Application.dataPath + ScenePath + currentScene+".json";
        string textTMp = File.ReadAllText(jsonFile0);
        print(jsonFile0);
        print(textTMp);
        

        SceneList List001 = JsonUtility.FromJson<SceneList>(textTMp);
        
        foreach (Scene e in List001.SceneQ)
        {
            TextButton[0].text = e.Button0;
            TextButton[1].text = e.Button1;
            TextButton[2].text = e.Button2;
            TextButton[3].text = e.Button3;
            ImageMain1 = e.Pictures;
            print(ImageMain1);
        }


    }





    void TaskOnClick0()
    {
        StartCoroutine(TaskOnClick_100("osen72.png"));
    }
    void TaskOnClick1()
    {
        StartCoroutine(TaskOnClick_100("osen71.png"));
    }

    void TaskOnClick2()
    {
        StartCoroutine(TaskOnClick_100("osen73.png"));
    }
    void TaskOnClick3()
    {
        StartCoroutine(TaskOnClick_100("osen74.png"));
    }

 
    IEnumerator TaskOnClick_100(string filetexture)
    {
        string pathPics2 = Application.dataPath + BackgroundsPath + filetexture;

        using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture(pathPics2))
        {
            yield return uwr.SendWebRequest();

            if (uwr.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(uwr.error);
            }
            else
            {
                // Get downloaded asset bundle
                var texteures1 = DownloadHandlerTexture.GetContent(uwr);
                GameObject image = GameObject.Find("RawImage");
                image.GetComponent<RawImage>().texture = texteures1;

            }
        }


    }


    
    void TaskWithParameters(string message)
    {
        //Output this to console when the Button2 is clicked
        Debug.Log(message);
        

    }


  
  






    public class SceneList
    {
        public Scene[] SceneQ;

    }

    void ButtonClicked(int buttonNo)
    {
        string path = "Assets/Resources/s001e001.json";
        if (FileExists(path))
        {
       //     loadjsonlist101(path);
        }
    }


    bool FileExists(string FileName)
    {
        if (FileName == null || FileName.Length == 0)
            return false;
        FileInfo fInfo = new FileInfo(FileName);

        if (!fInfo.Exists)
            return false;
        return true;
    }
}



