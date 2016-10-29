		using UnityEngine;
		using System.Collections;

		public class MapBuilder : MonoBehaviour {

			// spawn background prefabs
			public Transform background;

			// Use this for initialization
			void Start () {
				// instantiate prefabs from camera origin, along the +x axis until the x-start point is > the edge of the camera x-pos
				// then +y
				// repeat until y-start point is > edge of the camera y-pos
				// 6x4 bgs required, each one is 2x2
				int maxX = 6 * 2;
				int maxY = 4 * 2;
					for (int y = 0; y < maxY; y=y+2) {
					
						for (int x = 0; x < maxX; x=x+2) {
						//Quaternion rotate = Quaternion.Euler(0,0,

							Transform go = (Transform) Instantiate(background, new Vector3(x+1, y+1, 0), Quaternion.identity);
				Quaternion rot = Quaternion.identity;
					if (y == 0) {
						//rot = Quaternion.LookRotation (Vector3.down);
						rot *= Quaternion.Euler (0, 0, 180);
						//go.rotation = Quaternion.FromToRotation (go.rotation, rot);
						
					} else if (x == 0) {
					rot *= Quaternion.Euler (0, 0, 90);
					} else if (y == maxY - 2) {
					rot *= Quaternion.Euler (0, 0, 0);
					} else if (x == maxX - 2) {
					rot *= Quaternion.Euler (0, 0, -90);
					}
				go.rotation = rot;
						}
					}

			}
			
			// Update is called once per frame
			void Update () {
			
			}
		}
