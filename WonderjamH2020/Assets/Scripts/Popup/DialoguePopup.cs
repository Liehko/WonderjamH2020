﻿using Interactive.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Popup
{
    public class DialoguePopup : Popup 
    {
        [SerializeField]
        private TMPro.TextMeshProUGUI text;

        public void SetText(string message)
        {
            text.text = message;
        }

        public IEnumerator PopupDeactivation(float delay, float time, string message)
        {
            
            yield return new WaitForSeconds(delay);
            Display();
            text.text = message;

            yield return new WaitForSeconds(time);
            this.Hide();
        }
    }
}
