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
        textOut.text += "���������� � ����������� �����.-�������� ��� ������ ������� � ��� ����������� ������� ����������, � ������� �������� ������������ ����� ���������� ��������, ��������� ���������, ������ �������������. � ��������� ������� ������������ ����� ����� �������� ����� �� ��������, ����� �������� ���������.";
        textOut.text += "2���������� � ����������� �����.-�������� ��� ������ ������� � ��� ����������� ������� ����������, � ������� �������� ������������ ����� ���������� ��������, ��������� ���������, ������ �������������. � ��������� ������� ������������ ����� ����� �������� ����� �� ��������, ����� �������� ���������.";
        textOut.text += "3���������� � ����������� �����.-�������� ��� ������ ������� � ��� ����������� ������� ����������, � ������� �������� ������������ ����� ���������� ��������, ��������� ���������, ������ �������������. � ��������� ������� ������������ ����� ����� �������� ����� �� ��������, ����� �������� ���������.";
        textOut.text += "4���������� � ����������� �����.-�������� ��� ������ ������� � ��� ����������� ������� ����������, � ������� �������� ������������ ����� ���������� ��������, ��������� ���������, ������ �������������. � ��������� ������� ������������ ����� ����� �������� ����� �� ��������, ����� �������� ���������.";
        textOut.text += "5���������� � ����������� �����.-�������� ��� ������ ������� � ��� ����������� ������� ����������, � ������� �������� ������������ ����� ���������� ��������, ��������� ���������, ������ �������������. � ��������� ������� ������������ ����� ����� �������� ����� �� ��������, ����� �������� ���������.";
        textOut.text += "6���������� � ����������� �����.-�������� ��� ������ ������� � ��� ����������� ������� ����������, � ������� �������� ������������ ����� ���������� ��������, ��������� ���������, ������ �������������. � ��������� ������� ������������ ����� ����� �������� ����� �� ��������, ����� �������� ���������.";
    }

    // Start is called before the first frame update
    void Start()
    {
        textOut.text = "";










        
        str[0] = "Computer1<#800000>23science is the study12<#FFFF00>34 of computation,1123<#0000FF>45678 automation, and information.[1]<";
        str[1] = "\n������ <#FFFF00> ������������ ����� <#800000>���������� ������ i <#FF00FF>and Computer <#7FFF00>science spans theoretical disciplines (such as algorithms, theory of computation, ";
        str[2] = "\n��, 1<#00FF00>2��� ������ ������ ����������3<#FF00FF>4 � ��������, � ����� ������ �������� ��, �� �� �������� ����� �����";
        str[3] = "\n�������� <#FFD700>����������� ������<#FFFF00> ������ ����� � 1936 - �� �� 1949<#F4A460> ���.� ���� <#FFFF00>������ � ���� ���� ��������� ������������,String4 <#7FFF00>Srting4";

        str[4] = "\n� ��� ��� ��� <#800000>������ ��� ����� ���������� ������ ��� ��������� �������, ��� ��������� ������; � ��� ������� ����� �������� ���� ��������� ";
        str[5] = "\n�������� � <#00008B>�� ��� ����������, � ��� ����������� �������� <#00FFFF>� �������� ������������� � <#C0C0C0>������� <#800000>��������� ����.";
        
        str[6] = "\n������ <#FFFF00> ������������ ����� <#800000>���������� ������ i <#FF00FF>and Computer <#7FFF00>science spans theoretical disciplines (such as algorithms, theory of computation, ";
        str[7] = "\n��, 1<#00FF00>2��� ������ ������ ����������3<#FF00FF>4 � ��������, � ����� ������ �������� ��, �� �� �������� ����� �����";
        str[8] = "\n�������� <#FFD700>����������� ������<#FFFF00> ������ ����� � 1936 - �� �� 1949<#F4A460> ���.� ���� <#FFFF00>������ � ���� ���� ��������� ������������,";

        str[9] = "\n1234<#00008B>� ��� ��� ��� <#800000>������ ��� ����� ���������� ������ ��� ��������� �������, ��� ��������� ������; � ��� ������� ����� �������� ���� ��������� ";
        str[10] = "";
        str[11] = "";

        //        str[6] = "Computer1<#800000>23science is the study12<#FFFF00>34 of computation,1123<#0000FF>45678 automation, and information.[1]<";
        //      str[7] = "\n������ <#FFFF00> ������������ ����� <#800000>���������� ������ i <#FF00FF>and Computer <#7FFF00>science spans theoretical disciplines (such as algorithms, theory of computation, ";
        //     str[8] = "\n��, 1<#00FF00>2��� ������ ������ ����������3<#FF00FF>4 � ��������, � ����� ������ �������� ��, �� �� �������� ����� �����";

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
