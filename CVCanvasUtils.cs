using UnityEngine;
using System.Collections;
using OpenCVForUnity;
using CVStereoVision;

/*
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * */

namespace CVStereoVision{

	public class CVCanvasUtils{

		Mat canvasSRTMat = Mat.zeros(3,3,CvType.CV_32FC1);

		Vector3 translationVec;
		Vector3 rotationVec;
		Vector3 scaleVec;


		// method for initializing SRT values from Matrix to Vectors

		void initSRTMat(Mat srtMat){
		
			translationVec = getTranslationVec (srtMat);
			rotationVec = getRotationVec (srtMat);
			scaleVec = getScaleVec (srtMat);
		}


		GameObject createCamCanvas(Mat srtMat){
		
			GameObject newCanvas = new GameObject ();




			return newCanvas;

		
		}



		public void transformCanvas(Mat transformMat){
		
		
		}



		public GameObject createMonoCamCanvas(Mat srtMat){

			GameObject monoCamCanvas = new GameObject ();


			return monoCamCanvas;
		
		
		}

		public GameObject createStereoCamCanvas(Mat srtMat){

			GameObject stereoCamCanvas = new GameObject ();


			return stereoCamCanvas;

		}

		// stores translation values from SRT Matrix to Vector

		Vector3 getTranslationVec(Mat srtMat){

			Vector3 transVec;

			transVec.x = (float)srtMat.get (0, 0) [0];
			transVec.y = (float)srtMat.get (0, 1) [0];
			transVec.z = (float)srtMat.get (0, 2) [0];

			return transVec;

		}

		// stores rotation values from SRT Matrix to Vector
		
		Vector3 getRotationVec(Mat srtMat){
			
			Vector3 rotVec;
			
			rotVec.x = (float)srtMat.get (1, 0) [0];
			rotVec.y = (float)srtMat.get (1, 1) [0];
			rotVec.z = (float)srtMat.get (1, 2) [0];
			
			return rotVec;
			
		}

		// stores scale values from SRT Matrix to Vector
		
		Vector3 getScaleVec(Mat srtMat){
			
			Vector3 scaleVec;
			
			scaleVec.x = (float)srtMat.get (2, 0) [0];
			scaleVec.y = (float)srtMat.get (2, 1) [0];
			scaleVec.z = (float)srtMat.get (2, 2) [0];
			
			return scaleVec;
			
		}



	}
}