


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
    string[] SceneClick = new string[4];
    string[] Picture = new string[4];
    public string Pictures;




    public TextAsset jsonFile;
    public Image ImageMain;
    string ImageMainName;


    string currentScene = "s001e001";
    bool StoryOn = true;

    private string BackgroundsPath = "/_res/bg/";
    private string ScenePath = "/Episodes/";


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

        public string Picture0;
        public string Picture1;
        public string Picture2;
        public string Picture3;


    }
    void Start()
    {
        ButtonsLisening();
        newLevel();
    }


    void newLevel()
    {
        Init1();  //old name ButtonsTextSetiing();
        picturesMain();
    }


    void ButtonsLisening()
    {
        ButtonS[0].onClick.AddListener(TaskOnClick0);
        ButtonS[1].onClick.AddListener(TaskOnClick1);
        ButtonS[2].onClick.AddListener(TaskOnClick2);
        ButtonS[3].onClick.AddListener(TaskOnClick3);
    }

    public void Init1()
    {

        string jsonFile0 = Application.dataPath + ScenePath + currentScene + ".json";
        string textTMp = File.ReadAllText(jsonFile0);


        print(jsonFile0);

        SceneList List001 = JsonUtility.FromJson<SceneList>(textTMp);
        
        foreach (Scene e in List001.SceneQ)
        {
            TextButton[0].text = e.Button0;
            TextButton[1].text = e.Button1;
            TextButton[2].text = e.Button2;
            TextButton[3].text = e.Button3;

            Picture[0] = e.Picture0;
            Picture[1] = e.Picture1;
            Picture[2] = e.Picture2;
            Picture[3] = e.Picture3;

            SceneClick[0] = e.SceneClick0;
            SceneClick[1] = e.SceneClick1;
            SceneClick[2] = e.SceneClick2;
            SceneClick[3] = e.SceneClick3;

            Pictures = e.Pictures;
        }
    }





    void TaskOnClick0()
    {
         currentScene = SceneClick[0];
        StartCoroutine(TaskOnClick_100(0));
        Pictures = Picture[0];
        
        newLevel();
    }
    void TaskOnClick1()
    {
         currentScene = SceneClick[1];
        StartCoroutine(TaskOnClick_100(1));
        Pictures = Picture[1];
        newLevel();
    }

    void TaskOnClick2()
    {
         currentScene = SceneClick[2];
        StartCoroutine(TaskOnClick_100(2));
        Pictures = Picture[2];
        newLevel();
    }
    void TaskOnClick3()
    {
         currentScene = SceneClick[3];
        StartCoroutine(TaskOnClick_100(3));
        Pictures = Picture[3];
        newLevel();
    }


    IEnumerator TaskOnClick_100(int ButtonNumber)
    {
        string pathPics2 = Application.dataPath + BackgroundsPath + Picture[ButtonNumber];
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
                GameObject image = GameObject.Find("RawImage2");
                image.GetComponent<RawImage>().texture = texteures1;
            }
        }


    }



    IEnumerator picturesMain()
    {
        string pathPics2 = Application.dataPath + BackgroundsPath + Pictures;
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



