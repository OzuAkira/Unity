using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public static GameSystem instance { get; private set; } = null;   // シングルトン

    private void Awake()
    {
        if (instance == null)
        {
            // インスタンスがない場合は代入
            instance = this;

            // シーン切り替え時に消さないようにする
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            // ある場合は２つ目なのでゲームオブジェクトを消す
            Destroy(this.gameObject);

            return;
        }

        // 初期設定
        SetFps(60);
    }

    // フレームレートの設定（１秒間に何回 Update が実行されるか）
    public void SetFps(int fps)
    {
        // Update()が実行される周期
        Application.targetFrameRate = fps;

        // FixedUpdate()が実行される周期
        Time.fixedDeltaTime = 1.0f / (float)fps;
    }
}