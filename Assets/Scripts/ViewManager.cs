using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
public class ViewManager : MonoBehaviour
{
    [SerializeField] GameObject buttonPrefab;

    [HideInInspector] public ButtonManager leftNavigationViewButton;
    [HideInInspector] public MainManager mainManager;
}

