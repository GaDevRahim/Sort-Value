using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

namespace SortList
{
    public class GameManager : MonoBehaviour
    {
        [Header("Input Fields"), SerializeField] private GameObject control_InputFields;
        [SerializeField] private ControlField[] inp_Field;

        [Header("Sort Button"), SerializeField] private Button sortButton;
        [SerializeField] private TextMeshProUGUI textButton;

        [Header("Input Fields"), SerializeField] private GameObject control_TextList;
        [SerializeField] private TextMeshProUGUI[] text_List;

        private float[] value_List;

        private void Start()
        {
            SetComponent();
            sortButton.onClick.AddListener(ButtonClicked);
        }

        private void SetComponent()
        {
            value_List = new float[6];
            sortButton = sortButton.gameObject.GetComponent<Button>();
            textButton = textButton.gameObject.GetComponent<TextMeshProUGUI>();

            for (int i = 0; i < inp_Field.Length; i++)
            {
                inp_Field[i] = inp_Field[i].gameObject.GetComponent<ControlField>();
                text_List[i] = text_List[i].gameObject.GetComponent<TextMeshProUGUI>();
            }
        }

        private bool IsAllFull()
        {
            bool all = true;

            for (int i = 0; i < value_List.Length; i++)
            {
                value_List[i] = inp_Field[i].GetValue();

                if (value_List[i].ToString() == "")
                    all = false;
            }
            return all;
        }

        public void ShowList()
        {
            if (IsAllFull())
            {
                Array.Sort(value_List);
                for (int i = 0; i < value_List.Length; i++)
                    text_List[i].text = value_List[i].ToString();
                ChangeGUI();
            }
            else
            {
                textButton.text = "Full All Than Press";
            }
        }

        private void ButtonClicked()
        {
            Debug.Log("Clicked");
            ShowList();
               
        }

        private void ChangeGUI()
        {
            sortButton.gameObject.SetActive(false);
            control_InputFields.gameObject.SetActive(false);
            control_TextList.gameObject.SetActive(true);
        }
    }
}



