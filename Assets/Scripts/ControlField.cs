using UnityEngine;
using TMPro;
using System.Text;

namespace SortList
{
    public class ControlField : MonoBehaviour
    {
        private float value;
        private TMP_InputField fieldText;
        

        private void Start()
        {
            fieldText = GetComponent<TMP_InputField>();
        }

        public float GetValue()
        {
            value = float.Parse(fieldText.text.ToString());
            return value;
        }
    }
}
