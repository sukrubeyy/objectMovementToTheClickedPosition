# ObjectMovementWithTheMouse
Hi guys let me talk about myself , i from turkey and i'm 22 old. My department is Computer Technology And Information Systems. 
Well , Today i'm gonna show you , how can i object movement to the clicked position. LETS START !

**NOT : If you want to movement object with mouse position you must to remove ---> IF(Input.GetMouseButtonDown(0)){]
New Script 
------------------------------------
movement{
  mousePOS=Camera.Main.ScreenToWorldPoint(Input.mouseposition);
  rb.position=Vector3.Lerp(rb.position,mousePos,.5f);
}
