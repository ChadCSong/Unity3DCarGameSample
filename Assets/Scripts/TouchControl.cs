using UnityEngine;
using System.Collections;

public class TouchControl : MonoBehaviour {

	CarController _car;
	void Awake(){
		_car = GetComponent<CarController> ();
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	// Subscribe to events  

	void OnEnable(){  

		EasyTouch.On_TouchStart += On_TouchStart;  

	}  

	// Unsubscribe  

	void OnDisable(){  

		EasyTouch.On_TouchStart -= On_TouchStart;  

	}  

	// Unsubscribe  

	void OnDestroy(){  

		EasyTouch.On_TouchStart -= On_TouchStart;  

	}  

	// Touch start event  

	public void On_TouchStart(Gesture gesture){  

		Debug.Log( "Touch in " + gesture.position);  

	}  
	//移动摇杆结束  

	void OnJoystickMoveEnd(MovingJoystick move)  

	{  

		//停止时，角色恢复idle  

		if (move.joystickName == "MoveJoystick")  

		{  


		}  

	}  



	void OnJoystickMove(MovingJoystick move)  

	{  

		Debug.Log ("Arrive");
		//		Debug.Log ("accel:" + accel.ToString());
		if (move.joystickName != "MoveJoystick")  

		{  

			return;  

		}  

		//获取摇杆中心偏移的坐标  

		float joyPositionX = move.joystickAxis.x;  

		float joyPositionY = move.joystickAxis.y;  





		if (joyPositionY != 0 || joyPositionX != 0)  

		{  
			float h = 0;
			float v = 0;
			float handbreak = 0;
			if (joyPositionX > 0) {
				h = 1;
			} else {
				h = -1;
			}

			if (joyPositionY > 0) {
				v = 1;
			} else {
				v = -1;
			}
			_car.CarMove (h,v,v,handbreak);

		}  

	}  
}
