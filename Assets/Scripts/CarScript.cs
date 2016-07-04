using UnityEngine;
using System.Collections;

public class CarScript : MonoBehaviour {

	CarController _car;
	void Awake(){
		_car = GetComponent<CarController> ();
	}

	void FixedUpdate(){
//		float h = Input.GetAxis("Horizontal");
//		float v = Input.GetAxis("Vertical");
//		float handbreak = Input.GetAxis("Jump");
//		_car.CarMove (h,v,v,handbreak);
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnEnable()  

	{  
		
		EasyJoystick.On_JoystickMove += OnJoystickMove;  
		EasyJoystick.On_JoystickMoveEnd += OnJoystickMoveEnd;  

	}  


	//移动摇杆结束  

	void OnJoystickMoveEnd(MovingJoystick move)  

	{  

		//停止时，角色恢复idle  

		if (move.joystickName == "MovingJoystick")  

		{  


		}  

	}  



	void OnJoystickMove(MovingJoystick move)  

	{  

		Debug.Log ("Arrive");
		//		Debug.Log ("accel:" + accel.ToString());
		if (move.joystickName != "MovingJoystick")  

		{  

			return;  

		}  

		//获取摇杆中心偏移的坐标  

		float joyPositionX = move.joystickAxis.x;  

		float joyPositionY = move.joystickAxis.y;  



		Debug.Log ("joyPositionX:" + joyPositionX);
		Debug.Log ("joyPositionY:" + joyPositionY);

		if (joyPositionY != 0 || joyPositionX != 0)  

		{  
//			float h = 0;
//			float v = 0;
			float handbreak = 0;
//			if (joyPositionX > 0) {
//				h = 1;
//			} else {
//				h = -1;
//			}
//
//			if (joyPositionY > 0) {
//				v = 1;
//			} else {
//				v = -1;
//			}
			_car.CarMove (joyPositionX,joyPositionY,joyPositionY,handbreak);

		}  

	}  

}
