using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEngine;

public class HandTracking : MonoBehaviour
{
    //表示するオブジェクトを定義
    [SerializeField]
    GameObject Cube;

    void Start()
    {
        // Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);  //表示用の立方体を作成
        Cube.SetActive(false);
        Cube.transform.localScale = new Vector3(0.03f, 0.03f, 0.03f);  //大きさを指定
    }

    void Update()
    {
        //右手の人差し指の指先の位置情報を取得
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out MixedRealityPose pose))
        {
            Cube.SetActive(true);
            Cube.transform.position = pose.Position; //座標を設定
            Cube.transform.rotation = pose.Rotation; //回転を設定
        }

        else { 
        Cube.SetActive(false);
        }

    }
}