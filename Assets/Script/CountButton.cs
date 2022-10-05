using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountButton : MonoBehaviour
{
    public static CountButton Instance;

    [SerializeField]
    GameObject[] _cube;

    public static int _count;

}
