using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Join1 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision other)
    {
        // smile1 タグのオブジェクト同士での衝突を検出
        if (gameObject.CompareTag("smile1") && other.gameObject.CompareTag("smile1"))
        {
            // 衝突処理を1回だけ行うため、インスタンスIDが小さいオブジェクトのみ処理を実行
            if (gameObject.GetInstanceID() < other.gameObject.GetInstanceID())
            {
                // Resourcesフォルダから "smile2" プレハブを読み込む
                GameObject smile2 = (GameObject)Resources.Load("smile02");

                // 衝突位置の中心と回転を計算
                Vector3 center = (transform.position + other.transform.position) / 2;
                Quaternion rotation = Quaternion.Lerp(transform.rotation, other.transform.rotation, 0.5f);

                // smile2 オブジェクトを生成
                Instantiate(smile2, center, rotation);
            }

            // 現在のオブジェクトと衝突したオブジェクトを削除
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        if (gameObject.CompareTag("smile2") && other.gameObject.CompareTag("smile2"))
        {
            if (gameObject.GetInstanceID() < other.gameObject.GetInstanceID())
            {
                GameObject smile3 = (GameObject)Resources.Load("smile03");

                Vector3 center = (transform.position + other.transform.position) / 2;
                Quaternion rotation = Quaternion.Lerp(transform.rotation, other.transform.rotation, 0.5f);

                Instantiate(smile3, center, rotation);
            }

            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        if (gameObject.CompareTag("smile3") && other.gameObject.CompareTag("smile3"))
        {
            if (gameObject.GetInstanceID() < other.gameObject.GetInstanceID())
            {
                GameObject smile4 = (GameObject)Resources.Load("smile04");

                Vector3 center = (transform.position + other.transform.position) / 2;
                Quaternion rotation = Quaternion.Lerp(transform.rotation, other.transform.rotation, 0.5f);

                Instantiate(smile4, center, rotation);
            }

            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        if (gameObject.CompareTag("smile4") && other.gameObject.CompareTag("smile4"))
        {
            if (gameObject.GetInstanceID() < other.gameObject.GetInstanceID())
            {
                GameObject smile5 = (GameObject)Resources.Load("smile05");

                Vector3 center = (transform.position + other.transform.position) / 2;
                Quaternion rotation = Quaternion.Lerp(transform.rotation, other.transform.rotation, 0.5f);

                Instantiate(smile5, center, rotation);
            }

            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        if (gameObject.CompareTag("smile5") && other.gameObject.CompareTag("smile5"))
        {
            if (gameObject.GetInstanceID() < other.gameObject.GetInstanceID())
            {
                GameObject smile6 = (GameObject)Resources.Load("smile06");

                Vector3 center = (transform.position + other.transform.position) / 2;
                Quaternion rotation = Quaternion.Lerp(transform.rotation, other.transform.rotation, 0.5f);

                Instantiate(smile6, center, rotation);
            }

            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
