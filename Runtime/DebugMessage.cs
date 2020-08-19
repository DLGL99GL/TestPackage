using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DebugMessage
{
    public class DebugMessage : MonoBehaviour
    {
        /// <summary>
        /// 打印信息
        /// </summary>
        /// <param name="message">需要打印的字符</param>
        public void Debug(string message)
        {
            UnityEngine.Debug.Log("这是第一个版本的打印，打印的字符为：  " + message);
        }
    }
}

