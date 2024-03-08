
    using UnityEngine;
    using System.IO;
using UnityEngine.UIElements;
using System.Collections;
using System.Security.Policy;
using System;

public class ReadPythonOutput : MonoBehaviour


{
    string dataprev;
    public AudioSource source;
    public GameObject insituUI;
    public GameObject insituUIText;
    public GameObject egoUI;
    public GameObject egoUIText;
    public int condition;
    public string WOZdata;
    void Start()
    {
        dataprev = "placeholder";
        InvokeRepeating("ReadString", 1f, 1f);  //1s delay, repeat every 1s
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (condition == 3)
            {
                egoUI.SetActive(true);
                egoUIText.transform.GetComponent<TMPro.TextMeshProUGUI>().text = "";

                egoUIText.transform.GetComponent<TMPro.TextMeshProUGUI>().text = WOZdata;
                StartCoroutine(HideUI(5));
            }
            else if (condition == 4)
            {
                string path = "";

                switch (WOZdata) { 
                    case "walnuts sauce":
                        path = "C:\\Users\\hcist\\ArduinoTests\\Assets\\Resources\\audio\\walnutssauce.mp3";
                        break;
                    case "cuttlefish":
                        path = "C:\\Users\\hcist\\ArduinoTests\\Assets\\Resources\\audio\\cuttlefish.mp3";
                        Debug.Log("loading condition: " + path);

                        break;
                    case "anchovies":
                        path = "C:\\Users\\hcist\\ArduinoTests\\Assets\\Resources\\audio\\anchovies.mp3";
                        break;
                    case "rabbit":
                        path = "C:\\Users\\hcist\\ArduinoTests\\Assets\\Resources\\audio\\rabbit.mp3";
                        break;
                    case "fish":
                        path = "C:\\Users\\hcist\\ArduinoTests\\Assets\\Resources\\audio\\fish.mp3";
                        break;
                    case "clams":
                        path = "C:\\Users\\hcist\\ArduinoTests\\Assets\\Resources\\audio\\clams.mp3";
                        break;
                    default:
                    break;
                }
                LoadSongWOZ(path);
            }
        } 
    }

    /*  public static void WriteString()

      {

          string path = "C:\\Users\\hcist\\Downloads\\recognized.txt";

          //Write some text to the test.txt file

          StreamWriter writer = new StreamWriter(path, true);

          writer.WriteLine("Test");

           writer.Close();

          StreamReader reader = new StreamReader(path);

          //Print the text from the file

          Debug.Log(reader.ReadToEnd());

          reader.Close();

       }
*/
    public void ReadString()

    {

        string path = "C:\\Users\\hcist\\flo\\translated.txt";

        //Read the text from directly from the test.txt file

        StreamReader reader = new StreamReader(path);
        string data = reader.ReadToEnd();
        Debug.Log(data);

        reader.Close();

        // GameObject output = GameObject.Find("RenderingMRInSitu");


        data = data.Replace("\n", "");
        // if (output.transform.GetComponent<TMPro.TextMeshProUGUI>().text != data)
        //  {
        //    output.transform.GetComponent<TMPro.TextMeshProUGUI>().text = data;
        //   StartCoroutine(HideUI(5));
        //  }
        if (condition == 0)
        {
            if (insituUIText.transform.GetComponent<TMPro.TextMeshProUGUI>().text != data)
            {
                insituUI.SetActive(true);
                insituUIText.transform.GetComponent<TMPro.TextMeshProUGUI>().text = "";

                insituUIText.transform.GetComponent<TMPro.TextMeshProUGUI>().text = data;
                insituUI.transform.position = GameObject.Find("SphereSurface").transform.GetComponent<CollisionSurface>().getInSituPosition();
                StartCoroutine(HideUI(5));

            }
        }
        else if (condition == 1)
        {
            if (egoUIText.transform.GetComponent<TMPro.TextMeshProUGUI>().text != data)
            {
                egoUI.SetActive(true);
                egoUIText.transform.GetComponent<TMPro.TextMeshProUGUI>().text = "";

                egoUIText.transform.GetComponent<TMPro.TextMeshProUGUI>().text = data;
                StartCoroutine(HideUI(5));

            }
        }
        else if (condition == 2)
        {

            if (dataprev != data)
            {
                dataprev = data;
                //AudioSource audio = gameObject.AddComponent<AudioSource>();
                //audio.PlayOneShot((AudioClip)Resources.Load("audio/audio"));
                LoadSong();
            }
        }

        

    }

    public void LoadSong()
    {
        StartCoroutine(LoadSongCoroutine());

    }
    public void LoadSongWOZ(string path)
    {
        StartCoroutine(LoadSongCoroutineWOZ(path));

    }

    IEnumerator LoadSongCoroutine()
    {
        string path = "C:\\Users\\hcist\\ArduinoTests\\Assets\\Resources\\audio\\audio.mp3";
        string url = string.Format("file://{0}", path);
        WWW www = new WWW(url);
        yield return www;

        source.clip = www.GetAudioClip(false, false);
        source.Play(0);

    }

    IEnumerator LoadSongCoroutineWOZ(string path)
    {
        string url = string.Format("file://{0}", path);
        Debug.Log("loading URL: " + url);
        WWW www = new WWW(url);
        yield return www;

        source.clip = www.GetAudioClip(false, false);
        source.Play(0);

    }

    IEnumerator HideUI(float duration)
    {
        // do something before
      
            // waits here
            yield return new WaitForSeconds(duration);

            // do something after
           egoUI.SetActive(false);
            insituUI.SetActive(false);


        }

    }


