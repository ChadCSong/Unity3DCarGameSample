using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

	public WheelCollider[] _wheelColliders = new WheelCollider[4];
	private Rigidbody carRigidbody;
	private float speed;
	// Use this for initialization
	void Start () {
		carRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void CarMove(float steer,float accel,float footbreak,float handbreak){
		steer = Mathf.Clamp (steer, -1, 1);
		accel = Mathf.Clamp (accel, -1, 1);
		footbreak = Mathf.Clamp (footbreak, -1, 0);
		handbreak = Mathf.Clamp (handbreak, 0, 1);

		if (steer > 0.5 || steer < -0.5) {
			_wheelColliders [0].steerAngle = steer * 10;
			_wheelColliders [1].steerAngle = steer * 10;
		} else {
			_wheelColliders [0].steerAngle = steer * 5;
			_wheelColliders [1].steerAngle = steer * 5;
		}

//		Debug.Log ("steer:" + steer.ToString());
//		Debug.Log ("accel:" + accel.ToString());
//		Debug.Log ("footbreak:" + footbreak.ToString());
//		Debug.Log ("handbreak:" + handbreak.ToString());
//		_wheelColliders [2].motorTorque = accel * 10000f;
//		_wheelColliders [3].motorTorque = accel * 10000f;
		if (accel < 0) {
			_wheelColliders [0].motorTorque = 0 * 10000f;
			_wheelColliders [1].motorTorque = 0 * 10000f;
//			_wheelColliders [2].motorTorque = footbreak * 10000f;
//			_wheelColliders [3].motorTorque = footbreak * 10000f;
			carRigidbody.drag = 10;
		} else {
			if (handbreak != 0) {
				_wheelColliders [0].motorTorque = accel * 10000f;
				_wheelColliders [1].motorTorque = accel * 10000f;
				carRigidbody.drag = 0.05f;
			} else {
				_wheelColliders [0].motorTorque = accel * 30000f;
				_wheelColliders [1].motorTorque = accel * 30000f;
				carRigidbody.drag = 0.05f;
			}
		}



		speed = carRigidbody.velocity.magnitude * 2.23f;
	}

}
