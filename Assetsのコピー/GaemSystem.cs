using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public static GameSystem instance { get; private set; } = null;   // �V���O���g��

    private void Awake()
    {
        if (instance == null)
        {
            // �C���X�^���X���Ȃ��ꍇ�͑��
            instance = this;

            // �V�[���؂�ւ����ɏ����Ȃ��悤�ɂ���
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            // ����ꍇ�͂Q�ڂȂ̂ŃQ�[���I�u�W�F�N�g������
            Destroy(this.gameObject);

            return;
        }

        // �����ݒ�
        SetFps(60);
    }

    // �t���[�����[�g�̐ݒ�i�P�b�Ԃɉ��� Update �����s����邩�j
    public void SetFps(int fps)
    {
        // Update()�����s��������
        Application.targetFrameRate = fps;

        // FixedUpdate()�����s��������
        Time.fixedDeltaTime = 1.0f / (float)fps;
    }
}