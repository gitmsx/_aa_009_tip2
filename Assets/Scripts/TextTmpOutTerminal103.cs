using System.Collections;

using UnityEngine;
using TMPro;


public class TextTmpOutTerminal103: MonoBehaviour
{

    [SerializeField] TextMeshProUGUI textOut;

    private Coroutine CourutineWork;
    public float SpeedText = 0.005f;
    public float SpeedText2 = 0.09f;



    int QueueAllStrings = 0;
    int CurrentElementQueueAllStrings = 0;

    string[] str = new string[12];

    [SerializeField] int ShowTipedStrings = 4;

    private void OnValidate()
    {
        textOut.text = "";
        textOut.text += "Переведено с английского языка.-Ползунок или полоса дорожки — это графический элемент управления, с помощью которого пользователь может установить значение, перемещая индикатор, обычно горизонтально. В некоторых случаях пользователь может также щелкнуть точку на ползунке, чтобы изменить настройку.";
        textOut.text += "2Переведено с английского языка.-Ползунок или полоса дорожки — это графический элемент управления, с помощью которого пользователь может установить значение, перемещая индикатор, обычно горизонтально. В некоторых случаях пользователь может также щелкнуть точку на ползунке, чтобы изменить настройку.";
        textOut.text += "3Переведено с английского языка.-Ползунок или полоса дорожки — это графический элемент управления, с помощью которого пользователь может установить значение, перемещая индикатор, обычно горизонтально. В некоторых случаях пользователь может также щелкнуть точку на ползунке, чтобы изменить настройку.";
        textOut.text += "4Переведено с английского языка.-Ползунок или полоса дорожки — это графический элемент управления, с помощью которого пользователь может установить значение, перемещая индикатор, обычно горизонтально. В некоторых случаях пользователь может также щелкнуть точку на ползунке, чтобы изменить настройку.";
        textOut.text += "5Переведено с английского языка.-Ползунок или полоса дорожки — это графический элемент управления, с помощью которого пользователь может установить значение, перемещая индикатор, обычно горизонтально. В некоторых случаях пользователь может также щелкнуть точку на ползунке, чтобы изменить настройку.";
        textOut.text += "6Переведено с английского языка.-Ползунок или полоса дорожки — это графический элемент управления, с помощью которого пользователь может установить значение, перемещая индикатор, обычно горизонтально. В некоторых случаях пользователь может также щелкнуть точку на ползунке, чтобы изменить настройку.";
    }

    // Start is called before the first frame update
    void Start()
    {
        textOut.text = "";










        
        str[0] = "Computer1<#800000>23science is the study12<#FFFF00>34 of computation,1123<#0000FF>45678 automation, and information.[1]<";
        str[1] = "\nМассив <#FFFF00> представляет набор <#800000>однотипных данных i <#FF00FF>and Computer <#7FFF00>science spans theoretical disciplines (such as algorithms, theory of computation, ";
        str[2] = "\nТе, 1<#00FF00>2кто просил больше информации3<#FF00FF>4 о хоббитах, в конце концов получили ее, но им пришлось ждать долго";
        str[3] = "\nсоздание <#FFD700>«Властелина Колец»<#FFFF00> заняло время с 1936 - го по 1949<#F4A460> год.В этот <#FFFF00>период у меня было множество обязанностей,String4 <#7FFF00>Srting4";

        str[4] = "\nС тех пор как <#800000>десять лет назад «Властелин Колец» был напечатан впервые, его прочитали многие; и мне хочется здесь выразить свое отношение ";
        str[5] = "\nкоторыми я <#00008B>не мог пренебречь, и мои собственные интересы <#00FFFF>в качестве преподавателя и <#C0C0C0>лектора <#800000>поглощали меня.";
        
        str[6] = "\nМассив <#FFFF00> представляет набор <#800000>однотипных данных i <#FF00FF>and Computer <#7FFF00>science spans theoretical disciplines (such as algorithms, theory of computation, ";
        str[7] = "\nТе, 1<#00FF00>2кто просил больше информации3<#FF00FF>4 о хоббитах, в конце концов получили ее, но им пришлось ждать долго";
        str[8] = "\nсоздание <#FFD700>«Властелина Колец»<#FFFF00> заняло время с 1936 - го по 1949<#F4A460> год.В этот <#FFFF00>период у меня было множество обязанностей,";

        str[9] = "\n1234<#00008B>С тех пор как <#800000>десять лет назад «Властелин Колец» был напечатан впервые, его прочитали многие; и мне хочется здесь выразить свое отношение ";
        str[10] = "";
        str[11] = "";

        //        str[6] = "Computer1<#800000>23science is the study12<#FFFF00>34 of computation,1123<#0000FF>45678 automation, and information.[1]<";
        //      str[7] = "\nМассив <#FFFF00> представляет набор <#800000>однотипных данных i <#FF00FF>and Computer <#7FFF00>science spans theoretical disciplines (such as algorithms, theory of computation, ";
        //     str[8] = "\nТе, 1<#00FF00>2кто просил больше информации3<#FF00FF>4 о хоббитах, в конце концов получили ее, но им пришлось ждать долго";

        CourutineWork = null;
        QueueAllStrings = str.Length;
        CurrentElementQueueAllStrings = 0;
        
      


        for (int i = 0; i < QueueAllStrings | i <= ShowTipedStrings; i++)

            CourutineWork = StartCoroutine(OutText1(i, str[i]));



      // if (QueueAllStrings > ShowTipedStrings)
        //    ;
       //     StartCoroutine(printline());


        // CourutineWork = StartCoroutine(printline());



        // StartCoroutine(printline());


    }






    IEnumerator OutText1(int i, string strT)
    {


        while (CurrentElementQueueAllStrings != i)
            yield return new WaitForSeconds(0.2f);
        
  
        char c;

        if (strT.Length==0) yield return null;

        for (int j = 0; j < strT.Length; j++)
        {
            c = strT[j];

            if ((strT[j] == '<') && (j + 1 < strT.Length) && strT[j + 1] == '#')
            {
                for (int k = j; k < j + 10; k++)
                    textOut.text += strT[k];
                j += 9;
            }
            else
            {
                textOut.text += c;
                    yield return new WaitForSeconds(SpeedText);
                }
        }
        CourutineWork = null;
        
        CurrentElementQueueAllStrings++;
        
        yield break;
    }



    IEnumerator Outtextline2()
    {

        while ((CurrentElementQueueAllStrings <= ShowTipedStrings))
        {
          //  print("CurrentElementQueueAllStrings " + CurrentElementQueueAllStrings.ToString());
            yield return new WaitForSeconds(0.7f);
        }
          //  print("####     CurrentElementQueueAllStrings " + CurrentElementQueueAllStrings.ToString());
            for (int i = ShowTipedStrings; i < str.Length; i++)
        {
            textOut.text += str[i];
            yield return new WaitForSeconds(SpeedText2);
        }

    }


}
