using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
public class recog : MonoBehaviour
{
    public ConfidenceLevel Confidence = ConfidenceLevel.Low;
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> keywords = new Dictionary<string, Action>();
    int n=1;
    void Start()
    {
        
        keywords.Add("hamdoulah", hamdoulah);
        keywords.Add("tbarklah", tbarklh);
        keywords.Add("sobhanalah", sobhanalah);

        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray(), Confidence);
        keywordRecognizer.OnPhraseRecognized += Recognizeed;
        keywordRecognizer.Start();
    }
        private void Recognizeed(PhraseRecognizedEventArgs speech)
        {


            if ((n == 1) && keywords[speech.text] == hamdoulah)
            {
                Debug.Log("9oul hamdoulah");
                keywords["hamdoulah"].Invoke();
            }
            else if ((n == 3) && keywords[speech.text] == sobhanalah)
            {
                keywords["sobhanalah"].Invoke();
            }
            else if ((n == 2) && keywords[speech.text] == tbarklh)
            {
                keywords["hamdoulah"].Invoke();
            }
        }
        private void hamdoulah()
        {
            Debug.Log("hamdoulah");
            //k = 1;
        }
        private void tbarklh()
        {

            Debug.Log("tbarklh");
            //k = 1;
        }
        private void sobhanalah()
        {
            Debug.Log("sobhanalah");
            //k = 1;
        }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
