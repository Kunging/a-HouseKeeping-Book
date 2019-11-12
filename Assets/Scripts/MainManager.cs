using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    //// Present한 ViewManager들
    //Stack<ViewManager> viewManagers = new Stack<ViewManager>();
    //public void PresentViewManager(ViewManager viewManager, bool isAnimated = false)
    //{
    //    if (viewManagers.Count > 0)
    //    {
    //        viewManager.Open(true);
    //    }
    //    // ViewManager에게 MainManager 할당
    //    viewManager.mainManager = this;

    //    navigationView.Title = viewManager.title;

    //    // 왼쪽 Navigation button 표시
    //    if (viewManager.leftNavigationViewButton)
    //    {
    //        viewManager.leftNavigationViewButton.transform.SetParent(navigationView.LeftButtonArea);
    //        viewManager.leftNavigationViewButton.GetComponent<RectTransform>().anchoredPosition
    //            = Vector2.zero;
    //        viewManager.leftNavigationViewButton.GetComponent<RectTransform>().sizeDelta
    //            = Vector2.zero;
    //        viewManager.leftNavigationViewButton.GetComponent<RectTransform>().localScale
    //            = Vector3.one;
    //    }
    //}
}