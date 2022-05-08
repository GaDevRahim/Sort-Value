using UnityEngine;
using TMPro;

namespace SortList
{
    public class ControlField : MonoBehaviour
    {
        private string value;
        private TMP_InputField fieldText;

        private void Start()
        {
            fieldText = GetComponent<TMP_InputField>();
        }

        public string GetValue()
        {
            value = fieldText.text.ToString();
            return value;
        }
    }
}
