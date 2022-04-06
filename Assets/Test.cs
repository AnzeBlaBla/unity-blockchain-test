using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// use web3.jslib
using System.Runtime.InteropServices;
public class Test : MonoBehaviour
{
    // text in the button
    public Text walletText;
    // use WalletAddress function from web3.jslib
    [DllImport("__Internal")] private static extern string WalletAddress();
    [DllImport("__Internal")] private static extern string CallFunc();

    public void DisplayAddress()
    {
        Debug.Log("setting wallet address");

        // get wallet address and display it on the button
        walletText.text = WalletAddress();
    }


    public void CallJSFunc()
    {
        Debug.Log("calling js function");
        CallFunc();
    }

}
