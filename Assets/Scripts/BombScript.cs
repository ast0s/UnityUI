using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombScript : MonoBehaviour
{
    public void TurnRed() { Image bombImage = gameObject.GetComponent<Image>();  bombImage.color = Color.red; }
}
